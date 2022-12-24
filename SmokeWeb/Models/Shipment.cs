namespace SmokeWeb.Models;

public class Shipment
{
    public int id { get; set; }
    public int productid  { get; set; }
    
    public string name { get; set; }
    public double price { get; set; }
    public int amount { get; set; }
    public DateTime dateof { get; set; } 
    
    
    
}