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
    
    public partial class tbl_YayınEvi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_YayınEvi()
        {
            this.tbl_Kitaplar = new HashSet<tbl_Kitaplar>();
        }
    
        public int Id { get; set; }
        public string YayınEviAdi { get; set; }
        public bool Durum { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Kitaplar> tbl_Kitaplar { get; set; }
    }
}
