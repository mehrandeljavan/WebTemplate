using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.DBA;

namespace Rewards.Models
{
public class BaseMonthlyInformationHandler
{
	// Handle to the BaseMonthlyInformation DBAccess class
	BaseMonthlyInformationDBAccess baseMonthlyInformationDb = null;

	public BaseMonthlyInformationHandler()
	{
		baseMonthlyInformationDb = new BaseMonthlyInformationDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of baseMonthlyInformations, we can put some logic here if needed 
	public List<BaseMonthlyInformation> GetListAll()
	{
		return baseMonthlyInformationDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of baseMonthlyInformations, we can put some logic here if needed 
	public bool Update(BaseMonthlyInformation baseMonthlyInformation)
	{
		return baseMonthlyInformationDb.Update(baseMonthlyInformation);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of baseMonthlyInformations, we can put some logic here if needed 
	public BaseMonthlyInformation GetDetails(int yearTypeID , int monthTypeID , int mainOfficeTypeID)
	{
		return baseMonthlyInformationDb.GetDetails(yearTypeID , monthTypeID , mainOfficeTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of baseMonthlyInformations, we can put some logic here if needed 
	public bool Delete(int yearTypeID , int monthTypeID , int mainOfficeTypeID)
	{
		return baseMonthlyInformationDb.Delete(yearTypeID , monthTypeID , mainOfficeTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of baseMonthlyInformations, we can put some logic here if needed 
	public Int64 Insert(BaseMonthlyInformation baseMonthlyInformation)
	{
		return baseMonthlyInformationDb.Insert(baseMonthlyInformation);
	}

	public bool Exists(BaseMonthlyInformation baseMonthlyInformation)
	{
		return baseMonthlyInformationDb.Exists(baseMonthlyInformation);
	}

	public bool Exists(int yearTypeID , int monthTypeID , int mainOfficeTypeID)
	{
		return baseMonthlyInformationDb.Exists(yearTypeID , monthTypeID , mainOfficeTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of baseMonthlyInformations, we can put some logic here if needed 
	public List<BaseMonthlyInformation> SearchLike(BaseMonthlyInformation baseMonthlyInformation)
	{
		return baseMonthlyInformationDb.SearchLike(baseMonthlyInformation);
	}

}
}
