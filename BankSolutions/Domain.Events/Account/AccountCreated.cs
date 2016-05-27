using System;

namespace Domain.Events.Account
{
    public class AccountCreated : BaseEvent
    {
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }
    }
}
