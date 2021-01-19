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
using Trade.Forms.Base;
using Trade.Helpers;
using Trade.Models;

namespace Trade.Forms.InventTables
{
    public partial class InventTableEditForm : BaseAddEditForm
    {

        private readonly InventTable inventTable;
        public EventHandler ReloadInventTables;

        public InventTableEditForm(string inventTableId)
        {
            InitializeComponent();
            inventTable = TradeContext.GetInventTableById(inventTableId);
            PrepareInventTableData(inventTable);

            ValidateControls();
        }

        private void PrepareInventTableData(InventTable inventTable)
        {
            txtName.Text = inventTable.Name;
        }

        private void ValidateControls()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                epName.SetError(txtName, "Pole Nazwa jest wymagane.");
            }
            else
            {
                epName.Clear();
            }
        }

        private bool ValidateForm()
        {
            StringBuilder sbErrorMessage = new StringBuilder();

            string nameErrorMessage = epName.GetError(txtName);

            if (!string.IsNullOrEmpty(nameErrorMessage))
            {
                sbErrorMessage.Append(nameErrorMessage);
            }

            if (sbErrorMessage.Length > 0)
            {
                MessageBox.Show(
                    sbErrorMessage.ToString(),
                    "Dodawanie Nazwy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        protected override void Save()
        {
            if (ValidateForm())
            {
                inventTable.Name = txtName.Text;
                inventTable.ModifiedDate = DateTime.Now;
                

                //inventTable = ModifyInventTable(inventTable);

                ReloadInventTables?.Invoke(btnSave, new InventTableEventArgs(inventTable));

                SynchronizeInventTableWithTradeObject.modifiedObjects.Add(inventTable);

                Close();
            }
        }

        protected override void Cancel()
        {
            MessageBox.Show("Anulowano!");
            Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }


    }
}
