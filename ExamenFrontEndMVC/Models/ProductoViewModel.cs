using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenFrontEndMVC.Models
{
    public partial class ProductoViewModel
    {
        public string SKU { get; set; }
        public string NOMBRE { get; set; }
        public Nullable<int> EXISTENCIA { get; set; }
        public Nullable<double> PRICE { get; set; }
        [JsonProperty(PropertyName = "PEDIDOS_DETALLE_W")]
        public virtual ICollection<PedidoDetalleViewModel> PEDIDOS_DETALLE_W { get; set; }
    }
}