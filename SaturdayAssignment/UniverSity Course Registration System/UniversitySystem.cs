using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    // =========================
    // University System Class
    // =========================
    public class UniversitySystem
    {
        public Dictionary<string, Course> AvailableCourses { get; private set; }
        public Dictionary<string, Student> Students { get; private set; }

        public UniversitySystem()
        {
            AvailableCourses = new Dictionary<string, Course>();
            Students = new Dictionary<string, Student>();
        }

        public void AddCourse(string code, string name, int credits, int maxCapacity = 50, List<string> prerequisites = null)
        {
            // TODO:
            // 1. Throw ArgumentException if course code exists
            // 2. Create Course object
            // 3. Add to AvailableCourses
            foreach(var it in AvailableCourses)
            {
                if(it.Value.CourseCode==code) throw new ArgumentException("Not found");
            }
            Course c=new Course(code,name,credits,maxCapacity,prerequisites);
            AvailableCourses.Add(code,c);
            throw new NotImplementedException();
        }

        public void AddStudent(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
        {
            // TODO:
            // 1. Throw ArgumentException if student ID exists
            // 2. Create Student object
            // 3. Add to Students dictionary
            foreach(var it in Students)
            {
                if(it.Value.StudentId==id) throw new ArgumentException("Student ID exist");
            }
            Student s=new Student(id,name,major,maxCredits,completedCourses);
            Students.Add(id,s);
            throw new NotImplementedException();
        }

        public bool RegisterStudentForCourse(string studentId, string courseCode)
        {
            // TODO:
            // 1. Validate student and course existence
            // 2. Call student.AddCourse(course)
            // 3. Display meaningful messages
            if(!Students.ContainsKey(studentId)) return false;
            if(!AvailableCourses.ContainsKey(courseCode)) return false;
            Student student = Students[studentId];
            Course course = AvailableCourses[courseCode];
            // 3. Try to add course
            if (!student.CanAddCourse(course))
            {
                return false;
            }

            if (course.IsFull())
            {
                return false;
            }

            student.AddCourse(course);
            Console.WriteLine("Registration successful.");
            return true;
            throw new NotImplementedException();
        }

        public bool DropStudentFromCourse(string studentId, string courseCode)
        {
            // TODO:
            // 1. Validate student existence
            // 2. Call student.DropCourse(courseCode)
            if(!Students.ContainsKey(studentId)) return false;
            bool result = Students[studentId].DropCourse(courseCode);
            if(result) return true;
            return false;
            throw new NotImplementedException();
        }

        public void DisplayAllCourses()
        {
            // TODO:
            // Display course code, name, credits, enrollment info
            foreach(var it in AvailableCourses)
            {
                Console.WriteLine(it.Value.CourseCode+" "+it.Value.CourseName+" "+it.Value.Credits+it.Value.GetEnrollmentInfo());
            }
            throw new NotImplementedException();
        }

        public void DisplayStudentSchedule(string studentId)
        {
            // TODO:
            // Validate student existence
            // Call student.DisplaySchedule()
            if (!Students.ContainsKey(studentId))
            {
                return;
            }
            Students[studentId].DisplaySchedule();
            throw new NotImplementedException();
        }

        public void DisplaySystemSummary()
        {
            // TODO:
            // Display total students, total courses, average enrollment
    
            Console.WriteLine("\nSystem Summary:");
            Console.WriteLine($"Total Students: {Students.Count}");
            Console.WriteLine($"Total Courses : {AvailableCourses.Count}");
            Console.WriteLine($"Average Enrollment: {Students.Count/AvailableCourses.Count}");
            throw new NotImplementedException();
        }
    }
}
