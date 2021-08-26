using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppAjax.Models;

namespace WebAppAjax.Controllers
{
  public class HomeController : Controller
  {
    public List<Employee> employees = new List<Employee>();

    public ActionResult Index()
    {
      return View();
    }

    public ActionResult About()
    {
      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }

    [HttpGet]
    public JsonResult EmployDetailsGet()
    {
      try
      {
        employees.Add(new Employee {EmployeeId = 1, EmployeeName = "Harena", MapCity = "Antananarivo", MapAddress = "Lot 1"});
        employees.Add(new Employee {EmployeeId = 2, EmployeeName = "Johan", MapCity = "Antananarivo", MapAddress = "Lot 2"});
        employees.Add(new Employee {EmployeeId = 3, EmployeeName = "Kianja", MapCity = "Ambatondrazaka", MapAddress = "Lot 3"});
        employees.Add(new Employee {EmployeeId = 4, EmployeeName = "Tsiry", MapCity = "Antananarivo", MapAddress = "Lot 4"});
        employees.Add(new Employee {EmployeeId = 5, EmployeeName = "Rija", MapCity = "Ambatondrazaka", MapAddress = "Lot 5"});
        employees.Add(new Employee {EmployeeId = 6, EmployeeName = "Lahatra", MapCity = "Ambatondrazaka", MapAddress = "Lot 6"});

        return Json(employees, JsonRequestBehavior.AllowGet);
      }
      catch (Exception e)
      {
        Console.WriteLine(e.ToString());
        return null;
      }
    }

    [HttpPost]
    public JsonResult EmployDetailsPost() 
    {
      try
      {
        employees.Add(new Employee { EmployeeId = 1, EmployeeName = "Harena", MapCity = "Antananarivo", MapAddress = "Lot 1" });
        employees.Add(new Employee { EmployeeId = 2, EmployeeName = "Johan", MapCity = "Antananarivo", MapAddress = "Lot 2" });
        employees.Add(new Employee { EmployeeId = 3, EmployeeName = "Kianja", MapCity = "Ambatondrazaka", MapAddress = "Lot 3" });
        employees.Add(new Employee { EmployeeId = 4, EmployeeName = "Tsiry", MapCity = "Antananarivo", MapAddress = "Lot 4" });
        employees.Add(new Employee { EmployeeId = 5, EmployeeName = "Rija", MapCity = "Ambatondrazaka", MapAddress = "Lot 5" });
        employees.Add(new Employee { EmployeeId = 6, EmployeeName = "Lahatra", MapCity = "Ambatondrazaka", MapAddress = "Lot 6" });

        return Json(employees, JsonRequestBehavior.AllowGet);
      }
      catch (Exception e)
      {
        Console.WriteLine(e.ToString());
        return null;
      }
    }

    [HttpPost]
    public void AddEmploye(int id, string name, string city, string address)
    {
      try
      {
        employees.Add(new Employee { EmployeeId = id, EmployeeName = name, MapCity = city, MapAddress = address });
      }
      catch (Exception e)
      {
        Console.WriteLine(e.ToString());
      }
    }
  }
}