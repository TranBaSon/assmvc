using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PenalizeManagement.Models
{
    public class ResponeEntitycs
    {
        public List<Penalize> Penalizes { get; set; }
        public double totalPayment { get; set; }
        public double totalPushUp { get; set; }
    }
}