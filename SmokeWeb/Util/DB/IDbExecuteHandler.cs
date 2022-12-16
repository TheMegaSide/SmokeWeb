using Npgsql;

namespace SmokeWeb.Util.DB;

public interface IDbExecuteHandler<T>
{
    T GetDataAfterExecute(NpgsqlDataReader rdr);
}