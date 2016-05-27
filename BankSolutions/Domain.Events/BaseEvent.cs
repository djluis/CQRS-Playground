using System;

namespace Domain.Events
{
    /// <summary>
    /// Every event contains an Id (guid).
    /// The event name must be in past tense (Ex: Created, Disabled, Accepted).
    /// </summary>
    public abstract class BaseEvent
    {
        public Guid Id { get; set; }
    }
}
