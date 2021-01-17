using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trade.Models;

namespace Trade.classes
{
    class InventTableEventArgs : EventArgs
    {
        public InventTable InventTable { private set; get; }

        public InventTableEventArgs(InventTable inventTable)
        {
            this.InventTable = inventTable;
        }
    }
}
