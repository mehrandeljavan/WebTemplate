using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.DBA;

namespace Rewards.Models
{
public class ComputationTypeHandler
{
	// Handle to the ComputationType DBAccess class
	ComputationTypeDBAccess computationTypeDb = null;

	public ComputationTypeHandler()
	{
		computationTypeDb = new ComputationTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of computationTypes, we can put some logic here if needed 
	public List<ComputationType> GetListAll()
	{
		return computationTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of computationTypes, we can put some logic here if needed 
	public bool Update(ComputationType computationType)
	{
		return computationTypeDb.Update(computationType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of computationTypes, we can put some logic here if needed 
	public ComputationType GetDetails(int computationTypeID)
	{
		return computationTypeDb.GetDetails(computationTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of computationTypes, we can put some logic here if needed 
	public bool Delete(int computationTypeID)
	{
		return computationTypeDb.Delete(computationTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of computationTypes, we can put some logic here if needed 
	public Int64 Insert(ComputationType computationType)
	{
		return computationTypeDb.Insert(computationType);
	}

	public bool Exists(ComputationType computationType)
	{
		return computationTypeDb.Exists(computationType);
	}

	public bool Exists(int computationTypeID)
	{
		return computationTypeDb.Exists(computationTypeID);
	}

	public List<Department> GetListDepartment(int computationTypeID)
	{
		return computationTypeDb.GetListDepartment(computationTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of computationTypes, we can put some logic here if needed 
	public List<ComputationType> SearchLike(ComputationType computationType)
	{
		return computationTypeDb.SearchLike(computationType);
	}

}
}
