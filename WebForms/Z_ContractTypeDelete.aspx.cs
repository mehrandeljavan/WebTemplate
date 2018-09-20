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

public partial class WebForms_Z_ContractTypeDelete : System.Web.UI.Page
{
	ContractTypeHandler contractTypeHandler = null;
	int contractTypeContractTypeID;

	protected void Page_Load(object sender, EventArgs e)
	{
		string contractTypeID = Request.QueryString["contractTypeID"] as string;
		if (contractTypeID == null)
			Response.Redirect("Z_ContractTypeDefault.aspx");

		try
		{
			contractTypeContractTypeID = Convert.ToInt32(contractTypeID.Trim());
			contractTypeHandler = new ContractTypeHandler();

			ContractType contractType = contractTypeHandler.GetDetails(contractTypeContractTypeID);

			lblContractTypeID.Text = contractType.ContractTypeID.ToString();
			lblTitle.Text = contractType.Title.ToString();
		}
		catch (Exception)
		{
			Response.Redirect("Z_ContractTypeDefault.aspx");
		}
	}
	protected void btnNO_Click(object sender, EventArgs e)
	{
		Response.Redirect("Z_ContractTypeDefault.aspx");
	}

	protected void btnYES_Click(object sender, EventArgs e)
	{
		if (contractTypeHandler.Delete(contractTypeContractTypeID))
			Response.Redirect("Z_ContractTypeDefault.aspx");
	}
}
