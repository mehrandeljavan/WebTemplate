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

public partial class WebForms_Z_OfficialEmployeeRewardDefault : System.Web.UI.Page
{
	OfficialEmployeeRewardHandler officialEmployeeRewardHandler = null;


	protected void Page_Load(object sender, EventArgs e)
	{
		lblResult.Text = string.Empty;

		officialEmployeeRewardHandler = new OfficialEmployeeRewardHandler();
		if (IsPostBack == false)
		{
			BindData();
		}
	}

	private void BindData()
	{
		GridView1.DataSource = officialEmployeeRewardHandler.GetListAll();
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

		Label lblNationalCode = GridView1.Rows[e.RowIndex].FindControl("lblNationalCode") as Label;
		Label lblYearTypeID = GridView1.Rows[e.RowIndex].FindControl("lblYearTypeID") as Label;
		Label lblMonthTypeID = GridView1.Rows[e.RowIndex].FindControl("lblMonthTypeID") as Label;
		Label lblEmployeeFullName = GridView1.Rows[e.RowIndex].FindControl("lblEmployeeFullName") as Label;
		Label lblDepartmentIDTitle = GridView1.Rows[e.RowIndex].FindControl("lblDepartmentIDTitle") as Label;
		Label lblYearTypeIDTitle = GridView1.Rows[e.RowIndex].FindControl("lblYearTypeIDTitle") as Label;
		Label lblMonthTypeIDTitle = GridView1.Rows[e.RowIndex].FindControl("lblMonthTypeIDTitle") as Label;
		Label lblRoleTypeIDTitle = GridView1.Rows[e.RowIndex].FindControl("lblRoleTypeIDTitle") as Label;
		Label lblTotalReward = GridView1.Rows[e.RowIndex].FindControl("lblTotalReward") as Label;
		Label lblReward_ = GridView1.Rows[e.RowIndex].FindControl("lblReward_") as Label;
		Label lblRoleTypeIDFactor = GridView1.Rows[e.RowIndex].FindControl("lblRoleTypeIDFactor") as Label;
		TextBox txtBossFactor = GridView1.Rows[e.RowIndex].FindControl("txtBossFactor") as TextBox;
		TextBox txtReward = GridView1.Rows[e.RowIndex].FindControl("txtReward") as TextBox;
		TextBox txtBossFinalValue = GridView1.Rows[e.RowIndex].FindControl("txtBossFinalValue") as TextBox;
		TextBox txtAssistantFinalValue = GridView1.Rows[e.RowIndex].FindControl("txtAssistantFinalValue") as TextBox;
		TextBox txtManagerFinalValue = GridView1.Rows[e.RowIndex].FindControl("txtManagerFinalValue") as TextBox;
		TextBox txtExtraReward1 = GridView1.Rows[e.RowIndex].FindControl("txtExtraReward1") as TextBox;
		TextBox txtExtraReward2 = GridView1.Rows[e.RowIndex].FindControl("txtExtraReward2") as TextBox;
		TextBox txtExtraReward3 = GridView1.Rows[e.RowIndex].FindControl("txtExtraReward3") as TextBox;
		TextBox txtRoleTypeID = GridView1.Rows[e.RowIndex].FindControl("txtRoleTypeID") as TextBox;
		TextBox txtParameter1 = GridView1.Rows[e.RowIndex].FindControl("txtParameter1") as TextBox;
		TextBox txtParameter2 = GridView1.Rows[e.RowIndex].FindControl("txtParameter2") as TextBox;
		TextBox txtParameter3 = GridView1.Rows[e.RowIndex].FindControl("txtParameter3") as TextBox;


		if (lblNationalCode != null && lblYearTypeID != null && lblMonthTypeID != null && lblEmployeeFullName != null && lblDepartmentIDTitle != null && lblYearTypeIDTitle != null && lblMonthTypeIDTitle != null && lblRoleTypeIDTitle != null && lblTotalReward != null && lblReward_ != null && lblRoleTypeIDFactor != null && txtBossFactor != null && txtReward != null && txtBossFinalValue != null && txtAssistantFinalValue != null && txtManagerFinalValue != null && txtExtraReward1 != null && txtExtraReward2 != null && txtExtraReward3 != null && txtRoleTypeID != null && txtParameter1 != null && txtParameter2 != null && txtParameter3 != null) 
		{
			OfficialEmployeeReward officialEmployeeReward = new OfficialEmployeeReward();

			officialEmployeeReward.NationalCode = Convert.ToInt64(lblNationalCode.Text.Trim());
			officialEmployeeReward.YearTypeID = Convert.ToInt32(lblYearTypeID.Text.Trim());
			officialEmployeeReward.MonthTypeID = Convert.ToInt32(lblMonthTypeID.Text.Trim());
			officialEmployeeReward.EmployeeFullName = lblEmployeeFullName.Text;
			officialEmployeeReward.DepartmentIDTitle = lblDepartmentIDTitle.Text;
			officialEmployeeReward.YearTypeIDTitle = lblYearTypeIDTitle.Text;
			officialEmployeeReward.MonthTypeIDTitle = lblMonthTypeIDTitle.Text;
			officialEmployeeReward.RoleTypeIDTitle = lblRoleTypeIDTitle.Text;
			officialEmployeeReward.TotalReward = Convert.ToInt64(lblTotalReward.Text.Trim());
			officialEmployeeReward.Reward_ = Convert.ToInt64(lblReward_.Text.Trim());
			officialEmployeeReward.Reward = Convert.ToInt64(txtReward.Text.Trim());
			officialEmployeeReward.BossFinalValue = Convert.ToInt64(txtBossFinalValue.Text.Trim());
			officialEmployeeReward.AssistantFinalValue = Convert.ToInt64(txtAssistantFinalValue.Text.Trim());
			officialEmployeeReward.ManagerFinalValue = Convert.ToInt64(txtManagerFinalValue.Text.Trim());
			officialEmployeeReward.ExtraReward1 = Convert.ToInt64(txtExtraReward1.Text.Trim());
			officialEmployeeReward.ExtraReward2 = Convert.ToInt64(txtExtraReward2.Text.Trim());
			officialEmployeeReward.ExtraReward3 = Convert.ToInt64(txtExtraReward3.Text.Trim());
			officialEmployeeReward.RoleTypeID = Convert.ToInt32(txtRoleTypeID.Text.Trim());
			officialEmployeeReward.Parameter1 = Convert.ToInt32(txtParameter1.Text.Trim());
			officialEmployeeReward.Parameter2 = Convert.ToInt32(txtParameter2.Text.Trim());
			officialEmployeeReward.Parameter3 = Convert.ToInt32(txtParameter3.Text.Trim());

			//Let us now update the database
			if (officialEmployeeRewardHandler.Update(officialEmployeeReward) == true)
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
		Response.Redirect("Z_OfficialEmployeeRewardAdd.aspx");
	}
}
