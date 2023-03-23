<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <th colspan="2">GIẢI PTB2</th>
                </tr>

                <tr>
                    <td>Nhập hệ số A:
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Nhập hệ số B:
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Nhập hệ số C:
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <th colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="Giải ngay và luôn" OnClick="Button1_Click" />
                    </th>
                </tr>
            </table>
        </div>
    </form>
    <div id="ketqua" runat="server"></div>

</body>
</html>
