//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TimeBank.Modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Wallet
    {
        public int idWallet { get; set; }
        public double Balance { get; set; }
        public System.DateTime fecha { get; set; }
        public int idCliente { get; set; }
    
        public virtual Clientes Clientes { get; set; }
    }
}
