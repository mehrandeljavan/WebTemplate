using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.DBA;

namespace Rewards.Models
{
public class OfficialEmployeeRewardHandler
{
	// Handle to the OfficialEmployeeReward DBAccess class
	OfficialEmployeeRewardDBAccess officialEmployeeRewardDb = null;

	public OfficialEmployeeRewardHandler()
	{
		officialEmployeeRewardDb = new OfficialEmployeeRewardDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of officialEmployeeRewards, we can put some logic here if needed 
	public List<OfficialEmployeeReward> GetListAll()
	{
		return officialEmployeeRewardDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of officialEmployeeRewards, we can put some logic here if needed 
	public bool Update(OfficialEmployeeReward officialEmployeeReward)
	{
		return officialEmployeeRewardDb.Update(officialEmployeeReward);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of officialEmployeeRewards, we can put some logic here if needed 
	public OfficialEmployeeReward GetDetails(Int64 nationalCode , int yearTypeID , int monthTypeID)
	{
		return officialEmployeeRewardDb.GetDetails(nationalCode , yearTypeID , monthTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of officialEmployeeRewards, we can put some logic here if needed 
	public bool Delete(Int64 nationalCode , int yearTypeID , int monthTypeID)
	{
		return officialEmployeeRewardDb.Delete(nationalCode , yearTypeID , monthTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of officialEmployeeRewards, we can put some logic here if needed 
	public Int64 Insert(OfficialEmployeeReward officialEmployeeReward)
	{
		return officialEmployeeRewardDb.Insert(officialEmployeeReward);
	}

	public bool Exists(OfficialEmployeeReward officialEmployeeReward)
	{
		return officialEmployeeRewardDb.Exists(officialEmployeeReward);
	}

	public bool Exists(Int64 nationalCode , int yearTypeID , int monthTypeID)
	{
		return officialEmployeeRewardDb.Exists(nationalCode , yearTypeID , monthTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of officialEmployeeRewards, we can put some logic here if needed 
	public List<OfficialEmployeeReward> SearchLike(OfficialEmployeeReward officialEmployeeReward)
	{
		return officialEmployeeRewardDb.SearchLike(officialEmployeeReward);
	}

}
}
