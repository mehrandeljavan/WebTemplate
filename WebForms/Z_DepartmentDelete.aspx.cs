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

public partial class WebForms_Z_DepartmentDelete : System.Web.UI.Page
{
	DepartmentHandler departmentHandler = null;
	int departmentDepartmentID;

	protected void Page_Load(object sender, EventArgs e)
	{
		string departmentID = Request.QueryString["departmentID"] as string;
		if (departmentID == null)
			Response.Redirect("Z_DepartmentDefault.aspx");

		try
		{
			departmentDepartmentID = Convert.ToInt32(departmentID.Trim());
			departmentHandler = new DepartmentHandler();

			Department department = departmentHandler.GetDetails(departmentDepartmentID);

			lblDepartmentID.Text = department.DepartmentID.ToString();
			lblDividerFullName.Text = department.DividerFullName.ToString();
			lblComputationTypeIDTitle.Text = department.ComputationTypeIDTitle.ToString();
			lblMainOfficeTypeIDTitle.Text = department.MainOfficeTypeIDTitle.ToString();
			lblAdjutancyTypeIDTitle.Text = department.AdjutancyTypeIDTitle.ToString();
			lblComputationTypeID.Text = department.ComputationTypeID.ToString();
			lblMainOfficeTypeID.Text = department.MainOfficeTypeID.ToString();
			lblAdjutancyTypeID.Text = department.AdjutancyTypeID.ToString();
			lblTotalEmployeeNumber.Text = department.TotalEmployeeNumber.ToString();
			lblTotalContractualEmployeeNumber.Text = department.TotalContractualEmployeeNumber.ToString();
			lblTotalPersonalScore.Text = department.TotalPersonalScore.ToString();
			lblDividerNationalCode.Text = department.DividerNationalCode.ToString();
			lblTitle.Text = department.Title.ToString();
		}
		catch (Exception)
		{
			Response.Redirect("Z_DepartmentDefault.aspx");
		}
	}
	protected void btnNO_Click(object sender, EventArgs e)
	{
		Response.Redirect("Z_DepartmentDefault.aspx");
	}

	protected void btnYES_Click(object sender, EventArgs e)
	{
		if (departmentHandler.Delete(departmentDepartmentID))
			Response.Redirect("Z_DepartmentDefault.aspx");
	}
}
