using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillScheduler.Domain.Enums
{
    public enum BillStatus
    {     
        New,
        Scheduled,
        Paid,
        PastDue
    }
}
