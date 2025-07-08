using System;
using Newtonsoft.Json.Linq;

namespace TEZ_Project.Common.Models;

public class Product_RoundAirPK : IProduct
{
	public int Id { get; set; }

	public int Order { get; set; }

	public string Name { get; set; }

	public int Amount { get; set; }

	public double Price { get; set; }

	public double FullPrice { get; set; }

	public int Discount { get; set; }

	public int ProcentVidhodu { get; set; }

	public bool IsChosen { get; set; }

	public string Section { get; set; }

	public string Prymitka { get; set; }

	public string TypeOfProduct { get; set; }

	public string Square { get; set; }

	public double TovchynaMetalu { get; set; }

	public double Volume { get; set; }

	public double MaterialCost { get; set; }

	public double Markup { get; set; }

	public double Rentabelnist { get; set; }

	public int D { get; set; }

	public int L { get; set; }

	public string MarkaStali { get; set; }

	public string ThicknessOfMetal { get; set; }

	public string Type { get; set; }

	public string ProfilType { get; set; }

	public string AisiType { get; set; }

	public string Vidbortovka { get; set; }

	public Product_RoundAirPK()
	{
	}

	public Product_RoundAirPK(JObject jObj)
	{
		Id = Convert.ToInt32(jObj.GetValue("Id"));
		Order = Convert.ToInt32(jObj.GetValue("Order"));
		Name = jObj.GetValue("Name").ToString();
		Amount = Convert.ToInt32(jObj.GetValue("Amount"));
		Price = Convert.ToDouble(jObj.GetValue("Price"));
		FullPrice = Convert.ToDouble(jObj.GetValue("FullPrice"));
		Discount = Convert.ToInt32(jObj.GetValue("Discount"));
		ProcentVidhodu = Convert.ToInt32(jObj.GetValue("ProcentVidhodu"));
		IsChosen = Convert.ToBoolean(jObj.GetValue("IsChosen"));
		Section = jObj.GetValue("Section").ToString();
		Prymitka = jObj.GetValue("Prymitka").ToString();
		TypeOfProduct = jObj.GetValue("TypeOfProduct").ToString();
		Square = jObj.GetValue("Square").ToString();
		TovchynaMetalu = Convert.ToDouble(jObj.GetValue("TovchynaMetalu"));
		Volume = Convert.ToDouble(jObj.GetValue("Volume"));
		MaterialCost = Convert.ToDouble(jObj.GetValue("MaterialCost"));
		Markup = Convert.ToDouble(jObj.GetValue("Markup"));
		Rentabelnist = Convert.ToDouble(jObj.GetValue("Rentabelnist"));
		D = Convert.ToInt32(jObj.GetValue("D"));
		L = Convert.ToInt32(jObj.GetValue("L"));
		MarkaStali = jObj.GetValue("MarkaStali").ToString();
		ThicknessOfMetal = jObj.GetValue("ThicknessOfMetal").ToString();
		Type = jObj.GetValue("Type").ToString();
		ProfilType = jObj.GetValue("ProfilType").ToString();
		AisiType = jObj.GetValue("AisiType")?.ToString();
		Vidbortovka = jObj.GetValue("Vidbortovka").ToString();
	}
}
