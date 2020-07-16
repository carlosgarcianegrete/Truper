using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Data.Entity;
using DataModel;


namespace WebApiCrud.Controllers
{
    public class PedidosController : ApiController
    {
        private examenEntities dbContexto = new examenEntities();


        // GET: api/Pedidos
        public IEnumerable<PEDIDOS_W> Get()
        {
            IEnumerable<PEDIDOS_W> pedido = dbContexto.PEDIDOS_W;

            return pedido;
        }

        // GET: api/Pedidos/5
        [ResponseType(typeof(PEDIDOS_W))]
        public IHttpActionResult Get(int id)
        {
            PEDIDOS_W pedido = dbContexto.PEDIDOS_W.Find(id);
            if (pedido == null)
            {
                return NotFound();
            }

            return Ok(pedido);
        }

        // POST: api/Pedidos
        [ResponseType(typeof(PEDIDOS_W))]
        public IHttpActionResult PostPedido(PEDIDOS_W pedido)
        {
            dbContexto.PEDIDOS_W.Add(pedido);

            try
            {
                dbContexto.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (PedidoExiste(pedido.ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = pedido.ID }, pedido);
        }

        // PUT: api/Pedidos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPedido(int id, PEDIDOS_W pedido)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pedido.ID)
            {
                return BadRequest();
            }

            dbContexto.Entry(pedido).State = EntityState.Modified;

            try
            {
                dbContexto.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PedidoExiste(id))
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

        // DELETE: api/Pedidos/5
        [ResponseType(typeof(PRODUCTO_W))]
        public IHttpActionResult DeletePedido(int id)
        {
            PEDIDOS_W pedido = dbContexto.PEDIDOS_W.Find(id);
            if (pedido == null)
            {
                return NotFound();
            }

            dbContexto.PEDIDOS_W.Remove(pedido);
            dbContexto.SaveChanges();

            return Ok(pedido);
        }

        private bool PedidoExiste(int id)
        {
            return dbContexto.PEDIDOS_W.Count(e => e.ID == id) > 0;
        }
    }
}
