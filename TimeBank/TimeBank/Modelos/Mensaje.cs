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
    
    public partial class Mensaje
    {
        public int idMensaje { get; set; }
        public int idOferta { get; set; }
        public int idUser { get; set; }
    
        public virtual Ofertas Ofertas { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
