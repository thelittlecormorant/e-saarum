<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="esaarum._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server" >
    
    
    <center><h1>signup page</h1></center>
    <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
    &nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
    ControlToValidate="TextBox1" ErrorMessage="User Name cant be empty"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
    <asp:TextBox ID="TextBox7" runat="server" TextMode="Password"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ControlToValidate="TextBox7" ErrorMessage="Password field  cant be empty"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Confirm Password"></asp:Label>
    <asp:TextBox ID="TextBox8" runat="server" TextMode="Password"></asp:TextBox>
    <asp:CompareValidator ID="CompareValidator1" runat="server" 
        ControlToCompare="TextBox7" ControlToValidate="TextBox8" 
        ErrorMessage="Password and confirm password does not mach "></asp:CompareValidator>
    <br />
    <asp:Label ID="Label4" runat="server" Text="E-mail"></asp:Label>
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
        ControlToValidate="TextBox4" ErrorMessage="Enter valid email id"></asp:RequiredFieldValidator>
    <asp:Label ID="Label7_for_esaarum_id" runat="server" 
        Text="Label7_for_esaarum_id_max value" Visible="False"></asp:Label>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
        ControlToValidate="TextBox4" ErrorMessage="Enter valid email id" 
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Security Question"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>What was your childhood nickname?</asp:ListItem>
        <asp:ListItem Value="Who was your childhood hero?"></asp:ListItem>
        <asp:ListItem>What is your pet&#39;s name?</asp:ListItem>
        <asp:ListItem>What is your favorite TV program?</asp:ListItem>
        <asp:ListItem Value="What is your favorite color?"></asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Label ID="Label6" runat="server" Text="Security Answer"></asp:Label>
    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
        ControlToValidate="TextBox6" ErrorMessage="Answer for the Security question"></asp:RequiredFieldValidator>
    <br />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Register now" />
    
    

    <br />
        <br />
    
    

    </form>
    &nbsp;
</body>
</html>
