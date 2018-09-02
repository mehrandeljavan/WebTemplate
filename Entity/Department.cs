using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rewards.DBA;

namespace Rewards.Models
{
[Serializable]
public partial class Department
{
	private int departmentID;
	private string dividerFullName;
	private string computationTypeIDTitle;
	private string mainOfficeTypeIDTitle;
	private string adjutancyTypeIDTitle;
	private int? computationTypeID;
	private int mainOfficeTypeID;
	private int? adjutancyTypeID;
	private int? totalEmployeeNumber;
	private int? totalContractualEmployeeNumber;
	private decimal? totalPersonalScore;
	private Int64? dividerNationalCode;
	private string title;
	private List<DepartmentMonthlyInformation> departmentMonthlyInformationList;
	private List<Employee> employeeList;
	private List<OfficialEmployeeReward> officialEmployeeRewardList;
	private List<ContractualEmployeeReward> contractualEmployeeRewardList;

	public int DepartmentID
	{
		get
		{
			return departmentID;
		}
		set
		{
			departmentID = value;
		}
	}

	public string DividerFullName
	{
		get
		{
			return dividerFullName;
		}
		set
		{
			dividerFullName = value;
		}
	}

	public string ComputationTypeIDTitle
	{
		get
		{
			return computationTypeIDTitle;
		}
		set
		{
			computationTypeIDTitle = value;
		}
	}

	public string MainOfficeTypeIDTitle
	{
		get
		{
			return mainOfficeTypeIDTitle;
		}
		set
		{
			mainOfficeTypeIDTitle = value;
		}
	}

	public string AdjutancyTypeIDTitle
	{
		get
		{
			return adjutancyTypeIDTitle;
		}
		set
		{
			adjutancyTypeIDTitle = value;
		}
	}

	public int? ComputationTypeID
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

	public int MainOfficeTypeID
	{
		get
		{
			return mainOfficeTypeID;
		}
		set
		{
			mainOfficeTypeID = value;
		}
	}

	public int? AdjutancyTypeID
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

	public int? TotalEmployeeNumber
	{
		get
		{
			return totalEmployeeNumber;
		}
		set
		{
			totalEmployeeNumber = value;
		}
	}

	public int? TotalContractualEmployeeNumber
	{
		get
		{
			return totalContractualEmployeeNumber;
		}
		set
		{
			totalContractualEmployeeNumber = value;
		}
	}

	public decimal? TotalPersonalScore
	{
		get
		{
			return totalPersonalScore;
		}
		set
		{
			totalPersonalScore = value;
		}
	}

	public Int64? DividerNationalCode
	{
		get
		{
			return dividerNationalCode;
		}
		set
		{
			dividerNationalCode = value;
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

	public List<OfficialEmployeeReward> OfficialEmployeeRewardList
	{
		get
		{
			return officialEmployeeRewardList;
		}
		set
		{
			officialEmployeeRewardList = value;
		}
	}

	public List<ContractualEmployeeReward> ContractualEmployeeRewardList
	{
		get
		{
			return contractualEmployeeRewardList;
		}
		set
		{
			contractualEmployeeRewardList = value;
		}
	}

	public List<DepartmentMonthlyInformation> GetListDepartmentMonthlyInformation()
	{
		DepartmentMonthlyInformationList = new DepartmentDBAccess().GetListDepartmentMonthlyInformation(this.DepartmentID);
		return DepartmentMonthlyInformationList;
	}

	public List<Employee> GetListEmployee()
	{
		EmployeeList = new DepartmentDBAccess().GetListEmployee(this.DepartmentID);
		return EmployeeList;
	}

	public List<OfficialEmployeeReward> GetListOfficialEmployeeReward()
	{
		OfficialEmployeeRewardList = new DepartmentDBAccess().GetListOfficialEmployeeReward(this.DepartmentID);
		return OfficialEmployeeRewardList;
	}

	public List<ContractualEmployeeReward> GetListContractualEmployeeReward()
	{
		ContractualEmployeeRewardList = new DepartmentDBAccess().GetListContractualEmployeeReward(this.DepartmentID);
		return ContractualEmployeeRewardList;
	}

	public bool AddDepartmentMonthlyInformation(DepartmentMonthlyInformation departmentMonthlyInformation)
	{
		departmentMonthlyInformation.DepartmentID = this.DepartmentID;
		DepartmentMonthlyInformationDBAccess departmentMonthlyInformationDBAccess = new DepartmentMonthlyInformationDBAccess();
		if (departmentMonthlyInformationDBAccess.Insert(departmentMonthlyInformation)>0)
			return (true);
		return (false);
	}

	public bool AddEmployee(Employee employee)
	{
		employee.DepartmentID = this.DepartmentID;
		EmployeeDBAccess employeeDBAccess = new EmployeeDBAccess();
		if (employeeDBAccess.Insert(employee)>0)
			return (true);
		return (false);
	}

}
}
