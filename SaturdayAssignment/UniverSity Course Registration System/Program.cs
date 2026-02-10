using System;
using System.Collections.Generic;
using System.Linq;
namespace University_Course_Registration_System
{
    class Program
    {
        static void Main()
        {
            UniversitySystem system = new UniversitySystem();
            bool exit = false;
            Console.WriteLine("Welcome to University Course Registration System");

            while (!exit)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Course");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Register Student for Course");
                Console.WriteLine("4. Drop Student from Course");
                Console.WriteLine("5. Display All Courses");
                Console.WriteLine("6. Display Student Schedule");
                Console.WriteLine("7. Display System Summary");
                Console.WriteLine("8. Exit");
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter Course Code: ");
                            string ccode = Console.ReadLine();
                            Console.Write("Enter Course Name: ");
                            string cname = Console.ReadLine();
                            Console.Write("Enter Credits: ");
                            int credits = int.Parse(Console.ReadLine());
                            Console.Write("Enter Max Capacity (default 50): ");
                            string capInput = Console.ReadLine();
                            int capacity = string.IsNullOrEmpty(capInput) ? 50 : int.Parse(capInput);
                            Console.Write("Enter Prerequisites (comma-separated, or Enter for none): ");
                            string pre = Console.ReadLine();
                            List<string> prereq = string.IsNullOrEmpty(pre)
                                ? new List<string>()
                                : pre.Split(',').Select(x => x.Trim()).ToList();

                            system.AddCourse(ccode, cname, credits, capacity, prereq);
                            Console.WriteLine("Course added successfully.");
                            break;
                        case "2":
                            Console.Write("Enter Student ID: ");
                            string sid = Console.ReadLine();
                            Console.Write("Enter Name: ");
                            string sname = Console.ReadLine();
                            Console.Write("Enter Major: ");
                            string major = Console.ReadLine();
                            Console.Write("Enter Max Credits (default 18): ");
                            string maxC = Console.ReadLine();
                            int maxCredits = string.IsNullOrEmpty(maxC) ? 18 : int.Parse(maxC);
                            Console.Write("Enter Completed Courses (comma-separated, or Enter for none): ");
                            string comp = Console.ReadLine();
                            List<string> completed = string.IsNullOrEmpty(comp)
                                ? new List<string>()
                                : comp.Split(',').Select(x => x.Trim()).ToList();

                            system.AddStudent(sid, sname, major, maxCredits, completed);
                            Console.WriteLine("Student added successfully.");
                            break;
                        case "3":
                            Console.Write("Enter Student ID: ");
                            string rsid = Console.ReadLine();
                            Console.Write("Enter Course Code: ");
                            string rccode = Console.ReadLine();
                            system.RegisterStudentForCourse(rsid, rccode);
                            break;
                        case "4":
                            Console.Write("Enter Student ID: ");
                            string dsid = Console.ReadLine();
                            Console.Write("Enter Course Code: ");
                            string dccode = Console.ReadLine();
                            system.DropStudentFromCourse(dsid, dccode);
                            break;
                        case "5":
                            system.DisplayAllCourses();
                            break;
                        case "6":
                            Console.Write("Enter Student ID: ");
                            string ssid = Console.ReadLine();
                            system.DisplayStudentSchedule(ssid);
                            break;
                        case "7":
                            system.DisplaySystemSummary();
                            break;

                        case "8":
                            exit = true;
                            Console.WriteLine("Exiting system...");
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
