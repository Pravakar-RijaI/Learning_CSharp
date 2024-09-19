using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Classes;
using DrinkWaterProject;
using Extensions;

namespace Tutorial3
{

    internal class Program
    {
        static void Main()
        {
            /*//Generics
            Generics<int> New = new Generics<int>(34);
            New.Display();

            Generica Gen = new Generica();
            string Input = Gen.Diss<string>("ram");
            Console.WriteLine(Input);*/

            /*//Delegates
            Delegates NewDelegate = new Delegates();
            DelegateExample d1 = new DelegateExample(NewDelegate.Display);
            d1 += new DelegateExample(NewDelegate.Introduce);
            d1();

            Delegates delegates = new Delegates();
            Action action = new Action(delegates.Display);
            action += delegates.Introduce;
            action();*/

            /*//Lambda Expressions
            Func<int,int,int,int> sum = (x, y, z) => x + y + z;
            int factor = 5;
            Func<int, int> factors = number => number * factor;

            Console.WriteLine("Sum :" + sum(3,6,8));
            Console.WriteLine("Factor: " + factors(5));

            var books = new BookCollection().GetBooks();
            var CheapBooks = books.FindAll(book => book.Price < 50);

            foreach(var book in CheapBooks)
            {
                Console.WriteLine(book.Title);
            }
            */

            /*//Events
            Video video = new Video() { Title = "Despacito.mp4" };
            VideoEncoder videoEncoder = new VideoEncoder();
            MailService mailService = new MailService();
            SendNotification sendNotification = new SendNotification();
            
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += sendNotification.OnVideoEncoded;
            
            videoEncoder.Encode(video);

            WaterBottle waterBottle = new WaterBottle();

            Console.WriteLine("Enter the Capacity of Water Bottle:");
            waterBottle.WaterLevel = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Quantity of Water Drank (in ounces): ");
            double WaterQuantityDrank = Convert.ToDouble(Console.ReadLine());

            if (!(WaterQuantityDrank > waterBottle.WaterLevel))
            {
            Warning warning = new Warning();

            waterBottle.WarningLevel += warning.OnWarningLevel;

            waterBottle.DrinkWater(WaterQuantityDrank);
            }
            else
                Console.WriteLine("Can't drink more water than that of Bottle.");*/

            /*//ExtensionMethods
            string post = "This is a very good practise of doing things.";
            int numberOfWords = 1;

            string summaryText = post.Summary(numberOfWords);

            Console.WriteLine(summaryText);*/

            /*//Linq
            BookRepo bookRepo = new BookRepo();
            var book = bookRepo.GetBooks();
            var bookColl = book.Where(bookss => bookss.Price < 10).OrderBy(booksss => booksss.Title);

            foreach (var bookCol in bookColl)
            {
                Console.WriteLine(bookCol.Title + " " + bookCol.Price);
            }

            var bookColle = book.Take(2).Skip(3);
            foreach(var bookC in bookColle)
            Console.WriteLine(bookC.Title);*/

            /*//Nullable Type
            int? Number = null;
            Console.WriteLine(Number.GetValueOrDefault());
            Console.WriteLine(Number);*/

            /*//Dynamic Type
            dynamic name = "Pravakar Rijal";
            name = 4;
            Console.WriteLine(name);*/

            /*//Exception Handaling
            int numerator = 43;
            int denominator = 0;

            try
            {
                double result = numerator / denominator;
                Console.WriteLine("Result: " + result);

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divided by Zero: " + e.Message);
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Arithmetic Exception..");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Command: " + e.Message);
            }

            //User Defined Exception
            try
            {
                YouTubeApi youTubeApi = new YouTubeApi();
                var videos = youTubeApi.GetVideo("new_user");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry. An Unexpected Error Occurred.." + ex.Message);
            }*/

            //Asynchronous Programming with Async Await
            Console.WriteLine("Main Method Started...");
            AsynchronousClass asynchronousClass = new AsynchronousClass();
            asynchronousClass.DisplayAsync();
            //asynchronousClass.DisplayNormal();
            Console.WriteLine("Main Method Stopped...");
            Console.ReadLine();




        }
    }

}
