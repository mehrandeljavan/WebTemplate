using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using Rewards;
using Rewards.Models;

public partial class WebForms_Z_AdjutancyTypeDefault : System.Web.UI.Page
{
	AdjutancyTypeHandler adjutancyTypeHandler = null;


	protected void Page_Load(object sender, EventArgs e)
	{
		lblResult.Text = string.Empty;

		adjutancyTypeHandler = new AdjutancyTypeHandler();
		if (IsPostBack == false)
		{
			BindData();
		}
	}

	private void BindData()
	{
		GridView1.DataSource = adjutancyTypeHandler.GetListAll();
		GridView1.DataBind();
	}


	protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
	{
		GridView1.EditIndex = e.NewEditIndex;
		BindData();
	}

	protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
	{
		GridView1.EditIndex = -1;
		BindData();
	}

	protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
	{

		Label lblAdjutancyTypeID = GridView1.Rows[e.RowIndex].FindControl("lblAdjutancyTypeID") as Label;
		Label lblAdjutantFullName = GridView1.Rows[e.RowIndex].FindControl("lblAdjutantFullName") as Label;
		TextBox txtAdjutantNationalCode = GridView1.Rows[e.RowIndex].FindControl("txtAdjutantNationalCode") as TextBox;
		TextBox txtTitle = GridView1.Rows[e.RowIndex].FindControl("txtTitle") as TextBox;


		if (lblAdjutancyTypeID != null && lblAdjutantFullName != null && txtAdjutantNationalCode != null && txtTitle != null) 
		{
			AdjutancyType adjutancyType = new AdjutancyType();

			adjutancyType.AdjutancyTypeID = Convert.ToInt32(lblAdjutancyTypeID.Text.Trim());
			adjutancyType.AdjutantFullName = lblAdjutantFullName.Text;
			adjutancyType.AdjutantNationalCode = Convert.ToInt64(txtAdjutantNationalCode.Text.Trim());
			adjutancyType.Title = txtTitle.Text;

			//Let us now update the database
			if (adjutancyTypeHandler.Update(adjutancyType) == true)
			{
				lblResult.Text = "Record Updated Successfully";
			}
			else
			{
				lblResult.Text = "Failed to Update record";
			}

			//end the editing and bind with updated records.
			GridView1.EditIndex = -1;
			BindData();
		}
	}
	protected void Button1_Click(object sender, EventArgs e)
	{
		Response.Redirect("Z_AdjutancyTypeAdd.aspx");
	}
}
