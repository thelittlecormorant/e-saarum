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
    public partial class Testpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = FetchAllImagesInfo();
            GridView1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
                if (FileUpload1.PostedFile != null&& FileUpload1.PostedFile.FileName != "")
                {

                    byte[] myimage = new byte[FileUpload1.PostedFile.ContentLength];
                    HttpPostedFile Image = FileUpload1.PostedFile;
                    Image.InputStream.Read(myimage, 0, (int)FileUpload1.PostedFile.ContentLength);

                    SqlConnection myConnection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\shakthydoss\\Documents\\Visual Studio 2008\\esaarum\\esaarum\\App_Data\\Database1.mdf;Integrated Security=True;User Instance=True");
                    SqlCommand storeimage = new SqlCommand("INSERT INTO ImageGallery "+"(Img_Content, Img_Type, Image_Size) "+" values (@image, @imagetype, @imagesize)", myConnection);
                    storeimage.Parameters.Add("@image", SqlDbType.Image, myimage.Length).Value = myimage;
                    storeimage.Parameters.Add("@imagetype", SqlDbType.VarChar, 100).Value= FileUpload1.PostedFile.ContentType;
                    storeimage.Parameters.Add("@imagesize", SqlDbType.BigInt, 99999).Value= FileUpload1.PostedFile.ContentLength;

                    myConnection.Open();
                    storeimage.ExecuteNonQuery();
                    myConnection.Close();
                }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        public DataTable FetchAllImagesInfo()
           
        {
        string sql = "Select * from ImageGallery"; 
  SqlDataAdapter da = new SqlDataAdapter(sql, "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\shakthydoss\\Documents\\Visual Studio 2008\\esaarum\\esaarum\\App_Data\\Database1.mdf;Integrated Security=True;User Instance=True"); 
  DataTable dt = new DataTable(); 
  da.Fill(dt); 
  return dt;
}

        protected void Button2_Click(object sender, EventArgs e)
        {

            String src = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\shakthydoss\\Documents\\Visual Studio 2008\\esaarum\\esaarum\\App_Data\\Database1.mdf;Integrated Security=True;User Instance=True";
            String comm = "select DISTINCT form_tag from Forum3 where serial BETWEEN 1 AND 10 ";
            SqlConnection conn = new SqlConnection(src);
            conn.Open();
            SqlCommand sqlcomm = new SqlCommand(comm, conn);

            SqlDataReader myreader = sqlcomm.ExecuteReader();


            for (int i = 0; myreader.Read(); i++)
            {
                ListBox1.Items.Add(myreader[0].ToString());

            }
            conn.Close();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int[] temp = new int[3];
            temp[0] = 1;
            temp[1] = 2;
          //  temp[2] = 10;
            
            String src = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\shakthydoss\\Documents\\Visual Studio 2008\\esaarum\\esaarum\\App_Data\\Database1.mdf;Integrated Security=True;User Instance=True";
            String comm = "select DISTINCT form_tag from Forum3 where serial IN ("+temp[1]+","+temp[2]+","+temp[0]+") ";
            SqlConnection conn = new SqlConnection(src);
            conn.Open();
            SqlCommand sqlcomm = new SqlCommand(comm, conn);

            SqlDataReader myreader = sqlcomm.ExecuteReader();


            for (int i = 0; myreader.Read(); i++)
            {
                ListBox1.Items.Add(myreader[0].ToString());

            }
            conn.Close();
            
        }

       

        
    }
}
