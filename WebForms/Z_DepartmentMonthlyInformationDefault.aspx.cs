using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using Rewards;
using Rewards.Models;

public partial class WebForms_Z_DepartmentMonthlyInformationDefault : System.Web.UI.Page
{
	DepartmentMonthlyInformationHandler departmentMonthlyInformationHandler = null;


	protected void Page_Load(object sender, EventArgs e)
	{
		lblResult.Text = string.Empty;

		departmentMonthlyInformationHandler = new DepartmentMonthlyInformationHandler();
		if (IsPostBack == false)
		{
			BindData();
		}
	}

	private void BindData()
	{
		GridView1.DataSource = departmentMonthlyInformationHandler.GetListAll();
		GridView1.DataBind();
	}


	protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
	{
		GridView1.EditIndex = e.NewEditIndex;
		BindData();
	}

	protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
	{
		GridView1.EditIndex = -1;
		BindData();
	}

	protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
	{

		Label lblYearTypeID = GridView1.Rows[e.RowIndex].FindControl("lblYearTypeID") as Label;
		Label lblMonthTypeID = GridView1.Rows[e.RowIndex].FindControl("lblMonthTypeID") as Label;
		Label lblDepartmentID = GridView1.Rows[e.RowIndex].FindControl("lblDepartmentID") as Label;
		Label lblAdjutancyTypeID = GridView1.Rows[e.RowIndex].FindControl("lblAdjutancyTypeID") as Label;
		Label lblValue1 = GridView1.Rows[e.RowIndex].FindControl("lblValue1") as Label;
		Label lblOperationalReward_Average = GridView1.Rows[e.RowIndex].FindControl("lblOperationalReward_Average") as Label;
		Label lblOperationalRewardAverage = GridView1.Rows[e.RowIndex].FindControl("lblOperationalRewardAverage") as Label;
		Label lblValue2 = GridView1.Rows[e.RowIndex].FindControl("lblValue2") as Label;
		Label lblOperationalScore = GridView1.Rows[e.RowIndex].FindControl("lblOperationalScore") as Label;
		Label lblTotalParameter1 = GridView1.Rows[e.RowIndex].FindControl("lblTotalParameter1") as Label;
		Label lblTotalParameter2 = GridView1.Rows[e.RowIndex].FindControl("lblTotalParameter2") as Label;
		Label lblTotalParameter3 = GridView1.Rows[e.RowIndex].FindControl("lblTotalParameter3") as Label;
		Label lblTotalBossFactor = GridView1.Rows[e.RowIndex].FindControl("lblTotalBossFactor") as Label;
		Label lblTotalReward_ = GridView1.Rows[e.RowIndex].FindControl("lblTotalReward_") as Label;
		Label lblOrganizationalReward_ = GridView1.Rows[e.RowIndex].FindControl("lblOrganizationalReward_") as Label;
		Label lblOperationalReward_ = GridView1.Rows[e.RowIndex].FindControl("lblOperationalReward_") as Label;
		Label lblTotalReward_Average = GridView1.Rows[e.RowIndex].FindControl("lblTotalReward_Average") as Label;
		Label lblYearTypeIDTitle = GridView1.Rows[e.RowIndex].FindControl("lblYearTypeIDTitle") as Label;
		Label lblMonthTypeIDTitle = GridView1.Rows[e.RowIndex].FindControl("lblMonthTypeIDTitle") as Label;
		Label lblDepartmentIDTitle = GridView1.Rows[e.RowIndex].FindControl("lblDepartmentIDTitle") as Label;
		TextBox txtRewardPerEmployee = GridView1.Rows[e.RowIndex].FindControl("txtRewardPerEmployee") as TextBox;
		TextBox txtOperationalRewardCalculated = GridView1.Rows[e.RowIndex].FindControl("txtOperationalRewardCalculated") as TextBox;
		TextBox txtOperationalReward = GridView1.Rows[e.RowIndex].FindControl("txtOperationalReward") as TextBox;
		TextBox txtOrganizationalRewardCalculated = GridView1.Rows[e.RowIndex].FindControl("txtOrganizationalRewardCalculated") as TextBox;
		TextBox txtOrganizationalReward = GridView1.Rows[e.RowIndex].FindControl("txtOrganizationalReward") as TextBox;
		TextBox txtMonthlyProceed = GridView1.Rows[e.RowIndex].FindControl("txtMonthlyProceed") as TextBox;
		TextBox txtDesiredMonthlyProceed = GridView1.Rows[e.RowIndex].FindControl("txtDesiredMonthlyProceed") as TextBox;
		TextBox txtLastYearProceed = GridView1.Rows[e.RowIndex].FindControl("txtLastYearProceed") as TextBox;
		TextBox txtStatisticsFinalalization = GridView1.Rows[e.RowIndex].FindControl("txtStatisticsFinalalization") as TextBox;
		TextBox txtAssistantRewardsFinalization = GridView1.Rows[e.RowIndex].FindControl("txtAssistantRewardsFinalization") as TextBox;
		TextBox txtManagerRewardsFinalization = GridView1.Rows[e.RowIndex].FindControl("txtManagerRewardsFinalization") as TextBox;
		TextBox txtIsOfficialRewardsFinalizedBoss = GridView1.Rows[e.RowIndex].FindControl("txtIsOfficialRewardsFinalizedBoss") as TextBox;
		TextBox txtIsOfficialRewardsFinalizedAssistant = GridView1.Rows[e.RowIndex].FindControl("txtIsOfficialRewardsFinalizedAssistant") as TextBox;
		TextBox txtIsOfficialRewardsFinalizedManager = GridView1.Rows[e.RowIndex].FindControl("txtIsOfficialRewardsFinalizedManager") as TextBox;
		TextBox txtContractualRewardsFinalization = GridView1.Rows[e.RowIndex].FindControl("txtContractualRewardsFinalization") as TextBox;
		TextBox txtIsContractualRewardsFinalizedBoss = GridView1.Rows[e.RowIndex].FindControl("txtIsContractualRewardsFinalizedBoss") as TextBox;
		TextBox txtIsContractualRewardsFinalizedAssistant = GridView1.Rows[e.RowIndex].FindControl("txtIsContractualRewardsFinalizedAssistant") as TextBox;
		TextBox txtIsContractualRewardsFinalizedManager = GridView1.Rows[e.RowIndex].FindControl("txtIsContractualRewardsFinalizedManager") as TextBox;
		TextBox txtDossierNumber = GridView1.Rows[e.RowIndex].FindControl("txtDossierNumber") as TextBox;
		TextBox txtValue3 = GridView1.Rows[e.RowIndex].FindControl("txtValue3") as TextBox;
		TextBox txtValue4 = GridView1.Rows[e.RowIndex].FindControl("txtValue4") as TextBox;
		TextBox txtValue5 = GridView1.Rows[e.RowIndex].FindControl("txtValue5") as TextBox;
		TextBox txtValue6 = GridView1.Rows[e.RowIndex].FindControl("txtValue6") as TextBox;
		TextBox txtEmployeeNumber = GridView1.Rows[e.RowIndex].FindControl("txtEmployeeNumber") as TextBox;
		TextBox txtContractualEmployeeNumber = GridView1.Rows[e.RowIndex].FindControl("txtContractualEmployeeNumber") as TextBox;


		if (lblYearTypeID != null && lblMonthTypeID != null && lblDepartmentID != null && lblAdjutancyTypeID != null && lblValue1 != null && lblOperationalReward_Average != null && lblOperationalRewardAverage != null && lblValue2 != null && lblOperationalScore != null && lblTotalParameter1 != null && lblTotalParameter2 != null && lblTotalParameter3 != null && lblTotalBossFactor != null && lblTotalReward_ != null && lblOrganizationalReward_ != null && lblOperationalReward_ != null && lblTotalReward_Average != null && lblYearTypeIDTitle != null && lblMonthTypeIDTitle != null && lblDepartmentIDTitle != null && txtRewardPerEmployee != null && txtOperationalRewardCalculated != null && txtOperationalReward != null && txtOrganizationalRewardCalculated != null && txtOrganizationalReward != null && txtMonthlyProceed != null && txtDesiredMonthlyProceed != null && txtLastYearProceed != null && txtStatisticsFinalalization != null && txtAssistantRewardsFinalization != null && txtManagerRewardsFinalization != null && txtIsOfficialRewardsFinalizedBoss != null && txtIsOfficialRewardsFinalizedAssistant != null && txtIsOfficialRewardsFinalizedManager != null && txtContractualRewardsFinalization != null && txtIsContractualRewardsFinalizedBoss != null && txtIsContractualRewardsFinalizedAssistant != null && txtIsContractualRewardsFinalizedManager != null && txtDossierNumber != null && txtValue3 != null && txtValue4 != null && txtValue5 != null && txtValue6 != null && txtEmployeeNumber != null && txtContractualEmployeeNumber != null) 
		{
			DepartmentMonthlyInformation departmentMonthlyInformation = new DepartmentMonthlyInformation();

			departmentMonthlyInformation.YearTypeID = Convert.ToInt32(lblYearTypeID.Text.Trim());
			departmentMonthlyInformation.MonthTypeID = Convert.ToInt32(lblMonthTypeID.Text.Trim());
			departmentMonthlyInformation.DepartmentID = Convert.ToInt32(lblDepartmentID.Text.Trim());
			departmentMonthlyInformation.AdjutancyTypeID = Convert.ToInt32(lblAdjutancyTypeID.Text.Trim());
			departmentMonthlyInformation.TotalReward_ = Convert.ToInt64(lblTotalReward_.Text.Trim());
			departmentMonthlyInformation.OrganizationalReward_ = Convert.ToInt64(lblOrganizationalReward_.Text.Trim());
			departmentMonthlyInformation.OperationalReward_ = Convert.ToInt64(lblOperationalReward_.Text.Trim());
			departmentMonthlyInformation.TotalReward_Average = Convert.ToInt64(lblTotalReward_Average.Text.Trim());
			departmentMonthlyInformation.YearTypeIDTitle = lblYearTypeIDTitle.Text;
			departmentMonthlyInformation.MonthTypeIDTitle = lblMonthTypeIDTitle.Text;
			departmentMonthlyInformation.DepartmentIDTitle = lblDepartmentIDTitle.Text;
			departmentMonthlyInformation.RewardPerEmployee = Convert.ToInt64(txtRewardPerEmployee.Text.Trim());
			departmentMonthlyInformation.OperationalRewardCalculated = Convert.ToInt64(txtOperationalRewardCalculated.Text.Trim());
			departmentMonthlyInformation.OperationalReward = Convert.ToInt64(txtOperationalReward.Text.Trim());
			departmentMonthlyInformation.OrganizationalRewardCalculated = Convert.ToInt64(txtOrganizationalRewardCalculated.Text.Trim());
			departmentMonthlyInformation.OrganizationalReward = Convert.ToInt64(txtOrganizationalReward.Text.Trim());
			departmentMonthlyInformation.MonthlyProceed = Convert.ToInt64(txtMonthlyProceed.Text.Trim());
			departmentMonthlyInformation.DesiredMonthlyProceed = Convert.ToInt64(txtDesiredMonthlyProceed.Text.Trim());
			departmentMonthlyInformation.LastYearProceed = Convert.ToInt64(txtLastYearProceed.Text.Trim());
			departmentMonthlyInformation.DossierNumber = Convert.ToInt32(txtDossierNumber.Text.Trim());
			departmentMonthlyInformation.Value3 = Convert.ToInt32(txtValue3.Text.Trim());
			departmentMonthlyInformation.Value4 = Convert.ToInt32(txtValue4.Text.Trim());
			departmentMonthlyInformation.Value5 = Convert.ToInt32(txtValue5.Text.Trim());
			departmentMonthlyInformation.Value6 = Convert.ToInt32(txtValue6.Text.Trim());
			departmentMonthlyInformation.EmployeeNumber = Convert.ToInt32(txtEmployeeNumber.Text.Trim());
			departmentMonthlyInformation.ContractualEmployeeNumber = Convert.ToInt32(txtContractualEmployeeNumber.Text.Trim());

			//Let us now update the database
			if (departmentMonthlyInformationHandler.Update(departmentMonthlyInformation) == true)
			{
				lblResult.Text = "Record Updated Successfully";
			}
			else
			{
				lblResult.Text = "Failed to Update record";
			}

			//end the editing and bind with updated records.
			GridView1.EditIndex = -1;
			BindData();
		}
	}
	protected void Button1_Click(object sender, EventArgs e)
	{
		Response.Redirect("Z_DepartmentMonthlyInformationAdd.aspx");
	}
}
