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
    
    public partial class SelectAllCarModels_Result
    {
        public int CarModelID { get; set; }
        public string ManufacturerName { get; set; }
        public string CarModel { get; set; }
        public int ManufactureYear { get; set; }
        public string Transmission { get; set; }
        public decimal DailyRate { get; set; }
        public decimal LateFee { get; set; }
        public bool IsDelete { get; set; }
    }
}
