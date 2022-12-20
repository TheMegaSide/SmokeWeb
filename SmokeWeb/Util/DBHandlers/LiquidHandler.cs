using Npgsql;
using SmokeWeb.Models;
using SmokeWeb.Util.DB;

namespace SmokeWeb.Util.DBHandlers;

public class LiquidHandler : IDbExecuteHandler<Liquid>
{
    public Liquid GetDataAfterExecute(NpgsqlDataReader rdr)
    {
        return new Liquid()
        {
            id = (int)rdr["id"],
            name = rdr["name"].ToString(),
            price = (double)rdr["price"],
            desc = rdr["description"].ToString(),
            isAvailable = (bool)rdr["isAvailable"],
            count = (int)rdr["count"]
        };
    }
}