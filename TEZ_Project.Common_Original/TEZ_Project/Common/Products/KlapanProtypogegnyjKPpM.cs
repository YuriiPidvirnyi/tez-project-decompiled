using System;

namespace TEZ_Project.Common.Products;

public static class KlapanProtypogegnyjKPpM
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

	public static double[,] MaterialKlapanProtypogegnyjKPpM(int B, int H, int number, int kincevyk, int typKPpM)
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
		array[num, 0] = ((double)(B - 4) * 30.15 * 2.0 / 1000000.0 + ((double)H / 2.0 - 16.0) * 29.13 * 4.0 / 1000000.0 + 0.04) * 1.05;
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
		array[num, 0] = ((double)(B + H + 10) * 250.0 * 2.0 / 1000000.0 + 0.000205 + 0.033) * 1.05;
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
		array[num, 0] = 0.0058;
		if (kincevyk == 1)
		{
			array[num, 0] += 0.001;
		}
		array[num, 0] += 0.002;
		array[num, 0] += ((H > 400) ? 0.06227 : 0.01);
		array[num, 0] *= 1.15;
		array[num, 1] = 0.15;
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
		array[num, 0] = 0.004362;
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
		if (typKPpM < 1)
		{
			int num2 = ((B > H) ? B : H);
			typKPpM = ((num2 < 710 && B + H < 1000) ? 1 : 2);
		}
		if (typKPpM == 1)
		{
			num++;
			materialName[num] = Consts2.profilS20.MaterialName;
			array[num, 0] = 2.0 * (2.0 * (double)(B + H) / 1000.0 - 0.12) * 1.03;
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
			array[num, 0] = 2.0 * (2.0 * (double)(B + H) / 1000.0 - 0.14) * 1.05;
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
		materialName[num] = Consts2.plytaVognezachysnaTECBOR.MaterialName;
		array[num, 0] = ((double)B - 12.0) * (double)(H - 12) / 1000000.0 * 1.2;
		array[num, 1] = 0.2;
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
		num++;
		materialName[num] = Consts2.kruh6.MaterialName;
		array[num, 0] = ((double)H / 2.0 + 30.0) * 1.05 / 1000.0;
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
		if (H <= 250)
		{
			materialName[num] = Consts2.pruzyna25.MaterialName;
		}
		else
		{
			materialName[num] = ((H <= 450) ? Consts2.pruzyna30.MaterialName : Consts2.pruzyna35.MaterialName);
		}
		array[num, 0] = 1.0;
		array[num, 4] = array[num, 0] * (double)number;
		if (H <= 250)
		{
			priceProduct += array[num, 0] * Consts2.pruzyna25.Price;
		}
		else
		{
			priceProduct += ((H <= 450) ? (array[num, 0] * Consts2.pruzyna30.Price) : (array[num, 0] * Consts2.pruzyna35.Price));
		}
		num++;
		materialName[num] = Consts2.ohraks.MaterialName;
		array[num, 0] = 2.0 * (double)(B + H - 20) * 1.03 / 1000.0;
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
		array[num, 0] = (double)(2 * (B + H - 20)) * 1.03 / 1000.0;
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
		priceProduct += array[num, 0] * Consts2.uschilnjuvachGumovyiD.Price;
		num++;
		materialName[num] = Consts2.kysen.MaterialName;
		if (H >= 100 && H <= 300)
		{
			array[num, 0] = 0.04;
		}
		else
		{
			array[num, 0] = ((H <= 650) ? 0.055 : 0.065);
		}
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.kysen.Price;
		num++;
		materialName[num] = Consts2.bolt5_30.MaterialName;
		array[num, 0] = ((H > 450) ? 6 : 4);
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.bolt5_30.Price;
		num++;
		materialName[num] = Consts2.shajba6.MaterialName;
		array[num, 0] = 2.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.shajba6.Price;
		num++;
		materialName[num] = Consts2.hvynt9x11.MaterialName;
		array[num, 0] = 12.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.hvynt9x11.Price;
		num++;
		materialName[num] = Consts2.hajkaM5.MaterialName;
		array[num, 0] = ((H > 450) ? 6 : 4);
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.hajkaM5.Price;
		num++;
		materialName[num] = Consts2.hajkaM6.MaterialName;
		array[num, 0] = 4.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.hajkaM6.Price;
		num++;
		materialName[num] = Consts2.boltM8_35.MaterialName;
		array[num, 0] = 1.0;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.boltM8_35.Price;
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
		materialName[num] = Consts2.sclotekstolitSTEF.MaterialName;
		array[num, 0] = 0.033;
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
		priceProduct += array[num, 0] * Consts2.sclotekstolitSTEF.Price;
		num++;
		materialName[num] = Consts2.hermetykTermostijkyj.MaterialName;
		array[num, 0] = 0.07;
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
		array[num, 0] = (double)B * 0.0007;
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.farbaAerozol.Price;
		if (kincevyk == 1)
		{
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
		}
		if (H == 100)
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
			materialName[num] = Consts2.microvymykachV_15_51C25.MaterialName;
			array[num, 0] = 1.0;
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * Consts2.microvymykachV_15_51C25.Price;
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

	public static double[,] FormPriceKlapanProtypogegnyjKPpM()
	{
		double[,] array = new double[7, 13];
		int[] array2 = new int[13]
		{
			100, 140, 160, 180, 200, 250, 315, 355, 400, 450,
			500, 560, 630
		};
		int[] array3 = new int[7] { 200, 250, 315, 355, 400, 450, 500 };
		double[,] array4 = new double[46, 6];
		array4 = MaterialKlapanProtypogegnyjKPpM(array2[0], array3[0], 1, 1, 1);
		array[0, 0] = priceProduct;
		for (int i = 0; i < 2; i++)
		{
			array4 = MaterialKlapanProtypogegnyjKPpM(array2[1], array3[i], 1, 1, 1);
			array[i, 1] = priceProduct;
		}
		for (int j = 0; j < 3; j++)
		{
			array4 = MaterialKlapanProtypogegnyjKPpM(array2[2], array3[j], 1, 1, 1);
			array[j, 2] = priceProduct;
		}
		for (int k = 0; k < 5; k++)
		{
			array4 = MaterialKlapanProtypogegnyjKPpM(array2[3], array3[k], 1, 1, 1);
			array[k, 3] = priceProduct;
		}
		array4 = MaterialKlapanProtypogegnyjKPpM(array2[4], array3[0], 1, 1, 1);
		array[0, 4] = priceProduct;
		for (int l = 0; l < 2; l++)
		{
			array4 = MaterialKlapanProtypogegnyjKPpM(array2[5], array3[l], 1, 1, 1);
			array[l, 5] = priceProduct;
		}
		for (int m = 0; m < 3; m++)
		{
			array4 = MaterialKlapanProtypogegnyjKPpM(array2[6], array3[m], 1, 1, 1);
			array[m, 6] = priceProduct;
		}
		for (int n = 0; n < 4; n++)
		{
			array4 = MaterialKlapanProtypogegnyjKPpM(array2[7], array3[n], 1, 1, 1);
			array[n, 7] = priceProduct;
		}
		for (int num = 0; num < 5; num++)
		{
			array4 = MaterialKlapanProtypogegnyjKPpM(array2[8], array3[num], 1, 1, 1);
			array[num, 8] = priceProduct;
		}
		for (int num2 = 0; num2 < 6; num2++)
		{
			array4 = MaterialKlapanProtypogegnyjKPpM(array2[9], array3[num2], 1, 1, 1);
			array[num2, 9] = priceProduct;
		}
		for (int num3 = 0; num3 < 7; num3++)
		{
			for (int num4 = 10; num4 < 13; num4++)
			{
				array4 = MaterialKlapanProtypogegnyjKPpM(array2[num4], array3[num3], 1, 1, 1);
				array[num3, num4] = priceProduct;
			}
		}
		return array;
	}

	public static double VolumeKlapanProtypogegnyjKPpM(int B, int H)
	{
		return Math.Round((double)B * (double)H * 250.0 / 1000000.0) / 1000.0;
	}
}
