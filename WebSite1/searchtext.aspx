<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="searchtext.aspx.cs" Inherits="searchtext" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">

    <asp:Label ID="Label1" runat="server" Text="姓名："></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server" Height="30px" Width="128px" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Name" AppendDataBoundItems="True">
        <asp:ListItem Selected="True"></asp:ListItem>
    </asp:DropDownList>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT DISTINCT [Name] FROM [tab_name]"></asp:SqlDataSource>

    <asp:Label ID="Label2" runat="server" Text="年份："></asp:Label>
    <asp:DropDownList ID="DropDownList2" runat="server" Height="30px" Width="128px">
        <asp:ListItem></asp:ListItem>
        <asp:ListItem>2014</asp:ListItem>
        <asp:ListItem>2015</asp:ListItem>
        <asp:ListItem>2016</asp:ListItem>
        <asp:ListItem>2017</asp:ListItem>
        <asp:ListItem>2018</asp:ListItem>
    </asp:DropDownList>


    <asp:Label ID="Label3" runat="server" Text="月份："></asp:Label>
    <asp:DropDownList ID="DropDownList3" runat="server" Height="30px" Width="128px">
        <asp:ListItem></asp:ListItem>
        <asp:ListItem>1</asp:ListItem>
        <asp:ListItem>2</asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
        <asp:ListItem>4</asp:ListItem>
        <asp:ListItem>5</asp:ListItem>
        <asp:ListItem>6</asp:ListItem>
        <asp:ListItem>7</asp:ListItem>
        <asp:ListItem>8</asp:ListItem>
        <asp:ListItem>9</asp:ListItem>
        <asp:ListItem>10</asp:ListItem>
        <asp:ListItem>11</asp:ListItem>
        <asp:ListItem>12</asp:ListItem>
    </asp:DropDownList>
    <asp:Button ID="Button1" runat="server" Text="查询"  style = "margin-left: 28px" Height="38px" Width="118px" BackColor="#507CD1" BorderStyle="None" Font-Names="华文细黑" Font-Size="Large" ForeColor="White" OnClick="Button1_Click" />
    
    <asp:GridView ID="GridView1" runat="server" OnPageIndexChanging="GridView1_PageIndexChanging" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="246px" Width="925px" AllowPaging="True" Style="margin-top: 30px; margin-left: -8px" PageSize="15" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" >

        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField HeaderText="编号" DataField="id">

                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
            </asp:BoundField>

            <asp:BoundField DataField="Aauthor" HeaderText="姓名">
                <HeaderStyle Width="60px" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:BoundField>

            <asp:BoundField DataField="Ayear" HeaderText="年份">
                <HeaderStyle Width="45px" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:BoundField>
            <asp:BoundField DataField="Amonth" HeaderText="月份">
                <HeaderStyle Width="45px" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:BoundField>
            <asp:BoundField DataField="Atitle" HeaderText="摘要" >
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="650px" />
            </asp:BoundField>
            <asp:ButtonField ButtonType="Button" CommandName="Select" Text="详情">

            <ControlStyle BackColor="#507CD1" BorderStyle="None" ForeColor="White" />

            </asp:ButtonField>
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerSettings Mode="NumericFirstLast" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>


</asp:Content>

