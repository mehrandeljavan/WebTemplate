<%@ Page Title="" Language="C#" MasterPageFile="..\MasterPages\MasterPage.master" AutoEventWireup="true" CodeFile="Z_EmployeeUserTypeDefault.aspx.cs" Inherits="WebForms_Z_EmployeeUserTypeDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
		<div>
			<h3>
				List of all the EmployeeUserTypes</h3>
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

				<asp:TemplateField HeaderText="UserTypeID">
					<EditItemTemplate>
						<asp:Label ID="lblUserTypeID" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("UserTypeID") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelUserTypeID" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("UserTypeID") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="NationalCode">
					<EditItemTemplate>
						<asp:Label ID="lblNationalCode" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("NationalCode") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelNationalCode" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("NationalCode") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="EmployeeFullName">
					<EditItemTemplate>
						<asp:Label ID="lblEmployeeFullName" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("EmployeeFullName") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelEmployeeFullName" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("EmployeeFullName") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="UserTypeIDTitle">
					<EditItemTemplate>
						<asp:Label ID="lblUserTypeIDTitle" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("UserTypeIDTitle") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelUserTypeIDTitle" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("UserTypeIDTitle") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:HyperLinkField Text="Delete" DataNavigateUrlFields="UserTypeID, NationalCode" DataNavigateUrlFormatString="Z_EmployeeUserTypeDelete.aspx?userTypeID={0}&nationalCode={1}" />
			</Columns>
		</asp:GridView>

		&nbsp;&nbsp;&nbsp;
		<br />
		<br />
		<asp:Button ID="Button1" runat="server" Text="Add New EmployeeUserType" OnClick="Button1_Click" CssClass="MyButton" /><br />
		<br />
		<asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
		</div>
</asp:Content>

