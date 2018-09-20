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

public partial class WebForms_Z_RoleTypeAdd : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
	}

	protected void btnYES_Click(object sender, EventArgs e)
	{
		RoleType roleType = new RoleType();

		roleType.Title = txtTitle.Text;

		RoleTypeHandler roleTypeHandler = new RoleTypeHandler();

		if (roleTypeHandler.Insert(roleType) > 0)
		{
			Response.Redirect("Z_RoleTypeDefault.aspx");
		}
	}

	protected void btnNO_Click(object sender, EventArgs e)
	{
		Response.Redirect("Z_RoleTypeDefault.aspx");
	}
}
