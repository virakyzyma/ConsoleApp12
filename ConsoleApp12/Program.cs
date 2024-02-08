namespace ConsoleApp12
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of cubes: ");
            int cub = int.Parse(Console.ReadLine());

            Console.WriteLine($"Count -> { Result(cub)}");
        }
        static int Result(int a, int i = 2, int count = 0)
        {
            if(a>0)
            {
                return Result(a-i, i+1, count + 1);
            }
            else
            {
                return count;
            }
        }
    }
}
