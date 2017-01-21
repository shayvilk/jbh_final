using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic
{
    public class RentalOrder
    {
        public int CarRentalID { get; set; }
        public string CarID { get; set; }
        public int UserID { get; set; }
        public DateTime RentalStartDate { get; set; }
        public DateTime RentalFinishDate { get; set; }
        public DateTime? RentalActualFinishDate { get; set; }
        public bool IsCancelled { get; set; }


    }
}
