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
    public partial class signin : System.Web.UI.Page
    {
        public String temp_esaarum_id, temp_serial_no, temp_date, temp_user_name;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                String src = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\shakthydoss\\Documents\\Visual Studio 2008\\esaarum\\esaarum\\App_Data\\Database1.mdf;Integrated Security=True;User Instance=True";
                String comm = "select password from signup_table where email_id ='" + TextBox1.Text + "'";
                SqlConnection conn = new SqlConnection(src);
                conn.Open();
                SqlCommand sqlcomm = new SqlCommand(comm, conn);
                object result = sqlcomm.ExecuteScalar();
                //  Response.Write(result.ToString());
               
                if (TextBox2.Text.Equals(result.ToString()))
                {
                    
                    try
                    {
                        
                      //  String src = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\shakthydoss\\Documents\\Visual Studio 2008\\esaarum\\esaarum\\App_Data\\Database1.mdf;Integrated Security=True;User Instance=True";

                        // for getting date and storing the value into temp_date
                        String comm11 = "SELECT GETDATE() AS [CurrentDateTime] ";
                        SqlConnection conn11 = new SqlConnection(src);
                        conn11.Open();
                        SqlCommand sqlcomm11 = new SqlCommand(comm11, conn11);
                        object result11 = sqlcomm11.ExecuteScalar();
                        temp_date = result11.ToString();
                        Response.Write(" date = " + result11.ToString());
                        conn11.Close();


                        // for getting esaarum_id  and storing the value into temp_esaarum_id
                        String comm22 = "select esaarum_id from signup_table where email_id ='" + TextBox1.Text + "'";
                        SqlConnection conn22 = new SqlConnection(src);
                        conn22.Open();
                        SqlCommand sqlcomm22 = new SqlCommand(comm22, conn22);
                        object result22 = sqlcomm22.ExecuteScalar();
                        temp_esaarum_id = result22.ToString();
                        Response.Write(" esaarum_id  = " + result22.ToString());
                        conn22.Close();

                      
                        // for getting serial no and storing the value into temp_serial_no 
                        String comm33 = "SELECT max(serial_no +1) from signin_table";
                        SqlConnection conn33 = new SqlConnection(src);
                        conn33.Open();
                        SqlCommand sqlcomm33 = new SqlCommand(comm33, conn33);
                        object result33 = sqlcomm33.ExecuteScalar();
                        temp_serial_no = result33.ToString();
                        Response.Write(" serial n0 =" + result33.ToString());
                        conn33.Close();


                        // inserting data to signin_table
                        String comm44 = "insert into signin_table values(" + temp_serial_no + ",'" + temp_esaarum_id + "','" + temp_date + "')";
                        SqlConnection conn44 = new SqlConnection(src);
                        conn44.Open();
                        SqlCommand sqlcomm44 = new SqlCommand(comm44, conn44);
                        sqlcomm44.ExecuteScalar();
                        conn44.Close();

                    }
                    catch (Exception  )
                    {
                        Response.Write("Error in updating signin table");

                    }


                    Response.Redirect("Mypage.aspx?e5@@ru3Parametervalue="+temp_esaarum_id);
                   

                }//if loop closing
                else
                {
                    Label3.Text = "The Email-id or password you entered is incorrect";
                }
            }

            catch (Exception )
            {
                Label3.Text = "The Email-id or password you entered is incorrect";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("signup.aspx");

        }
    }
}
