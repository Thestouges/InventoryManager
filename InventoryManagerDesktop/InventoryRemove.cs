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
    public partial class InventoryRemove : Form
    {
        public InventoryRemove()
        {
            InitializeComponent();
        }

        private void InventoryRemove_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void refreshGrid()
        {
            SQLclass sQLclass = new SQLclass();
            DataTable dt = sQLclass.GetAllItems();
            dgvItems.DataSource = dt;
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            SQLclass sQLclass = new SQLclass();
            sQLclass.RemoveItem(Int32.Parse(dgvItems.SelectedRows[0].Cells[0].Value.ToString()));
            refreshGrid();

            MessageBox.Show("Item removed");
        }
    }
}
