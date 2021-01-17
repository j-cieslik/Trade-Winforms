
namespace Trade.Forms.InventTables
{
    partial class InventTableAddForm
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
            this.lblInventTable = new System.Windows.Forms.Label();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.epName = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epName)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInventTable
            // 
            this.lblInventTable.AutoSize = true;
            this.lblInventTable.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInventTable.Location = new System.Drawing.Point(30, 30);
            this.lblInventTable.Name = "lblInventTable";
            this.lblInventTable.Size = new System.Drawing.Size(164, 30);
            this.lblInventTable.TabIndex = 0;
            this.lblInventTable.Text = "Wprowadź dane";
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.txtName);
            this.gbData.Controls.Add(this.lblName);
            this.gbData.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbData.Location = new System.Drawing.Point(35, 91);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(270, 186);
            this.gbData.TabIndex = 1;
            this.gbData.TabStop = false;
            this.gbData.Text = "Dane";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtName.Location = new System.Drawing.Point(123, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 25);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(21, 62);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nazwa";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Location = new System.Drawing.Point(158, 309);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Location = new System.Drawing.Point(276, 309);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // epName
            // 
            this.epName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epName.ContainerControl = this;
            // 
            // InventTableAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.lblInventTable);
            this.KeyPreview = true;
            this.Name = "InventTableAddForm";
            this.Text = "InventTableAddForm";
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInventTable;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider epName;
    }
}