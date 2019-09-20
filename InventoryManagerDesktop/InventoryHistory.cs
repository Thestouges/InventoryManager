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
    public partial class InventoryHistory : Form
    {
        public InventoryHistory()
        {
            InitializeComponent();
        }

        private void InventoryHistory_Load(object sender, EventArgs e)
        {
            SQLclass sQLclass = new SQLclass();
            DataTable dt = sQLclass.GetInventoryHistory();

            dgvHistory.DataSource = dt;
        }
    }
}
