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

            //Start menu

            Console.WindowHeight = 45;
            Console.WindowWidth = 128;
            string strMenuText = System.IO.File.ReadAllText(@"../../Menu.txt");
            Console.WriteLine(strMenuText);
            Console.SetCursorPosition(1, 15);
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

            //First puzzle in the basement

            string strBasementText = System.IO.File.ReadAllText(@"../../Basement.txt");
            Console.WriteLine(strBasementText);
            Console.SetCursorPosition(1, 15);
            Console.WriteLine("You search the cell.");
            Console.SetCursorPosition(1, 16);
            Console.WriteLine("And guess what, you found a book.");
            Console.SetCursorPosition(1, 18);
            Console.WriteLine("A boy named Bernard said You know that's bad luck.");
            Console.SetCursorPosition(1, 19);
            Console.WriteLine("If you do it too much then you tongue might get stuck.");
            Console.SetCursorPosition(1, 20);
            Console.WriteLine("When Bernard had a birthday, the cake was in place.");
            Console.SetCursorPosition(1, 21);
            Console.WriteLine("And Cecily sang with a smirk on her face. ");
            Console.SetCursorPosition(1, 23);
            Console.WriteLine("There is a hint written in the book.");
            Console.SetCursorPosition(1, 24);
            Console.WriteLine("First is bad, Last is good");
            Console.SetCursorPosition(1, 25);
            Console.WriteLine("a = 1, z = 26");
            Console.SetCursorPosition(1, 26);
            Console.WriteLine("You looked at the lock.");
            Console.SetCursorPosition(1, 27);
            Console.WriteLine("Its need a six digit number to unlock.");
            Console.SetCursorPosition(1, 29);
            Console.WriteLine("Try to open the lock.");           
            

            

            do
            {
                Console.SetCursorPosition(1, 32);
                Program.ClearLine();
                Console.SetCursorPosition(1, 33);
                Program.ClearLine();
                Console.SetCursorPosition(1, 34);
                Program.ClearLine();
                Console.SetCursorPosition(1, 31);
                Console.WriteLine("Enter the code");
                Console.SetCursorPosition(1, 32);
                


                command = Console.ReadLine();
                if (command == "111155")
                {
                    Console.WriteLine("Good job you opend the cell.");

                }
                else
                {
                    
                    Console.SetCursorPosition(1, 33);
                    Console.WriteLine("Press (Y) to try again");
                    Console.SetCursorPosition(1, 34);



                    command = Console.ReadLine();



                }
            } while (command == "y");


            
            //Halls and switches for other rooms
            
            do
            {

                Console.ResetColor();

                Console.Clear();
                string strHallText = System.IO.File.ReadAllText(@"../../Hall.txt");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine(strHallText);
                Console.SetCursorPosition(1, 15);
                Console.WriteLine("You are in the Hall.");
                Console.SetCursorPosition(1, 16);
                Console.WriteLine("1. Enter the dining room.");
                Console.SetCursorPosition(1, 17);
                Console.WriteLine("2. Enter the Living room.");
                Console.SetCursorPosition(1, 18);
                Console.WriteLine("3. Enter the Mortuarium.");
                Console.SetCursorPosition(1, 19);
                Console.WriteLine("4. Enter the Toilet");
                Console.SetCursorPosition(1, 20);

                switch (Console.ReadLine())
                {
                    case "1":
                        {                            
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.ForegroundColor = ConsoleColor.White;
                            Program.Dining();
                            Console.WriteLine("You have entered the Dining room.");
                            Console.SetCursorPosition(1, 16);
                            Console.WriteLine("b. To go back");
                            Console.SetCursorPosition(1, 17);
                            command = Console.ReadLine();
                            break;
                        }


                    case "2":
                        {
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.ForegroundColor = ConsoleColor.White;
                            Program.Livingroom();
                            Console.WriteLine("You have entered the Living room.");
                            Console.SetCursorPosition(1, 16);
                            Console.WriteLine("b. To go back");
                            Console.SetCursorPosition(1, 17);
                            command = Console.ReadLine();
                            break;
                        }


                    case "3":
                        {
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.White;
                            Program.Mortuarium();
                            Console.WriteLine("You have entered the Mortuarium.");
                            Console.SetCursorPosition(1, 16);
                            Console.WriteLine("b. To go back");
                            Console.SetCursorPosition(1, 17);
                            command = Console.ReadLine();
                            break;
                        }


                    case "4":
                        {                         
                            do
                            {
                                Console.ResetColor();
                                Console.Clear();
                                Program.Toilet();
                                                              
                                Console.SetCursorPosition(1, 15);
                                Console.WriteLine("You have entered the toilet.");
                                Console.SetCursorPosition(1, 16);
                                Console.WriteLine("1. Search the toilets");
                                Console.SetCursorPosition(1, 17);
                                Console.WriteLine("b. To go back");
                                Console.SetCursorPosition(1, 18);
                                command = Console.ReadLine();                            


                                
                                

                                if (command == "1")
                                {
                                    Console.SetCursorPosition(1, 19);
                                    Console.WriteLine("There is some tekst on the wall.");
                                    Console.SetCursorPosition(1, 20);
                                    Console.WriteLine("Put the colours in the right order.");
                                    Console.SetCursorPosition(1, 21);
                                    Console.WriteLine("Underneath it is a hidden console pannel.");
                                    Console.SetCursorPosition(1, 22);
                                    Console.WriteLine("Enter the colours.");
                                    Console.SetCursorPosition(1, 23);
                                    command = Console.ReadLine();

                                    if (command == "white")
                                    {
                                        Console.ResetColor();
                                        Console.Clear();                                        
                                        Console.BackgroundColor = ConsoleColor.White;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Program.Toilet();
                                        Console.SetCursorPosition(1, 15);
                                        Console.WriteLine("Enter next colour.");
                                        Console.SetCursorPosition(1, 16);
                                        command = Console.ReadLine();

                                        if(command == "blue")
                                        {
                                            Console.ResetColor();
                                            Console.Clear();                                            
                                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Program.Toilet();
                                            Console.SetCursorPosition(1, 15);
                                            Console.WriteLine("Enter next colour.");
                                            Console.SetCursorPosition(1, 16);
                                            command = Console.ReadLine();


                                            if (command == "green")
                                            {

                                                Console.ResetColor();
                                                Console.Clear();
                                                Console.BackgroundColor = ConsoleColor.DarkGreen;
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Program.Toilet();
                                                Console.SetCursorPosition(1, 15);
                                                Console.WriteLine("Enter next colour.");
                                                Console.SetCursorPosition(1, 16);
                                                command = Console.ReadLine();

                                                if (command == "red")
                                                {
                                                    Console.ResetColor();
                                                    Console.Clear();
                                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                                    Program.Toilet();
                                                    Thread.Sleep(80);
                                                    Console.ResetColor();
                                                    Console.Clear();
                                                    Console.BackgroundColor = ConsoleColor.White;
                                                    Program.Toilet();
                                                    Thread.Sleep(80);
                                                    Console.ResetColor();
                                                    Console.Clear();
                                                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                                                    Program.Toilet();
                                                    Thread.Sleep(80);
                                                    Console.ResetColor();
                                                    Console.Clear();
                                                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                                                    Program.Toilet();
                                                    Thread.Sleep(80);
                                                    Console.ResetColor();
                                                    Console.Clear();
                                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                                    Program.Toilet();
                                                    Thread.Sleep(80);
                                                    Console.ResetColor();
                                                    Console.Clear();
                                                    Console.BackgroundColor = ConsoleColor.White;
                                                    Program.Toilet();
                                                    Thread.Sleep(80);
                                                    Console.ResetColor();
                                                    Console.Clear();
                                                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                                                    Program.Toilet();
                                                    Thread.Sleep(80);
                                                    Console.ResetColor();
                                                    Console.Clear();
                                                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                                                    Program.Toilet();
                                                    Thread.Sleep(80);
                                                    Console.ResetColor();
                                                    Console.Clear();
                                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                                    Program.Toilet();
                                                    Thread.Sleep(80);
                                                }
                                                else
                                                {

                                                }

                                               

                                            }
                                            else
                                            {
                                                Console.Clear();
                                            }  
                                        }
                                        else
                                        {
                                            Console.Clear();
                                        }
                                        
                                    }
                                    else
                                    {
                                        Console.Clear();
                                    }                         
                                }
                                else
                                {
                                    Console.Clear();
                                }

                            } while (command == "y");

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
            Console.SetCursorPosition(1, 15);
            
            
        }

        static void Livingroom()
        {
            Console.Clear();
            string strLivingRoomTxt = System.IO.File.ReadAllText(@"../../LivingRoom.txt");
            Console.Write(strLivingRoomTxt);
            Console.SetCursorPosition(1, 15);
            
        }

        static void Mortuarium()
        {
            Console.Clear();
            string strMortuariumTxt = System.IO.File.ReadAllText(@"../../Mortuarium.txt");
            Console.Write(strMortuariumTxt);
            Console.SetCursorPosition(1, 15);
            
        }

        static void Toilet()
        {
            Console.Clear();
            string strToiletTxt = System.IO.File.ReadAllText(@"../../Toilet.txt");
            Console.Write(strToiletTxt);
            Console.SetCursorPosition(1, 15);
            
        }       
     

        static void ClearLine()
        {
            Console.Write(new string(' ', Console.BufferWidth - Console.CursorLeft ));
        }
    }
}
        

   


