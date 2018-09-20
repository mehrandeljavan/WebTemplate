using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.DBA;

namespace Rewards.Models
{
public class UserHandler
{
	// Handle to the User DBAccess class
	UserDBAccess userDb = null;

	public UserHandler()
	{
		userDb = new UserDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of users, we can put some logic here if needed 
	public List<User> GetListAll()
	{
		return userDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of users, we can put some logic here if needed 
	public bool Update(User user)
	{
		return userDb.Update(user);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of users, we can put some logic here if needed 
	public User GetDetails(Int64 nationalCode)
	{
		return userDb.GetDetails(nationalCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of users, we can put some logic here if needed 
	public bool Delete(Int64 nationalCode)
	{
		return userDb.Delete(nationalCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of users, we can put some logic here if needed 
	public Int64 Insert(User user)
	{
		return userDb.Insert(user);
	}

	public bool Exists(User user)
	{
		return userDb.Exists(user);
	}

	public bool Exists(Int64 nationalCode)
	{
		return userDb.Exists(nationalCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of users, we can put some logic here if needed 
	public List<User> SearchLike(User user)
	{
		return userDb.SearchLike(user);
	}

}
}
