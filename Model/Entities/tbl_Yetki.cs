//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KutuphaneYonetimSistemi.Model.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Yetki
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Yetki()
        {
            this.tbl_Personel = new HashSet<tbl_Personel>();
        }
    
        public byte Id { get; set; }
        public Nullable<bool> Durum { get; set; }
        public string YetkiAdi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Personel> tbl_Personel { get; set; }
    }
}
