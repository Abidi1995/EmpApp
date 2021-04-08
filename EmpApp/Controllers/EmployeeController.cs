using EmpApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EmpApp.Controllers
{
   
    public class EmployeeController : Controller
    {
        private readonly EmployeeContext _context;

        public EmployeeController (EmployeeContext context)
        {
            _context = context;
        }
             
       
        [HttpGet]
        public ActionResult Create()
        
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee model )

        {
           // model.EmployeeName = model.EmployeeName;
           // model.Salary = model.Salary;
           // model.DateofHiring = model.DateofHiring;
           // model.DateofBirth = model.DateofBirth;
           // model.City = model.City;
            _context.Add(model);
            _context.SaveChanges();

            return View(model);
            
        }
        public ActionResult EmployeeList()
        {
            var ListEmployee = _context.employees
            .AsNoTracking().ToList();
            return View(ListEmployee);
        }
      public ActionResult Edit(int Id)
        {
            var find = _context.employees.Find(Id);
            return View(find);
        }
        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            _context.Entry(employee).State = EntityState.Modified;
            _context.SaveChanges();
            return View(employee);
        }
        public ActionResult Delete(int Id)
        {
            var del = _context.employees.Find(Id);
            return View(del);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(Employee employee)
        {
            
            
                _context.employees.Remove(employee).State=EntityState.Deleted;

                _context.SaveChanges();
            return View(employee);

            }
            
           

        }
       
       }
