using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp
{
    class ProductDAO
    {
        string strConnection;

        public string getConnectionString()
        {
            string strConnection = @"server=Admin;database=ProductDB;uid=sa;pwd=12345";
            return strConnection;
        }
        public ProductDAO()
        {
            strConnection = getConnectionString();
        }

        public DataTable getProduct()
        {
            string SQL = "select * from Products";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtProduct = new DataTable();
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                da.Fill(dtProduct);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                cnn.Close();
            }
            return dtProduct;
        }

        public bool addProduct(Products products)
        {
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "Insert Products values(@productID,@productName,@category,@description,@date)";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@productID", products.productID);
            cmd.Parameters.AddWithValue("@productName", products.productName);
            cmd.Parameters.AddWithValue("@category", products.category);
            cmd.Parameters.AddWithValue("@description", products.description);
            cmd.Parameters.AddWithValue("@date", products.date);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            int count;
            try
            {
                count = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                count = 0;
            }
            return (count > 0);
        }

        public bool updateProduct(Products products)
        {
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "Update Products set productName=@productName,category=@category,description=@description,date=@date " +
                "where productID=@productID";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@productID", products.productID);
            cmd.Parameters.AddWithValue("@productName", products.productName);
            cmd.Parameters.AddWithValue("@category", products.category);
            cmd.Parameters.AddWithValue("@description", products.description);
            cmd.Parameters.AddWithValue("@date", products.date);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return (count > 0);
        }

        public bool removProduct(int productID)
        {
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "Delete Products where productID=@productID";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@productID", productID);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return (count > 0);
        }
    }
}

