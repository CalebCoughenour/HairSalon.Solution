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
  }
}