using System;
using System.Collections.Generic;

namespace TEZ_Project.Common.Products;

public class UnusualProduct
{
	public static string[] materialName = new string[40]
	{
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", "", "", "", "", "", "", ""
	};

	public static double materialCost;

	public static double priceProduct;

	public static double[,] MaterialUnusualProduct(string[] materialNameUnusualProduct, double[] materialSpend, int number)
	{
		double[,] array = new double[40, 6];
		materialCost = 0.0;
		priceProduct = 0.0;
		IEnumerable<CustomConst> allConsts = Consts2.GetAllConsts();
		int num = -1;
		for (int i = 0; i < materialNameUnusualProduct.Length; i++)
		{
			if (!(materialNameUnusualProduct[i] != ""))
			{
				continue;
			}
			num++;
			materialName[num] = materialNameUnusualProduct[i];
			double num2 = 0.0;
			double num3 = 0.0;
			array[num, 0] = materialSpend[i];
			array[num, 1] = 0.05;
			array[num, 2] = 0.0;
			array[num, 3] = 0.0;
			foreach (CustomConst item in allConsts)
			{
				if (!(materialName[num] == item.MaterialName))
				{
					continue;
				}
				if (item.OdVym1 == "кг")
				{
					array[num, 5] = array[num, 0] * (double)number;
				}
				else
				{
					array[num, 4] = array[num, 0] * (double)number;
					if (item.OdVym2 == "кг")
					{
						if (item.MaterialNameFlight == "Лист алюм 0,8(1000х2000) 1050  м.кв.")
						{
							num2 = 7625.0;
							num3 = 0.8;
						}
						else if (item.MaterialNameFlight == "Лист алюм 0,3мм")
						{
							num2 = 7625.0;
							num3 = 0.3;
						}
						else if (item.MaterialNameFlight == "Лист алюм 0,5(1000х2000), м.кв.")
						{
							num2 = 7625.0;
							num3 = 0.5;
						}
						else if (item.MaterialNameFlight == "Лист нерж AISI 201 0.5х1000х2000 4N+lass")
						{
							num2 = 7825.0;
							num3 = 0.5;
						}
						else if (item.MaterialNameFlight == "Лист нерж AISI 201 0.8х1000х2000 ВА PVC")
						{
							num2 = 7825.0;
							num3 = 0.8;
						}
						else if (item.MaterialNameFlight == "Лист нерж AISI 201 1,0х1240х2500 4N+ PVC")
						{
							num2 = 7825.0;
							num3 = 1.0;
						}
						else if (item.MaterialNameFlight == "Лист нерж AISI 304 0.5х1000х2000 4N+lass")
						{
							num2 = 7825.0;
							num3 = 0.5;
						}
						else if (item.MaterialNameFlight == "Лист нерж AISI 304 0.6х1000х2000 2В")
						{
							num2 = 7825.0;
							num3 = 0.6;
						}
						else if (item.MaterialNameFlight == "Лист нерж AISI 304 1,0х1250х2500 №4 PE")
						{
							num2 = 7825.0;
							num3 = 1.0;
						}
						else if (item.MaterialNameFlight == "Лист нерж AISI 430 0.5х1250х2500 4N+las")
						{
							num2 = 7825.0;
							num3 = 0.5;
						}
						else if (item.MaterialNameFlight == "Лист нерж AISI 430 0.8х1000х2000 4N+lass")
						{
							num2 = 7825.0;
							num3 = 0.8;
						}
						else if (item.MaterialNameFlight == "Лист нерж AISI 430 1,2х1250х2500")
						{
							num2 = 7825.0;
							num3 = 1.2;
						}
						else if (item.MaterialNameFlight == "Лист нерж AISI 430 1.5х1250х2500 4N+lase")
						{
							num2 = 7825.0;
							num3 = 1.5;
						}
						else if (item.MaterialNameFlight == "Лист нерж AISI 430 1,0х1000х2000 2В")
						{
							num2 = 7825.0;
							num3 = 1.0;
						}
						if (item.MaterialNameFlight == "Лист ст х/к 0,5мм 1х2 м.кв")
						{
							num2 = 7825.0;
							num3 = 0.5;
						}
						else if (item.MaterialNameFlight == "Лист ст х/к 0.8 1,25х2,5, м.кв.")
						{
							num2 = 7825.0;
							num3 = 0.8;
						}
						else if (item.MaterialNameFlight == "Лист ст х/к 1,0мм 1,25х2,5, м.кв")
						{
							num2 = 7825.0;
							num3 = 1.0;
						}
						else if (item.MaterialNameFlight == "Лист ст х/к 1,2мм 1,25х2,5, м.кв")
						{
							num2 = 7825.0;
							num3 = 1.2;
						}
						else if (item.MaterialNameFlight == "Лист ст г/к 3мм 1,25х2,5, м.кв")
						{
							num2 = 7825.0;
							num3 = 3.0;
						}
						else if (item.MaterialNameFlight == "Лист ст 4мм 1,25х2,5")
						{
							num2 = 7825.0;
							num3 = 4.0;
						}
						else if (item.MaterialNameFlight == "Лист ст г/к 2мм 1,25х2,5, м.кв")
						{
							num2 = 7825.0;
							num3 = 2.0;
						}
						else if (item.MaterialNameFlight == "Лист ст х/к 1,5мм 1,25х2,5, м.кв")
						{
							num2 = 7825.0;
							num3 = 1.5;
						}
						else if (item.MaterialNameFlight == "Лист ст г/к 10мм 1,5х6,0 м.кв")
						{
							num2 = 7825.0;
							num3 = 10.0;
						}
						else if (item.MaterialNameFlight == "Лист ст г/к 5мм 1,5х6 м.кв")
						{
							num2 = 7825.0;
							num3 = 5.0;
						}
						else if (item.MaterialNameFlight == "Лист ст г/к 6мм 1,5х6,0 м.кв")
						{
							num2 = 7825.0;
							num3 = 6.0;
						}
						else if (item.MaterialNameFlight == "Лист ст г/к 8мм 1,5х6,0 м.кв")
						{
							num2 = 7825.0;
							num3 = 8.0;
						}
						if (item.MaterialNameFlight == "Лист оцинкований 0,48 (м.кв.)")
						{
							num2 = 7825.0;
							num3 = 0.48;
						}
						else if (item.MaterialNameFlight == "Лист оцинкований 0,5 (м.кв.)")
						{
							num2 = 7825.0;
							num3 = 0.5;
						}
						else if (item.MaterialNameFlight == "Лист оцинкований 0.68 (м.кв.)")
						{
							num2 = 7825.0;
							num3 = 0.68;
						}
						else if (item.MaterialNameFlight == "Лист оцинкований 0.68 (м.кв.)")
						{
							num2 = 7825.0;
							num3 = 0.68;
						}
						else if (item.MaterialNameFlight == "Лист оцинкований 0,7 (м.кв.)")
						{
							num2 = 7825.0;
							num3 = 0.7;
						}
						else if (item.MaterialNameFlight == "Лист оцинкований 0,7 (м.кв.)")
						{
							num2 = 7825.0;
							num3 = 0.7;
						}
						else if (item.MaterialNameFlight == "Лист оцинкований 1 (м.кв.)")
						{
							num2 = 7825.0;
							num3 = 1.0;
						}
						else if (item.MaterialNameFlight == "Лист оцинкований 1 (м.кв.)")
						{
							num2 = 7825.0;
							num3 = 1.0;
						}
						else if (item.MaterialNameFlight == "Лист оцинкований 1,2 (м.кв.)")
						{
							num2 = 7825.0;
							num3 = 1.2;
						}
						else if (item.MaterialNameFlight == "Лист оцинкований 1,5 (м.кв.)")
						{
							num2 = 7825.0;
							num3 = 1.5;
						}
						else if (item.MaterialNameFlight == "Стрічка рулон оцинк 0,5х137")
						{
							num2 = 7825.0;
							num3 = 0.5;
						}
						else if (item.MaterialNameFlight == "Стрічка рулон оцинк 0,68х137")
						{
							num2 = 7825.0;
							num3 = 0.68;
						}
						else if (item.MaterialNameFlight == "Стрічка рулон оцинк 0,68х137")
						{
							num2 = 7825.0;
							num3 = 0.68;
						}
						else if (item.MaterialNameFlight == "Стрічка рулон оцинк 0,7х137")
						{
							num2 = 7825.0;
							num3 = 0.7;
						}
						else if (item.MaterialNameFlight == "Стрічка рулон оцинк 0,9х137")
						{
							num2 = 7825.0;
							num3 = 0.9;
						}
						else if (item.MaterialNameFlight == "Стрічка рулон оцинк 0,9х137")
						{
							num2 = 7825.0;
							num3 = 0.9;
						}
						array[num, 5] = array[num, 4] * num2 * num3 / 1000.0;
					}
				}
				materialCost += array[num, 0] * item.Price;
				for (int j = 0; j < 6; j++)
				{
					if (array[num, j] < 0.005)
					{
						array[num, j] = Math.Round(1000.0 * array[num, j]) / 1000.0;
					}
					else
					{
						array[num, j] = Math.Round(100.0 * array[num, j]) / 100.0;
					}
				}
				break;
			}
		}
		materialCost = Math.Round(100.0 * materialCost) / 100.0;
		priceProduct = Math.Round(100.0 * materialCost * 3.0) / 100.0;
		return array;
	}
}
