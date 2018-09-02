using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rewards.DBA;

namespace Rewards.Models
{
[Serializable]
public partial class ActivityType
{
	private int activityTypeID;
	private string title;
	private List<ActivityUserType> activityUserTypeList;

	public int ActivityTypeID
	{
		get
		{
			return activityTypeID;
		}
		set
		{
			activityTypeID = value;
		}
	}

	public string Title
	{
		get
		{
			return title;
		}
		set
		{
			title = value;
		}
	}

	public List<ActivityUserType> ActivityUserTypeList
	{
		get
		{
			return activityUserTypeList;
		}
		set
		{
			activityUserTypeList = value;
		}
	}

	public List<ActivityUserType> GetListActivityUserType()
	{
		ActivityUserTypeList = new ActivityTypeDBAccess().GetListActivityUserType(this.ActivityTypeID);
		return ActivityUserTypeList;
	}

	public bool AddActivityUserType(ActivityUserType activityUserType)
	{
		activityUserType.ActivityTypeID = this.ActivityTypeID;
		ActivityUserTypeDBAccess activityUserTypeDBAccess = new ActivityUserTypeDBAccess();
		if (activityUserTypeDBAccess.Insert(activityUserType)>0)
			return (true);
		return (false);
	}

}
}
