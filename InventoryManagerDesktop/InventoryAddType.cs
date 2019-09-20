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
    public partial class InventoryAddType : Form
    {
        public InventoryAddType()
        {
            InitializeComponent();
        }

        private void refreshgrid()
        {
            SQLclass sQLclass = new SQLclass();
            DataTable dt = sQLclass.GetAllItemsTypes();
            dgvItemType.DataSource = dt;
        }

        private void BtnAddItemType_Click(object sender, EventArgs e)
        {
            SQLclass sQLclass = new SQLclass();
            sQLclass.AddItemType(tbItemType.Text,tbDescription.Text);

            MessageBox.Show("Item Type Added");
            refreshgrid();

            tbItemType.Text = "";
            tbDescription.Text = "";
        }

        private void InventoryAddType_Load(object sender, EventArgs e)
        {
            AcceptButton = btnAddItemType;
            refreshgrid();
        }
    }
}
