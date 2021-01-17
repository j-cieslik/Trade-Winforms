using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trade.Data;
using Trade.Models;

namespace Trade.Helpers
{
    class SynchronizeInventTableWithTradeObject
    {
        public static List<InventTable> modifyObjects = new List<InventTable>();
        public StringBuilder sbuilder;

        private readonly List<InventTable> _inventTables;
        private readonly List<TradeObject> _tradeObjects;


        public SynchronizeInventTableWithTradeObject()
        {
            _inventTables = TradeContext.GetInventTables();
            _tradeObjects = TradeContext.GetTradeObjects();
            sbuilder = new StringBuilder();
      
        }


        public void AddRecodrs()
        {
            var inventTableItemsId = _inventTables
                                .Select(x => x.Id)
                                .Except(_tradeObjects
                                        .Select(x => x.Id))
                                        .ToList();

            if (inventTableItemsId != null)
            {
                List<InventTable> inventTableItems = new List<InventTable>();

                foreach (var itemId in inventTableItemsId)
                {
                    inventTableItems.Add(_inventTables
                                            .Where(x => x.Id == itemId)
                                            .FirstOrDefault());
                }

                foreach (var item in inventTableItems)
                {
                    var tradeObject = new TradeObject()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        ModifiedDate = item.ModifiedDate
                    };

                    TradeContext.tradeObjects.Add(tradeObject);

                    sbuilder.Append($"Dodano obiekt o nazwie: {tradeObject.Name} " + "\n");

                }
                sbuilder.Append($"Łącznie dodano: {inventTableItems.Count} " + "\n");
            }

        }

        public void DeleteRecords()
        {
            var tradeObjectsItemsId = _tradeObjects
                                .Select(x => x.Id)
                                .Except(_inventTables
                                        .Select(x => x.Id))
                                        .ToList();

            if (tradeObjectsItemsId != null)
            {
                List<TradeObject> tradeObjectsItems = new List<TradeObject>();

                foreach (var itemId in tradeObjectsItemsId)
                {
                    tradeObjectsItems.Add(_tradeObjects
                                            .Where(x => x.Id == itemId)
                                            .FirstOrDefault());
                }

                foreach (var item in tradeObjectsItems)
                {
                    TradeContext.tradeObjects.Remove(item);

                    sbuilder.Append($"Usunięto obiekt o nazwie: {item.Name} " + "\n");
                }
                sbuilder.Append($"Łącznie usunięto: {tradeObjectsItems.Count} " + "\n");
            }
        }

        public void ModifyObjects()
        {
            if (modifyObjects.Count != 0)
            {
                foreach (var item in modifyObjects)
                {
                    var itemToModify = TradeContext.tradeObjects
                                        .Where(x => x.Id == item.Id)
                                        .FirstOrDefault();

                    itemToModify.Name = item.Name;

                    sbuilder.Append($"Zmodyfikowano obiekt o nazwie: {item.Name} " + "\n");
                }

                sbuilder.Append($"Łącznie zmodyfikowano: {modifyObjects.Count} " + "\n");

                modifyObjects.Clear();
            }

        }
    }
}
