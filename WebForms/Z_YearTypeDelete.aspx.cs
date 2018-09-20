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

public partial class WebForms_Z_YearTypeDelete : System.Web.UI.Page
{
	YearTypeHandler yearTypeHandler = null;
	int yearTypeYearTypeID;

	protected void Page_Load(object sender, EventArgs e)
	{
		string yearTypeID = Request.QueryString["yearTypeID"] as string;
		if (yearTypeID == null)
			Response.Redirect("Z_YearTypeDefault.aspx");

		try
		{
			yearTypeYearTypeID = Convert.ToInt32(yearTypeID.Trim());
			yearTypeHandler = new YearTypeHandler();

			YearType yearType = yearTypeHandler.GetDetails(yearTypeYearTypeID);

			lblYearTypeID.Text = yearType.YearTypeID.ToString();
			lblTitle.Text = yearType.Title.ToString();
		}
		catch (Exception)
		{
			Response.Redirect("Z_YearTypeDefault.aspx");
		}
	}
	protected void btnNO_Click(object sender, EventArgs e)
	{
		Response.Redirect("Z_YearTypeDefault.aspx");
	}

	protected void btnYES_Click(object sender, EventArgs e)
	{
		if (yearTypeHandler.Delete(yearTypeYearTypeID))
			Response.Redirect("Z_YearTypeDefault.aspx");
	}
}
