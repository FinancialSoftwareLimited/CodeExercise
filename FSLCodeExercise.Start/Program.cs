using FSLCodeExercise.Core.Helpers;
using FSLCodeExercise.Core.Managers;
using System;

namespace FSLCodeExercise.Start
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("FSL Code Exercise v1.0");
            Console.WriteLine();
            Console.WriteLine("Calculates and prints information for a user-supplied shape and width");
            Console.WriteLine("---------------------------------------------------------------------");

            // UPDATED : Added Helper to always get a valid value
            Console.WriteLine("Do you want a square (1), circle (2), or equilateral triangle (3): ");
            var type = ReadLineHelper.IntValue();

            Console.WriteLine("Enter the shape's primary dimension (width, radius, or base): ");
            var width = ReadLineHelper.DoubleValue();

            // UPDATED: Because we are using singleton now, we don't need a new instance of Shape
            // Shape s = new Shape(type, width);
            var area = ShapeManager.Instance.Area(type, width);

            Console.WriteLine();
            Console.WriteLine("Shape properties:");
            Console.WriteLine("\tWidth: " + width);
            Console.WriteLine("\tArea: " + area);
        }
    }
}
