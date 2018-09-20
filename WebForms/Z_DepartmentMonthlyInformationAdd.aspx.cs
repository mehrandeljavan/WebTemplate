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

public partial class WebForms_Z_DepartmentMonthlyInformationAdd : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
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
		MonthTypeHandler monthTypeHandler = new MonthTypeHandler();
		List <MonthType> monthTypeList = monthTypeHandler.GetListAll();
		DataTable monthTypeTable = new DataTable();
		monthTypeTable.Columns.Add("MonthTypeID");
		
		if (monthTypeList != null)
			foreach (MonthType monthType in monthTypeList)
				monthTypeTable.Rows.Add(monthType.MonthTypeID);

		if(!IsPostBack)
		{
			ddlMonthTypeID.DataSource = monthTypeTable;
			ddlMonthTypeID.DataTextField = "MonthTypeID";
			ddlMonthTypeID.DataValueField = "MonthTypeID";
			ddlMonthTypeID.DataBind();
		}
		YearTypeHandler yearTypeHandler = new YearTypeHandler();
		List <YearType> yearTypeList = yearTypeHandler.GetListAll();
		DataTable yearTypeTable = new DataTable();
		yearTypeTable.Columns.Add("YearTypeID");
		
		if (yearTypeList != null)
			foreach (YearType yearType in yearTypeList)
				yearTypeTable.Rows.Add(yearType.YearTypeID);

		if(!IsPostBack)
		{
			ddlYearTypeID.DataSource = yearTypeTable;
			ddlYearTypeID.DataTextField = "YearTypeID";
			ddlYearTypeID.DataValueField = "YearTypeID";
			ddlYearTypeID.DataBind();
		}
	}

	protected void btnYES_Click(object sender, EventArgs e)
	{
		DepartmentMonthlyInformation departmentMonthlyInformation = new DepartmentMonthlyInformation();

		departmentMonthlyInformation.YearTypeID = Convert.ToInt32(ddlYearTypeID.SelectedValue);
		departmentMonthlyInformation.MonthTypeID = Convert.ToInt32(ddlMonthTypeID.SelectedValue);
		departmentMonthlyInformation.DepartmentID = Convert.ToInt32(ddlDepartmentID.SelectedValue);
		departmentMonthlyInformation.RewardPerEmployee = Convert.ToInt64(txtRewardPerEmployee.Text);
		departmentMonthlyInformation.OperationalRewardCalculated = Convert.ToInt64(txtOperationalRewardCalculated.Text);
		departmentMonthlyInformation.OperationalReward = Convert.ToInt64(txtOperationalReward.Text);
		departmentMonthlyInformation.OrganizationalRewardCalculated = Convert.ToInt64(txtOrganizationalRewardCalculated.Text);
		departmentMonthlyInformation.OrganizationalReward = Convert.ToInt64(txtOrganizationalReward.Text);
		departmentMonthlyInformation.MonthlyProceed = Convert.ToInt64(txtMonthlyProceed.Text);
		departmentMonthlyInformation.DesiredMonthlyProceed = Convert.ToInt64(txtDesiredMonthlyProceed.Text);
		departmentMonthlyInformation.LastYearProceed = Convert.ToInt64(txtLastYearProceed.Text);
		departmentMonthlyInformation.DossierNumber = Convert.ToInt32(txtDossierNumber.Text);
		departmentMonthlyInformation.Value3 = Convert.ToInt32(txtValue3.Text);
		departmentMonthlyInformation.Value4 = Convert.ToInt32(txtValue4.Text);
		departmentMonthlyInformation.Value5 = Convert.ToInt32(txtValue5.Text);
		departmentMonthlyInformation.Value6 = Convert.ToInt32(txtValue6.Text);
		departmentMonthlyInformation.EmployeeNumber = Convert.ToInt32(txtEmployeeNumber.Text);
		departmentMonthlyInformation.ContractualEmployeeNumber = Convert.ToInt32(txtContractualEmployeeNumber.Text);

		DepartmentMonthlyInformationHandler departmentMonthlyInformationHandler = new DepartmentMonthlyInformationHandler();

		if (departmentMonthlyInformationHandler.Insert(departmentMonthlyInformation) > 0)
		{
			Response.Redirect("Z_DepartmentMonthlyInformationDefault.aspx");
		}
	}

	protected void btnNO_Click(object sender, EventArgs e)
	{
		Response.Redirect("Z_DepartmentMonthlyInformationDefault.aspx");
	}
}
