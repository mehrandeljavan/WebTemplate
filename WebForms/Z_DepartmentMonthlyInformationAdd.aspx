<%@ Page Title="" Language="C#" MasterPageFile="..\MasterPages\MasterPage.master" AutoEventWireup="true" CodeFile="Z_DepartmentMonthlyInformationAdd.aspx.cs" Inherits="WebForms_Z_DepartmentMonthlyInformationAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<div>
		<strong>Add new DepartmentMonthlyInformation<br />
		</strong>
		<br />
		<table style="width: 320px">

			<tr>
				<td>
					YearTypeID
				</td>
				<td>
					<asp:DropDownList ID="ddlYearTypeID" runat="server" Width="300px"></asp:DropDownList>
				</td>
			</tr>


			<tr>
				<td>
					MonthTypeID
				</td>
				<td>
					<asp:DropDownList ID="ddlMonthTypeID" runat="server" Width="300px"></asp:DropDownList>
				</td>
			</tr>


			<tr>
				<td>
					DepartmentID
				</td>
				<td>
					<asp:DropDownList ID="ddlDepartmentID" runat="server" Width="300px"></asp:DropDownList>
				</td>
			</tr>


			<tr>
				<td>
					RewardPerEmployee
				</td>
				<td>
					<asp:TextBox ID="txtRewardPerEmployee" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					OperationalRewardCalculated
				</td>
				<td>
					<asp:TextBox ID="txtOperationalRewardCalculated" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					OperationalReward
				</td>
				<td>
					<asp:TextBox ID="txtOperationalReward" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					OrganizationalRewardCalculated
				</td>
				<td>
					<asp:TextBox ID="txtOrganizationalRewardCalculated" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					OrganizationalReward
				</td>
				<td>
					<asp:TextBox ID="txtOrganizationalReward" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					MonthlyProceed
				</td>
				<td>
					<asp:TextBox ID="txtMonthlyProceed" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					DesiredMonthlyProceed
				</td>
				<td>
					<asp:TextBox ID="txtDesiredMonthlyProceed" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					LastYearProceed
				</td>
				<td>
					<asp:TextBox ID="txtLastYearProceed" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					StatisticsFinalalization
				</td>
				<td>
					<asp:TextBox ID="txtStatisticsFinalalization" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					AssistantRewardsFinalization
				</td>
				<td>
					<asp:TextBox ID="txtAssistantRewardsFinalization" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					ManagerRewardsFinalization
				</td>
				<td>
					<asp:TextBox ID="txtManagerRewardsFinalization" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					IsOfficialRewardsFinalizedBoss
				</td>
				<td>
					<asp:TextBox ID="txtIsOfficialRewardsFinalizedBoss" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					IsOfficialRewardsFinalizedAssistant
				</td>
				<td>
					<asp:TextBox ID="txtIsOfficialRewardsFinalizedAssistant" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					IsOfficialRewardsFinalizedManager
				</td>
				<td>
					<asp:TextBox ID="txtIsOfficialRewardsFinalizedManager" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					ContractualRewardsFinalization
				</td>
				<td>
					<asp:TextBox ID="txtContractualRewardsFinalization" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					IsContractualRewardsFinalizedBoss
				</td>
				<td>
					<asp:TextBox ID="txtIsContractualRewardsFinalizedBoss" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					IsContractualRewardsFinalizedAssistant
				</td>
				<td>
					<asp:TextBox ID="txtIsContractualRewardsFinalizedAssistant" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					IsContractualRewardsFinalizedManager
				</td>
				<td>
					<asp:TextBox ID="txtIsContractualRewardsFinalizedManager" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					DossierNumber
				</td>
				<td>
					<asp:TextBox ID="txtDossierNumber" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					Value3
				</td>
				<td>
					<asp:TextBox ID="txtValue3" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					Value4
				</td>
				<td>
					<asp:TextBox ID="txtValue4" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					Value5
				</td>
				<td>
					<asp:TextBox ID="txtValue5" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					Value6
				</td>
				<td>
					<asp:TextBox ID="txtValue6" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					EmployeeNumber
				</td>
				<td>
					<asp:TextBox ID="txtEmployeeNumber" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					ContractualEmployeeNumber
				</td>
				<td>
					<asp:TextBox ID="txtContractualEmployeeNumber" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>

		</table>
		<br />
		Are you sure you want to submit?&nbsp; &nbsp;
		<asp:Button ID="btnYES" runat="server" OnClick="btnYES_Click" Text="Submit" CssClass="MyButton" />
		&nbsp; &nbsp;
		<asp:Button ID="btnNO" runat="server" OnClick="btnNO_Click" Text="Cancel"  CssClass="MyButton" /></div>
</asp:Content>

