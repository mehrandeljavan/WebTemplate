<%@ Page Title="" Language="C#" MasterPageFile="..\MasterPages\MasterPage.master" AutoEventWireup="true" CodeFile="Z_MainOfficeTypeDefault.aspx.cs" Inherits="WebForms_Z_MainOfficeTypeDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
		<div>
			<h3>
				List of all the MainOfficeTypes</h3>
			<br />
			<asp:GridView ID="GridView1" runat="server" CssClass="GridView" AutoGenerateColumns="False" AutoGenerateEditButton="True" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" >
			<FooterStyle CssClass="GridViewFooter" />
			<PagerStyle CssClass="GridViewPager" />
			<SelectedRowStyle CssClass="GridViewSelectedRow" />
			<HeaderStyle CssClass="GridViewHeader" />
			<EditRowStyle CssClass="GridViewEditRow" />
			<RowStyle CssClass="GridViewRow" />
			<AlternatingRowStyle CssClass="GridViewAlternatingRow" />
			<Columns>

				<asp:TemplateField HeaderText="MainOfficeTypeID">
					<EditItemTemplate>
						<asp:Label ID="lblMainOfficeTypeID" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("MainOfficeTypeID") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelMainOfficeTypeID" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("MainOfficeTypeID") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ContractualEmployeesNumber">
					<EditItemTemplate>
						<asp:Label ID="lblContractualEmployeesNumber" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("ContractualEmployeesNumber") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelContractualEmployeesNumber" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("ContractualEmployeesNumber") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Title">
					<EditItemTemplate>
						<asp:TextBox ID="txtTitle" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("Title") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelTitle" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("Title") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="TotalScore">
					<EditItemTemplate>
						<asp:TextBox ID="txtTotalScore" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("TotalScore") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelTotalScore" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("TotalScore") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="TotalScoreCat1">
					<EditItemTemplate>
						<asp:TextBox ID="txtTotalScoreCat1" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("TotalScoreCat1") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelTotalScoreCat1" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("TotalScoreCat1") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="TotalScoreCat2">
					<EditItemTemplate>
						<asp:TextBox ID="txtTotalScoreCat2" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("TotalScoreCat2") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelTotalScoreCat2" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("TotalScoreCat2") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:HyperLinkField Text="Delete" DataNavigateUrlFields="MainOfficeTypeID" DataNavigateUrlFormatString="Z_MainOfficeTypeDelete.aspx?mainOfficeTypeID={0}" />
			</Columns>
		</asp:GridView>

		&nbsp;&nbsp;&nbsp;
		<br />
		<br />
		<asp:Button ID="Button1" runat="server" Text="Add New MainOfficeType" OnClick="Button1_Click" CssClass="MyButton" /><br />
		<br />
		<asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
		</div>
</asp:Content>

