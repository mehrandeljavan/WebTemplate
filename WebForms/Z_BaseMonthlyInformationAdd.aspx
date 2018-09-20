<%@ Page Title="" Language="C#" MasterPageFile="..\MasterPages\MasterPage.master" AutoEventWireup="true" CodeFile="Z_BaseMonthlyInformationAdd.aspx.cs" Inherits="WebForms_Z_BaseMonthlyInformationAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<div>
		<strong>Add new BaseMonthlyInformation<br />
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
					MainOfficeTypeID
				</td>
				<td>
					<asp:DropDownList ID="ddlMainOfficeTypeID" runat="server" Width="300px"></asp:DropDownList>
				</td>
			</tr>


			<tr>
				<td>
					ContractualReward
				</td>
				<td>
					<asp:TextBox ID="txtContractualReward" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					ContractualConstantReward
				</td>
				<td>
					<asp:TextBox ID="txtContractualConstantReward" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					ExtraReward
				</td>
				<td>
					<asp:TextBox ID="txtExtraReward" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					Factor5
				</td>
				<td>
					<asp:TextBox ID="txtFactor5" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					Factor6
				</td>
				<td>
					<asp:TextBox ID="txtFactor6" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					Factor7
				</td>
				<td>
					<asp:TextBox ID="txtFactor7" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					Factor8
				</td>
				<td>
					<asp:TextBox ID="txtFactor8" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					Factor9
				</td>
				<td>
					<asp:TextBox ID="txtFactor9" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					Factor10
				</td>
				<td>
					<asp:TextBox ID="txtFactor10" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					OfficialReward
				</td>
				<td>
					<asp:TextBox ID="txtOfficialReward" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					IsFanalized
				</td>
				<td>
					<asp:TextBox ID="txtIsFanalized" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					IsFainalizedEmployeesInformation
				</td>
				<td>
					<asp:TextBox ID="txtIsFainalizedEmployeesInformation" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					IsFainalizedRewardCalculation
				</td>
				<td>
					<asp:TextBox ID="txtIsFainalizedRewardCalculation" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					BossFactor
				</td>
				<td>
					<asp:TextBox ID="txtBossFactor" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					OperationalFactor
				</td>
				<td>
					<asp:TextBox ID="txtOperationalFactor" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					Factor1
				</td>
				<td>
					<asp:TextBox ID="txtFactor1" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					Factor2
				</td>
				<td>
					<asp:TextBox ID="txtFactor2" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					Factor3
				</td>
				<td>
					<asp:TextBox ID="txtFactor3" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					Factor4
				</td>
				<td>
					<asp:TextBox ID="txtFactor4" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>

		</table>
		<br />
		Are you sure you want to submit?&nbsp; &nbsp;
		<asp:Button ID="btnYES" runat="server" OnClick="btnYES_Click" Text="Submit" />
		&nbsp; &nbsp;
		<asp:Button ID="btnNO" runat="server" OnClick="btnNO_Click" Text="Cancel" /></div>
</asp:Content>

