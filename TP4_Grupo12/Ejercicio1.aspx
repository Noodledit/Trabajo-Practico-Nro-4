<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP4_Grupo12.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 127px;
        }
        .auto-style3 {
            width: 239px;
        }
        .auto-style4 {
            width: 127px;
            height: 23px;
        }
        .auto-style6 {
            width: 239px;
            height: 23px;
        }
        .auto-style7 {
            height: 23px;
        }
        .auto-style8 {
            width: 122px;
            height: 23px;
            text-decoration: underline;
        }
        .auto-style9 {
            width: 122px;
        }
        .auto-style10 {
            width: 122px;
        }
        .auto-style11 {
            width: 122px;
        }
        .auto-style12 {
            width: 122px;
            height: 23px;
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width:100%;">
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style8">DESTINO INICIO</td>
                <td class="auto-style6"></td>
                <td class="auto-style7"></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style9">PROVINCIA:</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="ddlProvincia1" runat="server" AutoPostBack="True" Width="151px" OnSelectedIndexChanged="ddlProvincia1_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style9">
                    <asp:Label ID="lblLocalidad" runat="server" Text="LOCALIDAD:"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="ddlLocalidad1" runat="server" Width="151px">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style12">DESTINO FINAL</td>
                <td class="auto-style6"></td>
                <td class="auto-style7"></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style9">PROVINCIA:</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="ddlProvincia2" runat="server" Width="151px" AutoPostBack="True" OnSelectedIndexChanged="ddlProvincia2_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style9">LOCALIDAD:</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="ddlLocalidad2" runat="server" Height="16px" Width="151px">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
