using Microsoft.AspNetCore.Mvc;
using SmokeWeb.Models;
using SmokeWeb.Services;

namespace SmokeWeb.Controllers;
//Этот класс отвечает за логику взаимодействия представлений с сервисом, отправляющим запросы
public class PodController : Controller
{
    
    //Создание и инициализация экземлпяра сервиса
    private BDService Dbservice;
    public PodController(BDService dbservice)
    {
        Dbservice = dbservice;
    }
    //Открытие таблицы подов
    public IActionResult PodTablePage()
    {
        //Загрузка таблицы подов в массив из базы данных
        List<Pod> pods = Dbservice.GetAllPods();
        //Открытие таблицы на сайте и передача странице массива данных
        return View(pods);
    }
    //Открытие страницы редактирования одного элемента
    public IActionResult PodEdit(int id)
    {
        //Загрузка одного элемента из таблицы по id элемента и передача его странице сайта
        Pod pod = Dbservice.GetPodById(id);
        return View(pod);
    }
    //Вызов метода отправки изменений в базу данных и возврат к таблице
    public IActionResult Edit(Pod pod)
    {
        Dbservice.EditPod(pod);
        return RedirectToAction(nameof(PodTablePage));
    }
    //Отправка запроса удаления элемента из таблицы
    public IActionResult Delete(Pod pod)
    {
        Dbservice.DeletePod(pod);
        return RedirectToAction(nameof(PodTablePage));
    }
    //Открытие страницы добавления элемента
    public IActionResult PodAdd()
    {
        return View();
    }
    //Отправка запроса добавления элемента в таблицу
    public IActionResult Create(Pod pod)
    {
        Dbservice.AddPod(pod);
        return RedirectToAction(nameof(PodTablePage));
    }
    
}
