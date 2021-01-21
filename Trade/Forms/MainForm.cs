using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trade.classes;
using Trade.Data;
using Trade.Forms.InventTables;
using Trade.Helpers;
using Trade.Models;

namespace Trade.Forms
{
    partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            PrepareInventTableData();
            PrepareTradeObjectData();
        }


        private void PrepareInventTableData()
        {
            var fakeInventTables = TradeContext.GetInventTables().ToList();
            bsInventTable.DataSource = new BindingList<InventTable>(fakeInventTables);
            dgvInventTable.DataSource = bsInventTable;
        }
        private void PrepareTradeObjectData()
        {
            var fakeTradeObjects = TradeContext.GetTradeObjects().ToList();
            bsTradeObject.DataSource = new BindingList<TradeObject>(fakeTradeObjects);
            dgvTradeObject.DataSource = bsTradeObject;
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            InventTableAddForm frm = new InventTableAddForm();

            frm.ReloadInventTables += (s, ea) =>
            {
                var eventArgs = ea as InventTableEventArgs;

                if (eventArgs != null)
                {
                    var inventTable = eventArgs.InventTable;

                    TradeContext.inventTables.Add(inventTable);
                    bsInventTable.Add(inventTable);

                    dgvInventTable.ClearSelection();

                    var rowToSelect = dgvInventTable.Rows[dgvInventTable.Rows.Count - 1];

                    rowToSelect.Selected = true;
                    this.dgvInventTable.CurrentCell = rowToSelect.Cells[0];
                    this.dgvInventTable.BeginEdit(true);

                }
            };
            frm.ShowDialog();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string inventTableId = dgvInventTable.CurrentRow.Cells["colIdInvent"].Value.ToString();
            int selectedRowIndex = dgvInventTable.CurrentRow.Index;

            var frm = new InventTableEditForm(inventTableId);

            frm.ReloadInventTables += (s, ea) =>
            {
                var eventArgs = ea as InventTableEventArgs;

                if (eventArgs != null)
                {
                    InventTable inventTable = eventArgs.InventTable;

                    bsInventTable[selectedRowIndex] = inventTable;
                }
            };

            frm.ShowDialog();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string inventTableId = dgvInventTable.CurrentRow.Cells["colIdInvent"].Value.ToString();
            int selectedRowIndex = dgvInventTable.CurrentRow.Index;

            // RemoveInventTable(inventTableId)

            InventTable inventTable = TradeContext.GetInventTableById(inventTableId);

            if (inventTable != null)
            {
                bsInventTable.Remove(inventTable);
                TradeContext.inventTables.Remove(inventTable);

                if (dgvInventTable.Rows.Count >= 1)
                {
                    dgvInventTable.ClearSelection();

                    //var rowToSelect = dgvInventTable.Rows[dgvInventTable.Rows.Count - 1];
                    var rowToSelect = dgvInventTable.Rows[0];


                    rowToSelect.Selected = true;
                    this.dgvInventTable.CurrentCell = rowToSelect.Cells[0];
                    this.dgvInventTable.BeginEdit(true);
                }
            }
        }

        private void btnSynchro_Click(object sender, EventArgs e)
        {
            var syncTables = new SynchronizeInventTableWithTradeObject();

            var syncResult = syncTables.Synchronize();

            if (!syncResult)
            {
                MessageBox.Show("Synchronizacja się nie powiodła!");
            }

            if (rtInventTable.Text.Length > 0)
            {
                rtInventTable.Clear();
            }

            rtInventTable.AppendText(syncTables.sbuilder.ToString());

            syncTables.sbuilder.Clear();

            PrepareTradeObjectData();
        }
    }
}
