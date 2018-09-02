using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rewards.DBA;

namespace Rewards.Models
{
[Serializable]
public partial class ComputationType
{
	private int computationTypeID;
	private string title;
	private List<Department> departmentList;

	public int ComputationTypeID
	{
		get
		{
			return computationTypeID;
		}
		set
		{
			computationTypeID = value;
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

	public List<Department> DepartmentList
	{
		get
		{
			return departmentList;
		}
		set
		{
			departmentList = value;
		}
	}

	public List<Department> GetListDepartment()
	{
		DepartmentList = new ComputationTypeDBAccess().GetListDepartment(this.ComputationTypeID);
		return DepartmentList;
	}

	public bool AddDepartment(Department department)
	{
		department.ComputationTypeID = this.ComputationTypeID;
		DepartmentDBAccess departmentDBAccess = new DepartmentDBAccess();
		if (departmentDBAccess.Insert(department)>0)
			return (true);
		return (false);
	}

}
}
