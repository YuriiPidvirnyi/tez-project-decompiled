using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TEZ_Project.Common.Data.Entities;
using TEZ_Project.Common.Models;

namespace TEZ_Project.Common.Helpers;

public static class ProductHelper
{
	public const string ProductType_Povitroprovody = "Povitroprovody";

	public const string ProductType_Fasonka = "Fasonka";

	public const string ProductType_Obladn = "Obladn";

	public static IEnumerable<IProduct> ToProductList(this ICollection<Product> products)
	{
		return Enumerable.Select<Product, IProduct>((IEnumerable<Product>)products, (Func<Product, IProduct>)((Product p) => JsonToProduct(p.Data, p.Id)));
	}

	public static IProduct ToProduct(this Product product)
	{
		return JsonToProduct(product.Data, product.Id);
	}

	public static Product ToProduct(this IProduct product, int orderId)
	{
		return new Product
		{
			Id = product.Id,
			OrderId = orderId,
			Type = product.GetType().ToString(),
			Data = JsonConvert.SerializeObject(product),
			Price = product.FullPrice
		};
	}

	public static Product ToProduct(this IProduct product)
	{
		return new Product
		{
			Id = product.Id,
			Type = product.GetType().ToString(),
			Data = JsonConvert.SerializeObject(product),
			Price = product.FullPrice
		};
	}

	public static string GetProductType(IProduct product)
	{
		switch (product.GetType().Name)
		{
		case "Product_RoundAirPK":
		case "Product_RoundAirPSK":
		case "Product_PovitroprovidPFP":
			return "Povitroprovody";
		case "Product_VidvidVRNP":
		case "Product_VidvidVRVP":
		case "Product_NakladkaNK":
		case "Product_TrijnykTRK":
		case "Product_TrijnykTPVP":
		case "Product_ZaglushkaZK":
		case "Product_ZaglushkaZP":
		case "Product_TrijnykTOZP":
		case "Product_TrijnykTSHK":
		case "Product_NakladkaNKP":
		case "Product_NakladkaNPK":
		case "Product_PerehidnykPOLP_K":
		case "Product_PerehidnykPOPP_K":
		case "Product_UtkaURNP":
		case "Product_VidvidVK":
		case "Product_UtkaURVP":
		case "Product_NipelNVK":
		case "Product_NipelNZK":
		case "Product_VrizkaVKP":
		case "Product_VrizkaVPK":
		case "Product_VrizkaVPP":
		case "Product_VidvidVSP":
		case "Product_ObvidOK":
		case "Product_ObvidOP":
		case "Product_UtkaUAK":
		case "Product_ZontZVK":
		case "Product_ZontZVP":
		case "Product_UtkaUK":
		case "Product_UtkaUP":
		case "Product_PerehidnykPAK":
		case "Product_PerehidnykPAP":
		case "Product_TrijnykTSHOAP":
		case "Product_HrestovynaHAP":
		case "Product_PerehidnykPOK":
		case "Product_PerehidnykPOP":
		case "Product_PerehidnykPSK":
		case "Product_PerehidnykPSP":
		case "Product_HrestovynaHSP":
		case "Product_TrijnykTOASHK":
		case "Product_HrestovynaHRK":
		case "Product_PerehidnykPAP-K":
		case "Product_PerehidnykPOP_K":
		case "Product_PerehidnykPSP_K":
		case "Product_PerehidnykPOLP":
		case "Product_PerehidnykPOPP":
		case "Product_TrijnykTSHOP":
		case "Product_TrijnykTSHSP":
		case "Product_TrijnykTSHAP":
		case "Product_TrijnykTOSHK":
		case "Product_TrijnykTOSHP":
		case "Product_TrijnykTSSHP":
		case "Product_HrestovynaHK":
			return "Fasonka";
		default:
			return "Obladn";
		}
	}

	public static double GetProductAdditionalPercent1C(IProduct product, double defaultAddPercent1C)
	{
		switch (product.GetType().Name)
		{
		case "Product_ShumopohlynachSHK":
		case "Product_ShumopohlynachSHP":
		case "Product_ShumopohlynachSHKP":
			return 0.7;
		case "Product_KlapanDroselnyjKDK":
		case "Product_KlapanZvorotniyKZK":
		case "Product_KlapanGaluzijnjyKGP":
			return 0.25;
		default:
		{
			if (product.GetType().Name.Contains("Product_KlapanProtypogegnyj"))
			{
				return 0.25;
			}
			List<double> list = new List<double> { 0.5, 0.65, 0.68, 0.7, 0.9, 1.0 };
			if (product.GetType().Name == "Product_RoundAirPSK" && list.Contains(product.TovchynaMetalu))
			{
				return 0.15;
			}
			if (product.GetType().Name == "Product_PovitroprovidPFP" && list.Contains(product.TovchynaMetalu))
			{
				return 0.1;
			}
			if (product.IsFasonka())
			{
				if (product.TovchynaMetalu == 0.5)
				{
					return 0.5;
				}
				List<double> list2 = new List<double> { 0.65, 0.68, 0.7, 0.9, 1.0 };
				if (list2.Contains(product.TovchynaMetalu))
				{
					return 0.4;
				}
			}
			return defaultAddPercent1C;
		}
		}
	}

	private static IProduct JsonToProduct(string json, int id)
	{
		JObject jObject = JObject.Parse(json);
		Type type = Type.GetType(jObject.GetValue("TypeOfProduct").ToString() + ", TEZ_Project.Common");
		IProduct product = (IProduct)Activator.CreateInstance(type, jObject);
		product.Id = id;
		return product;
	}
}
