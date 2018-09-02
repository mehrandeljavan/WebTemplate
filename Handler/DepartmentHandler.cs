using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.DBA;

namespace Rewards.Models
{
public class DepartmentHandler
{
	// Handle to the Department DBAccess class
	DepartmentDBAccess departmentDb = null;

	public DepartmentHandler()
	{
		departmentDb = new DepartmentDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of departments, we can put some logic here if needed 
	public List<Department> GetListAll()
	{
		return departmentDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of departments, we can put some logic here if needed 
	public bool Update(Department department)
	{
		return departmentDb.Update(department);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of departments, we can put some logic here if needed 
	public Department GetDetails(int departmentID)
	{
		return departmentDb.GetDetails(departmentID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of departments, we can put some logic here if needed 
	public bool Delete(int departmentID)
	{
		return departmentDb.Delete(departmentID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of departments, we can put some logic here if needed 
	public Int64 Insert(Department department)
	{
		return departmentDb.Insert(department);
	}

	public bool Exists(Department department)
	{
		return departmentDb.Exists(department);
	}

	public bool Exists(int departmentID)
	{
		return departmentDb.Exists(departmentID);
	}

	public List<DepartmentMonthlyInformation> GetListDepartmentMonthlyInformation(int departmentID)
	{
		return departmentDb.GetListDepartmentMonthlyInformation(departmentID);
	}

	public List<Employee> GetListEmployee(int departmentID)
	{
		return departmentDb.GetListEmployee(departmentID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of departments, we can put some logic here if needed 
	public List<Department> SearchLike(Department department)
	{
		return departmentDb.SearchLike(department);
	}

}
}
