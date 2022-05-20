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
      return View();
    }
    [HttpPost]
    public ActionResult Create(Customer customer)
    {
      _db.Customers.Add(customer);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
    Customer thisCust = _db.Customers.FirstOrDefault(customer => customer.CustomerId == id);
    ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
    return View(thisCust);
    }

    public ActionResult Edit(int id)
    {
      var thisCust = _db.Customers.FirstOrDefault(customer => customer.CustomerId == id);
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View(thisCust);
    }
    [HttpPost]
    public ActionResult Edit(Customer customer)
    {
      _db.Entry(customer).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }


  }
}