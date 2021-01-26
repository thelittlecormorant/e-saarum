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
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int flag_check_for_redundancy_user = 0;
            try
            {
                String src = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\shakthydoss\\Documents\\Visual Studio 2008\\esaarum\\esaarum\\App_Data\\Database1.mdf;Integrated Security=True;User Instance=True";
               // String comm = "select user_name from signup_table where user_name = '" + TextBox1.Text + "'";
                String comm = "select email_id from signup_table where email_id ='" + TextBox4.Text + "'";
                SqlConnection conn = new SqlConnection(src);
                conn.Open();
                SqlCommand sqlcomm = new SqlCommand(comm, conn);
                object result = sqlcomm.ExecuteScalar();
                //String = username_check = null;
                if (TextBox4.Text.Equals(result.ToString()))
                flag_check_for_redundancy_user = 0;
                Response.Write("This Email-id already is already exist");
            }
            catch (Exception ex)
            {
                Response.Write("This Email-id is valied");
              
               flag_check_for_redundancy_user = 1;
            }

            // sending data to signup_table
            if (flag_check_for_redundancy_user == 1)
            {

                // for selecting esaarum id from signup_table
                try
                {
                    String src = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\shakthydoss\\Documents\\Visual Studio 2008\\esaarum\\esaarum\\App_Data\\Database1.mdf;Integrated Security=True;User Instance=True";
                    String comm = "select max(esaarum_id+1) from signup_table ";
                    SqlConnection conn = new SqlConnection(src);
                    conn.Open();
                    SqlCommand sqlcomm = new SqlCommand(comm, conn);
                    object result = sqlcomm.ExecuteScalar();
                    Label7_for_esaarum_id.Text = (result.ToString());
                }
                catch (Exception ex)
                {
                    Response.Write("Error in selecting esaarum id for you please try later");

                }

                // for inserting data 
                try
                {
                    String src = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\shakthydoss\\Documents\\Visual Studio 2008\\esaarum\\esaarum\\App_Data\\Database1.mdf;Integrated Security=True;User Instance=True";
                    String comm = "insert into signup_table values(" + Label7_for_esaarum_id.Text + ",'" + TextBox1.Text + "','" + TextBox7.Text + "','" + TextBox4.Text + "','" + DropDownList1.Text + "','" + TextBox6.Text + "'" + ")";
                    SqlConnection conn = new SqlConnection(src);
                    conn.Open();
                    SqlCommand sqlcomm = new SqlCommand(comm, conn);
                    sqlcomm.ExecuteNonQuery();
                    conn.Close();
                    Response.Redirect("Mypage.aspx");
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error in connection");

                }

                try
                {
                    String src = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\shakthydoss\\Documents\\Visual Studio 2008\\esaarum\\esaarum\\App_Data\\Database1.mdf;Integrated Security=True;User Instance=True";
                    String comm = "insert into Profile_Table esaarum_id values(" + Label7_for_esaarum_id.Text + ")";
                    SqlConnection conn = new SqlConnection(src);
                    conn.Open();
                    SqlCommand sqlcomm = new SqlCommand(comm, conn);
                    sqlcomm.ExecuteNonQuery();
                    conn.Close();
                    Response.Redirect("signin.aspx");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in connection");

                }

            }//if closing 
        }
    }
}
