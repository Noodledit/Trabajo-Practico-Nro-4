<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="TP4_Grupo12.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 0px;
        }
        .auto-style2 {
            font-weight: 700;
        }
        .auto-style3 {
            height: 23px;
            width: 126px;
        }
        .auto-style4 {
            width: 126px;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style6 {
            font-weight: 700;
            width: 200px;
        }
        .auto-style7 {
            height: 23px;
            width: 200px;
        }
        .auto-style8 {
        }
        .auto-style10 {
            width: 200px;
        }
    </style>
</head>
<body style="height: 550px">
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server" Height="270px">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style3">Seleccionar Tema:</td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="ddlTema" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:LinkButton ID="btnVerLibros" runat="server">Ver libros</asp:LinkButton>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" Height="270px">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style6">Listado de libros:</td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style8" colspan="2">
                        <asp:GridView ID="GridView1" runat="server">
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8" colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5" colspan="2"></td>
                </tr>
                <tr>
                    <td class="auto-style10">
                        <asp:LinkButton ID="btnConsultar" runat="server">Consultar otro tema</asp:LinkButton>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
    </form>
</body>
</html>
