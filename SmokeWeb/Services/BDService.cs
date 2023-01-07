using SmokeWeb.Models;
using SmokeWeb.Util.DB;
using SmokeWeb.Util.DBHandlers;


namespace SmokeWeb.Services;

public class BDService
{
    //Данный клас получает данные от страниц сайта и передает базе данных и наоборот
    public readonly string ConnectionString;

    public BDService(IConfiguration configuration)
    {
        ConnectionString = configuration.GetConnectionString("NpgsqlConnection");
    }
    //Данный метод получает все записи из таблицы подов
     public List<Pod> GetAllPods()
    {
        string comText =
            "select id, name, price, description, \"isAvailable\", count  from products where category =1";
        return DbExecutor.Execute<Pod>(ConnectionString, comText, new PodHandler());
    }
    //Данный метод находит один под по его id
    public Pod GetPodById(int id)
    {
        string comText = "select id, name, price, description, \"isAvailable\", count from  products where id="+id;
        return DbExecutor.Execute<Pod>(ConnectionString, comText, new PodHandler())[0];
    }
    //Метод редактирования пода
    public void  EditPod(Pod pod)
    {
        string comText = "update products " +
                         "set name='"+pod.name+"', price="+pod.price.ToString().Replace(',','.')+", description='"+pod.desc+"', \"isAvailable\"='"+pod.isAvailable+"', count="+pod.count+" " +
                         "where id="+pod.id;
        Console.WriteLine($"INFO:{comText}");
        DbExecutor.Execute(ConnectionString, comText, new PodHandler());
    }
    //Удаление пода
    public void DeletePod(Pod pod)
    {
        string comText = "delete from products where id="+pod.id;
        DbExecutor.Execute(ConnectionString, comText, new PodHandler());
    }
    //Добавление пода
    public void AddPod(Pod pod)
    {
        string comText = "insert into products (name, price, description, \"isAvailable\", count, category) " +
                         "values('" + pod.name + "','" + pod.price.ToString().Replace(',','.') + "','" + pod.desc + "','" + pod.isAvailable + "'," +
                         pod.count + ",1)";
        
                         
        DbExecutor.Execute(ConnectionString, comText, new PodHandler());
    }

    public List<Liquid> GetAllLiquids()
    {
        string comText = "Select id, name, price, description, \"isAvailable\", count from products where category=3";
        return DbExecutor.Execute<Liquid>(ConnectionString, comText, new LiquidHandler());
    }
    
    public Liquid GetLiquidById(int id)
    {
        string comText = "Select id, name, price, description, \"isAvailable\", count from products where id="+id;
        return DbExecutor.Execute<Liquid>(ConnectionString, comText, new LiquidHandler())[0];
    }

    public void EditLiquid(Liquid liquid)
    {
        string comText = "update products " +
                         "set name='"+liquid.name+"', price="+liquid.price.ToString().Replace(',','.')+", description='"+liquid.desc+"', \"isAvailable\"='"+liquid.isAvailable+"', count="+liquid.count+" " +
                         "where id="+liquid.id;
        Console.WriteLine($"INFO:{comText}");
        DbExecutor.Execute(ConnectionString, comText, new LiquidHandler());
    }

    public void DeleteLiquid(Liquid liquid)
    {
        string comText = "delete from products where id="+liquid.id;
        DbExecutor.Execute(ConnectionString, comText, new LiquidHandler());
    }

    public void AddLiquid(Liquid liquid)
    {
        string comText = "insert into products (name, price, description, \"isAvailable\",count, category) " +
                         "values('"+liquid.name+"',"+liquid.price.ToString().Replace(',','.')+",'"+liquid.desc+"','"+liquid.isAvailable+"',"+liquid.count+",3)";
                         
        DbExecutor.Execute(ConnectionString, comText, new LiquidHandler());
    }
    
    public List<Onetime> GetAllOnetimes()
    {
        string comText = "Select id, name, price, description, \"isAvailable\", count from products where category =2";
        return DbExecutor.Execute<Onetime>(ConnectionString, comText, new OnetimeHandler());
    }
    
    public Onetime GetOnetimeById(int id)
    {
        string comText = "Select id, name, price, description, \"isAvailable\", count from onetimes where id="+id;
        return DbExecutor.Execute<Onetime>(ConnectionString, comText, new OnetimeHandler())[0];
    }

    public void EditOnetime(Onetime onetime)
    {
        string comText = "update products " +
                         "set name='"+onetime.name+"', price="+onetime.price.ToString().Replace(',','.')+", description='"+onetime.desc+"', \"isAvailable\"='"+onetime.isAvailable+"', count="+onetime.count +
                         "where id="+onetime.id;
        Console.WriteLine($"INFO:{comText}");
        DbExecutor.Execute(ConnectionString, comText, new OnetimeHandler());
    }

    public void DeleteOnetime(Onetime onetime)
    {
        string comText = "delete from products where id="+onetime.id;
        DbExecutor.Execute(ConnectionString, comText, new OnetimeHandler());
    }

    public void AddOnetime(Onetime onetime)
    {
        string comText = "insert into products(name, price, description, \"isAvailable\", count, category) " +
                         "values('"+onetime.name+"',"+onetime.price.ToString().Replace(',','.')+",'"+onetime.desc+"','"+onetime.isAvailable+"',"+onetime.count+",2)";
                         
        DbExecutor.Execute(ConnectionString, comText, new LiquidHandler());
    }
    
    public List<Consumable> GetAllConsumables()
    {
        string comText = "Select id, name, price, description, \"isAvailable\", count from products where category =4";
        return DbExecutor.Execute<Consumable>(ConnectionString, comText, new ConsumableHandler());
    }
    
    public Consumable GetConsumableById(int id)
    {
        string comText = "Select id, name, price, description, \"isAvailable\", count from products where id="+id;
        return DbExecutor.Execute<Consumable>(ConnectionString, comText, new ConsumableHandler())[0];
    }

    public void EditConsumable(Consumable consumable)
    {
        string comText = "update products " +
                         "set name='"+consumable.name+"', price="+consumable.price.ToString().Replace(',','.')+", description='"+consumable.desc+"', \"isAvailable\"='"+consumable.isAvailable+"' , count="+consumable.count +
                         "where id="+consumable.id;
        Console.WriteLine($"INFO:{comText}");
        DbExecutor.Execute(ConnectionString, comText, new ConsumableHandler());
    }

    public void DeleteConsumable(Consumable consumable)
    {
        string comText = "delete from products where id="+consumable.id;
        DbExecutor.Execute(ConnectionString, comText, new ConsumableHandler());
    }

    public void AddConsumable(Consumable consumable)
    {
        string comText = "insert into products (name, price, description, \"isAvailable\", count, category) " +
                         "values('"+consumable.name+"',"+consumable.price.ToString().Replace(',','.')
                         +",'"+consumable.desc+"','"+consumable.isAvailable+"',"+consumable.count+", 4)";
                         
        DbExecutor.Execute(ConnectionString, comText, new ConsumableHandler());
    }
    
    
    public List<Shipment> GetPodShipments()
    {
        string comText = "select shipment.id, products.id as productid, name, shipment.price,  shipment.amount, dateof from products, shipment "+
        "where shipment.productid=products.id and products.category = 1";
        return DbExecutor.Execute<Shipment>(ConnectionString, comText, new ShipmentHandler());
    } 
    public List<Shipment> GetOnetimeShipments()
    {
        string comText = "select shipment.id, products.id as productid, name, shipment.price,  shipment.amount, dateof from products, shipment "+
                         "where shipment.productid=products.id and products.category = 2";
        return DbExecutor.Execute<Shipment>(ConnectionString, comText, new ShipmentHandler());
    }
    public List<Shipment> GetLiquidShipments()
    {
        string comText = "select shipment.id, products.id as productid, name, shipment.price,  shipment.amount, dateof from products, shipment "+
                         "where shipment.productid=products.id and products.category = 3";
        return DbExecutor.Execute<Shipment>(ConnectionString, comText, new ShipmentHandler());
    }
    public List<Shipment> GetConsumablesShipments()
    {
        string comText = "select shipment.id, products.id as productid, name, shipment.price,  shipment.amount, dateof from products, shipment "+
                         "where shipment.productid=products.id and products.category = 4";
        return DbExecutor.Execute<Shipment>(ConnectionString, comText, new ShipmentHandler());
    }
    public void AddShipment(Shipment shipment, int category)
    {
        string comText = "insert into shipment (productid, dateof, amount, price,category) " +
                         "values("+shipment.productid+",'"+DateTime.Now+"'"
                         +","+shipment.amount+",'"+shipment.price.ToString().Replace(',','.')+"',"+category+")";
        
                         
        DbExecutor.Execute(ConnectionString, comText, new ShipmentHandler());
        
            comText = "update products set price="+shipment.price.ToString().Replace(',','.')+", count=count+"+shipment.amount+" where id="+shipment.productid;
        
        DbExecutor.Execute(ConnectionString, comText, new ShipmentHandler());
    }

    public List<Sold> GetAllSold()
    {
        string comText = "select * from sold";
        return DbExecutor.Execute<Sold>(ConnectionString, comText, new SoldHandler());
    }

    public List<Pod> GetAllProducts()
    {
        string comText = "select id, name, price, description, \"isAvailable\", count from products";
        return DbExecutor.Execute<Pod>(ConnectionString, comText, new PodHandler());
    }

    public List<Client> GetAllClients()
    {
        string comText = "select * from clients";
        return DbExecutor.Execute<Client>(ConnectionString, comText, new ClientHandler());
    }
}
