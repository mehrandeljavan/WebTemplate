<%@ Page Title="" Language="C#" MasterPageFile="..\MasterPages\MasterPage.master" AutoEventWireup="true" CodeFile="Z_BaseMonthlyInformationDelete.aspx.cs" Inherits="WebForms_Z_BaseMonthlyInformationDelete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<div>
		Delete BaseMonthlyInformation<br />
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
					MainOfficeTypeID
				</td>
				<td>
					<asp:Label ID="lblMainOfficeTypeID" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					ValueToScore
				</td>
				<td>
					<asp:Label ID="lblValueToScore" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					TotalOperationalReward
				</td>
				<td>
					<asp:Label ID="lblTotalOperationalReward" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					TotalOrganizationalReward
				</td>
				<td>
					<asp:Label ID="lblTotalOrganizationalReward" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					ContractualDividableReward
				</td>
				<td>
					<asp:Label ID="lblContractualDividableReward" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					ContractualBossReward
				</td>
				<td>
					<asp:Label ID="lblContractualBossReward" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					ContractualDevotedReward
				</td>
				<td>
					<asp:Label ID="lblContractualDevotedReward" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					ContractualRemainingReward
				</td>
				<td>
					<asp:Label ID="lblContractualRemainingReward" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					DividableReward
				</td>
				<td>
					<asp:Label ID="lblDividableReward" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					BossReward
				</td>
				<td>
					<asp:Label ID="lblBossReward" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					DevotedReward
				</td>
				<td>
					<asp:Label ID="lblDevotedReward" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					RemainingReward
				</td>
				<td>
					<asp:Label ID="lblRemainingReward" runat="server" Font-Bold="True" Text=""></asp:Label>
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
					ContractualReward
				</td>
				<td>
					<asp:Label ID="lblContractualReward" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					ContractualConstantReward
				</td>
				<td>
					<asp:Label ID="lblContractualConstantReward" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					ExtraReward
				</td>
				<td>
					<asp:Label ID="lblExtraReward" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					Factor5
				</td>
				<td>
					<asp:Label ID="lblFactor5" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					Factor6
				</td>
				<td>
					<asp:Label ID="lblFactor6" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					Factor7
				</td>
				<td>
					<asp:Label ID="lblFactor7" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					Factor8
				</td>
				<td>
					<asp:Label ID="lblFactor8" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					Factor9
				</td>
				<td>
					<asp:Label ID="lblFactor9" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					Factor10
				</td>
				<td>
					<asp:Label ID="lblFactor10" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					OfficialReward
				</td>
				<td>
					<asp:Label ID="lblOfficialReward" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					IsFanalized
				</td>
				<td>
					<asp:Label ID="lblIsFanalized" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					IsFainalizedEmployeesInformation
				</td>
				<td>
					<asp:Label ID="lblIsFainalizedEmployeesInformation" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					IsFainalizedRewardCalculation
				</td>
				<td>
					<asp:Label ID="lblIsFainalizedRewardCalculation" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					BossFactor
				</td>
				<td>
					<asp:Label ID="lblBossFactor" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					OperationalFactor
				</td>
				<td>
					<asp:Label ID="lblOperationalFactor" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					Factor1
				</td>
				<td>
					<asp:Label ID="lblFactor1" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					Factor2
				</td>
				<td>
					<asp:Label ID="lblFactor2" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					Factor3
				</td>
				<td>
					<asp:Label ID="lblFactor3" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					Factor4
				</td>
				<td>
					<asp:Label ID="lblFactor4" runat="server" Font-Bold="True" Text=""></asp:Label>
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

