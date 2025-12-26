using System;
//indexer 
class EmployeeDirectory{
    //Read-Only Indexer->An indexer can be read-only by removing the set accessor.
    // private double[] marks = { 80, 90, 85 };

    // public double this[double index]{
    //     get { return marks[index]; }
    // }
    //indexer overloading
    private Dictionary<int, string> employees = new Dictionary<int, string>();

    public string this[int id]
    {
        get { return employees[id]; }
        set { employees[id] = value; }
    }

    public string this[string name]
    {
        get
        {
            return employees.FirstOrDefault(e => e.Value == name).Value;
        }
    }
}