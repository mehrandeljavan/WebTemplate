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

public partial class WebForms_Z_EmployeeUserTypeDelete : System.Web.UI.Page
{
	EmployeeUserTypeHandler employeeUserTypeHandler = null;
	int employeeUserTypeUserTypeID;
	Int64 employeeUserTypeNationalCode;

	protected void Page_Load(object sender, EventArgs e)
	{
		string userTypeID = Request.QueryString["userTypeID"] as string;
		string nationalCode = Request.QueryString["nationalCode"] as string;
		if (userTypeID == null || nationalCode == null)
			Response.Redirect("Z_EmployeeUserTypeDefault.aspx");

		try
		{
			employeeUserTypeUserTypeID = Convert.ToInt32(userTypeID.Trim());
			employeeUserTypeNationalCode = Convert.ToInt64(nationalCode.Trim());
			employeeUserTypeHandler = new EmployeeUserTypeHandler();

			EmployeeUserType employeeUserType = employeeUserTypeHandler.GetDetails(employeeUserTypeUserTypeID , employeeUserTypeNationalCode);

			lblUserTypeID.Text = employeeUserType.UserTypeID.ToString();
			lblNationalCode.Text = employeeUserType.NationalCode.ToString();
			lblEmployeeFullName.Text = employeeUserType.EmployeeFullName.ToString();
			lblUserTypeIDTitle.Text = employeeUserType.UserTypeIDTitle.ToString();
		}
		catch (Exception)
		{
			Response.Redirect("Z_EmployeeUserTypeDefault.aspx");
		}
	}
	protected void btnNO_Click(object sender, EventArgs e)
	{
		Response.Redirect("Z_EmployeeUserTypeDefault.aspx");
	}

	protected void btnYES_Click(object sender, EventArgs e)
	{
		if (employeeUserTypeHandler.Delete(employeeUserTypeUserTypeID , employeeUserTypeNationalCode))
			Response.Redirect("Z_EmployeeUserTypeDefault.aspx");
	}
}
