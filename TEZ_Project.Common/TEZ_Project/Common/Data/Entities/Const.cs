using System.Collections.Generic;

namespace TEZ_Project.Common.Data.Entities;

public class Const
{
	public int Id { get; set; }

	public string NameInApp { get; set; }

	public string MaterialName { get; set; }

	public double Price { get; set; }

	public string MaterialNameFlight { get; set; }

	public string Code1 { get; set; }

	public string MaterialName1C { get; set; }

	public string Code2 { get; set; }

	public string OdVym1 { get; set; }

	public string OdVym2 { get; set; }

	public ICollection<CustomProductConsts> CustomProductConsts { get; set; }
}
