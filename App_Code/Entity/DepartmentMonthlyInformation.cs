using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rewards.DBA;

namespace Rewards.Models
{
[Serializable]
public partial class DepartmentMonthlyInformation
{
	private int yearTypeID;
	private int monthTypeID;
	private int departmentID;
	private int? adjutancyTypeID;
	private float? value1;
	private float? operationalReward_Average;
	private float? operationalRewardAverage;
	private decimal? value2;
	private decimal? operationalScore;
	private decimal? totalParameter1;
	private decimal? totalParameter2;
	private decimal? totalParameter3;
	private decimal? totalBossFactor;
	private Int64? totalReward_;
	private Int64? organizationalReward_;
	private Int64? operationalReward_;
	private Int64? totalReward_Average;
	private string yearTypeIDTitle;
	private string monthTypeIDTitle;
	private string departmentIDTitle;
	private Int64? rewardPerEmployee;
	private Int64? operationalRewardCalculated;
	private Int64? operationalReward;
	private Int64? organizationalRewardCalculated;
	private Int64? organizationalReward;
	private Int64 monthlyProceed;
	private Int64 desiredMonthlyProceed;
	private Int64 lastYearProceed;
	private bool statisticsFinalalization;
	private bool assistantRewardsFinalization;
	private bool managerRewardsFinalization;
	private bool isOfficialRewardsFinalizedBoss;
	private bool isOfficialRewardsFinalizedAssistant;
	private bool isOfficialRewardsFinalizedManager;
	private bool contractualRewardsFinalization;
	private bool isContractualRewardsFinalizedBoss;
	private bool isContractualRewardsFinalizedAssistant;
	private bool isContractualRewardsFinalizedManager;
	private int dossierNumber;
	private int value3;
	private int value4;
	private int value5;
	private int value6;
	private int employeeNumber;
	private int contractualEmployeeNumber;

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

	public float? Value1
	{
		get
		{
			return value1;
		}
		set
		{
			value1 = value;
		}
	}

	public float? OperationalReward_Average
	{
		get
		{
			return operationalReward_Average;
		}
		set
		{
			operationalReward_Average = value;
		}
	}

	public float? OperationalRewardAverage
	{
		get
		{
			return operationalRewardAverage;
		}
		set
		{
			operationalRewardAverage = value;
		}
	}

	public decimal? Value2
	{
		get
		{
			return value2;
		}
		set
		{
			value2 = value;
		}
	}

	public decimal? OperationalScore
	{
		get
		{
			return operationalScore;
		}
		set
		{
			operationalScore = value;
		}
	}

	public decimal? TotalParameter1
	{
		get
		{
			return totalParameter1;
		}
		set
		{
			totalParameter1 = value;
		}
	}

	public decimal? TotalParameter2
	{
		get
		{
			return totalParameter2;
		}
		set
		{
			totalParameter2 = value;
		}
	}

	public decimal? TotalParameter3
	{
		get
		{
			return totalParameter3;
		}
		set
		{
			totalParameter3 = value;
		}
	}

	public decimal? TotalBossFactor
	{
		get
		{
			return totalBossFactor;
		}
		set
		{
			totalBossFactor = value;
		}
	}

	public Int64? TotalReward_
	{
		get
		{
			return totalReward_;
		}
		set
		{
			totalReward_ = value;
		}
	}

	public Int64? OrganizationalReward_
	{
		get
		{
			return organizationalReward_;
		}
		set
		{
			organizationalReward_ = value;
		}
	}

	public Int64? OperationalReward_
	{
		get
		{
			return operationalReward_;
		}
		set
		{
			operationalReward_ = value;
		}
	}

	public Int64? TotalReward_Average
	{
		get
		{
			return totalReward_Average;
		}
		set
		{
			totalReward_Average = value;
		}
	}

	public string YearTypeIDTitle
	{
		get
		{
			return yearTypeIDTitle;
		}
		set
		{
			yearTypeIDTitle = value;
		}
	}

	public string MonthTypeIDTitle
	{
		get
		{
			return monthTypeIDTitle;
		}
		set
		{
			monthTypeIDTitle = value;
		}
	}

	public string DepartmentIDTitle
	{
		get
		{
			return departmentIDTitle;
		}
		set
		{
			departmentIDTitle = value;
		}
	}

	public Int64? RewardPerEmployee
	{
		get
		{
			return rewardPerEmployee;
		}
		set
		{
			rewardPerEmployee = value;
		}
	}

	public Int64? OperationalRewardCalculated
	{
		get
		{
			return operationalRewardCalculated;
		}
		set
		{
			operationalRewardCalculated = value;
		}
	}

	public Int64? OperationalReward
	{
		get
		{
			return operationalReward;
		}
		set
		{
			operationalReward = value;
		}
	}

	public Int64? OrganizationalRewardCalculated
	{
		get
		{
			return organizationalRewardCalculated;
		}
		set
		{
			organizationalRewardCalculated = value;
		}
	}

	public Int64? OrganizationalReward
	{
		get
		{
			return organizationalReward;
		}
		set
		{
			organizationalReward = value;
		}
	}

	public Int64 MonthlyProceed
	{
		get
		{
			return monthlyProceed;
		}
		set
		{
			monthlyProceed = value;
		}
	}

	public Int64 DesiredMonthlyProceed
	{
		get
		{
			return desiredMonthlyProceed;
		}
		set
		{
			desiredMonthlyProceed = value;
		}
	}

	public Int64 LastYearProceed
	{
		get
		{
			return lastYearProceed;
		}
		set
		{
			lastYearProceed = value;
		}
	}

	public bool StatisticsFinalalization
	{
		get
		{
			return statisticsFinalalization;
		}
		set
		{
			statisticsFinalalization = value;
		}
	}

	public bool AssistantRewardsFinalization
	{
		get
		{
			return assistantRewardsFinalization;
		}
		set
		{
			assistantRewardsFinalization = value;
		}
	}

	public bool ManagerRewardsFinalization
	{
		get
		{
			return managerRewardsFinalization;
		}
		set
		{
			managerRewardsFinalization = value;
		}
	}

	public bool IsOfficialRewardsFinalizedBoss
	{
		get
		{
			return isOfficialRewardsFinalizedBoss;
		}
		set
		{
			isOfficialRewardsFinalizedBoss = value;
		}
	}

	public bool IsOfficialRewardsFinalizedAssistant
	{
		get
		{
			return isOfficialRewardsFinalizedAssistant;
		}
		set
		{
			isOfficialRewardsFinalizedAssistant = value;
		}
	}

	public bool IsOfficialRewardsFinalizedManager
	{
		get
		{
			return isOfficialRewardsFinalizedManager;
		}
		set
		{
			isOfficialRewardsFinalizedManager = value;
		}
	}

	public bool ContractualRewardsFinalization
	{
		get
		{
			return contractualRewardsFinalization;
		}
		set
		{
			contractualRewardsFinalization = value;
		}
	}

	public bool IsContractualRewardsFinalizedBoss
	{
		get
		{
			return isContractualRewardsFinalizedBoss;
		}
		set
		{
			isContractualRewardsFinalizedBoss = value;
		}
	}

	public bool IsContractualRewardsFinalizedAssistant
	{
		get
		{
			return isContractualRewardsFinalizedAssistant;
		}
		set
		{
			isContractualRewardsFinalizedAssistant = value;
		}
	}

	public bool IsContractualRewardsFinalizedManager
	{
		get
		{
			return isContractualRewardsFinalizedManager;
		}
		set
		{
			isContractualRewardsFinalizedManager = value;
		}
	}

	public int DossierNumber
	{
		get
		{
			return dossierNumber;
		}
		set
		{
			dossierNumber = value;
		}
	}

	public int Value3
	{
		get
		{
			return value3;
		}
		set
		{
			value3 = value;
		}
	}

	public int Value4
	{
		get
		{
			return value4;
		}
		set
		{
			value4 = value;
		}
	}

	public int Value5
	{
		get
		{
			return value5;
		}
		set
		{
			value5 = value;
		}
	}

	public int Value6
	{
		get
		{
			return value6;
		}
		set
		{
			value6 = value;
		}
	}

	public int EmployeeNumber
	{
		get
		{
			return employeeNumber;
		}
		set
		{
			employeeNumber = value;
		}
	}

	public int ContractualEmployeeNumber
	{
		get
		{
			return contractualEmployeeNumber;
		}
		set
		{
			contractualEmployeeNumber = value;
		}
	}

}
}
