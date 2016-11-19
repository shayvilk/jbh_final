using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Business_Logic
{
    public class Car
    {
        public int Mileage { get; set; }
        public string Photo { get; set; }
        public string ManufacturerName { get; set; }
        public string CarModel { get; set; }
        public string Transmission { get; set; }
        public bool ReadyForRental { get; set; }
        public bool IsDeleted { get; set; }
        public Decimal DailyRate { get; set; }
        public Decimal LateFee { get; set; }
        public int ManufactureYear { get; set; }



    }
}