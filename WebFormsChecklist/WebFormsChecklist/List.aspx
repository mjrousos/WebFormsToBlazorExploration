<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="WebFormsChecklist.List" %>

<%@ Register Src="~/MyControl.ascx" TagPrefix="uc1" TagName="MyControl" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1><%=PageTitle%></h1>
		<asp:datagrid
			id="dgTodoList"
			runat="server"
			Width="100%" AutoGenerateColumns="False"
			OnItemCommand="dgTodoList_ItemCommand">
			<HeaderStyle BackColor="Gray" ForeColor="white" Font-Bold="true" />
			<ItemStyle BackColor="white" />
			<AlternatingItemStyle BackColor="Beige" />
			<Columns>
				<asp:BoundColumn Visible="false" DataField="Id" />
				<asp:BoundColumn HeaderText="Description" DataField="Description" />
				<asp:BoundColumn HeaderText="Completed" DataField="CompletedTime" />
				<asp:ButtonColumn HeaderText="Complete" Text="Complete" ButtonType="PushButton" CommandName="Complete" />
			</Columns>
		</asp:datagrid>
        <br />
        Add new item <asp:TextBox ID="txtNewItem" runat="server"></asp:TextBox>
        <asp:Button ID="btnAddItem" runat="server" Text="Add" OnClick="AddItem" />
    </div>
	<div>
        <uc1:MyControl runat="server" id="MyControl" />
	</div>
</asp:Content>