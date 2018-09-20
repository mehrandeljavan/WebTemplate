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

public partial class WebForms_Z_MainOfficeTypeDefault : System.Web.UI.Page
{
	MainOfficeTypeHandler mainOfficeTypeHandler = null;


	protected void Page_Load(object sender, EventArgs e)
	{
		lblResult.Text = string.Empty;

		mainOfficeTypeHandler = new MainOfficeTypeHandler();
		if (IsPostBack == false)
		{
			BindData();
		}
	}

	private void BindData()
	{
		GridView1.DataSource = mainOfficeTypeHandler.GetListAll();
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

		Label lblMainOfficeTypeID = GridView1.Rows[e.RowIndex].FindControl("lblMainOfficeTypeID") as Label;
		Label lblContractualEmployeesNumber = GridView1.Rows[e.RowIndex].FindControl("lblContractualEmployeesNumber") as Label;
		TextBox txtTitle = GridView1.Rows[e.RowIndex].FindControl("txtTitle") as TextBox;
		TextBox txtTotalScore = GridView1.Rows[e.RowIndex].FindControl("txtTotalScore") as TextBox;
		TextBox txtTotalScoreCat1 = GridView1.Rows[e.RowIndex].FindControl("txtTotalScoreCat1") as TextBox;
		TextBox txtTotalScoreCat2 = GridView1.Rows[e.RowIndex].FindControl("txtTotalScoreCat2") as TextBox;


		if (lblMainOfficeTypeID != null && lblContractualEmployeesNumber != null && txtTitle != null && txtTotalScore != null && txtTotalScoreCat1 != null && txtTotalScoreCat2 != null) 
		{
			MainOfficeType mainOfficeType = new MainOfficeType();

			mainOfficeType.MainOfficeTypeID = Convert.ToInt32(lblMainOfficeTypeID.Text.Trim());
			mainOfficeType.ContractualEmployeesNumber = Convert.ToInt64(lblContractualEmployeesNumber.Text.Trim());
			mainOfficeType.Title = txtTitle.Text;

			//Let us now update the database
			if (mainOfficeTypeHandler.Update(mainOfficeType) == true)
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
		Response.Redirect("Z_MainOfficeTypeAdd.aspx");
	}
}
