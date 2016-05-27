using System;

namespace Domain.Events.Account
{
    public class AccountDisabled : BaseEvent
    {
        public Guid AccountId { get; set; }

        public string Reason { get; set; }
    }
}
