<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forgot_password.aspx.cs" Inherits="esaarum.forgot_password" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    
    
    <center><h1>forgot password</h1></center>
    <asp:Label ID="Label1" runat="server" Text="Step 1 :"></asp:Label>
    <asp:Label ID="Label2" runat="server" Text="Enter your Email ID"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Next" onclick="Button1_Click" />
    &nbsp;<asp:Button ID="Button2" runat="server" Text="Cancle" 
            onclick="Button2_Click" />
    &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" 
            runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter vaild Email ID" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Step 2 :" Visible="false"></asp:Label>
    <asp:Label ID="Label4" runat="server" Text="Label"  Visible="false"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server" Visible="false"></asp:TextBox>
        <asp:Button ID="Button3" runat="server" Text="Next"  Visible="false"
        onclick="Button3_Click" />
&nbsp;<asp:Button ID="Button4" runat="server" Text="Cancle" Visible="false" 
            onclick="Button4_Click" />
    <br />
        <asp:Label ID="Label7" runat="server" Text="Step 3 :" Visible="false"></asp:Label>
        <asp:Label ID="Label8" runat="server" Text="Enter new Password" Visible="false"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" Visible="false"></asp:TextBox>
        &nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToCompare="TextBox3" ControlToValidate="TextBox4" 
            ErrorMessage="New Password and Confirm new Password does not match."></asp:CompareValidator>
        <br />
        <asp:Label ID="Label9" runat="server" Text="Confirm new Password" Visible="false"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" Visible="false"></asp:TextBox>
        <asp:Button ID="Button5" runat="server" Text="Next"  
        onclick="Button5_Click" Visible="false"/>
&nbsp;<asp:Button ID="Button6" runat="server" Text="Cancle" Visible="false" 
        onclick="Button6_Click" />
        <br />
    <asp:Label ID="Label6" runat="server" Text="Label" Visible="false"></asp:Label>
    
        &nbsp;<asp:Button ID="Button7" runat="server" onclick="Button7_Click" Text="Enter" Visible="false" />
    
    </form>
</body>
</html>
