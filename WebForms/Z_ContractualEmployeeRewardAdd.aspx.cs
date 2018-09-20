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

public partial class WebForms_Z_ContractualEmployeeRewardAdd : System.Web.UI.Page
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
		ContractualEmployeeReward contractualEmployeeReward = new ContractualEmployeeReward();

		contractualEmployeeReward.YearTypeID = Convert.ToInt32(ddlYearTypeID.SelectedValue);
		contractualEmployeeReward.MonthTypeID = Convert.ToInt32(ddlMonthTypeID.SelectedValue);
		contractualEmployeeReward.NationalCode = Convert.ToInt64(ddlNationalCode.SelectedValue);
		contractualEmployeeReward.Reward = Convert.ToInt64(txtReward.Text);
		contractualEmployeeReward.BossFinalValue = Convert.ToInt64(txtBossFinalValue.Text);
		contractualEmployeeReward.AssistantFinalValue = Convert.ToInt64(txtAssistantFinalValue.Text);
		contractualEmployeeReward.ManagerFinalValue = Convert.ToInt64(txtManagerFinalValue.Text);
		contractualEmployeeReward.ExtraReward1 = Convert.ToInt64(txtExtraReward1.Text);
		contractualEmployeeReward.ExtraReward2 = Convert.ToInt64(txtExtraReward2.Text);
		contractualEmployeeReward.ExtraReward3 = Convert.ToInt64(txtExtraReward3.Text);

		ContractualEmployeeRewardHandler contractualEmployeeRewardHandler = new ContractualEmployeeRewardHandler();

		if (contractualEmployeeRewardHandler.Insert(contractualEmployeeReward) > 0)
		{
			Response.Redirect("Z_ContractualEmployeeRewardDefault.aspx");
		}
	}

	protected void btnNO_Click(object sender, EventArgs e)
	{
		Response.Redirect("Z_ContractualEmployeeRewardDefault.aspx");
	}
}
