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
}