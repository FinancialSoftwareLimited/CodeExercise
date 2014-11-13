using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSLCodeExercise.Core.Helpers
{
    public static class ReadLineHelper
    {
        public static int IntValue()
        {
            int value;
            int.TryParse(Console.ReadLine(), out value);

            while (value == 0)
            {
                Console.WriteLine("*************************** BAD REQUEST ***************************");
                Console.WriteLine("Do you want a square (1), circle (2), or equilateral triangle (3): ");

                int.TryParse(Console.ReadLine(), out value);
            }

            return value;
        }

        public static double DoubleValue()
        {
            double value;
            double.TryParse(Console.ReadLine(), out value);

            while (Equals(value, 0.00))
            {
                Console.WriteLine("************************* BAD REQUEST *************************");
                Console.WriteLine("Enter the shape's primary dimension (width, radius, or base):  ");

                double.TryParse(Console.ReadLine(), out value);
            }
            return value;
        }
    }
}
