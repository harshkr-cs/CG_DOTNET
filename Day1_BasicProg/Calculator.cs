using System;
namespace HelloWorldApp{
    class Calculator{
        // int num1;
        // int num2;
        int result;
       
       //program to perform basic arithmetic operations using methods(calculator)
        public void Add(int num1, int num2){
           result = num1 + num2;
            Console.WriteLine("Sum: " + result);
        }
        public void Subtract(int num1, int num2){
            result = num1 - num2;
            Console.WriteLine("Difference: " + result);
        }
        public void Multiply(int num1, int num2){
            result = num1 * num2;
            Console.WriteLine("Product: " + result);
        }
        public void Divide(int num1, int num2){
            if(num2 == 0){
                Console.WriteLine("Error: Division by zero is not allowed.");
                return;
            }
            result = num1 / num2;
            Console.WriteLine("Quotient: " + result);
        }

        public void Modulus(int num1, int num2){
            if(num2 == 0){
                Console.WriteLine("Error: Modulus by zero is not allowed.");
                return;
            }
            result = num1 % num2;
            Console.WriteLine("Remainder: " + result);
        }
    }

}