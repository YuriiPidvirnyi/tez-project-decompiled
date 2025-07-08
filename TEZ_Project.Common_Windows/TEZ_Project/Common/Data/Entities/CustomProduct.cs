using System;
using System.Collections.Generic;

namespace TEZ_Project.Common.Data.Entities;

public class CustomProduct
{
	public int Id { get; set; }

	public string Name { get; set; }

	public string CreatedBy { get; set; }

	public string LastUpdatedBy { get; set; }

	public DateTime LastUpdatedDate { get; set; }

	public ICollection<CustomProductConsts> CustomProductConsts { get; set; }
}
