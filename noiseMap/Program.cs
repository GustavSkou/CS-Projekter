class Program
{
    static void Main()
    {
        Random rand = new Random();

        int[,] map = new int[10, 10];

        for (int row = 0; row < 10; row++)
        {
            for (int column = 0; column < 10; column++)
            {
                map[row, column] = rand.Next(0, 10);
            }
        }

        for (int row = 0; row < 10; row++)
        {
            Console.WriteLine();
            
            for (int column = 0; column < 10; column++)
            {
                Console.Write(map[row, column] + " ");
            }
        }

    }
}
