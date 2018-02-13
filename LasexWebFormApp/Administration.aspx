<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeBehind="Administration.aspx.cs" Inherits="LasexWebFormApp.Administration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            
            <asp:Label ID="Label1" runat="server" Text="Login"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Width="50px"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Width="50px"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Permission"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" Width="50px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_OnClick" />


            <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="Login" HeaderText="Login" SortExpression="Login" />
                    <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
                    <asp:BoundField DataField="Permission" HeaderText="Permission" SortExpression="Permission" />
                </Columns>
            </asp:GridView>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:DBConnection %>" DeleteCommand="DELETE FROM [Users] WHERE [Id] = @original_Id AND (([Login] = @original_Login) OR ([Login] IS NULL AND @original_Login IS NULL)) AND (([Password] = @original_Password) OR ([Password] IS NULL AND @original_Password IS NULL)) AND (([Permission] = @original_Permission) OR ([Permission] IS NULL AND @original_Permission IS NULL))" InsertCommand="INSERT INTO [Users] ([Login], [Password], [Permission]) VALUES (@Login, @Password, @Permission)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Users]" UpdateCommand="UPDATE [Users] SET [Login] = @Login, [Password] = @Password, [Permission] = @Permission WHERE [Id] = @original_Id AND (([Login] = @original_Login) OR ([Login] IS NULL AND @original_Login IS NULL)) AND (([Password] = @original_Password) OR ([Password] IS NULL AND @original_Password IS NULL)) AND (([Permission] = @original_Permission) OR ([Permission] IS NULL AND @original_Permission IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="original_Id" Type="Int32" />
                <asp:Parameter Name="original_Login" Type="String" />
                <asp:Parameter Name="original_Password" Type="String" />
                <asp:Parameter Name="original_Permission" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Login" Type="String" />
                <asp:Parameter Name="Password" Type="String" />
                <asp:Parameter Name="Permission" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Login" Type="String" />
                <asp:Parameter Name="Password" Type="String" />
                <asp:Parameter Name="Permission" Type="String" />
                <asp:Parameter Name="original_Id" Type="Int32" />
                <asp:Parameter Name="original_Login" Type="String" />
                <asp:Parameter Name="original_Password" Type="String" />
                <asp:Parameter Name="original_Permission" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        
        <asp:Button ID="Button2" runat="server" Text="Back" OnClick="Button2_OnClick" />
    </form>
</body>
</html>
