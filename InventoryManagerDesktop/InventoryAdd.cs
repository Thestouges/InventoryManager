using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagerDesktop
{
    public partial class InventoryAdd : Form
    {
        public InventoryAdd()
        {
            InitializeComponent();
        }

        private void InventoryAdd_Load(object sender, EventArgs e)
        {
            SQLclass sQLclass = new SQLclass();
            DataTable dt = sQLclass.GetAllItemsTypes();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No item types found. Add item types first before adding items");
                this.Close();
            }

            cbType.DataSource = dt;
            cbType.ValueMember = "Type";
            cbType.DisplayMember = "Description";

            AcceptButton = btnAddItem;
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            SQLclass sQLclass = new SQLclass();
            sQLclass.AddItem(tbItem.Text, cbType.SelectedValue.ToString(), Int32.Parse(tbQuantity.Text));

            MessageBox.Show(tbItem.Text + " Added");

            tbItem.Text = "";
            tbQuantity.Text = "";
        }
    }
}
