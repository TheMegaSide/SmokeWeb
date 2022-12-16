using Microsoft.AspNetCore.Mvc;
using SmokeWeb.Models;
using SmokeWeb.Services;

namespace SmokeWeb.Controllers;

public class ConsumableController : Controller
{


    private BDService Dbservice;

    public ConsumableController(BDService dbservice)
    {
        Dbservice = dbservice;
    }

    public IActionResult ConsumableTablePage()
    {
        List<Consumable> consumables = Dbservice.GetAllConsumables();

        return View(consumables);
    }

    public IActionResult ConsumableEdit(int id)
    {
        Consumable consumable = Dbservice.GetConsumableById(id);
        return View(consumable);
    }

    public IActionResult Edit(Consumable consumable)
    {
        Dbservice.EditConsumable(consumable);
        return RedirectToAction(nameof(ConsumableTablePage));
    }

    public IActionResult Delete(Consumable consumable)
    {
        Dbservice.DeleteConsumable(consumable);
        return RedirectToAction(nameof(ConsumableTablePage));
    }

    public IActionResult Create(Consumable consumable)
    {
        Dbservice.AddConsumable(consumable);
        return RedirectToAction(nameof(ConsumableTablePage));
    }

    public IActionResult ConsumableAdd()
    {
        return View();
    }
}