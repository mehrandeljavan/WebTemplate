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

public partial class WebForms_Z_ActivityUserTypeAdd : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		ActivityTypeHandler activityTypeHandler = new ActivityTypeHandler();
		List <ActivityType> activityTypeList = activityTypeHandler.GetListAll();
		DataTable activityTypeTable = new DataTable();
		activityTypeTable.Columns.Add("ActivityTypeID");
		
		if (activityTypeList != null)
			foreach (ActivityType activityType in activityTypeList)
				activityTypeTable.Rows.Add(activityType.ActivityTypeID);

		if(!IsPostBack)
		{
			ddlActivityTypeID.DataSource = activityTypeTable;
			ddlActivityTypeID.DataTextField = "ActivityTypeID";
			ddlActivityTypeID.DataValueField = "ActivityTypeID";
			ddlActivityTypeID.DataBind();
		}
		UserTypeHandler userTypeHandler = new UserTypeHandler();
		List <UserType> userTypeList = userTypeHandler.GetListAll();
		DataTable userTypeTable = new DataTable();
		userTypeTable.Columns.Add("UserTypeID");
		
		if (userTypeList != null)
			foreach (UserType userType in userTypeList)
				userTypeTable.Rows.Add(userType.UserTypeID);

		if(!IsPostBack)
		{
			ddlUserTypeID.DataSource = userTypeTable;
			ddlUserTypeID.DataTextField = "UserTypeID";
			ddlUserTypeID.DataValueField = "UserTypeID";
			ddlUserTypeID.DataBind();
		}
	}

	protected void btnYES_Click(object sender, EventArgs e)
	{
		ActivityUserType activityUserType = new ActivityUserType();

		activityUserType.ActivityTypeID = Convert.ToInt32(ddlActivityTypeID.SelectedValue);
		activityUserType.UserTypeID = Convert.ToInt32(ddlUserTypeID.SelectedValue);

		ActivityUserTypeHandler activityUserTypeHandler = new ActivityUserTypeHandler();

		if (activityUserTypeHandler.Insert(activityUserType) > 0)
		{
			Response.Redirect("Z_ActivityUserTypeDefault.aspx");
		}
	}

	protected void btnNO_Click(object sender, EventArgs e)
	{
		Response.Redirect("Z_ActivityUserTypeDefault.aspx");
	}
}
