using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 25;
            int number2 = 50;
            int total = Add(number1, number2); //calling the method that we want to run
            Console.WriteLine(total);
            Console.WriteLine(Multiply(number1,number2)); //don't have to create a variable but once the code runs it, 
                                                          //it doesn't exist anymore. if you want to store thay value for
                                                          //future use, set a variable for it so you can access later
            Greeting();
            string name = "Will I. Am";
            RobotWarning(name);

        }

        public static int Add(int firstNumber, int secondNumber) //creating the method
        { 
            int sum = firstNumber + secondNumber; //what the method will do, what it will execute
            return sum; //what the method will output
        }

        public static int Multiply(int firstNumber, int secondNumber)
        {
            int product = firstNumber * secondNumber;
            return product;
        }
        
        public static void Greeting() //use void when you don't want to return anything
        {
            Console.WriteLine("Hello World!"); //not returning, it is just posting to console
        }

        public static void RobotWarning (string name)
        {
            Console.WriteLine("Danger, "+name); //console.writeline is in the method so you don't need to call it in main
            //you just call the method
        }
    }
}
