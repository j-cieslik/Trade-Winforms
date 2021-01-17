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
                    Id = "1",
                    Name = "Biurko"
                },
                new InventTable()
                {
                    Id = "2",
                    Name = "Szafa"
                },
                new InventTable()
                {
                    Id = "3",
                    Name = "Monitor"
                },
                new InventTable()
                {
                    Id = "4",
                    Name = "Krzeslo"
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
                    Id = "1",
                    Name = "Biurko"
                },
                new TradeObject()
                {
                    Id = "2",
                    Name = "Szafa"
                },
                new TradeObject()
                {
                    Id = "3",
                    Name = "Monitor"
                },
                new TradeObject()
                {
                    Id = "4",
                    Name = "Krzeslo"
                }
            };

            return tradeObject;
        }
    }
}
