using System;
using Newtonsoft.Json.Linq;

namespace TEZ_Project.Common.Models;

public class Product_ObvidOP : IProduct
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

	public int B { get; set; }

	public int H { get; set; }

	public int L { get; set; }

	public int l { get; set; }

	public int C { get; set; }

	public int K { get; set; }

	public int K1 { get; set; }

	public string MarkaStali { get; set; }

	public string ThicknessOfMetal { get; set; }

	public string Type { get; set; }

	public string TypProfilBH { get; set; }

	public string TypProfilB1H1 { get; set; }

	public int PolkaBH { get; set; }

	public int PolkaB1H1 { get; set; }

	public string Vidbortovka { get; set; }

	public string AisiType { get; set; }

	public Product_ObvidOP()
	{
	}

	public Product_ObvidOP(JObject jObj)
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
		B = Convert.ToInt32(jObj.GetValue("B"));
		H = Convert.ToInt32(jObj.GetValue("H"));
		L = Convert.ToInt32(jObj.GetValue("L"));
		l = Convert.ToInt32(jObj.GetValue("l"));
		C = Convert.ToInt32(jObj.GetValue("C"));
		K = Convert.ToInt32(jObj.GetValue("K"));
		K1 = Convert.ToInt32(jObj.GetValue("K1"));
		MarkaStali = jObj.GetValue("MarkaStali").ToString();
		ThicknessOfMetal = jObj.GetValue("ThicknessOfMetal").ToString();
		Type = jObj.GetValue("Type").ToString();
		TypProfilBH = jObj.GetValue("TypProfilBH").ToString();
		TypProfilB1H1 = jObj.GetValue("TypProfilB1H1").ToString();
		PolkaBH = Convert.ToInt32(jObj.GetValue("PolkaBH"));
		PolkaB1H1 = Convert.ToInt32(jObj.GetValue("PolkaB1H1"));
		Vidbortovka = jObj.GetValue("Vidbortovka").ToString();
		AisiType = jObj.GetValue("AisiType")?.ToString();
	}
}
