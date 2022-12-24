namespace SmokeWeb.Models;

public class Sold
{
    public int id { get; set; }
    public int productid { get; set; }

    public DateTime dateof { get; set; }
    public double price { get; set; }
    public string clientphone { get; set; }
    public string clientaddress { get; set; }
    public int category { get; set; }

}