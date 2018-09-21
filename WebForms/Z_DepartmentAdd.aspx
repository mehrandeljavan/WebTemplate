<%@ Page Title="" Language="C#" MasterPageFile="..\MasterPages\MasterPage.master" AutoEventWireup="true" CodeFile="Z_DepartmentAdd.aspx.cs" Inherits="WebForms_Z_DepartmentAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<div>
		<strong>Add new Department<br />
		</strong>
		<br />
		<table style="width: 320px">

			<tr>
				<td>
					ComputationTypeID
				</td>
				<td>
					<asp:DropDownList ID="ddlComputationTypeID" runat="server" Width="300px"></asp:DropDownList>
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
					AdjutancyTypeID
				</td>
				<td>
					<asp:DropDownList ID="ddlAdjutancyTypeID" runat="server" Width="300px"></asp:DropDownList>
				</td>
			</tr>


			<tr>
				<td>
					TotalEmployeeNumber
				</td>
				<td>
					<asp:TextBox ID="txtTotalEmployeeNumber" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					TotalContractualEmployeeNumber
				</td>
				<td>
					<asp:TextBox ID="txtTotalContractualEmployeeNumber" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					TotalPersonalScore
				</td>
				<td>
					<asp:TextBox ID="txtTotalPersonalScore" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					DividerNationalCode
				</td>
				<td>
					<asp:TextBox ID="txtDividerNationalCode" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					Title
				</td>
				<td>
					<asp:TextBox ID="txtTitle" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>

		</table>
		<br />
		Are you sure you want to submit?&nbsp; &nbsp;
		<asp:Button ID="btnYES" runat="server" OnClick="btnYES_Click" Text="Submit" CssClass="MyButton" />
		&nbsp; &nbsp;
		<asp:Button ID="btnNO" runat="server" OnClick="btnNO_Click" Text="Cancel"  CssClass="MyButton" /></div>
</asp:Content>

