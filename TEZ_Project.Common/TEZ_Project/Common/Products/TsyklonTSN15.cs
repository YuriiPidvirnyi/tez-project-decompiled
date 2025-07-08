using System;

namespace TEZ_Project.Common.Products;

public static class TsyklonTSN15
{
	public static string[] materialName = new string[18]
	{
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", "", "", "", "", ""
	};

	public static double materialCost;

	public static double priceProduct;

	public static double[,] MaterialTsyklonTSN15(int D, int typTSN15, int number)
	{
		double[,] array = new double[18, 6];
		int num = -1;
		materialName = new string[18]
		{
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", "", "", ""
		};
		priceProduct = 0.0;
		materialCost = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		double num4 = 0.0;
		double num5 = 0.0;
		double num6 = 0.0;
		double num7 = 0.0;
		double num8 = 0.0;
		double num9 = 0.0;
		double num10 = 0.0;
		switch (D)
		{
		case 300:
			if (typTSN15 == 1)
			{
				num2 += Math.Pow(140.0, 2.0) / 1000000.0;
				num2 += 0.08161560000000001;
				num2 += 0.1407945;
				num2 += 0.01830763118879452;
				num2 += 0.007371;
				num4 += 0.015012000000000001;
				num4 += Math.Pow(180.0, 2.0) / 1000000.0;
			}
			num2 += 0.045737999999999994;
			num2 += 0.047516699999999995;
			num2 += 0.031080000000000003;
			num2 += Math.PI * Math.Sqrt(Math.Pow(2.0 * (double)D / 1000.0, 2.0) + Math.Pow(((double)D - 105.0) / 2000.0, 2.0)) * (double)(D + 105) * 1.15 / 2000.0;
			num2 += Math.PI * (double)D * 0.678 * 1.05 / 1000.0;
			num2 += Math.Pow(0.318, 2.0);
			num2 += 0.29616799255040127;
			num4 += 0.018252000000000004;
			num4 += Math.Pow(0.237, 2.0);
			num4 += 0.0126;
			num4 += Math.Pow(205.0, 2.0) / 1000000.0;
			num9 += 2.4089732467726535;
			break;
		case 400:
			if (typTSN15 == 1)
			{
				num2 += Math.Pow(200.0, 2.0) / 1000000.0;
				num2 += 0.1430352;
				num2 += 0.23667;
				num2 += 0.0321950415139882;
				num2 += 0.013608;
				num4 += 0.0189;
				num4 += Math.Pow(240.0, 2.0) / 1000000.0;
			}
			num2 += 0.08063999999999999;
			num2 += 0.082992;
			num2 += 0.05775;
			num2 += Math.PI * Math.Sqrt(Math.Pow(2.0 * (double)D / 1000.0, 2.0) + Math.Pow(((double)D - 140.0) / 2000.0, 2.0)) * (double)(D + 140) * 1.15 / 2000.0;
			num2 += Math.PI * (double)D * 0.904 * 1.05 / 1000.0;
			num2 += Math.Pow(0.424, 2.0);
			num2 += 0.5303473354972303;
			num4 += 0.023436000000000002;
			num4 += Math.Pow(0.3, 2.0);
			num4 += 0.0273;
			num4 += Math.Pow(295.0, 2.0) / 1000000.0;
			num9 += 3.0875572599480487;
			break;
		case 450:
			if (typTSN15 == 1)
			{
				num2 += Math.Pow(230.0, 2.0) / 1000000.0;
				num2 += 0.1782;
				num2 += 0.289107;
				num2 += 0.040672629289700266;
				num2 += 0.01701;
				num4 += 0.020844;
				num4 += Math.Pow(270.0, 2.0) / 1000000.0;
			}
			num2 += 0.10404450000000001;
			num2 += 0.10712730000000001;
			num2 += 0.07056000000000001;
			num2 += Math.PI * Math.Sqrt(Math.Pow(2.0 * (double)D / 1000.0, 2.0) + Math.Pow(((double)D - 160.0) / 2000.0, 2.0)) * (double)(D + 160) * 1.15 / 2000.0;
			num2 += Math.PI * (double)D * 1.017 * 1.05 / 1000.0;
			num2 += Math.Pow(0.477, 2.0);
			num2 += 0.6741265644388494;
			num4 += 0.025812;
			num4 += Math.Pow(0.33, 2.0);
			num4 += 0.02814;
			num4 += Math.Pow(320.0, 2.0) / 1000000.0;
			num9 += 3.4268492665357466;
			break;
		case 500:
			if (typTSN15 == 1)
			{
				num2 += Math.Pow(255.0, 2.0) / 1000000.0;
				num2 += 0.22057200000000002;
				num2 += 0.353808;
				num2 += 0.05030475236560657;
				num2 += 0.02079;
				num4 += 0.022788;
				num4 += Math.Pow(295.0, 2.0) / 1000000.0;
			}
			num3 += 0.12852;
			num3 += 0.13194720000000001;
			num3 += 0.08463000000000001;
			num3 += Math.PI * Math.Sqrt(Math.Pow(2.0 * (double)D / 1000.0, 2.0) + Math.Pow(((double)D - 175.0) / 2000.0, 2.0)) * (double)(D + 175) * 1.15 / 2000.0;
			num3 += Math.PI * (double)D * 1.13 * 1.05 / 1000.0;
			num3 += Math.Pow(0.53, 2.0);
			num3 += 0.8322550178257401;
			num4 += 0.028512000000000006;
			num4 += Math.Pow(0.395, 2.0);
			num4 += 0.06;
			num4 += 0.02856;
			num4 += Math.Pow(340.0, 2.0) / 1000000.0;
			num6 += Math.Pow(60.0, 2.0) * 1.05 / 1000000.0;
			num9 += 3.7661412731234445;
			break;
		case 550:
			if (typTSN15 == 1)
			{
				num2 += Math.Pow(285.0, 2.0) / 1000000.0;
				num2 += 0.266805;
				num2 += 0.424935;
				num2 += 0.055252760795010486;
				num2 += 0.024948;
				num4 += 0.024732;
				num4 += Math.Pow(325.0, 2.0) / 1000000.0;
			}
			num3 += 0.15592500000000004;
			num3 += 0.16065000000000004;
			num3 += 0.102102;
			num3 += Math.PI * Math.Sqrt(Math.Pow(2.0 * (double)D / 1000.0, 2.0) + Math.Pow(((double)D - 195.0) / 2000.0, 2.0)) * (double)(D + 195) * 1.15 / 2000.0;
			num3 += Math.PI * (double)D * 1.243 * 1.05 / 1000.0;
			num3 += Math.Pow(0.583, 2.0);
			num3 += 1.0101854009471052;
			num4 += 0.030888000000000002;
			num4 += Math.Pow(0.425, 2.0);
			num4 += 0.066;
			num4 += 0.02856;
			num4 += Math.Pow(360.0, 2.0) / 1000000.0;
			num6 += Math.Pow(60.0, 2.0) * 1.05 / 1000000.0;
			num9 += 4.105433279711142;
			break;
		case 600:
			if (typTSN15 == 1)
			{
				num2 += Math.Pow(315.0, 2.0) / 1000000.0;
				num2 += 0.31743360000000004;
				num2 += 0.5025636;
				num2 += 0.06603941917111104;
				num2 += 0.0301644;
				num4 += 0.026676;
				num4 += Math.Pow(355.0, 2.0) / 1000000.0;
			}
			num3 += 0.18522;
			num3 += 0.190365;
			num3 += 0.121212;
			num3 += Math.PI * Math.Sqrt(Math.Pow(2.0 * (double)D / 1000.0, 2.0) + Math.Pow(((double)D - 210.0) / 2000.0, 2.0)) * (double)(D + 210) * 1.15 / 2000.0;
			num3 += Math.PI * (double)D * 1.356 * 1.05 / 1000.0;
			num3 += Math.Pow(0.636, 2.0);
			num3 += 1.2018910395359308;
			num4 += 0.033426000000000004;
			num4 += Math.Pow(0.455, 2.0);
			num4 += 0.072;
			num5 += 0.02898;
			num5 += Math.Pow(380.0, 2.0) / 1000000.0;
			num7 += Math.Pow(80.0, 2.0) * 1.05 / 1000000.0;
			num9 += 4.44472528629884;
			break;
		case 650:
			if (typTSN15 == 1)
			{
				num2 += Math.Pow(345.0, 2.0) / 1000000.0;
				num2 += 0.36936900000000006;
				num2 += 0.5788692000000001;
				num2 += 0.08447899725135632;
				num2 += 0.035135099999999996;
				num4 += 0.028620000000000003;
				num4 += Math.Pow(385.0, 2.0) / 1000000.0;
			}
			num3 += 0.21703500000000003;
			num3 += 0.22260000000000002;
			num3 += 0.14458500000000002;
			num3 += Math.PI * Math.Sqrt(Math.Pow(2.0 * (double)D / 1000.0, 2.0) + Math.Pow(((double)D - 230.0) / 2000.0, 2.0)) * (double)(D + 230) * 1.15 / 2000.0;
			num3 += Math.PI * (double)D * 1.469 * 1.05 / 1000.0;
			num3 += Math.Pow(0.689, 2.0);
			num3 += 1.4139725768370417;
			num9 += 1.4407200000000002;
			num5 += Math.Pow(0.485, 2.0);
			num4 += 0.078;
			num5 += 0.02856;
			num5 += Math.Pow(400.0, 2.0) / 1000000.0;
			num7 += Math.Pow(80.0, 2.0) * 1.05 / 1000000.0;
			num9 += 4.784017292886538;
			break;
		case 700:
			if (typTSN15 == 1)
			{
				num2 += Math.Pow(370.0, 2.0) / 1000000.0;
				num2 += 0.42134400000000005;
				num2 += 0.651924;
				num2 += 0.09790459345647232;
				num2 += 0.040219200000000004;
				num4 += 0.030564000000000004;
				num4 += Math.Pow(410.0, 2.0) / 1000000.0;
			}
			num3 += 0.252252;
			num3 += 0.258258;
			num3 += 0.16899750000000002;
			num3 += Math.PI * Math.Sqrt(Math.Pow(2.0 * (double)D / 1000.0, 2.0) + Math.Pow(((double)D - 245.0) / 2000.0, 2.0)) * (double)(D + 245) * 1.15 / 2000.0;
			num3 += Math.PI * (double)D * 1.582 * 1.05 / 1000.0;
			num3 += Math.Pow(0.742, 2.0);
			num3 += 1.6392554006278026;
			num9 += 1.5336;
			num5 += Math.Pow(0.515, 2.0);
			num4 += 0.08960000000000001;
			num5 += 0.05796;
			num5 += Math.Pow(465.0, 2.0) / 1000000.0;
			num7 += Math.Pow(80.0, 2.0) * 1.05 / 1000000.0;
			num9 += 5.123309299474235;
			break;
		case 750:
			if (typTSN15 == 1)
			{
				num2 += Math.Pow(400.0, 2.0) / 1000000.0;
				num2 += 0.49539600000000006;
				num2 += 0.774459;
				num2 += 0.1120723909259989;
				num2 += 0.048195;
				num4 += 0.032508;
				num4 += Math.Pow(440.0, 2.0) / 1000000.0;
			}
			num3 += 0.28917;
			num3 += 0.295596;
			num3 += 0.19530000000000003;
			num3 += Math.PI * Math.Sqrt(Math.Pow(2.0 * (double)D / 1000.0, 2.0) + Math.Pow(((double)D - 265.0) / 2000.0, 2.0)) * (double)(D + 265) * 1.15 / 2000.0;
			num3 += Math.PI * (double)D * 1.695 * 1.05 / 1000.0;
			num3 += Math.Pow(0.795, 2.0);
			num3 += 1.8854880921086594;
			num9 += 1.63728;
			num5 += Math.Pow(0.585, 2.0);
			num4 += 0.105;
			num5 += 0.05859;
			num5 += Math.Pow(490.0, 2.0) / 1000000.0;
			num7 += Math.Pow(80.0, 2.0) * 1.05 / 1000000.0;
			num9 += 5.4626013060619325;
			break;
		case 800:
			if (typTSN15 == 1)
			{
				num2 += Math.Pow(430.0, 2.0) / 1000000.0;
				num2 += 0.563904;
				num2 += 0.876645;
				num2 += 0.11924700314863458;
				num2 += 0.054432;
				num4 += 0.034452;
				num4 += Math.Pow(470.0, 2.0) / 1000000.0;
			}
			num3 += 0.33012;
			num3 += 0.3369975;
			num3 += 0.21829500000000002;
			num3 += Math.PI * Math.Sqrt(Math.Pow(2.0 * (double)D / 1000.0, 2.0) + Math.Pow(((double)D - 280.0) / 2000.0, 2.0)) * (double)(D + 280) * 1.15 / 2000.0;
			num3 += Math.PI * (double)D * 1.808 * 1.05 / 1000.0;
			num3 += Math.Pow(0.848, 2.0);
			num3 += 2.144348101101355;
			num9 += 1.74096;
			num5 += Math.Pow(0.61, 2.0);
			num4 += 0.11199999999999999;
			num6 += 0.05859;
			num6 += Math.Pow(505.0, 2.0) / 1000000.0;
			num7 += Math.Pow(80.0, 2.0) * 1.05 / 1000000.0;
			num9 += 5.80189331264963;
			break;
		case 900:
			if (typTSN15 == 1)
			{
				num2 += Math.Pow(485.0, 2.0) / 1000000.0;
				num2 += 0.7135128000000001;
				num2 += 1.1032392;
				num2 += 0.16031547311268715;
				num2 += 0.069741;
				num4 += 0.03834;
				num4 += Math.Pow(525.0, 2.0) / 1000000.0;
			}
			num3 += 0.41674500000000003;
			num3 += 0.42291900000000004;
			num3 += 0.27636;
			num3 += Math.PI * Math.Sqrt(Math.Pow(2.0 * (double)D / 1000.0, 2.0) + Math.Pow(((double)D - 315.0) / 2000.0, 2.0)) * (double)(D + 315) * 1.15 / 2000.0;
			num3 += Math.PI * (double)D * 2.034 * 1.05 / 1000.0;
			num3 += Math.Pow(0.954, 2.0);
			num3 += 2.7120034201562913;
			num9 += 1.9375200000000001;
			num7 += Math.Pow(0.69, 2.0);
			num4 += 0.148;
			num6 += 0.0882;
			num6 += Math.Pow(595.0, 2.0) / 1000000.0;
			num8 += Math.Pow(100.0, 2.0) * 1.05 / 1000000.0;
			num10 += 6.616194128460105;
			break;
		case 1000:
			if (typTSN15 == 1)
			{
				num2 += Math.Pow(545.0, 2.0) / 1000000.0;
				num2 += 0.8807040000000002;
				num2 += 1.35765;
				num2 += 0.18802432031734911;
				num2 += 0.08694;
				num9 += 1.6891200000000002;
				num4 += Math.Pow(585.0, 2.0) / 1000000.0;
			}
			num3 += 0.51534;
			num3 += 0.523929;
			num3 += 0.33852000000000004;
			num3 += Math.PI * Math.Sqrt(Math.Pow(2.0 * (double)D / 1000.0, 2.0) + Math.Pow(((double)D - 350.0) / 2000.0, 2.0)) * (double)(D + 350) * 1.15 / 2000.0;
			num3 += Math.PI * (double)D * 2.26 * 1.05 / 1000.0;
			num3 += Math.Pow(1.06, 2.0);
			num3 += 3.3577185201935027;
			num9 += 2.13408;
			num7 += Math.Pow(0.75, 2.0);
			num4 += 0.205;
			num6 += 0.11928;
			num6 += Math.Pow(680.0, 2.0) / 1000000.0;
			num8 += Math.Pow(100.0, 2.0) * 1.05 / 1000000.0;
			num10 += 7.2947781416355;
			break;
		case 1200:
			if (typTSN15 == 1)
			{
				num3 += Math.Pow(660.0, 2.0) / 1000000.0;
				num3 += 1.2706848;
				num3 += 1.947456;
				num3 += 0.2723713706772547;
				num3 += 0.12519360000000002;
				num9 += 2.0088000000000004;
				num5 += Math.Pow(700.0, 2.0) / 1000000.0;
			}
			num3 += 0.742392;
			num3 += 0.752703;
			num3 += 0.4928175;
			num3 += Math.PI * Math.Sqrt(Math.Pow(2.0 * (double)D / 1000.0, 2.0) + Math.Pow(((double)D - 420.0) / 2000.0, 2.0)) * (double)(D + 420) * 1.15 / 2000.0;
			num3 += Math.PI * (double)D * 2.741 * 1.05 / 1000.0;
			num3 += Math.Pow(1.272, 2.0);
			num3 += 4.8420022968123755;
			num9 += 2.5272;
			num8 += Math.Pow(0.91, 2.0);
			num4 += 0.245;
			num6 += 0.12012;
			num7 += Math.Pow(760.0, 2.0) / 1000000.0;
			num8 += Math.Pow(100.0, 2.0) * 1.05 / 1000000.0;
			num10 += 8.65194616798629;
			break;
		default:
			if (typTSN15 == 1)
			{
				num3 += Math.Pow(780.0, 2.0) / 1000000.0;
				num3 += 1.7280648;
				num3 += 2.636088;
				num3 += 0.37228815422835126;
				num3 += 0.17199;
				num9 += 2.31984;
				num5 += Math.Pow(820.0, 2.0) / 1000000.0;
			}
			num3 += 1.0143;
			num3 += 1.0287899999999999;
			num3 += 0.666855;
			num3 += Math.PI * Math.Sqrt(Math.Pow(2.0 * (double)D / 1000.0, 2.0) + Math.Pow(((double)D - 490.0) / 2000.0, 2.0)) * (double)(D + 490) * 1.15 / 2000.0;
			num3 += Math.PI * (double)D * 3.164 * 1.05 / 1000.0;
			num3 += Math.Pow(1.483, 2.0);
			num3 += 6.589163865268618;
			num9 += 2.93112;
			num8 += Math.Pow(1.025, 2.0);
			num4 += 0.34199999999999997;
			num7 += 0.222915;
			num7 += Math.Pow(935.0, 2.0) / 1000000.0;
			num8 += Math.Pow(100.0, 2.0) * 1.05 / 1000000.0;
			num10 += 10.00911419433708;
			break;
		}
		double num11 = 0.0;
		if (num2 > 0.0)
		{
			num++;
			materialName[num] = Consts2.lystStalnyj20.MaterialName;
			array[num, 0] = num2;
			num11 += array[num, 0];
			array[num, 1] = 0.1;
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
		}
		if (num3 > 0.0)
		{
			num++;
			materialName[num] = Consts2.lystStalnyj30.MaterialName;
			array[num, 0] = num3;
			num11 += array[num, 0];
			array[num, 1] = 0.1;
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
		if (num4 > 0.0)
		{
			num++;
			materialName[num] = Consts2.lystStalnyj40.MaterialName;
			array[num, 0] = num4;
			num11 += array[num, 0];
			array[num, 1] = 0.05;
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
		}
		if (num5 > 0.0)
		{
			num++;
			materialName[num] = Consts2.lystStalnyj50.MaterialName;
			array[num, 0] = num5;
			num11 += array[num, 0];
			array[num, 1] = 0.05;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 7825.0 * 5.0 / 1000.0;
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
			priceProduct += array[num, 0] * Consts2.lystStalnyj50.Price;
		}
		if (num6 > 0.0)
		{
			num++;
			materialName[num] = Consts2.lystStalnyj60.MaterialName;
			array[num, 0] = num6;
			num11 += array[num, 0];
			array[num, 1] = 0.05;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 7825.0 * 6.0 / 1000.0;
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
			priceProduct += array[num, 0] * Consts2.lystStalnyj60.Price;
		}
		if (num7 > 0.0)
		{
			num++;
			materialName[num] = Consts2.lystStalnyj80.MaterialName;
			array[num, 0] = num7;
			num11 += array[num, 0];
			array[num, 1] = 0.05;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 7825.0 * 8.0 / 1000.0;
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
			priceProduct += array[num, 0] * Consts2.lystStalnyj80.Price;
		}
		if (num8 > 0.0)
		{
			num++;
			materialName[num] = Consts2.lystStalnyj100.MaterialName;
			array[num, 0] = num8;
			num11 += array[num, 0];
			array[num, 1] = 0.05;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 7825.0 * 10.0 / 1000.0;
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
			priceProduct += array[num, 0] * Consts2.lystStalnyj100.Price;
		}
		if (num9 > 0.0)
		{
			num++;
			materialName[num] = Consts2.kutnyk25_25_4.MaterialName;
			array[num, 0] = num9;
			array[num, 1] = 0.08;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 1.46;
			array[num, 2] = array[num, 4] * array[num, 1];
			array[num, 3] = array[num, 2] * 1.46;
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
			priceProduct += array[num, 0] * Consts2.kutnyk25_25_4.Price;
		}
		if (num10 > 0.0)
		{
			num++;
			materialName[num] = Consts2.kutnyk35_35_4.MaterialName;
			array[num, 0] = num10;
			array[num, 1] = 0.08;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 1.6;
			array[num, 2] = array[num, 4] * array[num, 1];
			array[num, 3] = array[num, 2] * 1.6;
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
			priceProduct += array[num, 0] * Consts2.kutnyk35_35_4.Price;
		}
		if (typTSN15 == 1)
		{
			num++;
			materialName[num] = Consts2.boltM8x25.MaterialName;
			if (D <= 550)
			{
				array[num, 0] = 6.0;
			}
			else if (D <= 900)
			{
				array[num, 0] = 8.0;
			}
			else
			{
				array[num, 0] = ((D <= 1200) ? 10 : 12);
			}
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * Consts2.boltM8x25.Price;
			num++;
			materialName[num] = Consts2.hajkaM8.MaterialName;
			array[num, 0] = array[num - 1, 0];
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * Consts2.hajkaM8.Price;
			num++;
			materialName[num] = Consts2.shajbaGroverF8.MaterialName;
			array[num, 0] = array[num - 1, 0];
			array[num, 4] = array[num, 0] * (double)number;
			priceProduct += array[num, 0] * Consts2.shajbaGroverF8.Price;
		}
		num++;
		materialName[num] = Consts2.dritObmidnenyj08.MaterialName;
		if (D <= 400)
		{
			array[num, 0] = 1.5;
		}
		else if (D <= 550)
		{
			array[num, 0] = 2.0;
		}
		else if (D <= 700)
		{
			array[num, 0] = 2.5;
		}
		else
		{
			array[num, 0] = ((D <= 900) ? 3 : 4);
		}
		if (typTSN15 == 1)
		{
			if (D <= 450)
			{
				array[num, 0] += 0.5;
			}
			else if (D <= 650)
			{
				array[num, 0] += 0.7;
			}
			else
			{
				array[num, 0] += ((D <= 900) ? 0.8 : 0.9);
			}
		}
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
		materialName[num] = Consts2.soplo60A.MaterialName;
		if (D <= 400)
		{
			array[num, 0] = 1.0;
		}
		else if (D <= 550)
		{
			array[num, 0] = 2.0;
		}
		else
		{
			array[num, 0] = ((D <= 1000) ? 3 : 4);
		}
		if (typTSN15 == 1)
		{
			array[num, 0] += 1.0;
		}
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.soplo60A.Price;
		num++;
		materialName[num] = Consts2.electrod40_80A.MaterialName;
		array[num, 0] = array[num - 1, 0];
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.electrod40_80A.Price;
		num++;
		materialName[num] = Consts2.hruntovkaHF.MaterialName;
		array[num, 0] = num11 * 0.25;
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
		array[num, 0] = array[num - 1, 0] * 0.7;
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
		materialName[num] = Consts2.pharbaKG.MaterialName;
		array[num, 0] = array[num - 2, 0];
		array[num, 5] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.pharbaKG.Price;
		materialCost = priceProduct;
		priceProduct *= 3.0;
		return array;
	}

	public static double[,] FormPriceTsyklonTSN15()
	{
		double[,] array = new double[14, 2];
		int[] array2 = new int[14]
		{
			300, 400, 450, 500, 550, 600, 650, 700, 750, 800,
			900, 1000, 1200, 1400
		};
		double[,] array3 = new double[18, 6];
		for (int i = 0; i < 14; i++)
		{
			for (int j = 0; j < 2; j++)
			{
				array3 = MaterialTsyklonTSN15(array2[i], j + 1, 1);
				array[i, j] = priceProduct;
			}
		}
		return array;
	}

	public static double VolumeTsyklonTSN15(int D)
	{
		int num = 0;
		return Math.Round((double)D * (double)D * (double)(D switch
		{
			250 => 1150, 
			300 => 1380, 
			375 => 1720, 
			450 => 2035, 
			500 => 2505, 
			600 => 2455, 
			675 => 3053, 
			730 => 3345, 
			800 => 3650, 
			870 => 3980, 
			950 => 4335, 
			1050 => 4815, 
			1150 => 5255, 
			1235 => 5655, 
			1320 => 6045, 
			1400 => 6395, 
			1500 => 6855, 
			_ => 7335, 
		}) / 1000000.0) / 1000.0;
	}
}
