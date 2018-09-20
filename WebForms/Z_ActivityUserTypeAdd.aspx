<%@ Page Title="" Language="C#" MasterPageFile="..\MasterPages\MasterPage.master" AutoEventWireup="true" CodeFile="Z_ActivityUserTypeAdd.aspx.cs" Inherits="WebForms_Z_ActivityUserTypeAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<div>
		<strong>Add new ActivityUserType<br />
		</strong>
		<br />
		<table style="width: 320px">

			<tr>
				<td>
					ActivityTypeID
				</td>
				<td>
					<asp:DropDownList ID="ddlActivityTypeID" runat="server" Width="300px"></asp:DropDownList>
				</td>
			</tr>


			<tr>
				<td>
					UserTypeID
				</td>
				<td>
					<asp:DropDownList ID="ddlUserTypeID" runat="server" Width="300px"></asp:DropDownList>
				</td>
			</tr>

		</table>
		<br />
		Are you sure you want to submit?&nbsp; &nbsp;
		<asp:Button ID="btnYES" runat="server" OnClick="btnYES_Click" Text="Submit" />
		&nbsp; &nbsp;
		<asp:Button ID="btnNO" runat="server" OnClick="btnNO_Click" Text="Cancel" /></div>
</asp:Content>

