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
                                                Console.SetCursorPosition(0, 8);
                                                Console.WriteLine("hello");
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

                                        if(command == "1")
                                        {
                                            goto case 2;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Press b to go back.");
                                            command = Console.ReadLine();
                                            break;
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

   


