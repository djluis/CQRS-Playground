using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Events.Money
{
    public class MoneyWithdrawed
    {
        public Decimal Amount { get; set; }

        public Guid AccountId { get; set; }
    }
}
