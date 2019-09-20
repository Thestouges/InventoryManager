namespace InventoryManagerDesktop
{
    partial class InventoryAddType
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
            this.tbItemType = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddItemType = new System.Windows.Forms.Button();
            this.dgvItemType = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemType)).BeginInit();
            this.SuspendLayout();
            // 
            // tbItemType
            // 
            this.tbItemType.Location = new System.Drawing.Point(118, 12);
            this.tbItemType.Name = "tbItemType";
            this.tbItemType.Size = new System.Drawing.Size(302, 20);
            this.tbItemType.TabIndex = 0;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(118, 38);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(302, 20);
            this.tbDescription.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Item Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddItemType
            // 
            this.btnAddItemType.Location = new System.Drawing.Point(317, 64);
            this.btnAddItemType.Name = "btnAddItemType";
            this.btnAddItemType.Size = new System.Drawing.Size(103, 23);
            this.btnAddItemType.TabIndex = 8;
            this.btnAddItemType.Text = "Add Item Type";
            this.btnAddItemType.UseVisualStyleBackColor = true;
            this.btnAddItemType.Click += new System.EventHandler(this.BtnAddItemType_Click);
            // 
            // dgvItemType
            // 
            this.dgvItemType.AllowUserToAddRows = false;
            this.dgvItemType.AllowUserToDeleteRows = false;
            this.dgvItemType.AllowUserToResizeColumns = false;
            this.dgvItemType.AllowUserToResizeRows = false;
            this.dgvItemType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemType.Location = new System.Drawing.Point(12, 93);
            this.dgvItemType.MultiSelect = false;
            this.dgvItemType.Name = "dgvItemType";
            this.dgvItemType.ReadOnly = true;
            this.dgvItemType.RowHeadersVisible = false;
            this.dgvItemType.Size = new System.Drawing.Size(406, 274);
            this.dgvItemType.TabIndex = 9;
            // 
            // InventoryAddType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 379);
            this.Controls.Add(this.dgvItemType);
            this.Controls.Add(this.btnAddItemType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbItemType);
            this.Name = "InventoryAddType";
            this.Text = "InventoryAddType";
            this.Load += new System.EventHandler(this.InventoryAddType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbItemType;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddItemType;
        private System.Windows.Forms.DataGridView dgvItemType;
    }
}