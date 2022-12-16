using Npgsql;
using SmokeWeb.Models;
using SmokeWeb.Util.DB;

namespace SmokeWeb.Util.DBHandlers;

public class PodHandler : IDbExecuteHandler<Pod>
{
    public Pod GetDataAfterExecute(NpgsqlDataReader rdr)
    {
        return new Pod
        {
            id = (int)rdr["id"],
            name = rdr["name"].ToString(),
            price = (double)rdr["price"],
            desc = rdr["description"].ToString(),
            isAvailable = (bool)rdr["isAvailable"]
        };
    }
}