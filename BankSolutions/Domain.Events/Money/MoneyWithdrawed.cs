using System;

namespace Domain.Events.Money
{
    public class MoneyWithdrawed
    {
        public Decimal Amount { get; set; }

        public Guid AccountId { get; set; }
    }
}
