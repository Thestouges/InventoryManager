namespace InventoryManagerDesktop
{
    partial class InventoryCheckItems
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
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.cbItemTypes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToResizeColumns = false;
            this.dgvItems.AllowUserToResizeRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(12, 39);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(601, 285);
            this.dgvItems.TabIndex = 0;
            // 
            // cbItemTypes
            // 
            this.cbItemTypes.FormattingEnabled = true;
            this.cbItemTypes.Location = new System.Drawing.Point(12, 12);
            this.cbItemTypes.Name = "cbItemTypes";
            this.cbItemTypes.Size = new System.Drawing.Size(287, 21);
            this.cbItemTypes.TabIndex = 1;
            this.cbItemTypes.SelectedIndexChanged += new System.EventHandler(this.CbItemTypes_SelectedIndexChanged);
            // 
            // InventoryCheckItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 336);
            this.Controls.Add(this.cbItemTypes);
            this.Controls.Add(this.dgvItems);
            this.Name = "InventoryCheckItems";
            this.Text = "InventoryCheckItems";
            this.Load += new System.EventHandler(this.InventoryCheckItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.ComboBox cbItemTypes;
    }
}