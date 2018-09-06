using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.DBA;

namespace Rewards.Models
{
public class EmployeeHandler
{
	// Handle to the Employee DBAccess class
	EmployeeDBAccess employeeDb = null;

	public EmployeeHandler()
	{
		employeeDb = new EmployeeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of employees, we can put some logic here if needed 
	public List<Employee> GetListAll()
	{
		return employeeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of employees, we can put some logic here if needed 
	public bool Update(Employee employee)
	{
		return employeeDb.Update(employee);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of employees, we can put some logic here if needed 
	public Employee GetDetails(Int64 nationalCode)
	{
		return employeeDb.GetDetails(nationalCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of employees, we can put some logic here if needed 
	public bool Delete(Int64 nationalCode)
	{
		return employeeDb.Delete(nationalCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of employees, we can put some logic here if needed 
	public Int64 Insert(Employee employee)
	{
		return employeeDb.Insert(employee);
	}

	public bool Exists(Employee employee)
	{
		return employeeDb.Exists(employee);
	}

	public bool Exists(Int64 nationalCode)
	{
		return employeeDb.Exists(nationalCode);
	}

	public List<ContractualEmployeeReward> GetListContractualEmployeeReward(Int64 nationalCode)
	{
		return employeeDb.GetListContractualEmployeeReward(nationalCode);
	}

	public List<EmployeeUserType> GetListEmployeeUserType(Int64 nationalCode)
	{
		return employeeDb.GetListEmployeeUserType(nationalCode);
	}

	public List<OfficialEmployeeReward> GetListOfficialEmployeeReward(Int64 nationalCode)
	{
		return employeeDb.GetListOfficialEmployeeReward(nationalCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of employees, we can put some logic here if needed 
	public List<Employee> SearchLike(Employee employee)
	{
		return employeeDb.SearchLike(employee);
	}

}
}
