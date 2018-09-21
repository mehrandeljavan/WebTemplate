<%@ Page Title="" Language="C#" MasterPageFile="..\MasterPages\MasterPage.master" AutoEventWireup="true" CodeFile="Z_DepartmentMonthlyInformationDelete.aspx.cs" Inherits="WebForms_Z_DepartmentMonthlyInformationDelete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<div>
		Delete DepartmentMonthlyInformation<br />
		<br />
		<table style="width: 320px">

			<tr>
				<td>
					YearTypeID
				</td>
				<td>
					<asp:Label ID="lblYearTypeID" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					MonthTypeID
				</td>
				<td>
					<asp:Label ID="lblMonthTypeID" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					DepartmentID
				</td>
				<td>
					<asp:Label ID="lblDepartmentID" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					AdjutancyTypeID
				</td>
				<td>
					<asp:Label ID="lblAdjutancyTypeID" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					Value1
				</td>
				<td>
					<asp:Label ID="lblValue1" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					OperationalReward_Average
				</td>
				<td>
					<asp:Label ID="lblOperationalReward_Average" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					OperationalRewardAverage
				</td>
				<td>
					<asp:Label ID="lblOperationalRewardAverage" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					Value2
				</td>
				<td>
					<asp:Label ID="lblValue2" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					OperationalScore
				</td>
				<td>
					<asp:Label ID="lblOperationalScore" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					TotalParameter1
				</td>
				<td>
					<asp:Label ID="lblTotalParameter1" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					TotalParameter2
				</td>
				<td>
					<asp:Label ID="lblTotalParameter2" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					TotalParameter3
				</td>
				<td>
					<asp:Label ID="lblTotalParameter3" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					TotalBossFactor
				</td>
				<td>
					<asp:Label ID="lblTotalBossFactor" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					TotalReward_
				</td>
				<td>
					<asp:Label ID="lblTotalReward_" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					OrganizationalReward_
				</td>
				<td>
					<asp:Label ID="lblOrganizationalReward_" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					OperationalReward_
				</td>
				<td>
					<asp:Label ID="lblOperationalReward_" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					TotalReward_Average
				</td>
				<td>
					<asp:Label ID="lblTotalReward_Average" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					YearTypeIDTitle
				</td>
				<td>
					<asp:Label ID="lblYearTypeIDTitle" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					MonthTypeIDTitle
				</td>
				<td>
					<asp:Label ID="lblMonthTypeIDTitle" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					DepartmentIDTitle
				</td>
				<td>
					<asp:Label ID="lblDepartmentIDTitle" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					RewardPerEmployee
				</td>
				<td>
					<asp:Label ID="lblRewardPerEmployee" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					OperationalRewardCalculated
				</td>
				<td>
					<asp:Label ID="lblOperationalRewardCalculated" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					OperationalReward
				</td>
				<td>
					<asp:Label ID="lblOperationalReward" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					OrganizationalRewardCalculated
				</td>
				<td>
					<asp:Label ID="lblOrganizationalRewardCalculated" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					OrganizationalReward
				</td>
				<td>
					<asp:Label ID="lblOrganizationalReward" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					MonthlyProceed
				</td>
				<td>
					<asp:Label ID="lblMonthlyProceed" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					DesiredMonthlyProceed
				</td>
				<td>
					<asp:Label ID="lblDesiredMonthlyProceed" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					LastYearProceed
				</td>
				<td>
					<asp:Label ID="lblLastYearProceed" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					StatisticsFinalalization
				</td>
				<td>
					<asp:Label ID="lblStatisticsFinalalization" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					AssistantRewardsFinalization
				</td>
				<td>
					<asp:Label ID="lblAssistantRewardsFinalization" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					ManagerRewardsFinalization
				</td>
				<td>
					<asp:Label ID="lblManagerRewardsFinalization" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					IsOfficialRewardsFinalizedBoss
				</td>
				<td>
					<asp:Label ID="lblIsOfficialRewardsFinalizedBoss" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					IsOfficialRewardsFinalizedAssistant
				</td>
				<td>
					<asp:Label ID="lblIsOfficialRewardsFinalizedAssistant" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					IsOfficialRewardsFinalizedManager
				</td>
				<td>
					<asp:Label ID="lblIsOfficialRewardsFinalizedManager" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					ContractualRewardsFinalization
				</td>
				<td>
					<asp:Label ID="lblContractualRewardsFinalization" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					IsContractualRewardsFinalizedBoss
				</td>
				<td>
					<asp:Label ID="lblIsContractualRewardsFinalizedBoss" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					IsContractualRewardsFinalizedAssistant
				</td>
				<td>
					<asp:Label ID="lblIsContractualRewardsFinalizedAssistant" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					IsContractualRewardsFinalizedManager
				</td>
				<td>
					<asp:Label ID="lblIsContractualRewardsFinalizedManager" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					DossierNumber
				</td>
				<td>
					<asp:Label ID="lblDossierNumber" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					Value3
				</td>
				<td>
					<asp:Label ID="lblValue3" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					Value4
				</td>
				<td>
					<asp:Label ID="lblValue4" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					Value5
				</td>
				<td>
					<asp:Label ID="lblValue5" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					Value6
				</td>
				<td>
					<asp:Label ID="lblValue6" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					EmployeeNumber
				</td>
				<td>
					<asp:Label ID="lblEmployeeNumber" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					ContractualEmployeeNumber
				</td>
				<td>
					<asp:Label ID="lblContractualEmployeeNumber" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


		</table>

	</div>
		<br />
		Are you sure you want to delete this record? &nbsp; &nbsp;
		<asp:Button ID="btnYES" runat="server" Text="YES" OnClick="btnYES_Click" CssClass="MyButton" />
		&nbsp; &nbsp;
		<asp:Button ID="btnNO" runat="server" Text="NO" OnClick="btnNO_Click" CssClass="MyButton" /><br />
		<br />
		&nbsp;&nbsp;
</asp:Content>

