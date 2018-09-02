using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rewards.DBA;

namespace Rewards.Models
{
[Serializable]
public partial class BaseMonthlyInformation
{
	private int yearTypeID;
	private int monthTypeID;
	private int mainOfficeTypeID;
	private decimal? valueToScore;
	private Int64? totalOperationalReward;
	private Int64? totalOrganizationalReward;
	private Int64? contractualDividableReward;
	private Int64? contractualBossReward;
	private Int64? contractualDevotedReward;
	private Int64? contractualRemainingReward;
	private Int64? dividableReward;
	private Int64? bossReward;
	private Int64? devotedReward;
	private Int64? remainingReward;
	private string yearTypeIDTitle;
	private string monthTypeIDTitle;
	private Int64? contractualReward;
	private Int64? contractualConstantReward;
	private Int64? extraReward;
	private decimal factor5;
	private decimal factor6;
	private decimal factor7;
	private decimal factor8;
	private decimal factor9;
	private decimal factor10;
	private Int64? officialReward;
	private bool? isFanalized;
	private bool? isFainalizedEmployeesInformation;
	private bool? isFainalizedRewardCalculation;
	private decimal bossFactor;
	private decimal operationalFactor;
	private decimal factor1;
	private decimal factor2;
	private decimal factor3;
	private decimal factor4;

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

	public decimal? ValueToScore
	{
		get
		{
			return valueToScore;
		}
		set
		{
			valueToScore = value;
		}
	}

	public Int64? TotalOperationalReward
	{
		get
		{
			return totalOperationalReward;
		}
		set
		{
			totalOperationalReward = value;
		}
	}

	public Int64? TotalOrganizationalReward
	{
		get
		{
			return totalOrganizationalReward;
		}
		set
		{
			totalOrganizationalReward = value;
		}
	}

	public Int64? ContractualDividableReward
	{
		get
		{
			return contractualDividableReward;
		}
		set
		{
			contractualDividableReward = value;
		}
	}

	public Int64? ContractualBossReward
	{
		get
		{
			return contractualBossReward;
		}
		set
		{
			contractualBossReward = value;
		}
	}

	public Int64? ContractualDevotedReward
	{
		get
		{
			return contractualDevotedReward;
		}
		set
		{
			contractualDevotedReward = value;
		}
	}

	public Int64? ContractualRemainingReward
	{
		get
		{
			return contractualRemainingReward;
		}
		set
		{
			contractualRemainingReward = value;
		}
	}

	public Int64? DividableReward
	{
		get
		{
			return dividableReward;
		}
		set
		{
			dividableReward = value;
		}
	}

	public Int64? BossReward
	{
		get
		{
			return bossReward;
		}
		set
		{
			bossReward = value;
		}
	}

	public Int64? DevotedReward
	{
		get
		{
			return devotedReward;
		}
		set
		{
			devotedReward = value;
		}
	}

	public Int64? RemainingReward
	{
		get
		{
			return remainingReward;
		}
		set
		{
			remainingReward = value;
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

	public Int64? ContractualReward
	{
		get
		{
			return contractualReward;
		}
		set
		{
			contractualReward = value;
		}
	}

	public Int64? ContractualConstantReward
	{
		get
		{
			return contractualConstantReward;
		}
		set
		{
			contractualConstantReward = value;
		}
	}

	public Int64? ExtraReward
	{
		get
		{
			return extraReward;
		}
		set
		{
			extraReward = value;
		}
	}

	public decimal Factor5
	{
		get
		{
			return factor5;
		}
		set
		{
			factor5 = value;
		}
	}

	public decimal Factor6
	{
		get
		{
			return factor6;
		}
		set
		{
			factor6 = value;
		}
	}

	public decimal Factor7
	{
		get
		{
			return factor7;
		}
		set
		{
			factor7 = value;
		}
	}

	public decimal Factor8
	{
		get
		{
			return factor8;
		}
		set
		{
			factor8 = value;
		}
	}

	public decimal Factor9
	{
		get
		{
			return factor9;
		}
		set
		{
			factor9 = value;
		}
	}

	public decimal Factor10
	{
		get
		{
			return factor10;
		}
		set
		{
			factor10 = value;
		}
	}

	public Int64? OfficialReward
	{
		get
		{
			return officialReward;
		}
		set
		{
			officialReward = value;
		}
	}

	public bool? IsFanalized
	{
		get
		{
			return isFanalized;
		}
		set
		{
			isFanalized = value;
		}
	}

	public bool? IsFainalizedEmployeesInformation
	{
		get
		{
			return isFainalizedEmployeesInformation;
		}
		set
		{
			isFainalizedEmployeesInformation = value;
		}
	}

	public bool? IsFainalizedRewardCalculation
	{
		get
		{
			return isFainalizedRewardCalculation;
		}
		set
		{
			isFainalizedRewardCalculation = value;
		}
	}

	public decimal BossFactor
	{
		get
		{
			return bossFactor;
		}
		set
		{
			bossFactor = value;
		}
	}

	public decimal OperationalFactor
	{
		get
		{
			return operationalFactor;
		}
		set
		{
			operationalFactor = value;
		}
	}

	public decimal Factor1
	{
		get
		{
			return factor1;
		}
		set
		{
			factor1 = value;
		}
	}

	public decimal Factor2
	{
		get
		{
			return factor2;
		}
		set
		{
			factor2 = value;
		}
	}

	public decimal Factor3
	{
		get
		{
			return factor3;
		}
		set
		{
			factor3 = value;
		}
	}

	public decimal Factor4
	{
		get
		{
			return factor4;
		}
		set
		{
			factor4 = value;
		}
	}

}
}
