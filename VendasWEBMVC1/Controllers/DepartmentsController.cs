using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VendasWEBMVC1.Models;

namespace VendasWEBMVC1.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Eletronicos" });
            list.Add(new Department { Id = 2, Name = "Ferramentas" });
            list.Add(new Department { Id = 3, Name = "Móveis" });

            return View(list);
        }
    }
}