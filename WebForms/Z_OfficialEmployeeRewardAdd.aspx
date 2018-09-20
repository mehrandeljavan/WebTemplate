<%@ Page Title="" Language="C#" MasterPageFile="..\MasterPages\MasterPage.master" AutoEventWireup="true" CodeFile="Z_OfficialEmployeeRewardAdd.aspx.cs" Inherits="WebForms_Z_OfficialEmployeeRewardAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<div>
		<strong>Add new OfficialEmployeeReward<br />
		</strong>
		<br />
		<table style="width: 320px">

			<tr>
				<td>
					NationalCode
				</td>
				<td>
					<asp:DropDownList ID="ddlNationalCode" runat="server" Width="300px"></asp:DropDownList>
				</td>
			</tr>


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
					BossFactor
				</td>
				<td>
					<asp:TextBox ID="txtBossFactor" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					Reward
				</td>
				<td>
					<asp:TextBox ID="txtReward" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					BossFinalValue
				</td>
				<td>
					<asp:TextBox ID="txtBossFinalValue" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					AssistantFinalValue
				</td>
				<td>
					<asp:TextBox ID="txtAssistantFinalValue" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					ManagerFinalValue
				</td>
				<td>
					<asp:TextBox ID="txtManagerFinalValue" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					ExtraReward1
				</td>
				<td>
					<asp:TextBox ID="txtExtraReward1" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					ExtraReward2
				</td>
				<td>
					<asp:TextBox ID="txtExtraReward2" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					ExtraReward3
				</td>
				<td>
					<asp:TextBox ID="txtExtraReward3" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					RoleTypeID
				</td>
				<td>
					<asp:TextBox ID="txtRoleTypeID" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					Parameter1
				</td>
				<td>
					<asp:TextBox ID="txtParameter1" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					Parameter2
				</td>
				<td>
					<asp:TextBox ID="txtParameter2" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					Parameter3
				</td>
				<td>
					<asp:TextBox ID="txtParameter3" runat="server" Width="300px"></asp:TextBox>
				</td>
			</tr>

		</table>
		<br />
		Are you sure you want to submit?&nbsp; &nbsp;
		<asp:Button ID="btnYES" runat="server" OnClick="btnYES_Click" Text="Submit" />
		&nbsp; &nbsp;
		<asp:Button ID="btnNO" runat="server" OnClick="btnNO_Click" Text="Cancel" /></div>
</asp:Content>

