using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.DBA;

namespace Rewards.Models
{
public class ActivityUserTypeHandler
{
	// Handle to the ActivityUserType DBAccess class
	ActivityUserTypeDBAccess activityUserTypeDb = null;

	public ActivityUserTypeHandler()
	{
		activityUserTypeDb = new ActivityUserTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of activityUserTypes, we can put some logic here if needed 
	public List<ActivityUserType> GetListAll()
	{
		return activityUserTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of activityUserTypes, we can put some logic here if needed 
	public bool Update(ActivityUserType activityUserType)
	{
		return activityUserTypeDb.Update(activityUserType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of activityUserTypes, we can put some logic here if needed 
	public ActivityUserType GetDetails(int activityTypeID , int userTypeID)
	{
		return activityUserTypeDb.GetDetails(activityTypeID , userTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of activityUserTypes, we can put some logic here if needed 
	public bool Delete(int activityTypeID , int userTypeID)
	{
		return activityUserTypeDb.Delete(activityTypeID , userTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of activityUserTypes, we can put some logic here if needed 
	public Int64 Insert(ActivityUserType activityUserType)
	{
		return activityUserTypeDb.Insert(activityUserType);
	}

	public bool Exists(ActivityUserType activityUserType)
	{
		return activityUserTypeDb.Exists(activityUserType);
	}

	public bool Exists(int activityTypeID , int userTypeID)
	{
		return activityUserTypeDb.Exists(activityTypeID , userTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of activityUserTypes, we can put some logic here if needed 
	public List<ActivityUserType> SearchLike(ActivityUserType activityUserType)
	{
		return activityUserTypeDb.SearchLike(activityUserType);
	}

}
}
