<%@ Page Title="" Language="C#" MasterPageFile="..\MasterPages\MasterPage.master" AutoEventWireup="true" CodeFile="Z_ActivityTypeDefault.aspx.cs" Inherits="WebForms_Z_ActivityTypeDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
		<div>
			<h3>
				List of all the ActivityTypes</h3>
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

				<asp:TemplateField HeaderText="Title">
					<EditItemTemplate>
						<asp:TextBox ID="txtTitle" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("Title") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelTitle" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("Title") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:HyperLinkField Text="Delete" DataNavigateUrlFields="ActivityTypeID" DataNavigateUrlFormatString="Z_ActivityTypeDelete.aspx?activityTypeID={0}" />
                <asp:HyperLinkField Text="Insert" DataNavigateUrlFields="ActivityTypeID" DataNavigateUrlFormatString="Z_ActivityTypeAdd.aspx" />
                <asp:HyperLinkField Text="Edit"   DataNavigateUrlFields="ActivityTypeID" DataNavigateUrlFormatString="Z_ActivityTypeEdit.aspx?activityTypeID={0}" />
			</Columns>
		</asp:GridView>

		&nbsp;&nbsp;&nbsp;
		<br />
		<br />
		<asp:Button ID="Button1" runat="server" Text="Add New ActivityType" OnClick="Button1_Click" CssClass="MyButton" /><br />
		<br />
		<asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
		</div>
</asp:Content>

