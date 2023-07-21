namespace MethodsExample
{
    public class Program
    {
        static void Main(string[] args)
        {            
            Greet("Seth");

            string macksName = "Mack";

            Greet(macksName);

            int twoPlusTwo = Add(2, 2);
            Console.WriteLine(twoPlusTwo);

            Console.WriteLine(Add(3, 3));

            double tenTimesTen = Multiply(10.0, 10.0);
            Console.WriteLine(tenTimesTen);

            GreetAnon();
        }

        //Parts of a method
        //Access modifier - Return type - Name - Parameter list - Scope (body)
        public static void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static double Multiply(double num1, double num2)
        {

            return num1 * num2;
            Console.WriteLine(num1 * num2);
        }

        public static void GreetAnon()
        {
            Console.WriteLine("Hello, friend!");
        }
    }
}