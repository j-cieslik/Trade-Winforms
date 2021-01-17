using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade.Models
{
    class InventTable : BaseEntity
    {
        public string Name { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
