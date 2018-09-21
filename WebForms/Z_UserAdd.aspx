<%@ Page Title="" Language="C#" MasterPageFile="..\MasterPages\MasterPage.master" AutoEventWireup="true" CodeFile="Z_UserAdd.aspx.cs" Inherits="WebForms_Z_UserAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<div>
		<strong>Add new User<br />
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
					Password
				</td>
				<td>
					<asp:TextBox ID="txtPassword" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					LastPassChangeDate
				</td>
				<td>
					<asp:TextBox ID="txtLastPassChangeDate" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>


			<tr>
				<td>
					IsActiveUser
				</td>
				<td>
					<asp:TextBox ID="txtIsActiveUser" runat="server" Width="300px" CssClass="MyTextBox"></asp:TextBox>
				</td>
			</tr>

		</table>
		<br />
		Are you sure you want to submit?&nbsp; &nbsp;
		<asp:Button ID="btnYES" runat="server" OnClick="btnYES_Click" Text="Submit" CssClass="MyButton" />
		&nbsp; &nbsp;
		<asp:Button ID="btnNO" runat="server" OnClick="btnNO_Click" Text="Cancel"  CssClass="MyButton" /></div>
</asp:Content>

