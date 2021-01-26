<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="esaarum.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <style>
        p {
padding: 0 0 1em;
}
.msg_list {
margin: 0px;
padding: 0px;
width: 383px;
}
.msg_head {
padding: 5px 10px;
cursor: pointer;
position: relative;
background-color:#FFCCCC;
margin:1px;
}
.msg_body {
padding: 5px 10px 15px;
background-color:#F4F4F8;
}
    </style>
    
    <script>
    <script type="text/javascript" src="jquery.js"></script>
<script type="text/javascript">
$(document).ready(function()
{
  //hide the all of the element with class msg_body
  $(".msg_body").hide();
  //toggle the componenet with class msg_body
  $(".msg_head").click(function()
  {
    $(this).next(".msg_body").slideToggle(600);
  });
});
</script>
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="msg_list">
<p class="msg_head">Header-1 </p>
<div class="msg_body">
orem ipsum dolor sit amet, consectetuer adipiscing elit orem ipsum dolor sit amet, consectetuer adipiscing elit
</div>
<p class="msg_head">Header-2</p>
<div class="msg_body">
orem ipsum dolor sit amet, consectetuer adipiscing elit orem ipsum dolor sit amet, consectetuer adipiscing elit
</div>
<p class="msg_head">Header-3</p>
<div class="msg_body">
orem ipsum dolor sit amet, consectetuer adipiscing elit orem ipsum dolor sit amet, consectetuer adipiscing elit
</div>
</div>
    </form>
</body>
</html>
