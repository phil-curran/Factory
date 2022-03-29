using Factory.Data;
using Microsoft.AspNetCore.Mvc;
using Factory.Models;

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
        IEnumerable<Engineer> engineerList = _db.Engineers;
        return View(engineerList);
    }
}