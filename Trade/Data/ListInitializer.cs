using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trade.Models;

namespace Trade.Data
{
    class ListInitializer
    {

        public static List<InventTable> InitializeInventTables()
        {

            List<InventTable> inventTables = new List<InventTable>
            {
                new InventTable()
                {
                    Id = "aaaa",
                    Name = "Biurko",
                    ModifiedDate = new DateTime(2014, 9, 4)
                },
                new InventTable()
                {
                    Id = "bbbb",
                    Name = "Szafa",
                    ModifiedDate = new DateTime(2017, 5, 3)
                },
                new InventTable()
                {
                    Id = "cccc",
                    Name = "Monitor",
                    ModifiedDate = new DateTime(2019, 10, 24)
                },
                new InventTable()
                {
                    Id = "dddd",
                    Name = "Krzeslo",
                    ModifiedDate = new DateTime(2014, 5, 2)
                }
            };

            return inventTables;
        }

        public static List<TradeObject> InitializeTradeObjects()
        {

            List<TradeObject> tradeObject = new List<TradeObject>
            {
                new TradeObject()
                {
                    Id = "aaaa",
                    Name = "Biurko",
                    ModifiedDate = new DateTime(2014, 9, 4)
                },
                new TradeObject()
                {
                    Id = "bbbb",
                    Name = "Szafa",
                    ModifiedDate = new DateTime(2017, 5, 3)
                },
                new TradeObject()
                {
                    Id = "cccc",
                    Name = "Monitor",
                    ModifiedDate = new DateTime(2019, 10, 24)
                },
                new TradeObject()
                {
                    Id = "dddd",
                    Name = "Krzeslo",
                    ModifiedDate = new DateTime(2014, 5, 2)
                }
            };

            return tradeObject;
        }
    }
}
