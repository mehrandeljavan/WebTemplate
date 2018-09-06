using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.DBA;

namespace Rewards.Models
{
public class ContractualEmployeeRewardHandler
{
	// Handle to the ContractualEmployeeReward DBAccess class
	ContractualEmployeeRewardDBAccess contractualEmployeeRewardDb = null;

	public ContractualEmployeeRewardHandler()
	{
		contractualEmployeeRewardDb = new ContractualEmployeeRewardDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of contractualEmployeeRewards, we can put some logic here if needed 
	public List<ContractualEmployeeReward> GetListAll()
	{
		return contractualEmployeeRewardDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of contractualEmployeeRewards, we can put some logic here if needed 
	public bool Update(ContractualEmployeeReward contractualEmployeeReward)
	{
		return contractualEmployeeRewardDb.Update(contractualEmployeeReward);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of contractualEmployeeRewards, we can put some logic here if needed 
	public ContractualEmployeeReward GetDetails(int yearTypeID , int monthTypeID , Int64 nationalCode)
	{
		return contractualEmployeeRewardDb.GetDetails(yearTypeID , monthTypeID , nationalCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of contractualEmployeeRewards, we can put some logic here if needed 
	public bool Delete(int yearTypeID , int monthTypeID , Int64 nationalCode)
	{
		return contractualEmployeeRewardDb.Delete(yearTypeID , monthTypeID , nationalCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of contractualEmployeeRewards, we can put some logic here if needed 
	public Int64 Insert(ContractualEmployeeReward contractualEmployeeReward)
	{
		return contractualEmployeeRewardDb.Insert(contractualEmployeeReward);
	}

	public bool Exists(ContractualEmployeeReward contractualEmployeeReward)
	{
		return contractualEmployeeRewardDb.Exists(contractualEmployeeReward);
	}

	public bool Exists(int yearTypeID , int monthTypeID , Int64 nationalCode)
	{
		return contractualEmployeeRewardDb.Exists(yearTypeID , monthTypeID , nationalCode);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of contractualEmployeeRewards, we can put some logic here if needed 
	public List<ContractualEmployeeReward> SearchLike(ContractualEmployeeReward contractualEmployeeReward)
	{
		return contractualEmployeeRewardDb.SearchLike(contractualEmployeeReward);
	}

}
}
