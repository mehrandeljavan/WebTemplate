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

public partial class WebForms_Z_UserTypeDelete : System.Web.UI.Page
{
	UserTypeHandler userTypeHandler = null;
	int userTypeUserTypeID;

	protected void Page_Load(object sender, EventArgs e)
	{
		string userTypeID = Request.QueryString["userTypeID"] as string;
		if (userTypeID == null)
			Response.Redirect("Z_UserTypeDefault.aspx");

		try
		{
			userTypeUserTypeID = Convert.ToInt32(userTypeID.Trim());
			userTypeHandler = new UserTypeHandler();

			UserType userType = userTypeHandler.GetDetails(userTypeUserTypeID);

			lblUserTypeID.Text = userType.UserTypeID.ToString();
			lblTitle.Text = userType.Title.ToString();
		}
		catch (Exception)
		{
			Response.Redirect("Z_UserTypeDefault.aspx");
		}
	}
	protected void btnNO_Click(object sender, EventArgs e)
	{
		Response.Redirect("Z_UserTypeDefault.aspx");
	}

	protected void btnYES_Click(object sender, EventArgs e)
	{
		if (userTypeHandler.Delete(userTypeUserTypeID))
			Response.Redirect("Z_UserTypeDefault.aspx");
	}
}
