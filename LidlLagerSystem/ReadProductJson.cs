using System.Text.Json;
class Product
{
    public string Name {get; set;}    
    public double Price {get; set;}
    public int UnitsInStorage {get; set;}    
    public List<Product> AllProducts { get; set; } 
    public Product productsList;

    public Product getJsonFile(string fileLocation)
    {
        string text = File.ReadAllText(fileLocation);
        productsList = JsonSerializer.Deserialize<Product>(text);
        return productsList;
    }
}