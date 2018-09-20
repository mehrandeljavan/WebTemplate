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

public partial class WebForms_Z_ContractualEmployeeRewardDefault : System.Web.UI.Page
{
	ContractualEmployeeRewardHandler contractualEmployeeRewardHandler = null;


	protected void Page_Load(object sender, EventArgs e)
	{
		lblResult.Text = string.Empty;

		contractualEmployeeRewardHandler = new ContractualEmployeeRewardHandler();
		if (IsPostBack == false)
		{
			BindData();
		}
	}

	private void BindData()
	{
		GridView1.DataSource = contractualEmployeeRewardHandler.GetListAll();
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
		Label lblNationalCode = GridView1.Rows[e.RowIndex].FindControl("lblNationalCode") as Label;
		Label lblTotalReward = GridView1.Rows[e.RowIndex].FindControl("lblTotalReward") as Label;
		Label lblReward_ = GridView1.Rows[e.RowIndex].FindControl("lblReward_") as Label;
		Label lblEmployeeFullName = GridView1.Rows[e.RowIndex].FindControl("lblEmployeeFullName") as Label;
		Label lblDepartmentIDTitle = GridView1.Rows[e.RowIndex].FindControl("lblDepartmentIDTitle") as Label;
		Label lblYearTypeIDTitle = GridView1.Rows[e.RowIndex].FindControl("lblYearTypeIDTitle") as Label;
		Label lblMonthTypeIDTitle = GridView1.Rows[e.RowIndex].FindControl("lblMonthTypeIDTitle") as Label;
		TextBox txtReward = GridView1.Rows[e.RowIndex].FindControl("txtReward") as TextBox;
		TextBox txtBossFinalValue = GridView1.Rows[e.RowIndex].FindControl("txtBossFinalValue") as TextBox;
		TextBox txtAssistantFinalValue = GridView1.Rows[e.RowIndex].FindControl("txtAssistantFinalValue") as TextBox;
		TextBox txtManagerFinalValue = GridView1.Rows[e.RowIndex].FindControl("txtManagerFinalValue") as TextBox;
		TextBox txtExtraReward1 = GridView1.Rows[e.RowIndex].FindControl("txtExtraReward1") as TextBox;
		TextBox txtExtraReward2 = GridView1.Rows[e.RowIndex].FindControl("txtExtraReward2") as TextBox;
		TextBox txtExtraReward3 = GridView1.Rows[e.RowIndex].FindControl("txtExtraReward3") as TextBox;


		if (lblYearTypeID != null && lblMonthTypeID != null && lblNationalCode != null && lblTotalReward != null && lblReward_ != null && lblEmployeeFullName != null && lblDepartmentIDTitle != null && lblYearTypeIDTitle != null && lblMonthTypeIDTitle != null && txtReward != null && txtBossFinalValue != null && txtAssistantFinalValue != null && txtManagerFinalValue != null && txtExtraReward1 != null && txtExtraReward2 != null && txtExtraReward3 != null) 
		{
			ContractualEmployeeReward contractualEmployeeReward = new ContractualEmployeeReward();

			contractualEmployeeReward.YearTypeID = Convert.ToInt32(lblYearTypeID.Text.Trim());
			contractualEmployeeReward.MonthTypeID = Convert.ToInt32(lblMonthTypeID.Text.Trim());
			contractualEmployeeReward.NationalCode = Convert.ToInt64(lblNationalCode.Text.Trim());
			contractualEmployeeReward.TotalReward = Convert.ToInt64(lblTotalReward.Text.Trim());
			contractualEmployeeReward.Reward_ = Convert.ToInt64(lblReward_.Text.Trim());
			contractualEmployeeReward.EmployeeFullName = lblEmployeeFullName.Text;
			contractualEmployeeReward.DepartmentIDTitle = lblDepartmentIDTitle.Text;
			contractualEmployeeReward.YearTypeIDTitle = lblYearTypeIDTitle.Text;
			contractualEmployeeReward.MonthTypeIDTitle = lblMonthTypeIDTitle.Text;
			contractualEmployeeReward.Reward = Convert.ToInt64(txtReward.Text.Trim());
			contractualEmployeeReward.BossFinalValue = Convert.ToInt64(txtBossFinalValue.Text.Trim());
			contractualEmployeeReward.AssistantFinalValue = Convert.ToInt64(txtAssistantFinalValue.Text.Trim());
			contractualEmployeeReward.ManagerFinalValue = Convert.ToInt64(txtManagerFinalValue.Text.Trim());
			contractualEmployeeReward.ExtraReward1 = Convert.ToInt64(txtExtraReward1.Text.Trim());
			contractualEmployeeReward.ExtraReward2 = Convert.ToInt64(txtExtraReward2.Text.Trim());
			contractualEmployeeReward.ExtraReward3 = Convert.ToInt64(txtExtraReward3.Text.Trim());

			//Let us now update the database
			if (contractualEmployeeRewardHandler.Update(contractualEmployeeReward) == true)
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
		Response.Redirect("Z_ContractualEmployeeRewardAdd.aspx");
	}
}
