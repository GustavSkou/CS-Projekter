class Program
{
    static void Main()
    {
        Product list = new Product();
        list.readJsonFile(@"C:\Users\gusta\Desktop\c#\CS-Projekter\LidlLagerSystem\produkter.json");
        ProductSystem lidlSystem = new ProductSystem();

        lidlSystem.CreateLookUpTable(list.productsList.AllProducts);

        Ui ui = new Ui(lidlSystem);

        do
        {
            ui.Run();
        }
        while(ui.isRunning);
    }
}