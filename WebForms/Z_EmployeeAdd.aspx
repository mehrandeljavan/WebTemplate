<%@ Page Title="" Language="C#" MasterPageFile="..\MasterPages\MasterPage.master" AutoEventWireup="true" CodeFile="Z_EmployeeAdd.aspx.cs" Inherits="WebForms_Z_EmployeeAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<div>
		<strong>Add new Employee<br />
		</strong>
		<br />
		<table style="width: 320px">

			<tr>
				<td>
					NationalCode
				</td>
				<td>
					<asp:TextBox ID="txtNationalCode" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					PersonalCode
				</td>
				<td>
					<asp:TextBox ID="txtPersonalCode" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					FirstName
				</td>
				<td>
					<asp:TextBox ID="txtFirstName" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					LastName
				</td>
				<td>
					<asp:TextBox ID="txtLastName" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					AccountNumber
				</td>
				<td>
					<asp:TextBox ID="txtAccountNumber" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					ContractTypeID
				</td>
				<td>
					<asp:DropDownList ID="ddlContractTypeID" runat="server" Width="300px"></asp:DropDownList>
				</td>
			</tr>


			<tr>
				<td>
					RoleTypeID
				</td>
				<td>
					<asp:DropDownList ID="ddlRoleTypeID" runat="server" Width="300px"></asp:DropDownList>
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
					IsActiveEmployee
				</td>
				<td>
					<asp:TextBox ID="txtIsActiveEmployee" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>

		</table>
		<br />
		Are you sure you want to submit?&nbsp; &nbsp;
		<asp:Button ID="btnYES" runat="server" OnClick="btnYES_Click" Text="Submit" CssClass="MyButton" />
		&nbsp; &nbsp;
		<asp:Button ID="btnNO" runat="server" OnClick="btnNO_Click" Text="Cancel"  CssClass="MyButton" /></div>
</asp:Content>

