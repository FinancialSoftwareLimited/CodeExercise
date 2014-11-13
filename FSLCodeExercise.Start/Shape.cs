using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FSLCodeExercise.Start
{
    /// <summary>
    ///  UPDATES:
    ///  _ Class is public and sealed now.
    ///  _ It was modified to use a singleton pattern with lazy loading
    /// </summary>
    public sealed class Shape
    {
        private static readonly Lazy<Shape> LazyInstance = new Lazy<Shape>(() => new Shape());
        public static Shape Instance { get { return LazyInstance.Value; } }

        public Shape()
        {

        }

        // Fixed naming convention for private constants
        private const int Square = 1;
        private const int Circle = 2;
        private const int EquilateralTriangle = 3;

        
        // _ Now acepts parameters 
        // _ Added validation to the parameters
        public double Area(int type, double width)
        {
            switch (type)
            {
                case Square:
                    return width * width;

                case Circle:
                    return Math.PI * (width / 2) * (width / 2);

                case EquilateralTriangle:
                    return (Math.Sqrt(4) / 3) * width * width;

                default:
                    throw new InvalidProgramException("Unknown shape type encountered: " + type);
            }
        }
    }
}

