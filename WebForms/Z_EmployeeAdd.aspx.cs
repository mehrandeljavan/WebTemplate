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

public partial class WebForms_Z_EmployeeAdd : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		ContractTypeHandler contractTypeHandler = new ContractTypeHandler();
		List <ContractType> contractTypeList = contractTypeHandler.GetListAll();
		DataTable contractTypeTable = new DataTable();
		contractTypeTable.Columns.Add("ContractTypeID");
		
		if (contractTypeList != null)
			foreach (ContractType contractType in contractTypeList)
				contractTypeTable.Rows.Add(contractType.ContractTypeID);

		if(!IsPostBack)
		{
			ddlContractTypeID.DataSource = contractTypeTable;
			ddlContractTypeID.DataTextField = "ContractTypeID";
			ddlContractTypeID.DataValueField = "ContractTypeID";
			ddlContractTypeID.DataBind();
		}
		DepartmentHandler departmentHandler = new DepartmentHandler();
		List <Department> departmentList = departmentHandler.GetListAll();
		DataTable departmentTable = new DataTable();
		departmentTable.Columns.Add("DepartmentID");
		
		if (departmentList != null)
			foreach (Department department in departmentList)
				departmentTable.Rows.Add(department.DepartmentID);

		if(!IsPostBack)
		{
			ddlDepartmentID.DataSource = departmentTable;
			ddlDepartmentID.DataTextField = "DepartmentID";
			ddlDepartmentID.DataValueField = "DepartmentID";
			ddlDepartmentID.DataBind();
		}
		RoleTypeHandler roleTypeHandler = new RoleTypeHandler();
		List <RoleType> roleTypeList = roleTypeHandler.GetListAll();
		DataTable roleTypeTable = new DataTable();
		roleTypeTable.Columns.Add("RoleTypeID");
		
		if (roleTypeList != null)
			foreach (RoleType roleType in roleTypeList)
				roleTypeTable.Rows.Add(roleType.RoleTypeID);

		if(!IsPostBack)
		{
			ddlRoleTypeID.DataSource = roleTypeTable;
			ddlRoleTypeID.DataTextField = "RoleTypeID";
			ddlRoleTypeID.DataValueField = "RoleTypeID";
			ddlRoleTypeID.DataBind();
		}
	}

	protected void btnYES_Click(object sender, EventArgs e)
	{
		Employee employee = new Employee();

		employee.NationalCode = Convert.ToInt64(txtNationalCode.Text);
		employee.PersonalCode = txtPersonalCode.Text;
		employee.FirstName = txtFirstName.Text;
		employee.LastName = txtLastName.Text;
		employee.AccountNumber = txtAccountNumber.Text;
		employee.ContractTypeID = Convert.ToInt32(ddlContractTypeID.SelectedValue);
		employee.RoleTypeID = Convert.ToInt32(ddlRoleTypeID.SelectedValue);
		employee.DepartmentID = Convert.ToInt32(ddlDepartmentID.SelectedValue);

		EmployeeHandler employeeHandler = new EmployeeHandler();

		if (employeeHandler.Insert(employee) > 0)
		{
			Response.Redirect("Z_EmployeeDefault.aspx");
		}
	}

	protected void btnNO_Click(object sender, EventArgs e)
	{
		Response.Redirect("Z_EmployeeDefault.aspx");
	}
}
