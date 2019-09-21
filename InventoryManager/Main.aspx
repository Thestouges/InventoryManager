<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="InventoryManager.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="tbSearch" runat="server"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="Search Item" OnClick="btnSearch_Click"/>
            <br/><br/>
            <asp:GridView ID="gvItems" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
