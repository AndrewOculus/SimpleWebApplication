<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="LasexWebFormApp.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table ID="Table1" runat="server" Width="889px" Height="594px">
            <asp:TableRow> 
                <asp:TableCell>
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow> 
                <asp:TableCell>
                    <asp:Label ID="Label15" runat="server" Text="Выберете нужную форму"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button ID="Button1" runat="server" Text="Журнал эксплуатации оборудования (станок полировальный ПСП-2Ш ТУ28.49.11-001-50850821-2017)" Width="900px" Height="50px" OnClick="Button1_OnClick"/>
                </asp:TableCell>
            </asp:TableRow>
            
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button ID="Button2" runat="server" Text="Журнал эксплуатации оборудования (станок полировально-доводочный 3ПД-350)" Width="900px" Height="50px" OnClick="Button2_OnClick"/>
                </asp:TableCell>
            </asp:TableRow>
            
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button ID="Button3" runat="server" Text="Журнал эксплуатации оборудования (интерферометр OptoTL-250 ЕТВС.58901205)" Width="900px" Height="50px" OnClick="Button3_OnClick"/>
                </asp:TableCell>
            </asp:TableRow>
            
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button ID="Button4" runat="server" Text="Журнал эксплуатации оборудования (профилометр ZYGO NewView 700)" Width="900px" Height="50px" OnClick="Button4_OnClick"/>
                </asp:TableCell>
            </asp:TableRow>
            
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button ID="Button5" runat="server" Text="Журнал эксплуатации оборудования (микроскоп STEMI 508)" Width="900px" Height="50px" OnClick="Button5_OnClick"/>
                </asp:TableCell>
            </asp:TableRow>
            
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button ID="Button6" runat="server" Text="Выйти" Width="50px" Height="50px" OnClick="Button6_OnClick"/>
                </asp:TableCell>
            </asp:TableRow>
            </asp:Table>

        </div>
    </form>
</body>
</html>
