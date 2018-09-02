using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Rewards.DBA;

namespace Rewards.Models
{
public class AdjutancyTypeHandler
{
	// Handle to the AdjutancyType DBAccess class
	AdjutancyTypeDBAccess adjutancyTypeDb = null;

	public AdjutancyTypeHandler()
	{
		adjutancyTypeDb = new AdjutancyTypeDBAccess();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of adjutancyTypes, we can put some logic here if needed 
	public List<AdjutancyType> GetListAll()
	{
		return adjutancyTypeDb.GetListAll();
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of adjutancyTypes, we can put some logic here if needed 
	public bool Update(AdjutancyType adjutancyType)
	{
		return adjutancyTypeDb.Update(adjutancyType);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of adjutancyTypes, we can put some logic here if needed 
	public AdjutancyType GetDetails(int adjutancyTypeID)
	{
		return adjutancyTypeDb.GetDetails(adjutancyTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of adjutancyTypes, we can put some logic here if needed 
	public bool Delete(int adjutancyTypeID)
	{
		return adjutancyTypeDb.Delete(adjutancyTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of adjutancyTypes, we can put some logic here if needed 
	public Int64 Insert(AdjutancyType adjutancyType)
	{
		return adjutancyTypeDb.Insert(adjutancyType);
	}

	public bool Exists(AdjutancyType adjutancyType)
	{
		return adjutancyTypeDb.Exists(adjutancyType);
	}

	public bool Exists(int adjutancyTypeID)
	{
		return adjutancyTypeDb.Exists(adjutancyTypeID);
	}

	public List<Department> GetListDepartment(int adjutancyTypeID)
	{
		return adjutancyTypeDb.GetListDepartment(adjutancyTypeID);
	}

	// This fuction does not contain any business logic, it simply returns the 
	// list of adjutancyTypes, we can put some logic here if needed 
	public List<AdjutancyType> SearchLike(AdjutancyType adjutancyType)
	{
		return adjutancyTypeDb.SearchLike(adjutancyType);
	}

}
}
