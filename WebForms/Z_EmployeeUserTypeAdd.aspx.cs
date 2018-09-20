using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Rewards;
using Rewards.Models;

public partial class WebForms_Z_EmployeeUserTypeAdd : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		EmployeeHandler employeeHandler = new EmployeeHandler();
		List <Employee> employeeList = employeeHandler.GetListAll();
		DataTable employeeTable = new DataTable();
		employeeTable.Columns.Add("NationalCode");
		
		if (employeeList != null)
			foreach (Employee employee in employeeList)
				employeeTable.Rows.Add(employee.NationalCode);

		if(!IsPostBack)
		{
			ddlNationalCode.DataSource = employeeTable;
			ddlNationalCode.DataTextField = "NationalCode";
			ddlNationalCode.DataValueField = "NationalCode";
			ddlNationalCode.DataBind();
		}
		UserTypeHandler userTypeHandler = new UserTypeHandler();
		List <UserType> userTypeList = userTypeHandler.GetListAll();
		DataTable userTypeTable = new DataTable();
		userTypeTable.Columns.Add("UserTypeID");
		
		if (userTypeList != null)
			foreach (UserType userType in userTypeList)
				userTypeTable.Rows.Add(userType.UserTypeID);

		if(!IsPostBack)
		{
			ddlUserTypeID.DataSource = userTypeTable;
			ddlUserTypeID.DataTextField = "UserTypeID";
			ddlUserTypeID.DataValueField = "UserTypeID";
			ddlUserTypeID.DataBind();
		}
	}

	protected void btnYES_Click(object sender, EventArgs e)
	{
		EmployeeUserType employeeUserType = new EmployeeUserType();

		employeeUserType.UserTypeID = Convert.ToInt32(ddlUserTypeID.SelectedValue);
		employeeUserType.NationalCode = Convert.ToInt64(ddlNationalCode.SelectedValue);

		EmployeeUserTypeHandler employeeUserTypeHandler = new EmployeeUserTypeHandler();

		if (employeeUserTypeHandler.Insert(employeeUserType) > 0)
		{
			Response.Redirect("Z_EmployeeUserTypeDefault.aspx");
		}
	}

	protected void btnNO_Click(object sender, EventArgs e)
	{
		Response.Redirect("Z_EmployeeUserTypeDefault.aspx");
	}
}
