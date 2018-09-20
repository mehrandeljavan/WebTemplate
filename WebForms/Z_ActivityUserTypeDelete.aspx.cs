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

public partial class WebForms_Z_ActivityUserTypeDelete : System.Web.UI.Page
{
	ActivityUserTypeHandler activityUserTypeHandler = null;
	int activityUserTypeActivityTypeID;
	int activityUserTypeUserTypeID;

	protected void Page_Load(object sender, EventArgs e)
	{
		string activityTypeID = Request.QueryString["activityTypeID"] as string;
		string userTypeID = Request.QueryString["userTypeID"] as string;
		if (activityTypeID == null || userTypeID == null)
			Response.Redirect("Z_ActivityUserTypeDefault.aspx");

		try
		{
			activityUserTypeActivityTypeID = Convert.ToInt32(activityTypeID.Trim());
			activityUserTypeUserTypeID = Convert.ToInt32(userTypeID.Trim());
			activityUserTypeHandler = new ActivityUserTypeHandler();

			ActivityUserType activityUserType = activityUserTypeHandler.GetDetails(activityUserTypeActivityTypeID , activityUserTypeUserTypeID);

			lblActivityTypeID.Text = activityUserType.ActivityTypeID.ToString();
			lblUserTypeID.Text = activityUserType.UserTypeID.ToString();
			lblActivityTypeIDTitle.Text = activityUserType.ActivityTypeIDTitle.ToString();
			lblUserTypeIDTitle.Text = activityUserType.UserTypeIDTitle.ToString();
		}
		catch (Exception)
		{
			Response.Redirect("Z_ActivityUserTypeDefault.aspx");
		}
	}
	protected void btnNO_Click(object sender, EventArgs e)
	{
		Response.Redirect("Z_ActivityUserTypeDefault.aspx");
	}

	protected void btnYES_Click(object sender, EventArgs e)
	{
		if (activityUserTypeHandler.Delete(activityUserTypeActivityTypeID , activityUserTypeUserTypeID))
			Response.Redirect("Z_ActivityUserTypeDefault.aspx");
	}
}
