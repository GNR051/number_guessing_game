using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace number_guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "number_guessing_game";
            int me = 0;
            int pc = 0;


            for (int i = 1; i <= 5; i++)
            {

                Random rnd = new Random();
                int number1 = rnd.Next(1, 6);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Please Enter a Number Between 1 and 5: ");
                int number2 = Convert.ToInt32(Console.ReadLine());

                if (number1 == number2)
                {
                    me++;
                    Console.Clear();
                    Console.WriteLine("Congratulations you won...");
                    Console.WriteLine("Computer's choice: " + number1);
                    Console.WriteLine("Your choice: " + number2);
                    Thread.Sleep(2000);
                    Console.Clear();
                }

                else

                {
                    pc++;
                    Console.Clear();
                    Console.WriteLine("You lost :-( ");
                    Console.WriteLine("Computer's choice: " + number1);
                    Console.WriteLine("Your choice: " + number2);
                    Thread.Sleep(2000);
                    Console.Clear();
                }

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("************** Score **************");
                Console.WriteLine("My Score  : " + me);
                Console.WriteLine("PC Score : " + pc);
                Console.WriteLine("*****************************************");
            }

            if (me<pc)
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("GAME RESULT: YOU LOSE!!!");
                Console.WriteLine("My Score : " + me);
                Console.WriteLine("PC Score: " + pc);
            }

            else
            {

                Console.Clear();
                Console.WriteLine("GAME RESULT: YOU WON!!!");
                Console.WriteLine("My Score : " + me);
                Console.WriteLine("PC Score : " + pc);
            }

            Console.ReadLine();
        }
    }
}
