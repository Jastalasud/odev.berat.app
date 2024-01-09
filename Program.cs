namespace odev.berat.app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("Enter The Start Number:");
            int baslangic = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Finish Number:");
            int bitis = int.Parse(Console.ReadLine());

            Console.WriteLine("Select how many numbers to enter:");
            int count = int.Parse(Console.ReadLine());


            int[] numbers = new int[count];
            int num;
            for (int i = 0; i < numbers.Length; i++)
            {
                num = rnd.Next(baslangic, bitis);
                if (i == 0)
                {
                    numbers[i] = num;
                }
                for (int a = 0; a < i; a++)
                {
                    if (numbers[a] == num)
                    {
                        i--;
                        break;
                    }
                    else
                    {
                        numbers[i] = num;
                    }
                }
            }
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}