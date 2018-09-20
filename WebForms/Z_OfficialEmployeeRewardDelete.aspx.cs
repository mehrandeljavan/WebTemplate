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

public partial class WebForms_Z_OfficialEmployeeRewardDelete : System.Web.UI.Page
{
	OfficialEmployeeRewardHandler officialEmployeeRewardHandler = null;
	Int64 officialEmployeeRewardNationalCode;
	int officialEmployeeRewardYearTypeID;
	int officialEmployeeRewardMonthTypeID;

	protected void Page_Load(object sender, EventArgs e)
	{
		string nationalCode = Request.QueryString["nationalCode"] as string;
		string yearTypeID = Request.QueryString["yearTypeID"] as string;
		string monthTypeID = Request.QueryString["monthTypeID"] as string;
		if (nationalCode == null || yearTypeID == null || monthTypeID == null)
			Response.Redirect("Z_OfficialEmployeeRewardDefault.aspx");

		try
		{
			officialEmployeeRewardNationalCode = Convert.ToInt64(nationalCode.Trim());
			officialEmployeeRewardYearTypeID = Convert.ToInt32(yearTypeID.Trim());
			officialEmployeeRewardMonthTypeID = Convert.ToInt32(monthTypeID.Trim());
			officialEmployeeRewardHandler = new OfficialEmployeeRewardHandler();

			OfficialEmployeeReward officialEmployeeReward = officialEmployeeRewardHandler.GetDetails(officialEmployeeRewardNationalCode , officialEmployeeRewardYearTypeID , officialEmployeeRewardMonthTypeID);

			lblNationalCode.Text = officialEmployeeReward.NationalCode.ToString();
			lblYearTypeID.Text = officialEmployeeReward.YearTypeID.ToString();
			lblMonthTypeID.Text = officialEmployeeReward.MonthTypeID.ToString();
			lblEmployeeFullName.Text = officialEmployeeReward.EmployeeFullName.ToString();
			lblDepartmentIDTitle.Text = officialEmployeeReward.DepartmentIDTitle.ToString();
			lblYearTypeIDTitle.Text = officialEmployeeReward.YearTypeIDTitle.ToString();
			lblMonthTypeIDTitle.Text = officialEmployeeReward.MonthTypeIDTitle.ToString();
			lblRoleTypeIDTitle.Text = officialEmployeeReward.RoleTypeIDTitle.ToString();
			lblTotalReward.Text = officialEmployeeReward.TotalReward.ToString();
			lblReward_.Text = officialEmployeeReward.Reward_.ToString();
			lblRoleTypeIDFactor.Text = officialEmployeeReward.RoleTypeIDFactor.ToString();
			lblBossFactor.Text = officialEmployeeReward.BossFactor.ToString();
			lblReward.Text = officialEmployeeReward.Reward.ToString();
			lblBossFinalValue.Text = officialEmployeeReward.BossFinalValue.ToString();
			lblAssistantFinalValue.Text = officialEmployeeReward.AssistantFinalValue.ToString();
			lblManagerFinalValue.Text = officialEmployeeReward.ManagerFinalValue.ToString();
			lblExtraReward1.Text = officialEmployeeReward.ExtraReward1.ToString();
			lblExtraReward2.Text = officialEmployeeReward.ExtraReward2.ToString();
			lblExtraReward3.Text = officialEmployeeReward.ExtraReward3.ToString();
			lblRoleTypeID.Text = officialEmployeeReward.RoleTypeID.ToString();
			lblParameter1.Text = officialEmployeeReward.Parameter1.ToString();
			lblParameter2.Text = officialEmployeeReward.Parameter2.ToString();
			lblParameter3.Text = officialEmployeeReward.Parameter3.ToString();
		}
		catch (Exception)
		{
			Response.Redirect("Z_OfficialEmployeeRewardDefault.aspx");
		}
	}
	protected void btnNO_Click(object sender, EventArgs e)
	{
		Response.Redirect("Z_OfficialEmployeeRewardDefault.aspx");
	}

	protected void btnYES_Click(object sender, EventArgs e)
	{
		if (officialEmployeeRewardHandler.Delete(officialEmployeeRewardNationalCode , officialEmployeeRewardYearTypeID , officialEmployeeRewardMonthTypeID))
			Response.Redirect("Z_OfficialEmployeeRewardDefault.aspx");
	}
}
