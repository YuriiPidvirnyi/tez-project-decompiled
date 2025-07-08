using Newtonsoft.Json;

namespace TEZ_Project.Common.Models;

public interface IProduct
{
	[JsonIgnore]
	int Id { get; set; }

	int Order { get; set; }

	string Name { get; set; }

	int Amount { get; set; }

	double Price { get; set; }

	double FullPrice { get; set; }

	int Discount { get; set; }

	int ProcentVidhodu { get; set; }

	string Section { get; set; }

	bool IsChosen { get; set; }

	string Prymitka { get; set; }

	string TypeOfProduct { get; set; }

	string Square { get; set; }

	double TovchynaMetalu { get; set; }

	double Volume { get; set; }

	double MaterialCost { get; set; }

	double Markup { get; set; }

	double Rentabelnist { get; set; }
}
