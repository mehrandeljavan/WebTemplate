<%@ Page Title="" Language="C#" MasterPageFile="..\MasterPages\MasterPage.master" AutoEventWireup="true" CodeFile="Z_BaseMonthlyInformationDefault.aspx.cs" Inherits="WebForms_Z_BaseMonthlyInformationDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
		<div>
			<h3>
				List of all the BaseMonthlyInformations</h3>
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

				<asp:TemplateField HeaderText="MainOfficeTypeID">
					<EditItemTemplate>
						<asp:Label ID="lblMainOfficeTypeID" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("MainOfficeTypeID") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelMainOfficeTypeID" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("MainOfficeTypeID") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ValueToScore">
					<EditItemTemplate>
						<asp:Label ID="lblValueToScore" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("ValueToScore") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelValueToScore" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("ValueToScore") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="TotalOperationalReward">
					<EditItemTemplate>
						<asp:Label ID="lblTotalOperationalReward" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("TotalOperationalReward") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelTotalOperationalReward" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("TotalOperationalReward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="TotalOrganizationalReward">
					<EditItemTemplate>
						<asp:Label ID="lblTotalOrganizationalReward" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("TotalOrganizationalReward") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelTotalOrganizationalReward" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("TotalOrganizationalReward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ContractualDividableReward">
					<EditItemTemplate>
						<asp:Label ID="lblContractualDividableReward" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("ContractualDividableReward") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelContractualDividableReward" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("ContractualDividableReward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ContractualBossReward">
					<EditItemTemplate>
						<asp:Label ID="lblContractualBossReward" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("ContractualBossReward") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelContractualBossReward" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("ContractualBossReward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ContractualDevotedReward">
					<EditItemTemplate>
						<asp:Label ID="lblContractualDevotedReward" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("ContractualDevotedReward") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelContractualDevotedReward" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("ContractualDevotedReward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ContractualRemainingReward">
					<EditItemTemplate>
						<asp:Label ID="lblContractualRemainingReward" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("ContractualRemainingReward") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelContractualRemainingReward" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("ContractualRemainingReward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="DividableReward">
					<EditItemTemplate>
						<asp:Label ID="lblDividableReward" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("DividableReward") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelDividableReward" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("DividableReward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="BossReward">
					<EditItemTemplate>
						<asp:Label ID="lblBossReward" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("BossReward") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelBossReward" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("BossReward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="DevotedReward">
					<EditItemTemplate>
						<asp:Label ID="lblDevotedReward" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("DevotedReward") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelDevotedReward" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("DevotedReward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="RemainingReward">
					<EditItemTemplate>
						<asp:Label ID="lblRemainingReward" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("RemainingReward") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelRemainingReward" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("RemainingReward") %>'></asp:Label>
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

				<asp:TemplateField HeaderText="ContractualReward">
					<EditItemTemplate>
						<asp:TextBox ID="txtContractualReward" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("ContractualReward") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelContractualReward" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("ContractualReward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ContractualConstantReward">
					<EditItemTemplate>
						<asp:TextBox ID="txtContractualConstantReward" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("ContractualConstantReward") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelContractualConstantReward" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("ContractualConstantReward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ExtraReward">
					<EditItemTemplate>
						<asp:TextBox ID="txtExtraReward" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("ExtraReward") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelExtraReward" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("ExtraReward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Factor5">
					<EditItemTemplate>
						<asp:TextBox ID="txtFactor5" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("Factor5") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelFactor5" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("Factor5") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Factor6">
					<EditItemTemplate>
						<asp:TextBox ID="txtFactor6" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("Factor6") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelFactor6" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("Factor6") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Factor7">
					<EditItemTemplate>
						<asp:TextBox ID="txtFactor7" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("Factor7") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelFactor7" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("Factor7") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Factor8">
					<EditItemTemplate>
						<asp:TextBox ID="txtFactor8" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("Factor8") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelFactor8" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("Factor8") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Factor9">
					<EditItemTemplate>
						<asp:TextBox ID="txtFactor9" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("Factor9") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelFactor9" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("Factor9") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Factor10">
					<EditItemTemplate>
						<asp:TextBox ID="txtFactor10" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("Factor10") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelFactor10" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("Factor10") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="OfficialReward">
					<EditItemTemplate>
						<asp:TextBox ID="txtOfficialReward" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("OfficialReward") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelOfficialReward" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("OfficialReward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="IsFanalized">
					<EditItemTemplate>
						<asp:TextBox ID="txtIsFanalized" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("IsFanalized") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelIsFanalized" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("IsFanalized") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="IsFainalizedEmployeesInformation">
					<EditItemTemplate>
						<asp:TextBox ID="txtIsFainalizedEmployeesInformation" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("IsFainalizedEmployeesInformation") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelIsFainalizedEmployeesInformation" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("IsFainalizedEmployeesInformation") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="IsFainalizedRewardCalculation">
					<EditItemTemplate>
						<asp:TextBox ID="txtIsFainalizedRewardCalculation" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("IsFainalizedRewardCalculation") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelIsFainalizedRewardCalculation" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("IsFainalizedRewardCalculation") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="BossFactor">
					<EditItemTemplate>
						<asp:TextBox ID="txtBossFactor" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("BossFactor") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelBossFactor" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("BossFactor") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="OperationalFactor">
					<EditItemTemplate>
						<asp:TextBox ID="txtOperationalFactor" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("OperationalFactor") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelOperationalFactor" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("OperationalFactor") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Factor1">
					<EditItemTemplate>
						<asp:TextBox ID="txtFactor1" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("Factor1") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelFactor1" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("Factor1") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Factor2">
					<EditItemTemplate>
						<asp:TextBox ID="txtFactor2" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("Factor2") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelFactor2" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("Factor2") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Factor3">
					<EditItemTemplate>
						<asp:TextBox ID="txtFactor3" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("Factor3") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelFactor3" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("Factor3") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Factor4">
					<EditItemTemplate>
						<asp:TextBox ID="txtFactor4" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("Factor4") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelFactor4" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("Factor4") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:HyperLinkField Text="Delete" DataNavigateUrlFields="YearTypeID, MonthTypeID, MainOfficeTypeID" DataNavigateUrlFormatString="Z_BaseMonthlyInformationDelete.aspx?yearTypeID={0}&monthTypeID={1}&mainOfficeTypeID={2}" />
			</Columns>
		</asp:GridView>

		&nbsp;&nbsp;&nbsp;
		<br />
		<br />
		<asp:Button ID="Button1" runat="server" Text="Add New BaseMonthlyInformation" OnClick="Button1_Click" CssClass="MyButton" /><br />
		<br />
		<asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
		</div>
</asp:Content>

