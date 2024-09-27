class Ui
{
    public Commands commands;
    public ProductSystem system;
    public bool isRunning = false;
    public Dictionary<string, Action> commandList = new Dictionary<string, Action>();
 
    public Ui (ProductSystem system)
    {
        this.system = system; 
        
    }
    
    public void Run ()
    {
        isRunning = true;
        
        UseCommands( GetUserCommand() );
    }

    private void UseCommands(string[] command)
    {
        switch ( command[ 0 ] )
        {
            case "getprice":
                Console.WriteLine( system.getPrice( command[ 1 ] ) );
            break;
            
            case "getunitcount":
                Console.WriteLine( system.getUnitCount( command[ 1 ] ) );
            break;

            case "getallunits":
                foreach (var item in system.productLookUp)
                {
                    Console.WriteLine(item);
                }
            break;

            case "exit":
                Exit ();
            break;
        }
    }

    private string[] GetUserCommand()
    {
        
        string input = Console.ReadLine();  
        string[] command = input.ToLower().Split(' ');  //lower letters and spilt the command up in 2 The function and parameter

        return command;
    }

    public void Exit ()
    {
        isRunning = false;
    }
}