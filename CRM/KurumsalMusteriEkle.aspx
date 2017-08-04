<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="KurumsalMusteriEkle.aspx.cs" Inherits="CRM.KurumsalMusteriEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 125px;
        }
        .auto-style2 {
            width: 125px;
            height: 37px;
        }
        .auto-style3 {
            height: 37px;
        }
        .auto-style4 {
            width: 125px;
            height: 24px;
        }
        .auto-style5 {
            height: 24px;
        }
        .auto-style6 {
            width: 125px;
            height: 30px;
        }
        .auto-style7 {
            height: 30px;
        }
        .auto-style8 {
            width: 125px;
            height: 47px;
        }
        .auto-style9 {
            height: 47px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="nav-justified">
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Mersis No:</td>
            <td>
                <asp:TextBox ID="txtMersis" runat="server" Width="160px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">Unvanı:</td>
            <td class="auto-style9">
                <asp:TextBox ID="txtUnvan" runat="server" Height="30px" TextMode="MultiLine" Width="160px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Faaliyet Alanı:</td>
            <td class="auto-style3">
                <asp:DropDownList ID="ddlFaaliyetAlani" runat="server" Height="76px" Width="165px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Tel:</td>
            <td class="auto-style7">
                <asp:TextBox ID="txtTel" runat="server" Width="160px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Email:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtMail" runat="server" Width="160px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Adres:</td>
            <td>
                <asp:TextBox ID="txtAdres" runat="server" Height="68px" TextMode="MultiLine" Width="160px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">İlçe:</td>
            <td>
                <asp:TextBox ID="txtIlce" runat="server" Width="156px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">İl:</td>
            <td>
                <asp:TextBox ID="txtIl" runat="server" Width="155px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" Width="163px" OnClick="btnKaydet_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
