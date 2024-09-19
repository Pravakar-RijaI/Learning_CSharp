using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace Tutorial1
{
    /*public class randomclass
    {
        static public int ide = 43;
        static public void loggdata()
        {
            Console.WriteLine(ide);
        }
    }*/

    /* public class Person
    {
        public string FirstName = "Pravakar";
        public string LastName = "Rijal";
        public string Location = "BMC";

        public void Introduce ()
        {
            Console.WriteLine("This is {0} {1} and I am from {2}.", FirstName, LastName, Location);
        }
    }*/

    /*public enum Days :byte
    {
        Sunday = 1,
        Monday = 2,
        Tuesday = 3,
        Wednesday = 4,
        Thrusday = 5,
        Friday = 6,
        Saturday = 7
    }*/

    /*public enum PaymentMethod
    {
        Cash,
        EPayment,
        CreditCard,
        DebitCard
    }*/

    /*public struct Bmc
    {
        public int Csit;
        public int Bit;

        public void Logger()
        {
            Console.WriteLine("Csit : {0}, Bit : {1}", Csit, Bit);
        }
        
        static public int sum(int x,int y)
        {
            return x + y;
        }
    }*/


    internal class Program
    {
        static void Main()
        {
            /*Console.WriteLine("Hello World!!!");*/

            /*byte num = 255;
            num = (byte)(num + 1);
            Console.WriteLine(num);
            Console.ReadLine();*/

            /*int price = 99;
            float discount1 = 5.78f;
            double discount2 = 9.4422;
            char currency = '$';
            string person = "Pravakar";
            bool regular = false;
            decimal amount;

            if (regular)
            {
                amount = (decimal)price * (decimal)discount2;
                Console.WriteLine(person + " is charged "+ currency + amount);
            }
            else
            {
                amount = price * (decimal)discount1;
                Console.WriteLine(person + " is charged " + currency + amount);
            }
            Console.ReadLine();*/

            /*var number = 89;
            Console.WriteLine(number);*/

            /*var num1 = 3;
            var num2 = 5;
            var sum = num1 + num2;
            Console.WriteLine("Sum of {0} and {1} is {2}.", num1, num2, num1 + num2);
            Console.ReadLine();
            */

            /*const float PI = 3.1415f;
            float radius = 2f;
            float area = PI * radius * radius;

            Console.WriteLine("Area of Circle(origin: circle, radius: 4): {0}.", area);
            Console.ReadLine();*/

            /*//Primitive Data Types
            byte a = 23;
            short b = 34;
            int c = 465;
            long d = 3451;
            float e = 7.69;
            double f = 8.451;
            decimal g = 9.3453;
            char h = 'A';
            string i = 'alphabets';
            bool j = true;*/

            /*//Implicit type conversion
            //short - byte, int - byte, short,  long - byte, short, int;
            //float - byte, short, int, long;
            //double - all from float, float;

            decimal num = 76237.23314m;
            double real = num;
            Console.WriteLine(real);
            Console.ReadLine();*/

            /*//Explicit type conversion
            //all reverse roles with loss of data;
            //still "1" string cannot be converted to int;

            float num1 = 3242.124f;
            decimal num2 = (decimal) num1;
            Console.WriteLine(num2);
            Console.ReadLine();*/

            /*//Object
            randomclass r1 = new randomclass();
            r1.loggdata();
            Console.ReadLine();*/

            /*Person P1 = new Person();
            P1.FirstName = "Rakesh";
            P1.LastName = "Jhunjhunwala";
            P1.Location = "Mumbai";
            P1.Introduce();
            Console.ReadLine();

            Person P2 = new Person();
            P2.Introduce();
            Console.ReadLine();*/

            /*//Static access
            randomclass.loggdata();
            Console.ReadLine();*/

            /*//Namespaces
            double Num1 = 34;
            double Num2 = 45;
            double Sum = Calculator.Add(Num1, Num2);
            double Diff = Calculator.Sub(Num1, Num2);
            Console.WriteLine("Sum of {0} and {1} is {2}.", Num1, Num2, Sum);
            Console.WriteLine("Difference of {0} and {1} is {2}.", Num1, Num2, Diff);
            */

            /*//Arrays
            int[] Roll = new int[] { 1, 4, 5, 7, 9, 2};
            string[] Students = new string[] {"Manish","Prakash","Akash","Niroj"};

            foreach(string Student in Students)
            {
                Console.WriteLine(Student);
            }
            
            //Console.WriteLine(Roll.Length);

            for(int i = 0; i<Students.Length;i++)
            {
                Console.WriteLine("Roll No." + Roll[i] + " : " + Students[i]);
            }*/

            /*//Strings
            string FirstName = "Rajesh";
            string LastName = "Dai";
            
            string FullName = FirstName + " " + LastName;
            Console.WriteLine(FullName);

            string Name = string.Format("{0} {1}",FirstName, LastName);
            Console.WriteLine(Name);
            
            Console.WriteLine("I\tam \n{0} {1}.", FirstName, LastName);
            
            string Path = @"Dear John,
Please look into the Folder
C:\Users\Rajesh\Documents\New.txt";
            Console.WriteLine(Path);

            char[] IndChar = new char[5] { 'M', 'A', 'R', 'S', 'I' };
            string CharacterName = string.Join("", IndChar);
            Console.WriteLine(CharacterName);*/

            /*char[] Person = new char[3];
            for (int i = 0; i < Person.Length; i++)
            {
                Person[i] = Console.ReadLine().ToCharArray()[0];
            }
            Console.WriteLine(Person);*/

            /*//enum
            Console.WriteLine("Enter a day: ");
            int IntDays = Convert.ToInt32(Console.ReadLine());
            Days choice = (Days)IntDays;

            switch(choice)
            {
                case Days.Sunday:
                    Console.WriteLine("\n" + choice);
                    Console.WriteLine("Eat, Sleep, Code, Repeat");
                    break;
                case Days.Monday:
                    Console.WriteLine("\n" + choice);
                    Console.WriteLine("Eat Shit Sleep");
                    break;
                case Days.Tuesday:
                    Console.WriteLine("\n" + choice);
                    Console.WriteLine("Do Nothing...");
                    break;
                case Days.Wednesday:
                    Console.WriteLine("\n" + choice);
                    Console.WriteLine("Do Nothing...");
                    break;
                case Days.Thrusday:
                    Console.WriteLine("\n" + choice);
                    Console.WriteLine("Do Nothing...");
                    break;
                case Days.Friday:
                    Console.WriteLine("\n" + choice);
                    Console.WriteLine("Do Nothing...");
                    break;
                case Days.Saturday:
                    Console.WriteLine("\n" + choice);
                    Console.WriteLine("Do Nothing...");
                    break;
                default:
                    Console.WriteLine("Invalid Day..");
                    break;
            }

            PaymentMethod num = PaymentMethod.CreditCard;
            Console.WriteLine(num);

            string Payment = "DebitCard";
            PaymentMethod Payments= (PaymentMethod)Enum.Parse(typeof(PaymentMethod),Payment);
            Console.WriteLine(Payments);
            Console.WriteLine(Payments);*/

            /*Seasons Sea1 = Seasons.Spring;
            Console.WriteLine(Sea1);*/

            /*Bmc Csit = new Bmc {
            Csit = 23,
            Bit = 43
            };
            Csit.Logger();
            Console.WriteLine("Sum is {0}",Bmc.sum(34,56));*/

            /*Classes
                Strings
                Arrays
            Structures
                PrimitiveDataTypes*/

            //Control Flow
            /*//Conditionals
            Console.WriteLine("Enter Your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 18)
            {
                Console.WriteLine("You are {0} years old. You can drive.",age);
            }
            else
            {
                Console.WriteLine("You are {0} years old. You can't drive.",age);
            }

            string choice;
            if (age > 0 && age <= 10)
                choice = "Child";
            else if (age > 10 && age <= 20)
                choice = "Teenager";
            else if (age > 20 && age <= 60)
                choice = "Adult";
            else if (age > 60 && age <= 110)
                choice = "Old Age";
            else
                choice = "Invalid";

            switch (choice)
            {
                case "Child":
                    Console.WriteLine("You are a Child.");
                    break;
                case "Teenager":
                    Console.WriteLine("You are a Teenager.");
                    break;
                case "Adult":
                    Console.WriteLine("You are an Adult.");
                    break;
                case "Old Age":
                    Console.WriteLine("You are an Old Age.");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }*/

            /*//Loops
            //for
            //foreach
            //while
            //do while
            for(int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("{0} is Even.", i);
                else    
                    Console.WriteLine("{0} is Odd.", i);
            }

            int[] arr = new int[5];
            for(int i = 0; i < arr.Length; i++)
            {
                try
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                   Console.WriteLine("Invalid Input. Enter an Integer.");
                    
                }
            }
            int Count = 0;
            foreach (int a in arr)
            {
                Console.WriteLine("Array[{0}]: {1}", Count, a);
                Count++;
            }

            string Name;
            do
            {
                Console.WriteLine("Enter Your Name: ");
                Name = Console.ReadLine();
            } while (Name == "");
                Console.WriteLine("Your name must be {0}.", Name);*/

            /*//Random Class
            Random random = new Random();
            const int PasswordLength = 10;
            int MinValue = 0;
            int MaxValue = 26;
            char[] Buffer = new char[PasswordLength];
            //string Password = "";
            for (int i = 0; i < PasswordLength; i++)
            {
                Buffer[i] = ((char)('a' + random.Next(MinValue, MaxValue)));
            //    Password += Buffer[i];
            }
            string Password = new string(Buffer);
            Console.WriteLine("Password: {0}",Password);*/

            /*//Arrays
            //Single Dimensional Array
            int[] Numbers = new int[5];
            //Multi Dimensional Array
            //2D
                int[,] Matrix = new int[3, 3]
                {
                    { 1, 2, 3},
                    { 4, 5, 6},
                    { 7, 8, 9}
                };
            int Element = Matrix[1, 2];
            Console.WriteLine(Element);
            //Jagged Array
            int[][] JaggedMatrix = new int[3][];
            JaggedMatrix[0] = new int[3];
            JaggedMatrix[1] = new int[4];
            JaggedMatrix[2] = new int[5];
            //3D
            int[,,] ThreeDArray = new int[2, 3, 5];

            //Array Methods
            int[] Numb = { 1, 2, 4 };
            int[] Numbers = new int[5];
            
            //Length
            int Length = Numb.Length;
            Console.WriteLine("Length: {0}", Length);
            
            //Index
            const int Key = 4;
            int KeyIndex = Array.IndexOf(Numb, Key);
            Console.WriteLine("Index of {0}: {1}.", Key, KeyIndex);
            
            //Clear
            Array.Clear(Numb, 1, 2);
            foreach (int Num in Numb)
            {
                Console.Write(Num + " ");
            }
            Console.WriteLine();
           
            Numb[1] = 5;
            Numb[2] = 3;
            
            //Copy
            Array.Copy(Numb, Numbers, 3);
            foreach (int Number in Numbers)
            {
                Console.Write(Number + " ");
            }
            Console.WriteLine();

            //Sort
            Array.Sort(Numbers);
            foreach (int Number in Numbers)
            {
                Console.Write(Number + " ");
            }
            Console.WriteLine();

            //Reverse
            Array.Reverse(Numbers);
            foreach(int Number in Numbers)
            {
                Console.Write(Number + " ");
            }
            Console.WriteLine();
            
            string[] Names = new string[5] { "Manish", "Akash", "Kusum", "Bipin", "RP" };
            Console.WriteLine(Names.Length);
            Console.WriteLine(Array.IndexOf(Names,"Kusum"));
            Array.Clear(Names, 2, 2);
            foreach (string Name in Names)
            {
                Console.Write(Name + " ");
            }
            Console.WriteLine();*/

            /*//Lists
            //var Numbers = new List<int>();
            var Numbers = new List<int> { 1, 2, 4, 6 };
            int[] Numbs = new int[5];
            var Numberss = Numbs.ToList<int>();
            Numberss.Add(4);
            Numbers.Add(5);
            foreach (int Number in Numbers)
            {
                Console.Write(Number + " ");
            }
            Console.WriteLine();

            int[] Ram = new int[5] { 2, 5, 6, 78, 9 };
            List<int> Next = new List<int>();
            Next.Add(45);
            Next.AddRange(Numbers);
            Next.AddRange(Ram);
            foreach (int N in Next)
            {
                Console.Write(N + " ");
            }
            Console.WriteLine();

            Console.WriteLine(Next.IndexOf(2));
            Console.WriteLine(Next.LastIndexOf(2));
            Console.WriteLine(Next.Count);
            Next.Remove(2);
            foreach (int N in Next)
            {
                Console.Write(N + " ");
            }
            Console.WriteLine();

            for(int i = 0; i < Next.Count; i++)
            {
                if (Next[i] == 2)
                    Next.Remove(Next[i]);
                Console.Write(Next[i] + " ");
            }
            Console.WriteLine();

            Next.Clear();
            Console.WriteLine(Next.Count);*/

            /*//Date Time
           // DateTime DateandTime = new DateTime();
            DateTime New = DateTime.Now;
            Console.WriteLine(New.Hour);
          //  Console.WriteLine(DateandTime.Day);
            Console.WriteLine(New.ToLongDateString());
            Console.WriteLine(New.AddYears(57).ToString("yyyy.MM.dd"));

            //Time Span
            TimeSpan TimeKat = new TimeSpan(1,3,4);
           TimeKat = TimeSpan.FromHours(1);
            DateTime Start = DateTime.Now;
            DateTime End = DateTime.Now.AddMinutes(6);
            TimeSpan Duration = End - Start;
            Console.WriteLine(Duration);
            Console.WriteLine("Minutes: " + TimeKat.Minutes);
            Console.WriteLine("Minutes: " + TimeKat.TotalMinutes);

            
            Console.WriteLine(TimeKat.Add(Duration));
            Console.WriteLine(TimeKat.Subtract(Duration));

            //To String
            Console.WriteLine("To String" + TimeKat.ToString());

            //Parse
            Console.WriteLine("Parse: "+ TimeSpan.Parse("ad"));*/

            /*//Strings Operations
            string Input = "sagar Guru";
            Console.WriteLine(Input.ToLower());
            Console.WriteLine(Input.ToUpper());
            Console.WriteLine(Input.Trim());
            Console.WriteLine(Input.IndexOf('a'));
            Console.WriteLine(Input.LastIndexOf("Guru"));
            Console.WriteLine(Input.Substring(4,2));
            Console.WriteLine(Input.Replace("Guru", "Suru"));
            Console.WriteLine(String.IsNullOrEmpty(Input));
            string[] Words = new string[3];
            Words = Input.Split(' ');
            foreach (string Word in Words)
                Console.WriteLine(Word);
            string Num = "1234";
            int i = int.Parse(Num);
            Console.WriteLine(i);
            string s = i.ToString("x");
            Console.WriteLine(s);*/

            /*//Summarize
            Console.WriteLine("Write a Sentence:");
            //string Text = "This is a very very very very long paragraph that needs to be studied in very precise manner.";
            string Text = Console.ReadLine();
            Console.WriteLine("\nSummary Length in Characters: ");
            int MaxCharacter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nSummary:");
            string SummarizedText = SummarizeText(Text, MaxCharacter);
            Console.WriteLine(SummarizedText + "\n");*/

            /*//String Builder
            StringBuilder Builder = new StringBuilder();
            Builder.Append('-', 10);
            Builder.Append(" Header ");
            Builder.Append('-', 10);
            Builder.AppendLine();
            Builder.Replace('-', '*');
            Builder.Remove(0, 11);
            Builder.Insert(0, new string('-',10));
            Console.WriteLine(Builder);

            StringBuilder New = new StringBuilder();
            New.
                Append('-', 10).
                Append(" Header ").
                Append('-', 10).
                AppendLine().
                AppendLine().
                Append("\tWelcome").
                AppendLine().
                Append('-', 20);
            Console.WriteLine(New);*/

            /*//Procedural Programming
            Console.WriteLine("Enter Your Name: ");
            string Name = Console.ReadLine();
            string ReversedName = ReverseName(Name);
            Console.WriteLine(ReversedName);*/

            /*//Files
            string SourcePath = @"C:\Users\USER\Documents\PRAVAKAR\newfile.txt";
            string DestinationPath = @"C:\Users\USER\Documents\newfile.txt";
            
            //string Text = "This Content is Written From C# Sharp Language from Console Project.";
            //File.Create(SourcePath);
            // File.Copy(SourcePath, DestinationPath);
           // if (File.Exists(SourcePath))
               // Console.WriteLine("File is Present.");
            //Console.WriteLine(File.Exists(Path));
            //File.WriteAllText(Path, Text);
            //Console.WriteLine(File.ReadAllText(Path));
            //File.Delete(Path);

            //FileInfo
            //FileInfo FileMake = new FileInfo("NewFile.txt");
            //FileMake.CopyTo(Path);
            //FileMake.Delete();
            if (FileMake.Exists)
                Console.WriteLine("File is Created.");
            else
                Console.WriteLine("No File.");*/

            /*//Directory
            string DirectoryPath = @"C:\Users\USER\Documents\PRAVAKAR\Misc";
            Directory.CreateDirectory(DirectoryPath);
            var Folders = Directory.GetFiles(@"C:\Users\USER\Documents\PRAVAKAR","*.sln",SearchOption.AllDirectories);
            foreach (string Files in Folders)
                Console.WriteLine(Files);
            var Folderss = Directory.GetDirectories(@"C:\Users\USER\Documents\PRAVAKAR", ".", SearchOption.AllDirectories);
            foreach(string Foldersss in Folderss)
                Console.WriteLine(Foldersss);
            //DirectoryInfo
            DirectoryInfo Folder = new DirectoryInfo(DirectoryPath);
            Folder.GetFiles();
            Console.WriteLine(Folder.GetDirectories());
            Folder.GetFiles();*/

            /*//Path
            string FilePath = @"C:\Users\USER\Documents\PRAVAKAR\newfile.txt";
            Console.WriteLine(Path.GetExtension(FilePath));
            Console.WriteLine(Path.GetDirectoryName(FilePath));
            Console.WriteLine(Path.GetFileNameWithoutExtension(FilePath));*/

            /*//Debugging Steps
            //F9 - Set BreakPoint
            //F5 - Run Program in Debug Mode
            //F10 - Step Over
            //F11 - Step Into
            //Ctrl + Shift + F9 - Delete All BreakPoints
            //Ctrl + Shift + F5 - Restart Application
            //Shift + F11 - Step Out
            //F5 - Moves to Next BreakPoint
            //Shift + F5 - Stop Debugger
            //Observe Watch, Local, Auto, Call Stack*/
        }

        /*public static string SummarizeText (string Text, int MaxCharacter)
        {
            
            string[] Words = new string[MaxCharacter];
            int TotalCharacter = 0;
            List<string> SummarizedWords = new List<string>();
            string SummarizedText;
            Words = Text.Split(' ');

            foreach (string Word in Words)
            {
                SummarizedWords.Add(Word);
                TotalCharacter += Word.Length + 1;
                if (TotalCharacter > MaxCharacter)
                    break;
            }
            SummarizedText = String.Join(" ", SummarizedWords) + "...";
            return SummarizedText;
        }*/

        /*public static string ReverseName(string Name)
        {
            Name = Name.ToLower();
            char[] Output = new char[Name.Length];

            for (int i = Name.Length; i > 0; i--)
                Output[Name.Length - i] = Name[i - 1];

            string ReversedName = new string(Output);
            return ReversedName;*/

        }
    }

 