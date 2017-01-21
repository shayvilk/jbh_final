using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Partials
{
    [MetadataType(typeof(RentalMetadata))]
    public partial class Order
    {
        private class RentalMetadata
        {
            public int CarRentalID { get; set; }

            public string CarID { get; set; }

            public int UserID { get; set; }

            public DateTime RentalStartDate { get; set; }

            public DateTime RentalFinishDate { get; set; }

            public DateTime RentalActualFinishDate { get; set; }

            public bool IsCancelled { get; set; }

        }
    }
}
