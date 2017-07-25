using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;   // dataset 


public partial class searchtext : System.Web.UI.Page
{
    string sqlall = "select id , Aauthor , Ayear , Amonth , Atitle from tab_article order by id desc; "; // 查询全部数据

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)  //只在第一次打开时加载数据 
        {
            bind(sqlall);

        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)    // 分页数据每次重新绑定
    {
        string sql1 = "select id , Aauthor , Ayear , Amonth , Atitle from tab_article where Aauthor='" + DropDownList1.Text + "'order by id desc; "; // 查询姓名 数据
        string sql2 = "select id , Aauthor , Ayear , Amonth , Atitle from tab_article where Ayear='" + DropDownList2.Text + "'order by id desc; "; // 查询年份 数据
        string sql3 = "select id , Aauthor , Ayear , Amonth , Atitle from tab_article where Amonth='" + DropDownList3.Text + "'order by id desc; "; // 查询年份 数据
        string sql4 = "select id , Aauthor , Ayear , Amonth , Atitle from tab_article where Aauthor='" + DropDownList1.Text + "'and Ayear = '" + DropDownList2.Text + "'order by id desc; "; // 查询姓名，年份 数据
        string sql5 = "select id , Aauthor , Ayear , Amonth , Atitle from tab_article where Aauthor='" + DropDownList1.Text + "'and Amonth = '" + DropDownList3.Text + "'order by id desc; "; // 查询姓名，月份 数据
        string sql6 = "select id , Aauthor , Ayear , Amonth , Atitle from tab_article where Ayear='" + DropDownList2.Text + "'and Amonth = '" + DropDownList3.Text + "'order by id desc; "; // 查询年份，月份 数据
        string sql7 = "select id , Aauthor , Ayear , Amonth , Atitle from tab_article where Aauthor='" + DropDownList1.Text + "'and Ayear='" + DropDownList2.Text + "'and Amonth = '" + DropDownList3.Text + "'order by id desc; "; // 查询姓名 ，年份，月份 数据
        if (DropDownList1.Text == "" && DropDownList2.Text == "" && DropDownList3.Text == "")  // 
        {
            GridView1.PageIndex = e.NewPageIndex;

            bind(sqlall);
        }

        else if (DropDownList2.Text.Trim() == "" && DropDownList3.Text.Trim() == "")  // 
        {
            GridView1.PageIndex = e.NewPageIndex;

            bind(sql1);
        }
        else if (DropDownList1.Text.Trim() == "" && DropDownList3.Text.Trim() == "")  // 
        {
            GridView1.PageIndex = e.NewPageIndex;

            bind(sql2);
        }
        else if (DropDownList1.Text.Trim() == "" && DropDownList2.Text.Trim() == "")  // 
        {
            GridView1.PageIndex = e.NewPageIndex;

            bind(sql3);
        }
        else if (DropDownList3.Text.Trim() == "")  // 
        {
            GridView1.PageIndex = e.NewPageIndex;

            bind(sql4);
        }
        else if (DropDownList2.Text.Trim() == "")  // 
        {
            GridView1.PageIndex = e.NewPageIndex;

            bind(sql5);
        }
        else if (DropDownList1.Text.Trim() == "")  // 
        {
            GridView1.PageIndex = e.NewPageIndex;

            bind(sql6);
        }
        else if (DropDownList1.Text.Trim().Length != 0 && DropDownList2.Text.Trim().Length != 0 && DropDownList3.Text.Trim().Length != 0)  // 
        {
            GridView1.PageIndex = e.NewPageIndex;

            bind(sql7);

        }
    }
   
  public void bind(string sql)   // 检索所有数据的函数
    {

         string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/WebSite1/App_Data/mydb.mdb";

        OleDbConnection conn = new OleDbConnection(ConnectionString);

        conn.Open();

        OleDbDataAdapter mydataadapter = new OleDbDataAdapter(sql, conn);

        DataSet mydataset = new DataSet();

        int numberofrow = mydataadapter.Fill(mydataset, "tab_article"); //读取数据的行数 其实没用到

        conn.Close();

        GridView1.DataSource = mydataset.Tables["tab_article"];

        GridView1.DataBind();

    }

    protected void Button1_Click(object sender, EventArgs e)  //点击查询按钮
    {
        string sql1 = "select id , Aauthor , Ayear , Amonth , Atitle from tab_article where Aauthor='" + DropDownList1.Text + "'order by id desc; "; // 查询姓名 数据
        string sql2 = "select id , Aauthor , Ayear , Amonth , Atitle from tab_article where Ayear='" + DropDownList2.Text + "'order by id desc; "; // 查询年份 数据
        string sql3 = "select id , Aauthor , Ayear , Amonth , Atitle from tab_article where Amonth='" + DropDownList3.Text + "'order by id desc; "; // 查询年份 数据
        string sql4 = "select id , Aauthor , Ayear , Amonth , Atitle from tab_article where Aauthor='" + DropDownList1.Text + "'and Ayear = '" + DropDownList2.Text + "'order by id desc; "; // 查询姓名，年份 数据
        string sql5 = "select id , Aauthor , Ayear , Amonth , Atitle from tab_article where Aauthor='" + DropDownList1.Text + "'and Amonth = '" + DropDownList3.Text + "'order by id desc; "; // 查询姓名，月份 数据
        string sql6 = "select id , Aauthor , Ayear , Amonth , Atitle from tab_article where Ayear='" + DropDownList2.Text + "'and Amonth = '" + DropDownList3.Text + "'order by id desc; "; // 查询年份，月份 数据
        string sql7 = "select id , Aauthor , Ayear , Amonth , Atitle from tab_article where Aauthor='" + DropDownList1.Text + "'and Ayear='" + DropDownList2.Text + "'and Amonth = '" + DropDownList3.Text + "'order by id desc; "; // 查询姓名 ，年份，月份 数据

        if (DropDownList1.Text == "" && DropDownList2.Text == "" && DropDownList3.Text == "")  // 
        {
            bind(sqlall);
        }      

        else if (DropDownList2.Text.Trim() == "" && DropDownList3.Text.Trim() == "")  // 
        {
            bind(sql1);
        }
        else if (DropDownList1.Text.Trim() == "" && DropDownList3.Text.Trim() == "")  // 
        {
            bind(sql2);
        }
        else if (DropDownList1.Text.Trim() == "" && DropDownList2.Text.Trim() == "")  // 
        {
            bind(sql3);
        }
        else if (DropDownList3.Text.Trim() == "")  // 
        {
            bind(sql4);
        }
        else if (DropDownList2.Text.Trim() == "")  // 
        {
            bind(sql5);
        }
        else if (DropDownList1.Text.Trim() == "")  // 
        {
            bind(sql6);
        }
        else if (DropDownList1.Text.Trim().Length != 0 && DropDownList2.Text.Trim().Length != 0 && DropDownList3.Text.Trim().Length != 0)  // 
        {
            bind(sql7);

        }
    }
  
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["id"] = GridView1.SelectedRow.Cells[0].Text;  //将选中行的第一列的数据放入session
        //    Response.Write(function.redirect("Default.aspx", "登录成功"));
          
        Response.Redirect("details.aspx");

    }
}