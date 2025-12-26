using System;

// Compile-Time Polymorphism (Method Overloading)
// Run-Time Polymorphism (Method Overriding)

//Method Overloading:Multiple methods with the same name but different parameters.
class MethodOverloading{
    
    public int Add(int a, int b){
        return a + b;
    }

    public double Add(double a, double b){
        return a + b;
    }

    public int Add(int a, int b, int c){
        return a + b + c;
    }
    public string Add(string value1, string value2){  
            return (value1 + " " + value2);  
        }  

}
// Method Overriding:A derived class can modify the behavior of a base class method.
// Uses inheritance
// Requires virtual and override
// Decision happens at runtime
public class Drawing{
    // Virtual method
    public virtual double Area()
    {
        return 0;
    }
}

// ---------------- CIRCLE ----------------
public class Circle : Drawing{
    public double Radius { get; set; }

    public Circle(){
        Radius = 5;
    }

    public override double Area(){
        return Math.PI * Math.Pow(Radius, 2);
    }
}

// ---------------- SQUARE ----------------
public class Square : Drawing{
    public double Length { get; set; }

    public Square(){
        Length = 6;
    }

    public override double Area(){
        return Math.Pow(Length, 2);
    }
}

// ---------------- RECTANGLE ----------------
public class Rectangle : Drawing{
    public double Height { get; set; }
    public double Width { get; set; }

    public Rectangle(){
        Height = 5.3;
        Width = 3.4;
    }

    public override double Area(){
        return Height * Width;
    }
}

//Method Overriding
// Base Class
class Animal
{
    public virtual void Sound(){
        Console.WriteLine("Animal makes sound");
    }
}
// Derived Class
class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}

//Using base Keyword
class Dog1 : Animal{
    public override void Sound()
    {
        base.Sound();//calls parent method
        Console.WriteLine("Dog barks");
    }
}


