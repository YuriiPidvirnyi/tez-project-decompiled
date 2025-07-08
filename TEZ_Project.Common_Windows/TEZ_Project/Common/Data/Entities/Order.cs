using System;
using System.Collections.Generic;

namespace TEZ_Project.Common.Data.Entities;

public class Order
{
	public int Id { get; set; }

	public DateTime Date { get; set; }

	public int Status { get; set; }

	public int Priority { get; set; }

	public string Contragent { get; set; }

	public int PercentFor1C { get; set; }

	public string Code { get; set; }

	public string Account1C { get; set; }

	public int ManagerId { get; set; }

	public User Manager { get; set; }

	public ICollection<Product> Products { get; set; } = new List<Product>();

}
