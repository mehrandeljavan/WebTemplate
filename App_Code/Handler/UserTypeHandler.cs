using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.DBA;

namespace Rewards.Models
{
public class UserTypeHandler
{
	// Handle to the UserType DBAccess class
	UserTypeDBAccess userTypeDb = null;

	public UserTypeHandler()
	{
		userTypeDb = new UserTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of userTypes, we can put some logic here if needed 
	public List<UserType> GetListAll()
	{
		return userTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of userTypes, we can put some logic here if needed 
	public bool Update(UserType userType)
	{
		return userTypeDb.Update(userType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of userTypes, we can put some logic here if needed 
	public UserType GetDetails(int userTypeID)
	{
		return userTypeDb.GetDetails(userTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of userTypes, we can put some logic here if needed 
	public bool Delete(int userTypeID)
	{
		return userTypeDb.Delete(userTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of userTypes, we can put some logic here if needed 
	public Int64 Insert(UserType userType)
	{
		return userTypeDb.Insert(userType);
	}

	public bool Exists(UserType userType)
	{
		return userTypeDb.Exists(userType);
	}

	public bool Exists(int userTypeID)
	{
		return userTypeDb.Exists(userTypeID);
	}

	public List<ActivityUserType> GetListActivityUserType(int userTypeID)
	{
		return userTypeDb.GetListActivityUserType(userTypeID);
	}

	public List<EmployeeUserType> GetListEmployeeUserType(int userTypeID)
	{
		return userTypeDb.GetListEmployeeUserType(userTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of userTypes, we can put some logic here if needed 
	public List<UserType> SearchLike(UserType userType)
	{
		return userTypeDb.SearchLike(userType);
	}

}
}
