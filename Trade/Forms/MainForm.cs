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
            PrepareEmployeesData();
        }


        private void PrepareEmployeesData()
        {
            var fakeInventTablesSorted = TradeContext.GetInventTables().ToList();
            bsInventTable.DataSource = new BindingList<InventTable>(fakeInventTablesSorted);
            dgvInventTable.DataSource = bsInventTable;

            var fakeTradeObjectsSorted = TradeContext.GetTradeObjects().ToList();
            bsTradeObject.DataSource = new BindingList<TradeObject>(fakeTradeObjectsSorted);
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
                    dgvInventTable.Rows[dgvInventTable.Rows.Count - 1].Selected = true;
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
                InventTableEventArgs eventArgs = ea as InventTableEventArgs;

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

                if (dgvInventTable.Rows.Count > 1)
                {
                    dgvInventTable.ClearSelection();
                    dgvInventTable.Rows[dgvInventTable.Rows.Count - 1].Selected = true;
                }
            }
        }

        private void btnSynchro_Click(object sender, EventArgs e)
        {
            var syncTables = new SynchronizeInventTableWithTradeObject();

            syncTables.AddRecodrs();
            syncTables.DeleteRecords();
            syncTables.ModifyObjects();


            if (rtInventTable.Text.Length > 0)
            {
                rtInventTable.Clear();
            }

            rtInventTable.AppendText(syncTables.sbuilder.ToString());

            syncTables.sbuilder.Clear();

            PrepareEmployeesData();
        }
    }
}
