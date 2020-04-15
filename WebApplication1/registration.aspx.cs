using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace ConestogaHomes
{
    public partial class registration : System.Web.UI.Page

    {
        string connecctionString = @"Data Source=LAPTOP-E62UMEUC;Initial Catalog=Student Registration;Integrated Security=True";
        private object TextLastName;
        private object TextContact;
        private object DGender;
        private object TextUserName;
        private readonly object textFirstName;
        private readonly object hfStudentID;

        public object TextAddress { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon=new SqlConnection(connecctionString))
            {
                sqlcon.Open();
                SqlCommand sqlcomd = new SqlCommand("UserAddOrEdit");
                sqlcomd.CommandType = CommandType.StoredProcedure;
                sqlcomd.Parameters.AddWithValue("@Student ID", Convert.ToInt32(hfStudentID.Value.""?"0":hfStudentID.value));
                sqlcomd.Parameters.AddWithValue("@First Name", txtFirstName.Text.Trim());
                sqlcomd.Parameters.AddWithValue("@Last Name", txtLastName.Text.Trim());
                sqlcomd.Parameters.AddWithValue("@Contact", txtContact.Text.Trim());
                sqlcomd.Parameters.AddWithValue("@Gender", DGender.SelectedValue());
                sqlcomd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                sqlcomd.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
                sqlcomd.Parameters.AddWithValue("@UserName", Password.Text.Trim());
                sqlcomd.ExecuteNonQuery()
                    lblSuccessMsg.text = "Submitted Successfully";
            }

        }

        void clear()
        {

        }
    }

}