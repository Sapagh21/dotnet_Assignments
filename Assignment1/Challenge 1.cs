/* 
Problem Statement : 
Create a user Login System, where the user can first register and
then Login in. The Program should check if the user has entered the
correct username and password, when login in (so the same ones
that he used when registering).
As we haven't covered storing data yet, just create the program in a
way, that registering and logging in, happen in the same execution of
it.
User If statements and User Input and Methods to solve the
challenge.

*/


using System; 
namespace Login
{
    class user
    {  
        public static void StartLogin()
        { 
            Console.WriteLine("\t Registration\n\tPlease Enter Your Information");
            
            string username,pass;
            username=pass = "";
            
            while(pass.Length == 0 || username.Length == 0){
                Console.Write("Username: ");
                username = Console.ReadLine();
                Console.Write("Password: ");
                pass = Console.ReadLine()  ;    
                if(pass.Length == 0 || username.Length == 0){
                    Console.WriteLine("Please Don\'t Enter an Empty Value");
                }
            }
            
            Console.WriteLine($"User Successfully Registred\nusername{username}\nPassword{pass}");
            string inputUsername = "";
            string inputPass = "";
            string msg= "";

            while((inputUsername != username) || (inputPass != pass)){ 
                Console.WriteLine("\t Login\n\tPlease Enter Your Information");
                Console.Write("Username: ");
                inputUsername = Console.ReadLine();
                Console.Write("Password: ");
                inputPass = Console.ReadLine();

                if((inputUsername == username) && (inputPass == pass)){
                    msg = "\nLogin Success";
                }else{
                    msg = "\nPlease Try Again, Password or userame are wrong";
                }
                Console.WriteLine(msg);
            }
        }

    }
}
