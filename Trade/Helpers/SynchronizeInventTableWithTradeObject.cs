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
        public static List<InventTable> modifiedObjects = new List<InventTable>();
        public StringBuilder sbuilder;

        private readonly List<InventTable> _inventTables;
        private readonly List<TradeObject> _tradeObjects;


        public SynchronizeInventTableWithTradeObject()
        {
            _inventTables = TradeContext.GetInventTables();
            _tradeObjects = TradeContext.GetTradeObjects();
            sbuilder = new StringBuilder();
      
        }

        public bool Synchronize()
        {
            try
            {
                AddRecodrs();
                DeleteRecords();
                ModifyObjects();
            }
            catch (Exception)
            {

                return false;
            }


            return true;
        }


        private void AddRecodrs()
        {
            var inventTableItemsId = _inventTables
                                .Select(x => x.Id)
                                .Except(_tradeObjects
                                        .Select(x => x.Id))
                                        .ToList();

            if (inventTableItemsId != null)
            {

                foreach (var itemId in inventTableItemsId)
                { 

                    var inventTableItem = _inventTables
                                            .Where(x => x.Id == itemId)
                                            .FirstOrDefault();

                    var tradeObject = new TradeObject()
                    {
                        Id = inventTableItem.Id,
                        Name = inventTableItem.Name,
                        ModifiedDate = inventTableItem.ModifiedDate
                    };

                    TradeContext.tradeObjects.Add(tradeObject);

                    sbuilder.Append($"Dodano obiekt o nazwie: {tradeObject.Name} " + "\n");

                }

                sbuilder.Append($"Łącznie dodano: {inventTableItemsId.Count} " + "\n");
            }
        }

        private void DeleteRecords()
        {
            var tradeObjectsItemsId = _tradeObjects
                                .Select(x => x.Id)
                                .Except(_inventTables
                                        .Select(x => x.Id))
                                        .ToList();

            if (tradeObjectsItemsId != null)
            {

                foreach (var itemId in tradeObjectsItemsId)
                {
                    var tradeObjectItem = _tradeObjects
                                            .Where(x => x.Id == itemId)
                                            .FirstOrDefault();

                    TradeContext.tradeObjects.Remove(tradeObjectItem);

                    sbuilder.Append($"Usunięto obiekt o nazwie: {tradeObjectItem.Name} " + "\n");

                }

                sbuilder.Append($"Łącznie usunięto: {tradeObjectsItemsId.Count} " + "\n");
            }
        }

        private void ModifyObjects()
        {
            if (modifiedObjects.Count != 0)
            {
                foreach (var item in modifiedObjects)
                {
                    var itemToModify = _tradeObjects
                                        .Where(x => x.Id == item.Id)
                                        .FirstOrDefault();

                    if (itemToModify != null)
                    {
                        itemToModify.Name = item.Name;
                        itemToModify.ModifiedDate = item.ModifiedDate;

                        sbuilder.Append($"Zmodyfikowano obiekt o nazwie: {item.Name} " + "\n");
                    }     
                }

                sbuilder.Append($"Łącznie zmodyfikowano: {modifiedObjects.Count} " + "\n");

                modifiedObjects.Clear();
            }

        }

    }
}
