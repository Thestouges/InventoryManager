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
    public partial class InventoryModify : Form
    {
        public InventoryModify()
        {
            InitializeComponent();
        }

        private void InventoryModify_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void refreshGrid()
        {
            SQLclass sQLclass = new SQLclass();
            DataTable dt = sQLclass.GetAllItems();
            dgvItems.DataSource = dt;
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            SQLclass sQLclass = new SQLclass();
            sQLclass.ModifyItemQuantity(tbItemId.Text, Int32.Parse(tbQuantity.Text));

            tbItemId.Text = "";
            tbQuantity.Text = "";

            refreshGrid();
        }
    }
}
