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

public partial class WebForms_Z_RoleTypeDefault : System.Web.UI.Page
{
	RoleTypeHandler roleTypeHandler = null;


	protected void Page_Load(object sender, EventArgs e)
	{
		lblResult.Text = string.Empty;

		roleTypeHandler = new RoleTypeHandler();
		if (IsPostBack == false)
		{
			BindData();
		}
	}

	private void BindData()
	{
		GridView1.DataSource = roleTypeHandler.GetListAll();
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

		Label lblRoleTypeID = GridView1.Rows[e.RowIndex].FindControl("lblRoleTypeID") as Label;
		TextBox txtFactor = GridView1.Rows[e.RowIndex].FindControl("txtFactor") as TextBox;
		TextBox txtTitle = GridView1.Rows[e.RowIndex].FindControl("txtTitle") as TextBox;


		if (lblRoleTypeID != null && txtFactor != null && txtTitle != null) 
		{
			RoleType roleType = new RoleType();

			roleType.RoleTypeID = Convert.ToInt32(lblRoleTypeID.Text.Trim());
			roleType.Title = txtTitle.Text;

			//Let us now update the database
			if (roleTypeHandler.Update(roleType) == true)
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
		Response.Redirect("Z_RoleTypeAdd.aspx");
	}
}
