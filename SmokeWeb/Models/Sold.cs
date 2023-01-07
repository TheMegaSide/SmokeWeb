namespace SmokeWeb.Models;

public class Sold
{
    public int id { get; set; }
    
    public int client { get; set; }
    public int[] products { get; set; }

    public DateTime dateof { get; set; }
    public string state { get; set; }
    
    
  

}