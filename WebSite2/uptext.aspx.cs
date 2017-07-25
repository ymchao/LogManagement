using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class uptext : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        Label2.Text = Session["UserName"].ToString();
   
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DateTime dt = DateTime.Now;
        int year = dt.Year;
        int month = dt.Month;

        if (this.TextBox1.Text.Trim() == "" || this.TextBox2.Text.Trim() == "")
        {
            Response.Write("<script language='javascript'> alert('摘要或者正文不允许为空!'); history.back(); </script>");
        }
        else 
        {   
            string text1 = TextBox1.Text.Trim();

            string text3 = text1.Replace( "'", "''");

            string text2 = TextBox2.Text.Trim();

            string text4 = text2.Replace("'", "''");  // 防止输入的字符串中有单引号 导致sql 语句出错


            string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/ymc/Desktop/WebSite1/App_Data/mydb.mdb";

            OleDbConnection conn = new OleDbConnection(ConnectionString);

            conn.Open();

            string sql = "insert into tab_article(Atitle , Acontent , Aauthor , Adate , Ayear , Amonth) values ('"+text3+"','"+text4+"','"+Label2.Text.Trim()+"','"+Label1.Text.Trim()+"','"+year+"','"+month+"');"; 

            OleDbCommand comm = new OleDbCommand(sql, conn);

            comm.ExecuteNonQuery(); // 上传语句

            Response.Write("<script language='javascript'> alert('上传成功!'); history.back(); </script>");

            conn.Close();
        }








    }
}