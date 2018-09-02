using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.DBA;

namespace Rewards.Models
{
public class MonthTypeHandler
{
	// Handle to the MonthType DBAccess class
	MonthTypeDBAccess monthTypeDb = null;

	public MonthTypeHandler()
	{
		monthTypeDb = new MonthTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of monthTypes, we can put some logic here if needed 
	public List<MonthType> GetListAll()
	{
		return monthTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of monthTypes, we can put some logic here if needed 
	public bool Update(MonthType monthType)
	{
		return monthTypeDb.Update(monthType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of monthTypes, we can put some logic here if needed 
	public MonthType GetDetails(int monthTypeID)
	{
		return monthTypeDb.GetDetails(monthTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of monthTypes, we can put some logic here if needed 
	public bool Delete(int monthTypeID)
	{
		return monthTypeDb.Delete(monthTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of monthTypes, we can put some logic here if needed 
	public Int64 Insert(MonthType monthType)
	{
		return monthTypeDb.Insert(monthType);
	}

	public bool Exists(MonthType monthType)
	{
		return monthTypeDb.Exists(monthType);
	}

	public bool Exists(int monthTypeID)
	{
		return monthTypeDb.Exists(monthTypeID);
	}

	public List<BaseMonthlyInformation> GetListBaseMonthlyInformation(int monthTypeID)
	{
		return monthTypeDb.GetListBaseMonthlyInformation(monthTypeID);
	}

	public List<ContractualEmployeeReward> GetListContractualEmployeeReward(int monthTypeID)
	{
		return monthTypeDb.GetListContractualEmployeeReward(monthTypeID);
	}

	public List<DepartmentMonthlyInformation> GetListDepartmentMonthlyInformation(int monthTypeID)
	{
		return monthTypeDb.GetListDepartmentMonthlyInformation(monthTypeID);
	}

	public List<OfficialEmployeeReward> GetListOfficialEmployeeReward(int monthTypeID)
	{
		return monthTypeDb.GetListOfficialEmployeeReward(monthTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of monthTypes, we can put some logic here if needed 
	public List<MonthType> SearchLike(MonthType monthType)
	{
		return monthTypeDb.SearchLike(monthType);
	}

}
}
