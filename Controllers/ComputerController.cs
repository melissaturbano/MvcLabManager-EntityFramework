using Microsoft.AspNetCore.Mvc;
using MvcLabManager.Models;

namespace MvcLabManager.Controllers;

public class ComputerController : Controller 
{
     public readonly LabManagerContext _context;

     public ComputerController (LabManagerContext context)
     {
        _context = context;


     }

     public IActionResult Index()
     {
        return View(_context.Computers);
     }

     public IActionResult Show(int id)
     {
        Computer computer = _context.Computers.Find(id);

        if(computer == null)
        {
            return NotFound();
        }
        return View(computer);
     }

     //DELETAR
    public IActionResult Delete(int id)
    {
        Computer computer = _context.Computers.Find(id);

        if(computer == null)
        {
            return NotFound();
        }
        _context.Computers.Remove(computer);
        _context.SaveChanges();
        return View(computer);
    }

    //ATUALIZAR
    public IActionResult Update (int id, [FromForm] string ram, [FromForm] string processor)
    {
        Computer computer = _context.Computers.Find(id);

        if(computer == null)
        {
            return NotFound();
        }

        _context.Computers.Update(computer);
        _context.SaveChanges();

        return View();
    }*/

    //CRIAR (adicionar)
    public IActionResult Create ([FromForm] int id, [FromForm] string ram, [FromForm] string processor)
    {
        if (id != 0)
        {
            _context.Computers.Add(new Computer (id, ram, processor));
            _context.SaveChanges();
            
        } 
        return View();
    }

  
}