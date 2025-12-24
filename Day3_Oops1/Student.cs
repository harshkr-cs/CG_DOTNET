using System;
class Student
{
    // Private fields (data hiding)
    private string name;
    private int age;
    private int marks;
    private int id;
    private string password;
   
    // PART A: Auto-Implemented Property
    public int StudentId { get; set; }

    // Property for Name
    public string Name{
        get{
            return name;
        }
        set{
            if (!string.IsNullOrEmpty(value)){
                name = value;
            }
        }
    }

    // Property for Age
    public int Age{
        get{
            return age;
        }
        set{
            if (value > 0){
                age = value;
            }
        }
    }

    // Property for Marks
    public int Marks{
        get{
            return marks;
        }
        set{
            if (value >= 0 && value <= 100){
                marks = value;
            }
        }
    }
    //Normal Property-for ID
    // public int ID{
    //     get{
    //         return id;
    //     }
    //     set{
    //         if (value > 0){
    //             id = value;
    //         }
    //     }
    // }
    // PART B: Read-Only Property
    public string Result{
        get{
            return marks >= 40 ? "Pass" : "Fail";
        }
    }


    // PART C: Write-Only Property for Password
    public string Password{
        // get{
        //     return password;
        // }
        set{
            if (value.Length>=6){
                password = value;
            }
        }
    }
    
    //What is init in C#?
    // init is an init-only setter (introduced in C# 9.0).
    // It allows a property to be:
    // Assigned only during object initialization
    // Read-only after the object is created
    // public int RollNo { get; init; }
    // public string name1 { get; init; }
    
    //indexer:An indexer allows an object to be accessed like an array, using square brackets [].
    private string[] students = new string[3];
    public string this[int index]{
        get{
            if (index < 0 || index >= students.Length)
                return "Invalid Index";
            return students[index];
        }
        set{
            if (index >= 0 && index < students.Length)
                students[index] = value;
        }
    }
}