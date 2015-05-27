<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ListViewExample._Default" %>

<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI.WebControls" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="ListViewStyle.css" rel="stylesheet" type="text/css" />
    <title>Example: Binding a custom object to an ASP-ListView</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListView ID="flightListView" runat="server">
            <LayoutTemplate>
                <table>
                    <tr>
                        <th>Flight Number</th>
                        <th>Departure</th>
                        <th>Destination</th>
                        <th>Delay Time</th>
                    </tr>
                    <tr runat="server" id="itemPlaceholder" />
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("flightNumber") %></td>
                    <td><%# Eval("departure") %></td>
                    <td><%# Eval("destination") %></td>
                    <td><%# Eval("delayTime") %></td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
    </form>

</body>
</html>
