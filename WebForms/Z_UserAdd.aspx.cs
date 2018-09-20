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

public partial class WebForms_Z_UserAdd : System.Web.UI.Page
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
	}

	protected void btnYES_Click(object sender, EventArgs e)
	{
		User user = new User();

		user.NationalCode = Convert.ToInt64(ddlNationalCode.SelectedValue);
		user.Password = txtPassword.Text;
		user.LastPassChangeDate = txtLastPassChangeDate.Text;

		UserHandler userHandler = new UserHandler();

		if (userHandler.Insert(user) > 0)
		{
			Response.Redirect("Z_UserDefault.aspx");
		}
	}

	protected void btnNO_Click(object sender, EventArgs e)
	{
		Response.Redirect("Z_UserDefault.aspx");
	}
}
