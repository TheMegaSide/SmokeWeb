using Npgsql;

namespace SmokeWeb.Util.DB;

public class DbExecutor
{
    public static List<T> Execute<T>(string connectionString, string query, IDbExecuteHandler<T> executeHandlerHandler)
    {
        var returnObject = new List<T>();
        using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
        {
            con.Open();
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
            {
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    T item = executeHandlerHandler.GetDataAfterExecute(rdr);
                    returnObject.Add(item);
                }
            }
        }

        return returnObject;
    }
}