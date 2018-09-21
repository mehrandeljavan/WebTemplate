<%@ Page Title="" Language="C#" MasterPageFile="..\MasterPages\MasterPage.master" AutoEventWireup="true" CodeFile="Z_EmployeeDefault.aspx.cs" Inherits="WebForms_Z_EmployeeDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
		<div>
			<h3>
				List of all the Employees</h3>
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

				<asp:TemplateField HeaderText="ContractTypeIDTitle">
					<EditItemTemplate>
						<asp:Label ID="lblContractTypeIDTitle" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("ContractTypeIDTitle") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelContractTypeIDTitle" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("ContractTypeIDTitle") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="RoleTypeIDTitle">
					<EditItemTemplate>
						<asp:Label ID="lblRoleTypeIDTitle" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("RoleTypeIDTitle") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelRoleTypeIDTitle" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("RoleTypeIDTitle") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="FullName">
					<EditItemTemplate>
						<asp:Label ID="lblFullName" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("FullName") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelFullName" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("FullName") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="DepartmentIDTitle">
					<EditItemTemplate>
						<asp:Label ID="lblDepartmentIDTitle" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("DepartmentIDTitle") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelDepartmentIDTitle" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("DepartmentIDTitle") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="RoleTypeIDFactor">
					<EditItemTemplate>
						<asp:Label ID="lblRoleTypeIDFactor" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("RoleTypeIDFactor") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelRoleTypeIDFactor" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("RoleTypeIDFactor") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="PersonalCode">
					<EditItemTemplate>
						<asp:TextBox ID="txtPersonalCode" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("PersonalCode") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelPersonalCode" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("PersonalCode") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="FirstName">
					<EditItemTemplate>
						<asp:TextBox ID="txtFirstName" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("FirstName") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelFirstName" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("FirstName") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="LastName">
					<EditItemTemplate>
						<asp:TextBox ID="txtLastName" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("LastName") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelLastName" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("LastName") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="AccountNumber">
					<EditItemTemplate>
						<asp:TextBox ID="txtAccountNumber" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("AccountNumber") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelAccountNumber" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("AccountNumber") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ContractTypeID">
					<EditItemTemplate>
						<asp:TextBox ID="txtContractTypeTitle" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("ContractTypeID") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelContractTypeID" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("ContractTypeID") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="RoleTypeID">
					<EditItemTemplate>
						<asp:TextBox ID="txtRoleTypeTitle" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("RoleTypeID") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelRoleTypeID" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("RoleTypeID") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="DepartmentID">
					<EditItemTemplate>
						<asp:TextBox ID="txtDepartmentTitle" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("DepartmentID") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelDepartmentID" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("DepartmentID") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="IsActiveEmployee">
					<EditItemTemplate>
						<asp:TextBox ID="txtIsActiveEmployee" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("IsActiveEmployee") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelIsActiveEmployee" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("IsActiveEmployee") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:HyperLinkField Text="Delete" DataNavigateUrlFields="NationalCode" DataNavigateUrlFormatString="Z_EmployeeDelete.aspx?nationalCode={0}" />
			</Columns>
		</asp:GridView>

		&nbsp;&nbsp;&nbsp;
		<br />
		<br />
		<asp:Button ID="Button1" runat="server" Text="Add New Employee" OnClick="Button1_Click" CssClass="MyButton" /><br />
		<br />
		<asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
		</div>
</asp:Content>

