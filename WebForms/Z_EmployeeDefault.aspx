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
			<asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" AutoGenerateColumns="False" AutoGenerateEditButton="True" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" BorderColor="Silver" BorderStyle="Solid" BorderWidth="1px" Font-Names="BYekan">
			<FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
			<PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
			<SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
			<HeaderStyle BackColor="#9933CC" Font-Bold="True" ForeColor="White" />
			<EditRowStyle BackColor="#33b5e5" />
			<RowStyle BackColor="#EFF3FB" />
			<AlternatingRowStyle BackColor="White" />
			<Columns>

				<asp:TemplateField HeaderText="NationalCode">
					<EditItemTemplate>
						<asp:Label ID="lblNationalCode" runat="server" Text='<%# Eval("NationalCode") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelNationalCode" runat="server" Text='<%# Bind("NationalCode") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ContractTypeIDTitle">
					<EditItemTemplate>
						<asp:Label ID="lblContractTypeIDTitle" runat="server" Text='<%# Eval("ContractTypeIDTitle") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelContractTypeIDTitle" runat="server" Text='<%# Bind("ContractTypeIDTitle") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="RoleTypeIDTitle">
					<EditItemTemplate>
						<asp:Label ID="lblRoleTypeIDTitle" runat="server" Text='<%# Eval("RoleTypeIDTitle") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelRoleTypeIDTitle" runat="server" Text='<%# Bind("RoleTypeIDTitle") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="FullName">
					<EditItemTemplate>
						<asp:Label ID="lblFullName" runat="server" Text='<%# Eval("FullName") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelFullName" runat="server" Text='<%# Bind("FullName") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="DepartmentIDTitle">
					<EditItemTemplate>
						<asp:Label ID="lblDepartmentIDTitle" runat="server" Text='<%# Eval("DepartmentIDTitle") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelDepartmentIDTitle" runat="server" Text='<%# Bind("DepartmentIDTitle") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="RoleTypeIDFactor">
					<EditItemTemplate>
						<asp:Label ID="lblRoleTypeIDFactor" runat="server" Text='<%# Eval("RoleTypeIDFactor") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelRoleTypeIDFactor" runat="server" Text='<%# Bind("RoleTypeIDFactor") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="PersonalCode">
					<EditItemTemplate>
						<asp:TextBox ID="txtPersonalCode" runat="server" Text='<%# Eval("PersonalCode") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelPersonalCode" runat="server" Text='<%# Bind("PersonalCode") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="FirstName">
					<EditItemTemplate>
						<asp:TextBox ID="txtFirstName" runat="server" Text='<%# Eval("FirstName") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelFirstName" runat="server" Text='<%# Bind("FirstName") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="LastName">
					<EditItemTemplate>
						<asp:TextBox ID="txtLastName" runat="server" Text='<%# Eval("LastName") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelLastName" runat="server" Text='<%# Bind("LastName") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="AccountNumber">
					<EditItemTemplate>
						<asp:TextBox ID="txtAccountNumber" runat="server" Text='<%# Eval("AccountNumber") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelAccountNumber" runat="server" Text='<%# Bind("AccountNumber") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ContractTypeID">
					<EditItemTemplate>
						<asp:TextBox ID="txtContractTypeTitle" runat="server" Text='<%# Eval("ContractTypeID") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelContractTypeID" runat="server" Text='<%# Bind("ContractTypeID") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="RoleTypeID">
					<EditItemTemplate>
						<asp:TextBox ID="txtRoleTypeTitle" runat="server" Text='<%# Eval("RoleTypeID") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelRoleTypeID" runat="server" Text='<%# Bind("RoleTypeID") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="DepartmentID">
					<EditItemTemplate>
						<asp:TextBox ID="txtDepartmentTitle" runat="server" Text='<%# Eval("DepartmentID") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelDepartmentID" runat="server" Text='<%# Bind("DepartmentID") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="IsActiveEmployee">
					<EditItemTemplate>
						<asp:TextBox ID="txtIsActiveEmployee" runat="server" Text='<%# Eval("IsActiveEmployee") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelIsActiveEmployee" runat="server" Text='<%# Bind("IsActiveEmployee") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:HyperLinkField Text="Delete" DataNavigateUrlFields="NationalCode" DataNavigateUrlFormatString="Z_EmployeeDelete.aspx?nationalCode={0}" />
			</Columns>
		</asp:GridView>

		&nbsp;&nbsp;&nbsp;
		<br />
		<br />
		<asp:Button ID="Button1" runat="server" Text="Add New Employee" OnClick="Button1_Click" CssClass="MehButton" /><br />
		<br />
		<asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
		</div>
</asp:Content>

