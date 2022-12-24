using Npgsql;
using SmokeWeb.Models;
using SmokeWeb.Util.DB;

namespace SmokeWeb.Util.DBHandlers;

public class SoldHandler: IDbExecuteHandler<Sold>
{
    public Sold GetDataAfterExecute(NpgsqlDataReader rdr)
    {
        
        return new Sold
        {
            
            id = (int)rdr["id"],
            productid = (int)rdr["productid"],
     
            dateof = (DateTime)rdr["dateof"],
            price = (double)rdr["price"],
            clientphone = rdr["clientphone"].ToString(),
            clientaddress = rdr["clientaddress"].ToString(),
            category = (int)rdr["category"]
            
            
            
        };
    }
}