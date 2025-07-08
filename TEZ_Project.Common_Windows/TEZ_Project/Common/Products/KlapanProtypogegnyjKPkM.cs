using System;

namespace TEZ_Project.Common.Products;

public static class KlapanProtypogegnyjKPkM
{
	public static string[] materialName = new string[46]
	{
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", "", "", ""
	};

	public static double materialCost;

	public static double priceProduct;

	public static double[,] MaterialKlapanProtypogegnyjKPkM(int D, int number, int kincevyk, int typKPkM)
	{
		double[,] array = new double[46, 6];
		int num = -1;
		materialName = new string[46]
		{
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", ""
		};
		priceProduct = 0.0;
		materialCost = 0.0;
		num++;
		materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
		array[num, 0] = ((Math.PI * (double)D / 2.0 - 40.0) * 29.0 * 2.0 / 1000000.0 + 0.04) * 1.05;
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
		materialName[num] = Consts2.lystOchynkovanyj10.MaterialName;
		array[num, 0] = (276.0 * (double)(D + 10) * Math.PI * 1.0 / 1000000.0 + 0.002 + 0.0094) * 1.05;
		array[num, 1] = 0.05;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 5] = array[num, 4] * 7825.0 * 1.0 / 1000.0;
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
		priceProduct += array[num, 0] * Consts2.lystOchynkovanyj10.Price;
		num++;
		materialName[num] = Consts2.lystStalnyj15.MaterialName;
		array[num, 0] = 0.0053;
		if (kincevyk == 1)
		{
			array[num, 0] += 0.001;
		}
		array[num, 0] += 0.002;
		if (D > 450 && D <= 800)
		{
			array[num, 0] += 0.012;
		}
		if (D >= 100 && D <= 450)
		{
			array[num, 0] += 0.004;
		}
		array[num, 0] *= 1.05;
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
		materialName[num] = Consts2.lystStalnyj20.MaterialName;
		if (typKPkM == 1 && D >= 100 && D <= 350)
		{
			array[num, 0] = (Math.Pow(D, 2.0) + Math.Pow(D + 50, 2.0)) * Math.PI * 2.0 / 4000000.0;
		}
		else
		{
			array[num, 0] = 0.0;
		}
		array[num, 0] += 0.004;
		array[num, 0] *= 1.05;
		array[num, 1] = 0.05;
		array[num, 4] = array[num, 0] * (double)number;
		array[num, 5] = array[num, 4] * 7825.0 * 2.0 / 1000.0;
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
		priceProduct += array[num, 0] * Consts2.lystStalnyj20.Price;
		if (typKPkM == 1 && D > 350 && D < 800)
		{
			num++;
			materialName[num] = Consts2.lystStalnyj30.MaterialName;
			array[num, 0] = (Math.Pow(D, 2.0) + Math.Pow(D + 50, 2.0)) * Math.PI * 2.0 / 4000000.0 * 1.05;
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
		}
		num++;
		materialName[num] = Consts2.plytaVognezachysnaTECBOR.MaterialName;
		array[num, 0] = Math.PI * Math.Pow(D, 2.0) / 4000000.0 * 1.3;
		array[num, 1] = 0.3;
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
		priceProduct += array[num, 0] * Consts2.plytaVognezachysnaTECBOR.Price;
		num++;
		materialName[num] = Consts2.kruh16.MaterialName;
		array[num, 0] = 0.08360000000000001;
		array[num, 1] = 0.1;
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
		priceProduct += array[num, 0] * Consts2.kruh16.Price;
		if (D > 100)
		{
			num++;
			materialName[num] = Consts2.kruh6.MaterialName;
			array[num, 0] = ((double)D / 2.0 + 30.0) * 1.05 / 1000.0;
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
		}
		num++;
		materialName[num] = Consts2.pruzyna25.MaterialName;
		array[num, 0] = 1.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.pruzyna25.Price;
		num++;
		materialName[num] = Consts2.ohraks.MaterialName;
		array[num, 0] = (Math.PI * (double)D - 60.0) * 1.03 / 1000.0;
		array[num, 1] = 0.03;
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
		if (array[num, 5] < 0.005)
		{
			array[num, 5] = Math.Round(1000.0 * array[num, 5]) / 1000.0;
		}
		else
		{
			array[num, 5] = Math.Round(100.0 * array[num, 5]) / 100.0;
		}
		priceProduct += array[num, 0] * Consts2.ohraks.Price;
		num++;
		materialName[num] = Consts2.uschilnjuvachGumovyiD.MaterialName;
		array[num, 0] = 2.0 * (Math.PI * (double)D / 2.0 - 40.0) * 1.02 / 1000.0;
		array[num, 1] = 0.02;
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
		materialName[num] = Consts2.kysen.MaterialName;
		if (D >= 100 && D <= 300)
		{
			array[num, 0] = 0.04;
		}
		else
		{
			array[num, 0] = ((D <= 650) ? 0.055 : 0.065);
		}
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.kysen.Price;
		num++;
		materialName[num] = Consts2.bolt5_30.MaterialName;
		array[num, 0] = 4.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.bolt5_30.Price;
		num++;
		materialName[num] = Consts2.boltM8_35.MaterialName;
		array[num, 0] = 1.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.boltM8_35.Price;
		num++;
		materialName[num] = Consts2.hvynt9x11.MaterialName;
		array[num, 0] = ((kincevyk == 1) ? 12 : 10);
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.hvynt9x11.Price;
		num++;
		materialName[num] = Consts2.hajkaM5.MaterialName;
		array[num, 0] = 4.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.hajkaM5.Price;
		if (D > 100)
		{
			num++;
			materialName[num] = Consts2.hajkaM6.MaterialName;
			array[num, 0] = 4.0;
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * Consts2.hajkaM6.Price;
		}
		num++;
		materialName[num] = Consts2.hajkaM8.MaterialName;
		array[num, 0] = 1.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.hajkaM8.Price;
		num++;
		materialName[num] = Consts2.shajba5.MaterialName;
		array[num, 0] = 4.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.shajba5.Price;
		if (D > 100)
		{
			num++;
			materialName[num] = Consts2.shajba6.MaterialName;
			array[num, 0] = 4.0;
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * Consts2.shajba6.Price;
		}
		num++;
		materialName[num] = Consts2.shajba_8.MaterialName;
		array[num, 0] = 2.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.shajba_8.Price;
		num++;
		materialName[num] = Consts2.shajba16.MaterialName;
		array[num, 0] = 2.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.shajba16.Price;
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
		materialName[num] = Consts2.sclotekstolitSTEF.MaterialName;
		array[num, 0] = 0.0094;
		array[num, 1] = 0.01;
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
		materialName[num] = Consts2.hermetykTermostijkyj.MaterialName;
		array[num, 0] = 0.001;
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
		priceProduct += array[num, 0] * Consts2.hermetykTermostijkyj.Price;
		num++;
		materialName[num] = Consts2.farbaAerozol.MaterialName;
		array[num, 0] = 0.1;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.farbaAerozol.Price;
		if (kincevyk == 1)
		{
			num++;
			materialName[num] = Consts2.hvynt3x16.MaterialName;
			array[num, 0] = 2.0;
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * Consts2.hvynt3x16.Price;
			num++;
			materialName[num] = Consts2.hajkaM3.MaterialName;
			array[num, 0] = 2.0;
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * Consts2.hajkaM3.Price;
			num++;
			materialName[num] = Consts2.providPVS3x075.MaterialName;
			array[num, 0] = 0.3605;
			array[num, 1] = 0.03;
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
			priceProduct += array[num, 0] * Consts2.providPVS3x075.Price;
			num++;
			materialName[num] = Consts2.nakonechnykTrubchastyj.MaterialName;
			array[num, 0] = 3.0;
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * Consts2.nakonechnykTrubchastyj.Price;
			num++;
			materialName[num] = Consts2.konector125_250.MaterialName;
			array[num, 0] = 3.0;
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * Consts2.konector125_250.Price;
			num++;
			materialName[num] = Consts2.microvymykachV_15_51C25.MaterialName;
			array[num, 0] = 1.0;
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * Consts2.microvymykachV_15_51C25.Price;
		}
		if (D == 100)
		{
			num++;
			materialName[num] = Consts2.hachokM4x60.MaterialName;
			array[num, 0] = 2.0;
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * Consts2.hachokM4x60.Price;
			num++;
			materialName[num] = Consts2.hajkaM4.MaterialName;
			array[num, 0] = 4.0;
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * Consts2.hajkaM4.Price;
		}
		num++;
		materialName[num] = Consts2.zamokTeplovyj72C.MaterialName;
		array[num, 0] = 1.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.zamokTeplovyj72C.Price;
		materialCost = priceProduct;
		priceProduct *= 3.0;
		return array;
	}

	public static double[] FormPriceKlapanProtypogegnyjKPkM()
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
			array3 = MaterialKlapanProtypogegnyjKPkM(array2[i], 1, 1, 1);
			array[i] = priceProduct;
		}
		return array;
	}

	public static double VolumeKlapanProtypogegnyjKPkM(int D)
	{
		return Math.Round((double)D * (double)D * 260.0 / 1000000.0) / 1000.0;
	}
}
