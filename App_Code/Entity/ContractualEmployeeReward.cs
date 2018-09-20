using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rewards.DBA;

namespace Rewards.Models
{
[Serializable]
public partial class ContractualEmployeeReward
{
	private int yearTypeID;
	private int monthTypeID;
	private Int64 nationalCode;
	private Int64? totalReward;
	private Int64? reward_;
	private string employeeFullName;
	private string departmentIDTitle;
	private string yearTypeIDTitle;
	private string monthTypeIDTitle;
	private Int64 reward;
	private Int64 bossFinalValue;
	private Int64 assistantFinalValue;
	private Int64 managerFinalValue;
	private Int64 extraReward1;
	private Int64 extraReward2;
	private Int64 extraReward3;

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

	public Int64 NationalCode
	{
		get
		{
			return nationalCode;
		}
		set
		{
			nationalCode = value;
		}
	}

	public Int64? TotalReward
	{
		get
		{
			return totalReward;
		}
		set
		{
			totalReward = value;
		}
	}

	public Int64? Reward_
	{
		get
		{
			return reward_;
		}
		set
		{
			reward_ = value;
		}
	}

	public string EmployeeFullName
	{
		get
		{
			return employeeFullName;
		}
		set
		{
			employeeFullName = value;
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

	public Int64 Reward
	{
		get
		{
			return reward;
		}
		set
		{
			reward = value;
		}
	}

	public Int64 BossFinalValue
	{
		get
		{
			return bossFinalValue;
		}
		set
		{
			bossFinalValue = value;
		}
	}

	public Int64 AssistantFinalValue
	{
		get
		{
			return assistantFinalValue;
		}
		set
		{
			assistantFinalValue = value;
		}
	}

	public Int64 ManagerFinalValue
	{
		get
		{
			return managerFinalValue;
		}
		set
		{
			managerFinalValue = value;
		}
	}

	public Int64 ExtraReward1
	{
		get
		{
			return extraReward1;
		}
		set
		{
			extraReward1 = value;
		}
	}

	public Int64 ExtraReward2
	{
		get
		{
			return extraReward2;
		}
		set
		{
			extraReward2 = value;
		}
	}

	public Int64 ExtraReward3
	{
		get
		{
			return extraReward3;
		}
		set
		{
			extraReward3 = value;
		}
	}

}
}
