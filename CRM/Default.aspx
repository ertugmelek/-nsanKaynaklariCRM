<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CRM.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:DropDownList ID="ddlMusteri" runat="server" OnSelectedIndexChanged="ddlMusteri_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
    <br />

    <asp:GridView ID="GrdListele" runat="server">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                <asp:LinkButton runat="server">Detay</asp:LinkButton>
                    </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField>
               <ItemTemplate>
                <asp:LinkButton runat="server">Sil</asp:LinkButton>
                    </ItemTemplate>
            </asp:TemplateField>


        </Columns>
        
    </asp:GridView>
    
    <asp:GridView ID="grdKurumsal" runat="server">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                <asp:LinkButton runat="server">Detay</asp:LinkButton>
                    </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField>
               <ItemTemplate>
                <asp:LinkButton runat="server">Sil</asp:LinkButton>
                    </ItemTemplate>
            </asp:TemplateField>


        </Columns>
        
    </asp:GridView>


</asp:Content>
