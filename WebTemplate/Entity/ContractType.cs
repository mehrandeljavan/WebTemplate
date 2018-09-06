using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rewards.DBA;

namespace Rewards.Models
{
[Serializable]
public partial class ContractType
{
	private int contractTypeID;
	private string title;
	private List<Employee> employeeList;

	public int ContractTypeID
	{
		get
		{
			return contractTypeID;
		}
		set
		{
			contractTypeID = value;
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
		EmployeeList = new ContractTypeDBAccess().GetListEmployee(this.ContractTypeID);
		return EmployeeList;
	}

	public bool AddEmployee(Employee employee)
	{
		employee.ContractTypeID = this.ContractTypeID;
		EmployeeDBAccess employeeDBAccess = new EmployeeDBAccess();
		if (employeeDBAccess.Insert(employee)>0)
			return (true);
		return (false);
	}

}
}
