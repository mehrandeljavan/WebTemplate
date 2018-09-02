using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rewards.DBA;

namespace Rewards.Models
{
[Serializable]
public partial class EmployeeUserType
{
	private int userTypeID;
	private Int64 nationalCode;
	private string employeeFullName;
	private string userTypeIDTitle;

	public int UserTypeID
	{
		get
		{
			return userTypeID;
		}
		set
		{
			userTypeID = value;
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

	public string UserTypeIDTitle
	{
		get
		{
			return userTypeIDTitle;
		}
		set
		{
			userTypeIDTitle = value;
		}
	}

}
}
