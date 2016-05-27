using System;

namespace Domain.Events.Money
{
    public class MoneyTransferred : BaseEvent
    {
        public Decimal Amount { get; set; }

        public Guid AccountA { get; set; }

        public Guid AccountB { get; set; }
    }
}
