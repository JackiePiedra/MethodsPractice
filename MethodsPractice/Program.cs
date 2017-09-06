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

            string foodType = "Wine";
            string foodName = "Cabernet Sauvignon";
            FavoriteFood(foodType, foodName);

            Console.WriteLine("Please enter your age:");
            int userAge = int.Parse(Console.ReadLine());
            RetirementCalculator(userAge);

            double hoursWorked = 240d;
            double hourlyWage = 25d;
            WageCalculator(hoursWorked, hourlyWage);

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
        
        //create a method called FavoriteFood
        //it should take two string parameters
        //type of the food and the other being the name of the food
        //it should be void return type
        //the method should concatenate the two values

        public static void FavoriteFood (string firstFood, string secondFood)
        {
            Console.WriteLine(firstFood+": "+secondFood);
        }

        /*create a method called RetirementCalculator
         * it should take an int as a parameter representing the user's age. 
         * the method should calculate how many more years until the user retires using 65 as the retirement age.
         * the return type should be void. 
         * once it caluclates the users retirement age it should print:
         * The user will retire in X years, where X represents the value that was calculated */
        public static void RetirementCalculator (int userAge)
        {
            int retirementAge = 65;
            int yearsToRetire = retirementAge - userAge;
            Console.WriteLine("The user will retire in " + yearsToRetire + " years.");
        }


        //Wage Caluclator -- take 2 double parameters, one represents hours worked, the other hourly wage.
        //return type should be of type double. method should calculate monthly wage.
        //once it calculates, it should return that value
        public static double WageCalculator(double hoursWorked, double hourlyWage)
        {
            double monthlyWage = hoursWorked * hourlyWage;
            return monthlyWage;
        }

        //create two methods of your choosing. at least one should have a non void return type.
        //both should take at least one parameter
        public static void
        
    }
}
