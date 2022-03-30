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

    public IActionResult Delete(int machineId)
    {
        if (machineId == null || machineId == 0) return NotFound();
        var machineFromDb = _db.Machines.Find(machineId);
        if (machineFromDb == null) return NotFound();
        return View(machineFromDb);
    }

    [HttpPost]
    [ActionName("Delete")]
    public IActionResult DeleteConfirmed(int machineId)
    {
        var machineFromDb = _db.Machines.Find(machineId);
        _db.Machines.Remove(machineFromDb);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Details()
    {
        return View();
    }

    public IActionResult Edit(int? machineId)
    {
        if (machineId == null || machineId == 0) return NotFound();
        var machineFromDb = _db.Machines.Find(machineId);
        if (machineFromDb == null) return NotFound();
        return View(machineFromDb);
    }

    [HttpPost]
    public IActionResult Edit(Machine obj)
    {
        if (ModelState.IsValid)
        {
            _db.Machines.Update(obj);
            _db.SaveChanges();
            TempData["success"] = "Machine updated successfully";
            return RedirectToAction("Index");
        }

        return View(obj);
    }

    public IActionResult Index()
    {
        IEnumerable<Machine> machineList = _db.Machines;
        return View(machineList);
    }
}