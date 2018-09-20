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

public partial class WebForms_Z_DepartmentDefault : System.Web.UI.Page
{
	DepartmentHandler departmentHandler = null;


	protected void Page_Load(object sender, EventArgs e)
	{
		lblResult.Text = string.Empty;

		departmentHandler = new DepartmentHandler();
		if (IsPostBack == false)
		{
			BindData();
		}
	}

	private void BindData()
	{
		GridView1.DataSource = departmentHandler.GetListAll();
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

		Label lblDepartmentID = GridView1.Rows[e.RowIndex].FindControl("lblDepartmentID") as Label;
		Label lblDividerFullName = GridView1.Rows[e.RowIndex].FindControl("lblDividerFullName") as Label;
		Label lblComputationTypeIDTitle = GridView1.Rows[e.RowIndex].FindControl("lblComputationTypeIDTitle") as Label;
		Label lblMainOfficeTypeIDTitle = GridView1.Rows[e.RowIndex].FindControl("lblMainOfficeTypeIDTitle") as Label;
		Label lblAdjutancyTypeIDTitle = GridView1.Rows[e.RowIndex].FindControl("lblAdjutancyTypeIDTitle") as Label;
		TextBox txtComputationTypeID = GridView1.Rows[e.RowIndex].FindControl("txtComputationTypeID") as TextBox;
		TextBox txtMainOfficeTypeID = GridView1.Rows[e.RowIndex].FindControl("txtMainOfficeTypeID") as TextBox;
		TextBox txtAdjutancyTypeID = GridView1.Rows[e.RowIndex].FindControl("txtAdjutancyTypeID") as TextBox;
		TextBox txtTotalEmployeeNumber = GridView1.Rows[e.RowIndex].FindControl("txtTotalEmployeeNumber") as TextBox;
		TextBox txtTotalContractualEmployeeNumber = GridView1.Rows[e.RowIndex].FindControl("txtTotalContractualEmployeeNumber") as TextBox;
		TextBox txtTotalPersonalScore = GridView1.Rows[e.RowIndex].FindControl("txtTotalPersonalScore") as TextBox;
		TextBox txtDividerNationalCode = GridView1.Rows[e.RowIndex].FindControl("txtDividerNationalCode") as TextBox;
		TextBox txtTitle = GridView1.Rows[e.RowIndex].FindControl("txtTitle") as TextBox;


		if (lblDepartmentID != null && lblDividerFullName != null && lblComputationTypeIDTitle != null && lblMainOfficeTypeIDTitle != null && lblAdjutancyTypeIDTitle != null && txtComputationTypeID != null && txtMainOfficeTypeID != null && txtAdjutancyTypeID != null && txtTotalEmployeeNumber != null && txtTotalContractualEmployeeNumber != null && txtTotalPersonalScore != null && txtDividerNationalCode != null && txtTitle != null) 
		{
			Department department = new Department();

			department.DepartmentID = Convert.ToInt32(lblDepartmentID.Text.Trim());
			department.DividerFullName = lblDividerFullName.Text;
			department.ComputationTypeIDTitle = lblComputationTypeIDTitle.Text;
			department.MainOfficeTypeIDTitle = lblMainOfficeTypeIDTitle.Text;
			department.AdjutancyTypeIDTitle = lblAdjutancyTypeIDTitle.Text;
			department.ComputationTypeID = Convert.ToInt32(txtComputationTypeID.Text.Trim());
			department.MainOfficeTypeID = Convert.ToInt32(txtMainOfficeTypeID.Text.Trim());
			department.AdjutancyTypeID = Convert.ToInt32(txtAdjutancyTypeID.Text.Trim());
			department.TotalEmployeeNumber = Convert.ToInt32(txtTotalEmployeeNumber.Text.Trim());
			department.TotalContractualEmployeeNumber = Convert.ToInt32(txtTotalContractualEmployeeNumber.Text.Trim());
			department.DividerNationalCode = Convert.ToInt64(txtDividerNationalCode.Text.Trim());
			department.Title = txtTitle.Text;

			//Let us now update the database
			if (departmentHandler.Update(department) == true)
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
		Response.Redirect("Z_DepartmentAdd.aspx");
	}
}
