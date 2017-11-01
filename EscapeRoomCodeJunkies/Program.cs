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

            Thread.Sleep(1000);

            Console.Clear();

            string strBasementText = System.IO.File.ReadAllText(@"../../Basement.txt");
            Console.WriteLine(strBasementText);
            Console.SetCursorPosition(2, 17);


            
       
            Console.WriteLine("You search the cell. \n"+ "And guess what, you found a book." );
            Console.WriteLine("");
            Program.Book();
            Console.Clear();
            Console.WriteLine(" ");
            Console.WriteLine("There is a hint written in the book. \n"+ "First is bad, Last is good.\n" + "a = 1, z = 26");
            Console.WriteLine("");
            Console.WriteLine("You looked at the lock. \n" +"Its need a six digit number to unlock.");
            
            
            
               
            Console.WriteLine("1. Do you want to open the book again?");
            Console.WriteLine("2. Try the lock");
            

            command = Console.ReadLine();

            if (command == "1")
            {
                Program.Book();
            }
            else
            {

            }

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Enter the code");
                command = Console.ReadLine();
                if (command == "111155")
                {
                    Console.WriteLine("Good job you opend the cell.");

                }
                else
                {
                    Console.WriteLine("Press (Y) to try again");
                    command = Console.ReadLine();
                }
            } while (command == "y");



            

            do
            {

                Console.Clear();
                string strHallText = System.IO.File.ReadAllText(@"../../Hall.txt");
                Console.WriteLine(strHallText);
                Console.SetCursorPosition(2, 17);
                Console.WriteLine("You are in the Hall.");
                Console.WriteLine("1. Enter the dining room.");
                Console.WriteLine("2. Enter the Living room.");
                Console.WriteLine("3. Enter the Mortuarium.");
                Console.WriteLine("4. Enter the Toilet");

                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Program.Dining();
                            Console.WriteLine("You have entered the Dining room.");
                            Console.WriteLine("b. To go back");
                            command = Console.ReadLine();
                            break;
                        }


                    case "2":
                        {
                            Program.Livingroom();
                            Console.WriteLine("You have entered the Living room.");
                            Console.WriteLine("b. To go back");
                            command = Console.ReadLine();
                            break;
                        }


                    case "3":
                        {
                            Program.Mortuarium();
                            Console.WriteLine("You have entered the Mortuarium.");
                            Console.WriteLine("b. To go back");
                            command = Console.ReadLine();
                            break;
                        }


                    case "4":
                        {
                            Program.Toilet();
                            Console.WriteLine("You have entered the toilet.");
                            Console.WriteLine("b. To go back");
                            command = Console.ReadLine();
                            break;
                        }

                }
                
            } while (command == "b");



            
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
            
            
        }

        static void Livingroom()
        {
            Console.Clear();
            string strLivingRoomTxt = System.IO.File.ReadAllText(@"../../LivingRoom.txt");
            Console.Write(strLivingRoomTxt);
            Console.SetCursorPosition(2, 17);
            
        }

        static void Mortuarium()
        {
            Console.Clear();
            string strMortuariumTxt = System.IO.File.ReadAllText(@"../../Mortuarium.txt");
            Console.Write(strMortuariumTxt);
            Console.SetCursorPosition(2, 17);
            
        }

        static void Toilet()
        {
            Console.Clear();
            string strToiletTxt = System.IO.File.ReadAllText(@"../../Toilet.txt");
            Console.Write(strToiletTxt);
            Console.SetCursorPosition(2, 17);
            
        }
        
        static void Book()
        {
            
            string strBookText = System.IO.File.ReadAllText(@"../../Book.txt");
            Console.Write(strBookText);
            Console.ReadLine();
        }
    }
}
        

   


