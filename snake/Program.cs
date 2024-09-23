class Map{
    public int rows, columns;
    public char emptyCell = '.';
    public char apple = 'a';
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
                map[row, column] = emptyCell;
            }
        }
    }

    public void printMap(){

        //Console.Clear();

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
    public char model = '¤';
    public List<int[]> snakePosition = new();

    public Player()
    {
        int[] position = {0, 0};
        snakePosition.Add(position);
    }

    public void spawn(Map gameMap)
    {
        gameMap.map[snakePosition[0][0], snakePosition[0][1]] = model;
        gameMap.printMap();
    }

    public void movement(Game.WASD input, Map gameMap)
    {
        int inputNum = (int) input;
        int[] snakeTail = snakePosition[snakePosition.Count - 1];
        gameMap.map[snakePosition[snakePosition.Count - 1][0], snakePosition[snakePosition.Count - 1][1]] = gameMap.emptyCell;

        Console.WriteLine(snakeTail[0] + " " + snakeTail[1]);

        switch(inputNum)
        {
            case 0:
                snakePosition[0][0]--;
                break;
            case 1:
                snakePosition[0][1]--;
                break;
            case 2:
                snakePosition[0][0]++;
                break;
            case 3:
                snakePosition[0][1]++;
                break;
            default:
                gameMap.map[snakePosition[0][0], snakePosition[0][1]] = model;
                break;
        }

        if (gameMap.map[snakePosition[0][0], snakePosition[0][1]] == gameMap.apple)
        {
            expandSnake(snakeTail);
        }

        for (int i = 0; i < snakePosition.Count(); i++)
        {
            gameMap.map[snakePosition[i][0], snakePosition[i][1] ] = model;
            Console.WriteLine(snakePosition[i][0] + " " + snakePosition[i][1]);
        }
        
        gameMap.printMap();
    }

    void expandSnake(int[] tailPosition)
    {
        snakePosition.Add(tailPosition);
        Console.WriteLine("Her");
    }
}

class Game
{
    public bool run = false;
    public Game(bool start)
    {
        run = start;
    }

    public enum WASD
    {
        W,
        A,
        S,
        D
    }
    public WASD UpdateMovement()
    {
        var movement = Console.ReadKey(false).Key;

        if (movement == ConsoleKey.W)
        {
            return WASD.W;
        }
        if (movement == ConsoleKey.A)
        {
            return WASD.A;
        }
        if (movement == ConsoleKey.S)
        {
            return WASD.S;
        }
        if (movement == ConsoleKey.D)
        {
            return WASD.D;
        }
        return 0;
    }
}

class Item
{
    public int row, column;

    public int pointValue = 1;

    public void spawn(Map gameMap)
    {
        Random ran = new Random();
        row = ran.Next(10);
        column = ran.Next(10);

        gameMap.map[row, column] = gameMap.apple;
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

        Game newGame = new Game(true);

        Item points = new Item();
        points.spawn(gameMap);

        while(newGame.run)
        {
            player.movement(newGame.UpdateMovement(), gameMap);
        }
    }
}