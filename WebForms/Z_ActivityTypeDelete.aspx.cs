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

public partial class WebForms_Z_ActivityTypeDelete : System.Web.UI.Page
{
	ActivityTypeHandler activityTypeHandler = null;
	int activityTypeActivityTypeID;

	protected void Page_Load(object sender, EventArgs e)
	{
		string activityTypeID = Request.QueryString["activityTypeID"] as string;
		if (activityTypeID == null)
			Response.Redirect("Z_ActivityTypeDefault.aspx");

		try
		{
			activityTypeActivityTypeID = Convert.ToInt32(activityTypeID.Trim());
			activityTypeHandler = new ActivityTypeHandler();

			ActivityType activityType = activityTypeHandler.GetDetails(activityTypeActivityTypeID);

			lblActivityTypeID.Text = activityType.ActivityTypeID.ToString();
			lblTitle.Text = activityType.Title.ToString();
		}
		catch (Exception)
		{
			Response.Redirect("Z_ActivityTypeDefault.aspx");
		}
	}
	protected void btnNO_Click(object sender, EventArgs e)
	{
		Response.Redirect("Z_ActivityTypeDefault.aspx");
	}

	protected void btnYES_Click(object sender, EventArgs e)
	{
		if (activityTypeHandler.Delete(activityTypeActivityTypeID))
			Response.Redirect("Z_ActivityTypeDefault.aspx");
	}
}
