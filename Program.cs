namespace Interns.Maersk.DemoProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 10;
            int sum = 0;
            int j = 0;
            for (int i = 0; i < m; i++)
            {
                sum += i;
            }

            Console.WriteLine("Hello, my value is {0}!", sum);
        }
    }
}