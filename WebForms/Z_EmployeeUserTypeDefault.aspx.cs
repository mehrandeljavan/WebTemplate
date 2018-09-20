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

public partial class WebForms_Z_EmployeeUserTypeDefault : System.Web.UI.Page
{
	EmployeeUserTypeHandler employeeUserTypeHandler = null;


	protected void Page_Load(object sender, EventArgs e)
	{
		lblResult.Text = string.Empty;

		employeeUserTypeHandler = new EmployeeUserTypeHandler();
		if (IsPostBack == false)
		{
			BindData();
		}
	}

	private void BindData()
	{
		GridView1.DataSource = employeeUserTypeHandler.GetListAll();
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

		Label lblUserTypeID = GridView1.Rows[e.RowIndex].FindControl("lblUserTypeID") as Label;
		Label lblNationalCode = GridView1.Rows[e.RowIndex].FindControl("lblNationalCode") as Label;
		Label lblEmployeeFullName = GridView1.Rows[e.RowIndex].FindControl("lblEmployeeFullName") as Label;
		Label lblUserTypeIDTitle = GridView1.Rows[e.RowIndex].FindControl("lblUserTypeIDTitle") as Label;


		if (lblUserTypeID != null && lblNationalCode != null && lblEmployeeFullName != null && lblUserTypeIDTitle != null) 
		{
			EmployeeUserType employeeUserType = new EmployeeUserType();

			employeeUserType.UserTypeID = Convert.ToInt32(lblUserTypeID.Text.Trim());
			employeeUserType.NationalCode = Convert.ToInt64(lblNationalCode.Text.Trim());
			employeeUserType.EmployeeFullName = lblEmployeeFullName.Text;
			employeeUserType.UserTypeIDTitle = lblUserTypeIDTitle.Text;

			//Let us now update the database
			if (employeeUserTypeHandler.Update(employeeUserType) == true)
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
		Response.Redirect("Z_EmployeeUserTypeAdd.aspx");
	}
}
