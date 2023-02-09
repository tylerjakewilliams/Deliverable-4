namespace Deliverable_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("These are the first 25 numbers of the Fibonacci sequence:");
            int[] fibonacci = new int[25];

            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 0; i < 25; i++)
            {
                if (i >= 2)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }
            }

            foreach (int number in fibonacci)
            {
                Console.WriteLine(number);
            }
        }
    }
}