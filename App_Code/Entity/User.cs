using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rewards.DBA;

namespace Rewards.Models
{
[Serializable]
public partial class User : Employee
{
	private string password;
	private string lastPassChangeDate;
	private bool? isActiveUser;

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

}
}
