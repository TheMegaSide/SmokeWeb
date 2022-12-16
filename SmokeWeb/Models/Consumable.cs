namespace SmokeWeb.Models;

public class Consumable
{
    public int id { get; set; }
    public string name { get; set; }
    public double price { get; set; } 
    public string desc { get; set; }
    public bool isAvailable { get; set; }

}