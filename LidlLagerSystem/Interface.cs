class Ui : Commands
{
    public bool isRunning = false;
    public Dictionary<string, Action> commandList = new Dictionary<string, Action>();
    
    public void Run ()
    {
        string[] command = GetUserCommand();
        UseCommands(command);
        isRunning = command[0] != "exit" ? true : false;
    }

    private string[] GetUserCommand()
    {
        
        string input = Console.ReadLine();  
        string[] command = input.ToLower().Split(' ');  //lower letters and spilt the command up in 2 The function and parameter

        return command;
    }
}