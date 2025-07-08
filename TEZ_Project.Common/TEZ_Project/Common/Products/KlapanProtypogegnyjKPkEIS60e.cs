using System;

namespace TEZ_Project.Common.Products;

public static class KlapanProtypogegnyjKPkEIS60e
{
	public static string[] materialName = new string[42]
	{
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", "", "", "", "", "", "", "",
		"", ""
	};

	public static double materialCost;

	public static double priceProduct;

	public static double[,] MaterialKlapanProtypogegnyjKPkEIS60e(int D, int number, int servopryvid)
	{
		double[,] array = new double[42, 6];
		int num = -1;
		materialName = new string[42]
		{
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", "", "", "", "", "",
			"", ""
		};
		priceProduct = 0.0;
		materialCost = 0.0;
		num++;
		materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
		array[num, 0] = 2.0 * (double)(D - 18) * (double)(D - 11) * 1.05 / 1000000.0;
		array[num, 1] = 0.05;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 5] = array[num, 4] * 7825.0 * 0.7 / 1000.0;
		if (array[num, 0] < 0.005)
		{
			array[num, 0] = Math.Round(1000.0 * array[num, 0]) / 1000.0;
		}
		else
		{
			array[num, 0] = Math.Round(100.0 * array[num, 0]) / 100.0;
		}
		if (array[num, 4] < 0.005)
		{
			array[num, 4] = Math.Round(1000.0 * array[num, 4]) / 1000.0;
		}
		else
		{
			array[num, 4] = Math.Round(100.0 * array[num, 4]) / 100.0;
		}
		if (array[num, 5] < 0.005)
		{
			array[num, 5] = Math.Round(1000.0 * array[num, 5]) / 1000.0;
		}
		else
		{
			array[num, 5] = Math.Round(100.0 * array[num, 5]) / 100.0;
		}
		priceProduct += array[num, 0] * Consts2.lystOchynkovanyj07.Price;
		num++;
		materialName[num] = Consts2.lystOchynkovanyj09.MaterialName;
		array[num, 0] = 0.016653;
		array[num, 1] = 0.05;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 5] = array[num, 4] * 7825.0 * 0.9 / 1000.0;
		if (array[num, 0] < 0.005)
		{
			array[num, 0] = Math.Round(1000.0 * array[num, 0]) / 1000.0;
		}
		else
		{
			array[num, 0] = Math.Round(100.0 * array[num, 0]) / 100.0;
		}
		if (array[num, 4] < 0.005)
		{
			array[num, 4] = Math.Round(1000.0 * array[num, 4]) / 1000.0;
		}
		else
		{
			array[num, 4] = Math.Round(100.0 * array[num, 4]) / 100.0;
		}
		if (array[num, 5] < 0.005)
		{
			array[num, 5] = Math.Round(1000.0 * array[num, 5]) / 1000.0;
		}
		else
		{
			array[num, 5] = Math.Round(100.0 * array[num, 5]) / 100.0;
		}
		priceProduct += array[num, 0] * Consts2.lystOchynkovanyj09.Price;
		num++;
		materialName[num] = Consts2.lystStalnyj15.MaterialName;
		array[num, 0] = Math.PI * (double)D * 300.0 + 0.9 * ((double)D - 1.5) * (double)(D - 20 - 13) + 16900.0 + 12000.0 + 121500.0;
		array[num, 0] += ((D <= 250) ? 12000 : 38400);
		array[num, 0] *= 1.0500000000000001E-06;
		double num2 = array[num, 0];
		array[num, 1] = 0.05;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 5] = array[num, 4] * 7825.0 * 1.5 / 1000.0;
		array[num, 2] = array[num, 4] * array[num, 1];
		array[num, 3] = array[num, 5] * array[num, 1];
		if (array[num, 0] < 0.005)
		{
			array[num, 0] = Math.Round(1000.0 * array[num, 0]) / 1000.0;
		}
		else
		{
			array[num, 0] = Math.Round(100.0 * array[num, 0]) / 100.0;
		}
		if (array[num, 2] < 0.005)
		{
			array[num, 2] = Math.Round(1000.0 * array[num, 2]) / 1000.0;
		}
		else
		{
			array[num, 2] = Math.Round(100.0 * array[num, 2]) / 100.0;
		}
		if (array[num, 3] < 0.005)
		{
			array[num, 3] = Math.Round(1000.0 * array[num, 3]) / 1000.0;
		}
		else
		{
			array[num, 3] = Math.Round(100.0 * array[num, 3]) / 100.0;
		}
		if (array[num, 4] < 0.005)
		{
			array[num, 4] = Math.Round(1000.0 * array[num, 4]) / 1000.0;
		}
		else
		{
			array[num, 4] = Math.Round(100.0 * array[num, 4]) / 100.0;
		}
		if (array[num, 5] < 0.005)
		{
			array[num, 5] = Math.Round(1000.0 * array[num, 5]) / 1000.0;
		}
		else
		{
			array[num, 5] = Math.Round(100.0 * array[num, 5]) / 100.0;
		}
		priceProduct += array[num, 0] * Consts2.lystStalnyj15.Price;
		num++;
		materialName[num] = Consts2.lystStalnyj30.MaterialName;
		array[num, 0] = 2.0 * (double)(D + 50) * (double)(D + 50) * 1.05 / 1000000.0;
		double num3 = array[num, 0];
		array[num, 1] = 0.05;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 5] = array[num, 4] * 7825.0 * 3.0 / 1000.0;
		array[num, 2] = array[num, 4] * array[num, 1];
		array[num, 3] = array[num, 5] * array[num, 1];
		if (array[num, 0] < 0.005)
		{
			array[num, 0] = Math.Round(1000.0 * array[num, 0]) / 1000.0;
		}
		else
		{
			array[num, 0] = Math.Round(100.0 * array[num, 0]) / 100.0;
		}
		if (array[num, 2] < 0.005)
		{
			array[num, 2] = Math.Round(1000.0 * array[num, 2]) / 1000.0;
		}
		else
		{
			array[num, 2] = Math.Round(100.0 * array[num, 2]) / 100.0;
		}
		if (array[num, 3] < 0.005)
		{
			array[num, 3] = Math.Round(1000.0 * array[num, 3]) / 1000.0;
		}
		else
		{
			array[num, 3] = Math.Round(100.0 * array[num, 3]) / 100.0;
		}
		if (array[num, 4] < 0.005)
		{
			array[num, 4] = Math.Round(1000.0 * array[num, 4]) / 1000.0;
		}
		else
		{
			array[num, 4] = Math.Round(100.0 * array[num, 4]) / 100.0;
		}
		if (array[num, 5] < 0.005)
		{
			array[num, 5] = Math.Round(1000.0 * array[num, 5]) / 1000.0;
		}
		else
		{
			array[num, 5] = Math.Round(100.0 * array[num, 5]) / 100.0;
		}
		priceProduct += array[num, 0] * Consts2.lystStalnyj30.Price;
		num++;
		materialName[num] = Consts2.lystStalnyj40.MaterialName;
		array[num, 0] = 0.023530000000000002;
		array[num, 1] = 0.3;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 5] = array[num, 4] * 7825.0 * 4.0 / 1000.0;
		array[num, 2] = array[num, 4] * array[num, 1];
		array[num, 3] = array[num, 5] * array[num, 1];
		if (array[num, 0] < 0.005)
		{
			array[num, 0] = Math.Round(1000.0 * array[num, 0]) / 1000.0;
		}
		else
		{
			array[num, 0] = Math.Round(100.0 * array[num, 0]) / 100.0;
		}
		if (array[num, 2] < 0.005)
		{
			array[num, 2] = Math.Round(1000.0 * array[num, 2]) / 1000.0;
		}
		else
		{
			array[num, 2] = Math.Round(100.0 * array[num, 2]) / 100.0;
		}
		if (array[num, 3] < 0.005)
		{
			array[num, 3] = Math.Round(1000.0 * array[num, 3]) / 1000.0;
		}
		else
		{
			array[num, 3] = Math.Round(100.0 * array[num, 3]) / 100.0;
		}
		if (array[num, 4] < 0.005)
		{
			array[num, 4] = Math.Round(1000.0 * array[num, 4]) / 1000.0;
		}
		else
		{
			array[num, 4] = Math.Round(100.0 * array[num, 4]) / 100.0;
		}
		if (array[num, 5] < 0.005)
		{
			array[num, 5] = Math.Round(1000.0 * array[num, 5]) / 1000.0;
		}
		else
		{
			array[num, 5] = Math.Round(100.0 * array[num, 5]) / 100.0;
		}
		priceProduct += array[num, 0] * Consts2.lystStalnyj40.Price;
		num++;
		array[num, 0] = 1.0;
		array[num, 4] = array[num, 0] * (double)number;
		if (D <= 125)
		{
			materialName[num] = Consts2.plytaVermykulitova_114_108_20.MaterialName;
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_114_108_20.Price;
		}
		else if (D <= 150)
		{
			materialName[num] = Consts2.plytaVermykulitova_139_133_20.MaterialName;
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_139_133_20.Price;
		}
		else if (D <= 160)
		{
			materialName[num] = Consts2.plytaVermykulitova_149_143_20.MaterialName;
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_149_143_20.Price;
		}
		else if (D <= 180)
		{
			materialName[num] = Consts2.plytaVermykulitova_169_163_20.MaterialName;
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_169_163_20.Price;
		}
		else if (D <= 200)
		{
			materialName[num] = Consts2.plytaVermykulitova_189_183_20.MaterialName;
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_189_183_20.Price;
		}
		else if (D <= 250)
		{
			materialName[num] = Consts2.plytaVermykulitova_239_233_20.MaterialName;
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_239_233_20.Price;
		}
		else if (D <= 315)
		{
			materialName[num] = Consts2.plytaVermykulitova_304_298_20.MaterialName;
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_304_298_20.Price;
		}
		else if (D <= 355)
		{
			materialName[num] = Consts2.plytaVermykulitova_344_338_20.MaterialName;
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_344_338_20.Price;
		}
		else if (D <= 400)
		{
			materialName[num] = Consts2.plytaVermykulitova_389_383_20.MaterialName;
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_389_383_20.Price;
		}
		else if (D <= 450)
		{
			materialName[num] = Consts2.plytaVermykulitova_439_433_20.MaterialName;
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_439_433_20.Price;
		}
		else if (D <= 500)
		{
			materialName[num] = Consts2.plytaVermykulitova_489_483_20.MaterialName;
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_489_483_20.Price;
		}
		else if (D <= 560)
		{
			materialName[num] = Consts2.plytaVermykulitova_549_543_20.MaterialName;
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_549_543_20.Price;
		}
		else if (D <= 630)
		{
			materialName[num] = Consts2.plytaVermykulitova_619_613_20.MaterialName;
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_619_613_20.Price;
		}
		else if (D <= 710)
		{
			materialName[num] = Consts2.plytaVermykulitova_699_693_20.MaterialName;
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_699_693_20.Price;
		}
		else if (D <= 800)
		{
			materialName[num] = Consts2.plytaVermykulitova_789_783_20.MaterialName;
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_789_783_20.Price;
		}
		else
		{
			materialName[num] = Consts2.plytaVermykulitova_789_783_20.MaterialName;
			priceProduct += 2.0 * array[num, 0] * Consts2.plytaVermykulitova_789_783_20.Price;
		}
		num++;
		materialName[num] = Consts2.ohraks.MaterialName;
		array[num, 0] = Math.PI * (double)D * 1.05 / 1000.0;
		array[num, 1] = 0.05;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 2] = array[num, 4] * array[num, 1];
		if (array[num, 0] < 0.005)
		{
			array[num, 0] = Math.Round(1000.0 * array[num, 0]) / 1000.0;
		}
		else
		{
			array[num, 0] = Math.Round(100.0 * array[num, 0]) / 100.0;
		}
		if (array[num, 2] < 0.005)
		{
			array[num, 2] = Math.Round(1000.0 * array[num, 2]) / 1000.0;
		}
		else
		{
			array[num, 2] = Math.Round(100.0 * array[num, 2]) / 100.0;
		}
		if (array[num, 4] < 0.005)
		{
			array[num, 4] = Math.Round(1000.0 * array[num, 4]) / 1000.0;
		}
		else
		{
			array[num, 4] = Math.Round(100.0 * array[num, 4]) / 100.0;
		}
		priceProduct += array[num, 0] * Consts2.ohraks.Price;
		num++;
		materialName[num] = Consts2.kruh6.MaterialName;
		array[num, 0] = 0.03465;
		array[num, 1] = 0.05;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 2] = array[num, 4] * array[num, 1];
		if (array[num, 0] < 0.005)
		{
			array[num, 0] = Math.Round(1000.0 * array[num, 0]) / 1000.0;
		}
		else
		{
			array[num, 0] = Math.Round(100.0 * array[num, 0]) / 100.0;
		}
		if (array[num, 2] < 0.005)
		{
			array[num, 2] = Math.Round(1000.0 * array[num, 2]) / 1000.0;
		}
		else
		{
			array[num, 2] = Math.Round(100.0 * array[num, 2]) / 100.0;
		}
		if (array[num, 4] < 0.005)
		{
			array[num, 4] = Math.Round(1000.0 * array[num, 4]) / 1000.0;
		}
		else
		{
			array[num, 4] = Math.Round(100.0 * array[num, 4]) / 100.0;
		}
		priceProduct += array[num, 0] * Consts2.kruh6.Price;
		num++;
		materialName[num] = Consts2.kruh22.MaterialName;
		array[num, 0] = 0.09975;
		array[num, 1] = 0.05;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 5] = array[num, 4] * 0.75;
		if (array[num, 0] < 0.005)
		{
			array[num, 0] = Math.Round(1000.0 * array[num, 0]) / 1000.0;
		}
		else
		{
			array[num, 0] = Math.Round(100.0 * array[num, 0]) / 100.0;
		}
		if (array[num, 4] < 0.005)
		{
			array[num, 4] = Math.Round(1000.0 * array[num, 4]) / 1000.0;
		}
		else
		{
			array[num, 4] = Math.Round(100.0 * array[num, 4]) / 100.0;
		}
		if (array[num, 5] < 0.005)
		{
			array[num, 5] = Math.Round(1000.0 * array[num, 5]) / 1000.0;
		}
		else
		{
			array[num, 5] = Math.Round(100.0 * array[num, 5]) / 100.0;
		}
		priceProduct += array[num, 0] * Consts2.kruh22.Price;
		num++;
		materialName[num] = Consts2.kruh18LC59.MaterialName;
		array[num, 0] = 0.052500000000000005;
		array[num, 1] = 0.05;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 2] = array[num, 4] * array[num, 1];
		if (array[num, 0] < 0.005)
		{
			array[num, 0] = Math.Round(1000.0 * array[num, 0]) / 1000.0;
		}
		else
		{
			array[num, 0] = Math.Round(100.0 * array[num, 0]) / 100.0;
		}
		if (array[num, 2] < 0.005)
		{
			array[num, 2] = Math.Round(1000.0 * array[num, 2]) / 1000.0;
		}
		else
		{
			array[num, 2] = Math.Round(100.0 * array[num, 2]) / 100.0;
		}
		if (array[num, 4] < 0.005)
		{
			array[num, 4] = Math.Round(1000.0 * array[num, 4]) / 1000.0;
		}
		else
		{
			array[num, 4] = Math.Round(100.0 * array[num, 4]) / 100.0;
		}
		priceProduct += array[num, 0] * Consts2.kruh18LC59.Price;
		num++;
		materialName[num] = Consts2.uschilnjuvachThermasheet.MaterialName;
		array[num, 0] = 0.004200000000000001;
		array[num, 1] = 0.05;
		array[num, 4] = array[num, 0] * (double)number;
		if (array[num, 0] < 0.005)
		{
			array[num, 0] = Math.Round(1000.0 * array[num, 0]) / 1000.0;
		}
		else
		{
			array[num, 0] = Math.Round(100.0 * array[num, 0]) / 100.0;
		}
		if (array[num, 4] < 0.005)
		{
			array[num, 4] = Math.Round(1000.0 * array[num, 4]) / 1000.0;
		}
		else
		{
			array[num, 4] = Math.Round(100.0 * array[num, 4]) / 100.0;
		}
		priceProduct += array[num, 0] * Consts2.uschilnjuvachThermasheet.Price;
		num++;
		materialName[num] = Consts2.uschilnjuvachGumovyiD.MaterialName;
		array[num, 0] = Math.PI * (double)D * 1.05 / 1000.0;
		array[num, 1] = 0.05;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 2] = array[num, 4] * array[num, 1];
		if (array[num, 0] < 0.005)
		{
			array[num, 0] = Math.Round(1000.0 * array[num, 0]) / 1000.0;
		}
		else
		{
			array[num, 0] = Math.Round(100.0 * array[num, 0]) / 100.0;
		}
		if (array[num, 2] < 0.005)
		{
			array[num, 2] = Math.Round(1000.0 * array[num, 2]) / 1000.0;
		}
		else
		{
			array[num, 2] = Math.Round(100.0 * array[num, 2]) / 100.0;
		}
		if (array[num, 4] < 0.005)
		{
			array[num, 4] = Math.Round(1000.0 * array[num, 4]) / 1000.0;
		}
		else
		{
			array[num, 4] = Math.Round(100.0 * array[num, 4]) / 100.0;
		}
		priceProduct += array[num, 0] * Consts2.uschilnjuvachGumovyiD.Price;
		num++;
		materialName[num] = Consts2.farbaAerozol.MaterialName;
		array[num, 0] = 0.15;
		array[num, 5] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.farbaAerozol.Price;
		num++;
		materialName[num] = Consts2.dritObmidnenyj08.MaterialName;
		array[num, 0] = 2.0 * (double)D / 1000.0;
		array[num, 5] = array[num, 0] * (double)number;
		if (array[num, 0] < 0.005)
		{
			array[num, 0] = Math.Round(1000.0 * array[num, 0]) / 1000.0;
		}
		else
		{
			array[num, 0] = Math.Round(100.0 * array[num, 0]) / 100.0;
		}
		if (array[num, 5] < 0.005)
		{
			array[num, 5] = Math.Round(1000.0 * array[num, 5]) / 1000.0;
		}
		else
		{
			array[num, 5] = Math.Round(100.0 * array[num, 5]) / 100.0;
		}
		priceProduct += array[num, 0] * Consts2.dritObmidnenyj08.Price;
		num++;
		materialName[num] = Consts2.sylicon.MaterialName;
		array[num, 0] = 2.0 * (double)D * 0.00035;
		array[num, 4] = array[num, 0] * (double)number;
		if (array[num, 0] < 0.005)
		{
			array[num, 0] = Math.Round(1000.0 * array[num, 0]) / 1000.0;
		}
		else
		{
			array[num, 0] = Math.Round(100.0 * array[num, 0]) / 100.0;
		}
		if (array[num, 4] < 0.005)
		{
			array[num, 4] = Math.Round(1000.0 * array[num, 4]) / 1000.0;
		}
		else
		{
			array[num, 4] = Math.Round(100.0 * array[num, 4]) / 100.0;
		}
		priceProduct += array[num, 0] * Consts2.sylicon.Price;
		num++;
		materialName[num] = Consts2.hvyntM6x12.MaterialName;
		array[num, 0] = 4.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.hvyntM6x12.Price;
		num++;
		materialName[num] = Consts2.boltM6_25.MaterialName;
		array[num, 0] = 1.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.boltM6_25.Price;
		num++;
		materialName[num] = Consts2.hajkaM6.MaterialName;
		array[num, 0] = 10.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.hajkaM6.Price;
		num++;
		materialName[num] = Consts2.shajba5.MaterialName;
		array[num, 0] = 8.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.shajba5.Price;
		num++;
		materialName[num] = Consts2.shajba6.MaterialName;
		array[num, 0] = 15.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.shajba6.Price;
		num++;
		materialName[num] = Consts2.shajbaF10.MaterialName;
		array[num, 0] = 1.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.shajbaF10.Price;
		num++;
		materialName[num] = Consts2.shajbaGroverF6.MaterialName;
		array[num, 0] = 5.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.shajbaGroverF6.Price;
		num++;
		materialName[num] = Consts2.shajbaPidshypnykShtoporneKiltse6.MaterialName;
		array[num, 0] = 2.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.shajbaPidshypnykShtoporneKiltse6.Price;
		num++;
		materialName[num] = Consts2.shajbaGroverF10.MaterialName;
		array[num, 0] = 1.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.shajbaGroverF10.Price;
		num++;
		materialName[num] = Consts2.shajba_8.MaterialName;
		array[num, 0] = 4.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.shajba_8.Price;
		num++;
		materialName[num] = Consts2.bolt5_35.MaterialName;
		if (D <= 250)
		{
			array[num, 0] = 4.0;
		}
		else if (D <= 315)
		{
			array[num, 0] = 6.0;
		}
		else
		{
			array[num, 0] = ((D <= 500) ? 8 : 10);
		}
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.bolt5_35.Price;
		num++;
		materialName[num] = Consts2.boltM8_35.MaterialName;
		array[num, 0] = 2.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.boltM8_35.Price;
		num++;
		materialName[num] = Consts2.hajkaM5.MaterialName;
		array[num, 0] = 8.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.hajkaM5.Price;
		num++;
		materialName[num] = Consts2.hajkaM8.MaterialName;
		array[num, 0] = 2.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.hajkaM8.Price;
		num++;
		materialName[num] = Consts2.gajkaM10.MaterialName;
		array[num, 0] = 1.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.gajkaM10.Price;
		num++;
		materialName[num] = Consts2.hvynt5x10.MaterialName;
		array[num, 0] = 1.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.hvynt5x10.Price;
		num++;
		materialName[num] = Consts2.naklejkaTEZ.MaterialName;
		array[num, 0] = 1.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.naklejkaTEZ.Price;
		num++;
		materialName[num] = Consts2.kvadrat14.MaterialName;
		array[num, 0] = 0.12;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.kvadrat14.Price;
		num++;
		materialName[num] = Consts2.plivkaStrech.MaterialName;
		array[num, 0] = 0.05 * (double)D / 100.0;
		array[num, 4] = array[num, 0] * (double)number;
		if (array[num, 0] < 0.005)
		{
			array[num, 0] = Math.Round(1000.0 * array[num, 0]) / 1000.0;
		}
		else
		{
			array[num, 0] = Math.Round(100.0 * array[num, 0]) / 100.0;
		}
		if (array[num, 4] < 0.005)
		{
			array[num, 4] = Math.Round(1000.0 * array[num, 4]) / 1000.0;
		}
		else
		{
			array[num, 4] = Math.Round(100.0 * array[num, 4]) / 100.0;
		}
		priceProduct += array[num, 0] * Consts2.plivkaStrech.Price;
		num++;
		materialName[num] = Consts2.shurupWS42_19.MaterialName;
		array[num, 0] = Math.Ceiling((double)D / 50.0);
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.shurupWS42_19.Price;
		num++;
		materialName[num] = Consts2.farbaSribljasta.MaterialName;
		array[num, 0] = 0.2 * (2.0 * num2 + num3);
		array[num, 5] = array[num, 0] * (double)number;
		if (array[num, 0] < 0.005)
		{
			array[num, 0] = Math.Round(1000.0 * array[num, 0]) / 1000.0;
		}
		else
		{
			array[num, 0] = Math.Round(100.0 * array[num, 0]) / 100.0;
		}
		if (array[num, 5] < 0.005)
		{
			array[num, 5] = Math.Round(1000.0 * array[num, 5]) / 1000.0;
		}
		else
		{
			array[num, 5] = Math.Round(100.0 * array[num, 5]) / 100.0;
		}
		priceProduct += array[num, 0] * Consts2.farbaSribljasta.Price;
		num++;
		materialName[num] = Consts2.hruntovkaHF.MaterialName;
		array[num, 0] = 0.2 * (2.0 * num2 + num3);
		double num4 = array[num, 0];
		array[num, 5] = array[num, 0] * (double)number;
		if (array[num, 0] < 0.005)
		{
			array[num, 0] = Math.Round(1000.0 * array[num, 0]) / 1000.0;
		}
		else
		{
			array[num, 0] = Math.Round(100.0 * array[num, 0]) / 100.0;
		}
		if (array[num, 5] < 0.005)
		{
			array[num, 5] = Math.Round(1000.0 * array[num, 5]) / 1000.0;
		}
		else
		{
			array[num, 5] = Math.Round(100.0 * array[num, 5]) / 100.0;
		}
		priceProduct += array[num, 0] * Consts2.hruntovkaHF.Price;
		num++;
		materialName[num] = Consts2.rozchynnyk647.MaterialName;
		array[num, 0] = 1.1 * num4;
		array[num, 4] = array[num, 0] * (double)number;
		if (array[num, 0] < 0.005)
		{
			array[num, 0] = Math.Round(1000.0 * array[num, 0]) / 1000.0;
		}
		else
		{
			array[num, 0] = Math.Round(100.0 * array[num, 0]) / 100.0;
		}
		if (array[num, 4] < 0.005)
		{
			array[num, 4] = Math.Round(1000.0 * array[num, 4]) / 1000.0;
		}
		else
		{
			array[num, 4] = Math.Round(100.0 * array[num, 4]) / 100.0;
		}
		priceProduct += array[num, 0] * Consts2.rozchynnyk647.Price;
		num++;
		switch (servopryvid)
		{
		case 1:
			materialName[num] = Consts2.servopryvidBFL_230Т.MaterialName;
			break;
		case 2:
			materialName[num] = Consts2.servopryvidBFN_230Т.MaterialName;
			break;
		default:
			materialName[num] = ((servopryvid == 3) ? Consts2.servopryvidBFL_24T.MaterialName : Consts2.servopryvidBFN_24T.MaterialName);
			break;
		}
		array[num, 0] = 1.0;
		array[num, 4] = array[num, 0] * (double)number;
		double num5 = ((servopryvid == 1) ? (array[num, 0] * Consts2.servopryvidBFL_230Т.Price) : ((servopryvid != 2) ? ((servopryvid == 3) ? Consts2.servopryvidBFL_24T.Price : Consts2.servopryvidBFN_24T.Price) : (array[num, 0] * Consts2.servopryvidBFN_230Т.Price)));
		num++;
		materialName[num] = Consts2.boltM6_60.MaterialName;
		array[num, 0] = 3.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.boltM6_60.Price;
		num++;
		materialName[num] = Consts2.shajba6zbilshena5.MaterialName;
		array[num, 0] = 1.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.shajba6zbilshena5.Price;
		num++;
		materialName[num] = Consts2.paletsNaKlapanServ.MaterialName;
		array[num, 0] = 1.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.paletsNaKlapanServ.Price;
		materialCost = priceProduct + num5;
		priceProduct *= 3.0;
		priceProduct += num5;
		return array;
	}

	public static double[] FormPriceKlapanProtypogegnyjKPkEIS60e()
	{
		double[] array = new double[14];
		int[] array2 = new int[14]
		{
			125, 160, 180, 200, 250, 315, 355, 400, 450, 500,
			560, 630, 710, 800
		};
		double[,] array3 = new double[46, 6];
		for (int i = 0; i < 14; i++)
		{
			array3 = MaterialKlapanProtypogegnyjKPkEIS60e(array2[i], 1, 0);
			array[i] = priceProduct;
		}
		return array;
	}

	public static double VolumeKlapanProtypogegnyjKPkEIS60e(int D)
	{
		return Math.Round((double)D * (double)D * 300.0 / 1000000.0) / 1000.0;
	}
}
