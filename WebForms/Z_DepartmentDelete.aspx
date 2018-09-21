<%@ Page Title="" Language="C#" MasterPageFile="..\MasterPages\MasterPage.master" AutoEventWireup="true" CodeFile="Z_DepartmentDelete.aspx.cs" Inherits="WebForms_Z_DepartmentDelete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<div>
		Delete Department<br />
		<br />
		<table style="width: 320px">

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
					DividerFullName
				</td>
				<td>
					<asp:Label ID="lblDividerFullName" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					ComputationTypeIDTitle
				</td>
				<td>
					<asp:Label ID="lblComputationTypeIDTitle" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					MainOfficeTypeIDTitle
				</td>
				<td>
					<asp:Label ID="lblMainOfficeTypeIDTitle" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					AdjutancyTypeIDTitle
				</td>
				<td>
					<asp:Label ID="lblAdjutancyTypeIDTitle" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					ComputationTypeID
				</td>
				<td>
					<asp:Label ID="lblComputationTypeID" runat="server" Font-Bold="True" Text=""></asp:Label>
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
					AdjutancyTypeID
				</td>
				<td>
					<asp:Label ID="lblAdjutancyTypeID" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					TotalEmployeeNumber
				</td>
				<td>
					<asp:Label ID="lblTotalEmployeeNumber" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					TotalContractualEmployeeNumber
				</td>
				<td>
					<asp:Label ID="lblTotalContractualEmployeeNumber" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					TotalPersonalScore
				</td>
				<td>
					<asp:Label ID="lblTotalPersonalScore" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					DividerNationalCode
				</td>
				<td>
					<asp:Label ID="lblDividerNationalCode" runat="server" Font-Bold="True" Text=""></asp:Label>
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

