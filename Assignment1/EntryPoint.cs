using System;
using Login;
using Game;
using calculator;

namespace entry
{
    class program{
        static void Main(string[] args){
            Console.WriteLine("\tPlease Choose a number: ");
            Console.WriteLine("[1] Login System (challenge 1)");
            Console.WriteLine("[2] Game Highscore (challenge 2)");
            Console.WriteLine("[3] Calculator (challenge 3)");

            string choice = Console.ReadLine();
            switch(choice){
                case "1":
                    user.StartLogin();
                    break;
                case "2":
                    Player.startGame();
                    break;
                case "3":
                    calc.StartCalculator();
                    break;
                default:
                    Console.WriteLine("Error: Invalid Input please Choose From the Available options");
                    break;

            }


        }
    }
}