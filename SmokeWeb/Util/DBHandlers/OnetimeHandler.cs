using Npgsql;
using SmokeWeb.Models;
using SmokeWeb.Util.DB;

namespace SmokeWeb.Util.DBHandlers;

public class OnetimeHandler : IDbExecuteHandler<Onetime>
{
    public Onetime GetDataAfterExecute(NpgsqlDataReader rdr)
    {
        return new Onetime()
        {
            id = (int)rdr["id"],
            name = rdr["name"].ToString(),
            price = (double)rdr["price"],
            desc = rdr["description"].ToString(),
            isAvailable = (bool)rdr["isAvailable"]
        };
    }
}