using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace InventoryManagerDesktop
{
    public class SQLclass
    {
        public void AddItem(string item, string type, int quantity)
        {
            SqlConnection conn = new SqlConnection(Global.connectionStr);
            SqlCommand cmd = new SqlCommand("AddItem", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@item", SqlDbType.NVarChar);
            cmd.Parameters.Add("@type", SqlDbType.NVarChar);
            cmd.Parameters.Add("@quantity", SqlDbType.Int);
            cmd.Parameters["@item"].Value = item;
            cmd.Parameters["@type"].Value = type;
            cmd.Parameters["@quantity"].Value = quantity;

            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                throw new Exception(ex.Message);
            }
        }

        public void AddItemType(string itemType, string description)
        {
            SqlConnection conn = new SqlConnection(Global.connectionStr);
            SqlCommand cmd = new SqlCommand("AddItemType", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@itemType", SqlDbType.NVarChar);
            cmd.Parameters.Add("@description", SqlDbType.NVarChar);
            cmd.Parameters["@itemType"].Value = itemType;
            cmd.Parameters["@description"].Value = description;

            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                throw new Exception(ex.Message);
            }
        }

        public DataTable GetAllItemsTypes()
        {
            SqlConnection conn = new SqlConnection(Global.connectionStr);
            SqlCommand cmd = new SqlCommand("GetAllItemsTypes", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sqladapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqladapter.Fill(dt);

            return dt;
        }

        public DataTable GetAllTypeItems(string type)
        {
            SqlConnection conn = new SqlConnection(Global.connectionStr);
            SqlCommand cmd = new SqlCommand("GetAllTypeItems", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@type", SqlDbType.NVarChar);
            cmd.Parameters["@type"].Value = type;

            SqlDataAdapter sqladapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqladapter.Fill(dt);

            return dt;
        }

        public void ModifyItemQuantity(string itemID, int quantity)
        {
            SqlConnection conn = new SqlConnection(Global.connectionStr);
            SqlCommand cmd = new SqlCommand("ModifyItemQuantity", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@itemID", SqlDbType.Int);
            cmd.Parameters.Add("@quantity", SqlDbType.Int);
            cmd.Parameters["@itemID"].Value = itemID;
            cmd.Parameters["@quantity"].Value = quantity;

            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                throw new Exception(ex.Message);
            }
        }

        public void ModifyItemType(string itemType, string description)
        {
            SqlConnection conn = new SqlConnection(Global.connectionStr);
            SqlCommand cmd = new SqlCommand("ModifyItemType", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@itemType", SqlDbType.NVarChar);
            cmd.Parameters.Add("@description", SqlDbType.NVarChar);
            cmd.Parameters["@itemType"].Value = itemType;
            cmd.Parameters["@description"].Value = description;

            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                throw new Exception(ex.Message);
            }
        }

        public void RemoveItem(string itemID)
        {
            SqlConnection conn = new SqlConnection(Global.connectionStr);
            SqlCommand cmd = new SqlCommand("AddItem", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@itemID", SqlDbType.NVarChar);
            cmd.Parameters["@itemID"].Value = itemID;


            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                throw new Exception(ex.Message);
            }
        }
    }
}
