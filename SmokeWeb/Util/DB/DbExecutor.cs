using Npgsql;

namespace SmokeWeb.Util.DB;
//Класс, который выполняет соединение с базой данных и отправляет в нее запрос, полученный от BDService
public class DbExecutor
{
    //Метод выполнения запроса
    public static List<T> Execute<T>(string connectionString, string query, IDbExecuteHandler<T> executeHandlerHandler)
    {
        //Массив, который записывает полученные данные
        var returnObject = new List<T>();
        //Создание экземпляра подключения
        using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
        {
            //Открытие подключения
            con.Open();
            //Создание экземпляра запроса
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
            {
                //Получение данных через запрос
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                //Запись полученных данных в массив returnObject
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
