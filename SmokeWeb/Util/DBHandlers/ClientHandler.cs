using Npgsql;
using SmokeWeb.Models;
using SmokeWeb.Util.DB;

namespace SmokeWeb.Util.DBHandlers;

public class ClientHandler: IDbExecuteHandler<Client>
{
    public Client GetDataAfterExecute(NpgsqlDataReader rdr)
    {
        
        return new Client
        {
            
            id = (int)rdr["id"],
            phone = rdr["phone"].ToString(),
            address = rdr["address"].ToString(),
     
            username = rdr["username"].ToString()
            
            
            
            
        };
    }
}