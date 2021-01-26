<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Testpage.aspx.cs" Inherits="esaarum.Testpage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server">
        <Columns>
           <asp:TemplateField>
            <ItemTemplate>
            <asp:Image ID="Image1" runat="server" ImageUrl='<%# "Handler.ashx?id=" + Eval("Img_Id")  %>' />
            </ItemTemplate>
           </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Image ID="Image1" runat="server" ImageUrl="YourImageFilePath" />
    
    <p>
        &nbsp;</p>
    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Button" />
    <br />
    <br />
    <asp:ListBox ID="ListBox1" runat="server" Height="337px" Rows="6" Width="362px">
    </asp:ListBox>
    
    &nbsp;
    <asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="Button" />
    <br />
    <br />
    <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Button" />
    
    </form>
</body>
</html>
