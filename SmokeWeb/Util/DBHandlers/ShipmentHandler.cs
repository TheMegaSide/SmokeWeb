using Npgsql;
using SmokeWeb.Models;
using SmokeWeb.Util.DB;

namespace SmokeWeb.Util.DBHandlers;

public class ShipmentHandler: IDbExecuteHandler<Shipment>
{
    public Shipment GetDataAfterExecute(NpgsqlDataReader rdr)
    {
        
        return new Shipment
        {
            
            id = (int)rdr["id"],
            productid = (int)rdr["productid"],
            name = rdr["name"].ToString(),
            price = (double)rdr["price"],
            amount = (int)rdr["amount"],
            dateof = (DateTime)rdr["dateof"]
            
            
        };
    }
}