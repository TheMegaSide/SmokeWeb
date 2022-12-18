using Npgsql;
using SmokeWeb.Models;
using SmokeWeb.Util.DB;

namespace SmokeWeb.Util.DBHandlers;

//Данный класс обрабатывает сырые данные с базы данных и приводит их к форме экземлпяра класса Pod
public class PodHandler : IDbExecuteHandler<Pod>
{
    public Pod GetDataAfterExecute(NpgsqlDataReader rdr)
    {
        //Создание нового экземпляра Pod
        return new Pod
        {
            //Заполнение атрибутов и приведение к нужному типу данных
            id = (int)rdr["id"],
            name = rdr["name"].ToString(),
            price = (double)rdr["price"],
            desc = rdr["description"].ToString(),
            isAvailable = (bool)rdr["isAvailable"]
        };
    }
}
