using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rewards.DBA;

namespace Rewards.Models
{
[Serializable]
public partial class UserType
{
	private int userTypeID;
	private string title;
	private List<ActivityUserType> activityUserTypeList;
	private List<EmployeeUserType> employeeUserTypeList;

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

	public List<ActivityUserType> ActivityUserTypeList
	{
		get
		{
			return activityUserTypeList;
		}
		set
		{
			activityUserTypeList = value;
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

	public List<ActivityUserType> GetListActivityUserType()
	{
		ActivityUserTypeList = new UserTypeDBAccess().GetListActivityUserType(this.UserTypeID);
		return ActivityUserTypeList;
	}

	public List<EmployeeUserType> GetListEmployeeUserType()
	{
		EmployeeUserTypeList = new UserTypeDBAccess().GetListEmployeeUserType(this.UserTypeID);
		return EmployeeUserTypeList;
	}

	public bool AddActivityUserType(ActivityUserType activityUserType)
	{
		activityUserType.UserTypeID = this.UserTypeID;
		ActivityUserTypeDBAccess activityUserTypeDBAccess = new ActivityUserTypeDBAccess();
		if (activityUserTypeDBAccess.Insert(activityUserType)>0)
			return (true);
		return (false);
	}

	public bool AddEmployeeUserType(EmployeeUserType employeeUserType)
	{
		employeeUserType.UserTypeID = this.UserTypeID;
		EmployeeUserTypeDBAccess employeeUserTypeDBAccess = new EmployeeUserTypeDBAccess();
		if (employeeUserTypeDBAccess.Insert(employeeUserType)>0)
			return (true);
		return (false);
	}

}
}
