using BillScheduler.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillScheduler.Domain.Aggregates
{
    public class Pay
    {
        public DateOnly PayDate { get; set; }
        public List<Bill> ScheduledBills { get; set;}
        public List<Income> IncomeSources { get; set;}
    }

   
}
