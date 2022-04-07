using Factory.Data;
using Factory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Factory.Controllers;

public class EngineersController : Controller
{
    private readonly ApplicationDbContext _db;

    public EngineersController(ApplicationDbContext db)
    {
        _db = db;
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Engineer obj)
    {
        _db.Engineers.Add(obj);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int engineerId)
    {
        if (engineerId == 0) return NotFound();
        var engineerFromDb = _db.Engineers.Find(engineerId);
        if (engineerFromDb == null) return NotFound();
        return View(engineerFromDb);
    }

    [HttpPost]
    [ActionName("Delete")]
    public IActionResult DeleteConfirmed(int engineerId)
    {
        var engineerFromDb = _db.Engineers.Find(engineerId);
        _db.Engineers.Remove(engineerFromDb);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
        var thisEngineer = _db.Engineers
            .Include(engineer => engineer.JoinEntities)
            .ThenInclude(join => join.Machine)
            .FirstOrDefault(engineer => engineer.EngineerId == id);
        return View(thisEngineer);
    }

    public IActionResult Edit(int? engineerId)
    {
        if (engineerId == null || engineerId == 0) return NotFound();
        var engineerFromDb = _db.Engineers.Find(engineerId);
        if (engineerFromDb == null) return NotFound();
        return View(engineerFromDb);
    }

    [HttpPost]
    public IActionResult Edit(Engineer obj)
    {
        if (ModelState.IsValid)
        {
            _db.Engineers.Update(obj);
            _db.SaveChanges();
            TempData["success"] = "Engineer updated successfully";
            return RedirectToAction("Index");
        }

        return View(obj);
    }

    public IActionResult Index()
    {
        IEnumerable<Engineer> engineerList = _db.Engineers;
        return View(engineerList);
    }
}