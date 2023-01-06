namespace PartTimeWages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ISPARTTIME = 1;
            int ISFULLTIME = 2;
            int EMPRATEPERHOUR = 20;
            int emphrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == ISPARTTIME)
            {
                emphrs = 4;

            }
            else if (empCheck == ISFULLTIME)
            {
                emphrs = 8;
            }
            else
            {
                emphrs = 0;
            }
            empWage = emphrs * EMPRATEPERHOUR;
            Console.WriteLine("Emp Wage :" + empWage);
            Console.WriteLine("Hello, World!");
        }
    }
}