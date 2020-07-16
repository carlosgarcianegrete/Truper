using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenFrontEndMVC.Models
{
    public partial class PedidoDetalleViewModel
    {
        public int ID { get; set; }

        [JsonProperty(PropertyName = "ID_PEDIDO")]
        public Nullable<int> ID_PEDIDO { get; set; }
        public string SKU { get; set; }
        public Nullable<double> AMOUT { get; set; }
        public Nullable<double> PRICE { get; set; }
        [JsonProperty(PropertyName = "PEDIDOS_W")]
        public virtual PedidoViewModel PEDIDOS_W { get; set; }
        [JsonProperty(PropertyName = "PRODUCTO_W")]
        public virtual ProductoViewModel PRODUCTO_W { get; set; }
    }
}