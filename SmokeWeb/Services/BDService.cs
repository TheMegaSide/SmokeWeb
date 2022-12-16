using SmokeWeb.Models;
using SmokeWeb.Util.DB;
using SmokeWeb.Util.DBHandlers;

namespace SmokeWeb.Services;

public class BDService
{
    public readonly string ConnectionString;

    public BDService(IConfiguration configuration)
    {
        ConnectionString = configuration.GetConnectionString("NpgsqlConnection");
    }

    public List<Pod> GetAllPods()
    {
        string comText =
            "select *  from pods";
        return DbExecutor.Execute<Pod>(ConnectionString, comText, new PodHandler());
    }

    public Pod GetPodById(int id)
    {
        string comText = "select * from  pods where id="+id;
        return DbExecutor.Execute<Pod>(ConnectionString, comText, new PodHandler())[0];
    }

    public void  EditPod(Pod pod)
    {
        string comText = "update pods set name='"+pod.name+"', price="+pod.price+", description='"+pod.desc+"', \"isAvailable\"='"+pod.isAvailable+"' where id="+pod.id;
        Console.WriteLine($"INFO:{comText}");
        DbExecutor.Execute(ConnectionString, comText, new PodHandler());
    }

    public void DeletePod(Pod pod)
    {
        string comText = "delete from pods where id="+pod.id;
        DbExecutor.Execute(ConnectionString, comText, new PodHandler());
    }

    public void AddPod(Pod pod)
    {
        string comText = "insert into pods (name, price, description, \"isAvailable\") values('"+pod.name+"',"+pod.price+",'"+pod.desc+"','"+pod.isAvailable+"')";
                         
        DbExecutor.Execute(ConnectionString, comText, new PodHandler());
    }

    public List<Liquid> GetAllLiquids()
    {
        string comText = "Select * from liquids";
        return DbExecutor.Execute<Liquid>(ConnectionString, comText, new LiquidHandler());
    }
    
    public Liquid GetLiquidById(int id)
    {
        string comText = "Select * from liquids where id="+id;
        return DbExecutor.Execute<Liquid>(ConnectionString, comText, new LiquidHandler())[0];
    }

    public void EditLiquid(Liquid liquid)
    {
        string comText = "update liquids set name='"+liquid.name+"', price="+liquid.price+", description='"+liquid.desc+"', \"isAvailable\"='"+liquid.isAvailable+"' where id="+liquid.id;
        Console.WriteLine($"INFO:{comText}");
        DbExecutor.Execute(ConnectionString, comText, new LiquidHandler());
    }

    public void DeleteLiquid(Liquid liquid)
    {
        string comText = "delete from liquids where id="+liquid.id;
        DbExecutor.Execute(ConnectionString, comText, new LiquidHandler());
    }

    public void AddLiquid(Liquid liquid)
    {
        string comText = "insert into liquids (name, price, description, \"isAvailable\") values('"+liquid.name+"',"+liquid.price+",'"+liquid.desc+"','"+liquid.isAvailable+"')";
                         
        DbExecutor.Execute(ConnectionString, comText, new LiquidHandler());
    }
    
    public List<Onetime> GetAllOnetimes()
    {
        string comText = "Select * from onetimes";
        return DbExecutor.Execute<Onetime>(ConnectionString, comText, new OnetimeHandler());
    }
    
    public Onetime GetOnetimeById(int id)
    {
        string comText = "Select * from onetimes where id="+id;
        return DbExecutor.Execute<Onetime>(ConnectionString, comText, new OnetimeHandler())[0];
    }

    public void EditOnetime(Onetime onetime)
    {
        string comText = "update onetimes set name='"+onetime.name+"', price="+onetime.price+", description='"+onetime.desc+"', \"isAvailable\"='"+onetime.isAvailable+"' where id="+onetime.id;
        Console.WriteLine($"INFO:{comText}");
        DbExecutor.Execute(ConnectionString, comText, new OnetimeHandler());
    }

    public void DeleteOnetime(Onetime onetime)
    {
        string comText = "delete from onetimes where id="+onetime.id;
        DbExecutor.Execute(ConnectionString, comText, new OnetimeHandler());
    }

    public void AddOnetime(Onetime onetime)
    {
        string comText = "insert into onetimes (name, price, description, \"isAvailable\") values('"+onetime.name+"',"+onetime.price+",'"+onetime.desc+"','"+onetime.isAvailable+"')";
                         
        DbExecutor.Execute(ConnectionString, comText, new LiquidHandler());
    }
    
    public List<Consumable> GetAllConsumables()
    {
        string comText = "Select * from consumables";
        return DbExecutor.Execute<Consumable>(ConnectionString, comText, new ConsumableHandler());
    }
    
    public Consumable GetConsumableById(int id)
    {
        string comText = "Select * from consumables where id="+id;
        return DbExecutor.Execute<Consumable>(ConnectionString, comText, new ConsumableHandler())[0];
    }

    public void EditConsumable(Consumable consumable)
    {
        string comText = "update consumables set name='"+consumable.name+"', price="+consumable.price+", description='"+consumable.desc+"', \"isAvailable\"='"+consumable.isAvailable+"' where id="+consumable.id;
        Console.WriteLine($"INFO:{comText}");
        DbExecutor.Execute(ConnectionString, comText, new ConsumableHandler());
    }

    public void DeleteConsumable(Consumable consumable)
    {
        string comText = "delete from consumables where id="+consumable.id;
        DbExecutor.Execute(ConnectionString, comText, new ConsumableHandler());
    }

    public void AddConsumable(Consumable consumable)
    {
        string comText = "insert into consumables (name, price, description, \"isAvailable\") values('"+consumable.name+"',"+consumable.price+",'"+consumable.desc+"','"+consumable.isAvailable+"')";
                         
        DbExecutor.Execute(ConnectionString, comText, new ConsumableHandler());
    }
}