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
			<asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" AutoGenerateColumns="False" AutoGenerateEditButton="True" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" BorderColor="Silver" BorderStyle="Solid" BorderWidth="1px" Font-Names="BYekan">
			<FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
			<PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
			<SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
			<HeaderStyle BackColor="#9933CC" Font-Bold="True" ForeColor="White" />
			<EditRowStyle BackColor="#33b5e5" />
			<RowStyle BackColor="#EFF3FB" />
			<AlternatingRowStyle BackColor="White" />
			<Columns>

				<asp:TemplateField HeaderText="MainOfficeTypeID">
					<EditItemTemplate>
						<asp:Label ID="lblMainOfficeTypeID" runat="server" Text='<%# Eval("MainOfficeTypeID") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelMainOfficeTypeID" runat="server" Text='<%# Bind("MainOfficeTypeID") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ContractualEmployeesNumber">
					<EditItemTemplate>
						<asp:Label ID="lblContractualEmployeesNumber" runat="server" Text='<%# Eval("ContractualEmployeesNumber") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelContractualEmployeesNumber" runat="server" Text='<%# Bind("ContractualEmployeesNumber") %>'></asp:Label>
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

				<asp:TemplateField HeaderText="TotalScore">
					<EditItemTemplate>
						<asp:TextBox ID="txtTotalScore" runat="server" Text='<%# Eval("TotalScore") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelTotalScore" runat="server" Text='<%# Bind("TotalScore") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="TotalScoreCat1">
					<EditItemTemplate>
						<asp:TextBox ID="txtTotalScoreCat1" runat="server" Text='<%# Eval("TotalScoreCat1") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelTotalScoreCat1" runat="server" Text='<%# Bind("TotalScoreCat1") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="TotalScoreCat2">
					<EditItemTemplate>
						<asp:TextBox ID="txtTotalScoreCat2" runat="server" Text='<%# Eval("TotalScoreCat2") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelTotalScoreCat2" runat="server" Text='<%# Bind("TotalScoreCat2") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:HyperLinkField Text="Delete" DataNavigateUrlFields="MainOfficeTypeID" DataNavigateUrlFormatString="Z_MainOfficeTypeDelete.aspx?mainOfficeTypeID={0}" />
			</Columns>
		</asp:GridView>

		&nbsp;&nbsp;&nbsp;
		<br />
		<br />
		<asp:Button ID="Button1" runat="server" Text="Add New MainOfficeType" OnClick="Button1_Click" CssClass="MehButton" /><br />
		<br />
		<asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
		</div>
</asp:Content>

