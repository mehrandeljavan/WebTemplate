<%@ Page Title="" Language="C#" MasterPageFile="..\MasterPages\MasterPage.master" AutoEventWireup="true" CodeFile="Z_UserDefault.aspx.cs" Inherits="WebForms_Z_UserDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
		<div>
			<h3>
				List of all the Users</h3>
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

				<asp:TemplateField HeaderText="NationalCode">
					<EditItemTemplate>
						<asp:Label ID="lblNationalCode" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("NationalCode") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelNationalCode" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("NationalCode") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Password">
					<EditItemTemplate>
						<asp:TextBox ID="txtPassword" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("Password") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelPassword" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("Password") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="LastPassChangeDate">
					<EditItemTemplate>
						<asp:TextBox ID="txtLastPassChangeDate" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("LastPassChangeDate") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelLastPassChangeDate" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("LastPassChangeDate") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="IsActiveUser">
					<EditItemTemplate>
						<asp:TextBox ID="txtIsActiveUser" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("IsActiveUser") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelIsActiveUser" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("IsActiveUser") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:HyperLinkField Text="Delete" DataNavigateUrlFields="NationalCode" DataNavigateUrlFormatString="Z_UserDelete.aspx?nationalCode={0}" />
			</Columns>
		</asp:GridView>

		&nbsp;&nbsp;&nbsp;
		<br />
		<br />
		<asp:Button ID="Button1" runat="server" Text="Add New User" OnClick="Button1_Click" CssClass="MyButton" /><br />
		<br />
		<asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
		</div>
</asp:Content>

