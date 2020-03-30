using System;

namespace CSharp_ClassSubmission_FirstExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter array length");
            string fNumber_s = Console.ReadLine();
            Console.WriteLine("please enter multiplication number");
            string sNumber_s = Console.ReadLine();

            int fNumber_int=Convert.ToInt32(fNumber_s);
            int sNumber_int = Convert.ToInt32(sNumber_s);

            int[] arr = new int[fNumber_int];
            int i = 0;
            for ( ; i<arr.Length; i++)
            {
                arr[i] = i * sNumber_int;
            }

            Console.WriteLine($"num of elements: {fNumber_int}");
            Console.WriteLine($"num of mul: {sNumber_int}");
            Console.Write("array content: ");
            for (i=0 ; i<arr.Length; i++ )
            {
                Console.Write(arr[i] + " ");
            }

        }
    }
}
