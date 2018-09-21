<%@ Page Title="" Language="C#" MasterPageFile="..\MasterPages\MasterPage.master" AutoEventWireup="true" CodeFile="Z_DepartmentMonthlyInformationDefault.aspx.cs" Inherits="WebForms_Z_DepartmentMonthlyInformationDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
		<div>
			<h3>
				List of all the DepartmentMonthlyInformations</h3>
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

				<asp:TemplateField HeaderText="DepartmentID">
					<EditItemTemplate>
						<asp:Label ID="lblDepartmentID" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("DepartmentID") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelDepartmentID" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("DepartmentID") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="AdjutancyTypeID">
					<EditItemTemplate>
						<asp:Label ID="lblAdjutancyTypeID" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("AdjutancyTypeID") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelAdjutancyTypeID" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("AdjutancyTypeID") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Value1">
					<EditItemTemplate>
						<asp:Label ID="lblValue1" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("Value1") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelValue1" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("Value1") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="OperationalReward_Average">
					<EditItemTemplate>
						<asp:Label ID="lblOperationalReward_Average" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("OperationalReward_Average") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelOperationalReward_Average" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("OperationalReward_Average") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="OperationalRewardAverage">
					<EditItemTemplate>
						<asp:Label ID="lblOperationalRewardAverage" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("OperationalRewardAverage") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelOperationalRewardAverage" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("OperationalRewardAverage") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Value2">
					<EditItemTemplate>
						<asp:Label ID="lblValue2" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("Value2") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelValue2" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("Value2") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="OperationalScore">
					<EditItemTemplate>
						<asp:Label ID="lblOperationalScore" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("OperationalScore") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelOperationalScore" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("OperationalScore") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="TotalParameter1">
					<EditItemTemplate>
						<asp:Label ID="lblTotalParameter1" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("TotalParameter1") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelTotalParameter1" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("TotalParameter1") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="TotalParameter2">
					<EditItemTemplate>
						<asp:Label ID="lblTotalParameter2" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("TotalParameter2") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelTotalParameter2" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("TotalParameter2") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="TotalParameter3">
					<EditItemTemplate>
						<asp:Label ID="lblTotalParameter3" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("TotalParameter3") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelTotalParameter3" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("TotalParameter3") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="TotalBossFactor">
					<EditItemTemplate>
						<asp:Label ID="lblTotalBossFactor" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("TotalBossFactor") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelTotalBossFactor" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("TotalBossFactor") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="TotalReward_">
					<EditItemTemplate>
						<asp:Label ID="lblTotalReward_" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("TotalReward_") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelTotalReward_" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("TotalReward_") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="OrganizationalReward_">
					<EditItemTemplate>
						<asp:Label ID="lblOrganizationalReward_" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("OrganizationalReward_") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelOrganizationalReward_" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("OrganizationalReward_") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="OperationalReward_">
					<EditItemTemplate>
						<asp:Label ID="lblOperationalReward_" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("OperationalReward_") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelOperationalReward_" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("OperationalReward_") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="TotalReward_Average">
					<EditItemTemplate>
						<asp:Label ID="lblTotalReward_Average" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("TotalReward_Average") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelTotalReward_Average" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("TotalReward_Average") %>'></asp:Label>
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

				<asp:TemplateField HeaderText="DepartmentIDTitle">
					<EditItemTemplate>
						<asp:Label ID="lblDepartmentIDTitle" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Eval("DepartmentIDTitle") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelDepartmentIDTitle" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("DepartmentIDTitle") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="RewardPerEmployee">
					<EditItemTemplate>
						<asp:TextBox ID="txtRewardPerEmployee" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("RewardPerEmployee") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelRewardPerEmployee" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("RewardPerEmployee") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="OperationalRewardCalculated">
					<EditItemTemplate>
						<asp:TextBox ID="txtOperationalRewardCalculated" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("OperationalRewardCalculated") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelOperationalRewardCalculated" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("OperationalRewardCalculated") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="OperationalReward">
					<EditItemTemplate>
						<asp:TextBox ID="txtOperationalReward" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("OperationalReward") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelOperationalReward" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("OperationalReward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="OrganizationalRewardCalculated">
					<EditItemTemplate>
						<asp:TextBox ID="txtOrganizationalRewardCalculated" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("OrganizationalRewardCalculated") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelOrganizationalRewardCalculated" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("OrganizationalRewardCalculated") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="OrganizationalReward">
					<EditItemTemplate>
						<asp:TextBox ID="txtOrganizationalReward" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("OrganizationalReward") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelOrganizationalReward" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("OrganizationalReward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="MonthlyProceed">
					<EditItemTemplate>
						<asp:TextBox ID="txtMonthlyProceed" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("MonthlyProceed") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelMonthlyProceed" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("MonthlyProceed") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="DesiredMonthlyProceed">
					<EditItemTemplate>
						<asp:TextBox ID="txtDesiredMonthlyProceed" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("DesiredMonthlyProceed") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelDesiredMonthlyProceed" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("DesiredMonthlyProceed") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="LastYearProceed">
					<EditItemTemplate>
						<asp:TextBox ID="txtLastYearProceed" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("LastYearProceed") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelLastYearProceed" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("LastYearProceed") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="StatisticsFinalalization">
					<EditItemTemplate>
						<asp:TextBox ID="txtStatisticsFinalalization" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("StatisticsFinalalization") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelStatisticsFinalalization" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("StatisticsFinalalization") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="AssistantRewardsFinalization">
					<EditItemTemplate>
						<asp:TextBox ID="txtAssistantRewardsFinalization" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("AssistantRewardsFinalization") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelAssistantRewardsFinalization" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("AssistantRewardsFinalization") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ManagerRewardsFinalization">
					<EditItemTemplate>
						<asp:TextBox ID="txtManagerRewardsFinalization" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("ManagerRewardsFinalization") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelManagerRewardsFinalization" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("ManagerRewardsFinalization") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="IsOfficialRewardsFinalizedBoss">
					<EditItemTemplate>
						<asp:TextBox ID="txtIsOfficialRewardsFinalizedBoss" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("IsOfficialRewardsFinalizedBoss") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelIsOfficialRewardsFinalizedBoss" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("IsOfficialRewardsFinalizedBoss") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="IsOfficialRewardsFinalizedAssistant">
					<EditItemTemplate>
						<asp:TextBox ID="txtIsOfficialRewardsFinalizedAssistant" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("IsOfficialRewardsFinalizedAssistant") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelIsOfficialRewardsFinalizedAssistant" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("IsOfficialRewardsFinalizedAssistant") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="IsOfficialRewardsFinalizedManager">
					<EditItemTemplate>
						<asp:TextBox ID="txtIsOfficialRewardsFinalizedManager" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("IsOfficialRewardsFinalizedManager") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelIsOfficialRewardsFinalizedManager" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("IsOfficialRewardsFinalizedManager") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ContractualRewardsFinalization">
					<EditItemTemplate>
						<asp:TextBox ID="txtContractualRewardsFinalization" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("ContractualRewardsFinalization") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelContractualRewardsFinalization" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("ContractualRewardsFinalization") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="IsContractualRewardsFinalizedBoss">
					<EditItemTemplate>
						<asp:TextBox ID="txtIsContractualRewardsFinalizedBoss" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("IsContractualRewardsFinalizedBoss") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelIsContractualRewardsFinalizedBoss" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("IsContractualRewardsFinalizedBoss") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="IsContractualRewardsFinalizedAssistant">
					<EditItemTemplate>
						<asp:TextBox ID="txtIsContractualRewardsFinalizedAssistant" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("IsContractualRewardsFinalizedAssistant") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelIsContractualRewardsFinalizedAssistant" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("IsContractualRewardsFinalizedAssistant") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="IsContractualRewardsFinalizedManager">
					<EditItemTemplate>
						<asp:TextBox ID="txtIsContractualRewardsFinalizedManager" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("IsContractualRewardsFinalizedManager") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelIsContractualRewardsFinalizedManager" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("IsContractualRewardsFinalizedManager") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="DossierNumber">
					<EditItemTemplate>
						<asp:TextBox ID="txtDossierNumber" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("DossierNumber") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelDossierNumber" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("DossierNumber") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Value3">
					<EditItemTemplate>
						<asp:TextBox ID="txtValue3" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("Value3") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelValue3" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("Value3") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Value4">
					<EditItemTemplate>
						<asp:TextBox ID="txtValue4" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("Value4") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelValue4" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("Value4") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Value5">
					<EditItemTemplate>
						<asp:TextBox ID="txtValue5" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("Value5") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelValue5" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("Value5") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Value6">
					<EditItemTemplate>
						<asp:TextBox ID="txtValue6" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("Value6") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelValue6" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("Value6") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="EmployeeNumber">
					<EditItemTemplate>
						<asp:TextBox ID="txtEmployeeNumber" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("EmployeeNumber") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelEmployeeNumber" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("EmployeeNumber") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ContractualEmployeeNumber">
					<EditItemTemplate>
						<asp:TextBox ID="txtContractualEmployeeNumber" runat="server" CssClass="GridViewEditItemTextBox" Text='<%# Eval("ContractualEmployeeNumber") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelContractualEmployeeNumber" runat="server" CssClass="GridViewEditItemLabel" Text='<%# Bind("ContractualEmployeeNumber") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:HyperLinkField Text="Delete" DataNavigateUrlFields="YearTypeID, MonthTypeID, DepartmentID" DataNavigateUrlFormatString="Z_DepartmentMonthlyInformationDelete.aspx?yearTypeID={0}&monthTypeID={1}&departmentID={2}" />
			</Columns>
		</asp:GridView>

		&nbsp;&nbsp;&nbsp;
		<br />
		<br />
		<asp:Button ID="Button1" runat="server" Text="Add New DepartmentMonthlyInformation" OnClick="Button1_Click" CssClass="MyButton" /><br />
		<br />
		<asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
		</div>
</asp:Content>

