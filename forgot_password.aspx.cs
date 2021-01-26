using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;

namespace esaarum
{
    public partial class forgot_password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                String src = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\shakthydoss\\Documents\\Visual Studio 2008\\esaarum\\esaarum\\App_Data\\Database1.mdf;Integrated Security=True;User Instance=True";
                String comm = "select security_question from signup_table where email_id ='" + TextBox1.Text + "'";
                SqlConnection conn = new SqlConnection(src);
                conn.Open();
                SqlCommand sqlcomm = new SqlCommand(comm, conn);
                object result = sqlcomm.ExecuteScalar();

                Label4.Text = result.ToString();
                Label3.Visible = true;
                Label4.Visible = true;
                TextBox2.Visible = true;
                Button2.Visible = false;
                Button1.Visible = false;
                Button3.Visible = true;
                Button4.Visible = true;
                TextBox1.Enabled = false;
                conn.Close();
            }
            catch (Exception ex)
            {
                Label6.Visible = true;
                Label6.Text = "Enter vaild email id";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            try
            {

                String src = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\shakthydoss\\Documents\\Visual Studio 2008\\esaarum\\esaarum\\App_Data\\Database1.mdf;Integrated Security=True;User Instance=True";
                String comm = "select security_answers from signup_table where email_id ='" + TextBox1.Text + "' AND security_question = '" + Label4.Text + "'";
                SqlConnection conn = new SqlConnection(src);
                conn.Open();
                SqlCommand sqlcomm = new SqlCommand(comm, conn);
                object result = sqlcomm.ExecuteScalar();
               if (TextBox2.Text.Equals(result.ToString()))
                {
                    Label7.Visible = true;
                    Label8.Visible = true;
                    Label9.Visible = true;
                    TextBox3.Visible = true;
                    TextBox4.Visible = true;
                    Button5.Visible = true;
                    Button6.Visible = true;
                    TextBox2.Enabled = false;
                    Button3.Visible = false;
                    Button4.Visible = false;
                    Label6.Visible = false;
                }
                else
                {
                    Label6.Visible = true;
                    Label6.Text = "Invaild Email ID";
                }
            }
            catch (Exception ex)
            {
                Label6.Visible = true;
                Label6.Text = "Invaild Email ID";
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("signin.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {

                String src = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\shakthydoss\\Documents\\Visual Studio 2008\\esaarum\\esaarum\\App_Data\\Database1.mdf;Integrated Security=True;User Instance=True";
                String comm = "update signup_table set password = '" + TextBox3.Text + "' where email_id ='" + TextBox1.Text + "' ";
                SqlConnection conn = new SqlConnection(src);
                conn.Open();
                SqlCommand sqlcomm = new SqlCommand(comm, conn);
                sqlcomm.ExecuteNonQuery();
                conn.Close();
                Label6.Visible = true;
                Label6.Text = "Successfully your new password updated.";
                Button7.Visible = true;
               // Response.Redirect("Mypage.aspx");
            }

            catch (Exception ex)
            {
                Label6.Visible = true;
                Label6.Text = "Error: your new password doesn’t updated ";
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mypage.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("signin.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("signin.aspx");
        }
    }
}
