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
    public partial class Mypage : System.Web.UI.Page
    {
        string temp_user_name;

        protected void Page_Load(object sender, EventArgs e)
        {


            disable_funtion();

           
           
            TextBox3.Text = Request.QueryString["e5@@ru3Parametervalue"].ToString(); // essarum_id for TextBox3
            String temp_id = Request.QueryString["e5@@ru3Parametervalue"].ToString();
           
            String src = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\shakthydoss\\Documents\\Visual Studio 2008\\esaarum\\esaarum\\App_Data\\Database1.mdf;Integrated Security=True;User Instance=True";
            String comm55 = "select user_name from signup_table where esaarum_id =" + temp_id+ "";
            SqlConnection conn55 = new SqlConnection(src);
            conn55.Open();
            SqlCommand sqlcomm55 = new SqlCommand(comm55, conn55);
            object result55 = sqlcomm55.ExecuteScalar();
            temp_user_name = result55.ToString();
            
            conn55.Close();
            
            Response.Write("Welcome ! "+temp_user_name);

            profile_Load();
         
        }

        protected void profile_Load()
        {
            String src = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\shakthydoss\\Documents\\Visual Studio 2008\\esaarum\\esaarum\\App_Data\\Database1.mdf;Integrated Security=True;User Instance=True";
            String comm = "select FirstName,LastName,AboutMe,day,month,year,Gender,AddressLine1,AddressLine2,Street,Area,City,State,NameOfSchool,Class,FavoriteSubject,Hobbies,AreaOfInterest,Achievement,Sports,Music,StoryBooks,Others from Profile_Table where esaarum_id ='" + TextBox3.Text + "'";
            SqlConnection conn = new SqlConnection(src);
            conn.Open();
            SqlCommand sqlcomm = new SqlCommand(comm, conn);
            SqlDataReader dr = sqlcomm.ExecuteReader();

            while (dr.Read())
            {
                FirstnameTextBox1.Text = dr[0].ToString(); // first name
                TextBox2.Text = dr[1].ToString();// last name 

                TextBox13.Text = dr[2].ToString(); //about me 

                DropDownList4.Text = dr[3].ToString(); // day 
                DropDownList5.Text = dr[4].ToString();// month 
                DropDownList6.Text = dr[5].ToString(); // year 
                DropDownList2.Text = dr[6].ToString();// gender 

                TextBox7.Text = dr[7].ToString();  //add line 1
                TextBox8.Text = dr[8].ToString();  // add line 2
                TextBox9.Text = dr[9].ToString();  // area 

                DropDownList3.Text = dr[10].ToString(); // city 

                TextBox11.Text = dr[11].ToString(); // pin code

                DropDownList1.Text = dr[12].ToString();// state 

                TextBox14.Text = dr[13].ToString(); // name of school
                TextBox15.Text = dr[14].ToString(); // class 
                TextBox16.Text = dr[15].ToString(); // fav sub
                TextBox17.Text = dr[16].ToString(); // hobbies 
                TextBox18.Text = dr[17].ToString(); //area of interest 
                TextBox19.Text = dr[18].ToString(); // achivement 

                TextBox20.Text = dr[19].ToString(); //sport
                TextBox21.Text = dr[20].ToString(); //music 
                TextBox22.Text = dr[21].ToString(); // books  
                TextBox23.Text = dr[22].ToString();// others 

            }
            conn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            enable_funtion();
        }


        protected void disable_funtion()
        {
            FirstnameTextBox1.Enabled = false; //first name 
            TextBox2.Enabled = false; // last name 
            TextBox3.Enabled = false; // esaarum id 
            TextBox13.Enabled = false; //about me 

            DropDownList4.Enabled = false; // day 
            DropDownList5.Enabled = false;// month 
            DropDownList6.Enabled = false; // year 
            DropDownList2.Enabled = false;// gender 
            TextBox7.Enabled = false;  //add line 1
            TextBox8.Enabled = false;  // add line 2
            TextBox9.Enabled = false;  // area 
            DropDownList3.Enabled = false; // city 
            TextBox11.Enabled = false; // pin code 
            DropDownList1.Enabled = false;// state 
            TextBox14.Enabled = false; // name of school
            TextBox15.Enabled = false; // class 
            TextBox16.Enabled = false; // fav sub
            TextBox17.Enabled = false; // hobbies 
            TextBox18.Enabled = false; //area of interest 
            TextBox19.Enabled = false; // achivement 

            TextBox20.Enabled = false; //sport
            TextBox21.Enabled = false; //music 
            TextBox22.Enabled = false; // books  
            TextBox23.Enabled = false; // others 

            Button6.Enabled = false; // save 
            Button5.Enabled = false; // save 
            Button4.Enabled = false; // save
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            
                String newsrc = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\shakthydoss\\Documents\\Visual Studio 2008\\esaarum\\esaarum\\App_Data\\Database1.mdf;Integrated Security=True;User Instance=True";
                // String newcomm = " update Profile_Table set FirstName = '" + FirstnameTextBox1.Text + "',LastName ='" + TextBox2.Text + "',AboutMe ='" + TextBox1.Text + "',day ='" + DropDownList4.Text + "',month ='" + DropDownList5.Text + "',year ='" + DropDownList6.Text + "',Gender =' " + DropDownList2.Text + "',AddressLine1 ='" + TextBox7.Text + "',AddressLine2 = '" + TextBox8.Text + "',Street='" + TextBox9.Text + "',Area = '" + DropDownList3.Text + "',City = '" + TextBox11.Text + "',State ='" + DropDownList1.Text + "',NameOfSchool='" + TextBox14.Text + "',Class ='" + TextBox15.Text + "',FavoriteSubject='" + TextBox16.Text + "',Hobbies = '" + TextBox17.Text + "',AreaOfInterest = '" + TextBox18.Text + "',Achievement ='" + TextBox19.Text + "',Sports = '" + TextBox20.Text + "',Music= '" + TextBox21.Text + "',StoryBooks = '" + TextBox22.Text + "',Others = '" + TextBox23.Text + "'WHERE esaarum_id =" + TextBox3.Text + "";
                String newcomm = " update  Profile_Table set FirstName = '" + FirstnameTextBox1.Text + "' WHERE esaarum_id = '3'";
               //  String newcomm = " update Profile_Table set FirstName = '" + TextBox1.Text + "'WHERE esaarum_id =" + TextBox3.Text + "";
     

                SqlConnection newconn = new SqlConnection(newsrc);
                newconn.Open();
                SqlCommand newsqlcomm = new SqlCommand(newcomm, newconn);
                newsqlcomm.ExecuteScalar();
               // disable_funtion();
                profile_Load();

         }

        protected void Button2_Click(object sender, EventArgs e)
        {
            enable_funtion();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            enable_funtion();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            disable_funtion();
        }

        protected void enable_funtion()
        {
            FirstnameTextBox1.Enabled = true; //first name 
            TextBox2.Enabled = true; // last name 
            TextBox3.Enabled = false; // esaarum id 
            TextBox13.Enabled = true; //about me 

            DropDownList4.Enabled = true; // day 
            DropDownList5.Enabled = true;// month 
            DropDownList6.Enabled = true; // year 
            DropDownList2.Enabled = true; //gender 

            TextBox7.Enabled = true;  //add line 1
            TextBox8.Enabled = true;  // add line 2
            TextBox9.Enabled = true;  // area 
            DropDownList3.Enabled = true; // city 
            TextBox11.Enabled = true; // pin code 
            DropDownList1.Enabled = true;// state 
            TextBox14.Enabled = true; // name of school
            TextBox15.Enabled = true; // class 
            TextBox16.Enabled = true; // fav sub
            TextBox17.Enabled = true; // hobbies 
            TextBox18.Enabled = true; //area of interest 
            TextBox19.Enabled = true; // achivement 

            TextBox20.Enabled = true; //sport
            TextBox21.Enabled = true; //music 
            TextBox22.Enabled = true; // books  
            TextBox23.Enabled = true; // others 

            Button6.Enabled = true; // save 
            Button5.Enabled = true; // save 
            Button4.Enabled = true; // save
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            String newsrc = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\shakthydoss\\Documents\\Visual Studio 2008\\esaarum\\esaarum\\App_Data\\Database1.mdf;Integrated Security=True;User Instance=True";
            // String newcomm = " update Profile_Table set FirstName = '" + FirstnameTextBox1.Text + "',LastName ='" + TextBox2.Text + "',AboutMe ='" + TextBox1.Text + "',day ='" + DropDownList4.Text + "',month ='" + DropDownList5.Text + "',year ='" + DropDownList6.Text + "',Gender =' " + DropDownList2.Text + "',AddressLine1 ='" + TextBox7.Text + "',AddressLine2 = '" + TextBox8.Text + "',Street='" + TextBox9.Text + "',Area = '" + DropDownList3.Text + "',City = '" + TextBox11.Text + "',State ='" + DropDownList1.Text + "',NameOfSchool='" + TextBox14.Text + "',Class ='" + TextBox15.Text + "',FavoriteSubject='" + TextBox16.Text + "',Hobbies = '" + TextBox17.Text + "',AreaOfInterest = '" + TextBox18.Text + "',Achievement ='" + TextBox19.Text + "',Sports = '" + TextBox20.Text + "',Music= '" + TextBox21.Text + "',StoryBooks = '" + TextBox22.Text + "',Others = '" + TextBox23.Text + "'WHERE esaarum_id =" + TextBox3.Text + "";
            String newcomm = " update  Profile_Table set NameOfSchool = '" + TextBox14.Text + "' WHERE esaarum_id = '3'";
            //  String newcomm = " update Profile_Table set FirstName = '" + TextBox1.Text + "'WHERE esaarum_id =" + TextBox3.Text + "";


            SqlConnection newconn = new SqlConnection(newsrc);
            newconn.Open();
            SqlCommand newsqlcomm = new SqlCommand(newcomm, newconn);
            newsqlcomm.ExecuteScalar();
            // disable_funtion();
            profile_Load();

            disable_funtion();
        }

        
        
    }
}
