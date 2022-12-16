using Microsoft.AspNetCore.Mvc;
using SmokeWeb.Models;
using SmokeWeb.Services;

namespace SmokeWeb.Controllers;

public class PodController : Controller
{
    

    private BDService Dbservice;
    public PodController(BDService dbservice)
    {
        Dbservice = dbservice;
    }
    
    public IActionResult PodTablePage()
    {
        List<Pod> pods = Dbservice.GetAllPods();
        
        return View(pods);
    }
    
    public IActionResult PodEdit(int id)
    {
        Pod pod = Dbservice.GetPodById(id);
        return View(pod);
    }
    
    public IActionResult Edit(Pod pod)
    {
        Dbservice.EditPod(pod);
        return RedirectToAction(nameof(PodTablePage));
    }

    public IActionResult Delete(Pod pod)
    {
        Dbservice.DeletePod(pod);
        return RedirectToAction(nameof(PodTablePage));
    }

    public IActionResult PodAdd()
    {
        return View();
    }

    public IActionResult Create(Pod pod)
    {
        Dbservice.AddPod(pod);
        return RedirectToAction(nameof(PodTablePage));
    }
    
}