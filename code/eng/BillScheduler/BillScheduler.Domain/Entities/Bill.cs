using BillScheduler.Domain.Enums;
using BillScheduler.Domain.Interfaces.Common;

namespace BillScheduler.Domain.Entities
{
    public class Bill : IDomainEntity
    {
        public string? Name { get; set; }
        public float Amount { get; set; }
        public DateOnly DueDate { get; set; }
        public BillStatus Status { get; set; }

        public Bill(string? name, float amount, DateOnly dueDate, BillStatus status)
        {         
            Name = name;
            Amount = amount;
            DueDate = dueDate;
            Status = status;
        }
    }
}
