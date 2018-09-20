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

public partial class WebForms_Z_DepartmentAdd : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		AdjutancyTypeHandler adjutancyTypeHandler = new AdjutancyTypeHandler();
		List <AdjutancyType> adjutancyTypeList = adjutancyTypeHandler.GetListAll();
		DataTable adjutancyTypeTable = new DataTable();
		adjutancyTypeTable.Columns.Add("AdjutancyTypeID");
		adjutancyTypeTable.Columns.Add("Title");
		
		if (adjutancyTypeList != null)
			foreach (AdjutancyType adjutancyType in adjutancyTypeList)
				adjutancyTypeTable.Rows.Add(adjutancyType.AdjutancyTypeID, adjutancyType.Title);

		if(!IsPostBack)
		{
			ddlAdjutancyTypeID.DataSource = adjutancyTypeTable;
			ddlAdjutancyTypeID.DataTextField = "Title";
			ddlAdjutancyTypeID.DataValueField = "AdjutancyTypeID";
			ddlAdjutancyTypeID.DataBind();
		}
		ComputationTypeHandler computationTypeHandler = new ComputationTypeHandler();
		List <ComputationType> computationTypeList = computationTypeHandler.GetListAll();
		DataTable computationTypeTable = new DataTable();
		computationTypeTable.Columns.Add("ComputationTypeID");
		computationTypeTable.Columns.Add("Title");
		
		if (computationTypeList != null)
			foreach (ComputationType computationType in computationTypeList)
				computationTypeTable.Rows.Add(computationType.ComputationTypeID, computationType.Title);

		if(!IsPostBack)
		{
			ddlComputationTypeID.DataSource = computationTypeTable;
			ddlComputationTypeID.DataTextField = "Title";
			ddlComputationTypeID.DataValueField = "ComputationTypeID";
			ddlComputationTypeID.DataBind();
		}
		MainOfficeTypeHandler mainOfficeTypeHandler = new MainOfficeTypeHandler();
		List <MainOfficeType> mainOfficeTypeList = mainOfficeTypeHandler.GetListAll();
		DataTable mainOfficeTypeTable = new DataTable();
		mainOfficeTypeTable.Columns.Add("MainOfficeTypeID");
		mainOfficeTypeTable.Columns.Add("Title");
		
		if (mainOfficeTypeList != null)
			foreach (MainOfficeType mainOfficeType in mainOfficeTypeList)
				mainOfficeTypeTable.Rows.Add(mainOfficeType.MainOfficeTypeID, mainOfficeType.Title);

		if(!IsPostBack)
		{
			ddlMainOfficeTypeID.DataSource = mainOfficeTypeTable;
			ddlMainOfficeTypeID.DataTextField = "Title";
			ddlMainOfficeTypeID.DataValueField = "MainOfficeTypeID";
			ddlMainOfficeTypeID.DataBind();
		}
	}

	protected void btnYES_Click(object sender, EventArgs e)
	{
		Department department = new Department();

		department.ComputationTypeID = Convert.ToInt32(ddlComputationTypeID.SelectedValue);
		department.MainOfficeTypeID = Convert.ToInt32(ddlMainOfficeTypeID.SelectedValue);
		department.AdjutancyTypeID = Convert.ToInt32(ddlAdjutancyTypeID.SelectedValue);
		department.TotalEmployeeNumber = Convert.ToInt32(txtTotalEmployeeNumber.Text);
		department.TotalContractualEmployeeNumber = Convert.ToInt32(txtTotalContractualEmployeeNumber.Text);
		department.DividerNationalCode = Convert.ToInt64(txtDividerNationalCode.Text);
		department.Title = txtTitle.Text;

		DepartmentHandler departmentHandler = new DepartmentHandler();

		if (departmentHandler.Insert(department) > 0)
		{
			Response.Redirect("Z_DepartmentDefault.aspx");
		}
	}

	protected void btnNO_Click(object sender, EventArgs e)
	{
		Response.Redirect("Z_DepartmentDefault.aspx");
	}
}
