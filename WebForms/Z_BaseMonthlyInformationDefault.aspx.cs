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

public partial class WebForms_Z_BaseMonthlyInformationDefault : System.Web.UI.Page
{
	BaseMonthlyInformationHandler baseMonthlyInformationHandler = null;


	protected void Page_Load(object sender, EventArgs e)
	{
		lblResult.Text = string.Empty;

		baseMonthlyInformationHandler = new BaseMonthlyInformationHandler();
		if (IsPostBack == false)
		{
			BindData();
		}
	}

	private void BindData()
	{
		GridView1.DataSource = baseMonthlyInformationHandler.GetListAll();
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
		Label lblMainOfficeTypeID = GridView1.Rows[e.RowIndex].FindControl("lblMainOfficeTypeID") as Label;
		Label lblValueToScore = GridView1.Rows[e.RowIndex].FindControl("lblValueToScore") as Label;
		Label lblTotalOperationalReward = GridView1.Rows[e.RowIndex].FindControl("lblTotalOperationalReward") as Label;
		Label lblTotalOrganizationalReward = GridView1.Rows[e.RowIndex].FindControl("lblTotalOrganizationalReward") as Label;
		Label lblContractualDividableReward = GridView1.Rows[e.RowIndex].FindControl("lblContractualDividableReward") as Label;
		Label lblContractualBossReward = GridView1.Rows[e.RowIndex].FindControl("lblContractualBossReward") as Label;
		Label lblContractualDevotedReward = GridView1.Rows[e.RowIndex].FindControl("lblContractualDevotedReward") as Label;
		Label lblContractualRemainingReward = GridView1.Rows[e.RowIndex].FindControl("lblContractualRemainingReward") as Label;
		Label lblDividableReward = GridView1.Rows[e.RowIndex].FindControl("lblDividableReward") as Label;
		Label lblBossReward = GridView1.Rows[e.RowIndex].FindControl("lblBossReward") as Label;
		Label lblDevotedReward = GridView1.Rows[e.RowIndex].FindControl("lblDevotedReward") as Label;
		Label lblRemainingReward = GridView1.Rows[e.RowIndex].FindControl("lblRemainingReward") as Label;
		Label lblYearTypeIDTitle = GridView1.Rows[e.RowIndex].FindControl("lblYearTypeIDTitle") as Label;
		Label lblMonthTypeIDTitle = GridView1.Rows[e.RowIndex].FindControl("lblMonthTypeIDTitle") as Label;
		TextBox txtContractualReward = GridView1.Rows[e.RowIndex].FindControl("txtContractualReward") as TextBox;
		TextBox txtContractualConstantReward = GridView1.Rows[e.RowIndex].FindControl("txtContractualConstantReward") as TextBox;
		TextBox txtExtraReward = GridView1.Rows[e.RowIndex].FindControl("txtExtraReward") as TextBox;
		TextBox txtFactor5 = GridView1.Rows[e.RowIndex].FindControl("txtFactor5") as TextBox;
		TextBox txtFactor6 = GridView1.Rows[e.RowIndex].FindControl("txtFactor6") as TextBox;
		TextBox txtFactor7 = GridView1.Rows[e.RowIndex].FindControl("txtFactor7") as TextBox;
		TextBox txtFactor8 = GridView1.Rows[e.RowIndex].FindControl("txtFactor8") as TextBox;
		TextBox txtFactor9 = GridView1.Rows[e.RowIndex].FindControl("txtFactor9") as TextBox;
		TextBox txtFactor10 = GridView1.Rows[e.RowIndex].FindControl("txtFactor10") as TextBox;
		TextBox txtOfficialReward = GridView1.Rows[e.RowIndex].FindControl("txtOfficialReward") as TextBox;
		TextBox txtIsFanalized = GridView1.Rows[e.RowIndex].FindControl("txtIsFanalized") as TextBox;
		TextBox txtIsFainalizedEmployeesInformation = GridView1.Rows[e.RowIndex].FindControl("txtIsFainalizedEmployeesInformation") as TextBox;
		TextBox txtIsFainalizedRewardCalculation = GridView1.Rows[e.RowIndex].FindControl("txtIsFainalizedRewardCalculation") as TextBox;
		TextBox txtBossFactor = GridView1.Rows[e.RowIndex].FindControl("txtBossFactor") as TextBox;
		TextBox txtOperationalFactor = GridView1.Rows[e.RowIndex].FindControl("txtOperationalFactor") as TextBox;
		TextBox txtFactor1 = GridView1.Rows[e.RowIndex].FindControl("txtFactor1") as TextBox;
		TextBox txtFactor2 = GridView1.Rows[e.RowIndex].FindControl("txtFactor2") as TextBox;
		TextBox txtFactor3 = GridView1.Rows[e.RowIndex].FindControl("txtFactor3") as TextBox;
		TextBox txtFactor4 = GridView1.Rows[e.RowIndex].FindControl("txtFactor4") as TextBox;


		if (lblYearTypeID != null && lblMonthTypeID != null && lblMainOfficeTypeID != null && lblValueToScore != null && lblTotalOperationalReward != null && lblTotalOrganizationalReward != null && lblContractualDividableReward != null && lblContractualBossReward != null && lblContractualDevotedReward != null && lblContractualRemainingReward != null && lblDividableReward != null && lblBossReward != null && lblDevotedReward != null && lblRemainingReward != null && lblYearTypeIDTitle != null && lblMonthTypeIDTitle != null && txtContractualReward != null && txtContractualConstantReward != null && txtExtraReward != null && txtFactor5 != null && txtFactor6 != null && txtFactor7 != null && txtFactor8 != null && txtFactor9 != null && txtFactor10 != null && txtOfficialReward != null && txtIsFanalized != null && txtIsFainalizedEmployeesInformation != null && txtIsFainalizedRewardCalculation != null && txtBossFactor != null && txtOperationalFactor != null && txtFactor1 != null && txtFactor2 != null && txtFactor3 != null && txtFactor4 != null) 
		{
			BaseMonthlyInformation baseMonthlyInformation = new BaseMonthlyInformation();

			baseMonthlyInformation.YearTypeID = Convert.ToInt32(lblYearTypeID.Text.Trim());
			baseMonthlyInformation.MonthTypeID = Convert.ToInt32(lblMonthTypeID.Text.Trim());
			baseMonthlyInformation.MainOfficeTypeID = Convert.ToInt32(lblMainOfficeTypeID.Text.Trim());
			baseMonthlyInformation.TotalOperationalReward = Convert.ToInt64(lblTotalOperationalReward.Text.Trim());
			baseMonthlyInformation.TotalOrganizationalReward = Convert.ToInt64(lblTotalOrganizationalReward.Text.Trim());
			baseMonthlyInformation.ContractualDividableReward = Convert.ToInt64(lblContractualDividableReward.Text.Trim());
			baseMonthlyInformation.ContractualBossReward = Convert.ToInt64(lblContractualBossReward.Text.Trim());
			baseMonthlyInformation.ContractualDevotedReward = Convert.ToInt64(lblContractualDevotedReward.Text.Trim());
			baseMonthlyInformation.ContractualRemainingReward = Convert.ToInt64(lblContractualRemainingReward.Text.Trim());
			baseMonthlyInformation.DividableReward = Convert.ToInt64(lblDividableReward.Text.Trim());
			baseMonthlyInformation.BossReward = Convert.ToInt64(lblBossReward.Text.Trim());
			baseMonthlyInformation.DevotedReward = Convert.ToInt64(lblDevotedReward.Text.Trim());
			baseMonthlyInformation.RemainingReward = Convert.ToInt64(lblRemainingReward.Text.Trim());
			baseMonthlyInformation.YearTypeIDTitle = lblYearTypeIDTitle.Text;
			baseMonthlyInformation.MonthTypeIDTitle = lblMonthTypeIDTitle.Text;
			baseMonthlyInformation.ContractualReward = Convert.ToInt64(txtContractualReward.Text.Trim());
			baseMonthlyInformation.ContractualConstantReward = Convert.ToInt64(txtContractualConstantReward.Text.Trim());
			baseMonthlyInformation.ExtraReward = Convert.ToInt64(txtExtraReward.Text.Trim());
			baseMonthlyInformation.OfficialReward = Convert.ToInt64(txtOfficialReward.Text.Trim());

			//Let us now update the database
			if (baseMonthlyInformationHandler.Update(baseMonthlyInformation) == true)
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
		Response.Redirect("Z_BaseMonthlyInformationAdd.aspx");
	}
}
