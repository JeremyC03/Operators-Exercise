using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercise
{
    internal class Circle
    {
        public static double AreaOfCircle(double radius)
        {
            double answer = Math.PI * Math.Pow(radius, 2);
            return answer;
        }
    }
}
