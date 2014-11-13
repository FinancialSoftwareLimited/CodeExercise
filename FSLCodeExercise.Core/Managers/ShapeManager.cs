using System;
using FSLCodeExercise.Core.Models;

namespace FSLCodeExercise.Core.Managers
{
    //  Identify potential problems that could be encountered in developing and/or maintaining a system that uses the code as it is written
    //  _ Accessibility Levels where not defined (most offensive code)
    //  _ It was not scalable
    //  _ You would have to create an instace every time you wanted to use the class
    //  _ It was not respecting any naming convention (most offensive code)
   
    //  Describe why the refactored code is better than the previous code
    //  _ Class is public now.
    //  _ It was modified to use a singleton pattern with lazy loading
    //      _ Lazy Instantiation will not use memory until the property or function is first called.
    //      _ Only one Instance of ShapeManager is created. Sharing a single instance of that class with many threads will save resources and time. 
    //      _ Singleton Class instance can be passed as a parameter to another method
    //  _ Shapes Model was created to be alble to use everywhere
    //  _ EquilateralTriangle formula was wrong
    //  _ The parameters are not passed in the constructor anymore. Now they are used only by Area (where they are needed).

    //  Describe what you would do if you had longer than 2 hours to complete these exercises.:
    //  _ Custom Exceptions
    //  _ Load Tests

    public class ShapeManager
    {
        private static readonly Lazy<ShapeManager> LazyInstance = new Lazy<ShapeManager>(() => new ShapeManager());
        public  static ShapeManager Instance { get { return LazyInstance.Value; } }

        // _ Now acepts parameters 
        public double Area(int type, double width)
        {
            switch (type)
            {
                case ShapesModel.Square:
                    return width * width;

                case ShapesModel.Circle: //A = π* (r)^2
                    var r = width / 2;
                    return Math.PI * r * r;
                
                case ShapesModel.EquilateralTriangle: // A = (Math.Sqrt(3) / 4) * (w)^2
                    return (Math.Sqrt(3) / 4) * width * width;

                default:
                    throw new InvalidProgramException("Unknown shape type encountered: " + type);
            }
        }
    }
}
