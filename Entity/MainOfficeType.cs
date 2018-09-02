using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rewards.DBA;

namespace Rewards.Models
{
[Serializable]
public partial class MainOfficeType
{
	private int mainOfficeTypeID;
	private Int64? contractualEmployeesNumber;
	private string title;
	private decimal? totalScore;
	private decimal? totalScoreCat1;
	private decimal? totalScoreCat2;
	private List<BaseMonthlyInformation> baseMonthlyInformationList;
	private List<Department> departmentList;
	private List<OfficialEmployeeReward> officialEmployeeRewardList;
	private List<ContractualEmployeeReward> contractualEmployeeRewardList;

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

	public Int64? ContractualEmployeesNumber
	{
		get
		{
			return contractualEmployeesNumber;
		}
		set
		{
			contractualEmployeesNumber = value;
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

	public decimal? TotalScore
	{
		get
		{
			return totalScore;
		}
		set
		{
			totalScore = value;
		}
	}

	public decimal? TotalScoreCat1
	{
		get
		{
			return totalScoreCat1;
		}
		set
		{
			totalScoreCat1 = value;
		}
	}

	public decimal? TotalScoreCat2
	{
		get
		{
			return totalScoreCat2;
		}
		set
		{
			totalScoreCat2 = value;
		}
	}

	public List<BaseMonthlyInformation> BaseMonthlyInformationList
	{
		get
		{
			return baseMonthlyInformationList;
		}
		set
		{
			baseMonthlyInformationList = value;
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

	public List<BaseMonthlyInformation> GetListBaseMonthlyInformation()
	{
		BaseMonthlyInformationList = new MainOfficeTypeDBAccess().GetListBaseMonthlyInformation(this.MainOfficeTypeID);
		return BaseMonthlyInformationList;
	}

	public List<Department> GetListDepartment()
	{
		DepartmentList = new MainOfficeTypeDBAccess().GetListDepartment(this.MainOfficeTypeID);
		return DepartmentList;
	}

	public List<OfficialEmployeeReward> GetListOfficialEmployeeReward()
	{
		OfficialEmployeeRewardList = new MainOfficeTypeDBAccess().GetListOfficialEmployeeReward(this.MainOfficeTypeID);
		return OfficialEmployeeRewardList;
	}

	public List<ContractualEmployeeReward> GetListContractualEmployeeReward()
	{
		ContractualEmployeeRewardList = new MainOfficeTypeDBAccess().GetListContractualEmployeeReward(this.MainOfficeTypeID);
		return ContractualEmployeeRewardList;
	}

	public bool AddBaseMonthlyInformation(BaseMonthlyInformation baseMonthlyInformation)
	{
		baseMonthlyInformation.MainOfficeTypeID = this.MainOfficeTypeID;
		BaseMonthlyInformationDBAccess baseMonthlyInformationDBAccess = new BaseMonthlyInformationDBAccess();
		if (baseMonthlyInformationDBAccess.Insert(baseMonthlyInformation)>0)
			return (true);
		return (false);
	}

	public bool AddDepartment(Department department)
	{
		department.MainOfficeTypeID = this.MainOfficeTypeID;
		DepartmentDBAccess departmentDBAccess = new DepartmentDBAccess();
		if (departmentDBAccess.Insert(department)>0)
			return (true);
		return (false);
	}

}
}
