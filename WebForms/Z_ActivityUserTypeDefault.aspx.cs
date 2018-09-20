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

public partial class WebForms_Z_ActivityUserTypeDefault : System.Web.UI.Page
{
	ActivityUserTypeHandler activityUserTypeHandler = null;


	protected void Page_Load(object sender, EventArgs e)
	{
		lblResult.Text = string.Empty;

		activityUserTypeHandler = new ActivityUserTypeHandler();
		if (IsPostBack == false)
		{
			BindData();
		}
	}

	private void BindData()
	{
		GridView1.DataSource = activityUserTypeHandler.GetListAll();
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

		Label lblActivityTypeID = GridView1.Rows[e.RowIndex].FindControl("lblActivityTypeID") as Label;
		Label lblUserTypeID = GridView1.Rows[e.RowIndex].FindControl("lblUserTypeID") as Label;
		Label lblActivityTypeIDTitle = GridView1.Rows[e.RowIndex].FindControl("lblActivityTypeIDTitle") as Label;
		Label lblUserTypeIDTitle = GridView1.Rows[e.RowIndex].FindControl("lblUserTypeIDTitle") as Label;


		if (lblActivityTypeID != null && lblUserTypeID != null && lblActivityTypeIDTitle != null && lblUserTypeIDTitle != null) 
		{
			ActivityUserType activityUserType = new ActivityUserType();

			activityUserType.ActivityTypeID = Convert.ToInt32(lblActivityTypeID.Text.Trim());
			activityUserType.UserTypeID = Convert.ToInt32(lblUserTypeID.Text.Trim());
			activityUserType.ActivityTypeIDTitle = lblActivityTypeIDTitle.Text;
			activityUserType.UserTypeIDTitle = lblUserTypeIDTitle.Text;

			//Let us now update the database
			if (activityUserTypeHandler.Update(activityUserType) == true)
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
		Response.Redirect("Z_ActivityUserTypeAdd.aspx");
	}
}
