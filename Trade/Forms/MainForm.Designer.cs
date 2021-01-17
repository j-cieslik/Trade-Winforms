
namespace Trade.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tlpTrade = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSynchro = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvInventTable = new System.Windows.Forms.DataGridView();
            this.colIdInvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNameInvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModifyInvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsInventTable = new System.Windows.Forms.BindingSource(this.components);
            this.dgvTradeObject = new System.Windows.Forms.DataGridView();
            this.colIdTrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNameTrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModifyTrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTradeObject = new System.Windows.Forms.BindingSource(this.components);
            this.rtInventTable = new System.Windows.Forms.RichTextBox();
            this.ssTrade = new System.Windows.Forms.StatusStrip();
            this.tsslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlpTrade.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInventTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTradeObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTradeObject)).BeginInit();
            this.ssTrade.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpTrade
            // 
            this.tlpTrade.ColumnCount = 2;
            this.tlpTrade.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTrade.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTrade.Controls.Add(this.panel1, 0, 0);
            this.tlpTrade.Controls.Add(this.dgvInventTable, 0, 1);
            this.tlpTrade.Controls.Add(this.dgvTradeObject, 1, 1);
            this.tlpTrade.Controls.Add(this.rtInventTable, 0, 2);
            this.tlpTrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTrade.Location = new System.Drawing.Point(0, 0);
            this.tlpTrade.Name = "tlpTrade";
            this.tlpTrade.RowCount = 3;
            this.tlpTrade.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpTrade.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTrade.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpTrade.Size = new System.Drawing.Size(814, 640);
            this.tlpTrade.TabIndex = 0;
            // 
            // panel1
            // 
            this.tlpTrade.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.btnSynchro);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 34);
            this.panel1.TabIndex = 0;
            // 
            // btnSynchro
            // 
            this.btnSynchro.BackColor = System.Drawing.Color.White;
            this.btnSynchro.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSynchro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSynchro.Location = new System.Drawing.Point(678, 0);
            this.btnSynchro.Name = "btnSynchro";
            this.btnSynchro.Size = new System.Drawing.Size(130, 34);
            this.btnSynchro.TabIndex = 3;
            this.btnSynchro.Text = "Synchronizuj";
            this.btnSynchro.UseVisualStyleBackColor = false;
            this.btnSynchro.Click += new System.EventHandler(this.btnSynchro_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRemove.Location = new System.Drawing.Point(195, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 34);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Usuń";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.White;
            this.btnModify.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModify.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModify.Location = new System.Drawing.Point(90, 0);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(105, 34);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "Modyfikuj";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.White;
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreate.Location = new System.Drawing.Point(0, 0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(90, 34);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Dodaj";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dgvInventTable
            // 
            this.dgvInventTable.AllowUserToAddRows = false;
            this.dgvInventTable.AllowUserToDeleteRows = false;
            this.dgvInventTable.AutoGenerateColumns = false;
            this.dgvInventTable.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdInvent,
            this.colNameInvent,
            this.colModifyInvent});
            this.dgvInventTable.DataSource = this.bsInventTable;
            this.dgvInventTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventTable.Location = new System.Drawing.Point(3, 43);
            this.dgvInventTable.Name = "dgvInventTable";
            this.dgvInventTable.ReadOnly = true;
            this.dgvInventTable.RowHeadersVisible = false;
            this.dgvInventTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventTable.Size = new System.Drawing.Size(401, 444);
            this.dgvInventTable.TabIndex = 1;
            // 
            // colIdInvent
            // 
            this.colIdInvent.DataPropertyName = "Id";
            this.colIdInvent.HeaderText = "Id";
            this.colIdInvent.Name = "colIdInvent";
            this.colIdInvent.ReadOnly = true;
            // 
            // colNameInvent
            // 
            this.colNameInvent.DataPropertyName = "Name";
            this.colNameInvent.HeaderText = "Name";
            this.colNameInvent.Name = "colNameInvent";
            this.colNameInvent.ReadOnly = true;
            // 
            // colModifyInvent
            // 
            this.colModifyInvent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colModifyInvent.DataPropertyName = "ModifiedDate";
            this.colModifyInvent.HeaderText = "ModifiedDate";
            this.colModifyInvent.Name = "colModifyInvent";
            this.colModifyInvent.ReadOnly = true;
            // 
            // bsInventTable
            // 
            this.bsInventTable.DataSource = typeof(Trade.Models.InventTable);
            // 
            // dgvTradeObject
            // 
            this.dgvTradeObject.AllowUserToAddRows = false;
            this.dgvTradeObject.AllowUserToDeleteRows = false;
            this.dgvTradeObject.AutoGenerateColumns = false;
            this.dgvTradeObject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTradeObject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdTrade,
            this.colNameTrade,
            this.colModifyTrade});
            this.dgvTradeObject.DataSource = this.bsTradeObject;
            this.dgvTradeObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTradeObject.Location = new System.Drawing.Point(410, 43);
            this.dgvTradeObject.Name = "dgvTradeObject";
            this.dgvTradeObject.ReadOnly = true;
            this.dgvTradeObject.RowHeadersVisible = false;
            this.dgvTradeObject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTradeObject.Size = new System.Drawing.Size(401, 444);
            this.dgvTradeObject.TabIndex = 2;
            // 
            // colIdTrade
            // 
            this.colIdTrade.DataPropertyName = "Id";
            this.colIdTrade.HeaderText = "Id";
            this.colIdTrade.Name = "colIdTrade";
            this.colIdTrade.ReadOnly = true;
            // 
            // colNameTrade
            // 
            this.colNameTrade.DataPropertyName = "Name";
            this.colNameTrade.HeaderText = "Name";
            this.colNameTrade.Name = "colNameTrade";
            this.colNameTrade.ReadOnly = true;
            // 
            // colModifyTrade
            // 
            this.colModifyTrade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colModifyTrade.DataPropertyName = "ModifiedDate";
            this.colModifyTrade.HeaderText = "ModifiedDate";
            this.colModifyTrade.Name = "colModifyTrade";
            this.colModifyTrade.ReadOnly = true;
            // 
            // bsTradeObject
            // 
            this.bsTradeObject.DataSource = typeof(Trade.Models.TradeObject);
            // 
            // rtInventTable
            // 
            this.tlpTrade.SetColumnSpan(this.rtInventTable, 2);
            this.rtInventTable.Location = new System.Drawing.Point(3, 493);
            this.rtInventTable.Name = "rtInventTable";
            this.rtInventTable.Size = new System.Drawing.Size(808, 122);
            this.rtInventTable.TabIndex = 3;
            this.rtInventTable.Text = "";
            // 
            // ssTrade
            // 
            this.ssTrade.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslVersion,
            this.tsslDatabase,
            this.tsslUser});
            this.ssTrade.Location = new System.Drawing.Point(0, 618);
            this.ssTrade.Name = "ssTrade";
            this.ssTrade.Size = new System.Drawing.Size(814, 22);
            this.ssTrade.TabIndex = 1;
            this.ssTrade.Text = "statusStrip1";
            // 
            // tsslVersion
            // 
            this.tsslVersion.Name = "tsslVersion";
            this.tsslVersion.Size = new System.Drawing.Size(78, 17);
            this.tsslVersion.Text = "Wersja 1.0.0.0";
            // 
            // tsslDatabase
            // 
            this.tsslDatabase.Name = "tsslDatabase";
            this.tsslDatabase.Size = new System.Drawing.Size(65, 17);
            this.tsslDatabase.Text = "Baza: Trade";
            // 
            // tsslUser
            // 
            this.tsslUser.Name = "tsslUser";
            this.tsslUser.Size = new System.Drawing.Size(96, 17);
            this.tsslUser.Text = "Użytkownik: root";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 640);
            this.Controls.Add(this.ssTrade);
            this.Controls.Add(this.tlpTrade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trade ";
            this.tlpTrade.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInventTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTradeObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTradeObject)).EndInit();
            this.ssTrade.ResumeLayout(false);
            this.ssTrade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTrade;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvInventTable;
        private System.Windows.Forms.DataGridView dgvTradeObject;
        private System.Windows.Forms.RichTextBox rtInventTable;
        private System.Windows.Forms.StatusStrip ssTrade;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersion;
        private System.Windows.Forms.ToolStripStatusLabel tsslDatabase;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.Button btnSynchro;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdInvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameInvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModifyInvent;
        private System.Windows.Forms.BindingSource bsInventTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdTrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameTrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModifyTrade;
        private System.Windows.Forms.BindingSource bsTradeObject;
    }
}