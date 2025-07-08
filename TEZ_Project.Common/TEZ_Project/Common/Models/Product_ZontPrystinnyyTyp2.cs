using System;
using Newtonsoft.Json.Linq;

namespace TEZ_Project.Common.Models;

public class Product_ZontPrystinnyyTyp2 : IProduct
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

	public int G { get; set; }

	public int d1 { get; set; }

	public int a1 { get; set; }

	public int b1 { get; set; }

	public int p1 { get; set; }

	public int f1 { get; set; }

	public int g1 { get; set; }

	public int d2 { get; set; }

	public int a2 { get; set; }

	public int b2 { get; set; }

	public int p2 { get; set; }

	public int f2 { get; set; }

	public int g2 { get; set; }

	public int d3 { get; set; }

	public int a3 { get; set; }

	public int b3 { get; set; }

	public int p3 { get; set; }

	public int f3 { get; set; }

	public int g3 { get; set; }

	public string MarkaStali { get; set; }

	public string ThicknessOfMetal { get; set; }

	public string Connection { get; set; }

	public string Zlyv { get; set; }

	public string Fastening { get; set; }

	public string FasteningType { get; set; }

	public string Vyhid { get; set; }

	public string ZhyrFiltr { get; set; }

	public string MarkaStaliFiltr { get; set; }

	public string ThicknessOfMetalFiltr { get; set; }

	public string Vyhid1 { get; set; }

	public string TypVyhid1 { get; set; }

	public string ProfilType1 { get; set; }

	public string Vyhid2 { get; set; }

	public string TypVyhid2 { get; set; }

	public string ProfilType2 { get; set; }

	public string Vyhid3 { get; set; }

	public string TypVyhid3 { get; set; }

	public string ProfilType3 { get; set; }

	public string SquareZhyrFiltr { get; set; }

	public Product_ZontPrystinnyyTyp2()
	{
	}

	public Product_ZontPrystinnyyTyp2(JObject jObj)
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
		G = Convert.ToInt32(jObj.GetValue("G"));
		d1 = Convert.ToInt32(jObj.GetValue("d1"));
		a1 = Convert.ToInt32(jObj.GetValue("a1"));
		b1 = Convert.ToInt32(jObj.GetValue("b1"));
		p1 = Convert.ToInt32(jObj.GetValue("p1"));
		f1 = Convert.ToInt32(jObj.GetValue("f1"));
		g1 = Convert.ToInt32(jObj.GetValue("g1"));
		d2 = Convert.ToInt32(jObj.GetValue("d2"));
		a2 = Convert.ToInt32(jObj.GetValue("a2"));
		b2 = Convert.ToInt32(jObj.GetValue("b2"));
		p2 = Convert.ToInt32(jObj.GetValue("p2"));
		f2 = Convert.ToInt32(jObj.GetValue("f2"));
		g2 = Convert.ToInt32(jObj.GetValue("g2"));
		d3 = Convert.ToInt32(jObj.GetValue("d3"));
		a3 = Convert.ToInt32(jObj.GetValue("a3"));
		b3 = Convert.ToInt32(jObj.GetValue("b3"));
		p3 = Convert.ToInt32(jObj.GetValue("p3"));
		f3 = Convert.ToInt32(jObj.GetValue("f3"));
		g3 = Convert.ToInt32(jObj.GetValue("g3"));
		MarkaStali = jObj.GetValue("MarkaStali").ToString();
		ThicknessOfMetal = jObj.GetValue("ThicknessOfMetal").ToString();
		Connection = jObj.GetValue("Connection").ToString();
		Zlyv = jObj.GetValue("Zlyv").ToString();
		Fastening = jObj.GetValue("Fastening").ToString();
		FasteningType = jObj.GetValue("FasteningType").ToString();
		Vyhid = jObj.GetValue("Vyhid").ToString();
		ZhyrFiltr = jObj.GetValue("ZhyrFiltr").ToString();
		MarkaStaliFiltr = jObj.GetValue("MarkaStaliFiltr").ToString();
		ThicknessOfMetalFiltr = jObj.GetValue("ThicknessOfMetalFiltr").ToString();
		Vyhid1 = jObj.GetValue("Vyhid1").ToString();
		TypVyhid1 = jObj.GetValue("TypVyhid1").ToString();
		ProfilType1 = jObj.GetValue("ProfilType1").ToString();
		Vyhid2 = jObj.GetValue("Vyhid2").ToString();
		TypVyhid2 = jObj.GetValue("TypVyhid2").ToString();
		ProfilType2 = jObj.GetValue("ProfilType2").ToString();
		Vyhid3 = jObj.GetValue("Vyhid3").ToString();
		TypVyhid3 = jObj.GetValue("TypVyhid3").ToString();
		ProfilType3 = jObj.GetValue("ProfilType3").ToString();
		SquareZhyrFiltr = jObj.GetValue("SquareZhyrFiltr")?.ToString();
	}
}
