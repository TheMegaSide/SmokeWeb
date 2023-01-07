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
        ViewBag.products = Dbservice.GetAllProducts();
        List<Sold> solds = Dbservice.GetAllSold();
        ViewBag.clients = Dbservice.GetAllClients();
        return View(solds);
    }

    
}