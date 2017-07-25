using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;


public partial class account : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string name = Session["UserName"].ToString();     //  获取当前用户名

        if (this.TextBox1.Text.Trim() == "" || this.TextBox2.Text.Trim() == "" || this.TextBox3.Text.Trim() == "")

            Label1.Text = "信息不允许为空!";
        else
        {
            if (this.TextBox1.Text.Trim() != Session["password"].ToString())
            {
                Label1.Text = "初始密码不正确！!";

            }
            else
            {
                if (this.TextBox2.Text.Trim() != this.TextBox3.Text.Trim())
                {
                    Label1.Text = "两次输入的修改密码不相同！!";
                }
                else
                {

                    string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/ymc/Desktop/WebSite1/App_Data/mydb.mdb";

                    OleDbConnection conn = new OleDbConnection(ConnectionString);

                    conn.Open();

                    string sql = "update tab_name set [Password] = '" + this.TextBox3.Text.Trim()+ "' where [Name] = '" + name + "'"; // 非常重要！！！Password 和 Name 都为系统用词，所以要方括号，不然报错

                    OleDbCommand comm = new OleDbCommand(sql, conn);

                    comm.ExecuteNonQuery(); // 上传语句
               
                    Label1.Text = "密码修改成功！";

                    conn.Close();

                    }
   
                }
            
            }
        }
    }