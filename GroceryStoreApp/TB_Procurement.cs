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
    
    public partial class TB_Procurement
    {
        public int ID { get; set; }
        public int SupplierID { get; set; }
        public int BuyerID { get; set; }
        public string TheTotalAmount { get; set; }
        public string DATE { get; set; }
    
        public virtual TB_Suppliers TB_Suppliers { get; set; }
        public virtual TB_User TB_User { get; set; }
    }
}
