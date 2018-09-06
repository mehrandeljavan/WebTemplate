using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.DBA;

namespace Rewards.Models
{
public class MainOfficeTypeHandler
{
	// Handle to the MainOfficeType DBAccess class
	MainOfficeTypeDBAccess mainOfficeTypeDb = null;

	public MainOfficeTypeHandler()
	{
		mainOfficeTypeDb = new MainOfficeTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of mainOfficeTypes, we can put some logic here if needed 
	public List<MainOfficeType> GetListAll()
	{
		return mainOfficeTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of mainOfficeTypes, we can put some logic here if needed 
	public bool Update(MainOfficeType mainOfficeType)
	{
		return mainOfficeTypeDb.Update(mainOfficeType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of mainOfficeTypes, we can put some logic here if needed 
	public MainOfficeType GetDetails(int mainOfficeTypeID)
	{
		return mainOfficeTypeDb.GetDetails(mainOfficeTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of mainOfficeTypes, we can put some logic here if needed 
	public bool Delete(int mainOfficeTypeID)
	{
		return mainOfficeTypeDb.Delete(mainOfficeTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of mainOfficeTypes, we can put some logic here if needed 
	public Int64 Insert(MainOfficeType mainOfficeType)
	{
		return mainOfficeTypeDb.Insert(mainOfficeType);
	}

	public bool Exists(MainOfficeType mainOfficeType)
	{
		return mainOfficeTypeDb.Exists(mainOfficeType);
	}

	public bool Exists(int mainOfficeTypeID)
	{
		return mainOfficeTypeDb.Exists(mainOfficeTypeID);
	}

	public List<BaseMonthlyInformation> GetListBaseMonthlyInformation(int mainOfficeTypeID)
	{
		return mainOfficeTypeDb.GetListBaseMonthlyInformation(mainOfficeTypeID);
	}

	public List<Department> GetListDepartment(int mainOfficeTypeID)
	{
		return mainOfficeTypeDb.GetListDepartment(mainOfficeTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of mainOfficeTypes, we can put some logic here if needed 
	public List<MainOfficeType> SearchLike(MainOfficeType mainOfficeType)
	{
		return mainOfficeTypeDb.SearchLike(mainOfficeType);
	}

}
}
