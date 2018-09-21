<%@ Page Title="" Language="C#" MasterPageFile="..\MasterPages\MasterPage.master" AutoEventWireup="true" CodeFile="Z_MainOfficeTypeDelete.aspx.cs" Inherits="WebForms_Z_MainOfficeTypeDelete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<div>
		Delete MainOfficeType<br />
		<br />
		<table style="width: 320px">

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
					ContractualEmployeesNumber
				</td>
				<td>
					<asp:Label ID="lblContractualEmployeesNumber" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					Title
				</td>
				<td>
					<asp:Label ID="lblTitle" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					TotalScore
				</td>
				<td>
					<asp:Label ID="lblTotalScore" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					TotalScoreCat1
				</td>
				<td>
					<asp:Label ID="lblTotalScoreCat1" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					TotalScoreCat2
				</td>
				<td>
					<asp:Label ID="lblTotalScoreCat2" runat="server" Font-Bold="True" Text=""></asp:Label>
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

