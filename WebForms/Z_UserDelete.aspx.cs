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

public partial class WebForms_Z_UserDelete : System.Web.UI.Page
{
	UserHandler userHandler = null;
	Int64 userNationalCode;

	protected void Page_Load(object sender, EventArgs e)
	{
		string nationalCode = Request.QueryString["nationalCode"] as string;
		if (nationalCode == null)
			Response.Redirect("Z_UserDefault.aspx");

		try
		{
			userNationalCode = Convert.ToInt64(nationalCode.Trim());
			userHandler = new UserHandler();

			User user = userHandler.GetDetails(userNationalCode);

			lblNationalCode.Text = user.NationalCode.ToString();
			lblPassword.Text = user.Password.ToString();
			lblLastPassChangeDate.Text = user.LastPassChangeDate.ToString();
			lblIsActiveUser.Text = user.IsActiveUser.ToString();
		}
		catch (Exception)
		{
			Response.Redirect("Z_UserDefault.aspx");
		}
	}
	protected void btnNO_Click(object sender, EventArgs e)
	{
		Response.Redirect("Z_UserDefault.aspx");
	}

	protected void btnYES_Click(object sender, EventArgs e)
	{
		if (userHandler.Delete(userNationalCode))
			Response.Redirect("Z_UserDefault.aspx");
	}
}
