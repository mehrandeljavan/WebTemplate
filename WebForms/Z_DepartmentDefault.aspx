<%@ Page Title="" Language="C#" MasterPageFile="..\MasterPages\MasterPage.master" AutoEventWireup="true" CodeFile="Z_DepartmentDefault.aspx.cs" Inherits="WebForms_Z_DepartmentDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
		<div>
			<h3>
				List of all the Departments</h3>
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

				<asp:TemplateField HeaderText="DepartmentID">
					<EditItemTemplate>
						<asp:Label ID="lblDepartmentID" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("DepartmentID") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelDepartmentID" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("DepartmentID") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="DividerFullName">
					<EditItemTemplate>
						<asp:Label ID="lblDividerFullName" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("DividerFullName") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelDividerFullName" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("DividerFullName") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ComputationTypeIDTitle">
					<EditItemTemplate>
						<asp:Label ID="lblComputationTypeIDTitle" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("ComputationTypeIDTitle") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelComputationTypeIDTitle" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("ComputationTypeIDTitle") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="MainOfficeTypeIDTitle">
					<EditItemTemplate>
						<asp:Label ID="lblMainOfficeTypeIDTitle" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("MainOfficeTypeIDTitle") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelMainOfficeTypeIDTitle" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("MainOfficeTypeIDTitle") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="AdjutancyTypeIDTitle">
					<EditItemTemplate>
						<asp:Label ID="lblAdjutancyTypeIDTitle" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("AdjutancyTypeIDTitle") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelAdjutancyTypeIDTitle" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("AdjutancyTypeIDTitle") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ComputationTypeID">
					<EditItemTemplate>
						<asp:TextBox ID="txtComputationTypeTitle" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("ComputationTypeID") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelComputationTypeID" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("ComputationTypeID") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="MainOfficeTypeID">
					<EditItemTemplate>
						<asp:TextBox ID="txtMainOfficeTypeTitle" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("MainOfficeTypeID") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelMainOfficeTypeID" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("MainOfficeTypeID") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="AdjutancyTypeID">
					<EditItemTemplate>
						<asp:TextBox ID="txtAdjutancyTypeTitle" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("AdjutancyTypeID") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelAdjutancyTypeID" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("AdjutancyTypeID") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="TotalEmployeeNumber">
					<EditItemTemplate>
						<asp:TextBox ID="txtTotalEmployeeNumber" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("TotalEmployeeNumber") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelTotalEmployeeNumber" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("TotalEmployeeNumber") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="TotalContractualEmployeeNumber">
					<EditItemTemplate>
						<asp:TextBox ID="txtTotalContractualEmployeeNumber" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("TotalContractualEmployeeNumber") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelTotalContractualEmployeeNumber" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("TotalContractualEmployeeNumber") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="TotalPersonalScore">
					<EditItemTemplate>
						<asp:TextBox ID="txtTotalPersonalScore" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("TotalPersonalScore") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelTotalPersonalScore" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("TotalPersonalScore") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="DividerNationalCode">
					<EditItemTemplate>
						<asp:TextBox ID="txtDividerNationalCode" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("DividerNationalCode") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelDividerNationalCode" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("DividerNationalCode") %>'></asp:Label>
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

				<asp:HyperLinkField Text="Delete" DataNavigateUrlFields="DepartmentID" DataNavigateUrlFormatString="Z_DepartmentDelete.aspx?departmentID={0}" />
			</Columns>
		</asp:GridView>

		&nbsp;&nbsp;&nbsp;
		<br />
		<br />
		<asp:Button ID="Button1" runat="server" Text="Add New Department" OnClick="Button1_Click" CssClass="MyButton" /><br />
		<br />
		<asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
		</div>
</asp:Content>

