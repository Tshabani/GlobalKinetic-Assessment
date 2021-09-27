using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.GlobalKinetic.Coins
{
    public class Coin : FullAuditedEntity<Guid>
    {
        public virtual decimal? Amount { get; set; }
        public virtual decimal? Volume { get; set; }
    }
}
