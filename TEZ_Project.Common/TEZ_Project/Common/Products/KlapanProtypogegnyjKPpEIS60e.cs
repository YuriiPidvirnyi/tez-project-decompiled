using System;

namespace TEZ_Project.Common.Products;

public static class KlapanProtypogegnyjKPpEIS60e
{
	public static string[] materialName = new string[43]
	{
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", "", "", "", "", "", "", "",
		"", "", ""
	};

	public static double materialCost;

	public static double priceProduct;

	public static double[,] MaterialKlapanProtypogegnyjKPpEIS60e(int B, int H, int number, int servopryvid)
	{
		double[,] array = new double[43, 6];
		int num = -1;
		materialName = new string[43]
		{
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", "", "", "", "", "",
			"", "", ""
		};
		priceProduct = 0.0;
		materialCost = 0.0;
		num++;
		materialName[num] = Consts2.lystOchynkovanyj05.MaterialName;
		array[num, 0] = 2.0 * (double)B * 0.14 * 1.05 / 1000.0;
		if (H >= 350 && H < 600)
		{
			array[num, 0] += 0.072 * (double)(B - 14) * 1.15 / 1000.0;
		}
		else if (H >= 600)
		{
			array[num, 0] += 0.25 * (double)(B - 14) * 1.15 / 1000.0;
		}
		array[num, 1] = 0.15;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 2] = array[num, 1] * array[num, 4];
		array[num, 5] = array[num, 4] * 7825.0 * 0.5 / 1000.0;
		array[num, 3] = array[num, 1] * array[num, 5];
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
		priceProduct += array[num, 0] * Consts2.lystOchynkovanyj05.Price;
		num++;
		materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
		array[num, 0] = (60.0 * (double)(B - 3) + 60.0 * (double)(H - 20 - 13)) / 1000000.0 + 0.0024500000000000004;
		array[num, 0] *= 1.05;
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
		array[num, 0] = (0.002 + 0.102 * (double)(H + 20) / 1000.0 + 0.102 * (double)(B - 6) / 1000.0 + 280.0 * (double)H / 1000000.0 + 0.01386) * 1.05;
		array[num, 0] += (0.6 * (double)(H + 50) / 1000.0 + 0.6 * (double)(B + 50) / 1000.0 + 0.0225) * 1.15;
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
		materialName[num] = Consts2.lystOchynkovanyj15.MaterialName;
		array[num, 0] = 0.08141999999999998;
		array[num, 1] = 0.15;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 2] = array[num, 1] * array[num, 4];
		array[num, 5] = array[num, 4] * 7825.0 * 1.5 / 1000.0;
		array[num, 3] = array[num, 1] * array[num, 5];
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
		priceProduct += array[num, 0] * Consts2.lystOchynkovanyj15.Price;
		num++;
		materialName[num] = Consts2.lystStalnyj15.MaterialName;
		array[num, 0] = 0.0138;
		double num2 = array[num, 0];
		array[num, 1] = 0.15;
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
		priceProduct += array[num, 0] * Consts2.lystStalnyj15.Price;
		num++;
		materialName[num] = Consts2.lystStalnyj40.MaterialName;
		array[num, 0] = 0.00273;
		array[num, 1] = 0.05;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 5] = array[num, 4] * 7825.0 * 4.0 / 1000.0;
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
		priceProduct += array[num, 0] * Consts2.lystStalnyj40.Price;
		num++;
		if (B <= 100 && H <= 200)
		{
			materialName[num] = Consts2.plytaVermykulitova_87_188_20.MaterialName;
		}
		else if (B <= 140 && H <= 200)
		{
			materialName[num] = Consts2.plytaVermykulitova_127_188_20.MaterialName;
		}
		else if (B <= 140 && H <= 250)
		{
			materialName[num] = Consts2.plytaVermykulitova_127_238_20.MaterialName;
		}
		else if (B <= 160 && H <= 200)
		{
			materialName[num] = Consts2.plytaVermykulitova_147_188_20.MaterialName;
		}
		else if (B <= 160 && H <= 250)
		{
			materialName[num] = Consts2.plytaVermykulitova_147_238_20.MaterialName;
		}
		else if (B <= 160 && H <= 315)
		{
			materialName[num] = Consts2.plytaVermykulitova_147_303_20.MaterialName;
		}
		else if (B <= 180 && H <= 200)
		{
			materialName[num] = Consts2.plytaVermykulitova_167_188_20.MaterialName;
		}
		else if (B <= 180 && H <= 250)
		{
			materialName[num] = Consts2.plytaVermykulitova_167_238_20.MaterialName;
		}
		else if (B <= 180 && H <= 315)
		{
			materialName[num] = Consts2.plytaVermykulitova_167_303_20.MaterialName;
		}
		else if (B <= 180 && H <= 355)
		{
			materialName[num] = Consts2.plytaVermykulitova_167_343_20.MaterialName;
		}
		else if (B <= 180 && H <= 400)
		{
			materialName[num] = Consts2.plytaVermykulitova_167_388_20.MaterialName;
		}
		else if (B <= 200 && H <= 200)
		{
			materialName[num] = Consts2.plytaVermykulitova_187_188_20.MaterialName;
		}
		else if (B <= 250 && H <= 200)
		{
			materialName[num] = Consts2.plytaVermykulitova_237_188_20.MaterialName;
		}
		else if (B <= 250 && H <= 250)
		{
			materialName[num] = Consts2.plytaVermykulitova_237_238_20.MaterialName;
		}
		else if (B <= 315 && H <= 200)
		{
			materialName[num] = Consts2.plytaVermykulitova_302_188_20.MaterialName;
		}
		else if (B <= 315 && H <= 250)
		{
			materialName[num] = Consts2.plytaVermykulitova_302_238_20.MaterialName;
		}
		else if (B <= 315 && H <= 315)
		{
			materialName[num] = Consts2.plytaVermykulitova_302_303_20.MaterialName;
		}
		else if (B <= 355 && H <= 200)
		{
			materialName[num] = Consts2.plytaVermykulitova_342_188_20.MaterialName;
		}
		else if (B <= 355 && H <= 250)
		{
			materialName[num] = Consts2.plytaVermykulitova_342_188_20.MaterialName;
		}
		else if (B <= 355 && H <= 315)
		{
			materialName[num] = Consts2.plytaVermykulitova_342_303_20.MaterialName;
		}
		else if (B <= 355 && H <= 355)
		{
			materialName[num] = Consts2.plytaVermykulitova_342_343_20.MaterialName;
		}
		else if (B <= 400 && H <= 200)
		{
			materialName[num] = Consts2.plytaVermykulitova_387_188_20.MaterialName;
		}
		else if (B <= 400 && H <= 250)
		{
			materialName[num] = Consts2.plytaVermykulitova_387_238_20.MaterialName;
		}
		else if (B <= 400 && H <= 315)
		{
			materialName[num] = Consts2.plytaVermykulitova_387_303_20.MaterialName;
		}
		else if (B <= 400 && H <= 355)
		{
			materialName[num] = Consts2.plytaVermykulitova_387_343_20.MaterialName;
		}
		else if (B <= 400 && H <= 400)
		{
			materialName[num] = Consts2.plytaVermykulitova_387_388_20.MaterialName;
		}
		else if (B <= 450 && H <= 200)
		{
			materialName[num] = Consts2.plytaVermykulitova_437_188_20.MaterialName;
		}
		else if (B <= 450 && H <= 250)
		{
			materialName[num] = Consts2.plytaVermykulitova_437_238_20.MaterialName;
		}
		else if (B <= 450 && H <= 315)
		{
			materialName[num] = Consts2.plytaVermykulitova_437_303_20.MaterialName;
		}
		else if (B <= 450 && H <= 355)
		{
			materialName[num] = Consts2.plytaVermykulitova_437_343_20.MaterialName;
		}
		else if (B <= 450 && H <= 400)
		{
			materialName[num] = Consts2.plytaVermykulitova_437_388_20.MaterialName;
		}
		else if (B <= 450 && H <= 450)
		{
			materialName[num] = Consts2.plytaVermykulitova_437_438_20.MaterialName;
		}
		else if (B <= 500 && H <= 200)
		{
			materialName[num] = Consts2.plytaVermykulitova_487_188_20.MaterialName;
		}
		else if (B <= 500 && H <= 250)
		{
			materialName[num] = Consts2.plytaVermykulitova_487_238_20.MaterialName;
		}
		else if (B <= 500 && H <= 315)
		{
			materialName[num] = Consts2.plytaVermykulitova_487_303_20.MaterialName;
		}
		else if (B <= 500 && H <= 355)
		{
			materialName[num] = Consts2.plytaVermykulitova_487_343_20.MaterialName;
		}
		else if (B <= 500 && H <= 400)
		{
			materialName[num] = Consts2.plytaVermykulitova_487_388_20.MaterialName;
		}
		else if (B <= 500 && H <= 450)
		{
			materialName[num] = Consts2.plytaVermykulitova_487_438_20.MaterialName;
		}
		else if (B <= 500 && H <= 500)
		{
			materialName[num] = Consts2.plytaVermykulitova_487_488_20.MaterialName;
		}
		else if (B <= 560 && H <= 200)
		{
			materialName[num] = Consts2.plytaVermykulitova_547_188_20.MaterialName;
		}
		else if (B <= 560 && H <= 250)
		{
			materialName[num] = Consts2.plytaVermykulitova_547_238_20.MaterialName;
		}
		else if (B <= 560 && H <= 315)
		{
			materialName[num] = Consts2.plytaVermykulitova_547_303_20.MaterialName;
		}
		else if (B <= 560 && H <= 355)
		{
			materialName[num] = Consts2.plytaVermykulitova_547_343_20.MaterialName;
		}
		else if (B <= 560 && H <= 400)
		{
			materialName[num] = Consts2.plytaVermykulitova_547_388_20.MaterialName;
		}
		else if (B <= 560 && H <= 450)
		{
			materialName[num] = Consts2.plytaVermykulitova_547_438_20.MaterialName;
		}
		else if (B <= 560 && H <= 500)
		{
			materialName[num] = Consts2.plytaVermykulitova_547_488_20.MaterialName;
		}
		else if (B <= 630 && H <= 200)
		{
			materialName[num] = Consts2.plytaVermykulitova_617_188_20.MaterialName;
		}
		else if (B <= 630 && H <= 250)
		{
			materialName[num] = Consts2.plytaVermykulitova_617_238_20.MaterialName;
		}
		else if (B <= 630 && H <= 315)
		{
			materialName[num] = Consts2.plytaVermykulitova_617_303_20.MaterialName;
		}
		else if (B <= 630 && H <= 355)
		{
			materialName[num] = Consts2.plytaVermykulitova_617_343_20.MaterialName;
		}
		else if (B <= 630 && H <= 400)
		{
			materialName[num] = Consts2.plytaVermykulitova_617_388_20.MaterialName;
		}
		else if (B <= 630 && H <= 450)
		{
			materialName[num] = Consts2.plytaVermykulitova_617_438_20.MaterialName;
		}
		else if (B <= 630 && H <= 500)
		{
			materialName[num] = Consts2.plytaVermykulitova_617_488_20.MaterialName;
		}
		array[num, 0] = 1.0;
		array[num, 4] = array[num, 0] * (double)number;
		if (B <= 100 && H <= 200)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_87_188_20.Price;
		}
		else if (B <= 140 && H <= 200)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_127_188_20.Price;
		}
		else if (B <= 140 && H <= 250)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_127_238_20.Price;
		}
		else if (B <= 160 && H <= 200)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_147_188_20.Price;
		}
		else if (B <= 160 && H <= 250)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_147_238_20.Price;
		}
		else if (B <= 160 && H <= 315)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_147_303_20.Price;
		}
		else if (B <= 180 && H <= 200)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_167_188_20.Price;
		}
		else if (B <= 180 && H <= 250)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_167_238_20.Price;
		}
		else if (B <= 180 && H <= 315)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_167_303_20.Price;
		}
		else if (B <= 180 && H <= 355)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_167_343_20.Price;
		}
		else if (B <= 180 && H <= 400)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_167_388_20.Price;
		}
		else if (B <= 200 && H <= 200)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_187_188_20.Price;
		}
		else if (B <= 250 && H <= 200)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_237_188_20.Price;
		}
		else if (B <= 250 && H <= 250)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_237_238_20.Price;
		}
		else if (B <= 315 && H <= 200)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_302_188_20.Price;
		}
		else if (B <= 315 && H <= 250)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_302_238_20.Price;
		}
		else if (B <= 315 && H <= 315)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_302_303_20.Price;
		}
		else if (B <= 355 && H <= 200)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_342_188_20.Price;
		}
		else if (B <= 355 && H <= 250)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_342_188_20.Price;
		}
		else if (B <= 355 && H <= 315)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_342_303_20.Price;
		}
		else if (B <= 355 && H <= 355)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_342_343_20.Price;
		}
		else if (B <= 400 && H <= 200)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_387_188_20.Price;
		}
		else if (B <= 400 && H <= 250)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_387_238_20.Price;
		}
		else if (B <= 400 && H <= 315)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_387_303_20.Price;
		}
		else if (B <= 400 && H <= 355)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_387_343_20.Price;
		}
		else if (B <= 400 && H <= 400)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_387_388_20.Price;
		}
		else if (B <= 450 && H <= 200)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_437_188_20.Price;
		}
		else if (B <= 450 && H <= 250)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_437_238_20.Price;
		}
		else if (B <= 450 && H <= 315)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_437_303_20.Price;
		}
		else if (B <= 450 && H <= 355)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_437_343_20.Price;
		}
		else if (B <= 450 && H <= 400)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_437_388_20.Price;
		}
		else if (B <= 450 && H <= 450)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_437_438_20.Price;
		}
		else if (B <= 500 && H <= 200)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_487_188_20.Price;
		}
		else if (B <= 500 && H <= 250)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_487_238_20.Price;
		}
		else if (B <= 500 && H <= 315)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_487_303_20.Price;
		}
		else if (B <= 500 && H <= 355)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_487_343_20.Price;
		}
		else if (B <= 500 && H <= 400)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_487_388_20.Price;
		}
		else if (B <= 500 && H <= 450)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_487_438_20.Price;
		}
		else if (B <= 500 && H <= 500)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_487_488_20.Price;
		}
		else if (B <= 560 && H <= 200)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_547_188_20.Price;
		}
		else if (B <= 560 && H <= 250)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_547_238_20.Price;
		}
		else if (B <= 560 && H <= 315)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_547_303_20.Price;
		}
		else if (B <= 560 && H <= 355)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_547_343_20.Price;
		}
		else if (B <= 560 && H <= 400)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_547_388_20.Price;
		}
		else if (B <= 560 && H <= 450)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_547_438_20.Price;
		}
		else if (B <= 560 && H <= 500)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_547_488_20.Price;
		}
		else if (B <= 630 && H <= 200)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_617_188_20.Price;
		}
		else if (B <= 630 && H <= 250)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_617_238_20.Price;
		}
		else if (B <= 630 && H <= 315)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_617_303_20.Price;
		}
		else if (B <= 630 && H <= 355)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_617_343_20.Price;
		}
		else if (B <= 630 && H <= 400)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_617_388_20.Price;
		}
		else if (B <= 630 && H <= 450)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_617_438_20.Price;
		}
		else if (B <= 630 && H <= 500)
		{
			priceProduct += array[num, 0] * Consts2.plytaVermykulitova_617_488_20.Price;
		}
		else
		{
			priceProduct += 2.0 * array[num, 0] * Consts2.plytaVermykulitova_617_488_20.Price;
		}
		num++;
		materialName[num] = Consts2.ohraks.MaterialName;
		array[num, 0] = 2.0 * (double)(B + H) * 1.05 / 1000.0;
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
		if (B < 750 && H < 750)
		{
			num++;
			materialName[num] = Consts2.profilS20.MaterialName;
			array[num, 0] = (4.0 * (double)(B - 32) / 1000.0 + 4.0 * (double)(H - 32) / 1000.0) * 1.03;
			array[num, 1] = 0.03;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 0.5;
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
			priceProduct += array[num, 0] * Consts2.profilS20.Price;
			num++;
			materialName[num] = Consts2.kutnykS20.MaterialName;
			array[num, 0] = 8.0;
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * Consts2.kutnykS20.Price;
		}
		else
		{
			num++;
			materialName[num] = Consts2.profilS30.MaterialName;
			array[num, 0] = (4.0 * (double)(B - 35) / 1000.0 + 4.0 * (double)(H - 35) / 1000.0) * 1.05;
			array[num, 1] = 0.05;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 0.75;
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
			priceProduct += array[num, 0] * Consts2.profilS30.Price;
			num++;
			materialName[num] = Consts2.kutnykS30.MaterialName;
			array[num, 0] = 8.0;
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * Consts2.kutnykS30.Price;
		}
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
		array[num, 0] = 0.05;
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
		materialName[num] = Consts2.sclotekstolitSTEF.MaterialName;
		array[num, 0] = 0.017745000000000004;
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
		priceProduct += array[num, 0] * Consts2.sclotekstolitSTEF.Price;
		num++;
		materialName[num] = Consts2.uschilnjuvachGumovyiD.MaterialName;
		array[num, 0] = 2.0 * (double)(B + H) * 1.05 / 1000.0;
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
		array[num, 0] = 0.0007 * (double)B;
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
		priceProduct += array[num, 0] * Consts2.farbaAerozol.Price;
		num++;
		materialName[num] = Consts2.dritObmidnenyj08.MaterialName;
		array[num, 0] = 0.0008 * (double)B * (double)H / 1000.0;
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
		array[num, 0] = 0.2;
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
		if (H < 350)
		{
			if (B < 350)
			{
				array[num, 0] = 4.0;
			}
			else if (B < 600)
			{
				array[num, 0] = 6.0;
			}
			else if (B < 1000)
			{
				array[num, 0] = 8.0;
			}
		}
		else if (H < 600)
		{
			if (B < 350)
			{
				array[num, 0] = 6.0;
			}
			else if (B < 600)
			{
				array[num, 0] = 9.0;
			}
			else
			{
				array[num, 0] = ((B < 1000) ? 12 : 15);
			}
		}
		else if (B < 350)
		{
			array[num, 0] = 8.0;
		}
		else if (B < 600)
		{
			array[num, 0] = 12.0;
		}
		else
		{
			array[num, 0] = ((B < 1000) ? 16 : 20);
		}
		array[num, 0] += 2.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.shajba5.Price;
		num++;
		materialName[num] = Consts2.shajba6.MaterialName;
		array[num, 0] = 16.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.shajba6.Price;
		num++;
		materialName[num] = Consts2.shajbaF10.MaterialName;
		array[num, 0] = 1.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.shajbaF10.Price;
		num++;
		materialName[num] = Consts2.shajbaGroverF6.MaterialName;
		array[num, 0] = 7.0;
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
		materialName[num] = Consts2.bolt5_30.MaterialName;
		if (H < 350)
		{
			if (B < 350)
			{
				array[num, 0] = 4.0;
			}
			else if (B < 600)
			{
				array[num, 0] = 6.0;
			}
			else if (B < 1000)
			{
				array[num, 0] = 8.0;
			}
		}
		else if (H < 600)
		{
			if (B < 350)
			{
				array[num, 0] = 6.0;
			}
			else if (B < 600)
			{
				array[num, 0] = 9.0;
			}
			else
			{
				array[num, 0] = ((B < 1000) ? 12 : 15);
			}
		}
		else if (B < 350)
		{
			array[num, 0] = 8.0;
		}
		else if (B < 600)
		{
			array[num, 0] = 12.0;
		}
		else
		{
			array[num, 0] = ((B < 1000) ? 16 : 20);
		}
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.bolt5_30.Price;
		num++;
		materialName[num] = Consts2.boltM8_35.MaterialName;
		array[num, 0] = 2.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.boltM8_35.Price;
		num++;
		materialName[num] = Consts2.hajkaM5.MaterialName;
		if (H < 350)
		{
			if (B < 350)
			{
				array[num, 0] = 4.0;
			}
			else if (B < 600)
			{
				array[num, 0] = 6.0;
			}
			else if (B < 1000)
			{
				array[num, 0] = 8.0;
			}
		}
		else if (H < 600)
		{
			if (B < 350)
			{
				array[num, 0] = 6.0;
			}
			else if (B < 600)
			{
				array[num, 0] = 9.0;
			}
			else
			{
				array[num, 0] = ((B < 1000) ? 12 : 15);
			}
		}
		else if (B < 350)
		{
			array[num, 0] = 8.0;
		}
		else if (B < 600)
		{
			array[num, 0] = 12.0;
		}
		else
		{
			array[num, 0] = ((B < 1000) ? 16 : 20);
		}
		array[num, 0] += 2.0;
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
		double num3 = ((servopryvid == 1) ? (array[num, 0] * Consts2.servopryvidBFL_230Т.Price) : ((servopryvid != 2) ? ((servopryvid == 3) ? Consts2.servopryvidBFL_24T.Price : Consts2.servopryvidBFN_24T.Price) : (array[num, 0] * Consts2.servopryvidBFN_230Т.Price)));
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
		materialName[num] = Consts2.plivkaStrech.MaterialName;
		array[num, 0] = 0.05 * (double)H / 100.0;
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
		materialName[num] = Consts2.paletsNaKlapanServ.MaterialName;
		array[num, 0] = 1.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.paletsNaKlapanServ.Price;
		materialCost = priceProduct + num3;
		priceProduct *= 3.0;
		priceProduct += num3;
		return array;
	}

	public static double VolumeKlapanProtypogegnyjKPpEIS60e(int B, int H)
	{
		return Math.Round((double)B * (double)H * 300.0 / 1000000.0) / 1000.0;
	}
}
