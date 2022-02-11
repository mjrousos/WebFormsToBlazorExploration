<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MyControl.ascx.cs" Inherits="WebFormsChecklist.MyControl" %>
<h2>Custom user control</h2>
<asp:Label ID="Label1" runat="server" Text="Check boxes"></asp:Label>
<asp:CheckBoxList ID="chkList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
    <asp:ListItem Value="1">Check box item 1</asp:ListItem>
    <asp:ListItem Value="2">Check box item 2</asp:ListItem>
    <asp:ListItem Enabled="false" Value="3">Check box item 3</asp:ListItem>
</asp:CheckBoxList>
<br />
<asp:Literal ID="Literal1" runat="server" Text="Selected items"></asp:Literal>
<asp:ListBox ID="lstList" runat="server"></asp:ListBox>
<br />
<div>
    <asp:DropDownList ID="drpList" AutoPostBack="true" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        <asp:ListItem Selected="True" Value="A">A</asp:ListItem>
        <asp:ListItem Value="B">B</asp:ListItem>
    </asp:DropDownList>
    <asp:Table ID="Table1" runat="server" GridLines="Both" CellPadding="3" BackColor="Wheat">
        <asp:TableRow>
            <asp:TableCell Width="200">Dropbox item selected</asp:TableCell>
            <asp:TableCell ID="cellResult" Width="50" HorizontalAlign="Center">A</asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</div>