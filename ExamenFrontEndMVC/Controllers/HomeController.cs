using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using ExamenFrontEndMVC.Models;

namespace ExamenFrontEndMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IEnumerable<ProductoViewModel> productos;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Productos").Result;
            productos = response.Content.ReadAsAsync<IEnumerable<ProductoViewModel>>().Result;
            var lstProductos = productos.Select(p => new { Value = p.SKU, Text = p.NOMBRE, Precio = p.PRICE });
            ViewBag.Productos = lstProductos;

            return View();
        }

        [HttpGet]
        public ActionResult getData()
        {
            IEnumerable<PedidoDetalleViewModel> pedidosDetalles;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("PedidosDetalles").Result;
            pedidosDetalles = response.Content.ReadAsAsync<IEnumerable<PedidoDetalleViewModel>>().Result;
            
            return Json(new { data = pedidosDetalles }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult getProductoBySku(string sku)
        {
            IEnumerable<ProductoViewModel> producto;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Productos").Result;
           producto = response.Content.ReadAsAsync<IEnumerable<ProductoViewModel>>().Result;

            return Json(new { data = producto.Where(p=> p.SKU == sku).FirstOrDefault() }, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public JsonResult guardarPedido(PedidoDetalleViewModel pedidoDetalle)
        {
            if (ModelState.IsValid)
            {

                List<PedidoDetalleViewModel> pedidoDetalleNuevo = new List<PedidoDetalleViewModel>();
                pedidoDetalleNuevo.Add(pedidoDetalle);
                
                PedidoViewModel pedidoNuevo = new PedidoViewModel();
                pedidoNuevo.USERNAME = "admin";
                pedidoNuevo.TOTAL = pedidoDetalle.AMOUT * pedidoDetalle.PRICE;
                pedidoNuevo.DATE_SALE = DateTime.Now;
                pedidoNuevo.PEDIDOS_DETALLE_W = pedidoDetalleNuevo;

                pedidoDetalle.ID_PEDIDO = pedidoNuevo.ID;


                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Pedidos", pedidoNuevo).Result;                
            }

            return Json("Ok", JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult eliminarPedido(int id)
        {
            AccesoViewModel usuario = new AccesoViewModel();
            usuario.userName = "admin";
            usuario.password = "123456";

            HttpResponseMessage response = JWTVariables.WebApiClient.PostAsJsonAsync("Acceso/Login/", usuario).Result;

            return Json("Ok", JsonRequestBehavior.AllowGet);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}