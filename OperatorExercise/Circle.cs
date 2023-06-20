using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercise
{
    internal class Circle
    {
        public static void AreaOfCircle()
        {
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
        }
    }
}
