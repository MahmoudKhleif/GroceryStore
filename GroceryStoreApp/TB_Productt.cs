//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GroceryStoreApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_Productt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Productt()
        {
            this.TB_Saless = new HashSet<TB_Saless>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string ProductionsDate { get; set; }
        public string ExpirationDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Saless> TB_Saless { get; set; }
    }
}