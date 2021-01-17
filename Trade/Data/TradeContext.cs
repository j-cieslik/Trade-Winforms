using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trade.Models;

namespace Trade.Data
{
    static class TradeContext
    {

        static TradeContext()
        {
            inventTables = ListInitializer.InitializeInventTables();
            tradeObjects = ListInitializer.InitializeTradeObjects();

        }

        public static List<InventTable> inventTables = new List<InventTable>();
        public static List<TradeObject> tradeObjects = new List<TradeObject>();

        public static InventTable GetInventTableById(string id)
        {
            var inventTable = inventTables.Where(x => x.Id == id).FirstOrDefault();

            return inventTable;
        }
        public static TradeObject GetTradeObjectById(string id)
        {
            var tradeObject = tradeObjects.Where(x => x.Id == id).FirstOrDefault();

            return tradeObject;
        }

        public static List<InventTable> GetInventTables()
        {
            return inventTables;
        }

        public static List<TradeObject> GetTradeObjects()
        {
            return tradeObjects;
        }
    }
}
