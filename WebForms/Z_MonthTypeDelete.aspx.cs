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

public partial class WebForms_Z_MonthTypeDelete : System.Web.UI.Page
{
	MonthTypeHandler monthTypeHandler = null;
	int monthTypeMonthTypeID;

	protected void Page_Load(object sender, EventArgs e)
	{
		string monthTypeID = Request.QueryString["monthTypeID"] as string;
		if (monthTypeID == null)
			Response.Redirect("Z_MonthTypeDefault.aspx");

		try
		{
			monthTypeMonthTypeID = Convert.ToInt32(monthTypeID.Trim());
			monthTypeHandler = new MonthTypeHandler();

			MonthType monthType = monthTypeHandler.GetDetails(monthTypeMonthTypeID);

			lblMonthTypeID.Text = monthType.MonthTypeID.ToString();
			lblTitle.Text = monthType.Title.ToString();
		}
		catch (Exception)
		{
			Response.Redirect("Z_MonthTypeDefault.aspx");
		}
	}
	protected void btnNO_Click(object sender, EventArgs e)
	{
		Response.Redirect("Z_MonthTypeDefault.aspx");
	}

	protected void btnYES_Click(object sender, EventArgs e)
	{
		if (monthTypeHandler.Delete(monthTypeMonthTypeID))
			Response.Redirect("Z_MonthTypeDefault.aspx");
	}
}
