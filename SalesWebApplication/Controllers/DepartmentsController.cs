﻿using Microsoft.AspNetCore.Mvc;
using SalesWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebApplication.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();

            list.Add(new Department { Id = 1, Name = "Eletronicos" });

            list.Add(new Department { Id = 2, Name = "Fashion" });


            return View(list);
        }
    }
}
