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

public partial class WebForms_Z_RoleTypeDelete : System.Web.UI.Page
{
	RoleTypeHandler roleTypeHandler = null;
	int roleTypeRoleTypeID;

	protected void Page_Load(object sender, EventArgs e)
	{
		string roleTypeID = Request.QueryString["roleTypeID"] as string;
		if (roleTypeID == null)
			Response.Redirect("Z_RoleTypeDefault.aspx");

		try
		{
			roleTypeRoleTypeID = Convert.ToInt32(roleTypeID.Trim());
			roleTypeHandler = new RoleTypeHandler();

			RoleType roleType = roleTypeHandler.GetDetails(roleTypeRoleTypeID);

			lblRoleTypeID.Text = roleType.RoleTypeID.ToString();
			lblFactor.Text = roleType.Factor.ToString();
			lblTitle.Text = roleType.Title.ToString();
		}
		catch (Exception)
		{
			Response.Redirect("Z_RoleTypeDefault.aspx");
		}
	}
	protected void btnNO_Click(object sender, EventArgs e)
	{
		Response.Redirect("Z_RoleTypeDefault.aspx");
	}

	protected void btnYES_Click(object sender, EventArgs e)
	{
		if (roleTypeHandler.Delete(roleTypeRoleTypeID))
			Response.Redirect("Z_RoleTypeDefault.aspx");
	}
}
