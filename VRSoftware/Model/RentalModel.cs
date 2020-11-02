using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRSoftware.Model
{
    public class RentalModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int VideoId { get; set; }
        public DateTime IssuedDate { get; set; }
        public DateTime? ReturnedDate { get; set; }
        public bool IsReturned { get; set; }
        public DateTime Date { get; set; }
    }
}
