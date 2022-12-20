namespace SmokeWeb.Models;
//Класс-модель объекта
public class Pod
{
        //Атрибуты объекта
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; } 
        public string desc { get; set; }
        public bool isAvailable { get; set; }
        public int count { get; set; }
            
}
