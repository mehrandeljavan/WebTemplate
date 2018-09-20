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

public partial class WebForms_Z_ContractualEmployeeRewardDelete : System.Web.UI.Page
{
	ContractualEmployeeRewardHandler contractualEmployeeRewardHandler = null;
	int contractualEmployeeRewardYearTypeID;
	int contractualEmployeeRewardMonthTypeID;
	Int64 contractualEmployeeRewardNationalCode;

	protected void Page_Load(object sender, EventArgs e)
	{
		string yearTypeID = Request.QueryString["yearTypeID"] as string;
		string monthTypeID = Request.QueryString["monthTypeID"] as string;
		string nationalCode = Request.QueryString["nationalCode"] as string;
		if (yearTypeID == null || monthTypeID == null || nationalCode == null)
			Response.Redirect("Z_ContractualEmployeeRewardDefault.aspx");

		try
		{
			contractualEmployeeRewardYearTypeID = Convert.ToInt32(yearTypeID.Trim());
			contractualEmployeeRewardMonthTypeID = Convert.ToInt32(monthTypeID.Trim());
			contractualEmployeeRewardNationalCode = Convert.ToInt64(nationalCode.Trim());
			contractualEmployeeRewardHandler = new ContractualEmployeeRewardHandler();

			ContractualEmployeeReward contractualEmployeeReward = contractualEmployeeRewardHandler.GetDetails(contractualEmployeeRewardYearTypeID , contractualEmployeeRewardMonthTypeID , contractualEmployeeRewardNationalCode);

			lblYearTypeID.Text = contractualEmployeeReward.YearTypeID.ToString();
			lblMonthTypeID.Text = contractualEmployeeReward.MonthTypeID.ToString();
			lblNationalCode.Text = contractualEmployeeReward.NationalCode.ToString();
			lblTotalReward.Text = contractualEmployeeReward.TotalReward.ToString();
			lblReward_.Text = contractualEmployeeReward.Reward_.ToString();
			lblEmployeeFullName.Text = contractualEmployeeReward.EmployeeFullName.ToString();
			lblDepartmentIDTitle.Text = contractualEmployeeReward.DepartmentIDTitle.ToString();
			lblYearTypeIDTitle.Text = contractualEmployeeReward.YearTypeIDTitle.ToString();
			lblMonthTypeIDTitle.Text = contractualEmployeeReward.MonthTypeIDTitle.ToString();
			lblReward.Text = contractualEmployeeReward.Reward.ToString();
			lblBossFinalValue.Text = contractualEmployeeReward.BossFinalValue.ToString();
			lblAssistantFinalValue.Text = contractualEmployeeReward.AssistantFinalValue.ToString();
			lblManagerFinalValue.Text = contractualEmployeeReward.ManagerFinalValue.ToString();
			lblExtraReward1.Text = contractualEmployeeReward.ExtraReward1.ToString();
			lblExtraReward2.Text = contractualEmployeeReward.ExtraReward2.ToString();
			lblExtraReward3.Text = contractualEmployeeReward.ExtraReward3.ToString();
		}
		catch (Exception)
		{
			Response.Redirect("Z_ContractualEmployeeRewardDefault.aspx");
		}
	}
	protected void btnNO_Click(object sender, EventArgs e)
	{
		Response.Redirect("Z_ContractualEmployeeRewardDefault.aspx");
	}

	protected void btnYES_Click(object sender, EventArgs e)
	{
		if (contractualEmployeeRewardHandler.Delete(contractualEmployeeRewardYearTypeID , contractualEmployeeRewardMonthTypeID , contractualEmployeeRewardNationalCode))
			Response.Redirect("Z_ContractualEmployeeRewardDefault.aspx");
	}
}
