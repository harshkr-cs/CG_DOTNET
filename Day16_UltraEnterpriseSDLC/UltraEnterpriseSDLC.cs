using System;
using System.Collections.Generic; 
using System.Linq;


namespace UltraEnterpriseSDLC{
    //Represents the business risk associated with a requirement.
    enum RiskLevel{
        Low,
        Medium,
        High,
        Critical
    }
    
    //enums are integer types by default
    //Defines the strict lifecycle progression of a software work item.
    enum SDLCStage{
        Backlog=1,
        Requirement=2,
        Design=3,
        Development=4,
        CodeReview=5,
        Testing=6,
        UAT=7,
        Deployment=8,
        Maintenance=9
    }

    sealed class Requirement{
        public int Id{get; }
        public string Title{get; }
        public RiskLevel Risk{get; }

        public Requirement(int id,string title,RiskLevel risk){
            Id=id;
            Title=title;
            Risk=risk;
        }
    }

    sealed class WorkItem{
        public int Id{get; }
        public string Name{get; }
        public SDLCStage Stage{get; set;}
        public HashSet<int> DependencyIds { get; set; } = new HashSet<int>();

        public WorkItem(int id,string name,SDLCStage stage){
            Id=id;
            Name=name;
            Stage=stage;
            // Default values
            DependencyIds = new HashSet<int>();
        }

    } 

    sealed class BuildSnapshot{
        public string Version{get; }
        public DateTime Timestamp{get; }
        
        public BuildSnapshot(string version){
            Version=version;
            Timestamp=DateTime.Now;
        }
    }

    sealed class AuditLog{
        public DateTime Time{get; }
        public string Action{get; }
        
        public AuditLog(string action){
            Time= DateTime.Now;
            Action=action;
        }
    }

     sealed class QualityMetric{
        public string Name{get; }
        public double Score{get; }
        
        public QualityMetric(string name,double score){
            Name=name;
            Score=score;
        }
    }

    sealed class EnterpriseSDLCEngine{
        private List<Requirement> _requirements;
        private Dictionary<int, WorkItem> _workItemRegistry;
        private SortedDictionary<SDLCStage, List<WorkItem>> _stageBoard;
        private Queue<WorkItem> _executionQueue;
        private Stack<BuildSnapshot> _rollbackStack;
        private HashSet<string> _uniqueTestSuites;
        private LinkedList<AuditLog> _auditLedger;
        private SortedList<double, QualityMetric> _releaseScoreboard;
        private int _requirementCounter;
        private int _workItemCounter;

        public EnterpriseSDLCEngine()
        {
            _requirements = new List<Requirement>();
            _workItemRegistry = new Dictionary<int, WorkItem>();
            _stageBoard = new SortedDictionary<SDLCStage, List<WorkItem>>();

            foreach (SDLCStage stage in Enum.GetValues(typeof(SDLCStage)))
            {
                _stageBoard[stage] = new List<WorkItem>();
            }

            _executionQueue = new Queue<WorkItem>();
            _rollbackStack = new Stack<BuildSnapshot>();
            _uniqueTestSuites = new HashSet<string>();
            _auditLedger = new LinkedList<AuditLog>();
            _releaseScoreboard = new SortedList<double, QualityMetric>();
            _requirementCounter = 0;
            _workItemCounter = 0;
        }

        public void AddRequirement(string title, RiskLevel risk){
            var req = new Requirement(_requirementCounter++, title, risk);
            _requirements.Add(req);
            _auditLedger.AddLast(new AuditLog($"Requirement added: {title}, Risk={risk}"));
        }

        public WorkItem CreateWorkItem(string name, SDLCStage stage)
        {
            var item = new WorkItem(_workItemCounter++, name, stage);
            _workItemRegistry[item.Id] = item;
            _stageBoard[stage].Add(item);
            _auditLedger.AddLast(new AuditLog($"WorkItem created: {name}, Stage={stage}"));
            return item;
        }

        public void AddDependency(int workItemId, int dependsOnId)
        {
            if (!_workItemRegistry.ContainsKey(workItemId) ||
                !_workItemRegistry.ContainsKey(dependsOnId))
                return;

            _workItemRegistry[workItemId].DependencyIds.Add(dependsOnId);
            _auditLedger.AddLast(
                new AuditLog($"Dependency added: WorkItem {workItemId} depends on {dependsOnId}")
            );
        }

        public void PlanStage(SDLCStage stage)
        {
            var eligibleItems = _stageBoard[stage]
                .Where(w =>
                    w.DependencyIds.All(depId =>
                        _workItemRegistry[depId].Stage > stage))
                .ToList();

            foreach (var item in eligibleItems)
            {
                _executionQueue.Enqueue(item);
            }

            _auditLedger.AddLast(new AuditLog($"Stage planned: {stage}"));
        }

        public void ExecuteNext()
        {
            if (_executionQueue.Count == 0)
                return;

            var item = _executionQueue.Dequeue();
            var previousStage = item.Stage;
            item.Stage++;

            _stageBoard[previousStage].Remove(item);
            _stageBoard[item.Stage].Add(item);

            _auditLedger.AddLast(
                new AuditLog($"Executed WorkItem {item.Id}: {previousStage} → {item.Stage}")
            );
        }

        public void RegisterTestSuite(string suiteId)
        {
            if (_uniqueTestSuites.Add(suiteId))
            {
                _auditLedger.AddLast(new AuditLog($"Test suite registered: {suiteId}"));
            }
        }

        public void DeployRelease(string version)
        {
            var snapshot = new BuildSnapshot(version);
            _rollbackStack.Push(snapshot);
            _auditLedger.AddLast(new AuditLog($"Release deployed: {version}"));
        }

        public void RollbackRelease()
        {
            if (_rollbackStack.Count == 0)
                return;

            var snapshot = _rollbackStack.Pop();
            _auditLedger.AddLast(
                new AuditLog($"Rollback executed for version: {snapshot.Version}")
            );
        }

        public void RecordQualityMetric(string metricName, double score)
        {
            if (_releaseScoreboard.ContainsKey(score))
                return;

            _releaseScoreboard.Add(score, new QualityMetric(metricName, score));
        }

        public void PrintAuditLedger()
        {
            foreach (var log in _auditLedger)
            {
                Console.WriteLine($"{log.Time}: {log.Action}");
            }
        }

        public void PrintReleaseScoreboard()
        {
            foreach (var entry in _releaseScoreboard.Reverse())
            {
                Console.WriteLine($"{entry.Value.Name} → {entry.Key:F2}");
            }
        }

    }

}