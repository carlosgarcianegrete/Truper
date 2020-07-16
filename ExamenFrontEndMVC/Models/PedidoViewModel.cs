using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenFrontEndMVC.Models
{
    public partial class PedidoViewModel
    {
        public int ID { get; set; }
        public Nullable<double> TOTAL { get; set; }
        [JsonProperty(PropertyName = "DATE_SALE")]
        public Nullable<System.DateTime> DATE_SALE { get; set; }
        public string USERNAME { get; set; }
        [JsonProperty(PropertyName = "PEDIDOS_DETALLE_W")]
        public virtual List<PedidoDetalleViewModel> PEDIDOS_DETALLE_W { get; set; }
        [JsonProperty(PropertyName = "USUARIOS_W")]
        public virtual UsuarioViewModel USUARIOS_W { get; set; }

    }
}