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
    public partial class InventoryCheckItems : Form
    {
        public InventoryCheckItems()
        {
            InitializeComponent();
        }

        private void InventoryCheckItems_Load(object sender, EventArgs e)
        {
            SQLclass sQLclass = new SQLclass();
            DataTable dt = sQLclass.GetAllItemsTypes();

            cbItemTypes.DataSource = dt;
            cbItemTypes.ValueMember = "Type";
            cbItemTypes.DisplayMember = "Description";

        }

        private void CbItemTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLclass sQLclass = new SQLclass();
            DataTable dt = sQLclass.GetAllTypeItems(cbItemTypes.SelectedValue.ToString());
            dgvItems.DataSource = dt;
        }
    }
}
