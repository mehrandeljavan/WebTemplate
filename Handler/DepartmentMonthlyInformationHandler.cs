using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.DBA;

namespace Rewards.Models
{
public class DepartmentMonthlyInformationHandler
{
	// Handle to the DepartmentMonthlyInformation DBAccess class
	DepartmentMonthlyInformationDBAccess departmentMonthlyInformationDb = null;

	public DepartmentMonthlyInformationHandler()
	{
		departmentMonthlyInformationDb = new DepartmentMonthlyInformationDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of departmentMonthlyInformations, we can put some logic here if needed 
	public List<DepartmentMonthlyInformation> GetListAll()
	{
		return departmentMonthlyInformationDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of departmentMonthlyInformations, we can put some logic here if needed 
	public bool Update(DepartmentMonthlyInformation departmentMonthlyInformation)
	{
		return departmentMonthlyInformationDb.Update(departmentMonthlyInformation);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of departmentMonthlyInformations, we can put some logic here if needed 
	public DepartmentMonthlyInformation GetDetails(int yearTypeID , int monthTypeID , int departmentID)
	{
		return departmentMonthlyInformationDb.GetDetails(yearTypeID , monthTypeID , departmentID);
	}

	public DepartmentMonthlyInformation GetDetails(int yearTypeID , int monthTypeID)
	{
		return departmentMonthlyInformationDb.GetDetails(yearTypeID , monthTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of departmentMonthlyInformations, we can put some logic here if needed 
	public bool Delete(int yearTypeID , int monthTypeID , int departmentID)
	{
		return departmentMonthlyInformationDb.Delete(yearTypeID , monthTypeID , departmentID);
	}

	public bool Delete(int yearTypeID , int monthTypeID)
	{
		return departmentMonthlyInformationDb.Delete(yearTypeID , monthTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of departmentMonthlyInformations, we can put some logic here if needed 
	public Int64 Insert(DepartmentMonthlyInformation departmentMonthlyInformation)
	{
		return departmentMonthlyInformationDb.Insert(departmentMonthlyInformation);
	}

	public bool Exists(DepartmentMonthlyInformation departmentMonthlyInformation)
	{
		return departmentMonthlyInformationDb.Exists(departmentMonthlyInformation);
	}

	public bool Exists(int yearTypeID , int monthTypeID , int departmentID)
	{
		return departmentMonthlyInformationDb.Exists(yearTypeID , monthTypeID , departmentID);
	}

	public List<DepartmentMonthlyInformation> GetListByDepartmentMonthlyInformationYearTypeIDMonthTypeID(int yearTypeID,int monthTypeID)
	{
		return departmentMonthlyInformationDb.GetListByDepartmentMonthlyInformationYearTypeIDMonthTypeID(yearTypeID,monthTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of departmentMonthlyInformations, we can put some logic here if needed 
	public List<DepartmentMonthlyInformation> SearchLike(DepartmentMonthlyInformation departmentMonthlyInformation)
	{
		return departmentMonthlyInformationDb.SearchLike(departmentMonthlyInformation);
	}

}
}
