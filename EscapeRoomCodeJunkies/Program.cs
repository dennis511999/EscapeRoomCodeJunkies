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
            string command;
            

            Console.WindowHeight = 20;
            Console.WindowWidth = 128;
            string strMenuText = System.IO.File.ReadAllText(@"../../Menu.txt");
            Console.WriteLine(strMenuText);
            Console.SetCursorPosition(2, 17);
            Console.ReadLine();

            Console.Clear();

            string strIntroText = "Intro: \n" +
            "It’s the year 1888. \n" +
            "It's 2:00 am when you left the pub.\n" +
            "You walk through a dark alley when suddenly you got hit from behind on your head.\n" +
            "You slowly regained conciousness.\n" +
            "Where am I? \n" +
            "Old man: you have been captured by me. \n" +
            "Find your way out of my sewers, if you can that is. \n" +
            "I will give you a hint. \n" +
            "Start by finding the code to open your cell door. \n";



            for (int i = 0; i < strIntroText.Length; i++)
            {
                Console.Write(strIntroText[i]);
                Thread.Sleep(0);
            }

            Console.ReadLine();

            Console.Clear();

            string strBasementText = System.IO.File.ReadAllText(@"../../Basement.txt");
            Console.WriteLine(strBasementText);
            Console.SetCursorPosition(2, 17);


            string strCellText = "1. Search the cell \n" +
                                 "2. Try the lock \n";

            for (int i = 0; i < strCellText.Length; i++)
            {
                Console.Write(strCellText[i]);
                Thread.Sleep(0);
                
            }

            command = Console.ReadLine();

            if (command == "1")
            {

            }
            else
            {
                
                
                
            }
            
            

            
            

            


            Console.Clear();
            string strHallText = System.IO.File.ReadAllText(@"../../Hall.txt");
            Console.WriteLine(strHallText);
            Console.SetCursorPosition(2, 17);

            switch (Console.ReadLine())
            {
                case "1":
                    {
                        Program.Dining();
                        break;
                    }
                    

                case "2":
                    {
                        Program.Livingroom();
                        break;
                    }
                    

                case "3":
                    {
                        Program.Mortuarium();
                        break;
                    }
                    

                case "4":
                    {
                        Program.Toilet();
                        break;
                    }
                    
            }

            
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

        static void Dining()
        {
            Console.Clear();
            string strDiningRoomTxt = System.IO.File.ReadAllText(@"../../DiningroomA.txt");
            Console.Write(strDiningRoomTxt);
            Console.SetCursorPosition(2, 17);
            Console.ReadLine();
            
        }

        static void Livingroom()
        {
            Console.Clear();
            string strLivingRoomTxt = System.IO.File.ReadAllText(@"../../LivingRoom.txt");
            Console.Write(strLivingRoomTxt);
            Console.SetCursorPosition(2, 17);
            Console.ReadLine();
        }

        static void Mortuarium()
        {
            Console.Clear();
            string strMortuariumTxt = System.IO.File.ReadAllText(@"../../Mortuarium.txt");
            Console.Write(strMortuariumTxt);
            Console.SetCursorPosition(2, 17);
            Console.ReadLine();
        }

        static void Toilet()
        {
            Console.Clear();
            string strToiletTxt = System.IO.File.ReadAllText(@"../../Toilet.txt");
            Console.Write(strToiletTxt);
            Console.SetCursorPosition(2, 17);
            Console.ReadLine();
        }
        
    }
}
        

   


