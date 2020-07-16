using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataModel;
using System.Data.Entity;
using WebApiAutenticacion.Models;

namespace WebApiAutenticacion.Controllers
{
    public class AccesoController : ApiController
    {
        [HttpPost]
        public Respuesta Login([FromBody] AccesoViewModel model)
        {
            Respuesta res = new Respuesta();
            res.codigo = 0;

            try
            {
                using (examenEntities dbContexto = new examenEntities())
                {
                    USUARIOS_W usuario = dbContexto.USUARIOS_W.Where(u => u.USERNAME == model.userName && u.PASSWORD == model.password).FirstOrDefault();
                    if (usuario != null)
                    {
                        res.codigo = 1;
                        res.dato = Guid.NewGuid();
                        res.mensaje = "Token exitoso.";
                        usuario.TOKEN = res.dato;
                        dbContexto.Entry(usuario).State = EntityState.Modified;
                        dbContexto.SaveChanges();

                    }
                    else
                    {
                        res.mensaje = "Los datos son incorrectos, favor de validarlos.";
                    }
                }
            }
            catch (Exception ex)
            {
                res.mensaje = "Se ha generado un error.";
            }

            return res;
        }        

    }
}

