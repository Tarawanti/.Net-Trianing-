using System;
 

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            
            //adding new line 
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            //Console.WriteLine("You name is :"+name);
            Console.WriteLine("Enter your age");
            string age = Console.ReadLine();
            int intAge = Convert.ToInt32(age);
            //Console.WriteLine("Your age is :" + age);
            Console.WriteLine("Enter your Favorite Colo");
            string FavtColor = Console.ReadLine();
           // Console.BackgroundColor = ConsoleColor.Blue;
           // Console.Clear();


            Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), FavtColor);
            Console.Clear();



            if (intAge>=21)
            {
                Console.WriteLine(" have Beer if You want");
                Console.WriteLine("\n\n You name is :" + name);
                Console.WriteLine("Your age is :" + age);
                Console.WriteLine("Your Favorite Color  is :" + FavtColor);
               

            }
            else 
            {

                Console.WriteLine(" have Root Beer");

                Console.WriteLine("\n\n You name is :" + name);
                Console.WriteLine("Your age is :" + age);
                Console.WriteLine("Your Favorite Color  is :" + FavtColor);
            }




        }
    }
}


