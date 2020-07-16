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
    public class PedidosDetallesController : ApiController
    {
        private examenEntities dbContexto = new examenEntities();


        // GET: api/Pedidos
        public IEnumerable<PEDIDOS_DETALLE_W> Get()
        {
            IEnumerable<PEDIDOS_DETALLE_W> pedidoDetalles = dbContexto.PEDIDOS_DETALLE_W;

            return pedidoDetalles;
        }

        // DELETE: api/Pedidos/5
        [ResponseType(typeof(PEDIDOS_DETALLE_W))]
        public IHttpActionResult DeletePedidoDetalle(int id)
        {
            PEDIDOS_DETALLE_W pedidoDetalle = dbContexto.PEDIDOS_DETALLE_W.Find(id);
            if (pedidoDetalle == null)
            {
                return NotFound();
            }

            dbContexto.PEDIDOS_DETALLE_W.Remove(pedidoDetalle);
            dbContexto.SaveChanges();

            return Ok(pedidoDetalle);
        }
    }
}
