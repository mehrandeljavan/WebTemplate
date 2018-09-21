<%@ Page Title="" Language="C#" MasterPageFile="..\MasterPages\MasterPage.master" AutoEventWireup="true" CodeFile="Z_ActivityUserTypeDefault.aspx.cs" Inherits="WebForms_Z_ActivityUserTypeDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
		<div>
			<h3>
				List of all the ActivityUserTypes</h3>
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

				<asp:TemplateField HeaderText="ActivityTypeID">
					<EditItemTemplate>
						<asp:Label ID="lblActivityTypeID" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("ActivityTypeID") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelActivityTypeID" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("ActivityTypeID") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="UserTypeID">
					<EditItemTemplate>
						<asp:Label ID="lblUserTypeID" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("UserTypeID") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelUserTypeID" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("UserTypeID") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ActivityTypeIDTitle">
					<EditItemTemplate>
						<asp:Label ID="lblActivityTypeIDTitle" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("ActivityTypeIDTitle") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelActivityTypeIDTitle" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("ActivityTypeIDTitle") %>'></asp:Label>
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

				<asp:HyperLinkField Text="Delete" DataNavigateUrlFields="ActivityTypeID, UserTypeID" DataNavigateUrlFormatString="Z_ActivityUserTypeDelete.aspx?activityTypeID={0}&userTypeID={1}" />
			</Columns>
		</asp:GridView>

		&nbsp;&nbsp;&nbsp;
		<br />
		<br />
		<asp:Button ID="Button1" runat="server" Text="Add New ActivityUserType" OnClick="Button1_Click" CssClass="MyButton" /><br />
		<br />
		<asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
		</div>
</asp:Content>

