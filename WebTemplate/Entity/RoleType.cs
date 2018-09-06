using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rewards.DBA;

namespace Rewards.Models
{
[Serializable]
public partial class RoleType
{
	private int roleTypeID;
	private decimal factor;
	private string title;
	private List<Employee> employeeList;

	public int RoleTypeID
	{
		get
		{
			return roleTypeID;
		}
		set
		{
			roleTypeID = value;
		}
	}

	public decimal Factor
	{
		get
		{
			return factor;
		}
		set
		{
			factor = value;
		}
	}

	public string Title
	{
		get
		{
			return title;
		}
		set
		{
			title = value;
		}
	}

	public List<Employee> EmployeeList
	{
		get
		{
			return employeeList;
		}
		set
		{
			employeeList = value;
		}
	}

	public List<Employee> GetListEmployee()
	{
		EmployeeList = new RoleTypeDBAccess().GetListEmployee(this.RoleTypeID);
		return EmployeeList;
	}

	public bool AddEmployee(Employee employee)
	{
		employee.RoleTypeID = this.RoleTypeID;
		EmployeeDBAccess employeeDBAccess = new EmployeeDBAccess();
		if (employeeDBAccess.Insert(employee)>0)
			return (true);
		return (false);
	}

}
}
