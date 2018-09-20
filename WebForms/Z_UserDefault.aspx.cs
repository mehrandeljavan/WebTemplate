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

public partial class WebForms_Z_UserDefault : System.Web.UI.Page
{
	UserHandler userHandler = null;


	protected void Page_Load(object sender, EventArgs e)
	{
		lblResult.Text = string.Empty;

		userHandler = new UserHandler();
		if (IsPostBack == false)
		{
			BindData();
		}
	}

	private void BindData()
	{
		GridView1.DataSource = userHandler.GetListAll();
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
		TextBox txtPassword = GridView1.Rows[e.RowIndex].FindControl("txtPassword") as TextBox;
		TextBox txtLastPassChangeDate = GridView1.Rows[e.RowIndex].FindControl("txtLastPassChangeDate") as TextBox;
		TextBox txtIsActiveUser = GridView1.Rows[e.RowIndex].FindControl("txtIsActiveUser") as TextBox;


		if (lblNationalCode != null && txtPassword != null && txtLastPassChangeDate != null && txtIsActiveUser != null) 
		{
			User user = new User();

			user.NationalCode = Convert.ToInt64(lblNationalCode.Text.Trim());
			user.Password = txtPassword.Text;
			user.LastPassChangeDate = txtLastPassChangeDate.Text;

			//Let us now update the database
			if (userHandler.Update(user) == true)
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
		Response.Redirect("Z_UserAdd.aspx");
	}
}
