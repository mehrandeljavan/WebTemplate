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

public partial class WebForms_Z_MainOfficeTypeDelete : System.Web.UI.Page
{
	MainOfficeTypeHandler mainOfficeTypeHandler = null;
	int mainOfficeTypeMainOfficeTypeID;

	protected void Page_Load(object sender, EventArgs e)
	{
		string mainOfficeTypeID = Request.QueryString["mainOfficeTypeID"] as string;
		if (mainOfficeTypeID == null)
			Response.Redirect("Z_MainOfficeTypeDefault.aspx");

		try
		{
			mainOfficeTypeMainOfficeTypeID = Convert.ToInt32(mainOfficeTypeID.Trim());
			mainOfficeTypeHandler = new MainOfficeTypeHandler();

			MainOfficeType mainOfficeType = mainOfficeTypeHandler.GetDetails(mainOfficeTypeMainOfficeTypeID);

			lblMainOfficeTypeID.Text = mainOfficeType.MainOfficeTypeID.ToString();
			lblContractualEmployeesNumber.Text = mainOfficeType.ContractualEmployeesNumber.ToString();
			lblTitle.Text = mainOfficeType.Title.ToString();
			lblTotalScore.Text = mainOfficeType.TotalScore.ToString();
			lblTotalScoreCat1.Text = mainOfficeType.TotalScoreCat1.ToString();
			lblTotalScoreCat2.Text = mainOfficeType.TotalScoreCat2.ToString();
		}
		catch (Exception)
		{
			Response.Redirect("Z_MainOfficeTypeDefault.aspx");
		}
	}
	protected void btnNO_Click(object sender, EventArgs e)
	{
		Response.Redirect("Z_MainOfficeTypeDefault.aspx");
	}

	protected void btnYES_Click(object sender, EventArgs e)
	{
		if (mainOfficeTypeHandler.Delete(mainOfficeTypeMainOfficeTypeID))
			Response.Redirect("Z_MainOfficeTypeDefault.aspx");
	}
}
