using Microsoft.AspNetCore.Mvc;
using SmokeWeb.Models;
using SmokeWeb.Services;

namespace SmokeWeb.Controllers;

public class LiquidController : Controller
{
    
    
    private BDService Dbservice;
    public LiquidController(BDService dbservice)
    {
        Dbservice = dbservice;
    }
    
    public IActionResult LiquidTablePage()
    {
        List<Liquid> liquids = Dbservice.GetAllLiquids();
        
        return View(liquids);
    }

    public IActionResult LiquidEdit(int id)
    {
        Liquid liquid = Dbservice.GetLiquidById(id);
        return View(liquid);
    }

    public IActionResult Edit(Liquid liquid)
    {
        Dbservice.EditLiquid(liquid);
        return RedirectToAction(nameof(LiquidTablePage));
    }

    public IActionResult Delete(Liquid liquid)
    {
        Dbservice.DeleteLiquid(liquid);
        return RedirectToAction(nameof(LiquidTablePage));
    }

    public IActionResult Create(Liquid liquid)
    {
        Dbservice.AddLiquid(liquid);
        return RedirectToAction(nameof(LiquidTablePage));
    }

    public IActionResult LiquidAdd()
    {
        return View();
    }



}