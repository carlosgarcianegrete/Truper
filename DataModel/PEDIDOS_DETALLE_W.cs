//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class PEDIDOS_DETALLE_W
    {
        public int ID { get; set; }
        public Nullable<int> ID_PEDIDO { get; set; }
        public string SKU { get; set; }
        public Nullable<double> AMOUT { get; set; }
        public Nullable<double> PRICE { get; set; }
    
        public virtual PEDIDOS_W PEDIDOS_W { get; set; }
        public virtual PRODUCTO_W PRODUCTO_W { get; set; }
    }
}