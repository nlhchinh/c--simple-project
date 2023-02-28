using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab4
{
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        void Reset()
        {
            txtStudentCode.Text = txtName.Text = txtPhoneNumber.Text = "";
            txtStudentCode.Enabled = true;
            btnDelete.Visible = false;
        }

        protected void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtStudentCode.Enabled)
            {
                SqlDataSourceStudent.Insert();
            }
            SqlDataSourceStudent.Update();
            Reset();
        }

        protected void SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStudentCode.Text = GridView1.SelectedRow.Cells[0].Text;
            txtName.Text = GridView1.SelectedRow.Cells[1].Text;
            txtEmail.Text = GridView1.SelectedRow.Cells[2].Text;
            txtPhoneNumber.Text = GridView1.SelectedRow.Cells[3].Text;
            txtStudentCode.Enabled = false;
            btnDelete.Visible = true;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlDataSourceStudent.Delete();
            Reset();
        }
    }
}