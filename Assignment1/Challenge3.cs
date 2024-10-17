/* 
Problem Statement : 
In this task, you are to create a basic calculator using a switch
statement that performs arithmetic operations like addition,
subtraction, multiplication, and division based on user input.
Requirements:
1- The calculator should take two numbers as input.

2- The user should choose an operation from the following:

+ for addition

- for subtraction

* for multiplication
/ for division

3- If the user inputs a character other than these operations, the
program should handle it by showing an error message.

4- If the user tries to divide by zero, display an error message.
*/

using System; 
namespace calculator
{
    class calc
    {
       public static void StartCalculator(){
            Console.WriteLine("Enter The Two numbers");
            Console.Write("First Number: ");
            double num1 = Convert.ToDouble( Console.ReadLine());

            Console.Write("Second Number: ");
            double num2 = Convert.ToDouble( Console.ReadLine());

            Console.Write("What operation Do you want to perform? ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine($"{num1} + {num2} = {num1+num2}");
                    break;
                case "-":
                    Console.WriteLine($"{num1} - {num2} = {num1-num2}");
                    break;
                case "*":
                    Console.WriteLine($"{num1} * {num2} = {num1*num2}");
                    break;
                case "/":
                    // double tnum2 = Convert.ToDouble(num2);

                    if (num2 != 0){
                        Console.WriteLine($"{num1} / {num2} = {num1/num2}");
                    }else{
                        Console.WriteLine("You can't divide by zero");
                    }                       
                    break;
                default:
                Console.WriteLine("Error : Invalid Input");
                break;
            }
        }

    }
}
