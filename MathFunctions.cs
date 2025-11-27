using System;

namespace CSharpTutorials.MathFunctions
{
    class MathFunctions
    {
        static void Main(string[] args)
        {
            int x = 0;

            x = Math.Max(5, 10);
            Console.WriteLine(x);
            
            x = Math.Min(5, 10);
            Console.WriteLine(x);

            double dx = Convert.ToDouble(x);

            dx = Math.Sqrt(64);
            Console.WriteLine(dx); 
            
            dx = Math.Abs(-4.7);
            Console.WriteLine(dx);

            dx = Math.Round(9.99);
            /*
             double x = Math.Round(3.6);   // 4
             double y = Math.Round(3.4);   // 3

            double x = Math.Round(3.4567, 2);   // 3.46
            double y = Math.Round(9.999, 1);    // 10.0

            C# uses Banker’s Rounding (round to even) by default:

            Math.Round(2.5); → 2
            Math.Round(3.5); → 4

            If you want traditional rounding (always round .5 up), use:

            Math.Round(2.5, MidpointRounding.AwayFromZero); // 3
             */
            Console.WriteLine(dx);
        }

        private static int LetSayAMethodDoesNotExist(int v)
        {
            throw new NotImplementedException();
        }
    }
}

/*
 * namespace CSharpTutorials.Math
    {
        class Math
        {
            ...
        }
    }
 * Gives Error that Max, Min etc does not exist in math class
 * Getting the error because we created own class named Math, which overrides/hides the built-in System.Math class.  
 * C# thinks I am calling my own Math class, which does NOT contain Sqrt, Max, Min, Abs, Round, etc.
 * Solution : 1. Rename Class
              2. Call System.Math explicitly
                        x = System.Math.Max(5, 10);
                        x = System.Math.Min(5, 10);
 */

/*
 * Math.Sqrt, Math.Abs, and Math.Round return double, not int.
 */
