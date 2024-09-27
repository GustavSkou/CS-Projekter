class ProductNotFoundException : Exception 
{
    public ProductNotFoundException(string message) : base(message) {}
}

class ProductSystem : Product
{
    public Dictionary<string, Product> productLookUp = new Dictionary<string, Product>();

    public List<Product> readProducts() 
    {
        getJsonFile(@"C:\Users\gusta\Desktop\c#\CS-Projekter\LidlLagerSystem\produkter.json");
        return productsList.AllProducts;
    }
    
    public void CreateLookUpTable(List<Product> products)
    {
        foreach (var someProduct in products) 
        {
            productLookUp.Add(someProduct.Name, someProduct);
        }
        Console.WriteLine("LookUpTable Created");
    }

    protected double getPrice(string productName)
    {
        try 
        {
            return productLookUp[productName].Price;
        }
        catch(KeyNotFoundException)
        {
            throw new ProductNotFoundException($"{productName} was not found in system");
        }
    }

    protected int getUnitCount(string productName)
    {
        try 
        {
            return productLookUp[productName].UnitsInStorage;
        }
        catch(KeyNotFoundException)
        {
            throw new ProductNotFoundException($"{productName} was not found in system");
        }
    }
}

