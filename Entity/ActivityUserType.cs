using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rewards.DBA;

namespace Rewards.Models
{
[Serializable]
public partial class ActivityUserType
{
	private int activityTypeID;
	private int userTypeID;
	private string activityTypeIDTitle;
	private string userTypeIDTitle;

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

	public int UserTypeID
	{
		get
		{
			return userTypeID;
		}
		set
		{
			userTypeID = value;
		}
	}

	public string ActivityTypeIDTitle
	{
		get
		{
			return activityTypeIDTitle;
		}
		set
		{
			activityTypeIDTitle = value;
		}
	}

	public string UserTypeIDTitle
	{
		get
		{
			return userTypeIDTitle;
		}
		set
		{
			userTypeIDTitle = value;
		}
	}

}
}
