<%@ Page Title="" Language="C#" MasterPageFile="..\MasterPages\MasterPage.master" AutoEventWireup="true" CodeFile="Z_EmployeeDelete.aspx.cs" Inherits="WebForms_Z_EmployeeDelete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<div>
		Delete Employee<br />
		<br />
		<table style="width: 320px">

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
					ContractTypeIDTitle
				</td>
				<td>
					<asp:Label ID="lblContractTypeIDTitle" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					RoleTypeIDTitle
				</td>
				<td>
					<asp:Label ID="lblRoleTypeIDTitle" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					FullName
				</td>
				<td>
					<asp:Label ID="lblFullName" runat="server" Font-Bold="True" Text=""></asp:Label>
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
					RoleTypeIDFactor
				</td>
				<td>
					<asp:Label ID="lblRoleTypeIDFactor" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					PersonalCode
				</td>
				<td>
					<asp:Label ID="lblPersonalCode" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					FirstName
				</td>
				<td>
					<asp:Label ID="lblFirstName" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					LastName
				</td>
				<td>
					<asp:Label ID="lblLastName" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					AccountNumber
				</td>
				<td>
					<asp:Label ID="lblAccountNumber" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					ContractTypeID
				</td>
				<td>
					<asp:Label ID="lblContractTypeID" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					RoleTypeID
				</td>
				<td>
					<asp:Label ID="lblRoleTypeID" runat="server" Font-Bold="True" Text=""></asp:Label>
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
					IsActiveEmployee
				</td>
				<td>
					<asp:Label ID="lblIsActiveEmployee" runat="server" Font-Bold="True" Text=""></asp:Label>
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

