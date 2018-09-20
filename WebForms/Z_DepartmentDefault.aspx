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
			<asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" AutoGenerateColumns="False" AutoGenerateEditButton="True" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" BorderColor="Silver" BorderStyle="Solid" BorderWidth="1px" Font-Names="BYekan">
			<FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
			<PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
			<SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
			<HeaderStyle BackColor="#9933CC" Font-Bold="True" ForeColor="White" />
			<EditRowStyle BackColor="#33b5e5" />
			<RowStyle BackColor="#EFF3FB" />
			<AlternatingRowStyle BackColor="White" />
			<Columns>

				<asp:TemplateField HeaderText="DepartmentID">
					<EditItemTemplate>
						<asp:Label ID="lblDepartmentID" runat="server" Text='<%# Eval("DepartmentID") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelDepartmentID" runat="server" Text='<%# Bind("DepartmentID") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="DividerFullName">
					<EditItemTemplate>
						<asp:Label ID="lblDividerFullName" runat="server" Text='<%# Eval("DividerFullName") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelDividerFullName" runat="server" Text='<%# Bind("DividerFullName") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ComputationTypeIDTitle">
					<EditItemTemplate>
						<asp:Label ID="lblComputationTypeIDTitle" runat="server" Text='<%# Eval("ComputationTypeIDTitle") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelComputationTypeIDTitle" runat="server" Text='<%# Bind("ComputationTypeIDTitle") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="MainOfficeTypeIDTitle">
					<EditItemTemplate>
						<asp:Label ID="lblMainOfficeTypeIDTitle" runat="server" Text='<%# Eval("MainOfficeTypeIDTitle") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelMainOfficeTypeIDTitle" runat="server" Text='<%# Bind("MainOfficeTypeIDTitle") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="AdjutancyTypeIDTitle">
					<EditItemTemplate>
						<asp:Label ID="lblAdjutancyTypeIDTitle" runat="server" Text='<%# Eval("AdjutancyTypeIDTitle") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelAdjutancyTypeIDTitle" runat="server" Text='<%# Bind("AdjutancyTypeIDTitle") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ComputationTypeID">
					<EditItemTemplate>
						<asp:TextBox ID="txtComputationTypeTitle" runat="server" Text='<%# Eval("ComputationTypeID") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelComputationTypeID" runat="server" Text='<%# Bind("ComputationTypeID") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="MainOfficeTypeID">
					<EditItemTemplate>
						<asp:TextBox ID="txtMainOfficeTypeTitle" runat="server" Text='<%# Eval("MainOfficeTypeID") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelMainOfficeTypeID" runat="server" Text='<%# Bind("MainOfficeTypeID") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="AdjutancyTypeID">
					<EditItemTemplate>
						<asp:TextBox ID="txtAdjutancyTypeTitle" runat="server" Text='<%# Eval("AdjutancyTypeID") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelAdjutancyTypeID" runat="server" Text='<%# Bind("AdjutancyTypeID") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="TotalEmployeeNumber">
					<EditItemTemplate>
						<asp:TextBox ID="txtTotalEmployeeNumber" runat="server" Text='<%# Eval("TotalEmployeeNumber") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelTotalEmployeeNumber" runat="server" Text='<%# Bind("TotalEmployeeNumber") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="TotalContractualEmployeeNumber">
					<EditItemTemplate>
						<asp:TextBox ID="txtTotalContractualEmployeeNumber" runat="server" Text='<%# Eval("TotalContractualEmployeeNumber") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelTotalContractualEmployeeNumber" runat="server" Text='<%# Bind("TotalContractualEmployeeNumber") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="TotalPersonalScore">
					<EditItemTemplate>
						<asp:TextBox ID="txtTotalPersonalScore" runat="server" Text='<%# Eval("TotalPersonalScore") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelTotalPersonalScore" runat="server" Text='<%# Bind("TotalPersonalScore") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="DividerNationalCode">
					<EditItemTemplate>
						<asp:TextBox ID="txtDividerNationalCode" runat="server" Text='<%# Eval("DividerNationalCode") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelDividerNationalCode" runat="server" Text='<%# Bind("DividerNationalCode") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Title">
					<EditItemTemplate>
						<asp:TextBox ID="txtTitle" runat="server" Text='<%# Eval("Title") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelTitle" runat="server" Text='<%# Bind("Title") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:HyperLinkField Text="Delete" DataNavigateUrlFields="DepartmentID" DataNavigateUrlFormatString="Z_DepartmentDelete.aspx?departmentID={0}" />
			</Columns>
		</asp:GridView>

		&nbsp;&nbsp;&nbsp;
		<br />
		<br />
		<asp:Button ID="Button1" runat="server" Text="Add New Department" OnClick="Button1_Click" CssClass="MehButton" /><br />
		<br />
		<asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
		</div>
</asp:Content>

