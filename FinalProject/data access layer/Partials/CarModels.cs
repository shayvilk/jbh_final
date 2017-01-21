using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Data_Access_Layer
{
    [MetadataType(typeof(CarModelsMetadata))]
    public partial class CarModels
    {
        private class CarModelsMetadata
        {
            public int CarModelID { get; set; }
            public string ManufacturerID { get; set; }

            public string CarModel { get; set; }

            public int ManufactureYear { get; set; }

            public string Transmission { get; set; }

            public decimal DailyRate { get; set; }

            public decimal LatefFee { get; set; }

            public bool IsDelete { get; set; }
        }
    }
}
