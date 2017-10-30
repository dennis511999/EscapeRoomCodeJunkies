using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;



namespace EscapeRoomCodeJunkies
{
    class Program
     {
        public static bool Escape { get; private set; }


        static void Main(string[] args)
        {

            Console.WindowHeight = 20;
            Console.WindowWidth = 128;
            string strMenuText = System.IO.File.ReadAllText(@"../../Menu.txt");
            Console.WriteLine(strMenuText);
            Console.SetCursorPosition(2, 17);
            Console.ReadLine();

            Console.Clear();

            string strText = "Intro: \n" +
            "It’s the year 1888. \n" +
            "It's 2:00 am when you left the pub.\n" +
            "You walk through a dark alley when suddenly you got hit from behind on your head.\n" +
            "You slowly regained conciousness.\n" +
            "Where am I? \n" +
            "Old man: you have been captured by me. \n" +
            "Find your way out of my sewers, if you can that is. \n" +
            "I will give you a hint. \n" +
            "Start by finding the key to open your cell door. \n";

            for (int i = 0; i < strText.Length; i++)
            {
                Console.Write(strText[i]);
                Thread.Sleep(0);
            }

            Console.ReadLine();

            Console.Clear();
            string strBasementText = System.IO.File.ReadAllText(@"../../Basement.txt");
            Console.WriteLine(strBasementText);
            Console.ReadLine();
            Console.Clear();
            string strHallText = System.IO.File.ReadAllText(@"../../Hall.txt");
            Console.WriteLine(strHallText);
            Console.ReadLine();



            






            string command;
            command = Console.ReadLine();

            do
            {
                if (Escape == true)
                {
                    Console.Clear();
                    Console.WriteLine("Congratulations! You Made it out! ");
                    Console.WriteLine("Press any key to exit ");
                    Console.ReadLine();

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You didn't make it out in time, want to try again? (Y/N) ");

                }


            }
            while (command == "Y");



        }
    }
}
