using System;
using System.Collections.Generic;
using TEZ_Project.Common.Data.Entities;

namespace TEZ_Project.Common.Data;

public class OrderModel
{
	public int OrderId { get; set; }

	public DateTime Date { get; set; }

	public double? Price { get; set; }

	public int Status { get; set; }

	public int Priority { get; set; }

	public int ManagerId { get; set; }

	public string Manager { get; set; }

	public string Contragent { get; set; }

	public int PercentFor1C { get; set; }

	public string Account1C { get; set; }

	public string Code { get; set; }

	public bool IsSelected { get; set; }

	public ICollection<Product> Products { get; set; } = new List<Product>();


	public string DisplayDate => Date.ToString("dd/MM/yyyy HH mm", System.Globalization.CultureInfo.InvariantCulture);
}
