using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.DBA;

namespace Rewards.Models
{
public class ContractTypeHandler
{
	// Handle to the ContractType DBAccess class
	ContractTypeDBAccess contractTypeDb = null;

	public ContractTypeHandler()
	{
		contractTypeDb = new ContractTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of contractTypes, we can put some logic here if needed 
	public List<ContractType> GetListAll()
	{
		return contractTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of contractTypes, we can put some logic here if needed 
	public bool Update(ContractType contractType)
	{
		return contractTypeDb.Update(contractType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of contractTypes, we can put some logic here if needed 
	public ContractType GetDetails(int contractTypeID)
	{
		return contractTypeDb.GetDetails(contractTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of contractTypes, we can put some logic here if needed 
	public bool Delete(int contractTypeID)
	{
		return contractTypeDb.Delete(contractTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of contractTypes, we can put some logic here if needed 
	public Int64 Insert(ContractType contractType)
	{
		return contractTypeDb.Insert(contractType);
	}

	public bool Exists(ContractType contractType)
	{
		return contractTypeDb.Exists(contractType);
	}

	public bool Exists(int contractTypeID)
	{
		return contractTypeDb.Exists(contractTypeID);
	}

	public List<Employee> GetListEmployee(int contractTypeID)
	{
		return contractTypeDb.GetListEmployee(contractTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of contractTypes, we can put some logic here if needed 
	public List<ContractType> SearchLike(ContractType contractType)
	{
		return contractTypeDb.SearchLike(contractType);
	}

}
}
