using System;

namespace TEZ_Project.Common.Products;

public static class TsyklonTS
{
	public static string[] materialName = new string[15]
	{
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", "", ""
	};

	public static double materialCost;

	public static double priceProduct;

	public static double[,] MaterialTsyklonTS(int D, int number)
	{
		double[,] array = new double[15, 6];
		int num = -1;
		materialName = new string[15]
		{
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", ""
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
		double num11 = 0.0;
		switch (D)
		{
		case 250:
			num2 += Math.Pow(0.29, 2.0) * 1.1;
			num2 += 0.06168599999999999;
			num2 += 0.11663999999999998;
			num2 += Math.PI * Math.Sqrt(Math.Pow(600.0, 2.0) + Math.Pow((D - 100) / 2, 2.0)) * (double)(100 + D) * 1.15 / 2000000.0;
			num2 += Math.PI * (double)D * 0.3 * 1.05 / 1000.0;
			num2 += Math.Pow(0.262, 2.0) * 1.05;
			num2 += 0.077805;
			num2 += 0.13607023180860792;
			num4 = 0.015876;
			num4 += Math.Pow(0.21, 2.0) * 2.0 * 1.08;
			num4 += Math.Pow(0.15, 2.0) * 2.0 * 1.08;
			num5 += 0.013770000000000003;
			num4 += Math.Pow(0.105, 2.0) * 1.08;
			num4 += Math.Pow(0.31, 2.0) * 2.0 * 1.08;
			num7 += 0.03;
			break;
		case 300:
			num2 += Math.Pow(0.365, 2.0) * 1.1;
			num2 += 0.091884;
			num2 += 0.15552;
			num2 += Math.PI * Math.Sqrt(Math.Pow(700.0, 2.0) + Math.Pow((D - 110) / 2, 2.0)) * (double)(110 + D) * 1.15 / 2000000.0;
			num2 += Math.PI * (double)D * 0.37 * 1.05 / 1000.0;
			num2 += Math.Pow(0.315, 2.0) * 1.05;
			num2 += 0.1134;
			num2 += 0.20748648680633786;
			num4 = 0.018396;
			num4 += Math.Pow(0.24, 2.0) * 2.0 * 1.08;
			num4 += Math.Pow(0.19, 2.0) * 2.0 * 1.08;
			num5 += 0.0162;
			num4 += Math.Pow(0.115, 2.0) * 1.08;
			num4 += Math.Pow(0.355, 2.0) * 2.0 * 1.08;
			num7 += 0.03;
			break;
		case 375:
			num2 += Math.Pow(0.44, 2.0) * 1.1;
			num2 += 0.135292;
			num2 += 0.20196;
			num2 += Math.PI * Math.Sqrt(Math.Pow(895.0, 2.0) + Math.Pow((D - 135) / 2, 2.0)) * (double)(135 + D) * 1.15 / 2000000.0;
			num2 += Math.PI * (double)D * 0.45 * 1.05 / 1000.0;
			num2 += Math.Pow(0.391, 2.0) * 1.05;
			num2 += 0.17640000000000003;
			num2 += 0.3043025184083413;
			num4 = 0.021672;
			num4 += Math.Pow(0.28, 2.0) * 2.0 * 1.08;
			num4 += Math.Pow(0.23, 2.0) * 2.0 * 1.08;
			num5 += 0.018359999999999998;
			num4 += Math.Pow(0.14, 2.0) * 1.08;
			num7 += 0.03;
			num9 += Math.PI * (double)(D + 50) * 2.0 * 1.08 / 1000.0;
			break;
		case 450:
			num2 += Math.Pow(0.52, 2.0) * 1.1;
			num2 += 0.192238;
			num2 += 0.2862;
			num2 += Math.PI * Math.Sqrt(Math.Pow(1045.0, 2.0) + Math.Pow((D - 160) / 2, 2.0)) * (double)(160 + D) * 1.15 / 2000000.0;
			num2 += Math.PI * (double)D * 0.54 * 1.05 / 1000.0;
			num2 += Math.Pow(0.468, 2.0) * 1.05;
			num2 += 0.24276000000000006;
			num2 += 0.4408675510598897;
			num4 = 0.025452000000000002;
			num4 += Math.Pow(0.325, 2.0) * 2.0 * 1.08;
			num4 += Math.Pow(0.28, 2.0) * 2.0 * 1.08;
			num5 += 0.021600000000000005;
			num4 += Math.Pow(0.165, 2.0) * 1.08;
			num7 += 0.03;
			num9 += Math.PI * (double)(D + 50) * 2.0 * 1.08 / 1000.0;
			break;
		case 500:
			num2 += Math.Pow(0.64, 2.0) * 1.1;
			num2 += 0.28476;
			num2 += 351.0 / 800.0;
			num2 += Math.PI * Math.Sqrt(Math.Pow(1295.0, 2.0) + Math.Pow((D - 200) / 2, 2.0)) * (double)(200 + D) * 1.15 / 2000000.0;
			num2 += Math.PI * (double)D * 0.66 * 1.05 / 1000.0;
			num2 += Math.Pow(0.522, 2.0) * 1.05;
			num2 += 0.38745000000000007;
			num2 += 0.6585799219536622;
			num4 = 0.030366;
			num4 += Math.Pow(0.385, 2.0) * 2.0 * 1.08;
			num4 += Math.Pow(0.34, 2.0) * 2.0 * 1.08;
			num5 += 0.025380000000000003;
			num4 += Math.Pow(0.205, 2.0) * 1.08;
			num7 += 0.03;
			num9 += Math.PI * (double)(D + 50) * 2.0 * 1.08 / 1000.0;
			break;
		case 600:
			num2 += Math.Pow(0.695, 2.0) * 1.1;
			num2 += 0.327731;
			num2 += 0.58296;
			num2 += Math.PI * Math.Sqrt(Math.Pow(1435.0, 2.0) + Math.Pow((D - 220) / 2, 2.0)) * (double)(220 + D) * 1.15 / 2000000.0;
			num2 += Math.PI * (double)D * 0.72 * 1.05 / 1000.0;
			num2 += Math.Pow(0.624, 2.0) * 1.05;
			num2 += 0.42524999999999996;
			num2 += 0.772878916672893;
			num4 = 0.031374;
			num5 += 0.027540000000000005;
			num4 += Math.Pow(0.225, 2.0) * 1.08;
			num7 += 0.03;
			num9 += 2.7821944540191206;
			num9 += Math.PI * 486.0 / 625.0;
			num9 += Math.PI * (double)(D + 50) * 2.0 * 1.08 / 1000.0;
			break;
		case 675:
			num2 += Math.Pow(0.765, 2.0) * 1.1;
			num3 += 0.39992399999999995;
			num3 += 0.75264;
			num3 += Math.PI * Math.Sqrt(Math.Pow(1595.0, 2.0) + Math.Pow((D - 250) / 2, 2.0)) * (double)(250 + D) * 1.15 / 2000000.0;
			num3 += Math.PI * (double)D * 0.8 * 1.05 / 1000.0;
			num3 += Math.Pow(0.701, 2.0) * 1.05;
			num3 += 0.5925149999999999;
			num3 += 0.9632123075906306;
			num4 = 0.035280000000000006;
			num5 += 0.030078;
			num4 += Math.Pow(0.256, 2.0) * 1.08;
			num7 += 0.03;
			num9 += 3.094343100079803;
			num9 += 2.7821944540191206;
			num9 += Math.PI * (double)(D + 50) * 2.0 * 1.08 / 1000.0;
			break;
		case 730:
			num2 += Math.Pow(0.84, 2.0) * 1.1;
			num3 += 0.473655;
			num3 += 1.0368;
			num3 += Math.PI * Math.Sqrt(Math.Pow(1745.0, 2.0) + Math.Pow((D - 270) / 2, 2.0)) * (double)(270 + D) * 1.15 / 2000000.0;
			num3 += Math.PI * (double)D * 0.88 * 1.05 / 1000.0;
			num3 += Math.Pow(0.759, 2.0) * 1.05;
			num3 += 0.6674640000000001;
			num3 += 1.1611326447667878;
			num4 = 0.03843;
			num5 += 0.032940000000000004;
			num4 += Math.Pow(0.276, 2.0) * 1.08;
			num7 += 0.03;
			num9 += 3.365776705349961;
			num9 += Math.PI * 243.0 / 250.0;
			num9 += Math.PI * (double)(D + 50) * 2.0 * 1.08 / 1000.0;
			break;
		case 800:
			num2 += Math.Pow(0.92, 2.0) * 1.1;
			num3 += 0.5556460000000001;
			num3 += 1.200768;
			num3 += Math.PI * Math.Sqrt(Math.Pow(1895.0, 2.0) + Math.Pow((D - 300) / 2, 2.0)) * (double)(300 + D) * 1.15 / 2000000.0;
			num3 += Math.PI * (double)D * 0.96 * 1.05 / 1000.0;
			num3 += Math.Pow(0.831, 2.0) * 1.05;
			num3 += 0.7560000000000001;
			num3 += 1.393359173720145;
			num4 = 0.041832;
			num4 += Math.Pow(0.306, 2.0) * 1.08;
			num7 += 0.03;
			num9 += 3.637210310620119;
			num9 += 3.2911324639006674;
			num9 += 0.03574800000000001;
			num9 += Math.PI * (double)(D + 50) * 2.0 * 1.08 / 1000.0;
			break;
		case 870:
			num2 += Math.Pow(1.005, 2.0) * 1.1;
			num3 += 0.65758;
			num3 += 1.41312;
			num3 += Math.PI * Math.Sqrt(Math.Pow(2075.0, 2.0) + Math.Pow((D - 320) / 2, 2.0)) * (double)(320 + D) * 1.15 / 2000000.0;
			num3 += Math.PI * (double)D * 1.04 * 1.05 / 1000.0;
			num3 += Math.Pow(0.904, 2.0) * 1.05;
			num3 += 0.8913450000000002;
			num3 += 1.646697205305626;
			num4 = 0.044982;
			num4 += Math.Pow(0.326, 2.0) * 1.08;
			num7 += 0.03;
			num9 += 3.908643915890277;
			num9 += 3.5625660691708254;
			num9 += 0.03861;
			num9 += Math.PI * (double)(D + 50) * 2.0 * 1.08 / 1000.0;
			break;
		case 950:
			num2 += Math.Pow(1.09, 2.0) * 1.1;
			num3 += 0.788832;
			num3 += 1.7009999999999998;
			num3 += Math.PI * Math.Sqrt(Math.Pow(2235.0, 2.0) + Math.Pow((D - 350) / 2, 2.0)) * (double)(350 + D) * 1.15 / 2000000.0;
			num3 += Math.PI * (double)D * 1.15 * 1.05 / 1000.0;
			num3 += Math.Pow(0.988, 2.0) * 1.05;
			num3 += 1.141875;
			num3 += 1.9915733928350794;
			num4 = 0.04876200000000001;
			num7 += 0.03;
			num9 += 4.281865123136745;
			num9 += 3.935787276417293;
			num9 += 0.04249800000000001;
			num9 += 1.3775255467460528;
			num11 += Math.PI * (double)(D + 70) * 2.0 * 1.08 / 1000.0;
			break;
		case 1050:
			num2 += Math.Pow(1.21, 2.0) * 1.1;
			num4 = 0.053801999999999996;
			num4 += 0.974276;
			num4 += 1.9406400000000001;
			num4 += Math.PI * Math.Sqrt(Math.Pow(2505.0, 2.0) + Math.Pow(((double)D - 390.0) / 2.0, 2.0)) * (double)(390 + D) * 1.15 / 2000000.0;
			num4 += Math.PI * (double)D * 1.26 * 1.05 / 1000.0;
			num4 += Math.Pow(1.092, 2.0) * 1.05;
			num4 += 1.3072920000000001;
			num4 += 2.400278889103844;
			num8 += 0.03;
			num9 += 4.66865801064672;
			num9 += 4.34293768432253;
			num9 += 0.046116000000000004;
			num9 += 1.5200281895128855;
			num11 += Math.PI * (double)(D + 70) * 2.0 * 1.08 / 1000.0;
			break;
		case 1150:
			num2 += Math.Pow(1.31, 2.0) * 1.1;
			num4 = 0.058338;
			num4 += 1.1804649999999999;
			num4 += 2.2915200000000002;
			num4 += Math.PI * Math.Sqrt(Math.Pow(2735.0, 2.0) + Math.Pow(((double)D - 420.0) / 2.0, 2.0)) * (double)(420 + D) * 1.15 / 2000000.0;
			num4 += Math.PI * (double)D * 1.38 * 1.05 / 1000.0;
			num4 += Math.Pow(1.195, 2.0) * 1.05;
			num4 += 1.6254;
			num4 += 2.867865685682515;
			num8 += 0.03;
			num9 += 5.075808418551957;
			num9 += 4.7500880922277675;
			num9 += 0.05000400000000001;
			num9 += 1.6218157914891949;
			num11 += Math.PI * (double)(D + 70) * 2.0 * 1.08 / 1000.0;
			break;
		case 1235:
			num2 += Math.Pow(1.42, 2.0) * 1.1;
			num4 += 1.3614249999999999;
			num4 += 2.6352;
			num4 += Math.PI * Math.Sqrt(Math.Pow(2945.0, 2.0) + Math.Pow(((double)D - 460.0) / 2.0, 2.0)) * (double)(460 + D) * 1.15 / 2000000.0;
			num4 += Math.PI * (double)D * 1.48 * 1.05 / 1000.0;
			num4 += Math.Pow(1.283, 2.0) * 1.05;
			num4 += 1.8065250000000002;
			num4 += 3.3197837889014057;
			num5 += 0.062369999999999995;
			num8 += 0.03;
			num9 += 5.415100425139654;
			num9 += 5.089380098815465;
			num9 += 0.05351400000000001;
			num9 += 1.7575325941242739;
			num11 += Math.PI * (double)(D + 70) * 2.0 * 1.08 / 1000.0;
			break;
		case 1320:
			num2 += Math.Pow(1.525, 2.0) * 1.1;
			num4 += 1.5541999999999998;
			num4 += 3.00288;
			num4 += Math.PI * Math.Sqrt(Math.Pow(3155.0, 2.0) + Math.Pow(((double)D - 490.0) / 2.0, 2.0)) * (double)(490 + D) * 1.15 / 2000000.0;
			num4 += Math.PI * (double)D * 1.58 * 1.05 / 1000.0;
			num4 += Math.Pow(1.371, 2.0) * 1.05;
			num4 += 2.05821;
			num4 += 3.778629103921464;
			num5 += 0.06678;
			num8 += 0.03;
			num9 += 5.754392431727353;
			num9 += 5.428672105403163;
			num9 += 0.05702400000000001;
			num9 += 1.8593201961005834;
			num11 += Math.PI * (double)(D + 70) * 2.0 * 1.08 / 1000.0;
			break;
		case 1400:
			num2 += Math.Pow(1.59, 2.0) * 1.1;
			num5 += 1.7637749999999999;
			num5 += 3.29472;
			num5 += Math.PI * Math.Sqrt(Math.Pow(3335.0, 2.0) + Math.Pow(((double)D - 500.0) / 2.0, 2.0)) * (double)(500 + D) * 1.15 / 2000000.0;
			num5 += Math.PI * (double)D * 1.68 * 1.05 / 1000.0;
			num5 += Math.Pow(1.456, 2.0) * 1.05;
			num5 += 2.31525;
			num5 += 4.239453622313283;
			num5 += 0.07005600000000001;
			num8 += 0.03;
			num9 += 6.107256118578558;
			num9 += 5.76796411199086;
			num9 += 0.06048000000000001;
			num9 += 1.8932493967593529;
			num11 += Math.PI * (double)(D + 70) * 2.0 * 1.08 / 1000.0;
			break;
		case 1500:
			num2 += Math.Pow(1.72, 2.0) * 1.1;
			num5 += 1.9882229999999999;
			num5 += 3.682176;
			num5 += Math.PI * Math.Sqrt(Math.Pow(3585.0, 2.0) + Math.Pow(((double)D - 550.0) / 2.0, 2.0)) * (double)(550 + D) * 1.15 / 2000000.0;
			num5 += Math.PI * (double)D * 1.8 * 1.05 / 1000.0;
			num5 += Math.Pow(1.56, 2.0) * 1.05;
			num5 += 2.700432;
			num5 += 4.868840294533461;
			num6 += 0.07497;
			num8 += 0.03;
			num11 += 6.5144065264837945;
			num9 += 6.1751145198960975;
			num9 += 0.064692;
			num9 += 2.062895400053202;
			num11 += Math.PI * (double)(D + 70) * 2.0 * 1.08 / 1000.0;
			break;
		default:
			num2 += Math.Pow(1.85, 2.0) * 1.1;
			num5 += 2.2225840000000003;
			num5 += 4.11264;
			num5 += Math.PI * Math.Sqrt(Math.Pow(3825.0, 2.0) + Math.Pow(((double)D - 590.0) / 2.0, 2.0)) * (double)(590 + D) * 1.15 / 2000000.0;
			num5 += Math.PI * (double)D * 1.92 * 1.05 / 1000.0;
			num5 += Math.Pow(1.663, 2.0) * 1.05;
			num5 += 3.0240000000000005;
			num5 += 5.668438456725135;
			num6 += 0.080136;
			num8 += 0.03;
			num11 += 6.921556934389033;
			num9 += 6.582264927801335;
			num10 += 0.08778240000000001;
			num9 += 2.1986122026882806;
			num11 += Math.PI * (double)(D + 70) * 2.0 * 1.08 / 1000.0;
			break;
		}
		double num12 = 0.0;
		if (num2 > 0.0)
		{
			num++;
			materialName[num] = Consts2.lystStalnyj15.MaterialName;
			array[num, 0] = num2;
			num12 += array[num, 0];
			array[num, 1] = 0.1;
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
		}
		if (num3 > 0.0)
		{
			num++;
			materialName[num] = Consts2.lystStalnyj20.MaterialName;
			array[num, 0] = num3;
			num12 += array[num, 0];
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
		if (num4 > 0.0)
		{
			num++;
			materialName[num] = Consts2.lystStalnyj30.MaterialName;
			array[num, 0] = num4;
			num12 += array[num, 0];
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
		if (num5 > 0.0)
		{
			num++;
			materialName[num] = Consts2.lystStalnyj40.MaterialName;
			array[num, 0] = num5;
			num12 += array[num, 0];
			array[num, 1] = 0.1;
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
		if (num6 > 0.0)
		{
			num++;
			materialName[num] = Consts2.lystStalnyj50.MaterialName;
			array[num, 0] = num6;
			num12 += array[num, 0];
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
		if (num7 > 0.0)
		{
			num++;
			materialName[num] = Consts2.lystStalnyj60.MaterialName;
			array[num, 0] = num7;
			num12 += array[num, 0];
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
		if (num8 > 0.0)
		{
			num++;
			materialName[num] = Consts2.lystStalnyj80.MaterialName;
			array[num, 0] = num8;
			num12 += array[num, 0];
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
			materialName[num] = Consts2.kutnyk32_32_3.MaterialName;
			array[num, 0] = num10;
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
			priceProduct += array[num, 0] * Consts2.kutnyk32_32_3.Price;
		}
		if (num11 > 0.0)
		{
			num++;
			materialName[num] = Consts2.kutnyk35_35_4.MaterialName;
			array[num, 0] = num11;
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
		num++;
		materialName[num] = Consts2.dritObmidnenyj08.MaterialName;
		if (D <= 450)
		{
			array[num, 0] = 3.0;
		}
		else
		{
			array[num, 0] = ((D <= 1050) ? 4 : 5);
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
		if (D <= 600)
		{
			array[num, 0] = 3.0;
		}
		else
		{
			array[num, 0] = ((D <= 1235) ? 4 : 5);
		}
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.soplo60A.Price;
		num++;
		materialName[num] = Consts2.electrod40_80A.MaterialName;
		if (D <= 600)
		{
			array[num, 0] = 3.0;
		}
		else
		{
			array[num, 0] = ((D <= 1235) ? 4 : 5);
		}
		array[num, 4] = array[num, 0] * (double)number;
		priceProduct += array[num, 0] * Consts2.electrod40_80A.Price;
		num++;
		materialName[num] = Consts2.hruntovkaHF.MaterialName;
		array[num, 0] = num12 * 0.25;
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

	public static double[] FormPriceTsyklonTS()
	{
		double[] array = new double[18];
		int[] array2 = new int[18]
		{
			250, 300, 375, 450, 500, 600, 675, 730, 800, 870,
			950, 1050, 1150, 1235, 1320, 1400, 1500, 1600
		};
		double[,] array3 = new double[18, 6];
		for (int i = 0; i < 18; i++)
		{
			array3 = MaterialTsyklonTS(array2[i], 1);
			array[i] = priceProduct;
		}
		return array;
	}

	public static double VolumeTsyklonTS(int D)
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
