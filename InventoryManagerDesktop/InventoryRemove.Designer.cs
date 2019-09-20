namespace InventoryManagerDesktop
{
    partial class InventoryRemove
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
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToResizeColumns = false;
            this.dgvItems.AllowUserToResizeRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(12, 12);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(430, 269);
            this.dgvItems.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(333, 287);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(109, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove Selected";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // InventoryRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 319);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvItems);
            this.Name = "InventoryRemove";
            this.Text = "InventoryRemove";
            this.Load += new System.EventHandler(this.InventoryRemove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button btnRemove;
    }
}