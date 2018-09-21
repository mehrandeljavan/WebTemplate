<%@ Page Title="" Language="C#" MasterPageFile="..\MasterPages\MasterPage.master" AutoEventWireup="true" CodeFile="Z_AdjutancyTypeDefault.aspx.cs" Inherits="WebForms_Z_AdjutancyTypeDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
		<div>
			<h3>
				List of all the AdjutancyTypes</h3>
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

				<asp:TemplateField HeaderText="AdjutancyTypeID">
					<EditItemTemplate>
						<asp:Label ID="lblAdjutancyTypeID" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("AdjutancyTypeID") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelAdjutancyTypeID" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("AdjutancyTypeID") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="AdjutantFullName">
					<EditItemTemplate>
						<asp:Label ID="lblAdjutantFullName" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("AdjutantFullName") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelAdjutantFullName" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("AdjutantFullName") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="AdjutantNationalCode">
					<EditItemTemplate>
						<asp:TextBox ID="txtAdjutantNationalCode" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("AdjutantNationalCode") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelAdjutantNationalCode" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("AdjutantNationalCode") %>'></asp:Label>
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

				<asp:HyperLinkField Text="Delete" DataNavigateUrlFields="AdjutancyTypeID" DataNavigateUrlFormatString="Z_AdjutancyTypeDelete.aspx?adjutancyTypeID={0}" />
			</Columns>
		</asp:GridView>

		&nbsp;&nbsp;&nbsp;
		<br />
		<br />
		<asp:Button ID="Button1" runat="server" Text="Add New AdjutancyType" OnClick="Button1_Click" CssClass="MyButton" /><br />
		<br />
		<asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
		</div>
</asp:Content>

