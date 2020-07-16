using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenFrontEndMVC.Models
{
    public class Respuesta
    {
        public int codigo { get; set; }
        public Guid dato { get; set; }
        public string mensaje { get; set; }
    }
}