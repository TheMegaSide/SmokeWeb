using Npgsql;
using SmokeWeb.Models;
using SmokeWeb.Util.DB;

namespace SmokeWeb.Util.DBHandlers;

public class ConsumableHandler: IDbExecuteHandler<Consumable>
{
    public Consumable GetDataAfterExecute(NpgsqlDataReader rdr)
    {
        return new Consumable()
        {
            id = (int)rdr["id"],
            name = rdr["name"].ToString(),
            price = (double)rdr["price"],
            desc = rdr["description"].ToString(),
            isAvailable = (bool)rdr["isAvailable"]
        };
    }
}