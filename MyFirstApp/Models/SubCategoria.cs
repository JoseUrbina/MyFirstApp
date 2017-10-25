using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstApp.Models
{
    // AInherit is with :
    public class SubCategoria : Categoria
    {
        public string Mensaje()
        {
            return "Codigo: " + this.idCategory + " . Categoria: " + this.Name;
        }
    }
}