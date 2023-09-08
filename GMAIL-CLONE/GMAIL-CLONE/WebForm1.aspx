<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="GMAIL_CLONE.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="cId" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="cId" HeaderText="cId" ReadOnly="True" SortExpression="cId" />
                    <asp:BoundField DataField="myid" HeaderText="myid" SortExpression="myid" />
                    <asp:BoundField DataField="toid" HeaderText="toid" SortExpression="toid" />
                    <asp:BoundField DataField="myimgurl" HeaderText="myimgurl" SortExpression="myimgurl" />
                    <asp:BoundField DataField="toimgurl" HeaderText="toimgurl" SortExpression="toimgurl" />
                    <asp:BoundField DataField="myname" HeaderText="myname" SortExpression="myname" />
                    <asp:BoundField DataField="toname" HeaderText="toname" SortExpression="toname" />
                    <asp:BoundField DataField="msg" HeaderText="msg" SortExpression="msg" />
                    <asp:BoundField DataField="dt" HeaderText="dt" SortExpression="dt" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [chat]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
