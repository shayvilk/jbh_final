using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Partials
{
    [MetadataType(typeof(CarFleetMetadata))]
    public partial class Car
    {
        private class CarFleetMetadata
        {
            public string CarID { get; set; }

            public int CarModelID { get; set; }

            public int Mileage { get; set; }

            public string Photo { get; set; }

            public bool ReadyForRental { get; set; }

            public bool IsDelete { get; set; }

        }
    }
