<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" AutoEventWireup="true" CodeFile="Z_ActivityTypeEdit.aspx.cs" Inherits="WebForms_Z_ActivityTypeEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
		<strong>Edit ActivityType<br />
		</strong>
		<br />
		<table style="width: 320px">

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
		Are you sure you want to Edit?&nbsp; &nbsp;
		<asp:Button ID="btnYES" runat="server" OnClick="btnYES_Click" Text="Edit" CssClass="MyButton" />
		&nbsp; &nbsp;
		<asp:Button ID="btnNO" runat="server" OnClick="btnNO_Click" Text="Cancel"  CssClass="MyButton" />
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>

