using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;   // dataset 


public partial class details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Session["id"].ToString();  //将传递的值收入
 
        DataSet ds = new DataSet();
        OleDbCommand comm = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        //access数据库连接字符串，自行更改数据库路径和名字
        string ConnectionStr ="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/ymc/Desktop/WebSite1/App_Data/mydb.mdb";
        OleDbConnection conn = new OleDbConnection(ConnectionStr);
        conn.Open();
        comm.Connection = conn;
        comm.CommandType = CommandType.Text;
        comm.CommandText ="select  Aauthor ,Adate , Atitle , Acontent from tab_article where id ="+id+" "; // 用id查询数据
        da.SelectCommand = comm;
        da.Fill(ds);

        Label2.Text = ds.Tables[0].Rows[0][0].ToString();//显示第一行第一列的一个值  
        Label1.Text = ds.Tables[0].Rows[0][1].ToString();
        TextBox1.Text = ds.Tables[0].Rows[0][2].ToString();
        TextBox2.Text = ds.Tables[0].Rows[0][3].ToString();
        conn.Close();
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("searchtext.aspx");

    }
}