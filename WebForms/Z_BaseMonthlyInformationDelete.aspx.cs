using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using Rewards;
using Rewards.Models;

public partial class WebForms_Z_BaseMonthlyInformationDelete : System.Web.UI.Page
{
	BaseMonthlyInformationHandler baseMonthlyInformationHandler = null;
	int baseMonthlyInformationYearTypeID;
	int baseMonthlyInformationMonthTypeID;
	int baseMonthlyInformationMainOfficeTypeID;

	protected void Page_Load(object sender, EventArgs e)
	{
		string yearTypeID = Request.QueryString["yearTypeID"] as string;
		string monthTypeID = Request.QueryString["monthTypeID"] as string;
		string mainOfficeTypeID = Request.QueryString["mainOfficeTypeID"] as string;
		if (yearTypeID == null || monthTypeID == null || mainOfficeTypeID == null)
			Response.Redirect("Z_BaseMonthlyInformationDefault.aspx");

		try
		{
			baseMonthlyInformationYearTypeID = Convert.ToInt32(yearTypeID.Trim());
			baseMonthlyInformationMonthTypeID = Convert.ToInt32(monthTypeID.Trim());
			baseMonthlyInformationMainOfficeTypeID = Convert.ToInt32(mainOfficeTypeID.Trim());
			baseMonthlyInformationHandler = new BaseMonthlyInformationHandler();

			BaseMonthlyInformation baseMonthlyInformation = baseMonthlyInformationHandler.GetDetails(baseMonthlyInformationYearTypeID , baseMonthlyInformationMonthTypeID , baseMonthlyInformationMainOfficeTypeID);

			lblYearTypeID.Text = baseMonthlyInformation.YearTypeID.ToString();
			lblMonthTypeID.Text = baseMonthlyInformation.MonthTypeID.ToString();
			lblMainOfficeTypeID.Text = baseMonthlyInformation.MainOfficeTypeID.ToString();
			lblValueToScore.Text = baseMonthlyInformation.ValueToScore.ToString();
			lblTotalOperationalReward.Text = baseMonthlyInformation.TotalOperationalReward.ToString();
			lblTotalOrganizationalReward.Text = baseMonthlyInformation.TotalOrganizationalReward.ToString();
			lblContractualDividableReward.Text = baseMonthlyInformation.ContractualDividableReward.ToString();
			lblContractualBossReward.Text = baseMonthlyInformation.ContractualBossReward.ToString();
			lblContractualDevotedReward.Text = baseMonthlyInformation.ContractualDevotedReward.ToString();
			lblContractualRemainingReward.Text = baseMonthlyInformation.ContractualRemainingReward.ToString();
			lblDividableReward.Text = baseMonthlyInformation.DividableReward.ToString();
			lblBossReward.Text = baseMonthlyInformation.BossReward.ToString();
			lblDevotedReward.Text = baseMonthlyInformation.DevotedReward.ToString();
			lblRemainingReward.Text = baseMonthlyInformation.RemainingReward.ToString();
			lblYearTypeIDTitle.Text = baseMonthlyInformation.YearTypeIDTitle.ToString();
			lblMonthTypeIDTitle.Text = baseMonthlyInformation.MonthTypeIDTitle.ToString();
			lblContractualReward.Text = baseMonthlyInformation.ContractualReward.ToString();
			lblContractualConstantReward.Text = baseMonthlyInformation.ContractualConstantReward.ToString();
			lblExtraReward.Text = baseMonthlyInformation.ExtraReward.ToString();
			lblFactor5.Text = baseMonthlyInformation.Factor5.ToString();
			lblFactor6.Text = baseMonthlyInformation.Factor6.ToString();
			lblFactor7.Text = baseMonthlyInformation.Factor7.ToString();
			lblFactor8.Text = baseMonthlyInformation.Factor8.ToString();
			lblFactor9.Text = baseMonthlyInformation.Factor9.ToString();
			lblFactor10.Text = baseMonthlyInformation.Factor10.ToString();
			lblOfficialReward.Text = baseMonthlyInformation.OfficialReward.ToString();
			lblIsFanalized.Text = baseMonthlyInformation.IsFanalized.ToString();
			lblIsFainalizedEmployeesInformation.Text = baseMonthlyInformation.IsFainalizedEmployeesInformation.ToString();
			lblIsFainalizedRewardCalculation.Text = baseMonthlyInformation.IsFainalizedRewardCalculation.ToString();
			lblBossFactor.Text = baseMonthlyInformation.BossFactor.ToString();
			lblOperationalFactor.Text = baseMonthlyInformation.OperationalFactor.ToString();
			lblFactor1.Text = baseMonthlyInformation.Factor1.ToString();
			lblFactor2.Text = baseMonthlyInformation.Factor2.ToString();
			lblFactor3.Text = baseMonthlyInformation.Factor3.ToString();
			lblFactor4.Text = baseMonthlyInformation.Factor4.ToString();
		}
		catch (Exception)
		{
			Response.Redirect("Z_BaseMonthlyInformationDefault.aspx");
		}
	}
	protected void btnNO_Click(object sender, EventArgs e)
	{
		Response.Redirect("Z_BaseMonthlyInformationDefault.aspx");
	}

	protected void btnYES_Click(object sender, EventArgs e)
	{
		if (baseMonthlyInformationHandler.Delete(baseMonthlyInformationYearTypeID , baseMonthlyInformationMonthTypeID , baseMonthlyInformationMainOfficeTypeID))
			Response.Redirect("Z_BaseMonthlyInformationDefault.aspx");
	}
}
