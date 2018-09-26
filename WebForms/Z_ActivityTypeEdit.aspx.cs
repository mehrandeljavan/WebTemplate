using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Rewards;
using Rewards.Models;

public partial class WebForms_Z_ActivityTypeEdit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ActivityType activityType = new ActivityType();
            ActivityTypeHandler activityTypeHandler = new ActivityTypeHandler();
            string activityTypeID = Request.QueryString["activityTypeID"] as string;
            activityType.ActivityTypeID = Convert.ToInt32(activityTypeID);
        
            activityType = activityTypeHandler.GetDetails(activityType.ActivityTypeID);
            txtTitle.Text = activityType.Title;
        }
    }

    protected void btnYES_Click(object sender, EventArgs e)
    {
        ActivityType activityType = new ActivityType();
        ActivityTypeHandler activityTypeHandler = new ActivityTypeHandler();
        string activityTypeID = Request.QueryString["activityTypeID"] as string;
        activityType.ActivityTypeID = Convert.ToInt32(activityTypeID);

        activityType.Title = txtTitle.Text;

        activityTypeHandler.Update(activityType);
        Response.Redirect("Z_ActivityTypeDefault.aspx");
    }

    protected void btnNO_Click(object sender, EventArgs e)
    {
        Response.Redirect("Z_ActivityTypeDefault.aspx");
    }
}