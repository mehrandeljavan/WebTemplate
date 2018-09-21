<%@ Page Title="" Language="C#" MasterPageFile="..\MasterPages\MasterPage.master" AutoEventWireup="true" CodeFile="Z_AdjutancyTypeDelete.aspx.cs" Inherits="WebForms_Z_AdjutancyTypeDelete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<div>
		Delete AdjutancyType<br />
		<br />
		<table style="width: 320px">

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
					AdjutantFullName
				</td>
				<td>
					<asp:Label ID="lblAdjutantFullName" runat="server" Font-Bold="True" Text=""></asp:Label>
				</td>
			</tr>


			<tr>
				<td>
					AdjutantNationalCode
				</td>
				<td>
					<asp:Label ID="lblAdjutantNationalCode" runat="server" Font-Bold="True" Text=""></asp:Label>
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

