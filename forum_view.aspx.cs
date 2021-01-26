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
    public partial class forum_view : System.Web.UI.Page
    {
        int start_intext = 1, stop_index = 10;

        protected void Page_Load(object sender, EventArgs e)
        {
            string[] tempforum_no = new string[9];

            Label1.Text = "1";
            Label2.Text = "2";
            Label3.Text = "3";
            Label4.Text = "4";
            Label5.Text = "5";
            Label6.Text = "6";
            Label7.Text = "7";
            Label8.Text = "8";
            Label9.Text = "9";
            Label10.Text = "10";

            Label11.Text = "";

            try
            {
                // for retiving recently updated forum 
                String src = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\shakthydoss\\Documents\\Visual Studio 2008\\esaarum\\esaarum\\App_Data\\Database1.mdf;Integrated Security=True;User Instance=True";
                String comm = "select DISTINCT form_tag from Forum3 where serial BETWEEN 1 AND 10 ";
                SqlConnection conn = new SqlConnection(src);
                conn.Open();
                SqlCommand sqlcomm = new SqlCommand(comm, conn);
                SqlDataReader myreader = sqlcomm.ExecuteReader();
                conn.Close();

                for (int i = 0; myreader.Read(); i++)
                {
                    tempforum_no[i] = myreader[0].ToString();

                }
            }
            catch (Exception){ }




           
            /*    String src1 = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\shakthydoss\\Documents\\Visual Studio 2008\\esaarum\\esaarum\\App_Data\\Database1.mdf;Integrated Security=True;User Instance=True";
                String comm1 = "select question  from Forum1 where forum_id = 'f100'";
                SqlConnection conn1 = new SqlConnection(src1);
                conn1.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(comm1, conn1);
                

                object result = comm1.ExecuteReader();
                Label11.Text = result.ToString();

           */


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
                    string [] tempQuestion = new string[9];
                    string [] tempReply = new string[9];
                    
            try
            {
                String src = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\shakthydoss\\Documents\\Visual Studio 2008\\esaarum\\esaarum\\App_Data\\Database1.mdf;Integrated Security=True;User Instance=True";
                String comm = "select max(serial) from Forum3";
                SqlConnection conn = new SqlConnection(src);
                conn.Open();
                SqlCommand sqlcomm = new SqlCommand(comm, conn);
                object result = sqlcomm.ExecuteScalar();
                conn.Close();
            }
            catch (Exception)
            {

            }



            




            
        }
    }
}
