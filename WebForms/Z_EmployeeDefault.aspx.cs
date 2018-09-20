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

public partial class WebForms_Z_EmployeeDefault : System.Web.UI.Page
{
	EmployeeHandler employeeHandler = null;


	protected void Page_Load(object sender, EventArgs e)
	{
		lblResult.Text = string.Empty;

		employeeHandler = new EmployeeHandler();
		if (IsPostBack == false)
		{
			BindData();
		}
	}

	private void BindData()
	{
		GridView1.DataSource = employeeHandler.GetListAll();
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
		Label lblContractTypeIDTitle = GridView1.Rows[e.RowIndex].FindControl("lblContractTypeIDTitle") as Label;
		Label lblRoleTypeIDTitle = GridView1.Rows[e.RowIndex].FindControl("lblRoleTypeIDTitle") as Label;
		Label lblFullName = GridView1.Rows[e.RowIndex].FindControl("lblFullName") as Label;
		Label lblDepartmentIDTitle = GridView1.Rows[e.RowIndex].FindControl("lblDepartmentIDTitle") as Label;
		Label lblRoleTypeIDFactor = GridView1.Rows[e.RowIndex].FindControl("lblRoleTypeIDFactor") as Label;
		TextBox txtPersonalCode = GridView1.Rows[e.RowIndex].FindControl("txtPersonalCode") as TextBox;
		TextBox txtFirstName = GridView1.Rows[e.RowIndex].FindControl("txtFirstName") as TextBox;
		TextBox txtLastName = GridView1.Rows[e.RowIndex].FindControl("txtLastName") as TextBox;
		TextBox txtAccountNumber = GridView1.Rows[e.RowIndex].FindControl("txtAccountNumber") as TextBox;
		TextBox txtContractTypeID = GridView1.Rows[e.RowIndex].FindControl("txtContractTypeID") as TextBox;
		TextBox txtRoleTypeID = GridView1.Rows[e.RowIndex].FindControl("txtRoleTypeID") as TextBox;
		TextBox txtDepartmentID = GridView1.Rows[e.RowIndex].FindControl("txtDepartmentID") as TextBox;
		TextBox txtIsActiveEmployee = GridView1.Rows[e.RowIndex].FindControl("txtIsActiveEmployee") as TextBox;


		if (lblNationalCode != null && lblContractTypeIDTitle != null && lblRoleTypeIDTitle != null && lblFullName != null && lblDepartmentIDTitle != null && lblRoleTypeIDFactor != null && txtPersonalCode != null && txtFirstName != null && txtLastName != null && txtAccountNumber != null && txtContractTypeID != null && txtRoleTypeID != null && txtDepartmentID != null && txtIsActiveEmployee != null) 
		{
			Employee employee = new Employee();

			employee.NationalCode = Convert.ToInt64(lblNationalCode.Text.Trim());
			employee.ContractTypeIDTitle = lblContractTypeIDTitle.Text;
			employee.RoleTypeIDTitle = lblRoleTypeIDTitle.Text;
			employee.FullName = lblFullName.Text;
			employee.DepartmentIDTitle = lblDepartmentIDTitle.Text;
			employee.PersonalCode = txtPersonalCode.Text;
			employee.FirstName = txtFirstName.Text;
			employee.LastName = txtLastName.Text;
			employee.AccountNumber = txtAccountNumber.Text;
			employee.ContractTypeID = Convert.ToInt32(txtContractTypeID.Text.Trim());
			employee.RoleTypeID = Convert.ToInt32(txtRoleTypeID.Text.Trim());
			employee.DepartmentID = Convert.ToInt32(txtDepartmentID.Text.Trim());

			//Let us now update the database
			if (employeeHandler.Update(employee) == true)
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
		Response.Redirect("Z_EmployeeAdd.aspx");
	}
}
