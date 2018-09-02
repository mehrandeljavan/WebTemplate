using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rewards.DBA;

namespace Rewards.Models
{
[Serializable]
public partial class AdjutancyType
{
	private int adjutancyTypeID;
	private string adjutantFullName;
	private Int64? adjutantNationalCode;
	private string title;
	private List<Department> departmentList;
	private List<DepartmentMonthlyInformation> departmentMonthlyInformationList;

	public int AdjutancyTypeID
	{
		get
		{
			return adjutancyTypeID;
		}
		set
		{
			adjutancyTypeID = value;
		}
	}

	public string AdjutantFullName
	{
		get
		{
			return adjutantFullName;
		}
		set
		{
			adjutantFullName = value;
		}
	}

	public Int64? AdjutantNationalCode
	{
		get
		{
			return adjutantNationalCode;
		}
		set
		{
			adjutantNationalCode = value;
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

	public List<DepartmentMonthlyInformation> DepartmentMonthlyInformationList
	{
		get
		{
			return departmentMonthlyInformationList;
		}
		set
		{
			departmentMonthlyInformationList = value;
		}
	}

	public List<Department> GetListDepartment()
	{
		DepartmentList = new AdjutancyTypeDBAccess().GetListDepartment(this.AdjutancyTypeID);
		return DepartmentList;
	}

	public List<DepartmentMonthlyInformation> GetListDepartmentMonthlyInformation()
	{
		DepartmentMonthlyInformationList = new AdjutancyTypeDBAccess().GetListDepartmentMonthlyInformation(this.AdjutancyTypeID);
		return DepartmentMonthlyInformationList;
	}

	public bool AddDepartment(Department department)
	{
		department.AdjutancyTypeID = this.AdjutancyTypeID;
		DepartmentDBAccess departmentDBAccess = new DepartmentDBAccess();
		if (departmentDBAccess.Insert(department)>0)
			return (true);
		return (false);
	}

}
}
