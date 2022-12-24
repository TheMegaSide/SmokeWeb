using Microsoft.AspNetCore.Mvc;
using SmokeWeb.Models;
using SmokeWeb.Services;


namespace SmokeWeb.Controllers;

public class ShipmentController : Controller
{
    private BDService Dbservice;

    public ShipmentController(BDService dbservice)
    {
        Dbservice = dbservice;
    }

    public IActionResult PodShipments()
    {
        

        List<Shipment> shipments = Dbservice.GetPodShipments();
        
        return View(shipments);
    }
    public IActionResult OnetimeShipments()
    {
        
        List<Shipment> shipments = Dbservice.GetOnetimeShipments();
        
        return View(shipments);
    }
    public IActionResult LiquidShipments()
    {
        
        List<Shipment> shipments = Dbservice.GetLiquidShipments();
        
        return View(shipments);
    }
    public IActionResult ConsumableShipments()
    {
        
        List<Shipment> shipments = Dbservice.GetConsumablesShipments();
        
        return View(shipments);
    }
    public IActionResult PodNewShipment()
    {
        ViewBag.pods = Dbservice.GetAllPods();
        

        return View();
    }
    public IActionResult PodShipmentCreate(Shipment shipment)
    {
        Dbservice.AddShipment(shipment, 1);
        return RedirectToAction(nameof(PodShipments));
    }
    public IActionResult OnetimeNewShipment()
    {
        ViewBag.onetimes = Dbservice.GetAllOnetimes();
        

        return View();
    }
    public IActionResult OnetimeShipmentCreate(Shipment shipment)
    {
        Dbservice.AddShipment(shipment, 2);
        return RedirectToAction(nameof(OnetimeShipments));
    }
    public IActionResult LiquidNewShipment()
    {
        ViewBag.liquids = Dbservice.GetAllLiquids();
        

        return View();
    }
    public IActionResult LiquidShipmentCreate(Shipment shipment)
    {
        Dbservice.AddShipment(shipment, 3);
        return RedirectToAction(nameof(LiquidShipments));
    }
    public IActionResult ConsumableNewShipment()
    {
        ViewBag.consumables = Dbservice.GetAllConsumables();
        

        return View();
    }
    public IActionResult ConsumableShipmentCreate(Shipment shipment)
    {
        Dbservice.AddShipment(shipment, 4);
        return RedirectToAction(nameof(ConsumableShipments));
    }
}