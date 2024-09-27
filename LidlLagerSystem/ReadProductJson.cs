using System.Text.Json;
public class Product
{
    public string Name {get; set;}    
    public double Price {get; set;}
    public int UnitsInStorage {get; set;}    
    public List<Product> AllProducts { get; set; } 
    public Product productsList;

    public void readJsonFile(string fileLocation)
    {
        string text = File.ReadAllText(fileLocation);
        productsList = JsonSerializer.Deserialize<Product>(text);
    }
}