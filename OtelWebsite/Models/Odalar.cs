//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OtelWebsite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Odalar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Odalar()
        {
            this.MusteriHesaps = new HashSet<MusteriHesap>();
        }
    
        public int OdaNo { get; set; }
        public Nullable<decimal> OdaFiyat { get; set; }
        public Nullable<int> YatakSayisi { get; set; }
        public string OdaTuru { get; set; }
        public Nullable<int> ServisNo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MusteriHesap> MusteriHesaps { get; set; }
        public virtual Servisler Servisler { get; set; }
    }
}
