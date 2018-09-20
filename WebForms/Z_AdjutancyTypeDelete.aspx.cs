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

public partial class WebForms_Z_AdjutancyTypeDelete : System.Web.UI.Page
{
	AdjutancyTypeHandler adjutancyTypeHandler = null;
	int adjutancyTypeAdjutancyTypeID;

	protected void Page_Load(object sender, EventArgs e)
	{
		string adjutancyTypeID = Request.QueryString["adjutancyTypeID"] as string;
		if (adjutancyTypeID == null)
			Response.Redirect("Z_AdjutancyTypeDefault.aspx");

		try
		{
			adjutancyTypeAdjutancyTypeID = Convert.ToInt32(adjutancyTypeID.Trim());
			adjutancyTypeHandler = new AdjutancyTypeHandler();

			AdjutancyType adjutancyType = adjutancyTypeHandler.GetDetails(adjutancyTypeAdjutancyTypeID);

			lblAdjutancyTypeID.Text = adjutancyType.AdjutancyTypeID.ToString();
			lblAdjutantFullName.Text = adjutancyType.AdjutantFullName.ToString();
			lblAdjutantNationalCode.Text = adjutancyType.AdjutantNationalCode.ToString();
			lblTitle.Text = adjutancyType.Title.ToString();
		}
		catch (Exception)
		{
			Response.Redirect("Z_AdjutancyTypeDefault.aspx");
		}
	}
	protected void btnNO_Click(object sender, EventArgs e)
	{
		Response.Redirect("Z_AdjutancyTypeDefault.aspx");
	}

	protected void btnYES_Click(object sender, EventArgs e)
	{
		if (adjutancyTypeHandler.Delete(adjutancyTypeAdjutancyTypeID))
			Response.Redirect("Z_AdjutancyTypeDefault.aspx");
	}
}
