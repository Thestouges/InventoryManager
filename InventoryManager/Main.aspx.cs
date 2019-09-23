using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace InventoryManager
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (File.Exists(Server.MapPath("~/SQLConnectionString.txt")))
            {
                Globals.connectionStr = File.ReadAllText(Server.MapPath("~/SQLConnectionString.txt"));
            }
            else
            {
                ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(),
                  "err_msg",
                  "alert('Database not loaded');",
                  true);
            }

            PopulateGrid();
        }

        private void PopulateGrid()
        {
            SQLModule sQL = new SQLModule();
            DataTable dt = sQL.GetItems();

            gvItems.DataSource = dt;
            gvItems.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SQLModule sQL = new SQLModule();
            DataTable dt = sQL.SearchItem(tbSearch.Text.Trim());

            gvItems.DataSource = dt;
            gvItems.DataBind();
            SearchTerm.Value = tbSearch.Text;
        }
    }
}