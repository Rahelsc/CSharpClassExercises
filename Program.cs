using ImTools;
using System;
using System.Net;

namespace lesson5_ClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Cookie cookie1 = new Cookie();
            Cookie cookie2 = new Cookie();
            Cookie cookie3 = new Cookie();
            Console.WriteLine("please enter is gluten");
            cookie1.IsGlutenFree = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("please enter is q sugar");
            cookie1.SugarQuantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter is q flower");
            cookie1.FlowerQuantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter is q eggs");
            cookie1.NumberOfEggs = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter is gluten");
            cookie2.IsGlutenFree = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("please enter is q sugar");
            cookie2.SugarQuantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter is q flower");
            cookie2.FlowerQuantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter is q eggs");
            cookie2.NumberOfEggs = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(printingCookie(cookie1)); // using the function
            Console.WriteLine(printingCookie(cookie2));

            cookie1.SugarQuantity = 5;

            Console.WriteLine(cookie1.GetDescription()); // using class property
            Console.WriteLine(cookie2.GetDescription());

            cookie2 = cookie1;

            cookie2.NumberOfEggs = 1;

            Console.WriteLine(cookie1.GetDescription());
            Console.WriteLine(cookie2.GetDescription());

            //because they point to the same place

            Car car1 = new Car();
            Console.WriteLine(car1.CurrentSpeed);

            Console.WriteLine("do you want to accelerate? how much?");

            car1.Accelerate(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine(car1.CurrentSpeed);

            car1.Deccelerate(2);
            Console.WriteLine(car1.CurrentSpeed);

            car1.Stop();
            Console.WriteLine(car1.CurrentSpeed);
        }

        public static string printingCookie(Cookie c)
        {
            return $" is glutenFree: {c.IsGlutenFree} \n " +
                    $"flower: {c.FlowerQuantity} \n" +
                    $"sugar: {c.SugarQuantity} \n" +
                    $"eggs: {c.NumberOfEggs}";
        }
    }
}
