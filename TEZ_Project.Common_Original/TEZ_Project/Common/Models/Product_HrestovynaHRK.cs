using System;
using Newtonsoft.Json.Linq;

namespace TEZ_Project.Common.Models;

public class Product_HrestovynaHRK : IProduct
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

	public int D1 { get; set; }

	public int D2 { get; set; }

	public int D3 { get; set; }

	public int L { get; set; }

	public int l { get; set; }

	public int l1 { get; set; }

	public int Alpha { get; set; }

	public int Alpha1 { get; set; }

	public int K { get; set; }

	public int K1 { get; set; }

	public string MarkaStali { get; set; }

	public string ThicknessOfMetal { get; set; }

	public string TypeHRKinput { get; set; }

	public string TypeHRKout { get; set; }

	public string TypeHRKvrizkaUp { get; set; }

	public string TypeHRKvrizkaDown { get; set; }

	public string TypMaterialD { get; set; }

	public string TypMaterialD1 { get; set; }

	public string TypMaterialD2 { get; set; }

	public string TypMaterialD3 { get; set; }

	public string Vidbortovka { get; set; }

	public string AisiType { get; set; }

	public Product_HrestovynaHRK()
	{
	}

	public Product_HrestovynaHRK(JObject jObj)
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
		D1 = Convert.ToInt32(jObj.GetValue("D1"));
		D2 = Convert.ToInt32(jObj.GetValue("D2"));
		D3 = Convert.ToInt32(jObj.GetValue("D3"));
		L = Convert.ToInt32(jObj.GetValue("L"));
		l = Convert.ToInt32(jObj.GetValue("l"));
		l1 = Convert.ToInt32(jObj.GetValue("l1"));
		Alpha = Convert.ToInt32(jObj.GetValue("Alpha"));
		Alpha1 = Convert.ToInt32(jObj.GetValue("Alpha1"));
		K = Convert.ToInt32(jObj.GetValue("K"));
		K1 = Convert.ToInt32(jObj.GetValue("K1"));
		MarkaStali = jObj.GetValue("MarkaStali").ToString();
		ThicknessOfMetal = jObj.GetValue("ThicknessOfMetal").ToString();
		TypeHRKinput = jObj.GetValue("TypeHRKinput").ToString();
		TypeHRKout = jObj.GetValue("TypeHRKout").ToString();
		TypeHRKvrizkaUp = jObj.GetValue("TypeHRKvrizkaUp").ToString();
		TypeHRKvrizkaDown = jObj.GetValue("TypeHRKvrizkaDown").ToString();
		TypMaterialD = jObj.GetValue("TypMaterialD").ToString();
		TypMaterialD1 = jObj.GetValue("TypMaterialD1").ToString();
		TypMaterialD2 = jObj.GetValue("TypMaterialD2").ToString();
		TypMaterialD3 = jObj.GetValue("TypMaterialD3").ToString();
		Vidbortovka = jObj.GetValue("Vidbortovka").ToString();
		AisiType = jObj.GetValue("AisiType")?.ToString();
	}
}
