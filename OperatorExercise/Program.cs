namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder} ");
            }

            Console.WriteLine("What is the radius of your circle?");
            Console.WriteLine("20");
            AreaOfCircle(20);
            Console.WriteLine($"The area of a circle of 20 is {AreaOfCircle(20)}");

        }
        public static double AreaOfCircle(double radius)
        {
            double answer = Math.PI * Math.Pow(radius, 2);
            return answer;
        }
    }
}
