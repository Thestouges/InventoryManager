<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="InventoryManager.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.6.9/angular.min.js"></script>

    <script src="SearchApp.js"></script>
    <script src="SearchCtrl.js"></script>
    <style>
        input.ng-invalid {
            background-color: lightblue;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:HiddenField ID="SearchTerm" runat="server"/>
        <div ng-app="searchapp" ng-controller="searchcontroller">
            <asp:TextBox ID="tbSearch" runat="server" ng-model="SearchItem" required></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="Search Item" OnClick="btnSearch_Click"/>
            <p>{{SearchString}} <%=SearchTerm.Value%></p>
            <br/>
            <asp:GridView ID="gvItems" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
