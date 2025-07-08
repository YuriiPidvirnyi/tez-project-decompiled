using System;

namespace TEZ_Project.Common.Products;

public static class DeflektorDK
{
	public static string[] materialName = new string[19]
	{
		"", "", "", "", "", "", "", "", "", "",
		"", "", "", "", "", "", "", "", ""
	};

	public static double materialCost;

	public static double priceProduct;

	public static double[,] MaterialDeflektorDK(int D, int typDK, int typProfil, int number, int markaStali = 0)
	{
		double[,] array = new double[19, 6];
		int num = -1;
		materialName = new string[19]
		{
			"", "", "", "", "", "", "", "", "", "",
			"", "", "", "", "", "", "", "", ""
		};
		priceProduct = 0.0;
		materialCost = 0.0;
		if (D < 300)
		{
			num++;
			materialName[num] = Consts2.lystOchynkovanyj05.MaterialName;
			double num2 = ((D > 160) ? ((D <= 250) ? 0.15 : 0.2) : 0.1);
			num2 *= Math.PI * (double)D / 1000.0 + 0.01;
			double num4;
			double num5;
			double num6;
			double num3;
			switch (D)
			{
			case 100:
				num3 = 0.12;
				num4 = 0.03;
				num5 = 0.17;
				num6 = 0.149;
				break;
			case 110:
				num3 = 0.133;
				num4 = 0.033;
				num5 = 0.185;
				num6 = 0.162;
				break;
			case 115:
				num3 = 0.14;
				num4 = 0.035;
				num5 = 0.195;
				num6 = 0.168;
				break;
			case 120:
				num3 = 0.145;
				num4 = 0.035;
				num5 = 0.2;
				num6 = 0.172;
				break;
			case 130:
				num3 = 0.16;
				num4 = 0.04;
				num5 = 0.22;
				num6 = 0.184;
				break;
			case 140:
				num3 = 0.17;
				num4 = 0.042;
				num5 = 0.235;
				num6 = 0.2;
				break;
			case 150:
				num3 = 0.18;
				num4 = 0.045;
				num5 = 0.255;
				num6 = 0.212;
				break;
			case 160:
				num3 = 0.195;
				num4 = 0.05;
				num5 = 0.27;
				num6 = 0.237;
				break;
			case 180:
				num3 = 0.215;
				num4 = 0.055;
				num5 = 0.305;
				num6 = 0.252;
				break;
			case 200:
				num3 = 0.24;
				num4 = 0.06;
				num5 = 0.335;
				num6 = 0.273;
				break;
			case 250:
				num3 = 0.3;
				num4 = 0.075;
				num5 = 0.42;
				num6 = 0.347;
				break;
			default:
				num3 = 0.34;
				num4 = 0.095;
				num5 = 0.47;
				num6 = 0.384;
				break;
			}
			num3 *= Math.PI * (double)D / 1000.0 + 0.03;
			double num7 = Math.PI * num5 / 2.0 * Math.Sqrt(num4 * num4 + num5 * num5 / 4.0);
			array[num, 0] = (num2 + num3 + num7) * 1.1;
			array[num, 1] = 0.1;
			array[num, 4] = array[num, 0] * (double)number;
			array[num, 5] = array[num, 4] * 7825.0 * 0.5 / 1000.0;
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
			priceProduct = array[num, 0] * Consts2.lystOchynkovanyj05.Price;
			num++;
			if (D <= 200)
			{
				materialName[num] = Consts2.lystOchynkovanyj10.MaterialName;
				array[num, 0] = num6 * 0.03 * 4.0 * 1.05;
				array[num, 1] = 0.05;
				array[num, 4] = array[num, 0] * (double)number;
				array[num, 5] = array[num, 4] * 7825.0 * 1.0 / 1000.0;
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
				priceProduct += array[num, 0] * Consts2.lystOchynkovanyj10.Price;
			}
			else
			{
				materialName[num] = Consts2.lystOchynkovanyj12.MaterialName;
				array[num, 0] = num6 * 0.03 * 1.05;
				array[num, 0] *= ((D <= 250) ? 4 : 6);
				array[num, 1] = 0.05;
				array[num, 4] = array[num, 0] * (double)number;
				array[num, 5] = array[num, 4] * 7825.0 * 1.2 / 1000.0;
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
				priceProduct += array[num, 0] * Consts2.lystOchynkovanyj12.Price;
			}
		}
		else
		{
			double num8;
			double num9;
			double num10;
			double num11;
			double num12;
			switch (D)
			{
			case 300:
				num8 = Math.PI * Math.Sqrt(Math.Pow(306.0, 2.0) + Math.Pow((380 - D) / 2, 2.0)) * (double)(380 + D) / 2000000.0;
				num9 = Math.PI * 2.0 * (double)D * 362.0 / 1000000.0;
				num10 = Math.PI * Math.Sqrt(Math.Pow(50.0, 2.0) + Math.Pow(60.0, 2.0)) * 780.0 / 2000000.0;
				num11 = Math.PI * Math.Sqrt(Math.Pow(90.0, 2.0) + Math.Pow(265.0, 2.0)) * 530.0 / 2000000.0;
				num12 = 0.09072;
				break;
			case 315:
				num8 = Math.PI * Math.Sqrt(Math.Pow(320.0, 2.0) + Math.Pow((400 - D) / 2, 2.0)) * (double)(400 + D) / 2000000.0;
				num9 = Math.PI * 2.0 * (double)D * 380.0 / 1000000.0;
				num10 = Math.PI * Math.Sqrt(Math.Pow(55.0, 2.0) + Math.Pow(60.0, 2.0)) * 820.0 / 2000000.0;
				num11 = Math.PI * Math.Sqrt(Math.Pow(95.0, 2.0) + Math.Pow(265.0, 2.0)) * 530.0 / 2000000.0;
				num12 = 0.09359999999999999;
				break;
			case 355:
				num8 = Math.PI * Math.Sqrt(Math.Pow(355.0, 2.0) + Math.Pow((450 - D) / 2, 2.0)) * (double)(450 + D) / 2000000.0;
				num9 = Math.PI * 2.0 * (double)D * 430.0 / 1000000.0;
				num10 = Math.PI * Math.Sqrt(Math.Pow(60.0, 2.0) + Math.Pow(70.0, 2.0)) * 920.0 / 2000000.0;
				num11 = Math.PI * Math.Sqrt(Math.Pow(110.0, 2.0) + Math.Pow(300.0, 2.0)) * 600.0 / 2000000.0;
				num12 = 0.108;
				break;
			case 400:
				num8 = Math.PI * Math.Sqrt(Math.Pow(410.0, 2.0) + Math.Pow((510 - D) / 2, 2.0)) * (double)(510 + D) / 2000000.0;
				num9 = Math.PI * 2.0 * (double)D * 480.0 / 1000000.0;
				num10 = Math.PI * Math.Sqrt(Math.Pow(65.0, 2.0) + Math.Pow(77.0, 2.0)) * 1045.0 / 2000000.0;
				num11 = Math.PI * Math.Sqrt(Math.Pow(120.0, 2.0) + Math.Pow(340.0, 2.0)) * 680.0 / 2000000.0;
				num12 = 0.12;
				break;
			case 450:
				num8 = Math.PI * Math.Sqrt(Math.Pow(450.0, 2.0) + Math.Pow((570 - D) / 2, 2.0)) * (double)(570 + D) / 2000000.0;
				num9 = Math.PI * 2.0 * (double)D * 540.0 / 1000000.0;
				num10 = Math.PI * Math.Sqrt(Math.Pow(75.0, 2.0) + Math.Pow(112.0, 2.0)) * 1215.0 / 2000000.0;
				num11 = Math.PI * Math.Sqrt(Math.Pow(135.0, 2.0) + Math.Pow(380.0, 2.0)) * 760.0 / 2000000.0;
				num12 = 0.13488;
				break;
			case 500:
				num8 = Math.PI * Math.Sqrt(Math.Pow(500.0, 2.0) + Math.Pow((630 - D) / 2, 2.0)) * (double)(630 + D) / 2000000.0;
				num9 = Math.PI * 2.0 * (double)D * 600.0 / 1000000.0;
				num10 = Math.PI * Math.Sqrt(Math.Pow(85.0, 2.0) + Math.Pow(92.0, 2.0)) * 1315.0 / 2000000.0;
				num11 = Math.PI * Math.Sqrt(Math.Pow(150.0, 2.0) + Math.Pow(420.0, 2.0)) * 840.0 / 2000000.0;
				num12 = 0.2048;
				break;
			case 560:
				num8 = Math.PI * Math.Sqrt(Math.Pow(560.0, 2.0) + Math.Pow((710 - D) / 2, 2.0)) * (double)(710 + D) / 2000000.0;
				num9 = Math.PI * 2.0 * (double)D * 675.0 / 1000000.0;
				num10 = Math.PI * Math.Sqrt(Math.Pow(95.0, 2.0) + Math.Pow(100.0, 2.0)) * 1470.0 / 2000000.0;
				num11 = Math.PI * Math.Sqrt(Math.Pow(170.0, 2.0) + Math.Pow(472.0, 2.0)) * 945.0 / 2000000.0;
				num12 = 0.2272;
				break;
			case 630:
				num8 = Math.PI * Math.Sqrt(Math.Pow(640.0, 2.0) + Math.Pow((800 - D) / 2, 2.0)) * (double)(800 + D) / 2000000.0;
				num9 = Math.PI * 2.0 * (double)D * 760.0 / 1000000.0;
				num10 = Math.PI * Math.Sqrt(Math.Pow(105.0, 2.0) + Math.Pow(112.0, 2.0)) * 1655.0 / 2000000.0;
				num11 = Math.PI * Math.Sqrt(Math.Pow(190.0, 2.0) + Math.Pow(530.0, 2.0)) * 1060.0 / 2000000.0;
				num12 = 0.316;
				break;
			case 710:
				num8 = Math.PI * Math.Sqrt(Math.Pow(720.0, 2.0) + Math.Pow((900 - D) / 2, 2.0)) * (double)(900 + D) / 2000000.0;
				num9 = Math.PI * 2.0 * (double)D * 855.0 / 1000000.0;
				num10 = Math.PI * Math.Sqrt(Math.Pow(120.0, 2.0) + Math.Pow(120.0, 2.0)) * 1870.0 / 2000000.0;
				num11 = Math.PI * Math.Sqrt(Math.Pow(215.0, 2.0) + Math.Pow(600.0, 2.0)) * 1200.0 / 2000000.0;
				num12 = 0.4544;
				break;
			case 800:
				num8 = Math.PI * Math.Sqrt(Math.Pow(800.0, 2.0) + Math.Pow((1000 - D) / 2, 2.0)) * (double)(1000 + D) / 2000000.0;
				num9 = Math.PI * 2.0 * (double)D * 960.0 / 1000000.0;
				num10 = Math.PI * Math.Sqrt(Math.Pow(140.0, 2.0) + Math.Pow(147.0, 2.0)) * 2105.0 / 2000000.0;
				num11 = Math.PI * Math.Sqrt(Math.Pow(240.0, 2.0) + Math.Pow(672.0, 2.0)) * 1345.0 / 2000000.0;
				num12 = 0.5008;
				break;
			case 900:
				num8 = Math.PI * Math.Sqrt(Math.Pow(900.0, 2.0) + Math.Pow((1125 - D) / 2, 2.0)) * (double)(1125 + D) / 2000000.0;
				num9 = Math.PI * 2.0 * (double)D * 1080.0 / 1000000.0;
				num10 = Math.PI * Math.Sqrt(Math.Pow(155.0, 2.0) + Math.Pow(162.0, 2.0)) * 2375.0 / 2000000.0;
				num11 = Math.PI * Math.Sqrt(Math.Pow(270.0, 2.0) + Math.Pow(756.0, 2.0)) * 1512.0 / 2000000.0;
				num12 = 0.5564;
				break;
			default:
				num8 = Math.PI * Math.Sqrt(Math.Pow(1000.0, 2.0) + Math.Pow((1250 - D) / 2, 2.0)) * (double)(1250 + D) / 2000000.0;
				num9 = Math.PI * 2.0 * (double)D * 1200.0 / 1000000.0;
				num10 = Math.PI * Math.Sqrt(Math.Pow(175.0, 2.0) + Math.Pow(180.0, 2.0)) * 2640.0 / 2000000.0;
				num11 = Math.PI * Math.Sqrt(Math.Pow(300.0, 2.0) + Math.Pow(840.0, 2.0)) * 1680.0 / 2000000.0;
				num12 = 0.624;
				break;
			}
			num++;
			if (D <= 450)
			{
				materialName[num] = Consts2.lystOchynkovanyj07.MaterialName;
				array[num, 0] = (num8 + num9 + num10 + num11) * 1.15;
				array[num, 1] = 0.15;
				array[num, 4] = array[num, 0] * (double)number;
				array[num, 5] = array[num, 4] * 7825.0 * 0.7 / 1000.0;
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
				priceProduct = array[num, 0] * Consts2.lystOchynkovanyj07.Price;
			}
			else
			{
				materialName[num] = Consts2.lystOchynkovanyj10.MaterialName;
				array[num, 0] = (num8 + num9 + num10 + num11) * 1.15;
				array[num, 1] = 0.15;
				array[num, 4] = array[num, 0] * (double)number;
				array[num, 5] = array[num, 4] * 7825.0 * 1.0 / 1000.0;
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
				priceProduct += array[num, 0] * Consts2.lystOchynkovanyj10.Price;
			}
			double num13 = 0.0;
			num++;
			if (D <= 710)
			{
				materialName[num] = Consts2.lystStalnyj30.MaterialName;
				array[num, 0] = num12 * 1.05;
				num13 += array[num, 0];
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
			else
			{
				materialName[num] = Consts2.lystStalnyj40.MaterialName;
				array[num, 0] = num12 * 1.05;
				num13 += array[num, 0];
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
			num++;
			if (D <= 800)
			{
				materialName[num] = Consts2.kutnyk25_25_4.MaterialName;
				array[num, 0] = Math.PI * (double)(D + 50) * 1.08 / 1000.0;
				num13 += array[num, 0];
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
			else
			{
				materialName[num] = Consts2.kutnyk32_32_3.MaterialName;
				array[num, 0] = ((D < 900) ? (D + 50) : (D + 65));
				array[num, 0] *= 0.003392920065876977;
				num13 += array[num, 0];
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
			num++;
			if (D <= 450)
			{
				materialName[num] = Consts2.zaklepkaKombinov48x10.MaterialName;
				array[num, 0] = ((D <= 300) ? 48 : 24);
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.zaklepkaKombinov48x10.Price;
			}
			else
			{
				materialName[num] = Consts2.zaklepkaKombinov48x12.MaterialName;
				if (D <= 560)
				{
					array[num, 0] = 32.0;
				}
				else if (D <= 630)
				{
					array[num, 0] = 40.0;
				}
				else
				{
					array[num, 0] = ((D <= 900) ? 48 : 56);
				}
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.zaklepkaKombinov48x12.Price;
			}
			if (D >= 315)
			{
				num++;
				materialName[num] = Consts2.boltM6x16.MaterialName;
				if (D <= 450)
				{
					array[num, 0] = 24.0;
				}
				else if (D <= 560)
				{
					array[num, 0] = 32.0;
				}
				else if (D <= 630)
				{
					array[num, 0] = 40.0;
				}
				else
				{
					array[num, 0] = ((D <= 900) ? 48 : 56);
				}
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.boltM6x16.Price;
				num++;
				materialName[num] = Consts2.hajkaM6.MaterialName;
				array[num, 0] = array[num - 1, 0];
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.hajkaM6.Price;
				num++;
				materialName[num] = Consts2.shajbaGroverF6.MaterialName;
				array[num, 0] = array[num - 1, 0];
				array[num, 4] = array[num, 0] * (double)number;
				priceProduct += array[num, 0] * Consts2.shajbaGroverF6.Price;
			}
			num++;
			materialName[num] = Consts2.hruntovkaHF.MaterialName;
			array[num, 0] = num13 * 0.1;
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
			materialName[num] = Consts2.dritObmidnenyj08.MaterialName;
			array[num, 0] = 0.075;
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
		}
		if (typDK == 4)
		{
			double[,] array2 = new double[5, 6];
			array2 = FlanetsKruglyj.MaterialFlanetsKruglyj(D, typProfil, number, 1);
			priceProduct += FlanetsKruglyj.priceProduct1;
			num++;
			for (int i = 0; i < 5; i++)
			{
				materialName[num + i] = FlanetsKruglyj.materialName1[i];
				for (int j = 0; j < 6; j++)
				{
					array[num + i, j] = array2[i, j];
				}
			}
		}
		materialCost = priceProduct;
		priceProduct *= 3.0;
		return array;
	}

	public static double[] FormPriceDeflektorDK()
	{
		double[] array = new double[23];
		int[] array2 = new int[23]
		{
			100, 125, 140, 150, 160, 180, 200, 225, 250, 280,
			315, 355, 400, 450, 500, 560, 630, 710, 800, 900,
			1000, 1120, 1250
		};
		double[,] array3 = new double[12, 6];
		for (int i = 0; i < 23; i++)
		{
			array3 = MaterialDeflektorDK(array2[i], 0, 4, 1);
			array[i] = priceProduct;
		}
		return array;
	}

	public static double VolumeDeflektorDK(int D)
	{
		return Math.Round(4.0 * (double)D * (double)D * 500.0 / 1000000.0) / 1000.0;
	}
}
