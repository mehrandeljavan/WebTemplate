<%@ Page Title="" Language="C#" MasterPageFile="..\MasterPages\MasterPage.master" AutoEventWireup="true" CodeFile="Z_BaseMonthlyInformationDefault.aspx.cs" Inherits="WebForms_Z_BaseMonthlyInformationDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
		<div>
			<h3>
				List of all the BaseMonthlyInformations</h3>
			<br />
			<asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" AutoGenerateColumns="False" AutoGenerateEditButton="True" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" BorderColor="Silver" BorderStyle="Solid" BorderWidth="1px" Font-Names="BYekan">
			<FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
			<PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
			<SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
			<HeaderStyle BackColor="#9933CC" Font-Bold="True" ForeColor="White" />
			<EditRowStyle BackColor="#33b5e5" />
			<RowStyle BackColor="#EFF3FB" />
			<AlternatingRowStyle BackColor="White" />
			<Columns>

				<asp:TemplateField HeaderText="YearTypeID">
					<EditItemTemplate>
						<asp:Label ID="lblYearTypeID" runat="server" Text='<%# Eval("YearTypeID") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelYearTypeID" runat="server" Text='<%# Bind("YearTypeID") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="MonthTypeID">
					<EditItemTemplate>
						<asp:Label ID="lblMonthTypeID" runat="server" Text='<%# Eval("MonthTypeID") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelMonthTypeID" runat="server" Text='<%# Bind("MonthTypeID") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="MainOfficeTypeID">
					<EditItemTemplate>
						<asp:Label ID="lblMainOfficeTypeID" runat="server" Text='<%# Eval("MainOfficeTypeID") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelMainOfficeTypeID" runat="server" Text='<%# Bind("MainOfficeTypeID") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ValueToScore">
					<EditItemTemplate>
						<asp:Label ID="lblValueToScore" runat="server" Text='<%# Eval("ValueToScore") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelValueToScore" runat="server" Text='<%# Bind("ValueToScore") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="TotalOperationalReward">
					<EditItemTemplate>
						<asp:Label ID="lblTotalOperationalReward" runat="server" Text='<%# Eval("TotalOperationalReward") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelTotalOperationalReward" runat="server" Text='<%# Bind("TotalOperationalReward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="TotalOrganizationalReward">
					<EditItemTemplate>
						<asp:Label ID="lblTotalOrganizationalReward" runat="server" Text='<%# Eval("TotalOrganizationalReward") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelTotalOrganizationalReward" runat="server" Text='<%# Bind("TotalOrganizationalReward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ContractualDividableReward">
					<EditItemTemplate>
						<asp:Label ID="lblContractualDividableReward" runat="server" Text='<%# Eval("ContractualDividableReward") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelContractualDividableReward" runat="server" Text='<%# Bind("ContractualDividableReward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ContractualBossReward">
					<EditItemTemplate>
						<asp:Label ID="lblContractualBossReward" runat="server" Text='<%# Eval("ContractualBossReward") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelContractualBossReward" runat="server" Text='<%# Bind("ContractualBossReward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ContractualDevotedReward">
					<EditItemTemplate>
						<asp:Label ID="lblContractualDevotedReward" runat="server" Text='<%# Eval("ContractualDevotedReward") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelContractualDevotedReward" runat="server" Text='<%# Bind("ContractualDevotedReward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ContractualRemainingReward">
					<EditItemTemplate>
						<asp:Label ID="lblContractualRemainingReward" runat="server" Text='<%# Eval("ContractualRemainingReward") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelContractualRemainingReward" runat="server" Text='<%# Bind("ContractualRemainingReward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="DividableReward">
					<EditItemTemplate>
						<asp:Label ID="lblDividableReward" runat="server" Text='<%# Eval("DividableReward") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelDividableReward" runat="server" Text='<%# Bind("DividableReward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="BossReward">
					<EditItemTemplate>
						<asp:Label ID="lblBossReward" runat="server" Text='<%# Eval("BossReward") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelBossReward" runat="server" Text='<%# Bind("BossReward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="DevotedReward">
					<EditItemTemplate>
						<asp:Label ID="lblDevotedReward" runat="server" Text='<%# Eval("DevotedReward") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelDevotedReward" runat="server" Text='<%# Bind("DevotedReward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="RemainingReward">
					<EditItemTemplate>
						<asp:Label ID="lblRemainingReward" runat="server" Text='<%# Eval("RemainingReward") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelRemainingReward" runat="server" Text='<%# Bind("RemainingReward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="YearTypeIDTitle">
					<EditItemTemplate>
						<asp:Label ID="lblYearTypeIDTitle" runat="server" Text='<%# Eval("YearTypeIDTitle") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelYearTypeIDTitle" runat="server" Text='<%# Bind("YearTypeIDTitle") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="MonthTypeIDTitle">
					<EditItemTemplate>
						<asp:Label ID="lblMonthTypeIDTitle" runat="server" Text='<%# Eval("MonthTypeIDTitle") %>'></asp:Label>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelMonthTypeIDTitle" runat="server" Text='<%# Bind("MonthTypeIDTitle") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ContractualReward">
					<EditItemTemplate>
						<asp:TextBox ID="txtContractualReward" runat="server" Text='<%# Eval("ContractualReward") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelContractualReward" runat="server" Text='<%# Bind("ContractualReward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ContractualConstantReward">
					<EditItemTemplate>
						<asp:TextBox ID="txtContractualConstantReward" runat="server" Text='<%# Eval("ContractualConstantReward") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelContractualConstantReward" runat="server" Text='<%# Bind("ContractualConstantReward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="ExtraReward">
					<EditItemTemplate>
						<asp:TextBox ID="txtExtraReward" runat="server" Text='<%# Eval("ExtraReward") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelExtraReward" runat="server" Text='<%# Bind("ExtraReward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Factor5">
					<EditItemTemplate>
						<asp:TextBox ID="txtFactor5" runat="server" Text='<%# Eval("Factor5") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelFactor5" runat="server" Text='<%# Bind("Factor5") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Factor6">
					<EditItemTemplate>
						<asp:TextBox ID="txtFactor6" runat="server" Text='<%# Eval("Factor6") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelFactor6" runat="server" Text='<%# Bind("Factor6") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Factor7">
					<EditItemTemplate>
						<asp:TextBox ID="txtFactor7" runat="server" Text='<%# Eval("Factor7") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelFactor7" runat="server" Text='<%# Bind("Factor7") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Factor8">
					<EditItemTemplate>
						<asp:TextBox ID="txtFactor8" runat="server" Text='<%# Eval("Factor8") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelFactor8" runat="server" Text='<%# Bind("Factor8") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Factor9">
					<EditItemTemplate>
						<asp:TextBox ID="txtFactor9" runat="server" Text='<%# Eval("Factor9") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelFactor9" runat="server" Text='<%# Bind("Factor9") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Factor10">
					<EditItemTemplate>
						<asp:TextBox ID="txtFactor10" runat="server" Text='<%# Eval("Factor10") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelFactor10" runat="server" Text='<%# Bind("Factor10") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="OfficialReward">
					<EditItemTemplate>
						<asp:TextBox ID="txtOfficialReward" runat="server" Text='<%# Eval("OfficialReward") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelOfficialReward" runat="server" Text='<%# Bind("OfficialReward") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="IsFanalized">
					<EditItemTemplate>
						<asp:TextBox ID="txtIsFanalized" runat="server" Text='<%# Eval("IsFanalized") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelIsFanalized" runat="server" Text='<%# Bind("IsFanalized") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="IsFainalizedEmployeesInformation">
					<EditItemTemplate>
						<asp:TextBox ID="txtIsFainalizedEmployeesInformation" runat="server" Text='<%# Eval("IsFainalizedEmployeesInformation") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelIsFainalizedEmployeesInformation" runat="server" Text='<%# Bind("IsFainalizedEmployeesInformation") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="IsFainalizedRewardCalculation">
					<EditItemTemplate>
						<asp:TextBox ID="txtIsFainalizedRewardCalculation" runat="server" Text='<%# Eval("IsFainalizedRewardCalculation") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelIsFainalizedRewardCalculation" runat="server" Text='<%# Bind("IsFainalizedRewardCalculation") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="BossFactor">
					<EditItemTemplate>
						<asp:TextBox ID="txtBossFactor" runat="server" Text='<%# Eval("BossFactor") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelBossFactor" runat="server" Text='<%# Bind("BossFactor") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="OperationalFactor">
					<EditItemTemplate>
						<asp:TextBox ID="txtOperationalFactor" runat="server" Text='<%# Eval("OperationalFactor") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelOperationalFactor" runat="server" Text='<%# Bind("OperationalFactor") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Factor1">
					<EditItemTemplate>
						<asp:TextBox ID="txtFactor1" runat="server" Text='<%# Eval("Factor1") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelFactor1" runat="server" Text='<%# Bind("Factor1") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Factor2">
					<EditItemTemplate>
						<asp:TextBox ID="txtFactor2" runat="server" Text='<%# Eval("Factor2") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelFactor2" runat="server" Text='<%# Bind("Factor2") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Factor3">
					<EditItemTemplate>
						<asp:TextBox ID="txtFactor3" runat="server" Text='<%# Eval("Factor3") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelFactor3" runat="server" Text='<%# Bind("Factor3") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:TemplateField HeaderText="Factor4">
					<EditItemTemplate>
						<asp:TextBox ID="txtFactor4" runat="server" Text='<%# Eval("Factor4") %>'></asp:TextBox>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="LabelFactor4" runat="server" Text='<%# Bind("Factor4") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>

				<asp:HyperLinkField Text="Delete" DataNavigateUrlFields="YearTypeID, MonthTypeID, MainOfficeTypeID" DataNavigateUrlFormatString="Z_BaseMonthlyInformationDelete.aspx?yearTypeID={0}&monthTypeID={1}&mainOfficeTypeID={2}" />
			</Columns>
		</asp:GridView>

		&nbsp;&nbsp;&nbsp;
		<br />
		<br />
		<asp:Button ID="Button1" runat="server" Text="Add New BaseMonthlyInformation" OnClick="Button1_Click" CssClass="MehButton" /><br />
		<br />
		<asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
		</div>
</asp:Content>

