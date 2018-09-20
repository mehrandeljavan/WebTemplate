using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rewards.DBA;

namespace Rewards.Models
{
[Serializable]
public partial class YearType
{
	private int yearTypeID;
	private string title;
	private List<BaseMonthlyInformation> baseMonthlyInformationList;
	private List<ContractualEmployeeReward> contractualEmployeeRewardList;
	private List<DepartmentMonthlyInformation> departmentMonthlyInformationList;
	private List<OfficialEmployeeReward> officialEmployeeRewardList;

	public int YearTypeID
	{
		get
		{
			return yearTypeID;
		}
		set
		{
			yearTypeID = value;
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
		BaseMonthlyInformationList = new YearTypeDBAccess().GetListBaseMonthlyInformation(this.YearTypeID);
		return BaseMonthlyInformationList;
	}

	public List<ContractualEmployeeReward> GetListContractualEmployeeReward()
	{
		ContractualEmployeeRewardList = new YearTypeDBAccess().GetListContractualEmployeeReward(this.YearTypeID);
		return ContractualEmployeeRewardList;
	}

	public List<DepartmentMonthlyInformation> GetListDepartmentMonthlyInformation()
	{
		DepartmentMonthlyInformationList = new YearTypeDBAccess().GetListDepartmentMonthlyInformation(this.YearTypeID);
		return DepartmentMonthlyInformationList;
	}

	public List<OfficialEmployeeReward> GetListOfficialEmployeeReward()
	{
		OfficialEmployeeRewardList = new YearTypeDBAccess().GetListOfficialEmployeeReward(this.YearTypeID);
		return OfficialEmployeeRewardList;
	}

	public bool AddBaseMonthlyInformation(BaseMonthlyInformation baseMonthlyInformation)
	{
		baseMonthlyInformation.YearTypeID = this.YearTypeID;
		BaseMonthlyInformationDBAccess baseMonthlyInformationDBAccess = new BaseMonthlyInformationDBAccess();
		if (baseMonthlyInformationDBAccess.Insert(baseMonthlyInformation)>0)
			return (true);
		return (false);
	}

	public bool AddContractualEmployeeReward(ContractualEmployeeReward contractualEmployeeReward)
	{
		contractualEmployeeReward.YearTypeID = this.YearTypeID;
		ContractualEmployeeRewardDBAccess contractualEmployeeRewardDBAccess = new ContractualEmployeeRewardDBAccess();
		if (contractualEmployeeRewardDBAccess.Insert(contractualEmployeeReward)>0)
			return (true);
		return (false);
	}

	public bool AddDepartmentMonthlyInformation(DepartmentMonthlyInformation departmentMonthlyInformation)
	{
		departmentMonthlyInformation.YearTypeID = this.YearTypeID;
		DepartmentMonthlyInformationDBAccess departmentMonthlyInformationDBAccess = new DepartmentMonthlyInformationDBAccess();
		if (departmentMonthlyInformationDBAccess.Insert(departmentMonthlyInformation)>0)
			return (true);
		return (false);
	}

	public bool AddOfficialEmployeeReward(OfficialEmployeeReward officialEmployeeReward)
	{
		officialEmployeeReward.YearTypeID = this.YearTypeID;
		OfficialEmployeeRewardDBAccess officialEmployeeRewardDBAccess = new OfficialEmployeeRewardDBAccess();
		if (officialEmployeeRewardDBAccess.Insert(officialEmployeeReward)>0)
			return (true);
		return (false);
	}

}
}
