using System;

namespace Domain.Events.Money
{
    public class MoneyDeposited
    {
        public Decimal Amount { get; set; }

        public Guid AccountId { get; set; }
    }
}
