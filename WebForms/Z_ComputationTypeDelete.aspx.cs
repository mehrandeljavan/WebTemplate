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

public partial class WebForms_Z_ComputationTypeDelete : System.Web.UI.Page
{
	ComputationTypeHandler computationTypeHandler = null;
	int computationTypeComputationTypeID;

	protected void Page_Load(object sender, EventArgs e)
	{
		string computationTypeID = Request.QueryString["computationTypeID"] as string;
		if (computationTypeID == null)
			Response.Redirect("Z_ComputationTypeDefault.aspx");

		try
		{
			computationTypeComputationTypeID = Convert.ToInt32(computationTypeID.Trim());
			computationTypeHandler = new ComputationTypeHandler();

			ComputationType computationType = computationTypeHandler.GetDetails(computationTypeComputationTypeID);

			lblComputationTypeID.Text = computationType.ComputationTypeID.ToString();
			lblTitle.Text = computationType.Title.ToString();
		}
		catch (Exception)
		{
			Response.Redirect("Z_ComputationTypeDefault.aspx");
		}
	}
	protected void btnNO_Click(object sender, EventArgs e)
	{
		Response.Redirect("Z_ComputationTypeDefault.aspx");
	}

	protected void btnYES_Click(object sender, EventArgs e)
	{
		if (computationTypeHandler.Delete(computationTypeComputationTypeID))
			Response.Redirect("Z_ComputationTypeDefault.aspx");
	}
}
