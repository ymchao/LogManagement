<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="uptext.aspx.cs" Inherits="uptext" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

    
        <table style="border: thin solid #507CD1; z-index: -1; left: 240px; top: 180px; position: absolute; height: 300px; font-family: 华文细黑; font-size: medium; color: #507CD1; width: 712px;">
            <tr>
                <td colspan="2" class="auto-style12">日志上传</td>
            </tr>
            <tr>
                <td class="auto-style18">用户:</td>
                <td class="auto-style14">
                    <asp:Label ID="Label2" runat="server" CssClass="text"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style19">时间:</td>
                <td class="auto-style9">
                    <asp:Label ID="Label1" runat="server" CssClass="text"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style20">摘要:</td>
                <td class="auto-style17">
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="zhaiyao" BorderStyle="None" TextMode="MultiLine" TabIndex="1" BackColor="White"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style21">正文:</td>
                <td class="auto-style11">
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="zhaiyao" BorderStyle="None" TextMode="MultiLine" TabIndex="1" BackColor="White"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style15" colspan="2">
                    <asp:Button ID="Button1" runat="server" BackColor="#507CD1" BorderStyle="None" Font-Names="华文细黑" Font-Size="Large"  Height="34px" Text="上传" Width="96px" OnClick="Button1_Click" TabIndex="1" />
                </td>
            </tr>
        </table>




</asp:Content>

