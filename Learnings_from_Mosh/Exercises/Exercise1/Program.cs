using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;

namespace Exercise1
{
    internal class Program
    {
        static void Main()
        {
            /*//Exercise 1
            Console.WriteLine("Enter a Number: ");
            int Num = Convert.ToInt32(Console.ReadLine());

            if (Num >= 1 && Num <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");*/

            /*//Exercise 2
            Console.WriteLine("Enter a Number: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another Number: ");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            //int Max = (Num1 > Num2) ? Num1 : Num2;
            //Console.WriteLine("Maximum: {0}", Max);
            
            if (Num1 > Num2)
                Console.WriteLine("Maximum of {0} and {1} is {2}.", Num1, Num2, Num1);
            else if(Num2 > Num1)
                Console.WriteLine("Maximum of {0} and {1} is {2}.", Num1, Num2, Num2);
            else
                Console.WriteLine("Both are equal.");*/

            /*//Exercise 3
            Console.WriteLine("Enter Width: ");
            double Width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Height: ");
            double Height = Convert.ToDouble(Console.ReadLine());
            
            string Image = (Width > Height) ? "Land Scape" : "Potrait";

            Console.WriteLine("Image: {0}.", Image);*/

            /*//Exercise 4
            Console.WriteLine("Enter the Speed Limit: ");
            int SpeedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Speed of the Car: ");
            int Speed = Convert.ToInt32(Console.ReadLine());

            if (Speed < SpeedLimit)
            {
                Console.WriteLine("Okay :-)");
            }
            else
            {
                double DemeritPoints = (Speed - SpeedLimit) / 5.0;
                Console.WriteLine("Above Speed Limit :-( Demerit Points Incurred: {0}", DemeritPoints);

                if (DemeritPoints > 12)
                    Console.WriteLine("License Suspended>>>");
            }*/

            /*//Exercise 5
            const int Divisor = 3;
            const int LowerLimit = 1;
            const int HigherLimit = 100;
            int Count = 0;
            for(int i = LowerLimit; i <= HigherLimit; i++)
            {
                if (i % Divisor == 0)
                    Count++;
            }
            Console.WriteLine("Numbers between {0} and {1} divisble by {2} is {3}.", LowerLimit, HigherLimit, Divisor, Count);*/

            /*//Exercise 6
            string Input;
            int[] Numbers = new int[10];
            int i = 0,Sum = 0;
            do
            {
                Console.WriteLine("Enter a Number: ");
                Input = Console.ReadLine();
                if(Input != "")
                Numbers[i] = Convert.ToInt32(Input);
                Sum += Numbers[i];
                i++;
            } while (Input != "");

            Console.WriteLine("Sum of the Numbers: {0}", Sum);*/

            /*//Exercise 7
            Console.WriteLine("Enter a Number: ");
            try
            { 
            int Number = Convert.ToInt32(Console.ReadLine()); 
            long Factorial = 1;
            int i = 1;
            do
            {
                Factorial *= i;
                i++;

            } while (i <= Number);
            
            Console.WriteLine("{0}!= {1}", Number, Factorial);
            }
            catch (Exception)
            { Console.WriteLine("Invalid Number."); }*/

            /*//Exercise 8
            Console.WriteLine("\t--------- Welcome To Number Guessing Game ---------");
            
            int Number, UserGuess,Chance = 4, i = 1;
            bool Flag = false;
            const int LowerLimit = 1;
            const int HigherLimit = 10;
            Random random = new Random();
            Number = random.Next(LowerLimit, HigherLimit);
            Console.WriteLine("\t\tGuess a Number between {0} and {1}.",LowerLimit, HigherLimit);
            
            try
            { 
                do
                {
                    Console.WriteLine("\nChance {0}:", i);
                    Console.WriteLine("Guess the Number: ");
                    UserGuess = Convert.ToInt32(Console.ReadLine());
                    i++;
                    if (UserGuess == Number)
                        Flag = true;
                } while (i <= Chance);
            
                if (Flag)
                    Console.WriteLine("\n\t\tYou Win :D\n\t\t....Correct Guess....\n");
                else
                    Console.WriteLine("\n\t\tYou Lose :C\n\t\tNumber was {0}.\n", Number);
            }

            catch (Exception)
            {
                Console.WriteLine("\nInvalid Number..\n");
            }*/

            /*//Exercise 9
            //string Input = "1,3,5,7";
            //int[] Numbers = new int[10];
            //int i = 0;
            //while (Convert.ToBoolean(Input[i].CompareTo('')))
            //{
            //    if (!(Convert.ToBoolean(Input[i].CompareTo(','))))
            //        continue;
            //    else
            //        Numbers[i] = Convert.ToInt32(Input[i]);
            //}
            //foreach (int Number in Numbers)
            //{
            //    Console.Write(Number + " ");
            //}

            Console.WriteLine("Enter Numbers Seperated by Comma(,): ");
            string Input = Console.ReadLine();
            string[] StrNum = Input.Split(',');
            int[] Numbers = new int[10];
            int i = 0,Max = Numbers[0];
            foreach (string Num in StrNum)
            {
                Numbers[i] = Convert.ToInt32(Num);
                if (Numbers[i] > Max)
                    Max = Numbers[i];
                i++;
            }
            
            Console.WriteLine("Maximum Value: {0}.", Max);*/

            /*//Exercise 10
            int i = 0;
            string Input;
            List<string> Names = new List<string>();
            do
            {
                Console.WriteLine("Enter a Name: ");
                Input = Console.ReadLine();
                if (Input != "")
                Names.Add(Input);
                i++;
            } while (Input != "");

            int Length = Names.Count;

            if (Length == 0)
            {
                Console.WriteLine();
            }
            else if (Length == 1)
            {
                Console.WriteLine("{0} Wrote in Console.", Names[0]);
            }
            else if (Length == 2)
            {
                Console.WriteLine("{0} and {1} Wrote in Console.", Names[0], Names[1]);
            }
            else if (Length > 2)
            {
                Console.WriteLine("{0} People Wrote in Console.", Names.Count);
            }
            else
            {
                Console.WriteLine("Technical Problem...");
            }*/

            /*//Exercise 11
            char[] Name = new char[5];
            int i = 0;
            char Input;
            Array.Reverse(Name);
            Console.WriteLine("Enter Your Name: ");
            do
            {
                Input = (char) Console.Read();
                Console.Write(Input);
                //if (Input != "")
                //Name[i] = Convert.ToChar(Input);
            }
            while (Input != '');

            Array.Reverse(Name);
            string ReversedName = Name.ToString();
            Console.WriteLine(ReversedName);

            char[] Namess = new char[4] { 's', 'a', 'g', 'a' };
            Array.Reverse(Namess);
            foreach (int N in Namess)
                Console.Write(N);*/

            /*//Exercise 12
            Console.WriteLine("-------- Enter Five Numbers to be Sorted -------- ");
            const int Times = 5;
            int[] Numbers = new int[Times];
            int Buffer;
            string Input;
            for (int i = 0; i < Times; i++)
            {
                label:
                Console.WriteLine("\nEnter a Number: ");
                Input = Console.ReadLine();
                
                if (Input == "")
                {
                    goto label;
                }

                Buffer = Convert.ToInt32(Input);

                if ((Array.IndexOf(Numbers, Buffer)) == -1)
                    Numbers[i] = Buffer;

                else
                {
                    Console.WriteLine("\nError: Number Already Present. Retry..\n");
                    goto label;
                }
            }
            Console.WriteLine("\nSorted Array of Numbers: ");
            Array.Sort(Numbers);
            foreach (int Number in Numbers)
                Console.Write(Number + " ");
            Console.WriteLine();*/

            /*//Exercise 13
            Console.Write("\n\t\t---- Enter Numbers ---- \n\t\t(Press Quit(Q) to Exit)\n\n");
            string Input;
            List<int> Numbers = new List<int>();
            int Buffer;
            while (true)
            {
                Console.WriteLine("Enter a Number: ");
                Input = Console.ReadLine();

                if (Input == "")
                    continue;
                
                if (Input == "Quit" || Input == "Q" || Input == "q" || Input == "quit")
                {
                    break;
                }
                
                Buffer = Convert.ToInt32(Input);
                
                if (Numbers.IndexOf(Buffer) == -1)
                {
                Numbers.Add(Buffer);
                }
            }

            Console.WriteLine();

            if(Numbers.Count > 0)
            {
                foreach (int Number in Numbers)
                    Console.Write(Number + " ");
                Console.WriteLine();
            }*/

            /*//Exercise 14
            string Input;
            List<int> Numbers = new List<int>();
            string[] Buffer = new string[10];
            List <int> MinList = new List<int>();
            
            while (true)
            {
                Console.WriteLine("Enter Comma(,) Seperated Numbers: ");
                Input = Console.ReadLine();
                Buffer = Input.Split(',');
                int Length = (Buffer.Length);
                
                if (Length < 5)
                {
                    Console.WriteLine("Invalid List.\nRetry...\n");
                    continue;
                }

                for (int i = 0; i < Length; i++)
                {
                    if (Numbers.IndexOf(Convert.ToInt32(Buffer[i])) == -1)
                    Numbers.Add((Convert.ToInt32(Buffer[i])));
                }

                break;
            }
         
            Console.WriteLine("\nThree Smallest Number in the lists are: ");
            Numbers.Sort();
            MinList.AddRange(new int[3]{ Numbers[0], Numbers[1], Numbers[2]});
            foreach (int MinElement in MinList)
                Console.Write(MinElement + " ");
            Console.WriteLine();*/

            /*//Exercise 15
            Console.WriteLine("Enter Numbers Seperated By Hyphens(-): ");
            string Input = Console.ReadLine();
            int Flag = 5;
            string[] Buffer = new string[Input.Length];
            List<int> Numbers = new List<int>();
            Buffer = Input.Split('-');

            for (int i = 0; i < Buffer.Length; i++)
            {
                if (Buffer[i] == "")
                    break;
                Numbers.Add(Convert.ToInt32(Buffer[i]));
            }

            for (int i = 0; i < Numbers.Count - 1; i++)
            { 
                if (Numbers[i + 1] == Numbers[i] + 1)
                    Flag = 1;
                else
                {
                    Flag = 0;
                    break;
                }
            }

            if (Flag == 1)
                Console.WriteLine("Consecutive");
            else if (Flag == 0)
                Console.WriteLine("Not Consecutive");
            else
                Console.WriteLine();*/

            /*//Exercise 16
            StringBuilder Header = new StringBuilder();
            Console.WriteLine(Header.Append('-', 10).Append(" Duplicate Finder ").Append('-', 10) + "\n");
            Console.WriteLine("Enter Numbers Seperated by Hyphens(-): ");
            string Input = Console.ReadLine();
            string[] Buffer = new string[Input.Length];
            Buffer = Input.Split('-');
            int Number, Flag = 1;
            List<int> Numbers = new List<int>();
            for (int i = 0; i < Buffer.Length; i++)
            { if (Buffer[i] == "")
                    break;
                else
                {
                    Number = Convert.ToInt32(Buffer[i]);
                    if (Numbers.IndexOf(Number) == -1)
                    {
                        Numbers.Add(Number);
                        Flag = 1;
                    }
                    else
                        Flag = 0;
                }
            }
            if (Flag == 0)
                Console.WriteLine("\nDuplicates Found.\n");
            else if (Flag == 1)
                Console.WriteLine("\nNo Duplicates Found.\n");
            else
                Console.WriteLine();*/

            /*//Exercise 17
            Console.WriteLine("Enter a Time in 24-Hour Format (hh:mm): ");
            string Input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(Input))
                return;
            var Components = Input.Split(':');
            
            if (Components.Length != 2)
                Console.WriteLine("Invalid Time");
            int Hours = Convert.ToInt32(Components[0]);
            int Minutes = Convert.ToInt32(Components[1]);

            if (Hours >= 0 && Hours < 24 && Minutes >= 0 && Minutes < 60)
                Console.WriteLine("Valid Time..");
            else
                Console.WriteLine("Invalid Time..");*/

            /*//Exercise 18
            StringBuilder Header = new StringBuilder();
            Console.WriteLine(Header.Append('-',5).Append(" Convert Words to Variables ").Append('-',5) + "\n");
            Console.Write("Enter Words: ");
            string Input = Console.ReadLine();
            string Upper, Temp;
            string[] Concat = new string[10];
            string[] Buffer = new string[Input.Length];
            Buffer = Input.Split(' ');
            for(int i = 0; i < Buffer.Length; i++)
            {
            Upper = Buffer[i][0].ToString().ToUpper();
            Temp = Buffer[i].Remove(0, 1).ToLower();
            Concat[i] = Upper + Temp;
            }
            string PascalCase = "";
            foreach (string C in Concat)
                PascalCase += C;
            Console.WriteLine(PascalCase);*/

            /*//Exercise 19
            StringBuilder Header = new StringBuilder();
            Console.WriteLine(Header.Append('-', 7).Append(" Vowel Counter").Append('-', 7) + "\n");
            Console.Write("Enter a Word: ");
            string Input = Console.ReadLine();
            string Buffer;
            int VowelCount = 0;
            for (int i = 0; i < Input.Length; i++)
            {
                Buffer = Input[i].ToString().ToLower();
                if (Buffer == "a" || Buffer == "e" || Buffer == "i" || Buffer == "o" || Buffer == "u")
                    VowelCount++;
            }
            Console.WriteLine("\nVowel Count: " + VowelCount + "\n");*/

            /*//Exercise 20
            string Path = @"C:\Users\USER\Documents\PRAVAKAR\NET Centric\Files\newfile.txt";
            FileInfo NewFile = new FileInfo(Path);
            Console.WriteLine("Write Content to be Written in File: ");
            string Input = Console.ReadLine();
            int WordCount = 0;
            var Buffer = Input.Split(' ');
            File.WriteAllLines(Path, Buffer);
            var Output = File.ReadAllLines(Path);
            foreach (string Word in Output)
            {
                WordCount++;
                //Console.Write(Word + " ");
            }

            Console.WriteLine("\nTotal Words: " + WordCount +"\n");*/

            /*//Exercise 21
            string Path = @"C:\Users\USER\Documents\PRAVAKAR\NET Centric\Files\NextFile.txt";
            //File.Create(Path);
            Console.WriteLine("Write Content to be Written in File: ");
            string Input = Console.ReadLine();
            var Buff = Input.Split(' ');
            File.WriteAllLines(Path, Buff);
            var Buffer = File.ReadAllLines(Path);
            int LongestCount = Buffer[0].Length;
            string LongestWord = Buffer[0];
            for (int i = 0; i < Buffer.Length; i++)
            {
                if (Buffer[i].Length > LongestCount)
                {
                    LongestCount = Buffer[i].Length;
                    LongestWord = Buffer[i];
                }
            }

            Console.WriteLine("\nLongest Word in File:\n" + LongestWord + "\nCount: " + LongestCount + "\n");*/


        }
    }
}
