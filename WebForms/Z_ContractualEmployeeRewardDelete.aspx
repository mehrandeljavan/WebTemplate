<%@ Page Title="" Language="C#" MasterPageFile="..\MasterPages\MasterPage.master" AutoEventWireup="true" CodeFile="Z_ContractualEmployeeRewardDelete.aspx.cs" Inherits="WebForms_Z_ContractualEmployeeRewardDelete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<div>
		Delete ContractualEmployeeReward<br />
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
					NationalCode
				</td>
				<td>
					<asp:Label ID="lblNationalCode" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					TotalReward
				</td>
				<td>
					<asp:Label ID="lblTotalReward" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					Reward_
				</td>
				<td>
					<asp:Label ID="lblReward_" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					EmployeeFullName
				</td>
				<td>
					<asp:Label ID="lblEmployeeFullName" runat="server" Font-Bold="True" Text=""></asp:Label>
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
					Reward
				</td>
				<td>
					<asp:Label ID="lblReward" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					BossFinalValue
				</td>
				<td>
					<asp:Label ID="lblBossFinalValue" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					AssistantFinalValue
				</td>
				<td>
					<asp:Label ID="lblAssistantFinalValue" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					ManagerFinalValue
				</td>
				<td>
					<asp:Label ID="lblManagerFinalValue" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					ExtraReward1
				</td>
				<td>
					<asp:Label ID="lblExtraReward1" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					ExtraReward2
				</td>
				<td>
					<asp:Label ID="lblExtraReward2" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					ExtraReward3
				</td>
				<td>
					<asp:Label ID="lblExtraReward3" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


		</table>

	</div>
		<br />
		Are you sure you want to delete this record? &nbsp; &nbsp;
		<asp:Button ID="btnYES" runat="server" Text="YES" OnClick="btnYES_Click" />
		&nbsp; &nbsp;
		<asp:Button ID="btnNO" runat="server" Text="NO" OnClick="btnNO_Click" /><br />
		<br />
		&nbsp;&nbsp;
</asp:Content>

