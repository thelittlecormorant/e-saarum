<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mypage.aspx.cs" Inherits="esaarum.Mypage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>My page</title>
</head>
<body>
    <form id="form1" runat="server" method="post"   >
    <div>
   <center> <h1>esaarum</h1></center>
    
    </div>
     <h4>General&nbsp;&nbsp;&nbsp;
         <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Edit" />
&nbsp;&nbsp;
         <asp:Button ID="Button6" runat="server" Text="Save" onclick="Button6_Click" />
        </h4>
        <asp:Label ID="Label1" runat="server" Text="First Name :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="FirstnameTextBox1" runat="server" 
            Width="244px" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="FirstnameTextBox1" ErrorMessage="Enter your Name"></asp:RequiredFieldValidator>
        <br />
        <br />
       
        <asp:Label ID="Label2" runat="server" Text="Last Name :"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Width="248px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="esaarum Id:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Width="245px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="About me : "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox13" runat="server" Height="88px" TextMode="MultiLine" 
            Width="245px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="D.O.B"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DropDownList4" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem Value="3"></asp:ListItem>
            <asp:ListItem Value="4"></asp:ListItem>
            <asp:ListItem Value="5"></asp:ListItem>
            <asp:ListItem Value="6"></asp:ListItem>
            <asp:ListItem Value="7"></asp:ListItem>
            <asp:ListItem Value="8"></asp:ListItem>
            <asp:ListItem Value="9"></asp:ListItem>
            <asp:ListItem Value="10"></asp:ListItem>
            <asp:ListItem Value="11"></asp:ListItem>
            <asp:ListItem Value="12"></asp:ListItem>
            <asp:ListItem Value="13"></asp:ListItem>
            <asp:ListItem Value="14"></asp:ListItem>
            <asp:ListItem Value="15"></asp:ListItem>
            <asp:ListItem>16</asp:ListItem>
            <asp:ListItem>17</asp:ListItem>
            <asp:ListItem>18</asp:ListItem>
            <asp:ListItem>19</asp:ListItem>
            <asp:ListItem Value="20">20</asp:ListItem>
            <asp:ListItem Value="21">21</asp:ListItem>
            <asp:ListItem Value="22">22</asp:ListItem>
            <asp:ListItem Value="23">23</asp:ListItem>
            <asp:ListItem Value="24">24</asp:ListItem>
            <asp:ListItem Value="25">25</asp:ListItem>
            <asp:ListItem Value="26"></asp:ListItem>
            <asp:ListItem Value="27"></asp:ListItem>
            <asp:ListItem Value="28"></asp:ListItem>
            <asp:ListItem Value="29"></asp:ListItem>
            <asp:ListItem Value="30"></asp:ListItem>
            <asp:ListItem Value="31"></asp:ListItem>
        </asp:DropDownList>
&nbsp;<asp:DropDownList ID="DropDownList5" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>06</asp:ListItem>
        </asp:DropDownList>
&nbsp;<asp:DropDownList ID="DropDownList6" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>1988</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Gender:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="DropDownList2" ErrorMessage="Select the Gender"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Address Line 1:"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Text="Adress Line 2:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Text="Area :"></asp:Label>
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label10" runat="server" Text="City : "></asp:Label>
        <asp:DropDownList ID="DropDownList3" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Chennai</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label11" runat="server" Text="Pin code : "></asp:Label>
        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label12" runat="server" Text="State : "></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" Height="16px">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Tamil Nadu</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <h4>Academics&nbsp;&nbsp;&nbsp;&nbsp;             <asp:Button ID="Button2" 
                runat="server" Text="Edit" onclick="Button2_Click" />
&nbsp;&nbsp;
            <asp:Button ID="Button5" runat="server" Text="Save" onclick="Button5_Click" />
        </h4>
        <asp:Label ID="Label13" runat="server" Text="Name of school:"></asp:Label>
        &nbsp;<asp:TextBox ID="TextBox14" runat="server" Width="261px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="TextBox14" ErrorMessage="Enter your School Name"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="Label14" runat="server" Text="Class "></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="TextBox15" runat="server" Width="186px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
            ControlToValidate="TextBox15" ErrorMessage="Enter your class "></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="Label15" runat="server" Text="Favorite subject:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label16" runat="server" Text="Hobbies:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label17" runat="server" Text="Area of interest: "></asp:Label>
        &nbsp;<asp:TextBox ID="TextBox18" runat="server" Width="181px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label18" runat="server" Text="Achievement:"></asp:Label>
        &nbsp;<asp:TextBox ID="TextBox19" runat="server" Height="46px" 
            TextMode="MultiLine" Width="203px"></asp:TextBox>
        <br />
    <br />
        <br />
        
        <h4>Non curriculum&nbsp;
            <asp:Button ID="Button3" runat="server" Text="Edit" onclick="Button3_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" Text="Save" onclick="Button4_Click" />
        </h4>
        <asp:Label ID="Label19" runat="server" Text="Sports:"></asp:Label>
        &nbsp;<asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label20" runat="server" Text="Music:"></asp:Label>
        &nbsp;<asp:TextBox ID="TextBox21" runat="server"></asp:TextBox>
        <br />
        <br />
    <asp:Label ID="Label21" runat="server" Text="Story books:"></asp:Label>
    &nbsp;<asp:TextBox ID="TextBox22" runat="server"></asp:TextBox>
        <br />
    <br />
    <asp:Label ID="Label22" runat="server" Text="Others:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="TextBox23" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
    </form>
</body>
</html>
