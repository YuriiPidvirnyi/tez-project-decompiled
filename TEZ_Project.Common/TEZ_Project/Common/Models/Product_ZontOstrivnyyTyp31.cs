using System;
using Newtonsoft.Json.Linq;

namespace TEZ_Project.Common.Models;

public class Product_ZontOstrivnyyTyp31 : IProduct
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

	public int L { get; set; }

	public int B { get; set; }

	public int H { get; set; }

	public int h { get; set; }

	public int a { get; set; }

	public int b { get; set; }

	public int c { get; set; }

	public int c1 { get; set; }

	public int p { get; set; }

	public string MarkaStali { get; set; }

	public string ThicknessOfMetal { get; set; }

	public string Connection { get; set; }

	public string Zlyv { get; set; }

	public string Fastening { get; set; }

	public string FasteningType { get; set; }

	public string ZhyrFiltr { get; set; }

	public string MarkaStaliFiltr { get; set; }

	public string ThicknessOfMetalFiltr { get; set; }

	public string SquareZhyrFiltr { get; set; }

	public string Implementation { get; set; }

	public Product_ZontOstrivnyyTyp31()
	{
	}

	public Product_ZontOstrivnyyTyp31(JObject jObj)
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
		L = Convert.ToInt32(jObj.GetValue("L"));
		B = Convert.ToInt32(jObj.GetValue("B"));
		H = Convert.ToInt32(jObj.GetValue("H"));
		h = Convert.ToInt32(jObj.GetValue("h"));
		a = Convert.ToInt32(jObj.GetValue("a"));
		b = Convert.ToInt32(jObj.GetValue("b"));
		c = Convert.ToInt32(jObj.GetValue("c"));
		c1 = Convert.ToInt32(jObj.GetValue("c1"));
		p = Convert.ToInt32(jObj.GetValue("p"));
		MarkaStali = jObj.GetValue("MarkaStali").ToString();
		ThicknessOfMetal = jObj.GetValue("ThicknessOfMetal").ToString();
		Connection = jObj.GetValue("Connection").ToString();
		Zlyv = jObj.GetValue("Zlyv").ToString();
		Fastening = jObj.GetValue("Fastening").ToString();
		FasteningType = jObj.GetValue("FasteningType").ToString();
		ZhyrFiltr = jObj.GetValue("ZhyrFiltr").ToString();
		MarkaStaliFiltr = jObj.GetValue("MarkaStaliFiltr").ToString();
		ThicknessOfMetalFiltr = jObj.GetValue("ThicknessOfMetalFiltr").ToString();
		Implementation = jObj.GetValue("Implementation").ToString();
		SquareZhyrFiltr = jObj.GetValue("SquareZhyrFiltr")?.ToString();
	}
}
