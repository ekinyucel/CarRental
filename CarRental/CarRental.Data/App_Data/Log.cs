//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRental.Data.App_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Log
    {
        public int ID { get; set; }
        public Nullable<int> UserId { get; set; }
        public string LogType { get; set; }
        public Nullable<int> CarId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }
}
