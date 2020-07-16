using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Data.Entity;
using DataModel;
using System.Data.Entity.Infrastructure;

namespace WebApiCrud.Controllers
{
    public class ProductosController : ApiController
    {
        private examenEntities dbContexto = new examenEntities();


        // GET: api/Productos
        public IQueryable<PRODUCTO_W> Get()
        {
            return dbContexto.PRODUCTO_W;
        }

        // GET: api/Productos/5
        [ResponseType(typeof(PRODUCTO_W))]
        public IHttpActionResult Get(string id)
        {
            PRODUCTO_W producto = dbContexto.PRODUCTO_W.Find(id);
            if (producto == null)
            {
                return NotFound();
            }

            return Ok(producto);
        }

        // PUT: api/Pedidos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProducto(string id, PRODUCTO_W producto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != producto.SKU)
            {
                return BadRequest();
            }

            dbContexto.Entry(producto).State = EntityState.Modified;

            try
            {
                dbContexto.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductoExiste(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        private bool ProductoExiste(string id)
        {
            return dbContexto.PRODUCTO_W.Count(e => e.SKU == id) > 0;
        }
    }
}
