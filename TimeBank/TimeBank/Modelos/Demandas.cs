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
    
    public partial class Demandas
    {
        public int idDemanda { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public double Tiempo { get; set; }
        public System.DateTime fecha_dem { get; set; }
        public int idUser { get; set; }
        public int idCategoria { get; set; }
    
        public virtual Categorias Categorias { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
