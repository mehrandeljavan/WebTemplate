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

public partial class WebForms_Z_DepartmentMonthlyInformationDelete : System.Web.UI.Page
{
	DepartmentMonthlyInformationHandler departmentMonthlyInformationHandler = null;
	int departmentMonthlyInformationYearTypeID;
	int departmentMonthlyInformationMonthTypeID;
	int departmentMonthlyInformationDepartmentID;

	protected void Page_Load(object sender, EventArgs e)
	{
		string yearTypeID = Request.QueryString["yearTypeID"] as string;
		string monthTypeID = Request.QueryString["monthTypeID"] as string;
		string departmentID = Request.QueryString["departmentID"] as string;
		if (yearTypeID == null || monthTypeID == null || departmentID == null)
			Response.Redirect("Z_DepartmentMonthlyInformationDefault.aspx");

		try
		{
			departmentMonthlyInformationYearTypeID = Convert.ToInt32(yearTypeID.Trim());
			departmentMonthlyInformationMonthTypeID = Convert.ToInt32(monthTypeID.Trim());
			departmentMonthlyInformationDepartmentID = Convert.ToInt32(departmentID.Trim());
			departmentMonthlyInformationHandler = new DepartmentMonthlyInformationHandler();

			DepartmentMonthlyInformation departmentMonthlyInformation = departmentMonthlyInformationHandler.GetDetails(departmentMonthlyInformationYearTypeID , departmentMonthlyInformationMonthTypeID , departmentMonthlyInformationDepartmentID);

			lblYearTypeID.Text = departmentMonthlyInformation.YearTypeID.ToString();
			lblMonthTypeID.Text = departmentMonthlyInformation.MonthTypeID.ToString();
			lblDepartmentID.Text = departmentMonthlyInformation.DepartmentID.ToString();
			lblAdjutancyTypeID.Text = departmentMonthlyInformation.AdjutancyTypeID.ToString();
			lblValue1.Text = departmentMonthlyInformation.Value1.ToString();
			lblOperationalReward_Average.Text = departmentMonthlyInformation.OperationalReward_Average.ToString();
			lblOperationalRewardAverage.Text = departmentMonthlyInformation.OperationalRewardAverage.ToString();
			lblValue2.Text = departmentMonthlyInformation.Value2.ToString();
			lblOperationalScore.Text = departmentMonthlyInformation.OperationalScore.ToString();
			lblTotalParameter1.Text = departmentMonthlyInformation.TotalParameter1.ToString();
			lblTotalParameter2.Text = departmentMonthlyInformation.TotalParameter2.ToString();
			lblTotalParameter3.Text = departmentMonthlyInformation.TotalParameter3.ToString();
			lblTotalBossFactor.Text = departmentMonthlyInformation.TotalBossFactor.ToString();
			lblTotalReward_.Text = departmentMonthlyInformation.TotalReward_.ToString();
			lblOrganizationalReward_.Text = departmentMonthlyInformation.OrganizationalReward_.ToString();
			lblOperationalReward_.Text = departmentMonthlyInformation.OperationalReward_.ToString();
			lblTotalReward_Average.Text = departmentMonthlyInformation.TotalReward_Average.ToString();
			lblYearTypeIDTitle.Text = departmentMonthlyInformation.YearTypeIDTitle.ToString();
			lblMonthTypeIDTitle.Text = departmentMonthlyInformation.MonthTypeIDTitle.ToString();
			lblDepartmentIDTitle.Text = departmentMonthlyInformation.DepartmentIDTitle.ToString();
			lblRewardPerEmployee.Text = departmentMonthlyInformation.RewardPerEmployee.ToString();
			lblOperationalRewardCalculated.Text = departmentMonthlyInformation.OperationalRewardCalculated.ToString();
			lblOperationalReward.Text = departmentMonthlyInformation.OperationalReward.ToString();
			lblOrganizationalRewardCalculated.Text = departmentMonthlyInformation.OrganizationalRewardCalculated.ToString();
			lblOrganizationalReward.Text = departmentMonthlyInformation.OrganizationalReward.ToString();
			lblMonthlyProceed.Text = departmentMonthlyInformation.MonthlyProceed.ToString();
			lblDesiredMonthlyProceed.Text = departmentMonthlyInformation.DesiredMonthlyProceed.ToString();
			lblLastYearProceed.Text = departmentMonthlyInformation.LastYearProceed.ToString();
			lblStatisticsFinalalization.Text = departmentMonthlyInformation.StatisticsFinalalization.ToString();
			lblAssistantRewardsFinalization.Text = departmentMonthlyInformation.AssistantRewardsFinalization.ToString();
			lblManagerRewardsFinalization.Text = departmentMonthlyInformation.ManagerRewardsFinalization.ToString();
			lblIsOfficialRewardsFinalizedBoss.Text = departmentMonthlyInformation.IsOfficialRewardsFinalizedBoss.ToString();
			lblIsOfficialRewardsFinalizedAssistant.Text = departmentMonthlyInformation.IsOfficialRewardsFinalizedAssistant.ToString();
			lblIsOfficialRewardsFinalizedManager.Text = departmentMonthlyInformation.IsOfficialRewardsFinalizedManager.ToString();
			lblContractualRewardsFinalization.Text = departmentMonthlyInformation.ContractualRewardsFinalization.ToString();
			lblIsContractualRewardsFinalizedBoss.Text = departmentMonthlyInformation.IsContractualRewardsFinalizedBoss.ToString();
			lblIsContractualRewardsFinalizedAssistant.Text = departmentMonthlyInformation.IsContractualRewardsFinalizedAssistant.ToString();
			lblIsContractualRewardsFinalizedManager.Text = departmentMonthlyInformation.IsContractualRewardsFinalizedManager.ToString();
			lblDossierNumber.Text = departmentMonthlyInformation.DossierNumber.ToString();
			lblValue3.Text = departmentMonthlyInformation.Value3.ToString();
			lblValue4.Text = departmentMonthlyInformation.Value4.ToString();
			lblValue5.Text = departmentMonthlyInformation.Value5.ToString();
			lblValue6.Text = departmentMonthlyInformation.Value6.ToString();
			lblEmployeeNumber.Text = departmentMonthlyInformation.EmployeeNumber.ToString();
			lblContractualEmployeeNumber.Text = departmentMonthlyInformation.ContractualEmployeeNumber.ToString();
		}
		catch (Exception)
		{
			Response.Redirect("Z_DepartmentMonthlyInformationDefault.aspx");
		}
	}
	protected void btnNO_Click(object sender, EventArgs e)
	{
		Response.Redirect("Z_DepartmentMonthlyInformationDefault.aspx");
	}

	protected void btnYES_Click(object sender, EventArgs e)
	{
		if (departmentMonthlyInformationHandler.Delete(departmentMonthlyInformationYearTypeID , departmentMonthlyInformationMonthTypeID , departmentMonthlyInformationDepartmentID))
			Response.Redirect("Z_DepartmentMonthlyInformationDefault.aspx");
	}
}
