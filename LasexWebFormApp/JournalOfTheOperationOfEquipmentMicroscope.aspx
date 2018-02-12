<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeBehind="JournalOfTheOperationOfEquipmentMicroscope.aspx.cs" Inherits="LasexWebFormApp.JournalOfTheOperationOfEquipmentMicroscope" %>

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
                    <asp:TableCell ColumnSpan="2">
                        <asp:Label ID="Label15" runat="server" Text="Журнал эксплуатации оборудования (профилометр ZYGO NewView 700)"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label1" runat="server" Text="ФИО" ></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox1" runat="server" Width="500px"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label2" runat="server" Text="Телефон"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox2" runat="server" Width="500px"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label3" runat="server" Text="E-Mail"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox3" runat="server" Width="500px"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label4" runat="server" Text="Время, [dd.mm.yyyy hh:mm]"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox4" runat="server" Width="500px"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label5" runat="server" Text="Температура, °С"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox5" runat="server" Width="500px"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label6" runat="server" Text="Давление, [торр]"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox6" runat="server" Width="500px"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label7" runat="server" Text="Влажность, [%]"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox7" runat="server" Width="500px"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label8" runat="server" Text="Номер блока"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox8" runat="server" Width="500px"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                
                            
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label9" runat="server" Text="Решение о годности"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox9" runat="server" Width="500px"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
            
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label10" runat="server" Text="Решение о негодности"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox10" runat="server" Width="500px"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell ColumnSpan="2" HorizontalAlign="Center">
                        <asp:Button ID="Button1" runat="server" Text="Отправить" Width="500px" Height="50px" OnClick="Button1_OnClick"/>
                    </asp:TableCell>
                </asp:TableRow>
                
                <asp:TableRow>
                    <asp:TableCell ColumnSpan="2" HorizontalAlign="Center">
                        <asp:Button ID="Button2" runat="server" Text="Назад" Width="500px" Height="50px" OnClick="Button2_OnClick"/>
                    </asp:TableCell>
                </asp:TableRow>

            </asp:Table>
        </div>
    </form>
</body>
</html>
