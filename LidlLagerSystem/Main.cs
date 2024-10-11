class Program
{
    static void Main()
    {
        Ui newUi = new Ui();
        
        do
        {
            newUi.Run();
        }
        while(newUi.isRunning);
    }
}