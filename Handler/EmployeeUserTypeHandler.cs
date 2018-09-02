using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.DBA;

namespace Rewards.Models
{
public class EmployeeUserTypeHandler
{
	// Handle to the EmployeeUserType DBAccess class
	EmployeeUserTypeDBAccess employeeUserTypeDb = null;

	public EmployeeUserTypeHandler()
	{
		employeeUserTypeDb = new EmployeeUserTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of employeeUserTypes, we can put some logic here if needed 
	public List<EmployeeUserType> GetListAll()
	{
		return employeeUserTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of employeeUserTypes, we can put some logic here if needed 
	public bool Update(EmployeeUserType employeeUserType)
	{
		return employeeUserTypeDb.Update(employeeUserType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of employeeUserTypes, we can put some logic here if needed 
	public EmployeeUserType GetDetails(int userTypeID , Int64 nationalCode)
	{
		return employeeUserTypeDb.GetDetails(userTypeID , nationalCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of employeeUserTypes, we can put some logic here if needed 
	public bool Delete(int userTypeID , Int64 nationalCode)
	{
		return employeeUserTypeDb.Delete(userTypeID , nationalCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of employeeUserTypes, we can put some logic here if needed 
	public Int64 Insert(EmployeeUserType employeeUserType)
	{
		return employeeUserTypeDb.Insert(employeeUserType);
	}

	public bool Exists(EmployeeUserType employeeUserType)
	{
		return employeeUserTypeDb.Exists(employeeUserType);
	}

	public bool Exists(int userTypeID , Int64 nationalCode)
	{
		return employeeUserTypeDb.Exists(userTypeID , nationalCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of employeeUserTypes, we can put some logic here if needed 
	public List<EmployeeUserType> SearchLike(EmployeeUserType employeeUserType)
	{
		return employeeUserTypeDb.SearchLike(employeeUserType);
	}

}
}
