using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HairSalon.Controllers
{
  public class CustomerController : Controller
  {
    private readonly HairSalonContext _db;

    public CustomerController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Customer> model = _db.Customers.Include(customer => customer.Stylist).ToList();
      ViewBag.PageTitle = "Customers";
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.PageTitle = "Add Appt.";
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      ViewBag.StylistSpecialty = new SelectList(_db.Stylists, "Specialty", "Specialty");
      return View();
    }
    [HttpPost]
    public ActionResult Create(Customer customer)
    {
      _db.Customers.Add(customer);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}