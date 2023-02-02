namespace OperatorExercise
{
    public class Program
    {
        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);

            return area;
        }

        static void Main(string[] args)
        {
            //Exercise1

            //Addition Operator
            int x = 10;
            int y = 20;
            x += y;
            Console.WriteLine(x);

            //Subtraction Operator
            x = 10;
            y = 5;
            x -= y;
            Console.WriteLine(x);

            //Multiplication Operator
            x = 10;
            y = 5;
            x *= y;
            Console.WriteLine(x);

            //Division Operator
            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            Console.WriteLine($"What is the radius of your circle ?");
            var userInput = Console.ReadLine();
            var radius = double.Parse(userInput);

            Console.WriteLine(AreaOfCircle(radius));
        }
    }   
}
