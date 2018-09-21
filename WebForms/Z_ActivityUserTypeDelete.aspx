<%@ Page Title="" Language="C#" MasterPageFile="..\MasterPages\MasterPage.master" AutoEventWireup="true" CodeFile="Z_ActivityUserTypeDelete.aspx.cs" Inherits="WebForms_Z_ActivityUserTypeDelete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<div>
		Delete ActivityUserType<br />
		<br />
		<table style="width: 320px">

			<tr>
				<td>
					ActivityTypeID
				</td>
				<td>
					<asp:Label ID="lblActivityTypeID" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					UserTypeID
				</td>
				<td>
					<asp:Label ID="lblUserTypeID" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					ActivityTypeIDTitle
				</td>
				<td>
					<asp:Label ID="lblActivityTypeIDTitle" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					UserTypeIDTitle
				</td>
				<td>
					<asp:Label ID="lblUserTypeIDTitle" runat="server" Font-Bold="True" Text=""></asp:Label>
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

