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

public partial class WebForms_Z_BaseMonthlyInformationAdd : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		MainOfficeTypeHandler mainOfficeTypeHandler = new MainOfficeTypeHandler();
		List <MainOfficeType> mainOfficeTypeList = mainOfficeTypeHandler.GetListAll();
		DataTable mainOfficeTypeTable = new DataTable();
		mainOfficeTypeTable.Columns.Add("MainOfficeTypeID");
		
		if (mainOfficeTypeList != null)
			foreach (MainOfficeType mainOfficeType in mainOfficeTypeList)
				mainOfficeTypeTable.Rows.Add(mainOfficeType.MainOfficeTypeID);

		if(!IsPostBack)
		{
			ddlMainOfficeTypeID.DataSource = mainOfficeTypeTable;
			ddlMainOfficeTypeID.DataTextField = "MainOfficeTypeID";
			ddlMainOfficeTypeID.DataValueField = "MainOfficeTypeID";
			ddlMainOfficeTypeID.DataBind();
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
		BaseMonthlyInformation baseMonthlyInformation = new BaseMonthlyInformation();

		baseMonthlyInformation.YearTypeID = Convert.ToInt32(ddlYearTypeID.SelectedValue);
		baseMonthlyInformation.MonthTypeID = Convert.ToInt32(ddlMonthTypeID.SelectedValue);
		baseMonthlyInformation.MainOfficeTypeID = Convert.ToInt32(ddlMainOfficeTypeID.SelectedValue);
		baseMonthlyInformation.ContractualReward = Convert.ToInt64(txtContractualReward.Text);
		baseMonthlyInformation.ContractualConstantReward = Convert.ToInt64(txtContractualConstantReward.Text);
		baseMonthlyInformation.ExtraReward = Convert.ToInt64(txtExtraReward.Text);
		baseMonthlyInformation.OfficialReward = Convert.ToInt64(txtOfficialReward.Text);

		BaseMonthlyInformationHandler baseMonthlyInformationHandler = new BaseMonthlyInformationHandler();

		if (baseMonthlyInformationHandler.Insert(baseMonthlyInformation) > 0)
		{
			Response.Redirect("Z_BaseMonthlyInformationDefault.aspx");
		}
	}

	protected void btnNO_Click(object sender, EventArgs e)
	{
		Response.Redirect("Z_BaseMonthlyInformationDefault.aspx");
	}
}
