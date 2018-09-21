<%@ Page Title="" Language="C#" MasterPageFile="..\MasterPages\MasterPage.master" AutoEventWireup="true" CodeFile="Z_UserDelete.aspx.cs" Inherits="WebForms_Z_UserDelete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<div>
		Delete User<br />
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
					Password
				</td>
				<td>
					<asp:Label ID="lblPassword" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					LastPassChangeDate
				</td>
				<td>
					<asp:Label ID="lblLastPassChangeDate" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					IsActiveUser
				</td>
				<td>
					<asp:Label ID="lblIsActiveUser" runat="server" Font-Bold="True" Text=""></asp:Label>
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

