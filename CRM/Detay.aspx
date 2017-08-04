<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Detay.aspx.cs" Inherits="CRM.Detay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 114px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table class="nav-justified">
        <tr>
            <td class="auto-style1">Ad:</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Soyad:</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">TC:</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Doğum Tarihi:</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>


    <div>
        <div style="width:100px">
            <asp:ListBox ID="lstAdres" runat="server" Height="110px" Width="83px"></asp:ListBox>
            <br />
            <br />
            <asp:Button ID="btnGuncelle" runat="server" Text="Button" OnClick="btnGuncelle_Click" />
        </div>



    </div>




</asp:Content>
