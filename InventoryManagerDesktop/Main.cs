using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagerDesktop
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!File.Exists("SQLConnectionString.txt"))
            {
                DatabaseInfo getconnStr = new DatabaseInfo();
                getconnStr.ShowDialog();
            }
            else
            {
                Global.connectionStr = File.ReadAllText("SQLConnectionString.txt");
            }

            if (Global.connectionStr == "")
            {
                this.Close();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            InventoryAdd inventoryAdd = new InventoryAdd();
            inventoryAdd.ShowDialog();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            InventoryCheckItems inventoryCheck = new InventoryCheckItems();
            inventoryCheck.ShowDialog();
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            InventoryModify inventoryModify = new InventoryModify();
            inventoryModify.ShowDialog();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            InventoryRemove inventoryRemove = new InventoryRemove();
            inventoryRemove.ShowDialog();
        }

        private void BtnViewHistory_Click(object sender, EventArgs e)
        {
            InventoryHistory inventoryHistory = new InventoryHistory();
            inventoryHistory.ShowDialog();
        }

        private void BtnAddItemType_Click(object sender, EventArgs e)
        {
            InventoryAddType addType = new InventoryAddType();
            addType.ShowDialog();
        }
    }
}
