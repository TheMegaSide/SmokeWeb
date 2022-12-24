using Microsoft.AspNetCore.Mvc;
using SmokeWeb.Models;
using SmokeWeb.Services;

namespace SmokeWeb.Controllers;

public class SoldController : Controller
{
    private BDService Dbservice;

    public SoldController(BDService dbservice)
    {
        Dbservice = dbservice;
    }

    public IActionResult SoldTablePage()
    {
        ViewBag.pods = Dbservice.GetAllPods();
        ViewBag.onetimes = Dbservice.GetAllOnetimes();
        ViewBag.liquids = Dbservice.GetAllLiquids();
        ViewBag.consumables = Dbservice.GetAllConsumables();
        List<Sold> solds = Dbservice.GetAllSold();
        return View(solds);
    }

    
}