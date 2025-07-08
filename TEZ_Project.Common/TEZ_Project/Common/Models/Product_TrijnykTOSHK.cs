using System;
using Newtonsoft.Json.Linq;

namespace TEZ_Project.Common.Models;

public class Product_TrijnykTOSHK : IProduct
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

	public int l { get; set; }

	public int Angle { get; set; }

	public string MarkaStali { get; set; }

	public string ThicknessOfMetal { get; set; }

	public string TypeTOSHKinput { get; set; }

	public string TypeTOSHKoutLeft { get; set; }

	public string TypeTOSHKoutRight { get; set; }

	public string TypMaterialInput { get; set; }

	public string TypMaterialOutLeft { get; set; }

	public string TypMaterialOutRight { get; set; }

	public string Vidbortovka { get; set; }

	public string AisiType { get; set; }

	public Product_TrijnykTOSHK()
	{
	}

	public Product_TrijnykTOSHK(JObject jObj)
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
		l = Convert.ToInt32(jObj.GetValue("l"));
		Angle = Convert.ToInt32(jObj.GetValue("Angle"));
		MarkaStali = jObj.GetValue("MarkaStali").ToString();
		ThicknessOfMetal = jObj.GetValue("ThicknessOfMetal").ToString();
		TypeTOSHKinput = jObj.GetValue("TypeTOSHKinput").ToString();
		TypeTOSHKoutLeft = jObj.GetValue("TypeTOSHKoutLeft").ToString();
		TypeTOSHKoutRight = jObj.GetValue("TypeTOSHKoutRight").ToString();
		TypMaterialInput = jObj.GetValue("TypMaterialInput").ToString();
		TypMaterialOutLeft = jObj.GetValue("TypMaterialOutLeft").ToString();
		TypMaterialOutRight = jObj.GetValue("TypMaterialOutRight").ToString();
		Vidbortovka = jObj.GetValue("Vidbortovka").ToString();
		AisiType = jObj.GetValue("AisiType")?.ToString();
	}
}
