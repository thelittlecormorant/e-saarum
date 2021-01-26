<%@ Page Language="C#" AutoEventWireup="false" CodeBehind="signin.aspx.cs" Inherits="esaarum.signin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Sign in</title>
    <script type = "text/javascript" >

   function preventBack(){window.history.forward();}

    setTimeout("preventBack()", 0);

    window.onunload=function(){null};

</script>
</head>
<body>
    <form id="form1" runat="server" method = "post">
    <h1> signin page</h1>
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Enter Email ID"></asp:Label><asp:TextBox ID="TextBox1"
    
        runat="server"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
        ControlToValidate="TextBox1" ErrorMessage="RegularExpressionValidator" 
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ControlToValidate="TextBox1" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label><asp:TextBox ID="TextBox2"
        runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="TextBox2" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
    <br />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Sign in" style="height: 26px" />
    &nbsp;<asp:Button ID="Button2" runat="server" CausesValidation="False"  
        onclick="Button2_Click" Text="Sign up" PostBackUrl="~/signup.aspx" />
    <br />
    <a href="forgot_password.aspx">If password forgot?</a></form>
</body>
</html>
