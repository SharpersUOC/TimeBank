//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TimeBank.Modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ofertas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ofertas()
        {
            this.Orden = new HashSet<Orden>();
        }
    
        public int idOferta { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public double Tiempo { get; set; }
        public System.DateTime fecha_ofer { get; set; }
        public int idUser { get; set; }
        public int idCategoria { get; set; }
    
        public virtual Categorias Categorias { get; set; }
        public virtual Usuarios Usuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orden> Orden { get; set; }
    }
}
