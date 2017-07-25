<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
           .p1{
            color:black;
            font-size:x-large;
            font-family:华文细黑;
            background-color:transparent;  

        }
        .p1:hover{
            color:deepskyblue;
        }
        .div {
            background-image: url('images/logo1.jpg'); 
            height: 115px;
            width: 1120px;
            margin:0 auto; 

        }
        .divfull {   
        background-image: url('images/xue.jpg'); 
        background-repeat: no-repeat; 
        height: 480px; 
        width: 820px;
        background-size: 100% 100%; 
        right:100px;
        margin-left:232px;
        margin-top:20px;
        }

    </style>
    </head>
<body style="background-image:url(/images/back1.jpg);">
    <form id="form1" runat="server" defaultbutton="Button3">
        
    <div  class="div">  
        
    </div>

        <div class="divfull">
        </div>

        <asp:Button ID="Button1" runat="server" BorderStyle="None" style="z-index: 1; left: 1176px; top: 190px; position: absolute; width: 109px; right: -40px;" Text="账号登录" CssClass="p1" Font-Names="华文细黑" Font-Size="X-Large" />

        <asp:Button ID="Button3" runat="server" style="z-index: 1; left: 1153px; top: 354px; position: absolute; width: 177px; height: 30px" Text="登录" BackColor="DeepSkyBlue" Font-Names="华文细黑" Font-Size="Large" ForeColor="White" BorderStyle="None" OnClick="Button3_Click" />

        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 1145px; top: 238px; position: absolute; width: 188px; height: 34px" Font-Names="华文细黑" Font-Size="Medium"  ></asp:TextBox>

        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 1145px; top: 272px; position: absolute; height: 34px; width: 188px" Font-Names="华文细黑" Font-Size="Medium" TextMode="Password" ></asp:TextBox>
        
        <asp:Label ID="Label2" runat="server" Font-Names="华文细黑" style="z-index: 1; left: 1102px; top: 283px; position: absolute; width: 50px; height: 20px; right: 191px;" Text="密码："></asp:Label>

        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 1085px; top: 249px; position: absolute; width: 65px; height: 20px; right: 188px;" Text="用户名：" Font-Names="华文细黑"></asp:Label>

        <asp:Label ID="Label3" runat="server" Font-Names="华文细黑" ForeColor="#DA2596" style="z-index: 1; left: 1150px; top: 322px; position: absolute; width: 187px"></asp:Label>     

    </form>
    </body>
</html>
