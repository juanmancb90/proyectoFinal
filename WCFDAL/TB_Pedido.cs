//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_Pedido
    {
        public TB_Pedido()
        {
            this.TB_DetallePedido = new HashSet<TB_DetallePedido>();
        }
    
        public int ID_Pedido { get; set; }
        public int ID_Cliente { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public decimal TotalBruto { get; set; }
        public decimal Impuesto { get; set; }
        public decimal ValorNeto { get; set; }
        public bool Estado { get; set; }
    
        public virtual TB_Cliente TB_Cliente { get; set; }
        public virtual ICollection<TB_DetallePedido> TB_DetallePedido { get; set; }
    }
}
