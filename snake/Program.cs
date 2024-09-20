class Map{
    public int rows, columns;
    public char emptyCell = '.';
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
    public Player()
    {
        row = 0;
        column = 0;
    }

    public void spawn(Map gameMap)
    {
        gameMap.map[row, column] = model;
        gameMap.printMap();
    }

    public void movement(Game.WASD input, Map gameMap)
    {
        int inputNum = (int) input;
        
        gameMap.map[row, column] = gameMap.emptyCell;

        switch(inputNum)
        {
            case 0:
                row--;
                break;
            case 1:
                column--;
                break;
            case 2:
                row++;
                break;
            case 3:
                column++;
                break;
            default:
                gameMap.map[row, column] = model; //Bug here, walk up then default?!
                break;
        }

        gameMap.map[row, column] = model;
        gameMap.printMap();
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

class Point
{
    public int row, column;

    public int pointScore = 1;
    public Point()
    {
        
    }

    public void spawn(Map gameMap)
    {
        Random ran = new Random();
        row = ran.Next(10);
        column = ran.Next(10);

        gameMap.map[row, column] = 'a';
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

        Point points = new Point();
        points.spawn(gameMap);

        while(newGame.run)
        {
            player.movement(newGame.UpdateMovement(), gameMap);
        }
    }
}