using Factory.Data;
using Factory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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
        ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "Name");
        return View();
    }

    [HttpPost]
    public IActionResult Create(Machine machine, int engineerId)
    {
        _db.Machines.Add(machine);
        _db.SaveChanges();
        if (engineerId != 0)
        {
            _db.EngineersMachines.Add(new() { EngineerId = engineerId, MachineId = machine.MachineId });
            _db.SaveChanges();
        }
        return RedirectToAction("Index");
    }
    
    public IActionResult Delete(int machineId)
    {
        if (machineId == 0) return NotFound();
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

    public IActionResult Details(int id)
    {
        var thisMachine = _db.Machines
            .Include(machine => machine.JoinEntities)
            .ThenInclude(join => join.Engineer)
            .FirstOrDefault(machine => machine.MachineId == id);
        return View(thisMachine);
    }

    public IActionResult Edit(int? machineId)
    {
        if (machineId == null || machineId == 0) return NotFound();
        var machineFromDb = _db.Machines.Find(machineId);
        if (machineFromDb == null) return NotFound();
        ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "EngineerName");
        return View(machineFromDb);
    }

    [HttpPost]
    public IActionResult Edit(Machine obj, int engineerId)
    {
        if (ModelState.IsValid)
        {
            _db.Machines.Update(obj);
            _db.SaveChanges();
            if (engineerId != 0)
            {
                _db.EngineersMachines.Update(new EngineerMachine {EngineerId = engineerId, MachineId = obj.MachineId});
                _db.SaveChanges();
            }
            TempData["success"] = "Machine updated successfully";
            return RedirectToAction("Index");
        }
        return View(obj);
    }

    public IActionResult Index()
    {
        return View(_db.Machines.ToList());
    }
}