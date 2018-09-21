﻿<%@ Page Title="" Language="C#" MasterPageFile="..\MasterPages\MasterPage.master" AutoEventWireup="true" CodeFile="Z_ContractualEmployeeRewardDefault.aspx.cs" Inherits="WebForms_Z_ContractualEmployeeRewardDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
		<div>
			<h3>
				List of all the ContractualEmployeeRewards</h3>
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

				<asp:TemplateField HeaderText="YearTypeID">
					<EditItemTemplate>
						<asp:Label ID="lblYearTypeID" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("YearTypeID") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelYearTypeID" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("YearTypeID") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="MonthTypeID">
					<EditItemTemplate>
						<asp:Label ID="lblMonthTypeID" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("MonthTypeID") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelMonthTypeID" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("MonthTypeID") %>'></asp:Label>
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

				<asp:TemplateField HeaderText="TotalReward">
					<EditItemTemplate>
						<asp:Label ID="lblTotalReward" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("TotalReward") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelTotalReward" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("TotalReward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Reward_">
					<EditItemTemplate>
						<asp:Label ID="lblReward_" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("Reward_") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelReward_" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("Reward_") %>'></asp:Label>
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

				<asp:TemplateField HeaderText="DepartmentIDTitle">
					<EditItemTemplate>
						<asp:Label ID="lblDepartmentIDTitle" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("DepartmentIDTitle") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelDepartmentIDTitle" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("DepartmentIDTitle") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="YearTypeIDTitle">
					<EditItemTemplate>
						<asp:Label ID="lblYearTypeIDTitle" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("YearTypeIDTitle") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelYearTypeIDTitle" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("YearTypeIDTitle") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="MonthTypeIDTitle">
					<EditItemTemplate>
						<asp:Label ID="lblMonthTypeIDTitle" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("MonthTypeIDTitle") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelMonthTypeIDTitle" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("MonthTypeIDTitle") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Reward">
					<EditItemTemplate>
						<asp:TextBox ID="txtReward" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("Reward") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelReward" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("Reward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="BossFinalValue">
					<EditItemTemplate>
						<asp:TextBox ID="txtBossFinalValue" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("BossFinalValue") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelBossFinalValue" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("BossFinalValue") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="AssistantFinalValue">
					<EditItemTemplate>
						<asp:TextBox ID="txtAssistantFinalValue" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("AssistantFinalValue") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelAssistantFinalValue" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("AssistantFinalValue") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ManagerFinalValue">
					<EditItemTemplate>
						<asp:TextBox ID="txtManagerFinalValue" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("ManagerFinalValue") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelManagerFinalValue" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("ManagerFinalValue") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ExtraReward1">
					<EditItemTemplate>
						<asp:TextBox ID="txtExtraReward1" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("ExtraReward1") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelExtraReward1" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("ExtraReward1") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ExtraReward2">
					<EditItemTemplate>
						<asp:TextBox ID="txtExtraReward2" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("ExtraReward2") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelExtraReward2" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("ExtraReward2") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ExtraReward3">
					<EditItemTemplate>
						<asp:TextBox ID="txtExtraReward3" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("ExtraReward3") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelExtraReward3" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("ExtraReward3") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:HyperLinkField Text="Delete" DataNavigateUrlFields="YearTypeID, MonthTypeID, NationalCode" DataNavigateUrlFormatString="Z_ContractualEmployeeRewardDelete.aspx?yearTypeID={0}&monthTypeID={1}&nationalCode={2}" />
			</Columns>
		</asp:GridView>

		&nbsp;&nbsp;&nbsp;
		<br />
		<br />
		<asp:Button ID="Button1" runat="server" Text="Add New ContractualEmployeeReward" OnClick="Button1_Click" CssClass="MyButton" /><br />
		<br />
		<asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
		</div>
</asp:Content>

