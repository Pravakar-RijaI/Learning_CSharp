using System;
using Composition;

/*using Kingdom;
using People;
using Business;
using Vechicle;
using Points;
using Calculate;
using ClassType;
using GetSet;
using CollegeProgram;
using System.Net;
using Cookies;*/
//using OOPConcept;
using ClassLibrary1;
using ClassLibrary.DifferentClasses;
using System.Collections.Specialized;
using MethodOverride;
using System.Collections.Generic;


namespace Tutorial2
{
    internal class Program
    {
        static void Main()
        {
            /*//Constructor Overloading
            Animal A1 = new Animal("Tiger", 4);
            A1.Introduce();
            Animal A3 = Animal.Parse("Lion",4);
            A3.Introduce();
            Person P1 = new Person("Ramesh");
            P1.Introduce();
            Person P2 = new Person("Ramesh", "Nepal");
            P2.Introduce();
            Customer C1 = new Customer(214 ,"Rajesh");
            Console.WriteLine(C1.CustomerId);
            Console.WriteLine(C1.Name);*/

            /*//List Initializing
            Car C1 = new Car();
            C1.Name = "Hyundai";
            C1.Type = "SUV";

            C1.Orders.Add("Creta");
            C1.Introduce();*/

            /*//Handaling Null Objects
            //Point P1 = new Point();
            Point P1 = new Point(34,67);
            P1.Move(100, 200);
            Console.WriteLine("X: " + P1.X);
            Console.WriteLine("Y: " + P1.Y);
            //Point P2 = new Point { X = 12, Y = 34 };
            P1.Move(new Point(11,11){ X=34,Y=21});
            Console.WriteLine("X: " + P1.X);
            Console.WriteLine("Y: " + P1.Y);
            
            try
            {
            P1.Move(null);
            Console.WriteLine("X: " + P1.X);
                Console.WriteLine("Y: " + P1.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("Error Occured.");
            }*/

            /*//Using params
            Calculator Cal = new Calculator();
            int[] Numbers = new int[] { 1, 4, 5, 6, 8 };
            out int Sum = 0;
            Console.WriteLine(Cal.Add(Sum,1, 2, 3, 4, 5));*/

            /*//Using out
            int num1 = int.Parse("1234");
            Console.WriteLine(num1);

            int num;
            bool result = int.TryParse("1234", out num);
            Console.WriteLine(result);
            Console.WriteLine(num);*/

            /*//Get Set Methods
            PrivateClass P1 = new PrivateClass();
            P1.SetBirthdate(new DateTime(1992,12,12));
            Console.WriteLine(P1.GetBirthdate());
            PrivateClass P2 = new PrivateClass(new DateTime(1992, 12, 12));
            Console.WriteLine(P2.Age);*/

            /*//Get Set Properties
            GetterSetter G1 = new GetterSetter();
            G1.Id = 34;
            Console.WriteLine(G1.Id);

            Animal myAnimal = new Animal();
            myAnimal.Name = "Dog";
            myAnimal.Description = "Domestic";
            myAnimal.Food();*/

            /*//Indexers
            HttpCookie H1 = new HttpCookie();
            H1["Name"] = "Hari";
            Console.WriteLine(H1["Name"]);*/

            //Class Coupling
            /*//Inheritance
            DerivedClass D1 = new DerivedClass();
            D1.Name = "Creta";
            D1.Type = "SUV";
            D1.Color = "Matt Black";
            D1.DerivedId = 23;
            D1.Description();
            D1.Introduce();

            //CustomerRank C11 = new CustomerRank();
            //BusinessRank B1 = new BusinessRank(23);
            //B1.Introduce();

            //Upcasting and Downcasting
            //Upcasting - From derived to base class
            //Downcasting - From base class to derived class
            //BusinessRank B1 = new BusinessRank(23);
            //CustomerRank C1 = B1;
            //C1.Introduce();

            //CustomerRank B3 = new CustomerRank(3);
            //BusinessRank B4 = (BusinessRank) C1;
            //B4.Introduce();

            DerivedClass D1 = new DerivedClass();
            BaseClass B2 = D1 as BaseClass;
            if(B2 == null)
                Console.WriteLine("Couldnot be ");
            else
                Console.WriteLine("Done");
            DerivedClass D2 = new DerivedClass();
            if(D1 is BaseClass)
                Console.WriteLine("B1 is BaseClass");*/

            /*//Composition
            DbMigrator D1 = new DbMigrator();
            D1.Migrate();*/

            /*//Boxing And Unboxing   
            //Boxing- Changing value type to reference type
            //Unboxing - Changing reference type to value type

            int num = 233;
            object O1 = num;
            num = 12;
            Console.WriteLine("Boxing");
            Console.WriteLine(num);
            Console.WriteLine(O1);
            Console.WriteLine("Unboxing");
            num = (int)O1;
            Console.WriteLine(num);
            Console.WriteLine(O1);*/

            /*//Method Overriding
            List<Shapes> Shape = new List<Shapes>();
            Shape.Add(new Circle());
            Shape.Add(new Rectangle());
            Canvas.DrawShapes(Shape);*/       


        }
    }
}
