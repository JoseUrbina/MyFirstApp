using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstApp.Controllers
{
    public class ProcesosController : Controller
    {
        // GET: Procesos
        public string Listado(int id = 0)
        {
            string message = "Hello World!!";
            return (id>0) ? message + " : " + id : message;
        }
    }
}