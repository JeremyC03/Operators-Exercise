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
                Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
            }

            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());

            var answer = Circle.AreaOfCircle(radius);
            Console.WriteLine($"The area of a circle of {radius} is {answer}");

        }
    }
}
