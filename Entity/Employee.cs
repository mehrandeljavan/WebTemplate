using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rewards.DBA;

namespace Rewards.Models
{
[Serializable]
public partial class Employee
{
	private Int64 nationalCode;
	private string roleTypeIDTitle;
	private string fullName;
	private string departmentIDTitle;
	private string contractTypeIDTitle;
	private decimal? roleTypeIDFactor;
	private string password;
	private string personalCode;
	private string lastPassChangeDate;
	private string firstName;
	private string lastName;
	private string accountNumber;
	private int? contractTypeID;
	private int? roleTypeID;
	private int? departmentID;
	private bool isActiveEmployee;
	private bool? isActiveUser;
	private List<ContractualEmployeeReward> contractualEmployeeRewardList;
	private List<EmployeeUserType> employeeUserTypeList;
	private List<OfficialEmployeeReward> officialEmployeeRewardList;

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

	public string RoleTypeIDTitle
	{
		get
		{
			return roleTypeIDTitle;
		}
		set
		{
			roleTypeIDTitle = value;
		}
	}

	public string FullName
	{
		get
		{
			return fullName;
		}
		set
		{
			fullName = value;
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

	public string ContractTypeIDTitle
	{
		get
		{
			return contractTypeIDTitle;
		}
		set
		{
			contractTypeIDTitle = value;
		}
	}

	public decimal? RoleTypeIDFactor
	{
		get
		{
			return roleTypeIDFactor;
		}
		set
		{
			roleTypeIDFactor = value;
		}
	}

	public string Password
	{
		get
		{
			return password;
		}
		set
		{
			password = value;
		}
	}

	public string PersonalCode
	{
		get
		{
			return personalCode;
		}
		set
		{
			personalCode = value;
		}
	}

	public string LastPassChangeDate
	{
		get
		{
			return lastPassChangeDate;
		}
		set
		{
			lastPassChangeDate = value;
		}
	}

	public string FirstName
	{
		get
		{
			return firstName;
		}
		set
		{
			firstName = value;
		}
	}

	public string LastName
	{
		get
		{
			return lastName;
		}
		set
		{
			lastName = value;
		}
	}

	public string AccountNumber
	{
		get
		{
			return accountNumber;
		}
		set
		{
			accountNumber = value;
		}
	}

	public int? ContractTypeID
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

	public int? RoleTypeID
	{
		get
		{
			return roleTypeID;
		}
		set
		{
			roleTypeID = value;
		}
	}

	public int? DepartmentID
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

	public bool IsActiveEmployee
	{
		get
		{
			return isActiveEmployee;
		}
		set
		{
			isActiveEmployee = value;
		}
	}

	public bool? IsActiveUser
	{
		get
		{
			return isActiveUser;
		}
		set
		{
			isActiveUser = value;
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

	public List<EmployeeUserType> EmployeeUserTypeList
	{
		get
		{
			return employeeUserTypeList;
		}
		set
		{
			employeeUserTypeList = value;
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

	public List<ContractualEmployeeReward> GetListContractualEmployeeReward()
	{
		ContractualEmployeeRewardList = new EmployeeDBAccess().GetListContractualEmployeeReward(this.NationalCode);
		return ContractualEmployeeRewardList;
	}

	public List<EmployeeUserType> GetListEmployeeUserType()
	{
		EmployeeUserTypeList = new EmployeeDBAccess().GetListEmployeeUserType(this.NationalCode);
		return EmployeeUserTypeList;
	}

	public List<OfficialEmployeeReward> GetListOfficialEmployeeReward()
	{
		OfficialEmployeeRewardList = new EmployeeDBAccess().GetListOfficialEmployeeReward(this.NationalCode);
		return OfficialEmployeeRewardList;
	}

	public bool AddContractualEmployeeReward(ContractualEmployeeReward contractualEmployeeReward)
	{
		contractualEmployeeReward.NationalCode = this.NationalCode;
		ContractualEmployeeRewardDBAccess contractualEmployeeRewardDBAccess = new ContractualEmployeeRewardDBAccess();
		if (contractualEmployeeRewardDBAccess.Insert(contractualEmployeeReward)>0)
			return (true);
		return (false);
	}

	public bool AddEmployeeUserType(EmployeeUserType employeeUserType)
	{
		employeeUserType.NationalCode = this.NationalCode;
		EmployeeUserTypeDBAccess employeeUserTypeDBAccess = new EmployeeUserTypeDBAccess();
		if (employeeUserTypeDBAccess.Insert(employeeUserType)>0)
			return (true);
		return (false);
	}

	public bool AddOfficialEmployeeReward(OfficialEmployeeReward officialEmployeeReward)
	{
		officialEmployeeReward.NationalCode = this.NationalCode;
		OfficialEmployeeRewardDBAccess officialEmployeeRewardDBAccess = new OfficialEmployeeRewardDBAccess();
		if (officialEmployeeRewardDBAccess.Insert(officialEmployeeReward)>0)
			return (true);
		return (false);
	}

}
}
