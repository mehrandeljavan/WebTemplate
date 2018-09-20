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

public partial class WebForms_Z_YearTypeDefault : System.Web.UI.Page
{
	YearTypeHandler yearTypeHandler = null;


	protected void Page_Load(object sender, EventArgs e)
	{
		lblResult.Text = string.Empty;

		yearTypeHandler = new YearTypeHandler();
		if (IsPostBack == false)
		{
			BindData();
		}
	}

	private void BindData()
	{
		GridView1.DataSource = yearTypeHandler.GetListAll();
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

		Label lblYearTypeID = GridView1.Rows[e.RowIndex].FindControl("lblYearTypeID") as Label;
		TextBox txtTitle = GridView1.Rows[e.RowIndex].FindControl("txtTitle") as TextBox;


		if (lblYearTypeID != null && txtTitle != null) 
		{
			YearType yearType = new YearType();

			yearType.YearTypeID = Convert.ToInt32(lblYearTypeID.Text.Trim());
			yearType.Title = txtTitle.Text;

			//Let us now update the database
			if (yearTypeHandler.Update(yearType) == true)
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
		Response.Redirect("Z_YearTypeAdd.aspx");
	}
}
