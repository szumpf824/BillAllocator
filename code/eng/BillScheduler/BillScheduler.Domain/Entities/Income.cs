using BillScheduler.Domain.Enums;
using BillScheduler.Domain.Interfaces.Common;

namespace BillScheduler.Domain.Entities
{
    public class Income : IDomainEntity
    {
        public string? Name { get; set; }
        public DateOnly DateReceived { get; set; }
        public float Amount { get; set; }
        public bool IsRecurring { get; set; }
        public PayFrequency Frequency { get; set; }

        public Income(string? name, DateOnly dateReceived, float amount, bool isRecurring, PayFrequency frequency)
        {
            Name = name;
            DateReceived = dateReceived;
            Amount = amount;
            IsRecurring = isRecurring;
            Frequency = frequency;
        }
    }
}