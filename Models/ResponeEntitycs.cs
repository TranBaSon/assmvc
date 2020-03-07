using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PenalizeManagement.Models
{
    public class ResponeEntitycs
    {
        public List<Penalize> Penalizes { get; set; }
        public Double totalPayment { get; set; }
        public Double totalPushUp { get; set; }
    }
}