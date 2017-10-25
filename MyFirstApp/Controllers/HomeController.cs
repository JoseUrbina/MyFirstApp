using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFirstApp.Models;

namespace MyFirstApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            List<SubCategoria> Categoria = new List<SubCategoria>();
            Categoria.Add(new Models.SubCategoria() { idCategory = 1, Name = "Another World", Status = true});

            // Return a specific field of a List
            // return Categoria[0].Name;

            return Categoria[0].Mensaje();
        }
    }
}