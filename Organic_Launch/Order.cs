//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Organic_Launch
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int orderID { get; set; }
        public Nullable<int> accountID { get; set; }
        public Nullable<int> farmProductID { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual FarmProduct FarmProduct { get; set; }
    }
}