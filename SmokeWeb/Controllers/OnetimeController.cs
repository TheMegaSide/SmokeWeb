using Microsoft.AspNetCore.Mvc;
using SmokeWeb.Models;
using SmokeWeb.Services;

namespace SmokeWeb.Controllers;

public class OnetimeController: Controller
{
    
    
    private BDService Dbservice;
    public OnetimeController(BDService dbservice)
    {
        Dbservice = dbservice;
    }
    
    public IActionResult OnetimeTablePage()
    {
        List<Onetime> onetimes = Dbservice.GetAllOnetimes();
        
        return View(onetimes);
    }

    public IActionResult OnetimeEdit(int id)
    {
        Onetime onetime = Dbservice.GetOnetimeById(id);
        return View(onetime);
    }

    public IActionResult Edit(Onetime onetime)
    {
        Dbservice.EditOnetime(onetime);
        return RedirectToAction(nameof(OnetimeTablePage));
    }

    public IActionResult Delete(Onetime onetime)
    {
        Dbservice.DeleteOnetime(onetime);
        return RedirectToAction(nameof(OnetimeTablePage));
    }

    public IActionResult Create(Onetime onetime)
    {
        Dbservice.AddOnetime(onetime);
        return RedirectToAction(nameof(OnetimeTablePage));
    }

    public IActionResult OnetimeAdd()
    {
        return View();
    }
}