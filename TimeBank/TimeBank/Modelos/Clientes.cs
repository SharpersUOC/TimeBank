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
    
    public partial class Clientes
    {
        public int idCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public bool Esadmin { get; set; }
        public int idUser { get; set; }
        public int idWallet { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
        public virtual Wallet Wallet { get; set; }
    }
}
