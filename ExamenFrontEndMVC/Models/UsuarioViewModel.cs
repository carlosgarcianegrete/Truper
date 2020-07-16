using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenFrontEndMVC.Models
{
    public partial class UsuarioViewModel
    {
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string ROLE { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDOS { get; set; }
        public Nullable<System.Guid> TOKEN { get; set; }
        [JsonProperty(PropertyName = "PEDIDOS_W")]
        public virtual ICollection<PedidoViewModel> PEDIDOS_W { get; set; }
    }
}