<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestApp._Default" %>

<%@ Register Assembly="System.Web.Extensions, Version=1.0.61025.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI" TagPrefix="asp" %>
<%@ Register TagPrefix="Ajaxified" Assembly="Ajaxified" Namespace="Ajaxified" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Demo Application</title>
    <link href="SiteStyle.css" rel="stylesheet" type="text/css" />
    <script language="javascript" type="text/javascript">
        function clientShowing(sender) {

        }
        function clientShown(sender) {

        }
        function clientHiding(sender) {

        }
        function clientHidden(sender) {
            
        }
        function selectionChanged(sender) {
            //alert(sender._selectedTime);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div>
                    <asp:TextBox ID="TextBox2" runat="server" Text="">
                    </asp:TextBox>
                    <Ajaxified:TimePicker runat="server" TargetControlID="TextBox2" CssClass="timepicker"
                        HeaderCssClass="header" TitleCssClass="title" ItemCssClass="item" SelectedItemCssClass="selecteditem"
                        TabCssClass="tab" SelectedTabCssClass="selectedtab" CloseOnSelection="true" OnClientShowing="clientShowing"
                        OnClientShown="clientShown" OnClientHiding="clientHiding" OnClientHidden="clientHidden"
                        OnClientSelectionChanged="selectionChanged"></Ajaxified:TimePicker>
                    <br />
                    <br />
                    <br />
                    <asp:TextBox ID="TextBox1" runat="server" Text="">
                    </asp:TextBox>
                    <Ajaxified:TimePicker ID="TimePicker1" runat="server" TargetControlID="TextBox1" MinuteStep="15" CloseOnSelection="false">
                    </Ajaxified:TimePicker>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
