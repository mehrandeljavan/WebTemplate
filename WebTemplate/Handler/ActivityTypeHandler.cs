using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.DBA;

namespace Rewards.Models
{
public class ActivityTypeHandler
{
	// Handle to the ActivityType DBAccess class
	ActivityTypeDBAccess activityTypeDb = null;

	public ActivityTypeHandler()
	{
		activityTypeDb = new ActivityTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of activityTypes, we can put some logic here if needed 
	public List<ActivityType> GetListAll()
	{
		return activityTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of activityTypes, we can put some logic here if needed 
	public bool Update(ActivityType activityType)
	{
		return activityTypeDb.Update(activityType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of activityTypes, we can put some logic here if needed 
	public ActivityType GetDetails(int activityTypeID)
	{
		return activityTypeDb.GetDetails(activityTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of activityTypes, we can put some logic here if needed 
	public bool Delete(int activityTypeID)
	{
		return activityTypeDb.Delete(activityTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of activityTypes, we can put some logic here if needed 
	public Int64 Insert(ActivityType activityType)
	{
		return activityTypeDb.Insert(activityType);
	}

	public bool Exists(ActivityType activityType)
	{
		return activityTypeDb.Exists(activityType);
	}

	public bool Exists(int activityTypeID)
	{
		return activityTypeDb.Exists(activityTypeID);
	}

	public List<ActivityUserType> GetListActivityUserType(int activityTypeID)
	{
		return activityTypeDb.GetListActivityUserType(activityTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of activityTypes, we can put some logic here if needed 
	public List<ActivityType> SearchLike(ActivityType activityType)
	{
		return activityTypeDb.SearchLike(activityType);
	}

}
}
