namespace InventoryManagerDesktop
{
    partial class Main
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnViewHistory = new System.Windows.Forms.Button();
            this.btnAddItemType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 41);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(143, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add to Inventory";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(12, 70);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(143, 23);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check Inventory";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(12, 99);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(143, 23);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "Modify Inventory";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 128);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(143, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove from Inventory";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnViewHistory
            // 
            this.btnViewHistory.Location = new System.Drawing.Point(12, 157);
            this.btnViewHistory.Name = "btnViewHistory";
            this.btnViewHistory.Size = new System.Drawing.Size(143, 23);
            this.btnViewHistory.TabIndex = 4;
            this.btnViewHistory.Text = "View Inventory History";
            this.btnViewHistory.UseVisualStyleBackColor = true;
            this.btnViewHistory.Click += new System.EventHandler(this.BtnViewHistory_Click);
            // 
            // btnAddItemType
            // 
            this.btnAddItemType.Location = new System.Drawing.Point(12, 12);
            this.btnAddItemType.Name = "btnAddItemType";
            this.btnAddItemType.Size = new System.Drawing.Size(143, 23);
            this.btnAddItemType.TabIndex = 5;
            this.btnAddItemType.Text = "Add Item Type";
            this.btnAddItemType.UseVisualStyleBackColor = true;
            this.btnAddItemType.Click += new System.EventHandler(this.BtnAddItemType_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 189);
            this.Controls.Add(this.btnAddItemType);
            this.Controls.Add(this.btnViewHistory);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnAdd);
            this.Name = "Main";
            this.Text = "Inventory Manager";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnViewHistory;
        private System.Windows.Forms.Button btnAddItemType;
    }
}

