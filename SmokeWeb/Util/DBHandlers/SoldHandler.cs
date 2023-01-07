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
            client = (int)rdr["client"],
            products = (int[])rdr["products"],
     
            dateof = (DateTime)rdr["date"],
            state = rdr["state"].ToString()
            
            
            
            
        };
    }
}