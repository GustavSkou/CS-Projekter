using System.Data;

class Map{
    public int rows, columns;
    public char[,] map;

    public Map(int rowsInput, int columnsInput)
    {
        rows = rowsInput;
        columns = columnsInput;
        map = new char[rows, columns];
        buildMap();
    }

    void buildMap(){
        for(int row = 0; row < rows; row++)
        {
            for(int column = 0; column < columns; column++)
            {
                map[row, column] = '.';
            }
        }
    }
    public void printMap(){
        
        Console.Clear();

        for(int row = 0; row < rows; row++)
        {
            Console.WriteLine();
            for(int column = 0; column < columns; column++)
            {
                Console.Write("{0,3}", map[row, column]);
            }
        }
    }


}

class Player 
{
    public int row, column;
    public char model = '¤';

    public void spawn(Map gameMap)
    {
        gameMap.map[0, 0] = model;
        gameMap.printMap();
    }

    void move()
    {

    }
}
class Game
{
    public void tick()
    {
        while (true)
        {
            var movement = Console.ReadKey(false).Key;
            if (movement ==  ConsoleKey.W || movement == ConsoleKey.A || movement == ConsoleKey.D || movement == ConsoleKey.S)
            {
                
            }
        }
    }
}
class Program
{
    static void Main()
    {
        Map gameMap = new Map(10, 10);
        gameMap.printMap();
        
        Player player = new Player();
        player.spawn(gameMap);

        Game newGame = new Game();
        newGame.tick();

    }
}