using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.DBA;

namespace Rewards.Models
{
public class YearTypeHandler
{
	// Handle to the YearType DBAccess class
	YearTypeDBAccess yearTypeDb = null;

	public YearTypeHandler()
	{
		yearTypeDb = new YearTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of yearTypes, we can put some logic here if needed 
	public List<YearType> GetListAll()
	{
		return yearTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of yearTypes, we can put some logic here if needed 
	public bool Update(YearType yearType)
	{
		return yearTypeDb.Update(yearType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of yearTypes, we can put some logic here if needed 
	public YearType GetDetails(int yearTypeID)
	{
		return yearTypeDb.GetDetails(yearTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of yearTypes, we can put some logic here if needed 
	public bool Delete(int yearTypeID)
	{
		return yearTypeDb.Delete(yearTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of yearTypes, we can put some logic here if needed 
	public Int64 Insert(YearType yearType)
	{
		return yearTypeDb.Insert(yearType);
	}

	public bool Exists(YearType yearType)
	{
		return yearTypeDb.Exists(yearType);
	}

	public bool Exists(int yearTypeID)
	{
		return yearTypeDb.Exists(yearTypeID);
	}

	public List<BaseMonthlyInformation> GetListBaseMonthlyInformation(int yearTypeID)
	{
		return yearTypeDb.GetListBaseMonthlyInformation(yearTypeID);
	}

	public List<ContractualEmployeeReward> GetListContractualEmployeeReward(int yearTypeID)
	{
		return yearTypeDb.GetListContractualEmployeeReward(yearTypeID);
	}

	public List<DepartmentMonthlyInformation> GetListDepartmentMonthlyInformation(int yearTypeID)
	{
		return yearTypeDb.GetListDepartmentMonthlyInformation(yearTypeID);
	}

	public List<OfficialEmployeeReward> GetListOfficialEmployeeReward(int yearTypeID)
	{
		return yearTypeDb.GetListOfficialEmployeeReward(yearTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of yearTypes, we can put some logic here if needed 
	public List<YearType> SearchLike(YearType yearType)
	{
		return yearTypeDb.SearchLike(yearType);
	}

}
}
