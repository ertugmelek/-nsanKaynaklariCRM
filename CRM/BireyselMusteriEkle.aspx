<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="BireyselMusteriEkle.aspx.cs" Inherits="CRM.BireyselMusteriEkle" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  
    <style type="text/css">
        .auto-style1 {
            width: 114px;
        }
        .auto-style2 {
            width: 114px;
            height: 20px;
        }
        .auto-style3 {
            height: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <%--<ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" PopupPosition="Right" TargetControlID="txtDogumTarihi"></ajaxToolkit:CalendarExtender>--%>
    <div> <h1>Bireysel Müşteri Kaydet</h1></div>
    <table class="nav-justified">
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Ad:</td>
            <td>
                <asp:TextBox ID="txtAd" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Soyad:</td>
            <td>
                <asp:TextBox ID="txtSoyad" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">TC:</td>
            <td>
                <asp:TextBox ID="txtTC" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Doğum Tarihi:</td>
            <td>
                <asp:TextBox ID="txtDogumTarihi" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Unvan:</td>
            <td>
                <asp:DropDownList ID="ddlUnvan" runat="server" Height="59px" Width="127px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Tel:</td>
            <td>
                <asp:TextBox ID="txtTel" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Email:</td>
            <td>
                <asp:TextBox ID="txtMail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Adres:</td>
            <td>
                <asp:TextBox ID="txtAdres" runat="server" Height="43px" TextMode="MultiLine" Width="174px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">İlçe:</td>
            <td>
                <asp:TextBox ID="txtIlce" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">İl:</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtIl" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" Width="124px" OnClick="btnKaydet_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
