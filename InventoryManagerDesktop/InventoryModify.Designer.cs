namespace InventoryManagerDesktop
{
    partial class InventoryModify
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
            this.tbItemId = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(15, 64);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(240, 150);
            this.dgvItems.TabIndex = 0;
            // 
            // tbItemId
            // 
            this.tbItemId.Location = new System.Drawing.Point(74, 12);
            this.tbItemId.Name = "tbItemId";
            this.tbItemId.Size = new System.Drawing.Size(100, 20);
            this.tbItemId.TabIndex = 1;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(74, 38);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(100, 20);
            this.tbQuantity.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ItemID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantity";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(180, 12);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "Submit";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // InventoryModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 224);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.tbItemId);
            this.Controls.Add(this.dgvItems);
            this.Name = "InventoryModify";
            this.Text = "InventoryModify";
            this.Load += new System.EventHandler(this.InventoryModify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.TextBox tbItemId;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModify;
    }
}