//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data_Access_Layer
{
    using System;
    
    public partial class GetRentalsByUser_Result
    {
        public int CarRentalID { get; set; }
        public string CarID { get; set; }
        public int UserID { get; set; }
        public System.DateTime RentalStartDate { get; set; }
        public System.DateTime RentalFinishDate { get; set; }
        public Nullable<System.DateTime> RentalActualFinishDate { get; set; }
        public Nullable<bool> IsCancelled { get; set; }
    }
}
