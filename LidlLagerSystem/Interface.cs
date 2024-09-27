class Ui : Commands
{
    private ProductSystem system;
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