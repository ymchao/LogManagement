using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //TextBox1.Attributes.Add("value", "用户名");
        //TextBox1.Attributes.Add("onfocus", "if(this.value=='用户名'){this.type='text';this.value=''}");
        //TextBox1.Attributes.Add("onblur", "if(this.value==''){this.type='text';this.value='用户名'}");

       // TextBox2.Attributes.Add("value", "密码");
       // TextBox2.Attributes.Add("onfocus", "if(this.value=='密码'){this.type='password';this.value=''}");
       // TextBox2.Attributes.Add("onblur", "if(this.value==''){this.type='text';this.value='密码'}");
     //   Button2.ForeColor = System.Drawing.Color.Black;
    }


    protected void Button3_Click(object sender, EventArgs e)
    {
        if (this.TextBox1.Text.Trim() == "" || this.TextBox2.Text.Trim() == "")

            Label3.Text = "用户名或账户不允许为空!";
        else {
            string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/ymc/Desktop/WebSite1/App_Data/mydb.mdb";
            OleDbConnection conn = new OleDbConnection(ConnectionString);
            conn.Open();


            string sql = "select * from tab_name where Name='" + Request.Form["TextBox1"].ToString() + "' and Password='" + Request.Form["TextBox2"].ToString() + "'";
            OleDbCommand comm = new OleDbCommand(sql, conn);
            OleDbDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                Session["username"] = TextBox1.Text;
                Session["password"] = TextBox2.Text;

            //    Response.Write(function.redirect("Default.aspx", "登录成功"));
                Response.Redirect("searchtext.aspx");
           
            }
            else
            {
                Session["login"] = "no";
               // Response.Write(function.redirect("login.aspx", "帐号、密码不正确"));
                Label3.Text = "用户名或密码不正确";

            }
            reader.Close();
            conn.Close();
        }
    }
}