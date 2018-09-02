using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rewards.DBA;

namespace Rewards.Models
{
[Serializable]
public partial class MonthType
{
	private int monthTypeID;
	private string title;
	private List<BaseMonthlyInformation> baseMonthlyInformationList;
	private List<ContractualEmployeeReward> contractualEmployeeRewardList;
	private List<DepartmentMonthlyInformation> departmentMonthlyInformationList;
	private List<OfficialEmployeeReward> officialEmployeeRewardList;

	public int MonthTypeID
	{
		get
		{
			return monthTypeID;
		}
		set
		{
			monthTypeID = value;
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

	public List<BaseMonthlyInformation> GetListBaseMonthlyInformation()
	{
		BaseMonthlyInformationList = new MonthTypeDBAccess().GetListBaseMonthlyInformation(this.MonthTypeID);
		return BaseMonthlyInformationList;
	}

	public List<ContractualEmployeeReward> GetListContractualEmployeeReward()
	{
		ContractualEmployeeRewardList = new MonthTypeDBAccess().GetListContractualEmployeeReward(this.MonthTypeID);
		return ContractualEmployeeRewardList;
	}

	public List<DepartmentMonthlyInformation> GetListDepartmentMonthlyInformation()
	{
		DepartmentMonthlyInformationList = new MonthTypeDBAccess().GetListDepartmentMonthlyInformation(this.MonthTypeID);
		return DepartmentMonthlyInformationList;
	}

	public List<OfficialEmployeeReward> GetListOfficialEmployeeReward()
	{
		OfficialEmployeeRewardList = new MonthTypeDBAccess().GetListOfficialEmployeeReward(this.MonthTypeID);
		return OfficialEmployeeRewardList;
	}

	public bool AddBaseMonthlyInformation(BaseMonthlyInformation baseMonthlyInformation)
	{
		baseMonthlyInformation.MonthTypeID = this.MonthTypeID;
		BaseMonthlyInformationDBAccess baseMonthlyInformationDBAccess = new BaseMonthlyInformationDBAccess();
		if (baseMonthlyInformationDBAccess.Insert(baseMonthlyInformation)>0)
			return (true);
		return (false);
	}

	public bool AddContractualEmployeeReward(ContractualEmployeeReward contractualEmployeeReward)
	{
		contractualEmployeeReward.MonthTypeID = this.MonthTypeID;
		ContractualEmployeeRewardDBAccess contractualEmployeeRewardDBAccess = new ContractualEmployeeRewardDBAccess();
		if (contractualEmployeeRewardDBAccess.Insert(contractualEmployeeReward)>0)
			return (true);
		return (false);
	}

	public bool AddDepartmentMonthlyInformation(DepartmentMonthlyInformation departmentMonthlyInformation)
	{
		departmentMonthlyInformation.MonthTypeID = this.MonthTypeID;
		DepartmentMonthlyInformationDBAccess departmentMonthlyInformationDBAccess = new DepartmentMonthlyInformationDBAccess();
		if (departmentMonthlyInformationDBAccess.Insert(departmentMonthlyInformation)>0)
			return (true);
		return (false);
	}

	public bool AddOfficialEmployeeReward(OfficialEmployeeReward officialEmployeeReward)
	{
		officialEmployeeReward.MonthTypeID = this.MonthTypeID;
		OfficialEmployeeRewardDBAccess officialEmployeeRewardDBAccess = new OfficialEmployeeRewardDBAccess();
		if (officialEmployeeRewardDBAccess.Insert(officialEmployeeReward)>0)
			return (true);
		return (false);
	}

}
}
