using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using Rewards;
using Rewards.Models;

public partial class WebForms_Z_EmployeeDelete : System.Web.UI.Page
{
	EmployeeHandler employeeHandler = null;
	Int64 employeeNationalCode;

	protected void Page_Load(object sender, EventArgs e)
	{
		string nationalCode = Request.QueryString["nationalCode"] as string;
		if (nationalCode == null)
			Response.Redirect("Z_EmployeeDefault.aspx");

		try
		{
			employeeNationalCode = Convert.ToInt64(nationalCode.Trim());
			employeeHandler = new EmployeeHandler();

			Employee employee = employeeHandler.GetDetails(employeeNationalCode);

			lblNationalCode.Text = employee.NationalCode.ToString();
			lblContractTypeIDTitle.Text = employee.ContractTypeIDTitle.ToString();
			lblRoleTypeIDTitle.Text = employee.RoleTypeIDTitle.ToString();
			lblFullName.Text = employee.FullName.ToString();
			lblDepartmentIDTitle.Text = employee.DepartmentIDTitle.ToString();
			lblRoleTypeIDFactor.Text = employee.RoleTypeIDFactor.ToString();
			lblPersonalCode.Text = employee.PersonalCode.ToString();
			lblFirstName.Text = employee.FirstName.ToString();
			lblLastName.Text = employee.LastName.ToString();
			lblAccountNumber.Text = employee.AccountNumber.ToString();
			lblContractTypeID.Text = employee.ContractTypeID.ToString();
			lblRoleTypeID.Text = employee.RoleTypeID.ToString();
			lblDepartmentID.Text = employee.DepartmentID.ToString();
			lblIsActiveEmployee.Text = employee.IsActiveEmployee.ToString();
		}
		catch (Exception)
		{
			Response.Redirect("Z_EmployeeDefault.aspx");
		}
	}
	protected void btnNO_Click(object sender, EventArgs e)
	{
		Response.Redirect("Z_EmployeeDefault.aspx");
	}

	protected void btnYES_Click(object sender, EventArgs e)
	{
		if (employeeHandler.Delete(employeeNationalCode))
			Response.Redirect("Z_EmployeeDefault.aspx");
	}
}
