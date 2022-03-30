using Factory.Data;
using Factory.Models;
using Microsoft.AspNetCore.Mvc;

namespace Factory.Controllers;

public class MachinesController : Controller
{
    private readonly ApplicationDbContext _db;

    public MachinesController(ApplicationDbContext db)
    {
        _db = db;
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Machine obj)
    {
        _db.Machines.Add(obj);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Delete()
    {
        return View();
    }

    public IActionResult Details()
    {
        return View();
    }

    public IActionResult Edit()
    {
        return View();
    }

    public IActionResult Index()
    {
        IEnumerable<Machine> machineList = _db.Machines;
        return View(machineList);
    }
}