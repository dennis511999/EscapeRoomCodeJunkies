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

            Thread.Sleep(0);

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
            Console.WriteLine("If you do it too much then your tongue might get stuck.");
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
            Console.WriteLine("Use 1 letter every sentence.");
            Console.SetCursorPosition(1, 26);
            Console.WriteLine("You looked at the lock.");
            Console.SetCursorPosition(1, 27);
            Console.WriteLine("Its need a six digit number to unlock.");
            Console.SetCursorPosition(1, 29);
            Console.WriteLine("Try to open the lock.");


            bool blnContinue = true;

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


                ConsoleKeyInfo ckiCommand;
                command = Console.ReadLine();

                if (command == "111155")
                {
                    Console.SetCursorPosition(1, 33);
                    Console.WriteLine("Good job you opened the cell.");
                    Console.SetCursorPosition(1, 34);
                    Console.WriteLine("Press any key to continue");
                    Console.SetCursorPosition(1, 35);
                    Console.ReadKey();
                    blnContinue = false;

                }
                else
                {
                    
                    Console.SetCursorPosition(1, 33);
                    Console.WriteLine("Press any key to try again");
                    Console.SetCursorPosition(1, 34);
                    Console.ReadKey();

                }
              
            } while (blnContinue);


            
            //Halls and switches for other rooms
            
            do
            {

                Console.ResetColor();

                Console.Clear();
                string strHallText = System.IO.File.ReadAllText(@"../../Hall.txt");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
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
                            
                            

                            int intQuestion = 1;                          

                                                           
                                switch (intQuestion)
                                {
                                    case 1:
                                    {
                                        Console.Clear();
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Program.Dining();
                                        Console.WriteLine("You have entered the Dining room, you see the table in front of you, it requires a 4 digit code.");
                                        Console.SetCursorPosition(1, 16);
                                        Console.WriteLine("1. To try the code lock ");
                                        Console.SetCursorPosition(1, 17);
                                        Console.WriteLine("b. To go back");
                                        Console.SetCursorPosition(1, 18);
                                        command = Console.ReadLine();
                                        
                                        if(command == "1")
                                        {
                                            goto case 2;
                                        }
                                        else if(command == "b")
                                        {
                                            Console.SetCursorPosition(1, 21);
                                            Console.WriteLine("Press b to go back.");
                                            Console.SetCursorPosition(1, 22);
                                            command = Console.ReadLine();
                                            if (command == "b")
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                goto case 1;
                                            }

                                        }
                                        else
                                        {
                                            goto case 1;
                                        }
                                        
                                        
                                    }
                                        

                                                                                                                      
                                        

                                    case 2:
                                        {

                                            Console.Clear();
                                            Program.Dining();
                                            Console.SetCursorPosition(1, 15);
                                            Console.WriteLine("You can now enter the 4 digit code, but it has to be in the right order.");
                                            Console.SetCursorPosition(1, 16);
                                            Console.WriteLine("b. to go back");
                                            Console.SetCursorPosition(1, 17);
                                            command = Console.ReadLine();


                                            if (command == "4505")
                                            {

                                                goto case 3;

                                            }
                                            else if(command == "b") 
                                            {
                                                Console.SetCursorPosition(1, 18);
                                                Console.WriteLine("Press b. ");
                                                Console.SetCursorPosition(1, 19);
                                                command = Console.ReadLine();
                                                break;
                                            }
                                            else
                                            {
                                                goto case 2;
                                            }
                                 
                                        }

                                    case 3:
                                        {
                                            Console.ResetColor();
                                            Console.Clear();
                                            Program.DiningroomB();
                                            Console.SetCursorPosition(42, 15);
                                            Console.WriteLine("A ladder hatch has opened under the table, it might be the exit !");
                                            Console.SetCursorPosition(42, 17);
                                            Console.WriteLine("Press 1 to go down the ladder");
                                            Console.SetCursorPosition(42, 18);
                                            if (Console.ReadLine() == "1")
                                            {
                                                goto case 4;
                                            }
                                            else
                                            {
                                                goto case 3;
                                            }
                                            

                                            
                                        }

                                    case 4:
                                        {

                                            Console.Clear();
                                            Program.Exit();
                                            Console.SetCursorPosition(3, 23);
                                            Console.WriteLine("This is the last puzzle, give the right answer and you will be a free bird.");
                                            Console.SetCursorPosition(3, 24);
                                            Console.WriteLine("there are seven people in my family, with five children including me.");
                                            Console.SetCursorPosition(3, 25);
                                            Console.WriteLine("The second eldest is four years younger than me. The second eldest girl, who I get on with really well,");
                                            Console.SetCursorPosition(3, 26);
                                            Console.WriteLine(" is three years younger than the eldest girl.");
                                            Console.SetCursorPosition(3, 27);
                                            Console.WriteLine("The eldest boy is four years younger than the eldest girl, and three years older than the youngest boy. ");
                                            Console.SetCursorPosition(3, 28);
                                            Console.WriteLine("We all have the same parents. If the second eldest girl is nineteen years old, how old am I?");
                                            Console.SetCursorPosition(3, 30);
                                            Console.WriteLine("Answer this riddle to escape the sewers !");
                                            Console.SetCursorPosition(45, 30);

                                            if (Console.ReadLine() == "19")
                                            {
                                                goto case 5;
                                            }
                                            else
                                            {
                                                goto case 4;
                                            }
                                                                                      
                                        }

                                    case 5:
                                        {

                                            Console.Clear();

                                            Console.SetCursorPosition(0, 5);
                                            Console.WriteLine("Congratulations ! you have escaped the sewers !");
                                            Console.WriteLine("Press 1 to exit the game.");
                                            

                                            if (Console.ReadLine() == "1")
                                            {                                                
                                                string strEscapeCar1 = System.IO.File.ReadAllText(@"../../EscapeCar1.txt");
                                                Console.Write(strEscapeCar1);
                                                Thread.Sleep(100);
                                                Console.Clear();
                                                string strEscapeCar2 = System.IO.File.ReadAllText(@"../../EscapeCar2.txt");
                                                Console.Write(strEscapeCar2);
                                                Thread.Sleep(100);
                                                Console.Clear();
                                                string strEscapeCar3 = System.IO.File.ReadAllText(@"../../EscapeCar3.txt");
                                                Console.Write(strEscapeCar3);
                                                Thread.Sleep(100);
                                                Console.Clear();
                                                string strEscapeCar4 = System.IO.File.ReadAllText(@"../../EscapeCar4.txt");
                                                Console.Write(strEscapeCar4);
                                                Thread.Sleep(90);
                                                Console.Clear();
                                                string strEscapeCar5 = System.IO.File.ReadAllText(@"../../EscapeCar5.txt");
                                                Console.Write(strEscapeCar5);
                                                Thread.Sleep(90);
                                                Console.Clear();
                                                string strEscapeCar6 = System.IO.File.ReadAllText(@"../../EscapeCar6.txt");
                                                Console.Write(strEscapeCar6);
                                                Thread.Sleep(90);
                                                Console.Clear();
                                                string strEscapeCar7 = System.IO.File.ReadAllText(@"../../EscapeCar7.txt");
                                                Console.Write(strEscapeCar7);
                                                Thread.Sleep(90);
                                                Console.Clear();
                                                string strEscapeCar8 = System.IO.File.ReadAllText(@"../../EscapeCar8.txt");
                                                Console.Write(strEscapeCar8);
                                                Thread.Sleep(85);
                                                Console.Clear();
                                                string strEscapeCar9 = System.IO.File.ReadAllText(@"../../EscapeCar9.txt");
                                                Console.Write(strEscapeCar9);
                                                Thread.Sleep(85);
                                                Console.Clear();
                                                string strEscapeCar10 = System.IO.File.ReadAllText(@"../../EscapeCar10.txt");
                                                Console.Write(strEscapeCar10);
                                                Thread.Sleep(85);
                                                Console.Clear();
                                                string strEscapeCar11 = System.IO.File.ReadAllText(@"../../EscapeCar11.txt");
                                                Console.Write(strEscapeCar11);
                                                Thread.Sleep(80);
                                                Console.Clear();
                                                string strEscapeCar12 = System.IO.File.ReadAllText(@"../../EscapeCar12.txt");
                                                Console.Write(strEscapeCar12);
                                                Thread.Sleep(80);
                                                Console.Clear();
                                                string strEscapeCar13 = System.IO.File.ReadAllText(@"../../EscapeCar13.txt");
                                                Console.Write(strEscapeCar13);
                                                Thread.Sleep(80);
                                                Console.Clear();
                                                string strEscapeCar14 = System.IO.File.ReadAllText(@"../../EscapeCar14.txt");
                                                Console.Write(strEscapeCar14);
                                                Thread.Sleep(75);
                                                Console.Clear();
                                                string strEscapeCar15 = System.IO.File.ReadAllText(@"../../EscapeCar15.txt");
                                                Console.Write(strEscapeCar15);
                                                Thread.Sleep(75);
                                                Console.Clear();
                                                string strEscapeCar16 = System.IO.File.ReadAllText(@"../../EscapeCar16.txt");
                                                Console.Write(strEscapeCar16);
                                                Thread.Sleep(75);
                                                Console.Clear();
                                                string strEscapeCar17 = System.IO.File.ReadAllText(@"../../EscapeCar17.txt");
                                                Console.Write(strEscapeCar17);
                                                Thread.Sleep(70);
                                                Console.Clear();
                                                string strEscapeCar18 = System.IO.File.ReadAllText(@"../../EscapeCar18.txt");
                                                Console.Write(strEscapeCar18);
                                                Thread.Sleep(70);
                                                Console.Clear();
                                                string strEscapeCar19 = System.IO.File.ReadAllText(@"../../EscapeCar19.txt");
                                                Console.Write(strEscapeCar19);
                                                Thread.Sleep(70);
                                                Console.Clear();
                                                string strEscapeCar20 = System.IO.File.ReadAllText(@"../../EscapeCar20.txt");
                                                Console.Write(strEscapeCar20);
                                                Thread.Sleep(65);
                                                Console.Clear();
                                                string strEscapeCar21 = System.IO.File.ReadAllText(@"../../EscapeCar21.txt");
                                                Console.Write(strEscapeCar21);
                                                Thread.Sleep(65);
                                                Console.Clear();
                                                string strEscapeCar22 = System.IO.File.ReadAllText(@"../../EscapeCar22.txt");
                                                Console.Write(strEscapeCar22);
                                                Thread.Sleep(65);
                                                Console.Clear();
                                                string strEscapeCar23 = System.IO.File.ReadAllText(@"../../EscapeCar23.txt");
                                                Console.Write(strEscapeCar23);
                                                Thread.Sleep(60);
                                                Console.Clear();
                                                string strEscapeCar24 = System.IO.File.ReadAllText(@"../../EscapeCar24.txt");
                                                Console.Write(strEscapeCar24);
                                                Thread.Sleep(60);
                                                Console.Clear();
                                                string strEscapeCar25 = System.IO.File.ReadAllText(@"../../EscapeCar25.txt");
                                                Console.Write(strEscapeCar25);
                                                Thread.Sleep(60);
                                                Console.Clear();
                                                string strEscapeCar26 = System.IO.File.ReadAllText(@"../../EscapeCar26.txt");
                                                Console.Write(strEscapeCar26);
                                                Thread.Sleep(55);
                                                Console.Clear();
                                                string strEscapeCar27 = System.IO.File.ReadAllText(@"../../EscapeCar27.txt");
                                                Console.Write(strEscapeCar27);
                                                Thread.Sleep(55);
                                                Console.Clear();
                                                string strEscapeCar28 = System.IO.File.ReadAllText(@"../../EscapeCar28.txt");
                                                Console.Write(strEscapeCar28);
                                                Thread.Sleep(55);
                                                Console.Clear();
                                                string strEscapeCar29 = System.IO.File.ReadAllText(@"../../EscapeCar29.txt");
                                                Console.Write(strEscapeCar29);
                                                Thread.Sleep(50);
                                                Console.Clear();
                                                string strEscapeCar30 = System.IO.File.ReadAllText(@"../../EscapeCar30.txt");
                                                Console.Write(strEscapeCar30);
                                                Thread.Sleep(50);
                                                Console.Clear();
                                                string strEscapeCar31 = System.IO.File.ReadAllText(@"../../EscapeCar31.txt");
                                                Console.Write(strEscapeCar31);
                                                Thread.Sleep(50);
                                                Console.Clear();
                                                string strEscapeCar32 = System.IO.File.ReadAllText(@"../../EscapeCar32.txt");
                                                Console.Write(strEscapeCar32);
                                                Thread.Sleep(45);
                                                Console.Clear();
                                                string strEscapeCar33 = System.IO.File.ReadAllText(@"../../EscapeCar33.txt");
                                                Console.Write(strEscapeCar33);
                                                Thread.Sleep(45);
                                                Console.Clear();
                                                string strEscapeCar34 = System.IO.File.ReadAllText(@"../../EscapeCar34.txt");
                                                Console.Write(strEscapeCar34);
                                                Thread.Sleep(45);
                                                Console.Clear();
                                                string strEscapeCar35 = System.IO.File.ReadAllText(@"../../EscapeCar35.txt");
                                                Console.Write(strEscapeCar35);
                                                Thread.Sleep(40);
                                                Console.Clear();
                                                string strEscapeCar36 = System.IO.File.ReadAllText(@"../../EscapeCar36.txt");
                                                Console.Write(strEscapeCar36);
                                                Thread.Sleep(40);
                                                Console.Clear();
                                                string strEscapeCar37 = System.IO.File.ReadAllText(@"../../EscapeCar37.txt");
                                                Console.Write(strEscapeCar37);
                                                Thread.Sleep(40);
                                                Console.Clear();
                                                string strEscapeCar38 = System.IO.File.ReadAllText(@"../../EscapeCar38.txt");
                                                Console.Write(strEscapeCar38);
                                                Thread.Sleep(35);
                                                Console.Clear();
                                                string strEscapeCar39 = System.IO.File.ReadAllText(@"../../EscapeCar39.txt");
                                                Console.Write(strEscapeCar39);
                                                Thread.Sleep(35);
                                                Console.Clear();
                                                string strEscapeCar40 = System.IO.File.ReadAllText(@"../../EscapeCar40.txt");
                                                Console.Write(strEscapeCar40);
                                                Thread.Sleep(35);
                                                Console.Clear();
                                                string strEscapeCar41 = System.IO.File.ReadAllText(@"../../EscapeCar41.txt");
                                                Console.Write(strEscapeCar41);
                                                Thread.Sleep(30);
                                                Console.Clear();
                                                string strEscapeCar42 = System.IO.File.ReadAllText(@"../../EscapeCar42.txt");
                                                Console.Write(strEscapeCar42);
                                                Thread.Sleep(30);
                                                Console.Clear();
                                                string strEscapeCar43 = System.IO.File.ReadAllText(@"../../EscapeCar43.txt");
                                                Console.Write(strEscapeCar43);
                                                Thread.Sleep(30);
                                                Console.Clear();
                                                string strEscapeCar44 = System.IO.File.ReadAllText(@"../../EscapeCar44.txt");
                                                Console.Write(strEscapeCar44);
                                                Thread.Sleep(20);
                                                Console.Clear();
                                                string strEscapeCar45 = System.IO.File.ReadAllText(@"../../EscapeCar45.txt");
                                                Console.Write(strEscapeCar45);
                                                Thread.Sleep(20);
                                                Console.Clear();
                                                string strEscapeCar46 = System.IO.File.ReadAllText(@"../../EscapeCar46.txt");
                                                Console.Write(strEscapeCar46);
                                                Thread.Sleep(20);
                                                Console.Clear();
                                                string strEnding = System.IO.File.ReadAllText(@"../../Ending.txt");
                                                Console.Write(strEnding);
                                                Thread.Sleep(10);
                                                Console.ReadLine();



                                            Console.ReadLine();
                                            }
                                            else
                                            {
                                                goto case 5;
                                            }

                                        break;
                                        }
            
                                }                              
                        }break;                  


                    case "2":
                        {
                            
                            

                          
                            int intQuestions2 = 1;

                            switch (intQuestions2)
                            {
                                case 1:
                                    {
                                        Console.Clear();
                                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Program.Livingroom();
                                        Console.WriteLine("You have entered the Living room.");
                                        Console.SetCursorPosition(1, 15);
                                        Console.WriteLine("You can open the Safe in this room, it requires a 3 digit code which you can get in another room.");
                                        Console.SetCursorPosition(1, 17);
                                        Console.WriteLine("1. To try the code lock");
                                        Console.SetCursorPosition(1, 18);
                                        Console.WriteLine("b. To go back");
                                        Console.SetCursorPosition(1, 19);
                                        command = Console.ReadLine();
                                        if(command == "1")
                                        {
                                            goto case 2;
                                        }
                                        else if(command == "b")
                                        {
                                            Console.SetCursorPosition(1, 21);
                                            Console.WriteLine("Press b to go back.");
                                            Console.SetCursorPosition(1, 22);
                                            command = Console.ReadLine();
                                            if (command == "b")
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                goto case 1;
                                            }
                                        }
                                        else
                                        {
                                            goto case 1;
                                        }
                                    }

                                case 2:
                                    {
                                        Console.Clear();
                                        Program.Livingroom();
                                        Console.WriteLine("Enter the 3 digit code");
                                        Console.SetCursorPosition(1, 16);
                                        Console.WriteLine("Press b to go back.");
                                        Console.SetCursorPosition(1, 17);
                                        command = Console.ReadLine();

                                        if (command == "782")
                                        {
                                            goto case 3;
                                        }
                                        else if (command == "b")
                                        {
                                            Console.SetCursorPosition(1, 21);
                                            Console.WriteLine("Press b to go back.");
                                            Console.SetCursorPosition(1, 22);
                                            command = Console.ReadLine();
                                            if (command == "b")
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                goto case 1;
                                            }

                                        }
                                        else
                                        {
                                            goto case 2;
                                        }
                                    }

                                case 3:
                                    {
                                        Console.Clear();
                                        Program.Livingroom();
                                        Console.SetCursorPosition(1, 15);
                                        Console.WriteLine("You have entered the right code, the safe is now open.");
                                        Console.SetCursorPosition(1, 16);
                                        Console.WriteLine("In the safe you found a note with the digits 45, these will be used in the final code lock, to escape.");
                                        Console.SetCursorPosition(1, 17);
                                        Console.WriteLine("Press b to go back");
                                        Console.SetCursorPosition(1, 18);
                                        command = Console.ReadLine();
                                        break;
                                    }

                                    
                            }
                            break;
                        }
                         


                    case "3":
                        {
                            

                            int intQuestions3 = 1;

                            switch (intQuestions3)
                            {
                                case 1:
                                    {
                                        Console.Clear();
                                        Console.BackgroundColor = ConsoleColor.DarkRed;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Program.Mortuarium();
                                        Console.SetCursorPosition(1, 15);
                                        Console.WriteLine("You have entered the Mortuarium.");
                                        Console.SetCursorPosition(1, 16);
                                        Console.WriteLine("Answer this riddle to know which drawer you have to open. If you open the wrong one the room wil explode");
                                        Console.SetCursorPosition(1, 17);
                                        Console.WriteLine("You found a note on the table, press 1 to open the note");
                                        Console.SetCursorPosition(1, 18);
                                        Console.WriteLine("1. Open the note");
                                        Console.SetCursorPosition(1, 19);
                                        Console.WriteLine("b. To go back");
                                        Console.SetCursorPosition(1, 20);
                                        command = Console.ReadLine();
                                        if(command == "1")
                                        {
                                            goto case 2;
                                        }
                                        else if(command == "b")
                                        {
                                            Console.SetCursorPosition(1, 21);
                                            Console.WriteLine("Press b to go back.");
                                            Console.SetCursorPosition(1, 22);
                                            command = Console.ReadLine();
                                            if (command == "b")
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                goto case 1;
                                            }
                                        }
                                        else
                                        {
                                            goto case 1;
                                        }


                                    }

                                case 2:
                                    {

                                        Console.Clear();
                                        Program.Mortuarium();
                                        Console.SetCursorPosition(1, 15);
                                        Console.WriteLine(".esuoh sih ta esuohrethguals a htiw esuoh gib a sah nam A");
                                        Console.SetCursorPosition(1, 16);
                                        Console.WriteLine(".gnippohs  tuo og ot tnaw ton seod nam eht dna dab si rehtaew eht yad txen ehT .stelgip lufituaeb 3 snwo nam eht");
                                        Console.SetCursorPosition(1, 17);
                                        Console.WriteLine(".ylimaf elohw eht htiw tae nac eh taht os sgip lufituaeb eht fo 2 rethguals ot sediced nam eht os");
                                        Console.SetCursorPosition(1, 18);
                                        Console.WriteLine("? tfel era stelgip ynam woH");
                                        Console.SetCursorPosition(1, 19);
                                        Console.WriteLine("What is the answer to this Riddle?");
                                        Console.SetCursorPosition(1, 21);
                                        command = Console.ReadLine();

                                        if (command == "3")
                                        {
                                            goto case 3;
                                        }
                                        else
                                        {
                                            goto case 2;
                                        }
                                    }

                                case 3:
                                    {
                                        Console.Clear();
                                        Program.Mortuarium();
                                        Console.SetCursorPosition(1, 15);
                                        Console.WriteLine("That is the right answer!");
                                        Console.SetCursorPosition(1, 16);
                                        Console.WriteLine("You have opened locker number 3");
                                        Console.SetCursorPosition(1, 17);
                                        Console.WriteLine("You found a note with the numbers 782, it must be for some kind of safe.");
                                        Console.SetCursorPosition(1, 18);
                                        Console.WriteLine("b. to go back");
                                        Console.SetCursorPosition(1, 19);

                                        command = Console.ReadLine();
                                        break;
                                    }
                            }

                            break;
                        }

                    case "4":
                        {


                            int intQuestions4 = 1;

                            switch (intQuestions4)
                            {
                                case 1:
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
                                            goto case 2;
                                        }
                                        else if (command == "b")
                                        {
                                            Console.SetCursorPosition(1, 21);
                                            Console.WriteLine("Press b to go back.");
                                            Console.SetCursorPosition(1, 22);
                                            command = Console.ReadLine();
                                            if (command == "b")
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                goto case 1;
                                            }
                                        }
                                        else
                                        {
                                            goto case 1;
                                        }



                                    }
                                case 2:
                                    {
                                        Console.ResetColor();
                                        Console.Clear();
                                        Program.Toilet();

                                        Console.SetCursorPosition(1, 15);
                                        Console.WriteLine("There is some tekst on the wall.");
                                        Console.SetCursorPosition(1, 16);
                                        Console.WriteLine("Put the colours in the right order.");
                                        Console.SetCursorPosition(1, 17);
                                        Console.WriteLine("Underneath it is a hidden console panel.");
                                        Console.SetCursorPosition(1, 18);
                                        Console.WriteLine("Enter the colours.");
                                        Console.SetCursorPosition(1, 19);
                                        command = Console.ReadLine();

                                        if (command == "yellow")
                                        {
                                            goto case 3;
                                        }
                                        else if (command == "b")
                                        {
                                            Console.WriteLine("Press b to leave the room");
                                            command = Console.ReadLine();
                                            break;
                                        }
                                        else
                                        {
                                            goto case 2;
                                        }
                                        
                                    
                                    }
                                case 3:
                                    {
                                        Console.ResetColor();
                                        Console.Clear();
                                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Program.Toilet();
                                        Console.SetCursorPosition(1, 15);
                                        Console.WriteLine("Enter next colour.");
                                        Console.SetCursorPosition(1, 16);
                                        command = Console.ReadLine();

                                        if (command == "blue")
                                        {
                                            goto case 4;
                                        }
                                        else
                                        {
                                            goto case 2;
                                        }
                                    }
                                case 4:
                                    {
                                        Console.ResetColor();
                                        Console.Clear();
                                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Program.Toilet();
                                        Console.SetCursorPosition(1, 15);
                                        Console.WriteLine("Enter next colour.");
                                        Console.SetCursorPosition(1, 16);
                                        command = Console.ReadLine();
                                        
                                        if(command == "green")
                                        {
                                            goto case 5;
                                        }
                                        else
                                        {
                                            goto case 2;
                                        }
                                               
                                    }
                                case 5:
                                    {
                                        Console.ResetColor();
                                        Console.Clear();
                                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Program.Toilet();
                                        Console.SetCursorPosition(1, 15);
                                        Console.WriteLine("Enter next colour.");
                                        Console.SetCursorPosition(1, 16);
                                        command = Console.ReadLine();

                                        if (command == "red")
                                        {
                                            goto case 6;
                                        }
                                        else
                                        {
                                            goto case 2;
                                        }
                                    }
                                case 6:
                                    {
                                        Console.ResetColor();
                                        Console.Clear();
                                        Console.BackgroundColor = ConsoleColor.DarkRed;
                                        Program.Toilet();
                                        Thread.Sleep(120);
                                        Console.ResetColor();
                                        Console.Clear();
                                        Console.BackgroundColor = ConsoleColor.Yellow;
                                        Program.Toilet();
                                        Thread.Sleep(120);
                                        Console.ResetColor();
                                        Console.Clear();
                                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                                        Program.Toilet();
                                        Thread.Sleep(120);
                                        Console.ResetColor();
                                        Console.Clear();
                                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                                        Program.Toilet();
                                        Thread.Sleep(120);
                                        Console.ResetColor();
                                        Console.Clear();
                                        Console.BackgroundColor = ConsoleColor.DarkRed;
                                        Program.Toilet();
                                        Thread.Sleep(120);
                                        Console.ResetColor();
                                        Console.Clear();
                                        Console.BackgroundColor = ConsoleColor.Yellow;
                                        Program.Toilet();
                                        Thread.Sleep(120);
                                        Console.ResetColor();
                                        Console.Clear();
                                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                                        Program.Toilet();
                                        Thread.Sleep(120);
                                        Console.ResetColor();
                                        Console.Clear();
                                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                                        Program.Toilet();
                                        Thread.Sleep(120);
                                        Console.ResetColor();
                                        Console.Clear();
                                        Console.BackgroundColor = ConsoleColor.DarkRed;
                                        Program.Toilet();
                                        Thread.Sleep(120);

                                        goto case 7;

                                    }
                                case 7:
                                    {
                                        Console.ResetColor();
                                        Console.Clear();
                                        Program.Toilet();
                                        Console.SetCursorPosition(1, 15);
                                        Console.WriteLine("The mirror went open.");
                                        Console.SetCursorPosition(1, 16);
                                        Console.WriteLine("In it is a note.");
                                        Console.SetCursorPosition(1, 17);
                                        Console.WriteLine("You have succeeded this puzzle.");
                                        Console.SetCursorPosition(1, 18);
                                        Console.WriteLine("The code is 05.");
                                        Console.SetCursorPosition(1, 19);
                                        Console.WriteLine("b. Go back to the hall.");
                                        Console.SetCursorPosition(1, 20);
                                        command = Console.ReadLine();
                                        if (command == "b")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            goto case 7;
                                        }
                                        
                                    }
                                                 
                            }

                            break;
                        }

                    default:
                    {
                            
                            Console.SetCursorPosition(1, 21);
                            Console.WriteLine("Wrong input, Try again.");
                            Console.SetCursorPosition(1, 22);
                            Console.WriteLine("Press b to go back");
                            
                            Console.SetCursorPosition(1, 23);
                            command = Console.ReadLine();
                            if(command == "b")
                            {
                                Console.SetCursorPosition(1, 24);
                                Console.WriteLine("Press b again");
                                Console.SetCursorPosition(1, 25);
                                break;
                            }
                            else
                            {
                                goto default;
                            }
        
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
        
        static void Exit()
        {
            Console.Clear();
            string strExitTxt = System.IO.File.ReadAllText(@"../../Exit.txt");
            Console.Write(strExitTxt);
            Console.SetCursorPosition(1, 15);
        }
     

        static void ClearLine()
        {
            Console.Write(new string(' ', Console.BufferWidth - Console.CursorLeft ));
        }

        static void DiningroomB()
        {
            Console.Clear();
            string strDiningroomBtxt = System.IO.File.ReadAllText(@"../../DiningroomB.txt");
            Console.Write(strDiningroomBtxt);
            Console.SetCursorPosition(1, 15);
        }

        

        
    }
}

   


