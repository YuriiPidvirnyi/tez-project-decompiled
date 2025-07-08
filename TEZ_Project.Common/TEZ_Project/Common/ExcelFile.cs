using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows;
using Microsoft.Office.Interop.Excel;
using Microsoft.Win32;
using TEZ_Project.Common.Helpers;
using TEZ_Project.Common.Models;
using TEZ_Project.Common.Products;
using TEZ_Project.Common.Products.ZontVytyazhnyy;
using TEZ_Project.Common.Data;
using TEZ_Project;

namespace TEZ_Project.Common;

public class ExcelFile
{
	private readonly string fullPath;

	private Process excelProcess;

	private Microsoft.Office.Interop.Excel.Application myExcelApplication;

	private Workbook myExcelWorkbook;

	private Worksheet myExcelWorkSheet;

	private Worksheet myExcelWorkSheet2;

	private Worksheet myExcelWorkSheet3;

	private static string[] spysannyaMaterialNames;

	private static double[] spysannyaMaterialArgumentsOne;

	private static double[,] spysannyaMaterialArgumentsTwo;

	public string ExcelFilePath { get; set; }

	public int Rownumber { get; set; } = 1;


	public ExcelFile(string excelFilePath)
	{
		ExcelFilePath = excelFilePath;
		fullPath = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 10);
	}

	public ExcelFile(string excelFilePath, int rownumber)
		: this(excelFilePath)
	{
		Rownumber = rownumber;
	}

	public void OpenExcel()
	{
		myExcelApplication = null;
		myExcelApplication = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
		myExcelApplication.DisplayAlerts = false;
		excelProcess = Enumerable.LastOrDefault<Process>(Enumerable.Where<Process>((IEnumerable<Process>)Process.GetProcessesByName("EXCEL"), (Func<Process, bool>)((Process p) => string.IsNullOrEmpty(p.MainWindowTitle))));
		myExcelWorkbook = myExcelApplication.Workbooks._Open(ExcelFilePath, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
		int count = myExcelApplication.Workbooks.Count;
		myExcelWorkSheet = (Worksheet)(dynamic)myExcelWorkbook.Worksheets[1];
		int count2 = myExcelWorkbook.Worksheets.Count;
	}

	public void MakeSpysannya(IEnumerable<IProduct> products, GlobalParameter globalParameter, bool isFor1C = false)
	{
		if (products == null)
		{
			return;
		}
		double result = ((!isFor1C || !double.TryParse(globalParameter.AditionalPercentage1C, out result)) ? 0.0 : ((result < 0.0) ? 0.0 : (result / 100.0)));
		myExcelWorkSheet2 = (Worksheet)(dynamic)myExcelWorkbook.Worksheets[2];
		myExcelWorkSheet.Name = "Списання 1";
		List<Material> list = new List<Material>();
		myExcelWorkSheet.Cells[4, "H"] = (string.IsNullOrWhiteSpace(globalParameter.OrderDate) ? DateTime.Now.Date.ToShortDateString() : globalParameter.OrderDate);
		myExcelWorkSheet.Cells[4, "B"] = globalParameter.OrderCode;
		myExcelWorkSheet.Cells[8, "B"] = globalParameter.Contragent;
		int num = 13;
		int num2 = 1;
		foreach (IProduct product in products)
		{
			myExcelWorkSheet.Cells[num, "B"] = num2++;
			myExcelWorkSheet.Cells[num, "C"] = product.Name;
			myExcelWorkSheet.Cells[num, "E"] = product.Amount;
			myExcelWorkSheet.Cells[num, "F"] = "шт.";
			num++;
		}
		((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{13}:F{num - 1}", Type.Missing).Cells.Borders.LineStyle = XlLineStyle.xlContinuous;
		((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{num + 1}:K{250}", Type.Missing).Cells.Delete(Type.Missing);
		Microsoft.Office.Interop.Excel.Range range = ((_Worksheet)myExcelWorkSheet2).get_Range((object)$"B{15}:K{17}", Type.Missing);
		Microsoft.Office.Interop.Excel.Range destination = ((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{num + 1}:K{num + 3}", Type.Missing);
		range.Copy(destination);
		myExcelWorkSheet.Cells[num + 1, "C"] = (string.IsNullOrWhiteSpace(globalParameter.OrderDate) ? DateTime.Now.Date.ToShortDateString() : globalParameter.OrderDate);
		num += 4;
		num2 = 1;
		foreach (IProduct product2 in products)
		{
			range = GetHeaderSpysannya(num2, product2.Name, product2.Amount.ToString());
			destination = ((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{num}:K{num + 4}", Type.Missing);
			range.Copy(destination);
			num += 4;
			GetMaterialNamesAndArgiments(product2);
			if (product2.Section != "Нестандартний виріб")
			{
				if (spysannyaMaterialNames.Length == 1)
				{
					if (isFor1C && spysannyaMaterialArgumentsOne[1] > 0.0)
					{
						double productAdditionalPercent1C = ProductHelper.GetProductAdditionalPercent1C(product2, result);
						double num3 = (1.0 + spysannyaMaterialArgumentsOne[1] + productAdditionalPercent1C) / (1.0 + spysannyaMaterialArgumentsOne[1]);
						spysannyaMaterialArgumentsOne[0] *= num3;
						spysannyaMaterialArgumentsOne[4] *= num3;
						spysannyaMaterialArgumentsOne[5] *= num3;
						spysannyaMaterialArgumentsOne[2] = spysannyaMaterialArgumentsOne[4] * spysannyaMaterialArgumentsOne[1];
						spysannyaMaterialArgumentsOne[3] = spysannyaMaterialArgumentsOne[5] * spysannyaMaterialArgumentsOne[1];
						spysannyaMaterialArgumentsOne[1] += productAdditionalPercent1C;
					}
					double[] array = SubArray(spysannyaMaterialArgumentsOne, 2, 4);
					if (list.Exists((Material m) => m.Name == spysannyaMaterialNames[0]))
					{
						Material material = Enumerable.FirstOrDefault<Material>(Enumerable.Where<Material>((IEnumerable<Material>)list, (Func<Material, bool>)((Material m) => m.Name == spysannyaMaterialNames[0])));
						for (int j = 0; j < array.Length; j++)
						{
							material.Values[j] += array[j];
						}
						material.Amount++;
					}
					else
					{
						list.Add(new Material(spysannyaMaterialNames[0], array));
					}
					range = GetLineSpysannya(spysannyaMaterialNames[0], spysannyaMaterialArgumentsOne);
					destination = ((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{num}:K{num++}", Type.Missing);
					range.Copy(destination);
				}
				else
				{
					int i;
					for (i = 0; i < spysannyaMaterialNames.Length; i++)
					{
						if (!(spysannyaMaterialNames[i] != ""))
						{
							continue;
						}
						if (isFor1C && spysannyaMaterialArgumentsTwo[i, 1] > 0.0)
						{
							double productAdditionalPercent1C2 = ProductHelper.GetProductAdditionalPercent1C(product2, result);
							double num4 = (1.0 + spysannyaMaterialArgumentsTwo[i, 1] + productAdditionalPercent1C2) / (1.0 + spysannyaMaterialArgumentsTwo[i, 1]);
							spysannyaMaterialArgumentsTwo[i, 0] *= num4;
							spysannyaMaterialArgumentsTwo[i, 4] *= num4;
							spysannyaMaterialArgumentsTwo[i, 5] *= num4;
							spysannyaMaterialArgumentsTwo[i, 2] = spysannyaMaterialArgumentsTwo[i, 4] * spysannyaMaterialArgumentsTwo[i, 1];
							spysannyaMaterialArgumentsTwo[i, 3] = spysannyaMaterialArgumentsTwo[i, 5] * spysannyaMaterialArgumentsTwo[i, 1];
							spysannyaMaterialArgumentsTwo[i, 1] += productAdditionalPercent1C2;
						}
						double[] array2 = ((spysannyaMaterialArgumentsTwo != null) ? GetOneDimentialArr(spysannyaMaterialArgumentsTwo, i) : spysannyaMaterialArgumentsOne);
						double[] array3 = SubArray(array2, 2, 4);
						if (list.Exists((Material m) => m.Name == spysannyaMaterialNames[i]))
						{
							Material material2 = Enumerable.FirstOrDefault<Material>(Enumerable.Where<Material>((IEnumerable<Material>)list, (Func<Material, bool>)((Material m) => m.Name == spysannyaMaterialNames[i])));
							for (int k = 0; k < array3.Length; k++)
							{
								material2.Values[k] += array3[k];
							}
							material2.Amount++;
						}
						else
						{
							list.Add(new Material(spysannyaMaterialNames[i], array3));
						}
						range = GetLineSpysannya(spysannyaMaterialNames[i], array2);
						destination = ((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{num}:K{num++}", Type.Missing);
						range.Copy(destination);
					}
				}
			}
			num2++;
		}
		((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{num - 1}:K{num - 1}", Type.Missing).Borders[XlBordersIndex.xlEdgeBottom].Weight = XlBorderWeight.xlMedium;
		((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{num - 1}:K{num - 1}", Type.Missing).Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
		num++;
		range = GetHeaderSpysannyaSum();
		destination = ((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{num}:K{num + 5}", Type.Missing);
		range.Copy(destination);
		num += 5;
		for (int l = 0; l < list.Count; l++)
		{
			range = GetLineSpysannyaSum(l + 1, list[l].Name, list[l].Values);
			destination = ((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{num}:K{num++}", Type.Missing);
			range.Copy(destination);
		}
		((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{num - 1}:K{num - 1}", Type.Missing).Borders[XlBordersIndex.xlEdgeBottom].Weight = XlBorderWeight.xlMedium;
		((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{num - 1}:K{num - 1}", Type.Missing).Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
		num++;
		range = GetFooterSpysannyaSum();
		destination = ((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{num}:K{num + 7}", Type.Missing);
		range.Copy(destination);
		num += 7;
		num = 1;
		myExcelWorkSheet3 = (Worksheet)(dynamic)myExcelWorkbook.Worksheets[3];
		IEnumerable<CustomConst> allConsts = Consts2.GetAllConsts();
		foreach (CustomConst item in allConsts)
		{
			myExcelWorkSheet3.Cells[num, "A"] = item.MaterialName;
			myExcelWorkSheet3.Cells[num, "B"] = item.MaterialNameFlight;
			myExcelWorkSheet3.Cells[num, "C"] = item.Code1;
			num++;
		}
		Worksheet worksheet = (dynamic)myExcelWorkbook.Worksheets[2];
		worksheet.Delete();
	}

	public void MakeSpysannyaBuh(IEnumerable<IProduct> products, GlobalParameter globalParameter)
	{
		if (products == null)
		{
			return;
		}
		myExcelWorkSheet2 = (Worksheet)(dynamic)myExcelWorkbook.Worksheets[2];
		myExcelWorkSheet.Name = "Списання 1";
		List<Material> list = new List<Material>();
		myExcelWorkSheet.Cells[4, "H"] = (string.IsNullOrWhiteSpace(globalParameter.OrderDate) ? DateTime.Now.Date.ToShortDateString() : globalParameter.OrderDate);
		myExcelWorkSheet.Cells[4, "B"] = globalParameter.OrderCode;
		myExcelWorkSheet.Cells[8, "B"] = globalParameter.Contragent;
		int num = 13;
		int num2 = 1;
		List<ProductCategory> categorizedMaterials = GetCategorizedMaterials(products);
		foreach (ProductCategory item in categorizedMaterials)
		{
			try
			{
				myExcelWorkSheet.Cells[num, "B"] = num2++;
				myExcelWorkSheet.Cells[num, "C"] = item.Name;
				myExcelWorkSheet.Cells[num, "F"] = "м2";
				myExcelWorkSheet.Cells[num, "E"] = ((item.MaterialSpendingClear == 0.0) ? $"{item.Materials[0].Values[2]:0.##}" : $"{item.MaterialSpendingClear:0.##}");
				num++;
			}
			catch
			{
			}
		}
		List<IProduct> list2 = Enumerable.ToList<IProduct>(Enumerable.Where<IProduct>(products, (Func<IProduct, bool>)((IProduct p) => p.IsObladn())));
		foreach (IProduct item2 in list2)
		{
			myExcelWorkSheet.Cells[num, "B"] = num2++;
			myExcelWorkSheet.Cells[num, "C"] = item2.Name;
			myExcelWorkSheet.Cells[num, "E"] = item2.Amount;
			myExcelWorkSheet.Cells[num, "F"] = "шт.";
			num++;
		}
		((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{13}:F{num - 1}", Type.Missing).Cells.Borders.LineStyle = XlLineStyle.xlContinuous;
		((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{num + 1}:K{250}", Type.Missing).Cells.Delete(Type.Missing);
		Microsoft.Office.Interop.Excel.Range range = ((_Worksheet)myExcelWorkSheet2).get_Range((object)$"B{15}:K{17}", Type.Missing);
		Microsoft.Office.Interop.Excel.Range destination = ((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{num + 1}:K{num + 3}", Type.Missing);
		range.Copy(destination);
		myExcelWorkSheet.Cells[num + 1, "C"] = (string.IsNullOrWhiteSpace(globalParameter.OrderDate) ? DateTime.Now.Date.ToShortDateString() : globalParameter.OrderDate);
		num += 4;
		num2 = 1;
		foreach (ProductCategory item3 in categorizedMaterials)
		{
			if (!Enumerable.Any<Material>((IEnumerable<Material>)item3.Materials))
			{
				continue;
			}
			string amount = ((item3.MaterialSpendingClear == 0.0) ? Math.Round(item3.Materials[0].Values[2]).ToString() : Math.Round(item3.MaterialSpendingClear).ToString());
			range = GetHeaderSpysannya(num2, item3.Name, amount);
			destination = ((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{num}:K{num + 4}", Type.Missing);
			range.Copy(destination);
			num += 4;
			foreach (Material material3 in item3.Materials)
			{
				if (!string.IsNullOrEmpty(material3.Name))
				{
					range = GetLineSpysannya(material3.Name, material3.Values);
					destination = ((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{num}:K{num++}", Type.Missing);
					range.Copy(destination);
				}
			}
			num2++;
		}
		foreach (IProduct product in products)
		{
			if (product.IsObladn())
			{
				range = GetHeaderSpysannya(num2, product.Name, product.Amount.ToString());
				destination = ((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{num}:K{num + 4}", Type.Missing);
				range.Copy(destination);
				num += 4;
			}
			GetMaterialNamesAndArgiments(product);
			if (product.Section != "Нестандартний виріб")
			{
				if (spysannyaMaterialNames.Length == 1)
				{
					double[] array = SubArray(spysannyaMaterialArgumentsOne, 2, 4);
					if (list.Exists((Material m) => m.Name == spysannyaMaterialNames[0]))
					{
						Material material = Enumerable.FirstOrDefault<Material>(Enumerable.Where<Material>((IEnumerable<Material>)list, (Func<Material, bool>)((Material m) => m.Name == spysannyaMaterialNames[0])));
						for (int j = 0; j < array.Length; j++)
						{
							material.Values[j] += array[j];
						}
						material.Amount++;
					}
					else
					{
						list.Add(new Material(spysannyaMaterialNames[0], array));
					}
					if (product.IsObladn())
					{
						range = GetLineSpysannya(spysannyaMaterialNames[0], spysannyaMaterialArgumentsOne);
						destination = ((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{num}:K{num++}", Type.Missing);
						range.Copy(destination);
					}
				}
				else
				{
					int i;
					for (i = 0; i < spysannyaMaterialNames.Length; i++)
					{
						if (!(spysannyaMaterialNames[i] != ""))
						{
							continue;
						}
						double[] array2 = ((spysannyaMaterialArgumentsTwo != null) ? GetOneDimentialArr(spysannyaMaterialArgumentsTwo, i) : spysannyaMaterialArgumentsOne);
						double[] array3 = SubArray(array2, 2, 4);
						if (list.Exists((Material m) => m.Name == spysannyaMaterialNames[i]))
						{
							Material material2 = Enumerable.FirstOrDefault<Material>(Enumerable.Where<Material>((IEnumerable<Material>)list, (Func<Material, bool>)((Material m) => m.Name == spysannyaMaterialNames[i])));
							for (int k = 0; k < array3.Length; k++)
							{
								material2.Values[k] += array3[k];
							}
							material2.Amount++;
						}
						else
						{
							list.Add(new Material(spysannyaMaterialNames[i], array3));
						}
						if (product.IsObladn())
						{
							range = GetLineSpysannya(spysannyaMaterialNames[i], array2);
							destination = ((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{num}:K{num++}", Type.Missing);
							range.Copy(destination);
						}
					}
				}
			}
			if (product.IsObladn())
			{
				num2++;
			}
		}
		((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{num - 1}:K{num - 1}", Type.Missing).Borders[XlBordersIndex.xlEdgeBottom].Weight = XlBorderWeight.xlMedium;
		((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{num - 1}:K{num - 1}", Type.Missing).Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
		num++;
		range = GetHeaderSpysannyaSum();
		destination = ((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{num}:K{num + 5}", Type.Missing);
		range.Copy(destination);
		num += 5;
		for (int l = 0; l < list.Count; l++)
		{
			range = GetLineSpysannyaSum(l + 1, list[l].Name, list[l].Values);
			destination = ((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{num}:K{num++}", Type.Missing);
			range.Copy(destination);
		}
		((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{num - 1}:K{num - 1}", Type.Missing).Borders[XlBordersIndex.xlEdgeBottom].Weight = XlBorderWeight.xlMedium;
		((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{num - 1}:K{num - 1}", Type.Missing).Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
		num++;
		range = GetFooterSpysannyaSum();
		destination = ((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{num}:K{num + 7}", Type.Missing);
		range.Copy(destination);
		num += 7;
		Worksheet worksheet = (dynamic)myExcelWorkbook.Worksheets[2];
		worksheet.Delete();
	}

	public void MakeForFlight(IEnumerable<IProduct> products)
	{
		if (products == null)
		{
			return;
		}
		myExcelWorkSheet2 = (Worksheet)(dynamic)myExcelWorkbook.Worksheets[2];
		int num = 2;
		List<Material> materialListForProducts = GetMaterialListForProducts(products);
		foreach (Material item in materialListForProducts)
		{
			CustomConst customConstByName = Consts2.GetCustomConstByName(item.Name);
			double amount = ((item.Values[2] != 0.0) ? item.Values[2] : item.Values[3]);
			Microsoft.Office.Interop.Excel.Range lineFlight = GetLineFlight(customConstByName.MaterialNameFlight, amount, customConstByName.Code1);
			Microsoft.Office.Interop.Excel.Range destination = ((_Worksheet)myExcelWorkSheet).get_Range((object)$"A{num}:K{num}", Type.Missing);
			lineFlight.Copy(destination);
			num++;
		}
	}

	public void MakeOrder(IEnumerable<IProduct> products, GlobalParameter globalParameter)
	{
		myExcelWorkSheet.Name = "Замовлення 1";
		if (products == null)
		{
			return;
		}
		int[] array = new int[41];
		myExcelWorkSheet.Cells[6, "C"] = DateTime.Now.Date;
		myExcelWorkSheet.Cells[2, "C"] = globalParameter.Contragent;
		myExcelWorkSheet.Cells[3, "C"] = globalParameter.OrderCode;
		myExcelWorkSheet.Cells[5, "C"] = globalParameter.Manager;
		int num = 9;
		int num2 = 1;
		foreach (IProduct product in products)
		{
			myExcelWorkSheet.Cells[num, "A"] = num2++;
			myExcelWorkSheet.Cells[num, "B"] = product.Name;
			myExcelWorkSheet.Cells[num, "C"] = product.Amount;
			string prymitka = GetPrymitka(product);
			myExcelWorkSheet.Cells[num, "D"] = prymitka;
			if (string.IsNullOrEmpty(prymitka))
			{
				array[3]++;
			}
			string propertyValueOrDefault = GetPropertyValueOrDefault(product, "B");
			if (propertyValueOrDefault == "")
			{
				array[4]++;
			}
			else
			{
				myExcelWorkSheet.Cells[num, "E"] = propertyValueOrDefault;
			}
			string propertyValueOrDefault2 = GetPropertyValueOrDefault(product, "H");
			if (propertyValueOrDefault2 == "")
			{
				array[5]++;
			}
			else
			{
				myExcelWorkSheet.Cells[num, "F"] = propertyValueOrDefault2;
			}
			string propertyValueOrDefault3 = GetPropertyValueOrDefault(product, "D");
			if (propertyValueOrDefault3 == "")
			{
				array[6]++;
			}
			else
			{
				myExcelWorkSheet.Cells[num, "G"] = propertyValueOrDefault3;
			}
			string propertyValueOrDefault4 = GetPropertyValueOrDefault(product, "D1");
			if (propertyValueOrDefault4 == "")
			{
				array[7]++;
			}
			else
			{
				myExcelWorkSheet.Cells[num, "H"] = propertyValueOrDefault4;
			}
			string propertyValueOrDefault5 = GetPropertyValueOrDefault(product, "D2");
			if (propertyValueOrDefault5 == "")
			{
				array[8]++;
			}
			else
			{
				myExcelWorkSheet.Cells[num, "I"] = propertyValueOrDefault5;
			}
			string propertyValueOrDefault6 = GetPropertyValueOrDefault(product, "L");
			if (propertyValueOrDefault6 == "")
			{
				array[9]++;
			}
			else
			{
				myExcelWorkSheet.Cells[num, "J"] = propertyValueOrDefault6;
			}
			string propertyValueOrDefault7 = GetPropertyValueOrDefault(product, "B1");
			if (propertyValueOrDefault7 == "")
			{
				array[10]++;
			}
			else
			{
				myExcelWorkSheet.Cells[num, "K"] = propertyValueOrDefault7;
			}
			string propertyValueOrDefault8 = GetPropertyValueOrDefault(product, "H1");
			if (propertyValueOrDefault8 == "")
			{
				array[11]++;
			}
			else
			{
				myExcelWorkSheet.Cells[num, "L"] = propertyValueOrDefault8;
			}
			string propertyValueOrDefault9 = GetPropertyValueOrDefault(product, "B2");
			if (propertyValueOrDefault9 == "")
			{
				array[12]++;
			}
			else
			{
				myExcelWorkSheet.Cells[num, "M"] = propertyValueOrDefault9;
			}
			string propertyValueOrDefault10 = GetPropertyValueOrDefault(product, "H2");
			if (propertyValueOrDefault10 == "")
			{
				array[13]++;
			}
			else
			{
				myExcelWorkSheet.Cells[num, "N"] = propertyValueOrDefault10;
			}
			string propertyValueOrDefault11 = GetPropertyValueOrDefault(product, "B3");
			if (propertyValueOrDefault11 == "")
			{
				array[14]++;
			}
			else
			{
				myExcelWorkSheet.Cells[num, "O"] = propertyValueOrDefault11;
			}
			string propertyValueOrDefault12 = GetPropertyValueOrDefault(product, "K");
			if (propertyValueOrDefault12 == "")
			{
				array[15]++;
			}
			else
			{
				myExcelWorkSheet.Cells[num, "P"] = propertyValueOrDefault12;
			}
			string propertyValueOrDefault13 = GetPropertyValueOrDefault(product, "K1");
			if (propertyValueOrDefault13 == "")
			{
				array[16]++;
			}
			else
			{
				myExcelWorkSheet.Cells[num, "Q"] = propertyValueOrDefault13;
			}
			string propertyValueOrDefault14 = GetPropertyValueOrDefault(product, "K2");
			if (propertyValueOrDefault14 == "")
			{
				array[17]++;
			}
			else
			{
				myExcelWorkSheet.Cells[num, "R"] = propertyValueOrDefault14;
			}
			string propertyValueOrDefault15 = GetPropertyValueOrDefault(product, "K3");
			if (propertyValueOrDefault15 == "")
			{
				array[18]++;
			}
			else
			{
				myExcelWorkSheet.Cells[num, "S"] = propertyValueOrDefault15;
			}
			string propertyValueOrDefault16 = GetPropertyValueOrDefault(product, "C");
			if (propertyValueOrDefault16 == "")
			{
				array[19]++;
			}
			else
			{
				myExcelWorkSheet.Cells[num, "T"] = propertyValueOrDefault16;
			}
			string propertyValueOrDefault17 = GetPropertyValueOrDefault(product, "C1");
			if (propertyValueOrDefault17 == "")
			{
				array[20]++;
			}
			else
			{
				myExcelWorkSheet.Cells[num, "U"] = propertyValueOrDefault17;
			}
			string propertyValueOrDefault18 = GetPropertyValueOrDefault(product, "Angle");
			if (propertyValueOrDefault18 == "")
			{
				array[21]++;
			}
			else
			{
				myExcelWorkSheet.Cells[num, "V"] = propertyValueOrDefault18;
			}
			string property = ((product is Product_TrijnykTOASHK) ? "r_l" : "l");
			string propertyValueOrDefault19 = GetPropertyValueOrDefault(product, property);
			if (propertyValueOrDefault19 == "")
			{
				array[22]++;
			}
			else
			{
				myExcelWorkSheet.Cells[num, "W"] = propertyValueOrDefault19;
			}
			string property2 = ((product is Product_TrijnykTOASHK) ? "r_l1" : "l1");
			string propertyValueOrDefault20 = GetPropertyValueOrDefault(product, property2);
			if (propertyValueOrDefault20 == "")
			{
				array[23]++;
			}
			else
			{
				myExcelWorkSheet.Cells[num, "X"] = propertyValueOrDefault20;
			}
			string property3 = ((product is Product_TrijnykTOASHK) ? "r_l2" : "l2");
			string propertyValueOrDefault21 = GetPropertyValueOrDefault(product, property3);
			if (propertyValueOrDefault21 == "")
			{
				array[24]++;
			}
			else
			{
				myExcelWorkSheet.Cells[num, "Y"] = propertyValueOrDefault21;
			}
			string propertyValueOrDefault22 = GetPropertyValueOrDefault(product, "F");
			if (propertyValueOrDefault22 == "")
			{
				array[25]++;
			}
			else
			{
				myExcelWorkSheet.Cells[num, "Z"] = propertyValueOrDefault22;
			}
			string propertyValueOrDefault23 = GetPropertyValueOrDefault(product, "G");
			if (propertyValueOrDefault23 == "")
			{
				array[26]++;
			}
			else
			{
				myExcelWorkSheet.Cells[num, "AA"] = propertyValueOrDefault23;
			}
			string propertyValueOrDefault24 = GetPropertyValueOrDefault(product, "R");
			if (propertyValueOrDefault24 == "" || (propertyValueOrDefault24 == "1" && product is Product_VidvidVK))
			{
				array[27]++;
			}
			else
			{
				myExcelWorkSheet.Cells[num, "AB"] = propertyValueOrDefault24;
			}
			string propertyValueOrDefault25 = GetPropertyValueOrDefault(product, "R1");
			if (propertyValueOrDefault25 == "")
			{
				array[28]++;
			}
			else
			{
				myExcelWorkSheet.Cells[num, "AC"] = propertyValueOrDefault25;
			}
			if (product is Product_AluminiumGrid)
			{
				string propertyValueOrDefault26 = GetPropertyValueOrDefault(product, "SposibKriplennja");
				if (string.IsNullOrEmpty(propertyValueOrDefault26))
				{
					array[29]++;
				}
				else
				{
					myExcelWorkSheet.Cells[num, "AD"] = propertyValueOrDefault26;
				}
				string propertyValueOrDefault27 = GetPropertyValueOrDefault(product, "TypAdaptera");
				if (string.IsNullOrEmpty(propertyValueOrDefault27))
				{
					array[30]++;
				}
				else
				{
					myExcelWorkSheet.Cells[num, "AE"] = propertyValueOrDefault27;
				}
				string propertyValueOrDefault28 = GetPropertyValueOrDefault(product, "ThicknessOfMetalAdapter");
				if (string.IsNullOrEmpty(propertyValueOrDefault28))
				{
					array[31]++;
				}
				else
				{
					myExcelWorkSheet.Cells[num, "AF"] = propertyValueOrDefault28;
				}
				string propertyValueOrDefault29 = GetPropertyValueOrDefault(product, "MarkaStaliAdapter");
				if (string.IsNullOrEmpty(propertyValueOrDefault29))
				{
					array[32]++;
				}
				else
				{
					myExcelWorkSheet.Cells[num, "AG"] = propertyValueOrDefault29;
				}
			}
			else
			{
				array[29]++;
				array[30]++;
				array[31]++;
				array[32]++;
			}
			string text = GetPropertyValueOrDefault(product, "MarkaStali");
			string propertyValueOrDefault30 = GetPropertyValueOrDefault(product, "AisiType");
			if (text == "")
			{
				array[33]++;
			}
			else
			{
				switch (text)
				{
				case "Оцинковка":
					text = "оц";
					break;
				case "Чорна":
					text = "ст";
					break;
				case "Нержавійка":
					text = (string.IsNullOrEmpty(propertyValueOrDefault30) ? "нерж" : ("AISI " + propertyValueOrDefault30));
					break;
				}
				myExcelWorkSheet.Cells[num, "AH"] = text;
			}
			string propertyValueOrDefault31 = GetPropertyValueOrDefault(product, "ThicknessOfMetal");
			double num3 = ((propertyValueOrDefault31 == "") ? 0.0 : Convert.ToDouble(propertyValueOrDefault31));
			if (num3 > 0.0)
			{
				myExcelWorkSheet.Cells[num, "AH"] = text + ", " + num3;
			}
			try
			{
				string vidbortovka = product.GetType()?.GetProperty("Vidbortovka")?.GetValue(product)?.ToString();
				string typeOfProduct = GetTypeOfProduct(product, vidbortovka, prymitka);
				if (typeOfProduct == "")
				{
					array[34]++;
				}
				else
				{
					myExcelWorkSheet.Cells[num, "AI"] = typeOfProduct;
				}
			}
			catch
			{
			}
			bool flag = true;
			myExcelWorkSheet.Cells[num, "AJ"] = product.Price;
			bool flag2 = false;
			myExcelWorkSheet.Cells[num, "AL"] = product.MaterialCost;
			if (string.IsNullOrWhiteSpace(product.Square) || Convert.ToDouble(product.Square) == 0.0)
			{
				array[38]++;
			}
			else
			{
				myExcelWorkSheet.Cells[num, "AM"] = product.Square;
			}
			string propertyValueOrDefault32 = GetPropertyValueOrDefault(product, "SquareZhyrFiltr");
			if (string.IsNullOrWhiteSpace(propertyValueOrDefault32) || Convert.ToDouble(propertyValueOrDefault32) == 0.0)
			{
				array[39]++;
			}
			else
			{
				myExcelWorkSheet.Cells[num, "AN"] = propertyValueOrDefault32;
			}
			bool flag3 = false;
			double? zarplata = GetZarplata(product);
			if (zarplata.HasValue)
			{
				myExcelWorkSheet.Cells[num, "AO"] = zarplata.Value;
			}
			else
			{
				array[40]++;
			}
			num++;
		}
		((_Worksheet)myExcelWorkSheet).get_Range((object)string.Format("{0}{1}:{2}{3}", "A", 9, "AO", num - 1), Type.Missing).Cells.Borders.LineStyle = XlLineStyle.xlContinuous;
		((_Worksheet)myExcelWorkSheet).get_Range((object)string.Format("{0}{1}:{2}{3}", "A", num, "AO", 308), Type.Missing).ClearContents();
		myExcelWorkSheet = (Worksheet)(dynamic)myExcelWorkbook.Worksheets[1];
		for (int num4 = 40; num4 >= 0; num4--)
		{
			if (array[num4] == num - 9)
			{
				((dynamic)myExcelWorkSheet.Columns[num4 + 1, Type.Missing]).Delete();
			}
		}
		myExcelWorkSheet.Cells[1, "E"] = "ПЛН 08";
		((dynamic)myExcelWorkSheet.Cells[1, "E"]).Font.Bold = true;
	}

	public static double? GetZarplata(IProduct item)
	{
		if (item is IHasZarplata hasZarplata)
		{
			return hasZarplata.Zarplata;
		}
		return null;
	}

	public void MakeCommercialOffer(IEnumerable<IProduct> products)
	{
		if (products == null)
		{
			return;
		}
		myExcelWorkSheet.Cells[13, "B"] = DateTime.Now.Date;
		int num = 16;
		int num2 = 1;
		foreach (IProduct product in products)
		{
			myExcelWorkSheet.Cells[num, "B"] = num2++;
			myExcelWorkSheet.Cells[num, "C"] = product.Name;
			myExcelWorkSheet.Cells[num, "D"] = product.Amount;
			myExcelWorkSheet.Cells[num, "G"] = product.Price;
			if (double.TryParse(product.Square, out var result) && result != 0.0)
			{
				myExcelWorkSheet.Cells[num, "E"] = result;
			}
			if (product.TovchynaMetalu != 0.0)
			{
				myExcelWorkSheet.Cells[num, "F"] = product.TovchynaMetalu;
			}
			num++;
		}
		((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{16}:H{num - 1}", Type.Missing).Cells.Borders.LineStyle = XlLineStyle.xlContinuous;
		((_Worksheet)myExcelWorkSheet).get_Range((object)$"A{num}:H{316}", Type.Missing).Delete(XlDeleteShiftDirection.xlShiftUp);
		myExcelWorkSheet = (Worksheet)(dynamic)myExcelWorkbook.Worksheets[2];
		((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{num}:G{316}", Type.Missing).Delete(XlDeleteShiftDirection.xlShiftUp);
		myExcelWorkSheet = (Worksheet)(dynamic)myExcelWorkbook.Worksheets[1];
		for (int num3 = num + 8; num3 >= num + 3; num3--)
		{
		}
	}

	public void MakeVolume(IEnumerable<IProduct> products)
	{
		if (products == null)
		{
			return;
		}
		myExcelWorkSheet.Name = "об'єм 1";
		int num = 16;
		int num2 = 1;
		foreach (IProduct product in products)
		{
			myExcelWorkSheet.Cells[num, "B"] = num2++;
			myExcelWorkSheet.Cells[num, "C"] = product.Name;
			myExcelWorkSheet.Cells[num, "D"] = product.Amount;
			myExcelWorkSheet.Cells[num, "E"] = product.Volume;
			num++;
		}
		((_Worksheet)myExcelWorkSheet).get_Range((object)$"B{16}:E{num - 1}", Type.Missing).Cells.Borders.LineStyle = XlLineStyle.xlContinuous;
		((_Worksheet)myExcelWorkSheet).get_Range((object)$"A{num}:F{316}", Type.Missing).Delete(XlDeleteShiftDirection.xlShiftUp);
	}

	public void MakeFor1C(IEnumerable<IProduct> products, string folderName)
	{
		//IL_0927: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3b: Unknown result type (might be due to invalid IL or missing references)
		List<Material> list = new List<Material>();
		int num = 1;
		string text = CreateFolderByPath(folderName);
		if (string.IsNullOrWhiteSpace(text))
		{
			return;
		}
		text += "\\";
		foreach (IProduct product in products)
		{
			int num2 = product.Name.IndexOf(" ");
			string text2 = ((num2 != -1) ? product.Name.Substring(0, num2) : "NoName");
			string text3 = Convert.ToString(num) + "_" + folderName + "_" + text2 + ".xlsx";
			try
			{
				OpenExcel();
				myExcelWorkSheet.Cells[1, 1] = "Артикул";
				myExcelWorkSheet.Cells[1, 2] = "Кількість 1";
				myExcelWorkSheet.Cells[1, 3] = "Одиниця виміру 1";
				myExcelWorkSheet.Cells[1, 4] = "Кількість 2";
				myExcelWorkSheet.Cells[1, 5] = "Одиниця виміру 2";
				myExcelWorkSheet.Cells[1, 6] = "Назва матеріалу";
				GetMaterialNamesAndArgiments(product);
				int num3 = 2;
				int num4 = 2;
				if (product.Section != "Нестандартний виріб")
				{
					if (spysannyaMaterialNames.Length == 1)
					{
						CustomConst customConstByName = Consts2.GetCustomConstByName(spysannyaMaterialNames[0]);
						myExcelWorkSheet.Cells[num3, 1] = customConstByName.Code2;
						myExcelWorkSheet.Cells[num3, 6] = customConstByName.MaterialName1C;
						if (spysannyaMaterialArgumentsOne[4] > 0.0)
						{
							myExcelWorkSheet.Cells[num3, num4] = ((spysannyaMaterialArgumentsOne[4] < 0.005) ? Math.Round(spysannyaMaterialArgumentsOne[4], 3) : Math.Round(spysannyaMaterialArgumentsOne[4], 2));
							myExcelWorkSheet.Cells[num3, num4 + 1] = customConstByName.OdVym1;
							num4 += 2;
						}
						if (spysannyaMaterialArgumentsOne[5] > 0.0)
						{
							if (num4 == 2)
							{
								myExcelWorkSheet.Cells[num3, num4] = ((spysannyaMaterialArgumentsOne[5] < 0.005) ? Math.Round(spysannyaMaterialArgumentsOne[5], 3) : Math.Round(spysannyaMaterialArgumentsOne[5], 2));
								myExcelWorkSheet.Cells[num3, num4 + 1] = customConstByName.OdVym1;
							}
							else if (customConstByName.OdVym2 != "")
							{
								myExcelWorkSheet.Cells[num3, num4] = ((spysannyaMaterialArgumentsOne[5] < 0.005) ? Math.Round(spysannyaMaterialArgumentsOne[5], 3) : Math.Round(spysannyaMaterialArgumentsOne[5], 2));
								myExcelWorkSheet.Cells[num3, num4 + 1] = customConstByName.OdVym2;
							}
						}
						double[] array = SubArray(spysannyaMaterialArgumentsOne, 2, 4);
						if (list.Exists((Material m) => m.Name == spysannyaMaterialNames[0]))
						{
							Material material = Enumerable.FirstOrDefault<Material>(Enumerable.Where<Material>((IEnumerable<Material>)list, (Func<Material, bool>)((Material m) => m.Name == spysannyaMaterialNames[0])));
							for (int j = 0; j < array.Length; j++)
							{
								material.Values[j] += array[j];
							}
							material.Amount++;
						}
						else
						{
							list.Add(new Material(spysannyaMaterialNames[0], array));
						}
					}
					else
					{
						for (int k = 0; k < spysannyaMaterialNames.Length; k++)
						{
							if (!(spysannyaMaterialNames[k] != ""))
							{
								continue;
							}
							CustomConst customConstByName2 = Consts2.GetCustomConstByName(spysannyaMaterialNames[k]);
							myExcelWorkSheet.Cells[num3, 1] = ((customConstByName2 != null) ? customConstByName2.Code2 : Consts2.nonExistentMaterial.Code2);
							myExcelWorkSheet.Cells[num3, 6] = ((customConstByName2 != null) ? customConstByName2.MaterialName1C : Consts2.nonExistentMaterial.MaterialName1C);
							num4 = 2;
							if (spysannyaMaterialArgumentsTwo[k, 4] > 0.0)
							{
								myExcelWorkSheet.Cells[num3, num4] = ((spysannyaMaterialArgumentsTwo[k, 4] < 0.005) ? Math.Round(spysannyaMaterialArgumentsTwo[k, 4], 3) : Math.Round(spysannyaMaterialArgumentsTwo[k, 4], 2));
								myExcelWorkSheet.Cells[num3, num4 + 1] = ((customConstByName2 != null) ? customConstByName2.OdVym1 : Consts2.nonExistentMaterial.OdVym1);
								num4 += 2;
							}
							if (spysannyaMaterialArgumentsTwo[k, 5] > 0.0)
							{
								if (num4 == 2)
								{
									myExcelWorkSheet.Cells[num3, num4] = ((spysannyaMaterialArgumentsTwo[k, 5] < 0.005) ? Math.Round(spysannyaMaterialArgumentsTwo[k, 5], 3) : Math.Round(spysannyaMaterialArgumentsTwo[k, 5], 2));
									myExcelWorkSheet.Cells[num3, num4 + 1] = ((customConstByName2 != null) ? customConstByName2.OdVym1 : Consts2.nonExistentMaterial.OdVym1);
								}
								else if (customConstByName2.OdVym2 != "")
								{
									myExcelWorkSheet.Cells[num3, num4] = ((spysannyaMaterialArgumentsTwo[k, 5] < 0.005) ? Math.Round(spysannyaMaterialArgumentsTwo[k, 5], 3) : Math.Round(spysannyaMaterialArgumentsTwo[k, 5], 2));
									myExcelWorkSheet.Cells[num3, num4 + 1] = ((customConstByName2 != null) ? customConstByName2.OdVym2 : Consts2.nonExistentMaterial.OdVym2);
								}
							}
							num3++;
						}
					}
					int i;
					for (i = 0; i < spysannyaMaterialNames.Length; i++)
					{
						if (!(spysannyaMaterialNames[i] != ""))
						{
							continue;
						}
						double[] data = ((spysannyaMaterialArgumentsTwo != null) ? GetOneDimentialArr(spysannyaMaterialArgumentsTwo, i) : spysannyaMaterialArgumentsOne);
						double[] array2 = SubArray(data, 2, 4);
						if (list.Exists((Material m) => m.Name == spysannyaMaterialNames[i]))
						{
							Material material2 = Enumerable.FirstOrDefault<Material>(Enumerable.Where<Material>((IEnumerable<Material>)list, (Func<Material, bool>)((Material m) => m.Name == spysannyaMaterialNames[i])));
							for (int l = 0; l < array2.Length; l++)
							{
								material2.Values[l] += array2[l];
							}
							material2.Amount++;
						}
						else
						{
							list.Add(new Material(spysannyaMaterialNames[i], array2));
						}
					}
				}
				SaveExcel(folderName, "xlsx", text + text3);
			}
			catch
			{
				MessageBox.Show("Сталася помилка під час роботи з ексель файлом.");
			}
			finally
			{
				CloseExcelApplication();
			}
			num++;
		}
		string text4 = folderName + "_Замовлення.xlsx";
		try
		{
			OpenExcel();
			myExcelWorkSheet.Cells[1, 1] = "Артикул";
			myExcelWorkSheet.Cells[1, 2] = "Кількість 1";
			myExcelWorkSheet.Cells[1, 3] = "Одиниця виміру 1";
			myExcelWorkSheet.Cells[1, 4] = "Кількість 2";
			myExcelWorkSheet.Cells[1, 5] = "Одиниця виміру 2";
			myExcelWorkSheet.Cells[1, 6] = "Назва матеріалу";
			int num5 = 2;
			foreach (Material item in list)
			{
				int num6 = 2;
				CustomConst customConstByName3 = Consts2.GetCustomConstByName(item.Name);
				myExcelWorkSheet.Cells[num5, 1] = ((customConstByName3 != null) ? customConstByName3.Code2 : Consts2.nonExistentMaterial.Code2);
				myExcelWorkSheet.Cells[num5, 6] = ((customConstByName3 != null) ? customConstByName3.MaterialName1C : Consts2.nonExistentMaterial.MaterialName1C);
				if (item.Values[2] > 0.0)
				{
					myExcelWorkSheet.Cells[num5, num6] = ((item.Values[2] < 0.005) ? Math.Round(item.Values[2], 3) : Math.Round(item.Values[2], 2));
					myExcelWorkSheet.Cells[num5, num6 + 1] = ((customConstByName3 != null) ? customConstByName3.OdVym1 : Consts2.nonExistentMaterial.OdVym1);
					num6 += 2;
				}
				if (item.Values[3] > 0.0)
				{
					if (num6 == 2)
					{
						myExcelWorkSheet.Cells[num5, num6] = ((item.Values[3] < 0.005) ? Math.Round(item.Values[3], 3) : Math.Round(item.Values[3], 2));
						myExcelWorkSheet.Cells[num5, num6 + 1] = ((customConstByName3 != null) ? customConstByName3.OdVym1 : Consts2.nonExistentMaterial.OdVym1);
					}
					else if (customConstByName3.OdVym2 != "")
					{
						myExcelWorkSheet.Cells[num5, num6] = ((item.Values[3] < 0.005) ? Math.Round(item.Values[3], 3) : Math.Round(item.Values[3], 2));
						myExcelWorkSheet.Cells[num5, num6 + 1] = ((customConstByName3 != null) ? customConstByName3.OdVym2 : Consts2.nonExistentMaterial.OdVym2);
					}
				}
				num5++;
			}
			SaveExcel(text4, "xlsx", text + text4);
		}
		catch
		{
			MessageBox.Show("Сталася помилка під час роботи з ексель файлом.");
		}
		finally
		{
			CloseExcelApplication();
		}
		if (text.Contains(folderName + "\\" + folderName))
		{
			ReplaceFiles(text, folderName);
		}
	}

	public void FillPrice()
	{
		Worksheet worksheet = (dynamic)myExcelWorkbook.Worksheets["1 м.кв."];
		worksheet.Cells[11, "D"] = 287.5;
		worksheet.Cells[11, "F"] = 322.0;
		worksheet.Cells[11, "H"] = 345.0;
		worksheet.Cells[11, "J"] = 402.5;
		worksheet.Cells[11, "L"] = 152.84;
		worksheet.Cells[11, "N"] = 193.2;
		worksheet.Cells[12, "D"] = 333.5;
		worksheet.Cells[12, "F"] = 377.0;
		worksheet.Cells[12, "H"] = 406.0;
		worksheet.Cells[12, "J"] = 464.0;
		worksheet.Cells[12, "L"] = " - ";
		worksheet.Cells[12, "N"] = 261.05;
		worksheet.Cells[13, "D"] = 400.0;
		worksheet.Cells[13, "F"] = 480.0;
		worksheet.Cells[13, "H"] = 520.0;
		worksheet.Cells[13, "J"] = 600.0;
		worksheet.Cells[13, "L"] = " - ";
		worksheet.Cells[13, "N"] = 327.75;
		Worksheet worksheet2 = (dynamic)myExcelWorkbook.Worksheets["К_обладнання"];
		int num = 9;
		double[,] array = KlapanDroselnyjKDK.FormPriceKlapanDroselnyjKDK();
		double[] array2 = new double[17];
		double[] array3 = new double[17];
		double[,] priceKlapanDroselnyjKDZK = KlapanDroselnyjKDK.priceKlapanDroselnyjKDZK;
		double[] array4 = new double[11];
		double[] array5 = new double[11];
		for (int i = 0; i < 17; i++)
		{
			array2[i] = array[i, 0];
			array3[i] = array[i, 1];
		}
		for (int j = 0; j < 11; j++)
		{
			array4[j] = priceKlapanDroselnyjKDZK[j, 0];
			array5[j] = priceKlapanDroselnyjKDZK[j, 1];
		}
		int num2 = num;
		int num3 = 0;
		while (num3 < 17)
		{
			worksheet2.Cells[num2, "F"] = Math.Round(array2[num3], 2);
			worksheet2.Cells[num2, "G"] = Math.Round(array3[num3], 2);
			num3++;
			num2++;
		}
		num2 = num;
		int num4 = 0;
		while (num4 < 11)
		{
			worksheet2.Cells[num2, "H"] = Math.Round(array4[num4], 2);
			worksheet2.Cells[num2, "I"] = Math.Round(array5[num4], 2);
			num4++;
			num2++;
		}
		double[,] array6 = HnuchkaVstavkaVHK.FormPriceHnuchkaVstavkaVHK();
		double[] array7 = new double[24];
		double[] array8 = new double[24];
		for (int k = 0; k < 24; k++)
		{
			array7[k] = array6[k, 0];
			array8[k] = array6[k, 1];
		}
		num2 = num;
		int num5 = 0;
		while (num5 < array7.Length)
		{
			worksheet2.Cells[num2, "N"] = Math.Round(array7[num5], 2);
			worksheet2.Cells[num2, "O"] = Math.Round(array8[num5], 2);
			num5++;
			num2++;
		}
		num2 = num;
		double[] priceShumopohlynachSHK = ShumopohlynachSHK.priceShumopohlynachSHK600;
		double[] array9 = ShumopohlynachSHK.FormPriceShumopohlynachSHK();
		int num6 = 0;
		while (num6 < priceShumopohlynachSHK.Length)
		{
			worksheet2.Cells[num2, "B"] = Math.Round(priceShumopohlynachSHK[num6], 2);
			num6++;
			num2++;
		}
		num2 = num;
		int num7 = 0;
		while (num7 < array9.Length)
		{
			worksheet2.Cells[num2, "C"] = Math.Round(array9[num7], 2);
			num7++;
			num2++;
		}
		num2 = num;
		double[] array10 = FiltrFK.FormPriceFiltrFK();
		int num8 = 0;
		while (num8 < array10.Length)
		{
			worksheet2.Cells[num2, "K"] = Math.Round(array10[num8], 2);
			num8++;
			num2++;
		}
		num2 = num;
		double[] array11 = DeflektorDK.FormPriceDeflektorDK();
		int num9 = 0;
		while (num9 < array11.Length)
		{
			worksheet2.Cells[num2, "L"] = Math.Round(array11[num9], 2);
			num9++;
			num2++;
		}
		Worksheet worksheet3 = (dynamic)myExcelWorkbook.Worksheets["ПК"];
		num = 10;
		double[] array12 = RoundAirPK.FormPriceRoundAirFlowPK();
		double[] array13 = RoundAirPSK.FormPricePovitroprovidPSK();
		double[] array14 = NipelNZK.FormPriceNipelNZK();
		double[] array15 = NipelNVK.FormPriceNipelNVK();
		double[] array16 = FlanetsKruglyj.FormPriceFlanetsKruglyj();
		double[] array17 = VidvidVK90.FormPriceVidvidVK();
		double[,] array18 = VidvidVK60_45_30_15.FormPriceVidvidVK60_45_30_15();
		double[] array19 = HomutAspiratsijnyj.FormPriceHomutAspiratsijnyj();
		num2 = num;
		int num10 = 0;
		while (num10 < array12.Length)
		{
			worksheet3.Cells[num2, "D"] = Math.Round(array12[num10], 2);
			worksheet3.Cells[num2, "C"] = Math.Round(array13[num10], 2);
			worksheet3.Cells[num2, "E"] = Math.Round(array14[num10], 2);
			worksheet3.Cells[num2, "F"] = Math.Round(array15[num10], 2);
			worksheet3.Cells[num2, "G"] = Math.Round(array16[num10], 2);
			worksheet3.Cells[num2, "H"] = Math.Round(array17[num10], 2);
			worksheet3.Cells[num2, "M"] = Math.Round(array19[num10], 2);
			worksheet3.Cells[num2, "I"] = Math.Round(array18[num10, 0], 2);
			worksheet3.Cells[num2, "J"] = Math.Round(array18[num10, 1], 2);
			worksheet3.Cells[num2, "K"] = Math.Round(array18[num10, 2], 2);
			worksheet3.Cells[num2, "L"] = Math.Round(array18[num10, 3], 2);
			num10++;
			num2++;
		}
		Worksheet worksheet4 = (dynamic)myExcelWorkbook.Worksheets["П_обладнання"];
		num = 11;
		double[] array20 = HnuchkaVstavkaVHP.FormPriceHnuchkaVstavkaVHP();
		double[] array21 = KlapanDroselnyjKDP.FormPriceKlapanDroselnyjKDP();
		double[] array22 = KlapanGaluzijnjyKGP.FormPriceKlapanGaluzijnjyKGP();
		double[] array23 = FiltrFP.FormPriceFiltrFP();
		num2 = num;
		int num11 = 0;
		while (num11 < array20.Length)
		{
			worksheet4.Cells[num2, "F"] = Math.Round(array20[num11], 2);
			num11++;
			num2++;
		}
		num2 = num;
		int num12 = 0;
		while (num12 < array21.Length)
		{
			worksheet4.Cells[num2, "E"] = Math.Round(array21[num12], 2);
			num12++;
			num2++;
		}
		num2 = num;
		int num13 = 0;
		while (num13 < array22.Length)
		{
			worksheet4.Cells[num2, "C"] = Math.Round(array22[num13], 2);
			num13++;
			num2++;
		}
		num2 = num;
		int num14 = 0;
		while (num14 < array23.Length)
		{
			worksheet4.Cells[num2, "G"] = Math.Round(array23[num14], 2);
			num14++;
			num2++;
		}
		Worksheet worksheet5 = (dynamic)myExcelWorkbook.Worksheets["Протипожежні"];
		string[] array24 = new string[14]
		{
			"E", "F", "G", "H", "I", "J", "K", "L", "M", "N",
			"O", "P", "Q", "R"
		};
		double[] array25 = KlapanProtypogegnyjKPkEIS60.FormPriceKlapanProtypogegnyjKPkEIS60();
		double[] array26 = KlapanProtypogegnyjKPkEIS60e.FormPriceKlapanProtypogegnyjKPkEIS60e();
		double[] array27 = KlapanProtypogegnyjKPkM.FormPriceKlapanProtypogegnyjKPkM();
		double[] array28 = KlapanProtypogegnyjKPkС.FormPriceKlapanProtypogegnyjKPkC();
		for (int l = 0; l < array24.Length; l++)
		{
			worksheet5.Cells[68, array24[l]] = Math.Round(array25[l], 2);
			worksheet5.Cells[69, array24[l]] = Math.Round(array26[l], 2);
			worksheet5.Cells[113, array24[l]] = Math.Round(array27[l], 2);
			worksheet5.Cells[134, array24[l]] = Math.Round(array28[l], 2);
		}
		string[] array29 = new string[13]
		{
			"E", "F", "G", "H", "I", "J", "K", "L", "M", "N",
			"O", "P", "Q"
		};
		double[,] array30 = KlapanProtypogegnyjKPpEIS60m.FormPriceKlapanProtypogegnyjKPpEIS60m();
		double[,] array31 = KlapanProtypogegnyjKPpM.FormPriceKlapanProtypogegnyjKPpM();
		double[,] array32 = KlapanProtypogegnyjKPpS.FormPriceKlapanProtypogegnyjKPpS();
		int num15 = 12;
		int num16 = 155;
		int num17 = 177;
		int num18 = 0;
		while (num18 < 7)
		{
			for (int m = 0; m < array29.Length; m++)
			{
				if (array30[num18, m] != 0.0)
				{
					worksheet5.Cells[num15, array29[m]] = Math.Round(array30[num18, m], 2);
				}
				if (array31[num18, m] != 0.0)
				{
					worksheet5.Cells[num16, array29[m]] = Math.Round(array31[num18, m], 2);
				}
				if (array32[num18, m] != 0.0)
				{
					worksheet5.Cells[num17, array29[m]] = Math.Round(array32[num18, m], 2);
				}
			}
			num18++;
			num15++;
			num16++;
			num17++;
		}
		Worksheet worksheet6 = (dynamic)myExcelWorkbook.Worksheets["Циклони"];
		int num19 = 5;
		double[] array33 = TsyklonTS.FormPriceTsyklonTS();
		int num20 = 0;
		while (num20 < array33.Length)
		{
			worksheet6.Cells[num19, "F"] = Math.Round(array33[num20], 2);
			num20++;
			num19++;
		}
		int num21 = 54;
		int num22 = 73;
		int num23 = 14;
		double[,] array34 = TsyklonTSN15.FormPriceTsyklonTSN15();
		int num24 = 0;
		while (num24 < num23)
		{
			worksheet6.Cells[num21, "D"] = Math.Round(array34[num24, 0], 2);
			worksheet6.Cells[num22, "D"] = Math.Round(array34[num24, 1], 2);
			num24++;
			num21++;
			num22++;
		}
	}

	public string SaveExcel(string fileName = "Excel document", string extension = "xlsx", string filePathForSaving = null)
	{
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (filePathForSaving == null)
			{
				filePathForSaving = GetFilePathForSaving(fileName, extension);
			}
			if (!string.IsNullOrWhiteSpace(filePathForSaving))
			{
				filePathForSaving = ReplaceInvalidFileNameCharacters(filePathForSaving);
				myExcelWorkbook.SaveAs(filePathForSaving, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
				if (myExcelWorkbook != null)
				{
					using (new FileStream(ExcelFilePath, FileMode.Open))
					{
						myExcelWorkbook.Close(true, ExcelFilePath, Missing.Value);
					}
				}
			}
		}
		catch
		{
			MessageBox.Show("Некоректна назва файлу або такий файл відкритий в іншій програмі. Збережіть під іншою назвою! \nПроблема під час збереження файлу: " + filePathForSaving);
		}
		finally
		{
			CloseExcelApplication();
		}
		return filePathForSaving;
	}

	public void CloseExcelApplication()
	{
		if (myExcelApplication == null)
		{
			return;
		}
		myExcelApplication.Workbooks.Close();
		myExcelApplication.Quit();
		myExcelApplication = null;
		if (excelProcess != null)
		{
			try
			{
				excelProcess.Kill();
			}
			catch
			{
			}
		}
	}

	public void MakeFor1C(IEnumerable<IProduct> products, string folderName, string additionalPercent1CString, string defaultFolderPath = null)
	{
		List<Material> list = new List<Material>();
		double result;
		bool flag = double.TryParse(additionalPercent1CString, out result);
		result = ((result < 0.0) ? 0.0 : (result / 100.0));
		int num = 1;
		string text = CreateFolderByPath(folderName, defaultFolderPath);
		if (string.IsNullOrWhiteSpace(text))
		{
			return;
		}
		text += "\\";
		foreach (IProduct product in products)
		{
			string text2 = Convert.ToString(num) + "_" + folderName + "_" + product.Name + ".xlsx";
			OpenExcel();
			myExcelWorkSheet.Cells[1, 1] = "Артикул";
			myExcelWorkSheet.Cells[1, 2] = "Кількість 1";
			myExcelWorkSheet.Cells[1, 3] = "Одиниця виміру 1";
			myExcelWorkSheet.Cells[1, 4] = "Кількість 2";
			GetMaterialNamesAndArgiments(product);
			int num2 = 2;
			int num3 = 2;
			if (spysannyaMaterialNames.Length == 1)
			{
				CustomConst customConstByName = Consts2.GetCustomConstByName(spysannyaMaterialNames[0]);
				myExcelWorkSheet.Cells[num2, 1] = customConstByName.Code2;
				double[] array = spysannyaMaterialArgumentsOne;
				if (array[1] > 0.0)
				{
					double productAdditionalPercent1C = ProductHelper.GetProductAdditionalPercent1C(product, result);
					double num4 = (1.0 + array[1] + productAdditionalPercent1C) / (1.0 + array[1]);
					array[0] *= num4;
					array[4] *= num4;
					array[5] *= num4;
					array[2] = array[4] * array[1];
					array[3] = array[5] * array[1];
					array[1] += productAdditionalPercent1C;
				}
				if (array[4] > 0.0)
				{
					myExcelWorkSheet.Cells[num2, num3] = ((array[4] < 0.005) ? Math.Round(array[4], 3) : Math.Round(array[4], 2));
					myExcelWorkSheet.Cells[num2, num3 + 1] = customConstByName.OdVym1;
					num3 += 2;
				}
				if (array[5] > 0.0)
				{
					if (num3 == 2)
					{
						myExcelWorkSheet.Cells[num2, num3] = ((array[5] < 0.005) ? Math.Round(array[5], 3) : Math.Round(array[5], 2));
						myExcelWorkSheet.Cells[num2, num3 + 1] = customConstByName.OdVym1;
					}
					else if (customConstByName.OdVym2 != "")
					{
						myExcelWorkSheet.Cells[num2, num3] = ((array[5] < 0.005) ? Math.Round(array[5], 3) : Math.Round(array[5], 2));
						myExcelWorkSheet.Cells[num2, num3 + 1] = customConstByName.OdVym2;
					}
				}
				double[] array2 = SubArray(array, 2, 4);
				if (list.Exists((Material m) => m.Name == spysannyaMaterialNames[0]))
				{
					Material material = Enumerable.FirstOrDefault<Material>(Enumerable.Where<Material>((IEnumerable<Material>)list, (Func<Material, bool>)((Material m) => m.Name == spysannyaMaterialNames[0])));
					for (int j = 0; j < array2.Length; j++)
					{
						material.Values[j] += array2[j];
					}
					material.Amount++;
				}
				else
				{
					list.Add(new Material(spysannyaMaterialNames[0], array2));
				}
			}
			else
			{
				double[,] array3 = spysannyaMaterialArgumentsTwo;
				for (int k = 0; k < spysannyaMaterialNames.Length; k++)
				{
					if (!(spysannyaMaterialNames[k] != ""))
					{
						continue;
					}
					if (array3[k, 1] > 0.0)
					{
						double productAdditionalPercent1C2 = ProductHelper.GetProductAdditionalPercent1C(product, result);
						double num5 = (1.0 + array3[k, 1] + productAdditionalPercent1C2) / (1.0 + array3[k, 1]);
						array3[k, 0] *= num5;
						array3[k, 4] *= num5;
						array3[k, 5] *= num5;
						array3[k, 2] = array3[k, 4] * array3[k, 1];
						array3[k, 3] = array3[k, 5] * array3[k, 1];
						array3[k, 1] += productAdditionalPercent1C2;
					}
					CustomConst customConstByName2 = Consts2.GetCustomConstByName(spysannyaMaterialNames[k]);
					myExcelWorkSheet.Cells[num2, 1] = customConstByName2.Code2;
					num3 = 2;
					if (array3[k, 4] > 0.0)
					{
						myExcelWorkSheet.Cells[num2, num3] = ((array3[k, 4] < 0.005) ? Math.Round(array3[k, 4], 3) : Math.Round(array3[k, 4], 2));
						myExcelWorkSheet.Cells[num2, num3 + 1] = customConstByName2.OdVym1;
						num3 += 2;
					}
					if (array3[k, 5] > 0.0)
					{
						if (num3 == 2)
						{
							myExcelWorkSheet.Cells[num2, num3] = ((array3[k, 5] < 0.005) ? Math.Round(array3[k, 5], 3) : Math.Round(array3[k, 5], 2));
							myExcelWorkSheet.Cells[num2, num3 + 1] = customConstByName2.OdVym1;
						}
						else if (customConstByName2.OdVym2 != "")
						{
							myExcelWorkSheet.Cells[num2, num3] = ((array3[k, 5] < 0.005) ? Math.Round(array3[k, 5], 3) : Math.Round(array3[k, 5], 2));
							myExcelWorkSheet.Cells[num2, num3 + 1] = customConstByName2.OdVym2;
						}
					}
					num2++;
				}
				int i;
				for (i = 0; i < spysannyaMaterialNames.Length; i++)
				{
					if (!(spysannyaMaterialNames[i] != ""))
					{
						continue;
					}
					double[] data = ((spysannyaMaterialArgumentsTwo != null) ? GetOneDimentialArr(spysannyaMaterialArgumentsTwo, i) : spysannyaMaterialArgumentsOne);
					double[] array4 = SubArray(data, 2, 4);
					if (list.Exists((Material m) => m.Name == spysannyaMaterialNames[i]))
					{
						Material material2 = Enumerable.FirstOrDefault<Material>(Enumerable.Where<Material>((IEnumerable<Material>)list, (Func<Material, bool>)((Material m) => m.Name == spysannyaMaterialNames[i])));
						for (int l = 0; l < array4.Length; l++)
						{
							material2.Values[l] += array4[l];
						}
						material2.Amount++;
					}
					else
					{
						list.Add(new Material(spysannyaMaterialNames[i], array4));
					}
				}
			}
			SaveExcel(folderName, "xlsx", text + text2);
			num++;
		}
		string text3 = folderName + "_Замовлення.xlsx";
		OpenExcel();
		myExcelWorkSheet.Cells[1, 1] = "Артикул";
		myExcelWorkSheet.Cells[1, 2] = "Кількість 1";
		myExcelWorkSheet.Cells[1, 3] = "Одиниця виміру 1";
		myExcelWorkSheet.Cells[1, 4] = "Кількість 2";
		myExcelWorkSheet.Cells[1, 5] = "Одиниця виміру 2";
		int num6 = 2;
		foreach (Material item in list)
		{
			int num7 = 2;
			CustomConst customConstByName3 = Consts2.GetCustomConstByName(item.Name);
			myExcelWorkSheet.Cells[num6, 1] = customConstByName3.Code2;
			if (item.Values[2] > 0.0)
			{
				myExcelWorkSheet.Cells[num6, num7] = ((item.Values[2] < 0.005) ? Math.Round(item.Values[2], 3) : Math.Round(item.Values[2], 2));
				myExcelWorkSheet.Cells[num6, num7 + 1] = customConstByName3.OdVym1;
				num7 += 2;
			}
			if (item.Values[3] > 0.0)
			{
				if (num7 == 2)
				{
					myExcelWorkSheet.Cells[num6, num7] = ((item.Values[3] < 0.005) ? Math.Round(item.Values[3], 3) : Math.Round(item.Values[3], 2));
					myExcelWorkSheet.Cells[num6, num7 + 1] = customConstByName3.OdVym1;
				}
				else if (customConstByName3.OdVym2 != "")
				{
					myExcelWorkSheet.Cells[num6, num7] = ((item.Values[3] < 0.005) ? Math.Round(item.Values[3], 3) : Math.Round(item.Values[3], 2));
					myExcelWorkSheet.Cells[num6, num7 + 1] = customConstByName3.OdVym2;
				}
			}
			num6++;
		}
		SaveExcel(text3, "xlsx", text + text3);
		if (text.Contains(folderName + "\\" + folderName))
		{
			ReplaceFiles(text, folderName);
		}
	}

	public string GetFilePathForSaving(string fileName, string extension)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		string result = "";
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).FileName = fileName;
		((FileDialog)val).Filter = "Excel Files|*." + extension;
		if (((CommonDialog)val).ShowDialog() == true)
		{
			result = ((FileDialog)val).FileName;
		}
		return result;
	}

	private void GetMaterialNamesAndArgiments(IProduct product)
	{
		string name = product.GetType().Name;
		string text = name;
		if (text == null)
		{
			return;
		}
		switch (text.Length)
		{
		case 16:
			switch (text[14])
			{
			case 'V':
				switch (text)
				{
				case "Product_NipelNVK":
					if (product is Product_NipelNVK product_NipelNVK)
					{
						spysannyaMaterialArgumentsOne = NipelNVK.MaterialNipelNVK(markaStali: product_NipelNVK.MarkaStali switch
						{
							"Оцинковка" => 1, 
							"Чорна" => 2, 
							"Нержавійка" => 3, 
							_ => 0, 
						}, D: product_NipelNVK.D, tovchynaMetalu: Convert.ToDouble(product_NipelNVK.ThicknessOfMetal), number: product_NipelNVK.Amount, aisiType: product_NipelNVK.AisiType);
						spysannyaMaterialNames = NipelNVK.materialName;
					}
					break;
				case "Product_VidvidVK":
					if (product is Product_VidvidVK product_VidvidVK)
					{
						int markaStali19 = product_VidvidVK.MarkaStali switch
						{
							"Оцинковка" => 1, 
							"Чорна" => 2, 
							"Нержавійка" => 3, 
							_ => 0, 
						};
						int typVK = product_VidvidVK.Type switch
						{
							"мінус - мінус" => 1, 
							"чисто - зуби" => 2, 
							"чисто - чисто" => 3, 
							"чисто - мінус" => 4, 
							"фланець - чисто" => 5, 
							"фланець - фланець" => 6, 
							"чисто - розтяжка" => 7, 
							"мінус - сітка" => 8, 
							"чисто - сітка" => 9, 
							"фланець - сітка" => 10, 
							_ => 0, 
						};
						int typProfil8 = product_VidvidVK.ProfileType switch
						{
							"Лист Ст 3 3мм" => 1, 
							"Полоса 30х4" => 2, 
							"Кутник 25х25х3" => 3, 
							"Кутник 32х32х3" => 4, 
							"Кутник 35х35х4" => 5, 
							_ => 0, 
						};
						if (product_VidvidVK.Angle == 90)
						{
							spysannyaMaterialArgumentsTwo = VidvidVK90.MaterialVidvidVK(product_VidvidVK.D, product_VidvidVK.R, product_VidvidVK.K, product_VidvidVK.K1, markaStali19, Convert.ToDouble(product_VidvidVK.ThicknessOfMetal), typVK, typProfil8, product_VidvidVK.Amount, product_VidvidVK.AisiType);
							spysannyaMaterialNames = VidvidVK90.materialName;
						}
						else
						{
							spysannyaMaterialArgumentsTwo = VidvidVK60_45_30_15.MaterialVidvidVK60_45_30_15(product_VidvidVK.D, product_VidvidVK.R, product_VidvidVK.K, product_VidvidVK.K1, product_VidvidVK.Angle, markaStali19, Convert.ToDouble(product_VidvidVK.ThicknessOfMetal), typVK, typProfil8, product_VidvidVK.Amount, product_VidvidVK.AisiType);
							spysannyaMaterialNames = VidvidVK60_45_30_15.materialName;
						}
					}
					break;
				case "Product_UtkaURVP":
					if (product is Product_UtkaURVP product_UtkaURVP)
					{
						int additionalLengthFromVidbortovka12 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_UtkaURVP.Vidbortovka);
						spysannyaMaterialArgumentsTwo = UtkaURVP.MaterialUtkaURVP(typURVP: product_UtkaURVP.Type switch
						{
							"фланець - фланець" => 1, 
							"фланець - чисто" => 2, 
							"чисто - фланець" => 3, 
							"чисто - чисто" => 4, 
							"чисто - мінус" => 5, 
							"мінус - чисто" => 6, 
							_ => 0, 
						}, markaStali: product_UtkaURVP.MarkaStali switch
						{
							"Оцинковка" => 1, 
							"Чорна" => 2, 
							"Нержавійка" => 3, 
							_ => 0, 
						}, typProfilB1H1: product_UtkaURVP.TypProfilBH switch
						{
							"S - 20" => 1, 
							"S - 30" => 2, 
							"Лист" => 3, 
							"Кутник" => 4, 
							_ => 0, 
						}, typProfilB2H2: product_UtkaURVP.TypProfilB1H1 switch
						{
							"S - 20" => 1, 
							"S - 30" => 2, 
							"Лист" => 3, 
							"Кутник" => 4, 
							_ => 0, 
						}, B: product_UtkaURVP.B, B1: product_UtkaURVP.B1, H: product_UtkaURVP.H, L: product_UtkaURVP.L, C: product_UtkaURVP.C, k: product_UtkaURVP.K, k1: product_UtkaURVP.K1, tovchynaMetalu: Convert.ToDouble(product_UtkaURVP.ThicknessOfMetal), number: product_UtkaURVP.Amount, polkaBH: product_UtkaURVP.PolkaBH, polkaB1H1: product_UtkaURVP.PolkaB1H1, vidbortovka: additionalLengthFromVidbortovka12, aisiType: product_UtkaURVP.AisiType);
						spysannyaMaterialNames = UtkaURVP.materialName;
					}
					break;
				}
				break;
			case 'Z':
				if (text == "Product_NipelNZK" && product is Product_NipelNZK product_NipelNZK)
				{
					spysannyaMaterialArgumentsOne = NipelNZK.MaterialNipelNZK(markaStali: product_NipelNZK.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					}, D: product_NipelNZK.D, tovchynaMetalu: Convert.ToDouble(product_NipelNZK.ThicknessOfMetal), number: product_NipelNZK.Amount, aisiType: product_NipelNZK.AisiType);
					spysannyaMaterialNames = NipelNZK.materialName;
				}
				break;
			case 'N':
				if (text == "Product_UtkaURNP" && product is Product_UtkaURNP product_UtkaURNP)
				{
					int additionalLengthFromVidbortovka11 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_UtkaURNP.Vidbortovka);
					spysannyaMaterialArgumentsTwo = UtkaURNP.MaterialUtkaURNP(typURNP: product_UtkaURNP.Type switch
					{
						"фланець - фланець" => 1, 
						"фланець - чисто" => 2, 
						"чисто - чисто" => 3, 
						"чисто - мінус" => 4, 
						_ => 0, 
					}, markaStali: product_UtkaURNP.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					}, typProfilBH: product_UtkaURNP.TypProfilBH switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					}, typProfilB1H1: product_UtkaURNP.TypProfilB1H1 switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					}, B: product_UtkaURNP.B, H: product_UtkaURNP.H, H1: product_UtkaURNP.H1, L: product_UtkaURNP.L, C: product_UtkaURNP.C, k: product_UtkaURNP.K, k1: product_UtkaURNP.K1, tovchynaMetalu: Convert.ToDouble(product_UtkaURNP.ThicknessOfMetal), number: product_UtkaURNP.Amount, polkaBH: product_UtkaURNP.PolkaBH, polkaB1H1: product_UtkaURNP.PolkaB1H1, vidbortovka: additionalLengthFromVidbortovka11, aisiType: product_UtkaURNP.AisiType);
					spysannyaMaterialNames = UtkaURNP.materialName;
				}
				break;
			}
			break;
		case 24:
			switch (text[20])
			{
			case 'd':
				if (text == "Product_PovitroprovidPFP" && product is Product_PovitroprovidPFP product_PovitroprovidPFP)
				{
					spysannyaMaterialArgumentsTwo = PovitroprovidPFP.MaterialPovitroprovidPFP(markaStali: product_PovitroprovidPFP.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					}, typPFP: product_PovitroprovidPFP.Type switch
					{
						"фланець - фланець" => 1, 
						"фланець - чисто" => 2, 
						"фланець - заглушка" => 3, 
						"фланець - мінус" => 4, 
						"чисто - чисто" => 5, 
						"чисто - мінус" => 6, 
						"чисто - заглушка" => 7, 
						_ => 0, 
					}, typProfil: product_PovitroprovidPFP.ProfilType switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					}, B: product_PovitroprovidPFP.B, H: product_PovitroprovidPFP.H, L: product_PovitroprovidPFP.L, tovchynaMetalu: Convert.ToDouble(product_PovitroprovidPFP.ThicknessOfMetal), number: product_PovitroprovidPFP.Amount, polka: product_PovitroprovidPFP.Polka, vidbortovka: MaterialHelper.GetAdditionalLengthFromVidbortovka(product_PovitroprovidPFP.Vidbortovka), aisiType: product_PovitroprovidPFP.AisiType);
					spysannyaMaterialNames = PovitroprovidPFP.materialName;
				}
				break;
			case 'L':
				if (text == "Product_PerehidnykPOLP_K")
				{
					Product_PerehidnykPOLP_K product_PerehidnykPOLP_K = product as Product_PerehidnykPOLP_K;
					int additionalLengthFromVidbortovka4 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_PerehidnykPOLP_K.Vidbortovka);
					int typPOLP_K = product_PerehidnykPOLP_K.Type switch
					{
						"фланець - фланець" => 1, 
						"фланець - чисто" => 2, 
						"чисто - фланець" => 3, 
						"чисто - мінус" => 4, 
						"мінус - чисто" => 5, 
						"чисто - чисто" => 6, 
						"чисто - зуби" => 7, 
						"зуби - чисто" => 8, 
						"фланець - мінус" => 9, 
						"мінус - фланець" => 10, 
						"мінус - мінус" => 11, 
						_ => 0, 
					};
					int markaStali4 = product_PerehidnykPOLP_K.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					int typProfilD2 = product_PerehidnykPOLP_K.TypProfilD switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					};
					int typProfilBH2 = product_PerehidnykPOLP_K.TypProfilBH switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					if (product_PerehidnykPOLP_K != null)
					{
						spysannyaMaterialArgumentsTwo = PerehidnykPOLP_K.MaterialPerehignykPOLP_K(product_PerehidnykPOLP_K.B, product_PerehidnykPOLP_K.H, product_PerehidnykPOLP_K.D, product_PerehidnykPOLP_K.L, product_PerehidnykPOLP_K.K, product_PerehidnykPOLP_K.K1, markaStali4, Convert.ToDouble(product_PerehidnykPOLP_K.ThicknessOfMetal), typPOLP_K, typProfilBH2, typProfilD2, product_PerehidnykPOLP_K.Amount, product_PerehidnykPOLP_K.PolkaB1H1, additionalLengthFromVidbortovka4, product_PerehidnykPOLP_K.AisiType);
						spysannyaMaterialNames = PerehidnykPOLP_K.materialName;
					}
				}
				break;
			case 'P':
				if (text == "Product_PerehidnykPOPP_K")
				{
					Product_PerehidnykPOPP_K product_PerehidnykPOPP_K = product as Product_PerehidnykPOPP_K;
					int additionalLengthFromVidbortovka3 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_PerehidnykPOPP_K.Vidbortovka);
					int typPOPP_K = product_PerehidnykPOPP_K.Type switch
					{
						"фланець - фланець" => 1, 
						"фланець - чисто" => 2, 
						"чисто - фланець" => 3, 
						"чисто - мінус" => 4, 
						"мінус - чисто" => 5, 
						"чисто - чисто" => 6, 
						"чисто - зуби" => 7, 
						"зуби - чисто" => 8, 
						"фланець - мінус" => 9, 
						"мінус - фланець" => 10, 
						"мінус - мінус" => 11, 
						_ => 0, 
					};
					int markaStali3 = product_PerehidnykPOPP_K.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					int typProfilD = product_PerehidnykPOPP_K.TypProfilD switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					};
					int typProfilBH = product_PerehidnykPOPP_K.TypProfilBH switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					if (product_PerehidnykPOPP_K != null)
					{
						spysannyaMaterialArgumentsTwo = PerehidnykPOPP_K.MaterialPerehignykPOPP_K(product_PerehidnykPOPP_K.B, product_PerehidnykPOPP_K.H, product_PerehidnykPOPP_K.D, product_PerehidnykPOPP_K.L, product_PerehidnykPOPP_K.K, product_PerehidnykPOPP_K.K1, markaStali3, Convert.ToDouble(product_PerehidnykPOPP_K.ThicknessOfMetal), typPOPP_K, typProfilBH, typProfilD, product_PerehidnykPOPP_K.Amount, product_PerehidnykPOPP_K.PolkaB1H1, additionalLengthFromVidbortovka3, product_PerehidnykPOPP_K.AisiType);
						spysannyaMaterialNames = PerehidnykPOPP_K.materialName;
					}
				}
				break;
			}
			break;
		case 19:
			switch (text[17])
			{
			case 'S':
				if (text == "Product_RoundAirPSK" && product is Product_RoundAirPSK product_RoundAirPSK)
				{
					spysannyaMaterialArgumentsTwo = RoundAirPSK.MaterialRoundAirFlowPSK(product_RoundAirPSK.D, product_RoundAirPSK.L, Convert.ToDouble(product_RoundAirPSK.ThicknessOfMetal), product_RoundAirPSK.Amount);
					spysannyaMaterialNames = RoundAirPSK.materialName;
				}
				break;
			case 'H':
				if (text == "Product_TrijnykTSHK")
				{
					Product_TrijnykTSHK product_TrijnykTSHK = product as Product_TrijnykTSHK;
					int additionalLengthFromVidbortovka7 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_TrijnykTSHK.Vidbortovka);
					int typTSHKinput = product_TrijnykTSHK.TypeInput1 switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"зуби" => 4, 
						"розтяжка" => 5, 
						_ => 0, 
					};
					int typTSHKinput2 = product_TrijnykTSHK.TypeInput2 switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"зуби" => 4, 
						"розтяжка" => 5, 
						_ => 0, 
					};
					int typTSHKvrizka = product_TrijnykTSHK.TypeVrizka switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"зуби" => 4, 
						"розтяжка" => 5, 
						_ => 0, 
					};
					int typMaterialD5 = product_TrijnykTSHK.TypMaterialD switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					};
					int typMaterialD6 = product_TrijnykTSHK.TypMaterialD1 switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					};
					int markaStali10 = product_TrijnykTSHK.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					if (product_TrijnykTSHK != null)
					{
						spysannyaMaterialArgumentsTwo = TrijnykTSHK.MaterialTrijnykTSHK(product_TrijnykTSHK.D, product_TrijnykTSHK.D1, product_TrijnykTSHK.L, product_TrijnykTSHK.l, product_TrijnykTSHK.Angle, markaStali10, Convert.ToDouble(product_TrijnykTSHK.ThicknessOfMetal), typTSHKinput, typTSHKinput2, typTSHKvrizka, typMaterialD5, typMaterialD6, product_TrijnykTSHK.Amount, additionalLengthFromVidbortovka7, product_TrijnykTSHK.AisiType);
						spysannyaMaterialNames = TrijnykTSHK.materialName;
					}
				}
				break;
			case 'Z':
				switch (text)
				{
				case "Product_TrijnykTOZP":
					if (product is Product_TrijnykTOZP product_TrijnykTOZP)
					{
						int additionalLengthFromVidbortovka6 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_TrijnykTOZP.Vidbortovka);
						string typProfilBH5 = product_TrijnykTOZP.TypProfilBH;
						string text10 = typProfilBH5;
						int typProfilBH6 = ((text10 == "S - 20") ? 1 : ((text10 == "S - 30") ? 2 : 0));
						string typProfilB1H3 = product_TrijnykTOZP.TypProfilB1H1;
						string text11 = typProfilB1H3;
						int typProfilB1H4 = ((text11 == "S - 20") ? 1 : ((text11 == "S - 30") ? 2 : 0));
						string typProfilB2H3 = product_TrijnykTOZP.TypProfilB2H2;
						string text12 = typProfilB2H3;
						spysannyaMaterialArgumentsTwo = TrijnykTOZP.MaterialTrijnykTOZP(typProfilB2H2: (text12 == "S - 20") ? 1 : ((text12 == "S - 30") ? 2 : 0), typTOZPenter: product_TrijnykTOZP.TypeTOZPenter switch
						{
							"фланець" => 1, 
							"чисто" => 2, 
							"мінус" => 3, 
							"розтяжка" => 4, 
							_ => 0, 
						}, typTOZPout: product_TrijnykTOZP.TypeTOZPout switch
						{
							"фланець" => 1, 
							"чисто" => 2, 
							"мінус" => 3, 
							"розтяжка" => 4, 
							_ => 0, 
						}, typTOZPvidvid: product_TrijnykTOZP.TypeTOZPvidvid switch
						{
							"фланець" => 1, 
							"чисто" => 2, 
							"мінус" => 3, 
							"розтяжка" => 4, 
							_ => 0, 
						}, markaStali: product_TrijnykTOZP.MarkaStali switch
						{
							"Оцинковка" => 1, 
							"Чорна" => 2, 
							"Нержавійка" => 3, 
							_ => 0, 
						}, B: product_TrijnykTOZP.B, H: product_TrijnykTOZP.H, B1: product_TrijnykTOZP.B1, B2: product_TrijnykTOZP.B2, G: (product_TrijnykTOZP.F == "Авто") ? (-1) : int.Parse(product_TrijnykTOZP.F), k: product_TrijnykTOZP.K, k1: product_TrijnykTOZP.K1, L: product_TrijnykTOZP.L, r: product_TrijnykTOZP.R, tovchynaMetalu: Convert.ToDouble(product_TrijnykTOZP.ThicknessOfMetal), typProfilBH: typProfilBH6, typProfilB1H1: typProfilB1H4, number: product_TrijnykTOZP.Amount, polkaBH: product_TrijnykTOZP.PolkaB1H1, polkaB1H1: product_TrijnykTOZP.PolkaB2H2, polkaB2H2: product_TrijnykTOZP.PolkaB3H3, vidbortovka: additionalLengthFromVidbortovka6, aisiType: product_TrijnykTOZP.AisiType);
						spysannyaMaterialNames = TrijnykTOZP.materialName;
					}
					break;
				case "Product_ZaglushkaZK":
				{
					Product_ZaglushkaZK product_ZaglushkaZK = product as Product_ZaglushkaZK;
					int markaStali8 = product_ZaglushkaZK.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					int typZK = product_ZaglushkaZK.Type switch
					{
						"мінус" => 1, 
						"чисто" => 2, 
						"фланець" => 3, 
						_ => 0, 
					};
					int typMaterialFlanets = product_ZaglushkaZK.TypMaterialFlanets switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					};
					if (product_ZaglushkaZK != null)
					{
						spysannyaMaterialArgumentsTwo = ZaglushkaZK.MaterialZaglushkaZK(product_ZaglushkaZK.D, product_ZaglushkaZK.M, markaStali8, Convert.ToDouble(product_ZaglushkaZK.ThicknessOfMetal), typZK, typMaterialFlanets, product_ZaglushkaZK.Amount, product_ZaglushkaZK.AisiType);
						spysannyaMaterialNames = ZaglushkaZK.materialName;
					}
					break;
				}
				case "Product_ZaglushkaZP":
				{
					Product_ZaglushkaZP product_ZaglushkaZP = product as Product_ZaglushkaZP;
					int markaStali7 = product_ZaglushkaZP.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					string type = product_ZaglushkaZP.Type;
					string text8 = type;
					int typZP = ((text8 == "фланець") ? 1 : ((text8 == "чисто") ? 2 : 0));
					string profilType3 = product_ZaglushkaZP.ProfilType;
					string text9 = profilType3;
					int typProfil5 = ((text9 == "S - 20" || text9 == "S - 30") ? 1 : 0);
					if (product_ZaglushkaZP != null)
					{
						spysannyaMaterialArgumentsTwo = ZaglushkaZP.MaterialZaglushkaZP(product_ZaglushkaZP.B, product_ZaglushkaZP.H, product_ZaglushkaZP.M, markaStali7, Convert.ToDouble(product_ZaglushkaZP.ThicknessOfMetal), typZP, typProfil5, product_ZaglushkaZP.Amount, product_ZaglushkaZP.Polka, product_ZaglushkaZP.AisiType);
						spysannyaMaterialNames = ZaglushkaZP.materialName;
					}
					break;
				}
				}
				break;
			case 'V':
				if (text == "Product_TrijnykTPVP" && product is Product_TrijnykTPVP product_TrijnykTPVP)
				{
					int additionalLengthFromVidbortovka5 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_TrijnykTPVP.Vidbortovka);
					string typProfilBH3 = product_TrijnykTPVP.TypProfilBH;
					string text5 = typProfilBH3;
					int typProfilBH4 = ((text5 == "S - 20") ? 1 : ((text5 == "S - 30") ? 2 : 0));
					string typProfilB1H = product_TrijnykTPVP.TypProfilB1H1;
					string text6 = typProfilB1H;
					int typProfilB1H2 = ((text6 == "S - 20") ? 1 : ((text6 == "S - 30") ? 2 : 0));
					string typProfilB2H = product_TrijnykTPVP.TypProfilB2H2;
					string text7 = typProfilB2H;
					spysannyaMaterialArgumentsTwo = TrijnykTPVP.MaterialTrijnykTPVP(typProfilB2H2: (text7 == "S - 20") ? 1 : ((text7 == "S - 30") ? 2 : 0), typTPVPenter: product_TrijnykTPVP.TypeTPVPenter switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"розтяжка" => 4, 
						_ => 0, 
					}, typTPVPout: product_TrijnykTPVP.TypeTPVPleft switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"розтяжка" => 4, 
						_ => 0, 
					}, typTPVPvidvid: product_TrijnykTPVP.TypeTPVPright switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"розтяжка" => 4, 
						_ => 0, 
					}, markaStali: product_TrijnykTPVP.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					}, B: product_TrijnykTPVP.B, H: product_TrijnykTPVP.H, B1: product_TrijnykTPVP.B1, B2: product_TrijnykTPVP.B2, k: product_TrijnykTPVP.K, k1: product_TrijnykTPVP.K1, L: product_TrijnykTPVP.L, r: product_TrijnykTPVP.R, tovchynaMetalu: Convert.ToDouble(product_TrijnykTPVP.ThicknessOfMetal), typProfilBH: typProfilBH4, typProfilB1H1: typProfilB1H2, number: product_TrijnykTPVP.Amount, polkaBH: product_TrijnykTPVP.PolkaB1H1, polkaB1H1: product_TrijnykTPVP.PolkaB2H2, polkaB2H2: product_TrijnykTPVP.PolkaB3H3, vidbortovka: additionalLengthFromVidbortovka5, aisiType: product_TrijnykTPVP.AisiType);
					spysannyaMaterialNames = TrijnykTPVP.materialName;
				}
				break;
			case 'P':
				if (text == "Product_NakladkaNPK")
				{
					Product_NakladkaNPK product_NakladkaNPK = product as Product_NakladkaNPK;
					int num14 = 0;
					int num15 = 0;
					num15 = product_NakladkaNPK.Type switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"зуби" => 4, 
						_ => 0, 
					};
					int typProfil6 = product_NakladkaNPK.TypProfil switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					num14 = product_NakladkaNPK.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					if (product_NakladkaNPK != null)
					{
						spysannyaMaterialArgumentsTwo = NakladkaNPK.MaterialNakladkaNPK(product_NakladkaNPK.B, product_NakladkaNPK.H, product_NakladkaNPK.K, product_NakladkaNPK.D, num14, Convert.ToDouble(product_NakladkaNPK.ThicknessOfMetal), num15, typProfil6, product_NakladkaNPK.Amount, product_NakladkaNPK.Polka, product_NakladkaNPK.AisiType);
						spysannyaMaterialNames = NakladkaNPK.materialName;
					}
				}
				break;
			case 'K':
				if (text == "Product_NakladkaNKP")
				{
					Product_NakladkaNKP product_NakladkaNKP = product as Product_NakladkaNKP;
					int num12 = 0;
					int num13 = 0;
					num13 = product_NakladkaNKP.Type switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"зуби" => 4, 
						_ => 0, 
					};
					int typMaterialD7 = product_NakladkaNKP.TypMaterialD switch
					{
						"Лист Ст 3  3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4, м.п" => 5, 
						_ => 0, 
					};
					num12 = product_NakladkaNKP.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					if (product_NakladkaNKP != null)
					{
						spysannyaMaterialArgumentsTwo = NakladkaNKP.MaterialNakladkaNKP(product_NakladkaNKP.K, product_NakladkaNKP.D, num12, Convert.ToDouble(product_NakladkaNKP.ThicknessOfMetal), num13, typMaterialD7, product_NakladkaNKP.Amount, product_NakladkaNKP.AisiType);
						spysannyaMaterialNames = NakladkaNKP.materialName;
					}
				}
				break;
			case 'D':
				if (text == "Product_DeflektorDK")
				{
					Product_DeflektorDK product_DeflektorDK = product as Product_DeflektorDK;
					int typProfil4 = 1;
					int typDK = 0;
					switch (product_DeflektorDK.TypeOf)
					{
					case "чисто":
						typDK = 1;
						break;
					case "мінус":
						typDK = 2;
						break;
					case "зуби":
						typDK = 3;
						break;
					case "фланець":
						typDK = 4;
						break;
					}
					switch (product_DeflektorDK.TypProfil)
					{
					case "Лист Ст 3 3мм":
						typProfil4 = 1;
						break;
					case "Полоса 30х4":
						typProfil4 = 2;
						break;
					case "Кутник 25х25х3":
						typProfil4 = 3;
						break;
					case "Кутник 32х32х3":
						typProfil4 = 4;
						break;
					case "Кутник 35х35х4":
						typProfil4 = 5;
						break;
					}
					if (product_DeflektorDK != null)
					{
						spysannyaMaterialArgumentsTwo = DeflektorDK.MaterialDeflektorDK(product_DeflektorDK.D, typDK, typProfil4, product_DeflektorDK.Amount);
						spysannyaMaterialNames = DeflektorDK.materialName;
					}
				}
				break;
			}
			break;
		case 18:
			switch (text[8])
			{
			case 'R':
				if (text == "Product_RoundAirPK" && product is Product_RoundAirPK product_RoundAirPK)
				{
					int additionalLengthFromVidbortovka = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_RoundAirPK.Vidbortovka);
					spysannyaMaterialArgumentsTwo = RoundAirPK.GetMaterialRoundAirFlowPK(markaStali: product_RoundAirPK.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					}, typPK: product_RoundAirPK.Type switch
					{
						"мінус - мінус" => 1, 
						"чисто - зуби" => 2, 
						"чисто - чисто" => 3, 
						"чисто - мінус" => 4, 
						"фланець - чисто" => 5, 
						"фланець - фланець" => 6, 
						"чисто - розтяжка" => 7, 
						_ => 0, 
					}, typProfil: product_RoundAirPK.ProfilType switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					}, D: product_RoundAirPK.D, L: product_RoundAirPK.L, tovchynaMetalu: Convert.ToDouble(product_RoundAirPK.ThicknessOfMetal), number: product_RoundAirPK.Amount, vidbortovka: additionalLengthFromVidbortovka, aisiType: product_RoundAirPK.AisiType);
					spysannyaMaterialNames = RoundAirPK.materialName;
				}
				break;
			case 'V':
				if (!(text == "Product_VidvidVRNP"))
				{
					if (text == "Product_VidvidVRVP")
					{
						Product_VidvidVRVP product_VidvidVRVP = product as Product_VidvidVRVP;
						int num4 = 0;
						int num5 = 0;
						int num6 = 0;
						int num7 = 0;
						num4 = product_VidvidVRVP.MarkaStali switch
						{
							"Оцинковка" => 1, 
							"Чорна" => 2, 
							"Нержавійка" => 3, 
							_ => 0, 
						};
						num5 = product_VidvidVRVP.Type switch
						{
							"фланець - фланець" => 1, 
							"фланець - чисто" => 2, 
							"чисто - фланець" => 3, 
							"фланець - заглушка" => 4, 
							"заглушка - фланець" => 5, 
							"фланець - сітка" => 6, 
							"сітка - фланець" => 7, 
							"чисто - чисто" => 8, 
							"чисто - мінус" => 9, 
							"мінус - чисто" => 10, 
							"чисто - заглушка" => 11, 
							"заглушка - чисто" => 12, 
							"мінус - мінус" => 13, 
							_ => 0, 
						};
						num6 = product_VidvidVRVP.TypProfile switch
						{
							"S - 20" => 1, 
							"S - 30" => 2, 
							"Лист" => 3, 
							"Кутник" => 4, 
							_ => 0, 
						};
						num7 = product_VidvidVRVP.TypProfile1 switch
						{
							"S - 20" => 1, 
							"S - 30" => 2, 
							"Лист" => 3, 
							"Кутник" => 4, 
							_ => 0, 
						};
						if (product_VidvidVRVP != null)
						{
							spysannyaMaterialArgumentsTwo = VidvidVRVP.MaterialVidvidVRVP(product_VidvidVRVP.B, product_VidvidVRVP.B1, product_VidvidVRVP.H, product_VidvidVRVP.K, product_VidvidVRVP.K1, product_VidvidVRVP.R, product_VidvidVRVP.Angle, num4, Convert.ToDouble(product_VidvidVRVP.ThicknessOfMetal), num5, num6, num7, product_VidvidVRVP.Amount, product_VidvidVRVP.PolkaBH, product_VidvidVRVP.PolkaB1H1, product_VidvidVRVP.AisiType);
							spysannyaMaterialNames = VidvidVRVP.materialName;
						}
					}
				}
				else
				{
					Product_VidvidVRNP product_VidvidVRNP = product as Product_VidvidVRNP;
					int num8 = 0;
					int num9 = 0;
					int num10 = 0;
					int num11 = 0;
					num8 = product_VidvidVRNP.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					num9 = product_VidvidVRNP.Type switch
					{
						"фланець - фланець" => 1, 
						"фланець - чисто" => 2, 
						"чисто - фланець" => 3, 
						"фланець - заглушка" => 4, 
						"заглушка - фланець" => 5, 
						"фланець - сітка" => 6, 
						"сітка - фланець" => 7, 
						"чисто - чисто" => 8, 
						"чисто - мінус" => 9, 
						"мінус - чисто" => 10, 
						"чисто - заглушка" => 11, 
						"заглушка - чисто" => 12, 
						"мінус - мінус" => 13, 
						_ => 0, 
					};
					num10 = product_VidvidVRNP.TypProfile switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					num11 = product_VidvidVRNP.TypProfile1 switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					if (product_VidvidVRNP != null)
					{
						spysannyaMaterialArgumentsTwo = VidvidVRNP.MaterialVidvidVRNP(product_VidvidVRNP.B, product_VidvidVRNP.H, product_VidvidVRNP.H1, product_VidvidVRNP.K, product_VidvidVRNP.K1, product_VidvidVRNP.R, product_VidvidVRNP.Angle, num8, Convert.ToDouble(product_VidvidVRNP.ThicknessOfMetal), num9, num10, num11, product_VidvidVRNP.Amount, product_VidvidVRNP.PolkaBH, product_VidvidVRNP.PolkaB1H1, product_VidvidVRNP.AisiType);
						spysannyaMaterialNames = VidvidVRNP.materialName;
					}
				}
				break;
			case 'T':
				if (text == "Product_TrijnykTRK" && product is Product_TrijnykTRK product_TrijnykTRK)
				{
					int additionalLengthFromVidbortovka2 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_TrijnykTRK.Vidbortovka);
					spysannyaMaterialArgumentsTwo = TrijnykTRK.MaterialTrijnykTRK(typTRKinput: product_TrijnykTRK.TypeTRKinput switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"зуби" => 4, 
						"розтяжка" => 5, 
						_ => 0, 
					}, typTRKoutput: product_TrijnykTRK.TypeTRKoutput switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"зуби" => 4, 
						"розтяжка" => 5, 
						_ => 0, 
					}, typTRKvrizka: product_TrijnykTRK.TypeTRKvrizka switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"зуби" => 4, 
						"розтяжка" => 5, 
						_ => 0, 
					}, typMaterialD: product_TrijnykTRK.TypMaterialD switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					}, typMaterialD1: product_TrijnykTRK.TypMaterialD1 switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					}, typMaterialD2: product_TrijnykTRK.TypMaterialD2 switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					}, markaStali: product_TrijnykTRK.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					}, D: product_TrijnykTRK.D, D1: product_TrijnykTRK.D1, D2: product_TrijnykTRK.D2, L: product_TrijnykTRK.L, l: product_TrijnykTRK.l, k: product_TrijnykTRK.K, k1: product_TrijnykTRK.K1, alpha: product_TrijnykTRK.Angle, tovchynaMetalu: Convert.ToDouble(product_TrijnykTRK.ThicknessOfMetal), number: product_TrijnykTRK.Amount, vidbortovka: additionalLengthFromVidbortovka2, aisiType: product_TrijnykTRK.AisiType);
					spysannyaMaterialNames = TrijnykTRK.materialName;
				}
				break;
			case 'N':
				if (text == "Product_NakladkaNK")
				{
					Product_NakladkaNK product_NakladkaNK = product as Product_NakladkaNK;
					int num2 = 0;
					int num3 = 0;
					num3 = product_NakladkaNK.Type switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"зуби" => 4, 
						_ => 0, 
					};
					int typMaterialD = product_NakladkaNK.TypMaterialD switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					};
					num2 = product_NakladkaNK.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					if (product_NakladkaNK != null)
					{
						spysannyaMaterialArgumentsTwo = VrizkaVK.MaterialVrizkaVK(product_NakladkaNK.D, product_NakladkaNK.D1, product_NakladkaNK.K, product_NakladkaNK.Angle, num2, Convert.ToDouble(product_NakladkaNK.ThicknessOfMetal), num3, typMaterialD, product_NakladkaNK.Amount);
						spysannyaMaterialNames = VrizkaVK.materialName;
					}
				}
				break;
			}
			break;
		case 17:
			switch (text[15])
			{
			case 'S':
				if (text == "Product_VidvidVSP" && product is Product_VidvidVSP { Type: var type2 } product_VidvidVSP)
				{
					spysannyaMaterialArgumentsTwo = VidvidVSP.MaterialVidvidVSP(typVSP: type2 switch
					{
						"фланець - фланець" => 1, 
						"фланець - чисто" => 2, 
						"фланець - заглушка" => 3, 
						"фланець - сітка" => 4, 
						"чисто - чисто" => 5, 
						"чисто - мінус" => 6, 
						"чисто - заглушка" => 7, 
						"мінус - мінус" => 8, 
						_ => 0, 
					}, markaStali: product_VidvidVSP.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					}, typProfil: product_VidvidVSP.ProfilType switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					}, B: product_VidvidVSP.B, H: product_VidvidVSP.H, k1: product_VidvidVSP.K, k2: product_VidvidVSP.K1, r: product_VidvidVSP.R, Angle: product_VidvidVSP.Angle, tovchynaMetalu: Convert.ToDouble(product_VidvidVSP.ThicknessOfMetal), number: product_VidvidVSP.Amount, polka: product_VidvidVSP.Polka, aisiType: product_VidvidVSP.AisiType);
					spysannyaMaterialNames = VidvidVSP.materialName;
				}
				break;
			case 'F':
				if (!(text == "Product_FlanetsFK"))
				{
					if (text == "Product_FlanetsFP")
					{
						Product_FlanetsFP product_FlanetsFP = product as Product_FlanetsFP;
						int num16 = 0;
						num16 = product_FlanetsFP.ProfilType switch
						{
							"S - 20" => 1, 
							"S - 30" => 2, 
							"Лист" => 3, 
							"Кутник" => 4, 
							_ => 0, 
						};
						if (product_FlanetsFP != null)
						{
							spysannyaMaterialArgumentsTwo = FlanetsPrjamokutnyj.MaterialFlanetsPrjamokutnyj(product_FlanetsFP.B, product_FlanetsFP.H, num16, product_FlanetsFP.Amount, product_FlanetsFP.Polka, 1);
							spysannyaMaterialNames = FlanetsPrjamokutnyj.materialName;
						}
					}
				}
				else if (product is Product_FlanetsFK product_FlanetsFK)
				{
					spysannyaMaterialArgumentsTwo = FlanetsKruglyj.MaterialFlanetsKruglyj(typMaterial: product_FlanetsFK.TypMaterial switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					}, D: product_FlanetsFK.D, number: product_FlanetsFK.Amount, numberSides: 1);
					spysannyaMaterialNames = FlanetsKruglyj.materialName1;
				}
				break;
			case 'P':
				if (!(text == "Product_VrizkaVPK"))
				{
					if (text == "Product_VrizkaVPP" && product is Product_VrizkaVPP product_VrizkaVPP)
					{
						int additionalLengthFromVidbortovka9 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_VrizkaVPP.Vidbortovka);
						spysannyaMaterialArgumentsTwo = VrizkaVPP.MaterialVrizkaVPP(typVPPenter: product_VrizkaVPP.TypeOfenter switch
						{
							"фланець" => 1, 
							"чисто" => 2, 
							"мінус" => 3, 
							_ => 0, 
						}, typVPPout: product_VrizkaVPP.TypeOfout switch
						{
							"фланець" => 1, 
							"чисто" => 2, 
							"мінус" => 3, 
							_ => 0, 
						}, typVPPvrizka: product_VrizkaVPP.TypeVrizka switch
						{
							"фланець" => 1, 
							"чисто" => 2, 
							"мінус" => 3, 
							_ => 0, 
						}, typProfilBH: product_VrizkaVPP.ProfilTypeBH switch
						{
							"S - 20" => 1, 
							"S - 30" => 2, 
							"Лист" => 3, 
							"Кутник" => 4, 
							_ => 0, 
						}, typProfilB1H1: product_VrizkaVPP.ProfilTypeB1H1 switch
						{
							"S - 20" => 1, 
							"S - 30" => 2, 
							"Лист" => 3, 
							"Кутник" => 4, 
							_ => 0, 
						}, typProfilB2H2: product_VrizkaVPP.ProfilTypeB2H2 switch
						{
							"S - 20" => 1, 
							"S - 30" => 2, 
							"Лист" => 3, 
							"Кутник" => 4, 
							_ => 0, 
						}, markaStali: product_VrizkaVPP.MarkaStali switch
						{
							"Оцинковка" => 1, 
							"Чорна" => 2, 
							"Нержавійка" => 3, 
							_ => 0, 
						}, B: product_VrizkaVPP.B, H: product_VrizkaVPP.H, L: product_VrizkaVPP.L, B1: product_VrizkaVPP.B1, H1: product_VrizkaVPP.H1, l: product_VrizkaVPP.l, tovchynaMetalu: Convert.ToDouble(product_VrizkaVPP.ThicknessOfMetal), number: product_VrizkaVPP.Amount, polkaBH: product_VrizkaVPP.PolkaBH, polkaB1H1: product_VrizkaVPP.PolkaB1H1, polkaB2H2: product_VrizkaVPP.PolkaB2H2, vidbortovka: additionalLengthFromVidbortovka9, aisiType: product_VrizkaVPP.AisiType);
						spysannyaMaterialNames = VrizkaVPP.materialName;
					}
				}
				else if (product is Product_VrizkaVPK product_VrizkaVPK)
				{
					int additionalLengthFromVidbortovka10 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_VrizkaVPK.Vidbortovka);
					spysannyaMaterialArgumentsTwo = VrizkaVPK.MaterialVrizkaVPK(typVPKenter: product_VrizkaVPK.TypeOfenter switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						_ => 0, 
					}, typVPKout: product_VrizkaVPK.TypeOfout switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						_ => 0, 
					}, typVPKvrizka: product_VrizkaVPK.TypeVrizka switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						_ => 0, 
					}, typMaterialD: product_VrizkaVPK.TypMaterialD switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					}, typProfilB1H1: product_VrizkaVPK.ProfilTypeBH switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					}, typProfilB2H2: product_VrizkaVPK.ProfilTypeB1H1 switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					}, markaStali: product_VrizkaVPK.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					}, B: product_VrizkaVPK.B, H: product_VrizkaVPK.H, L: product_VrizkaVPK.L, D: product_VrizkaVPK.D, l: product_VrizkaVPK.l, alpha: product_VrizkaVPK.Alpha, tovchynaMetalu: Convert.ToDouble(product_VrizkaVPK.ThicknessOfMetal), number: product_VrizkaVPK.Amount, polkaBH: product_VrizkaVPK.PolkaBH, polkaB1H1: product_VrizkaVPK.PolkaB1H1, vidbortovka: additionalLengthFromVidbortovka10, aisiType: product_VrizkaVPK.AisiType);
					spysannyaMaterialNames = VrizkaVPK.materialName;
				}
				break;
			case 'K':
				if (text == "Product_VrizkaVKP" && product is Product_VrizkaVKP product_VrizkaVKP)
				{
					int additionalLengthFromVidbortovka8 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_VrizkaVKP.Vidbortovka);
					spysannyaMaterialArgumentsTwo = VrizkaVKP.MaterialVrizkaVKP(typVPKenter: product_VrizkaVKP.TypeOfenter switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						_ => 0, 
					}, typVPKout: product_VrizkaVKP.TypeOfout switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						_ => 0, 
					}, typVPKvrizka: product_VrizkaVKP.TypeVrizka switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						_ => 0, 
					}, typMaterialD: product_VrizkaVKP.TypMaterialD switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					}, typMaterialD1: product_VrizkaVKP.TypMaterialD1 switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					}, typProfilBH: product_VrizkaVKP.ProfilTypeBH switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					}, markaStali: product_VrizkaVKP.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					}, D: product_VrizkaVKP.D, B: product_VrizkaVKP.B, H: product_VrizkaVKP.H, L: product_VrizkaVKP.L, l: product_VrizkaVKP.l, tovchynaMetalu: Convert.ToDouble(product_VrizkaVKP.ThicknessOfMetal), number: product_VrizkaVKP.Amount, polka: product_VrizkaVKP.Polka, vidbortovka: additionalLengthFromVidbortovka8, aisiType: product_VrizkaVKP.AisiType);
					spysannyaMaterialNames = VrizkaVKP.materialName;
				}
				break;
			case 'T':
				if (text == "Product_TsyklonTS" && product is Product_TsyklonTS product_TsyklonTS)
				{
					spysannyaMaterialArgumentsTwo = TsyklonTS.MaterialTsyklonTS(product_TsyklonTS.D, product_TsyklonTS.Amount);
					spysannyaMaterialNames = TsyklonTS.materialName;
				}
				break;
			}
			break;
		case 25:
			switch (text[24])
			{
			case 'K':
				if (!(text == "Product_HnuchkaVstavkaVHK"))
				{
					if (text == "Product_ShumopohlynachSHK" && product is Product_ShumopohlynachSHK product_ShumopohlynachSHK)
					{
						spysannyaMaterialArgumentsTwo = ShumopohlynachSHK.MaterialShumopohlynachSHK(product_ShumopohlynachSHK.D, product_ShumopohlynachSHK.L, product_ShumopohlynachSHK.Amount);
						spysannyaMaterialNames = ShumopohlynachSHK.materialName;
					}
				}
				else if (product is Product_HnuchkaVstavkaVHK product_HnuchkaVstavkaVHK)
				{
					spysannyaMaterialArgumentsTwo = HnuchkaVstavkaVHK.MateriaHnuchkaVstavkaVHK(typVHK: product_HnuchkaVstavkaVHK.Type switch
					{
						"чисто - чисто" => 1, 
						"фланець - чисто" => 2, 
						"фланець - фланець" => 3, 
						_ => 0, 
					}, D: product_HnuchkaVstavkaVHK.D, number: product_HnuchkaVstavkaVHK.Amount);
					spysannyaMaterialNames = HnuchkaVstavkaVHK.materialName;
				}
				break;
			case 'P':
				if (!(text == "Product_HnuchkaVstavkaVHP"))
				{
					if (text == "Product_ShumopohlynachSHP")
					{
						int num = 0;
						Product_ShumopohlynachSHP product_ShumopohlynachSHP = product as Product_ShumopohlynachSHP;
						string profilType = product_ShumopohlynachSHP.ProfilType;
						string text3 = profilType;
						num = ((text3 == "S - 20") ? 1 : ((text3 == "S - 30") ? 2 : 0));
						if (product_ShumopohlynachSHP != null)
						{
							spysannyaMaterialArgumentsTwo = ShumopohlynachSHP.MaterialShumopohlynachSHP(product_ShumopohlynachSHP.B, product_ShumopohlynachSHP.H, product_ShumopohlynachSHP.L, num, product_ShumopohlynachSHP.Amount);
							spysannyaMaterialNames = ShumopohlynachSHP.materialName;
						}
					}
				}
				else if (product is Product_HnuchkaVstavkaVHP product_HnuchkaVstavkaVHP)
				{
					int typVHP = product_HnuchkaVstavkaVHP.Type switch
					{
						"фланець - фланець" => 1, 
						"фланець - чисто" => 2, 
						"фланець - заглушка" => 3, 
						"чисто - чисто" => 4, 
						"чисто - мінус" => 5, 
						"чисто - заглушка" => 6, 
						_ => 0, 
					};
					string profilType2 = product_HnuchkaVstavkaVHP.ProfilType;
					string text4 = profilType2;
					spysannyaMaterialArgumentsTwo = HnuchkaVstavkaVHP.MateriaHnuchkaVstavkaVHP(typProfil: (text4 == "S - 20") ? 1 : ((text4 == "S - 30") ? 2 : 0), B: product_HnuchkaVstavkaVHP.B, H: product_HnuchkaVstavkaVHP.H, typVHP: typVHP, number: product_HnuchkaVstavkaVHP.Amount);
					spysannyaMaterialNames = HnuchkaVstavkaVHP.materialName;
				}
				break;
			case '1':
				if (text == "Product_ZontOstrivnyyTyp1" && product is Product_ZontOstrivnyyTyp1 product_ZontOstrivnyyTyp4)
				{
					spysannyaMaterialArgumentsTwo = ZontOstrivnyyTyp1.MaterialZontOstrivnyyTyp1(product_ZontOstrivnyyTyp4.L, product_ZontOstrivnyyTyp4.B, product_ZontOstrivnyyTyp4.H, product_ZontOstrivnyyTyp4.h, product_ZontOstrivnyyTyp4.b, product_ZontOstrivnyyTyp4.Amount, product_ZontOstrivnyyTyp4.MarkaStali, product_ZontOstrivnyyTyp4.ThicknessOfMetal, product_ZontOstrivnyyTyp4.Connection, product_ZontOstrivnyyTyp4.Zlyv, product_ZontOstrivnyyTyp4.Fastening, product_ZontOstrivnyyTyp4.FasteningType, product_ZontOstrivnyyTyp4.Vyhid, product_ZontOstrivnyyTyp4.Vyhid1, product_ZontOstrivnyyTyp4.d1, product_ZontOstrivnyyTyp4.a1, product_ZontOstrivnyyTyp4.b1, product_ZontOstrivnyyTyp4.p1, product_ZontOstrivnyyTyp4.f1, product_ZontOstrivnyyTyp4.g1, product_ZontOstrivnyyTyp4.TypVyhid1, product_ZontOstrivnyyTyp4.ProfilType1, product_ZontOstrivnyyTyp4.Vyhid2, product_ZontOstrivnyyTyp4.d2, product_ZontOstrivnyyTyp4.a2, product_ZontOstrivnyyTyp4.b2, product_ZontOstrivnyyTyp4.p2, product_ZontOstrivnyyTyp4.f2, product_ZontOstrivnyyTyp4.g2, product_ZontOstrivnyyTyp4.TypVyhid2, product_ZontOstrivnyyTyp4.ProfilType2, product_ZontOstrivnyyTyp4.Vyhid3, product_ZontOstrivnyyTyp4.d3, product_ZontOstrivnyyTyp4.a3, product_ZontOstrivnyyTyp4.b3, product_ZontOstrivnyyTyp4.p3, product_ZontOstrivnyyTyp4.f3, product_ZontOstrivnyyTyp4.g3, product_ZontOstrivnyyTyp4.TypVyhid3, product_ZontOstrivnyyTyp4.ProfilType3, product_ZontOstrivnyyTyp4.ZhyrFiltr, product_ZontOstrivnyyTyp4.G, product_ZontOstrivnyyTyp4.MarkaStaliFiltr, product_ZontOstrivnyyTyp4.ThicknessOfMetalFiltr);
					spysannyaMaterialNames = ZontOstrivnyyTyp1.materialName;
				}
				break;
			case '2':
				if (text == "Product_ZontOstrivnyyTyp2" && product is Product_ZontOstrivnyyTyp2 product_ZontOstrivnyyTyp2)
				{
					spysannyaMaterialArgumentsTwo = ZontOstrivnyyTyp2.MaterialZontOstrivnyyTyp2(product_ZontOstrivnyyTyp2.L, product_ZontOstrivnyyTyp2.B, product_ZontOstrivnyyTyp2.H, product_ZontOstrivnyyTyp2.h, product_ZontOstrivnyyTyp2.Amount, product_ZontOstrivnyyTyp2.MarkaStali, product_ZontOstrivnyyTyp2.ThicknessOfMetal, product_ZontOstrivnyyTyp2.Connection, product_ZontOstrivnyyTyp2.Zlyv, product_ZontOstrivnyyTyp2.Fastening, product_ZontOstrivnyyTyp2.FasteningType, product_ZontOstrivnyyTyp2.Vyhid, product_ZontOstrivnyyTyp2.Vyhid1, product_ZontOstrivnyyTyp2.d1, product_ZontOstrivnyyTyp2.a1, product_ZontOstrivnyyTyp2.b1, product_ZontOstrivnyyTyp2.p1, product_ZontOstrivnyyTyp2.f1, product_ZontOstrivnyyTyp2.g1, product_ZontOstrivnyyTyp2.TypVyhid1, product_ZontOstrivnyyTyp2.ProfilType1, product_ZontOstrivnyyTyp2.Vyhid2, product_ZontOstrivnyyTyp2.d2, product_ZontOstrivnyyTyp2.a2, product_ZontOstrivnyyTyp2.b2, product_ZontOstrivnyyTyp2.p2, product_ZontOstrivnyyTyp2.f2, product_ZontOstrivnyyTyp2.g2, product_ZontOstrivnyyTyp2.TypVyhid2, product_ZontOstrivnyyTyp2.ProfilType2, product_ZontOstrivnyyTyp2.Vyhid3, product_ZontOstrivnyyTyp2.d3, product_ZontOstrivnyyTyp2.a3, product_ZontOstrivnyyTyp2.b3, product_ZontOstrivnyyTyp2.p3, product_ZontOstrivnyyTyp2.f3, product_ZontOstrivnyyTyp2.g3, product_ZontOstrivnyyTyp2.TypVyhid3, product_ZontOstrivnyyTyp2.ProfilType3, product_ZontOstrivnyyTyp2.ZhyrFiltr, product_ZontOstrivnyyTyp2.G, product_ZontOstrivnyyTyp2.MarkaStaliFiltr, product_ZontOstrivnyyTyp2.ThicknessOfMetalFiltr);
					spysannyaMaterialNames = ZontOstrivnyyTyp2.materialName;
				}
				break;
			case '3':
				if (text == "Product_ZontOstrivnyyTyp3" && product is Product_ZontOstrivnyyTyp3 product_ZontOstrivnyyTyp3)
				{
					spysannyaMaterialArgumentsTwo = ZontOstrivnyyTyp3.MaterialZontOstrivnyyTyp3(product_ZontOstrivnyyTyp3.L, product_ZontOstrivnyyTyp3.B, product_ZontOstrivnyyTyp3.H, product_ZontOstrivnyyTyp3.h, product_ZontOstrivnyyTyp3.a, product_ZontOstrivnyyTyp3.b, product_ZontOstrivnyyTyp3.c, product_ZontOstrivnyyTyp3.c1, product_ZontOstrivnyyTyp3.Amount, product_ZontOstrivnyyTyp3.MarkaStali, product_ZontOstrivnyyTyp3.ThicknessOfMetal, product_ZontOstrivnyyTyp3.Connection, product_ZontOstrivnyyTyp3.Zlyv, product_ZontOstrivnyyTyp3.Fastening, product_ZontOstrivnyyTyp3.FasteningType, product_ZontOstrivnyyTyp3.Vyhid, product_ZontOstrivnyyTyp3.Vyhid1, product_ZontOstrivnyyTyp3.d1, product_ZontOstrivnyyTyp3.a1, product_ZontOstrivnyyTyp3.b1, product_ZontOstrivnyyTyp3.p1, product_ZontOstrivnyyTyp3.f1, product_ZontOstrivnyyTyp3.g1, product_ZontOstrivnyyTyp3.TypVyhid1, product_ZontOstrivnyyTyp3.ProfilType1, product_ZontOstrivnyyTyp3.Vyhid2, product_ZontOstrivnyyTyp3.d2, product_ZontOstrivnyyTyp3.a2, product_ZontOstrivnyyTyp3.b2, product_ZontOstrivnyyTyp3.p2, product_ZontOstrivnyyTyp3.f2, product_ZontOstrivnyyTyp3.g2, product_ZontOstrivnyyTyp3.TypVyhid2, product_ZontOstrivnyyTyp3.ProfilType2, product_ZontOstrivnyyTyp3.Vyhid3, product_ZontOstrivnyyTyp3.d3, product_ZontOstrivnyyTyp3.a3, product_ZontOstrivnyyTyp3.b3, product_ZontOstrivnyyTyp3.p3, product_ZontOstrivnyyTyp3.f3, product_ZontOstrivnyyTyp3.g3, product_ZontOstrivnyyTyp3.TypVyhid3, product_ZontOstrivnyyTyp3.ProfilType3, product_ZontOstrivnyyTyp3.ZhyrFiltr, product_ZontOstrivnyyTyp3.MarkaStaliFiltr, product_ZontOstrivnyyTyp3.ThicknessOfMetalFiltr, product_ZontOstrivnyyTyp3.Implementation);
					spysannyaMaterialNames = ZontOstrivnyyTyp3.materialName;
				}
				break;
			case '4':
				if (text == "Product_ZontOstrivnyyTyp4" && product is Product_ZontOstrivnyyTyp4 product_ZontOstrivnyyTyp)
				{
					spysannyaMaterialArgumentsTwo = ZontOstrivnyyTyp4.MaterialZontOstrivnyyTyp4("ЗВО-4", product_ZontOstrivnyyTyp.Implementation, product_ZontOstrivnyyTyp.L, product_ZontOstrivnyyTyp.B, product_ZontOstrivnyyTyp.H, product_ZontOstrivnyyTyp.Amount, product_ZontOstrivnyyTyp.MarkaStali, product_ZontOstrivnyyTyp.ThicknessOfMetal, product_ZontOstrivnyyTyp.Connection, product_ZontOstrivnyyTyp.Zlyv, product_ZontOstrivnyyTyp.Fastening, product_ZontOstrivnyyTyp.FasteningType, product_ZontOstrivnyyTyp.Vyhid, product_ZontOstrivnyyTyp.Vyhid1, product_ZontOstrivnyyTyp.d1, product_ZontOstrivnyyTyp.a1, product_ZontOstrivnyyTyp.b1, product_ZontOstrivnyyTyp.p1, product_ZontOstrivnyyTyp.f1, product_ZontOstrivnyyTyp.g1, product_ZontOstrivnyyTyp.TypVyhid1, product_ZontOstrivnyyTyp.ProfilType1, product_ZontOstrivnyyTyp.Vyhid2, product_ZontOstrivnyyTyp.d2, product_ZontOstrivnyyTyp.a2, product_ZontOstrivnyyTyp.b2, product_ZontOstrivnyyTyp.p2, product_ZontOstrivnyyTyp.f2, product_ZontOstrivnyyTyp.g2, product_ZontOstrivnyyTyp.TypVyhid2, product_ZontOstrivnyyTyp.ProfilType2, product_ZontOstrivnyyTyp.Vyhid3, product_ZontOstrivnyyTyp.d3, product_ZontOstrivnyyTyp.a3, product_ZontOstrivnyyTyp.b3, product_ZontOstrivnyyTyp.p3, product_ZontOstrivnyyTyp.f3, product_ZontOstrivnyyTyp.g3, product_ZontOstrivnyyTyp.TypVyhid3, product_ZontOstrivnyyTyp.ProfilType3, product_ZontOstrivnyyTyp.ZhyrFiltr, product_ZontOstrivnyyTyp.G, product_ZontOstrivnyyTyp.MarkaStaliFiltr, product_ZontOstrivnyyTyp.ThicknessOfMetalFiltr);
					spysannyaMaterialNames = ZontOstrivnyyTyp4.materialName;
				}
				break;
			}
			break;
		case 26:
			switch (text[12])
			{
			case 't':
				if (text == "Product_HomutAspiratsijnyj" && product is Product_HomutAspiratsijnyj product_HomutAspiratsijnyj)
				{
					spysannyaMaterialArgumentsTwo = HomutAspiratsijnyj.MaterialHomutAspiratsijnyj(product_HomutAspiratsijnyj.D, product_HomutAspiratsijnyj.Amount);
					spysannyaMaterialNames = HomutAspiratsijnyj.materialName;
				}
				break;
			case 'a':
				switch (text)
				{
				case "Product_KlapanDroselnyjKDK":
				{
					Product_KlapanDroselnyjKDK product_KlapanDroselnyjKDK = product as Product_KlapanDroselnyjKDK;
					int vydKDK = 1;
					int klapanServopryvidByStr2 = MaterialHelper.GetKlapanServopryvidByStr(product_KlapanDroselnyjKDK.Servopryvid);
					int additionalLengthFromVidbortovka31 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_KlapanDroselnyjKDK.Vidbortovka);
					switch (product_KlapanDroselnyjKDK.Vyd)
					{
					case "ручний (простий)":
						vydKDK = 1;
						break;
					case "під привід":
						vydKDK = 2;
						break;
					case "ущільнений":
						vydKDK = 3;
						break;
					case "ущільнений під привід":
						vydKDK = 4;
						break;
					case "ручний (простий), пласмасова ручка":
						vydKDK = 5;
						break;
					case "ручний (простий), металева втулка":
						vydKDK = 6;
						break;
					case "під привід, металева втулка":
						vydKDK = 7;
						break;
					case "ущільнений, металева втулка":
						vydKDK = 8;
						break;
					case "ущільнений під привід, металева втулка":
						vydKDK = 9;
						break;
					}
					int markaStali43 = product_KlapanDroselnyjKDK.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					if (product_KlapanDroselnyjKDK != null)
					{
						spysannyaMaterialArgumentsTwo = KlapanDroselnyjKDK.MaterialKlapanDroselnyjKDK(product_KlapanDroselnyjKDK.D, product_KlapanDroselnyjKDK.L, product_KlapanDroselnyjKDK.Amount, vydKDK, klapanServopryvidByStr2, markaStali43, additionalLengthFromVidbortovka31, product_KlapanDroselnyjKDK.AisiType);
						spysannyaMaterialNames = KlapanDroselnyjKDK.materialName;
					}
					break;
				}
				case "Product_KlapanDroselnyjKDP":
				{
					Product_KlapanDroselnyjKDP product_KlapanDroselnyjKDP = product as Product_KlapanDroselnyjKDP;
					int vydKDP = 1;
					int klapanServopryvidByStr3 = MaterialHelper.GetKlapanServopryvidByStr(product_KlapanDroselnyjKDP.Servopryvid);
					int additionalLengthFromVidbortovka32 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_KlapanDroselnyjKDP.Vidbortovka);
					switch (product_KlapanDroselnyjKDP.Vyd)
					{
					case "КДП":
						vydKDP = 1;
						break;
					case "КДП-С":
						vydKDP = 2;
						break;
					case "КДПм":
						vydKDP = 3;
						break;
					case "КДПм-С":
						vydKDP = 4;
						break;
					case "КДПп":
						vydKDP = 5;
						break;
					}
					int markaStali44 = product_KlapanDroselnyjKDP.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					if (product_KlapanDroselnyjKDP != null)
					{
						spysannyaMaterialArgumentsTwo = KlapanDroselnyjKDP.MaterialKlapanDroselnyjKDP(product_KlapanDroselnyjKDP.B, product_KlapanDroselnyjKDP.H, product_KlapanDroselnyjKDP.L, product_KlapanDroselnyjKDP.Amount, vydKDP, klapanServopryvidByStr3, markaStali44, additionalLengthFromVidbortovka32, product_KlapanDroselnyjKDP.AisiType);
						spysannyaMaterialNames = KlapanDroselnyjKDP.materialName;
					}
					break;
				}
				case "Product_KlapanZvorotniyKZP":
				{
					Product_KlapanZvorotniyKZP product_KlapanZvorotniyKZP = product as Product_KlapanZvorotniyKZP;
					int num54 = 0;
					string profilType8 = product_KlapanZvorotniyKZP.ProfilType;
					string text30 = profilType8;
					num54 = ((text30 == "S - 20") ? 1 : ((text30 == "S - 30") ? 2 : 0));
					if (product_KlapanZvorotniyKZP != null)
					{
						spysannyaMaterialArgumentsTwo = KlapanZvorotniyKZP.MaterialKlapanZvorotniyKZP(product_KlapanZvorotniyKZP.B, product_KlapanZvorotniyKZP.H, num54, product_KlapanZvorotniyKZP.Amount);
						spysannyaMaterialNames = KlapanZvorotniyKZP.materialName;
					}
					break;
				}
				case "Product_KlapanZvorotniyKZK":
					if (product is Product_KlapanZvorotniyKZK product_KlapanZvorotniyKZK)
					{
						spysannyaMaterialArgumentsTwo = KlapanZvorotniyKZK.MaterialKlapanZvorotniyKZK(product_KlapanZvorotniyKZK.D, product_KlapanZvorotniyKZK.L, product_KlapanZvorotniyKZK.Amount);
						spysannyaMaterialNames = KlapanZvorotniyKZK.materialName;
					}
					break;
				}
				break;
			case 'o':
				if (text == "Product_ShumopohlynachSHKP")
				{
					int num55 = 0;
					Product_ShumopohlynachSHKP product_ShumopohlynachSHKP = product as Product_ShumopohlynachSHKP;
					string profilType9 = product_ShumopohlynachSHKP.ProfilType;
					string text31 = profilType9;
					num55 = ((text31 == "S - 20") ? 1 : ((text31 == "S - 30") ? 2 : 0));
					if (product_ShumopohlynachSHKP != null)
					{
						spysannyaMaterialArgumentsTwo = ShumopohlynachSHKP.MaterialShumopohlynachSHKP(product_ShumopohlynachSHKP.B, product_ShumopohlynachSHKP.H, product_ShumopohlynachSHKP.L, num55, product_ShumopohlynachSHKP.Amount);
						spysannyaMaterialNames = ShumopohlynachSHKP.materialName;
					}
				}
				break;
			case 'i':
				if (text == "Product_ReshitkaFasadnaRFP")
				{
					Product_ReshitkaFasadnaRFP product_ReshitkaFasadnaRFP = product as Product_ReshitkaFasadnaRFP;
					int markaStali45 = product_ReshitkaFasadnaRFP.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					if (product_ReshitkaFasadnaRFP != null)
					{
						spysannyaMaterialArgumentsTwo = ReshitkaFasadnaRFP.MaterialReshitkaFasadnaRFP(product_ReshitkaFasadnaRFP.B, product_ReshitkaFasadnaRFP.H, product_ReshitkaFasadnaRFP.Amount, markaStali45);
						spysannyaMaterialNames = ReshitkaFasadnaRFP.materialName;
					}
				}
				break;
			case 'P':
				switch (text)
				{
				case "Product_ZontPrystinnyyTyp1":
					if (product is Product_ZontPrystinnyyTyp1 product_ZontPrystinnyyTyp5)
					{
						spysannyaMaterialArgumentsTwo = ZontPrystinnyyTyp1.MaterialZontVytyazhnyyTyp1(product_ZontPrystinnyyTyp5.L, product_ZontPrystinnyyTyp5.B, product_ZontPrystinnyyTyp5.H, product_ZontPrystinnyyTyp5.h, product_ZontPrystinnyyTyp5.b, product_ZontPrystinnyyTyp5.Amount, product_ZontPrystinnyyTyp5.MarkaStali, product_ZontPrystinnyyTyp5.ThicknessOfMetal, product_ZontPrystinnyyTyp5.Connection, product_ZontPrystinnyyTyp5.Zlyv, product_ZontPrystinnyyTyp5.Fastening, product_ZontPrystinnyyTyp5.Vyhid, product_ZontPrystinnyyTyp5.Vyhid1, product_ZontPrystinnyyTyp5.d1, product_ZontPrystinnyyTyp5.a1, product_ZontPrystinnyyTyp5.b1, product_ZontPrystinnyyTyp5.p1, product_ZontPrystinnyyTyp5.f1, product_ZontPrystinnyyTyp5.g1, product_ZontPrystinnyyTyp5.TypVyhid1, product_ZontPrystinnyyTyp5.ProfilType1, product_ZontPrystinnyyTyp5.Vyhid2, product_ZontPrystinnyyTyp5.d2, product_ZontPrystinnyyTyp5.a2, product_ZontPrystinnyyTyp5.b2, product_ZontPrystinnyyTyp5.p2, product_ZontPrystinnyyTyp5.f2, product_ZontPrystinnyyTyp5.g2, product_ZontPrystinnyyTyp5.TypVyhid2, product_ZontPrystinnyyTyp5.ProfilType2, product_ZontPrystinnyyTyp5.Vyhid3, product_ZontPrystinnyyTyp5.d3, product_ZontPrystinnyyTyp5.a3, product_ZontPrystinnyyTyp5.b3, product_ZontPrystinnyyTyp5.p3, product_ZontPrystinnyyTyp5.f3, product_ZontPrystinnyyTyp5.g3, product_ZontPrystinnyyTyp5.TypVyhid3, product_ZontPrystinnyyTyp5.ProfilType3, product_ZontPrystinnyyTyp5.ZhyrFiltr, product_ZontPrystinnyyTyp5.G, product_ZontPrystinnyyTyp5.MarkaStaliFiltr, product_ZontPrystinnyyTyp5.ThicknessOfMetalFiltr);
						spysannyaMaterialNames = ZontPrystinnyyTyp1.materialName;
					}
					break;
				case "Product_ZontPrystinnyyTyp2":
					if (product is Product_ZontPrystinnyyTyp2 product_ZontPrystinnyyTyp3)
					{
						spysannyaMaterialArgumentsTwo = ZontPrystinnyyTyp2.MaterialZontPrystinnyyTyp2(product_ZontPrystinnyyTyp3.L, product_ZontPrystinnyyTyp3.B, product_ZontPrystinnyyTyp3.H, product_ZontPrystinnyyTyp3.h, product_ZontPrystinnyyTyp3.Amount, product_ZontPrystinnyyTyp3.MarkaStali, product_ZontPrystinnyyTyp3.ThicknessOfMetal, product_ZontPrystinnyyTyp3.Connection, product_ZontPrystinnyyTyp3.Zlyv, product_ZontPrystinnyyTyp3.Fastening, product_ZontPrystinnyyTyp3.Vyhid, product_ZontPrystinnyyTyp3.Vyhid1, product_ZontPrystinnyyTyp3.d1, product_ZontPrystinnyyTyp3.a1, product_ZontPrystinnyyTyp3.b1, product_ZontPrystinnyyTyp3.p1, product_ZontPrystinnyyTyp3.f1, product_ZontPrystinnyyTyp3.g1, product_ZontPrystinnyyTyp3.TypVyhid1, product_ZontPrystinnyyTyp3.ProfilType1, product_ZontPrystinnyyTyp3.Vyhid2, product_ZontPrystinnyyTyp3.d2, product_ZontPrystinnyyTyp3.a2, product_ZontPrystinnyyTyp3.b2, product_ZontPrystinnyyTyp3.p2, product_ZontPrystinnyyTyp3.f2, product_ZontPrystinnyyTyp3.g2, product_ZontPrystinnyyTyp3.TypVyhid2, product_ZontPrystinnyyTyp3.ProfilType2, product_ZontPrystinnyyTyp3.Vyhid3, product_ZontPrystinnyyTyp3.d3, product_ZontPrystinnyyTyp3.a3, product_ZontPrystinnyyTyp3.b3, product_ZontPrystinnyyTyp3.p3, product_ZontPrystinnyyTyp3.f3, product_ZontPrystinnyyTyp3.g3, product_ZontPrystinnyyTyp3.TypVyhid3, product_ZontPrystinnyyTyp3.ProfilType3, product_ZontPrystinnyyTyp3.ZhyrFiltr, product_ZontPrystinnyyTyp3.G, product_ZontPrystinnyyTyp3.MarkaStaliFiltr, product_ZontPrystinnyyTyp3.ThicknessOfMetalFiltr);
						spysannyaMaterialNames = ZontPrystinnyyTyp2.materialName;
					}
					break;
				case "Product_ZontPrystinnyyTyp3":
					if (product is Product_ZontPrystinnyyTyp3 product_ZontPrystinnyyTyp4)
					{
						spysannyaMaterialArgumentsTwo = ZontPrystinnyyTyp3.MaterialZontPrystinnyyTyp3(product_ZontPrystinnyyTyp4.L, product_ZontPrystinnyyTyp4.B, product_ZontPrystinnyyTyp4.H, product_ZontPrystinnyyTyp4.h, product_ZontPrystinnyyTyp4.a, product_ZontPrystinnyyTyp4.b, product_ZontPrystinnyyTyp4.c, product_ZontPrystinnyyTyp4.Amount, product_ZontPrystinnyyTyp4.MarkaStali, product_ZontPrystinnyyTyp4.ThicknessOfMetal, product_ZontPrystinnyyTyp4.Connection, product_ZontPrystinnyyTyp4.Zlyv, product_ZontPrystinnyyTyp4.Fastening, product_ZontPrystinnyyTyp4.FasteningType, product_ZontPrystinnyyTyp4.Vyhid, product_ZontPrystinnyyTyp4.Vyhid1, product_ZontPrystinnyyTyp4.d1, product_ZontPrystinnyyTyp4.a1, product_ZontPrystinnyyTyp4.b1, product_ZontPrystinnyyTyp4.p1, product_ZontPrystinnyyTyp4.f1, product_ZontPrystinnyyTyp4.g1, product_ZontPrystinnyyTyp4.TypVyhid1, product_ZontPrystinnyyTyp4.ProfilType1, product_ZontPrystinnyyTyp4.Vyhid2, product_ZontPrystinnyyTyp4.d2, product_ZontPrystinnyyTyp4.a2, product_ZontPrystinnyyTyp4.b2, product_ZontPrystinnyyTyp4.p2, product_ZontPrystinnyyTyp4.f2, product_ZontPrystinnyyTyp4.g2, product_ZontPrystinnyyTyp4.TypVyhid2, product_ZontPrystinnyyTyp4.ProfilType2, product_ZontPrystinnyyTyp4.ZhyrFiltr, product_ZontPrystinnyyTyp4.MarkaStaliFiltr, product_ZontPrystinnyyTyp4.ThicknessOfMetalFiltr, product_ZontPrystinnyyTyp4.Implementation);
						spysannyaMaterialNames = ZontPrystinnyyTyp3.materialName;
					}
					break;
				case "Product_ZontPrystinnyyTyp4":
					if (product is Product_ZontPrystinnyyTyp4 product_ZontPrystinnyyTyp2)
					{
						spysannyaMaterialArgumentsTwo = ZontOstrivnyyTyp4.MaterialZontOstrivnyyTyp4("ЗВП-4", product_ZontPrystinnyyTyp2.Implementation, product_ZontPrystinnyyTyp2.L, product_ZontPrystinnyyTyp2.B, product_ZontPrystinnyyTyp2.H, product_ZontPrystinnyyTyp2.Amount, product_ZontPrystinnyyTyp2.MarkaStali, product_ZontPrystinnyyTyp2.ThicknessOfMetal, product_ZontPrystinnyyTyp2.Connection, product_ZontPrystinnyyTyp2.Zlyv, product_ZontPrystinnyyTyp2.Fastening, product_ZontPrystinnyyTyp2.FasteningType, product_ZontPrystinnyyTyp2.Vyhid, product_ZontPrystinnyyTyp2.Vyhid1, product_ZontPrystinnyyTyp2.d1, product_ZontPrystinnyyTyp2.a1, product_ZontPrystinnyyTyp2.b1, product_ZontPrystinnyyTyp2.p1, product_ZontPrystinnyyTyp2.f1, product_ZontPrystinnyyTyp2.g1, product_ZontPrystinnyyTyp2.TypVyhid1, product_ZontPrystinnyyTyp2.ProfilType1, product_ZontPrystinnyyTyp2.Vyhid2, product_ZontPrystinnyyTyp2.d2, product_ZontPrystinnyyTyp2.a2, product_ZontPrystinnyyTyp2.b2, product_ZontPrystinnyyTyp2.p2, product_ZontPrystinnyyTyp2.f2, product_ZontPrystinnyyTyp2.g2, product_ZontPrystinnyyTyp2.TypVyhid2, product_ZontPrystinnyyTyp2.ProfilType2, product_ZontPrystinnyyTyp2.Vyhid3, product_ZontPrystinnyyTyp2.d3, product_ZontPrystinnyyTyp2.a3, product_ZontPrystinnyyTyp2.b3, product_ZontPrystinnyyTyp2.p3, product_ZontPrystinnyyTyp2.f3, product_ZontPrystinnyyTyp2.g3, product_ZontPrystinnyyTyp2.TypVyhid3, product_ZontPrystinnyyTyp2.ProfilType3, product_ZontPrystinnyyTyp2.ZhyrFiltr, product_ZontPrystinnyyTyp2.G, product_ZontPrystinnyyTyp2.MarkaStaliFiltr, product_ZontPrystinnyyTyp2.ThicknessOfMetalFiltr);
						spysannyaMaterialNames = ZontOstrivnyyTyp4.materialName;
					}
					break;
				}
				break;
			case 'O':
				if (text == "Product_ZontOstrivnyyTyp31" && product is Product_ZontOstrivnyyTyp31 product_ZontOstrivnyyTyp5)
				{
					spysannyaMaterialArgumentsTwo = ZontOstrivnyyTyp31.MaterialZontOstrivnyyTyp31(product_ZontOstrivnyyTyp5.L, product_ZontOstrivnyyTyp5.B, product_ZontOstrivnyyTyp5.H, product_ZontOstrivnyyTyp5.h, product_ZontOstrivnyyTyp5.a, product_ZontOstrivnyyTyp5.b, product_ZontOstrivnyyTyp5.p, product_ZontOstrivnyyTyp5.c, product_ZontOstrivnyyTyp5.c1, product_ZontOstrivnyyTyp5.Amount, product_ZontOstrivnyyTyp5.MarkaStali, product_ZontOstrivnyyTyp5.ThicknessOfMetal, product_ZontOstrivnyyTyp5.Connection, product_ZontOstrivnyyTyp5.Zlyv, product_ZontOstrivnyyTyp5.Fastening, product_ZontOstrivnyyTyp5.FasteningType, product_ZontOstrivnyyTyp5.ZhyrFiltr, product_ZontOstrivnyyTyp5.MarkaStaliFiltr, product_ZontOstrivnyyTyp5.ThicknessOfMetalFiltr, product_ZontOstrivnyyTyp5.Implementation);
					spysannyaMaterialNames = ZontOstrivnyyTyp31.materialName;
				}
				break;
			}
			break;
		case 27:
			switch (text[25])
			{
			case 'G':
			{
				if (!(text == "Product_KlapanGaluzijnjyKGP"))
				{
					break;
				}
				Product_KlapanGaluzijnjyKGP product_KlapanGaluzijnjyKGP = product as Product_KlapanGaluzijnjyKGP;
				int vydKGP = 1;
				int klapanServopryvidByStr = MaterialHelper.GetKlapanServopryvidByStr(product_KlapanGaluzijnjyKGP.Servopryvid);
				int typProfil9 = 0;
				string vydKGP2 = product_KlapanGaluzijnjyKGP.VydKGP;
				string text28 = vydKGP2;
				if (!(text28 == "КЖП"))
				{
					if (text28 == "КЖП-С")
					{
						vydKGP = 2;
					}
				}
				else
				{
					vydKGP = 1;
				}
				string profilType7 = product_KlapanGaluzijnjyKGP.ProfilType;
				string text29 = profilType7;
				if (!(text29 == "S - 20"))
				{
					if (text29 == "S - 30")
					{
						typProfil9 = 2;
					}
				}
				else
				{
					typProfil9 = 1;
				}
				int markaStali42 = product_KlapanGaluzijnjyKGP.MarkaStali switch
				{
					"Оцинковка" => 1, 
					"Чорна" => 2, 
					"Нержавійка" => 3, 
					_ => 0, 
				};
				if (product_KlapanGaluzijnjyKGP != null)
				{
					spysannyaMaterialArgumentsTwo = KlapanGaluzijnjyKGP.MaterialKlapanGaluzijnjyKGP(product_KlapanGaluzijnjyKGP.B, product_KlapanGaluzijnjyKGP.H, product_KlapanGaluzijnjyKGP.Amount, vydKGP, klapanServopryvidByStr, markaStali42, typProfil9, product_KlapanGaluzijnjyKGP.AisiType);
					spysannyaMaterialNames = KlapanGaluzijnjyKGP.materialName;
				}
				break;
			}
			case 'P':
				if (text == "Product_KlapanZvorotniyKZPg")
				{
					Product_KlapanZvorotniyKZPg product_KlapanZvorotniyKZPg = product as Product_KlapanZvorotniyKZPg;
					int num53 = 0;
					string profilType6 = product_KlapanZvorotniyKZPg.ProfilType;
					string text27 = profilType6;
					num53 = ((text27 == "S - 20") ? 1 : ((text27 == "S - 30") ? 2 : 0));
					if (product_KlapanZvorotniyKZPg != null)
					{
						spysannyaMaterialArgumentsTwo = KlapanZvorotniyKZPg.MaterialKlapanZvorotniyKZPg(product_KlapanZvorotniyKZPg.B, product_KlapanZvorotniyKZPg.H, num53, product_KlapanZvorotniyKZPg.Amount);
						spysannyaMaterialNames = KlapanZvorotniyKZPg.materialName;
					}
				}
				break;
			case 'K':
				if (text == "Product_KlapanZvorotniyKZKg" && product is Product_KlapanZvorotniyKZKg product_KlapanZvorotniyKZKg)
				{
					spysannyaMaterialArgumentsTwo = KlapanZvorotniyKZKg.MaterialKlapanZvorotniyKZKg(product_KlapanZvorotniyKZKg.D, product_KlapanZvorotniyKZKg.Amount);
					spysannyaMaterialNames = KlapanZvorotniyKZKg.materialName;
				}
				break;
			case '3':
				if (text == "Product_ZontPrystinnyyTyp31" && product is Product_ZontPrystinnyyTyp31 product_ZontPrystinnyyTyp)
				{
					spysannyaMaterialArgumentsTwo = ZontPrystinnyyTyp31.MaterialZontPrystinnyyTyp31(product_ZontPrystinnyyTyp.L, product_ZontPrystinnyyTyp.B, product_ZontPrystinnyyTyp.H, product_ZontPrystinnyyTyp.h, product_ZontPrystinnyyTyp.a, product_ZontPrystinnyyTyp.b, product_ZontPrystinnyyTyp.p, product_ZontPrystinnyyTyp.c, product_ZontPrystinnyyTyp.Amount, product_ZontPrystinnyyTyp.MarkaStali, product_ZontPrystinnyyTyp.ThicknessOfMetal, product_ZontPrystinnyyTyp.Connection, product_ZontPrystinnyyTyp.Zlyv, product_ZontPrystinnyyTyp.Fastening, product_ZontPrystinnyyTyp.FasteningType, product_ZontPrystinnyyTyp.ZhyrFiltr, product_ZontPrystinnyyTyp.MarkaStaliFiltr, product_ZontPrystinnyyTyp.ThicknessOfMetalFiltr, product_ZontPrystinnyyTyp.Implementation);
					spysannyaMaterialNames = ZontPrystinnyyTyp31.materialName;
				}
				break;
			}
			break;
		case 36:
			switch (text[29])
			{
			case 'k':
				if (text == "Product_KlapanProtypogegnyjKPkEIS60e")
				{
					Product_KlapanProtypogegnyjKPkEIS60e product_KlapanProtypogegnyjKPkEIS60e = product as Product_KlapanProtypogegnyjKPkEIS60e;
					int servopryvid4 = 1;
					switch (product_KlapanProtypogegnyjKPkEIS60e.Servopryvid)
					{
					case "Сервопривід BFL-230Т":
						servopryvid4 = 1;
						break;
					case "Сервопривід BFN-230Т":
						servopryvid4 = 2;
						break;
					case "Сервопривід BFL-24T":
						servopryvid4 = 3;
						break;
					case "Сервопривід BFN-24T":
						servopryvid4 = 4;
						break;
					}
					if (product_KlapanProtypogegnyjKPkEIS60e != null)
					{
						spysannyaMaterialArgumentsTwo = KlapanProtypogegnyjKPkEIS60e.MaterialKlapanProtypogegnyjKPkEIS60e(product_KlapanProtypogegnyjKPkEIS60e.D, product_KlapanProtypogegnyjKPkEIS60e.Amount, servopryvid4);
						spysannyaMaterialNames = KlapanProtypogegnyjKPkEIS60e.materialName;
					}
				}
				break;
			case 'p':
			{
				if (!(text == "Product_KlapanProtypogegnyjKPpEIS60m"))
				{
					if (text == "Product_KlapanProtypogegnyjKPpEIS60e")
					{
						Product_KlapanProtypogegnyjKPpEIS60e product_KlapanProtypogegnyjKPpEIS60e = product as Product_KlapanProtypogegnyjKPpEIS60e;
						int servopryvid3 = 1;
						switch (product_KlapanProtypogegnyjKPpEIS60e.Servopryvid)
						{
						case "Сервопривід BFL-230Т":
							servopryvid3 = 1;
							break;
						case "Сервопривід BFN-230Т":
							servopryvid3 = 2;
							break;
						case "Сервопривід BFL-24T":
							servopryvid3 = 3;
							break;
						case "Сервопривід BFN-24T":
							servopryvid3 = 4;
							break;
						}
						if (product_KlapanProtypogegnyjKPpEIS60e != null)
						{
							spysannyaMaterialArgumentsTwo = KlapanProtypogegnyjKPpEIS60e.MaterialKlapanProtypogegnyjKPpEIS60e(product_KlapanProtypogegnyjKPpEIS60e.B, product_KlapanProtypogegnyjKPpEIS60e.H, product_KlapanProtypogegnyjKPpEIS60e.Amount, servopryvid3);
							spysannyaMaterialNames = KlapanProtypogegnyjKPpEIS60e.materialName;
						}
					}
					break;
				}
				Product_KlapanProtypogegnyjKPpEIS60m product_KlapanProtypogegnyjKPpEIS60m = product as Product_KlapanProtypogegnyjKPpEIS60m;
				int kincevyk7 = 0;
				string kincevyk8 = product_KlapanProtypogegnyjKPpEIS60m.Kincevyk;
				string text26 = kincevyk8;
				if (!(text26 == "Є"))
				{
					if (text26 == "Немає")
					{
						kincevyk7 = 2;
					}
				}
				else
				{
					kincevyk7 = 1;
				}
				if (product_KlapanProtypogegnyjKPpEIS60m != null)
				{
					spysannyaMaterialArgumentsTwo = KlapanProtypogegnyjKPpEIS60m.MaterialKlapanProtypogegnyjKPpEIS60m(product_KlapanProtypogegnyjKPpEIS60m.B, product_KlapanProtypogegnyjKPpEIS60m.H, product_KlapanProtypogegnyjKPpEIS60m.Amount, kincevyk7);
					spysannyaMaterialNames = KlapanProtypogegnyjKPpEIS60m.materialName;
				}
				break;
			}
			}
			break;
		case 31:
			switch (text[30])
			{
			case 'M':
			{
				if (!(text == "Product_KlapanProtypogegnyjKPkM"))
				{
					if (!(text == "Product_KlapanProtypogegnyjKPpM"))
					{
						break;
					}
					Product_KlapanProtypogegnyjKPpM product_KlapanProtypogegnyjKPpM = product as Product_KlapanProtypogegnyjKPpM;
					int kincevyk3 = 1;
					int typKPpM2 = 0;
					string kincevyk4 = product_KlapanProtypogegnyjKPpM.Kincevyk;
					string text21 = kincevyk4;
					if (!(text21 == "Є"))
					{
						if (text21 == "Немає")
						{
							kincevyk3 = 2;
						}
					}
					else
					{
						kincevyk3 = 1;
					}
					string profilType5 = product_KlapanProtypogegnyjKPpM.ProfilType;
					string text22 = profilType5;
					if (!(text22 == "S - 20"))
					{
						if (text22 == "S - 30")
						{
							typKPpM2 = 2;
						}
					}
					else
					{
						typKPpM2 = 1;
					}
					if (product_KlapanProtypogegnyjKPpM != null)
					{
						spysannyaMaterialArgumentsTwo = KlapanProtypogegnyjKPpM.MaterialKlapanProtypogegnyjKPpM(product_KlapanProtypogegnyjKPpM.B, product_KlapanProtypogegnyjKPpM.H, product_KlapanProtypogegnyjKPpM.Amount, kincevyk3, typKPpM2);
						spysannyaMaterialNames = KlapanProtypogegnyjKPpM.materialName;
					}
					break;
				}
				Product_KlapanProtypogegnyjKPkM product_KlapanProtypogegnyjKPkM = product as Product_KlapanProtypogegnyjKPkM;
				int kincevyk5 = 1;
				int typKPkM = 1;
				string kincevyk6 = product_KlapanProtypogegnyjKPkM.Kincevyk;
				string text23 = kincevyk6;
				if (!(text23 == "Є"))
				{
					if (text23 == "Немає")
					{
						kincevyk5 = 2;
					}
				}
				else
				{
					kincevyk5 = 1;
				}
				string type4 = product_KlapanProtypogegnyjKPkM.Type;
				string text24 = type4;
				if (!(text24 == "фланець"))
				{
					if (text24 == "чисто")
					{
						typKPkM = 2;
					}
				}
				else
				{
					typKPkM = 1;
				}
				if (product_KlapanProtypogegnyjKPkM != null)
				{
					spysannyaMaterialArgumentsTwo = KlapanProtypogegnyjKPkM.MaterialKlapanProtypogegnyjKPkM(product_KlapanProtypogegnyjKPkM.D, product_KlapanProtypogegnyjKPkM.Amount, kincevyk5, typKPkM);
					spysannyaMaterialNames = KlapanProtypogegnyjKPkM.materialName;
				}
				break;
			}
			case 'C':
			{
				if (!(text == "Product_KlapanProtypogegnyjKPkC"))
				{
					break;
				}
				Product_KlapanProtypogegnyjKPkC product_KlapanProtypogegnyjKPkC = product as Product_KlapanProtypogegnyjKPkC;
				int servopryvid2 = 1;
				int typKPkS = 1;
				switch (product_KlapanProtypogegnyjKPkC.Servopryvid)
				{
				case "BFL 230-T":
					servopryvid2 = 1;
					break;
				case "BFN 230-T":
					servopryvid2 = 2;
					break;
				case "BFL 24-T":
					servopryvid2 = 3;
					break;
				case "BFN 24-T":
					servopryvid2 = 4;
					break;
				}
				string type5 = product_KlapanProtypogegnyjKPkC.Type;
				string text25 = type5;
				if (!(text25 == "фланець"))
				{
					if (text25 == "чисто")
					{
						typKPkS = 2;
					}
				}
				else
				{
					typKPkS = 1;
				}
				if (product_KlapanProtypogegnyjKPkC != null)
				{
					spysannyaMaterialArgumentsTwo = KlapanProtypogegnyjKPkС.MaterialKlapanProtypogegnyjKPkС(product_KlapanProtypogegnyjKPkC.D, product_KlapanProtypogegnyjKPkC.Amount, servopryvid2, typKPkS);
					spysannyaMaterialNames = KlapanProtypogegnyjKPkС.materialName;
				}
				break;
			}
			case 'S':
			{
				if (!(text == "Product_KlapanProtypogegnyjKPpS"))
				{
					break;
				}
				Product_KlapanProtypogegnyjKPpS product_KlapanProtypogegnyjKPpS = product as Product_KlapanProtypogegnyjKPpS;
				int servopryvid = 1;
				int typKPpM = 0;
				switch (product_KlapanProtypogegnyjKPpS.Servopryvid)
				{
				case "BFL 230-T":
					servopryvid = 1;
					break;
				case "BFN 230-T":
					servopryvid = 2;
					break;
				case "BFL 24-T":
					servopryvid = 3;
					break;
				case "BFN 24-T":
					servopryvid = 4;
					break;
				}
				string profilType4 = product_KlapanProtypogegnyjKPpS.ProfilType;
				string text20 = profilType4;
				if (!(text20 == "S - 20"))
				{
					if (text20 == "S - 30")
					{
						typKPpM = 2;
					}
				}
				else
				{
					typKPpM = 1;
				}
				if (product_KlapanProtypogegnyjKPpS != null)
				{
					spysannyaMaterialArgumentsTwo = KlapanProtypogegnyjKPpS.MaterialKlapanProtypogegnyjKPpS(product_KlapanProtypogegnyjKPpS.B, product_KlapanProtypogegnyjKPpS.H, product_KlapanProtypogegnyjKPpS.Amount, servopryvid, typKPpM);
					spysannyaMaterialNames = KlapanProtypogegnyjKPpS.materialName;
				}
				break;
			}
			}
			break;
		case 21:
			switch (text[19])
			{
			case 'O':
				if (!(text == "Product_PerehidnykPOP"))
				{
					if (text == "Product_PerehidnykPOK")
					{
						Product_PerehidnykPOK product_PerehidnykPOK = product as Product_PerehidnykPOK;
						int num29 = 0;
						int num30 = 0;
						int num31 = 0;
						int num32 = 0;
						int additionalLengthFromVidbortovka24 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_PerehidnykPOK.Vidbortovka);
						num30 = product_PerehidnykPOK.Type switch
						{
							"фланець - фланець" => 1, 
							"фланець - чисто" => 2, 
							"чисто - фланець" => 3, 
							"чисто - мінус" => 4, 
							"мінус - чисто" => 5, 
							"чисто - чисто" => 6, 
							"чисто - зуби" => 7, 
							"зуби - чисто" => 8, 
							"мінус - мінус" => 9, 
							"чисто - розтяжка" => 10, 
							"розтяжка - чисто" => 11, 
							_ => 0, 
						};
						num29 = product_PerehidnykPOK.MarkaStali switch
						{
							"Оцинковка" => 1, 
							"Чорна" => 2, 
							"Нержавійка" => 3, 
							_ => 0, 
						};
						num31 = product_PerehidnykPOK.TypMaterialD switch
						{
							"Лист Ст 3 3мм" => 1, 
							"Полоса 30х4" => 2, 
							"Кутник 25х25х3" => 3, 
							"Кутник 32х32х3" => 4, 
							"Кутник 35х35х4" => 5, 
							_ => 0, 
						};
						num32 = product_PerehidnykPOK.TypMaterialD1 switch
						{
							"Лист Ст 3 3мм" => 1, 
							"Полоса 30х4" => 2, 
							"Кутник 25х25х3" => 3, 
							"Кутник 32х32х3" => 4, 
							"Кутник 35х35х4" => 5, 
							_ => 0, 
						};
						if (product_PerehidnykPOK != null)
						{
							spysannyaMaterialArgumentsTwo = PerehidnykPOK.MaterialPerehidnykPOK(product_PerehidnykPOK.D, product_PerehidnykPOK.D1, product_PerehidnykPOK.L, product_PerehidnykPOK.K, product_PerehidnykPOK.K1, num29, Convert.ToDouble(product_PerehidnykPOK.ThicknessOfMetal), num30, num31, num32, product_PerehidnykPOK.Amount, additionalLengthFromVidbortovka24, product_PerehidnykPOK.AisiType);
							spysannyaMaterialNames = PerehidnykPOK.materialName;
						}
					}
				}
				else
				{
					Product_PerehidnykPOP product_PerehidnykPOP = product as Product_PerehidnykPOP;
					int num33 = 0;
					int num34 = 0;
					int num35 = 0;
					int num36 = 0;
					int additionalLengthFromVidbortovka25 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_PerehidnykPOP.Vidbortovka);
					num33 = product_PerehidnykPOP.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					num34 = product_PerehidnykPOP.Type switch
					{
						"фланець - фланець" => 1, 
						"фланець - чисто" => 2, 
						"чисто - фланець" => 3, 
						"чисто - чисто" => 4, 
						"чисто - мінус" => 5, 
						"мінус - чисто" => 6, 
						"мінус - мінус" => 7, 
						_ => 0, 
					};
					num35 = product_PerehidnykPOP.ProfilType switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					num36 = product_PerehidnykPOP.ProfilType1 switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					if (product_PerehidnykPOP != null)
					{
						spysannyaMaterialArgumentsTwo = PerehidnykPOP.MaterialPerehidnykPOP(product_PerehidnykPOP.B, product_PerehidnykPOP.H, product_PerehidnykPOP.B1, product_PerehidnykPOP.H1, product_PerehidnykPOP.L, product_PerehidnykPOP.K, product_PerehidnykPOP.K1, num33, Convert.ToDouble(product_PerehidnykPOP.ThicknessOfMetal), num34, num35, num36, product_PerehidnykPOP.Amount, product_PerehidnykPOP.PolkaB1H1, product_PerehidnykPOP.PolkaB2H2, additionalLengthFromVidbortovka25, product_PerehidnykPOP.AisiType);
						spysannyaMaterialNames = PerehidnykPOP.materialName;
					}
				}
				break;
			case 'S':
				switch (text)
				{
				case "Product_PerehidnykPSP":
				{
					Product_PerehidnykPSP product_PerehidnykPSP = product as Product_PerehidnykPSP;
					int num49 = 0;
					int num50 = 0;
					int num51 = 0;
					int num52 = 0;
					int additionalLengthFromVidbortovka30 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_PerehidnykPSP.Vidbortovka);
					num49 = product_PerehidnykPSP.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					num50 = product_PerehidnykPSP.Type switch
					{
						"фланець - фланець" => 1, 
						"фланець - чисто" => 2, 
						"чисто - фланець" => 3, 
						"фланець - мінус" => 4, 
						"чисто - чисто" => 5, 
						"чисто - мінус" => 6, 
						"мінус - чисто" => 7, 
						_ => 0, 
					};
					num51 = product_PerehidnykPSP.ProfilType switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					num52 = product_PerehidnykPSP.ProfilType1 switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					if (product_PerehidnykPSP != null)
					{
						spysannyaMaterialArgumentsTwo = PerehidnykPSP.MaterialPerehidnykPSP(product_PerehidnykPSP.B, product_PerehidnykPSP.H, product_PerehidnykPSP.B1, product_PerehidnykPSP.H1, product_PerehidnykPSP.L, product_PerehidnykPSP.K, product_PerehidnykPSP.K1, num49, Convert.ToDouble(product_PerehidnykPSP.ThicknessOfMetal), num50, num51, num52, product_PerehidnykPSP.Amount, product_PerehidnykPSP.PolkaB1H1, product_PerehidnykPSP.PolkaB2H2, additionalLengthFromVidbortovka30, product_PerehidnykPSP.AisiType);
						spysannyaMaterialNames = PerehidnykPSP.materialName;
					}
					break;
				}
				case "Product_PerehidnykPSK":
				{
					Product_PerehidnykPSK product_PerehidnykPSK = product as Product_PerehidnykPSK;
					int num45 = 0;
					int num46 = 0;
					int num47 = 0;
					int num48 = 0;
					int additionalLengthFromVidbortovka29 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_PerehidnykPSK.Vidbortovka);
					num46 = product_PerehidnykPSK.Type switch
					{
						"фланець - фланець" => 1, 
						"фланець - чисто" => 2, 
						"чисто - фланець" => 3, 
						"чисто - мінус" => 4, 
						"мінус - чисто" => 5, 
						"чисто - чисто" => 6, 
						"чисто - зуби" => 7, 
						"зуби - чисто" => 8, 
						"мінус - мінус" => 9, 
						"фланець - мінус" => 10, 
						"чисто - розтяжка" => 11, 
						"розтяжка - чисто" => 12, 
						_ => 0, 
					};
					num45 = product_PerehidnykPSK.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					num47 = product_PerehidnykPSK.TypMaterialD switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					};
					num48 = product_PerehidnykPSK.TypMaterialD1 switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					};
					if (product_PerehidnykPSK != null)
					{
						spysannyaMaterialArgumentsTwo = PerehidnykPSK.MaterialPerehidnykPSK(product_PerehidnykPSK.D, product_PerehidnykPSK.D1, product_PerehidnykPSK.L, product_PerehidnykPSK.K, product_PerehidnykPSK.K1, num45, Convert.ToDouble(product_PerehidnykPSK.ThicknessOfMetal), num46, num47, num48, product_PerehidnykPSK.Amount, additionalLengthFromVidbortovka29, product_PerehidnykPSK.AisiType);
						spysannyaMaterialNames = PerehidnykPSK.materialName;
					}
					break;
				}
				case "Product_HrestovynaHSP":
				{
					Product_HrestovynaHSP product_HrestovynaHSP = product as Product_HrestovynaHSP;
					int vidbortovka2 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_HrestovynaHSP.VidbortovkaInput) + MaterialHelper.GetAdditionalLengthFromVidbortovka(product_HrestovynaHSP.VidbortovkaOut) + MaterialHelper.GetAdditionalLengthFromVidbortovka(product_HrestovynaHSP.VidbortovkaLeft) + MaterialHelper.GetAdditionalLengthFromVidbortovka(product_HrestovynaHSP.VidbortovkaRight);
					int typProfilBH24 = product_HrestovynaHSP.TypProfilBH switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					int typProfilB1H20 = product_HrestovynaHSP.TypProfilB1H1 switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					int typProfilB2H16 = product_HrestovynaHSP.TypProfilB2H2 switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					int typProfilB3H2 = product_HrestovynaHSP.TypProfilB3H3 switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					int typHSPinput = product_HrestovynaHSP.TypeHSPinput switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						_ => 0, 
					};
					int typHSPout = product_HrestovynaHSP.TypeHSPout switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						_ => 0, 
					};
					int typHSPleft = product_HrestovynaHSP.TypeHSPleft switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						_ => 0, 
					};
					int typHSPright = product_HrestovynaHSP.TypeHSPright switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						_ => 0, 
					};
					int markaStali41 = product_HrestovynaHSP.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					if (product_HrestovynaHSP != null)
					{
						spysannyaMaterialArgumentsTwo = HrestovynaHSP.MaterialHrestovynaHSP(product_HrestovynaHSP.B, product_HrestovynaHSP.B1, product_HrestovynaHSP.B2, product_HrestovynaHSP.H, product_HrestovynaHSP.L, product_HrestovynaHSP.R, product_HrestovynaHSP.K, product_HrestovynaHSP.K1, markaStali41, Convert.ToDouble(product_HrestovynaHSP.ThicknessOfMetal), typHSPinput, typHSPout, typHSPleft, typHSPright, typProfilBH24, typProfilB1H20, typProfilB2H16, typProfilB3H2, product_HrestovynaHSP.Amount, product_HrestovynaHSP.PolkaBH, product_HrestovynaHSP.PolkaB1H1, product_HrestovynaHSP.PolkaB2H2, product_HrestovynaHSP.PolkaB3H3, vidbortovka2, product_HrestovynaHSP.AisiType);
						spysannyaMaterialNames = HrestovynaHSP.materialName;
					}
					break;
				}
				}
				break;
			case 'A':
				switch (text)
				{
				case "Product_PerehidnykPAP":
				{
					Product_PerehidnykPAP product_PerehidnykPAP = product as Product_PerehidnykPAP;
					int num37 = 0;
					int num38 = 0;
					int num39 = 0;
					int num40 = 0;
					int additionalLengthFromVidbortovka27 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_PerehidnykPAP.Vidbortovka);
					num37 = product_PerehidnykPAP.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					num38 = product_PerehidnykPAP.Type switch
					{
						"фланець - фланець" => 1, 
						"фланець - чисто" => 2, 
						"чисто - фланець" => 3, 
						"чисто - чисто" => 4, 
						"чисто - мінус" => 5, 
						"мінус - чисто" => 6, 
						"мінус - мінус" => 7, 
						_ => 0, 
					};
					num39 = product_PerehidnykPAP.ProfilType switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					num40 = product_PerehidnykPAP.ProfilType1 switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					if (product_PerehidnykPAP != null)
					{
						spysannyaMaterialArgumentsTwo = PerehidnykPAP.MaterialPerehidnykPAP(product_PerehidnykPAP.B, product_PerehidnykPAP.H, product_PerehidnykPAP.B1, product_PerehidnykPAP.H1, product_PerehidnykPAP.L, product_PerehidnykPAP.C, product_PerehidnykPAP.C1, product_PerehidnykPAP.K, product_PerehidnykPAP.K1, num37, Convert.ToDouble(product_PerehidnykPAP.ThicknessOfMetal), num38, num39, num40, product_PerehidnykPAP.Amount, product_PerehidnykPAP.PolkaB1H1, product_PerehidnykPAP.PolkaB2H2, additionalLengthFromVidbortovka27, product_PerehidnykPAP.AisiType);
						spysannyaMaterialNames = PerehidnykPAP.materialName;
					}
					break;
				}
				case "Product_PerehidnykPAK":
				{
					Product_PerehidnykPAK product_PerehidnykPAK = product as Product_PerehidnykPAK;
					int num41 = 0;
					int num42 = 0;
					int num43 = 0;
					int num44 = 0;
					int additionalLengthFromVidbortovka28 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_PerehidnykPAK.Vidbortovka);
					num42 = product_PerehidnykPAK.Type switch
					{
						"фланець - фланець" => 1, 
						"фланець - чисто" => 2, 
						"чисто - фланець" => 3, 
						"чисто - мінус" => 4, 
						"мінус - чисто" => 5, 
						"чисто - чисто" => 6, 
						"чисто - зуби" => 7, 
						"зуби - чисто" => 8, 
						"мінус - мінус" => 9, 
						"чисто - розтяжка" => 10, 
						"розтяжка - чисто" => 11, 
						_ => 0, 
					};
					num41 = product_PerehidnykPAK.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					num43 = product_PerehidnykPAK.TypMaterialD switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					};
					num44 = product_PerehidnykPAK.TypMaterialD1 switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					};
					if (product_PerehidnykPAK != null)
					{
						spysannyaMaterialArgumentsTwo = PerehidnykPAK.MaterialPerehidnykPAK(product_PerehidnykPAK.D, product_PerehidnykPAK.D1, product_PerehidnykPAK.L, product_PerehidnykPAK.C, product_PerehidnykPAK.K, product_PerehidnykPAK.K1, num41, Convert.ToDouble(product_PerehidnykPAK.ThicknessOfMetal), num42, num43, num44, product_PerehidnykPAK.Amount, additionalLengthFromVidbortovka28, product_PerehidnykPAK.AisiType);
						spysannyaMaterialNames = PerehidnykPAK.materialName;
					}
					break;
				}
				case "Product_TrijnykTSHOAP":
				{
					Product_TrijnykTSHOAP product_TrijnykTSHOAP = product as Product_TrijnykTSHOAP;
					int typProfilBH23 = product_TrijnykTSHOAP.TypProfilBH switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					int typProfilB1H19 = product_TrijnykTSHOAP.TypProfilB1H1 switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					int typProfilB2H15 = product_TrijnykTSHOAP.TypProfilB2H2 switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					int typTSHOAPenter2 = product_TrijnykTSHOAP.TypeTSHOAPenter switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"розтяжка" => 4, 
						_ => 0, 
					};
					int typTSHOAPleft2 = product_TrijnykTSHOAP.TypeTSHOAPleft switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"розтяжка" => 4, 
						_ => 0, 
					};
					int typTSHOAPright2 = product_TrijnykTSHOAP.TypeTSHOAPright switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"розтяжка" => 4, 
						_ => 0, 
					};
					int markaStali40 = product_TrijnykTSHOAP.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					if (product_TrijnykTSHOAP != null)
					{
						if (product_TrijnykTSHOAP.R == 0 && product_TrijnykTSHOAP.R1 == 0)
						{
							spysannyaMaterialArgumentsTwo = TrijnykTSHOAPr0.MaterialTrijnykTSHOAPr0(product_TrijnykTSHOAP.B, product_TrijnykTSHOAP.H, product_TrijnykTSHOAP.B1, product_TrijnykTSHOAP.H1, product_TrijnykTSHOAP.B2, product_TrijnykTSHOAP.H2, product_TrijnykTSHOAP.K, product_TrijnykTSHOAP.K1, product_TrijnykTSHOAP.K2, product_TrijnykTSHOAP.K3, markaStali40, Convert.ToDouble(product_TrijnykTSHOAP.ThicknessOfMetal), typTSHOAPenter2, typTSHOAPleft2, typTSHOAPright2, typProfilBH23, typProfilB1H19, typProfilB2H15, product_TrijnykTSHOAP.Amount, product_TrijnykTSHOAP.PolkaB1H1, product_TrijnykTSHOAP.PolkaB2H2, product_TrijnykTSHOAP.PolkaB3H3, product_TrijnykTSHOAP.AisiType);
							spysannyaMaterialNames = TrijnykTSHOAPr0.materialName;
						}
						else
						{
							spysannyaMaterialArgumentsTwo = TrijnykTSHOAP.MaterialTrijnykTSHOAP(product_TrijnykTSHOAP.B, product_TrijnykTSHOAP.H, product_TrijnykTSHOAP.B1, product_TrijnykTSHOAP.H1, product_TrijnykTSHOAP.B2, product_TrijnykTSHOAP.H2, product_TrijnykTSHOAP.K, product_TrijnykTSHOAP.K1, product_TrijnykTSHOAP.K2, product_TrijnykTSHOAP.K3, product_TrijnykTSHOAP.F, product_TrijnykTSHOAP.R, product_TrijnykTSHOAP.R1, markaStali40, Convert.ToDouble(product_TrijnykTSHOAP.ThicknessOfMetal), typTSHOAPenter2, typTSHOAPleft2, typTSHOAPright2, typProfilBH23, typProfilB1H19, typProfilB2H15, product_TrijnykTSHOAP.Amount, product_TrijnykTSHOAP.PolkaB1H1, product_TrijnykTSHOAP.PolkaB2H2, product_TrijnykTSHOAP.PolkaB3H3, product_TrijnykTSHOAP.AisiType);
							spysannyaMaterialNames = TrijnykTSHOAP.materialName;
						}
					}
					break;
				}
				case "Product_HrestovynaHAP":
				{
					Product_HrestovynaHAP product_HrestovynaHAP = product as Product_HrestovynaHAP;
					int vidbortovka = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_HrestovynaHAP.VidbortovkaInput) + MaterialHelper.GetAdditionalLengthFromVidbortovka(product_HrestovynaHAP.VidbortovkaOut) + MaterialHelper.GetAdditionalLengthFromVidbortovka(product_HrestovynaHAP.VidbortovkaLeft) + MaterialHelper.GetAdditionalLengthFromVidbortovka(product_HrestovynaHAP.VidbortovkaRight);
					int typProfilBH22 = product_HrestovynaHAP.TypProfilBH switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					int typProfilB1H18 = product_HrestovynaHAP.TypProfilB1H1 switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					int typProfilB2H14 = product_HrestovynaHAP.TypProfilB2H2 switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					int typProfilB3H = product_HrestovynaHAP.TypProfilB3H3 switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					int typHAPinput = product_HrestovynaHAP.TypeHAPinput switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						_ => 0, 
					};
					int typHAPout = product_HrestovynaHAP.TypeHAPout switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						_ => 0, 
					};
					int typHAPleft = product_HrestovynaHAP.TypeHAPleft switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						_ => 0, 
					};
					int typHAPright = product_HrestovynaHAP.TypeHAPright switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						_ => 0, 
					};
					int markaStali39 = product_HrestovynaHAP.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					if (product_HrestovynaHAP != null)
					{
						spysannyaMaterialArgumentsTwo = HrestovynaHAP.MaterialHrestovynaHAP(product_HrestovynaHAP.B, product_HrestovynaHAP.B1, product_HrestovynaHAP.B2, product_HrestovynaHAP.B3, product_HrestovynaHAP.H, product_HrestovynaHAP.L, product_HrestovynaHAP.R, product_HrestovynaHAP.R1, product_HrestovynaHAP.K, product_HrestovynaHAP.K1, product_HrestovynaHAP.K2, product_HrestovynaHAP.K3, markaStali39, Convert.ToDouble(product_HrestovynaHAP.ThicknessOfMetal), typHAPinput, typHAPout, typHAPleft, typHAPright, typProfilBH22, typProfilB1H18, typProfilB2H14, typProfilB3H, product_HrestovynaHAP.Amount, product_HrestovynaHAP.PolkaBH, product_HrestovynaHAP.PolkaB1H1, product_HrestovynaHAP.PolkaB2H2, product_HrestovynaHAP.PolkaB3H3, vidbortovka, product_HrestovynaHAP.AisiType);
						spysannyaMaterialNames = HrestovynaHAP.materialName;
					}
					break;
				}
				}
				break;
			case 'H':
				if (text == "Product_TrijnykTOASHK")
				{
					Product_TrijnykTOASHK product_TrijnykTOASHK = product as Product_TrijnykTOASHK;
					int typTOASHKinput = product_TrijnykTOASHK.TypeTOASHKinput switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"зуби" => 4, 
						"розтяжка" => 5, 
						_ => 0, 
					};
					int typTOASHKoutLeft = product_TrijnykTOASHK.TypeTOASHKoutputLeft switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"зуби" => 4, 
						"розтяжка" => 5, 
						_ => 0, 
					};
					int typTOASHKoutRight = product_TrijnykTOASHK.TypeTOASHKoutRight switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"зуби" => 4, 
						"розтяжка" => 5, 
						_ => 0, 
					};
					int typMaterialInput4 = product_TrijnykTOASHK.TypMaterialD switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					};
					int typMaterialOutLeft2 = product_TrijnykTOASHK.TypMaterialD1 switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					};
					int typMaterialOutRight2 = product_TrijnykTOASHK.TypMaterialD2 switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					};
					int markaStali37 = product_TrijnykTOASHK.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					if (product_TrijnykTOASHK != null)
					{
						spysannyaMaterialArgumentsTwo = TrijnykTOASHK.MaterialTrijnykTOASHK(product_TrijnykTOASHK.D, product_TrijnykTOASHK.D1, product_TrijnykTOASHK.D2, product_TrijnykTOASHK.l, product_TrijnykTOASHK.l1, product_TrijnykTOASHK.l2, product_TrijnykTOASHK.K, product_TrijnykTOASHK.K1, product_TrijnykTOASHK.Angle, markaStali37, Convert.ToDouble(product_TrijnykTOASHK.ThicknessOfMetal), typTOASHKinput, typTOASHKoutLeft, typTOASHKoutRight, typMaterialInput4, typMaterialOutLeft2, typMaterialOutRight2, product_TrijnykTOASHK.Amount, product_TrijnykTOASHK.AisiType);
						spysannyaMaterialNames = TrijnykTOASHK.materialName;
					}
				}
				break;
			case 'R':
				if (text == "Product_HrestovynaHRK")
				{
					Product_HrestovynaHRK product_HrestovynaHRK = product as Product_HrestovynaHRK;
					int additionalLengthFromVidbortovka26 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_HrestovynaHRK.Vidbortovka);
					int markaStali38 = product_HrestovynaHRK.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					int typHRKinput = product_HrestovynaHRK.TypeHRKinput switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"зуби" => 4, 
						_ => 0, 
					};
					int typHRKoutput = product_HrestovynaHRK.TypeHRKout switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"зуби" => 4, 
						_ => 0, 
					};
					int typHRKvrizkaUp = product_HrestovynaHRK.TypeHRKvrizkaUp switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"зуби" => 4, 
						_ => 0, 
					};
					int typHRKvrizkaDown = product_HrestovynaHRK.TypeHRKvrizkaDown switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"зуби" => 4, 
						_ => 0, 
					};
					int typMaterialD17 = product_HrestovynaHRK.TypMaterialD switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					};
					int typMaterialD18 = product_HrestovynaHRK.TypMaterialD1 switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					};
					int typMaterialD19 = product_HrestovynaHRK.TypMaterialD2 switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					};
					int typMaterialD20 = product_HrestovynaHRK.TypMaterialD3 switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					};
					if (product_HrestovynaHRK != null)
					{
						spysannyaMaterialArgumentsTwo = HrestovynaHRK.MaterialHrestovynaHRK(product_HrestovynaHRK.D, product_HrestovynaHRK.D1, product_HrestovynaHRK.D2, product_HrestovynaHRK.D3, product_HrestovynaHRK.L, product_HrestovynaHRK.l, product_HrestovynaHRK.l1, product_HrestovynaHRK.Alpha, product_HrestovynaHRK.Alpha1, product_HrestovynaHRK.K, product_HrestovynaHRK.K1, markaStali38, Convert.ToDouble(product_HrestovynaHRK.ThicknessOfMetal), typHRKinput, typHRKoutput, typHRKvrizkaUp, typHRKvrizkaDown, typMaterialD17, typMaterialD18, typMaterialD19, typMaterialD20, product_HrestovynaHRK.Amount, additionalLengthFromVidbortovka26, product_HrestovynaHRK.AisiType);
						spysannyaMaterialNames = HrestovynaHRK.materialName;
					}
				}
				break;
			case 'i':
				if (text == "Product_AluminiumGrid" && product is Product_AluminiumGrid product_AluminiumGrid)
				{
					spysannyaMaterialArgumentsTwo = AluminiumGrid.MaterialAluminiumGrid(product_AluminiumGrid.B, product_AluminiumGrid.H, product_AluminiumGrid.TypReshitky, product_AluminiumGrid.RAL, product_AluminiumGrid.Anodovane, product_AluminiumGrid.SposibKriplennja, product_AluminiumGrid.NotRegular, product_AluminiumGrid.Amount, product_AluminiumGrid.Fasadna, product_AluminiumGrid.HasSitka);
					spysannyaMaterialNames = AluminiumGrid.materialName;
				}
				break;
			}
			break;
		case 22:
			switch (text[20])
			{
			case 'P':
				if (text == "Product_PerehidnykPOPP")
				{
					Product_PerehidnykPOPP product_PerehidnykPOPP = product as Product_PerehidnykPOPP;
					int num25 = 0;
					int num26 = 0;
					int num27 = 0;
					int num28 = 0;
					int additionalLengthFromVidbortovka23 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_PerehidnykPOPP.Vidbortovka);
					num25 = product_PerehidnykPOPP.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					num26 = product_PerehidnykPOPP.Type switch
					{
						"фланець - фланець" => 1, 
						"фланець - чисто" => 2, 
						"чисто - фланець" => 3, 
						"чисто - чисто" => 4, 
						"чисто - мінус" => 5, 
						"мінус - чисто" => 6, 
						"мінус - мінус" => 7, 
						_ => 0, 
					};
					num27 = product_PerehidnykPOPP.ProfilType switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					num28 = product_PerehidnykPOPP.ProfilType1 switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					if (product_PerehidnykPOPP != null)
					{
						spysannyaMaterialArgumentsTwo = PerehidnykPOPP.MaterialPerehidnykPOPP(product_PerehidnykPOPP.B, product_PerehidnykPOPP.H, product_PerehidnykPOPP.B1, product_PerehidnykPOPP.H1, product_PerehidnykPOPP.L, product_PerehidnykPOPP.K, product_PerehidnykPOPP.K1, num25, Convert.ToDouble(product_PerehidnykPOPP.ThicknessOfMetal), num26, num27, num28, product_PerehidnykPOPP.Amount, product_PerehidnykPOPP.PolkaB1H1, product_PerehidnykPOPP.PolkaB2H2, additionalLengthFromVidbortovka23, product_PerehidnykPOPP.AisiType);
						spysannyaMaterialNames = PerehidnykPOPP.materialName;
					}
				}
				break;
			case 'L':
				if (text == "Product_PerehidnykPOLP")
				{
					Product_PerehidnykPOLP product_PerehidnykPOLP = product as Product_PerehidnykPOLP;
					int num21 = 0;
					int num22 = 0;
					int num23 = 0;
					int num24 = 0;
					int additionalLengthFromVidbortovka22 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_PerehidnykPOLP.Vidbortovka);
					num21 = product_PerehidnykPOLP.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					num22 = product_PerehidnykPOLP.Type switch
					{
						"фланець - фланець" => 1, 
						"фланець - чисто" => 2, 
						"чисто - фланець" => 3, 
						"чисто - чисто" => 4, 
						"чисто - мінус" => 5, 
						"мінус - чисто" => 6, 
						"мінус - мінус" => 7, 
						_ => 0, 
					};
					num23 = product_PerehidnykPOLP.ProfilType switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					num24 = product_PerehidnykPOLP.ProfilType1 switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					if (product_PerehidnykPOLP != null)
					{
						spysannyaMaterialArgumentsTwo = PerehidnykPOLP.MaterialPerehidnykPOLP(product_PerehidnykPOLP.B, product_PerehidnykPOLP.H, product_PerehidnykPOLP.B1, product_PerehidnykPOLP.H1, product_PerehidnykPOLP.L, product_PerehidnykPOLP.K, product_PerehidnykPOLP.K1, num21, Convert.ToDouble(product_PerehidnykPOLP.ThicknessOfMetal), num22, num23, num24, product_PerehidnykPOLP.Amount, product_PerehidnykPOLP.PolkaB1H1, product_PerehidnykPOLP.PolkaB2H2, additionalLengthFromVidbortovka22, product_PerehidnykPOLP.AisiType);
						spysannyaMaterialNames = PerehidnykPOLP.materialName;
					}
				}
				break;
			}
			break;
		case 23:
			switch (text[19])
			{
			case 'S':
				if (text == "Product_PerehidnykPSP_K")
				{
					Product_PerehidnykPSP_K product_PerehidnykPSP_K = product as Product_PerehidnykPSP_K;
					int additionalLengthFromVidbortovka20 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_PerehidnykPSP_K.Vidbortovka);
					int typPSP_K = product_PerehidnykPSP_K.Type switch
					{
						"фланець - фланець" => 1, 
						"фланець - чисто" => 2, 
						"чисто - фланець" => 3, 
						"чисто - мінус" => 4, 
						"мінус - чисто" => 5, 
						"чисто - чисто" => 6, 
						"чисто - зуби" => 7, 
						"зуби - чисто" => 8, 
						"фланець - мінус" => 9, 
						"мінус - фланець" => 10, 
						"мінус - мінус" => 11, 
						_ => 0, 
					};
					int markaStali35 = product_PerehidnykPSP_K.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					int typProfilD4 = product_PerehidnykPSP_K.TypProfilD switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					};
					int typProfilBH20 = product_PerehidnykPSP_K.TypProfilBH switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					if (product_PerehidnykPSP_K != null)
					{
						spysannyaMaterialArgumentsTwo = PerehidnykPSP_K.MaterialPerehignykPSP_K(product_PerehidnykPSP_K.B, product_PerehidnykPSP_K.H, product_PerehidnykPSP_K.D, product_PerehidnykPSP_K.L, product_PerehidnykPSP_K.K, product_PerehidnykPSP_K.K1, markaStali35, Convert.ToDouble(product_PerehidnykPSP_K.ThicknessOfMetal), typPSP_K, typProfilBH20, typProfilD4, product_PerehidnykPSP_K.Amount, product_PerehidnykPSP_K.PolkaB1H1, additionalLengthFromVidbortovka20, product_PerehidnykPSP_K.AisiType);
						spysannyaMaterialNames = PerehidnykPSP_K.materialName;
					}
				}
				break;
			case 'A':
				if (text == "Product_PerehidnykPAP_K")
				{
					Product_PerehidnykPAP_K product_PerehidnykPAP_K = product as Product_PerehidnykPAP_K;
					int additionalLengthFromVidbortovka19 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_PerehidnykPAP_K.Vidbortovka);
					int typPAP_K = product_PerehidnykPAP_K.Type switch
					{
						"фланець - фланець" => 1, 
						"фланець - чисто" => 2, 
						"чисто - фланець" => 3, 
						"чисто - мінус" => 4, 
						"мінус - чисто" => 5, 
						"чисто - чисто" => 6, 
						"чисто - зуби" => 7, 
						"зуби - чисто" => 8, 
						"фланець - мінус" => 9, 
						"мінус - фланець" => 10, 
						"мінус - мінус" => 11, 
						_ => 0, 
					};
					int markaStali34 = product_PerehidnykPAP_K.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					int typProfilD3 = product_PerehidnykPAP_K.TypProfilD switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					};
					int typProfilBH19 = product_PerehidnykPAP_K.TypProfilBH switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					if (product_PerehidnykPAP_K != null)
					{
						spysannyaMaterialArgumentsTwo = PerehidnykPAP_K.MaterialPerehignykPAP_K(product_PerehidnykPAP_K.B, product_PerehidnykPAP_K.H, product_PerehidnykPAP_K.D, product_PerehidnykPAP_K.L, product_PerehidnykPAP_K.C, product_PerehidnykPAP_K.C1, product_PerehidnykPAP_K.K, product_PerehidnykPAP_K.K1, markaStali34, Convert.ToDouble(product_PerehidnykPAP_K.ThicknessOfMetal), typPAP_K, typProfilBH19, typProfilD3, product_PerehidnykPAP_K.Amount, product_PerehidnykPAP_K.PolkaB1H1, additionalLengthFromVidbortovka19, product_PerehidnykPAP_K.AisiType);
						spysannyaMaterialNames = PerehidnykPAP_K.materialName;
					}
				}
				break;
			case 'O':
				if (text == "Product_PerehidnykPOP_K")
				{
					Product_PerehidnykPOP_K product_PerehidnykPOP_K = product as Product_PerehidnykPOP_K;
					int additionalLengthFromVidbortovka21 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_PerehidnykPOP_K.Vidbortovka);
					int typPOP_K = product_PerehidnykPOP_K.Type switch
					{
						"фланець - фланець" => 1, 
						"фланець - чисто" => 2, 
						"чисто - фланець" => 3, 
						"чисто - мінус" => 4, 
						"мінус - чисто" => 5, 
						"чисто - чисто" => 6, 
						"чисто - зуби" => 7, 
						"зуби - чисто" => 8, 
						"фланець - мінус" => 9, 
						"мінус - фланець" => 10, 
						"мінус - мінус" => 11, 
						_ => 0, 
					};
					int markaStali36 = product_PerehidnykPOP_K.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					int typProfilD5 = product_PerehidnykPOP_K.TypProfilD switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					};
					int typProfilBH21 = product_PerehidnykPOP_K.TypProfilBH switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					if (product_PerehidnykPOP_K != null)
					{
						spysannyaMaterialArgumentsTwo = PerehidnykPOP_K.MaterialPerehignykPOP_K(product_PerehidnykPOP_K.B, product_PerehidnykPOP_K.H, product_PerehidnykPOP_K.D, product_PerehidnykPOP_K.L, product_PerehidnykPOP_K.K, product_PerehidnykPOP_K.K1, markaStali36, Convert.ToDouble(product_PerehidnykPOP_K.ThicknessOfMetal), typPOP_K, typProfilBH21, typProfilD5, product_PerehidnykPOP_K.Amount, product_PerehidnykPOP_K.PolkaB1H1, additionalLengthFromVidbortovka21, product_PerehidnykPOP_K.AisiType);
						spysannyaMaterialNames = PerehidnykPOP_K.materialName;
					}
				}
				break;
			case 'u':
				if (text == "Product_VuzolProhoduVP1" && product is Product_VuzolProhoduVP1 product_VuzolProhoduVP)
				{
					spysannyaMaterialArgumentsTwo = VuzolProhoduVP1.MaterialVuzolProhoduVP1(product_VuzolProhoduVP.D, product_VuzolProhoduVP.Amount);
					spysannyaMaterialNames = VuzolProhoduVP1.materialName;
				}
				break;
			}
			break;
		case 20:
			switch (text[18])
			{
			case 'H':
				switch (text)
				{
				case "Product_TrijnykTSSHP":
				{
					Product_TrijnykTSSHP product_TrijnykTSSHP = product as Product_TrijnykTSSHP;
					int typProfilBH17 = product_TrijnykTSSHP.TypProfilBH switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					int typProfilB1H16 = product_TrijnykTSSHP.TypProfilB1H1 switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					int typTSSHPenter = product_TrijnykTSSHP.TypeTSSHPenter switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"розтяжка" => 4, 
						_ => 0, 
					};
					int typTSSHPout = product_TrijnykTSSHP.TypeTSSHPout switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"розтяжка" => 4, 
						_ => 0, 
					};
					int markaStali31 = product_TrijnykTSSHP.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					if (product_TrijnykTSSHP != null)
					{
						spysannyaMaterialArgumentsTwo = TrijnykTSSHP.MaterialTrijnykTSSHP(product_TrijnykTSSHP.B, product_TrijnykTSSHP.H, product_TrijnykTSSHP.B1, product_TrijnykTSSHP.K, product_TrijnykTSSHP.K1, markaStali31, Convert.ToDouble(product_TrijnykTSSHP.ThicknessOfMetal), typTSSHPenter, typTSSHPout, typProfilBH17, typProfilB1H16, product_TrijnykTSSHP.Amount, product_TrijnykTSSHP.PolkaB1H1, product_TrijnykTSSHP.PolkaB2H2, product_TrijnykTSSHP.AisiType);
						spysannyaMaterialNames = TrijnykTSSHP.materialName;
					}
					break;
				}
				case "Product_TrijnykTOSHP":
				{
					Product_TrijnykTOSHP product_TrijnykTOSHP = product as Product_TrijnykTOSHP;
					int typProfilBH18 = product_TrijnykTOSHP.TypProfilBH switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					int typProfilB1H17 = product_TrijnykTOSHP.TypProfilB1H1 switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					int typProfilB2H13 = product_TrijnykTOSHP.TypProfilB2H2 switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					int typTOSHPenter = product_TrijnykTOSHP.TypeTOSHPenter switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"розтяжка" => 4, 
						_ => 0, 
					};
					int typTOSHPleft = product_TrijnykTOSHP.TypeTOSHPleft switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"розтяжка" => 4, 
						_ => 0, 
					};
					int typTOSHPright = product_TrijnykTOSHP.TypeTOSHPright switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"розтяжка" => 4, 
						_ => 0, 
					};
					int markaStali33 = product_TrijnykTOSHP.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					if (product_TrijnykTOSHP != null)
					{
						spysannyaMaterialArgumentsTwo = TrijnykTOSHP.MaterialTrijnykTOSHP(product_TrijnykTOSHP.B, product_TrijnykTOSHP.H, product_TrijnykTOSHP.H1, product_TrijnykTOSHP.B1, product_TrijnykTOSHP.B2, product_TrijnykTOSHP.L, product_TrijnykTOSHP.F, product_TrijnykTOSHP.G, product_TrijnykTOSHP.C, product_TrijnykTOSHP.C1, product_TrijnykTOSHP.K, product_TrijnykTOSHP.K1, markaStali33, Convert.ToDouble(product_TrijnykTOSHP.ThicknessOfMetal), typTOSHPenter, typTOSHPleft, typTOSHPright, typProfilBH18, typProfilB1H17, typProfilB2H13, product_TrijnykTOSHP.Amount, product_TrijnykTOSHP.PolkaB1H1, product_TrijnykTOSHP.PolkaB2H2, product_TrijnykTOSHP.PolkaB3H3, product_TrijnykTOSHP.AisiType);
						spysannyaMaterialNames = TrijnykTOSHP.materialName;
					}
					break;
				}
				case "Product_TrijnykTOSHK":
				{
					Product_TrijnykTOSHK product_TrijnykTOSHK = product as Product_TrijnykTOSHK;
					int typTOSHKinput = product_TrijnykTOSHK.TypeTOSHKinput switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"зуби" => 4, 
						"розтяжка" => 5, 
						_ => 0, 
					};
					int typTOSHKoutLeft = product_TrijnykTOSHK.TypeTOSHKoutLeft switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"зуби" => 4, 
						"розтяжка" => 5, 
						_ => 0, 
					};
					int typTOSHKoutRight = product_TrijnykTOSHK.TypeTOSHKoutRight switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"зуби" => 4, 
						"розтяжка" => 5, 
						_ => 0, 
					};
					int typMaterialInput3 = product_TrijnykTOSHK.TypMaterialInput switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					};
					int typMaterialOutLeft = product_TrijnykTOSHK.TypMaterialOutLeft switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					};
					int typMaterialOutRight = product_TrijnykTOSHK.TypMaterialOutRight switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					};
					int markaStali32 = product_TrijnykTOSHK.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					if (product_TrijnykTOSHK != null)
					{
						spysannyaMaterialArgumentsTwo = TrijnykTOSHK.MaterialTrijnykTOSHK(product_TrijnykTOSHK.D, product_TrijnykTOSHK.l, product_TrijnykTOSHK.Angle, markaStali32, Convert.ToDouble(product_TrijnykTOSHK.ThicknessOfMetal), typTOSHKinput, typTOSHKoutLeft, typTOSHKoutRight, typMaterialInput3, typMaterialOutLeft, typMaterialOutRight, product_TrijnykTOSHK.Amount, product_TrijnykTOSHK.AisiType);
						spysannyaMaterialNames = TrijnykTOSHK.materialName;
					}
					break;
				}
				case "Product_HrestovynaHK":
				{
					Product_HrestovynaHK product_HrestovynaHK = product as Product_HrestovynaHK;
					int additionalLengthFromVidbortovka18 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_HrestovynaHK.Vidbortovka);
					int markaStali30 = product_HrestovynaHK.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					int typHKinput = product_HrestovynaHK.TypeHKinput switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"зуби" => 4, 
						_ => 0, 
					};
					int typHKoutput = product_HrestovynaHK.TypeHKout switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"зуби" => 4, 
						_ => 0, 
					};
					int typHKvrizkaUp = product_HrestovynaHK.TypeHKvrizkaUp switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"зуби" => 4, 
						_ => 0, 
					};
					int typHKvrizkaDown = product_HrestovynaHK.TypeHKvrizkaDown switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"зуби" => 4, 
						_ => 0, 
					};
					int typMaterialD13 = product_HrestovynaHK.TypMaterialD switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					};
					int typMaterialD14 = product_HrestovynaHK.TypMaterialD1 switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					};
					int typMaterialD15 = product_HrestovynaHK.TypMaterialD2 switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					};
					int typMaterialD16 = product_HrestovynaHK.TypMaterialD3 switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					};
					if (product_HrestovynaHK != null)
					{
						spysannyaMaterialArgumentsTwo = HrestovynaHK.MaterialHrestovynaHK(product_HrestovynaHK.D, product_HrestovynaHK.D1, product_HrestovynaHK.D2, product_HrestovynaHK.L, product_HrestovynaHK.l, product_HrestovynaHK.l1, product_HrestovynaHK.Alpha, product_HrestovynaHK.Alpha1, markaStali30, Convert.ToDouble(product_HrestovynaHK.ThicknessOfMetal), typHKinput, typHKoutput, typHKvrizkaUp, typHKvrizkaDown, typMaterialD13, typMaterialD14, typMaterialD15, typMaterialD16, product_HrestovynaHK.Amount, additionalLengthFromVidbortovka18, product_HrestovynaHK.AisiType);
						spysannyaMaterialNames = HrestovynaHK.materialName;
					}
					break;
				}
				}
				break;
			case 'S':
				if (text == "Product_TrijnykTSHSP")
				{
					Product_TrijnykTSHSP product_TrijnykTSHSP = product as Product_TrijnykTSHSP;
					int typProfilBH14 = product_TrijnykTSHSP.TypProfilBH switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					int typProfilB1H13 = product_TrijnykTSHSP.TypProfilB1H1 switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					};
					int typTSHSPenter = product_TrijnykTSHSP.TypeTSHSPenter switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"розтяжка" => 4, 
						_ => 0, 
					};
					int typTSHSPout = product_TrijnykTSHSP.TypeTSHSPout switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"розтяжка" => 4, 
						_ => 0, 
					};
					int markaStali28 = product_TrijnykTSHSP.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					if (product_TrijnykTSHSP != null)
					{
						spysannyaMaterialArgumentsTwo = TrijnykTSHSP.MaterialTrijnykTSHSP(product_TrijnykTSHSP.B, product_TrijnykTSHSP.H, product_TrijnykTSHSP.B1, product_TrijnykTSHSP.K, product_TrijnykTSHSP.K1, product_TrijnykTSHSP.R, markaStali28, Convert.ToDouble(product_TrijnykTSHSP.ThicknessOfMetal), typTSHSPenter, typTSHSPout, typProfilBH14, typProfilB1H13, product_TrijnykTSHSP.Amount, product_TrijnykTSHSP.PolkaB1H1, product_TrijnykTSHSP.PolkaB2H2, product_TrijnykTSHSP.AisiType);
						spysannyaMaterialNames = TrijnykTSHSP.materialName;
					}
				}
				break;
			case 'O':
			{
				if (!(text == "Product_TrijnykTSHOP"))
				{
					break;
				}
				Product_TrijnykTSHOP product_TrijnykTSHOP = product as Product_TrijnykTSHOP;
				string typProfilBH15 = product_TrijnykTSHOP.TypProfilBH;
				string text17 = typProfilBH15;
				int typProfilBH16 = ((text17 == "S - 20") ? 1 : ((text17 == "S - 30") ? 2 : 0));
				string typProfilB1H14 = product_TrijnykTSHOP.TypProfilB1H1;
				string text18 = typProfilB1H14;
				int typProfilB1H15 = ((text18 == "S - 20") ? 1 : ((text18 == "S - 30") ? 2 : 0));
				string typProfilB2H11 = product_TrijnykTSHOP.TypProfilB2H2;
				string text19 = typProfilB2H11;
				int typProfilB2H12 = ((text19 == "S - 20") ? 1 : ((text19 == "S - 30") ? 2 : 0));
				int typTSHOAPenter = product_TrijnykTSHOP.TypeTSHOPenter switch
				{
					"фланець" => 1, 
					"чисто" => 2, 
					"мінус" => 3, 
					"розтяжка" => 4, 
					_ => 0, 
				};
				int typTSHOAPleft = product_TrijnykTSHOP.TypeTSHOPleft switch
				{
					"фланець" => 1, 
					"чисто" => 2, 
					"мінус" => 3, 
					"розтяжка" => 4, 
					_ => 0, 
				};
				int typTSHOAPright = product_TrijnykTSHOP.TypeTSHOPright switch
				{
					"фланець" => 1, 
					"чисто" => 2, 
					"мінус" => 3, 
					"розтяжка" => 4, 
					_ => 0, 
				};
				int markaStali29 = product_TrijnykTSHOP.MarkaStali switch
				{
					"Оцинковка" => 1, 
					"Чорна" => 2, 
					"Нержавійка" => 3, 
					_ => 0, 
				};
				if (product_TrijnykTSHOP != null)
				{
					if (product_TrijnykTSHOP.R == 0)
					{
						spysannyaMaterialArgumentsTwo = TrijnykTSHOAPr0.MaterialTrijnykTSHOAPr0(product_TrijnykTSHOP.B, product_TrijnykTSHOP.H, product_TrijnykTSHOP.B1, product_TrijnykTSHOP.H, product_TrijnykTSHOP.B1, product_TrijnykTSHOP.H, product_TrijnykTSHOP.K, product_TrijnykTSHOP.K, product_TrijnykTSHOP.K1, product_TrijnykTSHOP.K1, markaStali29, Convert.ToDouble(product_TrijnykTSHOP.ThicknessOfMetal), typTSHOAPenter, typTSHOAPleft, typTSHOAPright, typProfilBH16, typProfilB1H15, typProfilB2H12, product_TrijnykTSHOP.Amount, product_TrijnykTSHOP.PolkaB1H1, product_TrijnykTSHOP.PolkaB2H2, product_TrijnykTSHOP.PolkaB3H3, product_TrijnykTSHOP.AisiType);
						spysannyaMaterialNames = TrijnykTSHOAPr0.materialName;
					}
					else
					{
						spysannyaMaterialArgumentsTwo = TrijnykTSHOAP.MaterialTrijnykTSHOAP(product_TrijnykTSHOP.B, product_TrijnykTSHOP.H, product_TrijnykTSHOP.B1, product_TrijnykTSHOP.H, product_TrijnykTSHOP.B1, product_TrijnykTSHOP.H, product_TrijnykTSHOP.K, product_TrijnykTSHOP.K, product_TrijnykTSHOP.K1, product_TrijnykTSHOP.K1, product_TrijnykTSHOP.F, product_TrijnykTSHOP.R, product_TrijnykTSHOP.R, markaStali29, Convert.ToDouble(product_TrijnykTSHOP.ThicknessOfMetal), typTSHOAPenter, typTSHOAPleft, typTSHOAPright, typProfilBH16, typProfilB1H15, typProfilB2H12, product_TrijnykTSHOP.Amount, product_TrijnykTSHOP.PolkaB1H1, product_TrijnykTSHOP.PolkaB2H2, product_TrijnykTSHOP.PolkaB3H3, product_TrijnykTSHOP.AisiType);
						spysannyaMaterialNames = TrijnykTSHOAP.materialName;
					}
				}
				break;
			}
			case 'A':
				if (text == "Product_TrijnykTSHAP")
				{
					Product_TrijnykTSHAP product_TrijnykTSHAP = product as Product_TrijnykTSHAP;
					string typProfilBH12 = product_TrijnykTSHAP.TypProfilBH;
					string text14 = typProfilBH12;
					int typProfilBH13 = ((text14 == "S - 20") ? 1 : ((text14 == "S - 30") ? 2 : 0));
					string typProfilB1H11 = product_TrijnykTSHAP.TypProfilB1H1;
					string text15 = typProfilB1H11;
					int typProfilB1H12 = ((text15 == "S - 20") ? 1 : ((text15 == "S - 30") ? 2 : 0));
					string typProfilB2H9 = product_TrijnykTSHAP.TypProfilB2H2;
					string text16 = typProfilB2H9;
					int typProfilB2H10 = ((text16 == "S - 20") ? 1 : ((text16 == "S - 30") ? 2 : 0));
					int typTSHAPenter = product_TrijnykTSHAP.TypeTSHAPenter switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"розтяжка" => 4, 
						_ => 0, 
					};
					int typTSHAPleft = product_TrijnykTSHAP.TypeTSHAPleft switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"розтяжка" => 4, 
						_ => 0, 
					};
					int typTSHAPright = product_TrijnykTSHAP.TypeTSHAPright switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"розтяжка" => 4, 
						_ => 0, 
					};
					int markaStali27 = product_TrijnykTSHAP.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					if (product_TrijnykTSHAP != null)
					{
						spysannyaMaterialArgumentsTwo = TrijnykTSHAP.MaterialTrijnykTSHAP(product_TrijnykTSHAP.B, product_TrijnykTSHAP.H, product_TrijnykTSHAP.B1, product_TrijnykTSHAP.B2, product_TrijnykTSHAP.K, product_TrijnykTSHAP.K1, product_TrijnykTSHAP.K2, product_TrijnykTSHAP.K3, product_TrijnykTSHAP.R, product_TrijnykTSHAP.R1, markaStali27, Convert.ToDouble(product_TrijnykTSHAP.ThicknessOfMetal), typTSHAPenter, typTSHAPleft, typTSHAPright, typProfilBH13, typProfilB1H12, typProfilB2H10, product_TrijnykTSHAP.Amount, product_TrijnykTSHAP.PolkaB1H1, product_TrijnykTSHAP.PolkaB2H2, product_TrijnykTSHAP.PolkaB3H3, product_TrijnykTSHAP.AisiType);
						spysannyaMaterialNames = TrijnykTSHAP.materialName;
					}
				}
				break;
			case '1':
				if (text == "Product_TsyklonTSN15")
				{
					Product_TsyklonTSN15 product_TsyklonTSN = product as Product_TsyklonTSN15;
					string type3 = product_TsyklonTSN.Type;
					string text13 = type3;
					int typTSN = ((text13 == "з равликом") ? 1 : ((text13 == "без равлика") ? 2 : 0));
					if (product_TsyklonTSN != null)
					{
						spysannyaMaterialArgumentsTwo = TsyklonTSN15.MaterialTsyklonTSN15(product_TsyklonTSN.D, typTSN, product_TsyklonTSN.Amount);
						spysannyaMaterialNames = TsyklonTSN15.materialName;
					}
				}
				break;
			}
			break;
		case 15:
			switch (text[13])
			{
			case 'A':
				if (text == "Product_UtkaUAK" && product is Product_UtkaUAK product_UtkaUAK)
				{
					int num19 = 0;
					int num20 = 0;
					int additionalLengthFromVidbortovka17 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_UtkaUAK.Vidbortovka);
					spysannyaMaterialArgumentsTwo = UtkaUAK.MaterialUtkaUAK(typUAK: product_UtkaUAK.Type switch
					{
						"фланець - фланець" => 1, 
						"фланець - чисто" => 2, 
						"чисто - фланець" => 3, 
						"чисто - мінус" => 4, 
						"мінус - чисто" => 5, 
						"чисто - чисто" => 6, 
						"чисто - зуби" => 7, 
						"зуби - чисто" => 8, 
						"мінус - мінус" => 9, 
						_ => 0, 
					}, markaStali: product_UtkaUAK.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					}, typMaterialInput: product_UtkaUAK.TypMaterialInput switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					}, typMaterialOutput: product_UtkaUAK.TypMaterialOutput switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					}, D: product_UtkaUAK.D, D1: product_UtkaUAK.D1, L: product_UtkaUAK.L, k: product_UtkaUAK.K, k1: product_UtkaUAK.K1, C: product_UtkaUAK.C, tovchynaMetalu: Convert.ToDouble(product_UtkaUAK.ThicknessOfMetal), number: product_UtkaUAK.Amount, vidbortovka: additionalLengthFromVidbortovka17, aisiType: product_UtkaUAK.AisiType);
					spysannyaMaterialNames = UtkaUAK.materialName;
				}
				break;
			case 'O':
				if (!(text == "Product_ObvidOK"))
				{
					if (text == "Product_ObvidOP")
					{
						Product_ObvidOP product_ObvidOP = product as Product_ObvidOP;
						int additionalLengthFromVidbortovka15 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_ObvidOP.Vidbortovka);
						int typOP = product_ObvidOP.Type switch
						{
							"фланець - фланець" => 1, 
							"фланець - чисто" => 2, 
							"чисто - чисто" => 3, 
							"чисто - мінус" => 4, 
							_ => 0, 
						};
						int markaStali22 = product_ObvidOP.MarkaStali switch
						{
							"Оцинковка" => 1, 
							"Чорна" => 2, 
							"Нержавійка" => 3, 
							_ => 0, 
						};
						int typProfilB1H10 = product_ObvidOP.TypProfilBH switch
						{
							"S - 20" => 1, 
							"S - 30" => 2, 
							"Лист" => 3, 
							"Кутник" => 4, 
							_ => 0, 
						};
						int typProfilB2H8 = product_ObvidOP.TypProfilB1H1 switch
						{
							"S - 20" => 1, 
							"S - 30" => 2, 
							"Лист" => 3, 
							"Кутник" => 4, 
							_ => 0, 
						};
						if (product_ObvidOP != null)
						{
							spysannyaMaterialArgumentsTwo = ObvidOP.MaterialObvidOP(product_ObvidOP.B, product_ObvidOP.H, product_ObvidOP.L, product_ObvidOP.C, product_ObvidOP.l, product_ObvidOP.K, product_ObvidOP.K1, markaStali22, Convert.ToDouble(product_ObvidOP.ThicknessOfMetal), typOP, typProfilB1H10, typProfilB2H8, product_ObvidOP.Amount, product_ObvidOP.PolkaBH, product_ObvidOP.PolkaB1H1, additionalLengthFromVidbortovka15, product_ObvidOP.AisiType);
							spysannyaMaterialNames = ObvidOP.materialName;
						}
					}
				}
				else
				{
					Product_ObvidOK product_ObvidOK = product as Product_ObvidOK;
					int additionalLengthFromVidbortovka16 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_ObvidOK.Vidbortovka);
					int typOK = product_ObvidOK.Type switch
					{
						"фланець - фланець" => 1, 
						"фланець - чисто" => 2, 
						"чисто - мінус" => 3, 
						"чисто - чисто" => 4, 
						"чисто - зуби" => 5, 
						_ => 0, 
					};
					int markaStali23 = product_ObvidOK.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					int typMaterialD11 = product_ObvidOK.TypeMaterialD switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					};
					if (product_ObvidOK != null)
					{
						spysannyaMaterialArgumentsTwo = ObvidOK.MaterialObvidOK(product_ObvidOK.D, product_ObvidOK.L, product_ObvidOK.l, product_ObvidOK.C, product_ObvidOK.K, product_ObvidOK.K1, markaStali23, Convert.ToDouble(product_ObvidOK.ThicknessOfMetal), typOK, typMaterialD11, product_ObvidOK.Amount, additionalLengthFromVidbortovka16, product_ObvidOK.AisiType);
						spysannyaMaterialNames = ObvidOK.materialName;
					}
				}
				break;
			case 'F':
				if (!(text == "Product_FiltrFK"))
				{
					if (text == "Product_FiltrFP" && product is Product_FiltrFP product_FiltrFP)
					{
						spysannyaMaterialArgumentsTwo = FiltrFP.MaterialFiltrFP(product_FiltrFP.B, product_FiltrFP.H, product_FiltrFP.L, product_FiltrFP.Amount);
						spysannyaMaterialNames = FiltrFP.materialName;
					}
				}
				else if (product is Product_FiltrFK product_FiltrFK)
				{
					spysannyaMaterialArgumentsTwo = FiltrFK.MaterialFiltrFK(product_FiltrFK.D, product_FiltrFK.Amount);
					spysannyaMaterialNames = FiltrFK.materialName;
				}
				break;
			case 'V':
				if (!(text == "Product_ZontZVK"))
				{
					if (text == "Product_ZontZVP")
					{
						Product_ZontZVP product_ZontZVP = product as Product_ZontZVP;
						int typZVP = product_ZontZVP.Type switch
						{
							"фланець" => 1, 
							"чисто" => 2, 
							"мінус" => 3, 
							_ => 0, 
						};
						int markaStali24 = product_ZontZVP.MarkaStali switch
						{
							"Оцинковка" => 1, 
							"Чорна" => 2, 
							"Нержавійка" => 3, 
							_ => 0, 
						};
						int typProfilBH11 = product_ZontZVP.TypeMaterialD switch
						{
							"S - 20" => 1, 
							"S - 30" => 2, 
							"Лист" => 3, 
							"Кутник" => 4, 
							_ => 0, 
						};
						if (product_ZontZVP != null)
						{
							spysannyaMaterialArgumentsTwo = ZontZVP.MaterialZontZVP(product_ZontZVP.B, product_ZontZVP.H, product_ZontZVP.B1, product_ZontZVP.H1, markaStali24, typZVP, typProfilBH11, product_ZontZVP.Amount, product_ZontZVP.Polka, product_ZontZVP.AisiType);
							spysannyaMaterialNames = ZontZVP.materialName;
						}
					}
				}
				else
				{
					Product_ZontZVK product_ZontZVK = product as Product_ZontZVK;
					int typZVK = product_ZontZVK.Type switch
					{
						"фланець" => 1, 
						"чисто" => 2, 
						"мінус" => 3, 
						"зуби" => 4, 
						_ => 0, 
					};
					int markaStali25 = product_ZontZVK.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					};
					int typMaterialD12 = product_ZontZVK.TypeMaterialD switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					};
					if (product_ZontZVK != null)
					{
						spysannyaMaterialArgumentsTwo = ZontZVK.MaterialZontZVK(product_ZontZVK.D, product_ZontZVK.D1, product_ZontZVK.l, markaStali25, typZVK, typMaterialD12, product_ZontZVK.Amount, product_ZontZVK.AisiType);
						spysannyaMaterialNames = ZontZVK.materialName;
					}
				}
				break;
			case 'Z':
				if (text == "Product_FiltrZH" && product is Product_FiltrZH product_FiltrZH)
				{
					spysannyaMaterialArgumentsOne = FiltrZh.MaterialFiltrZh(product_FiltrZH.B, product_FiltrZH.H, product_FiltrZH.MarkaStali, product_FiltrZH.ThicknessOfMetal, product_FiltrZH.Amount);
					spysannyaMaterialNames = FiltrZh.materialName;
				}
				break;
			}
			break;
		case 14:
			switch (text[13])
			{
			case 'K':
				if (text == "Product_UtkaUK" && product is Product_UtkaUK product_UtkaUK)
				{
					int num17 = 0;
					int num18 = 0;
					int additionalLengthFromVidbortovka14 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_UtkaUK.Vidbortovka);
					spysannyaMaterialArgumentsTwo = UtkaUK.MaterialUtkaUK(typUK: product_UtkaUK.Type switch
					{
						"фланець - фланець" => 1, 
						"фланець - чисто" => 2, 
						"чисто - фланець" => 3, 
						"чисто - мінус" => 4, 
						"мінус - чисто" => 5, 
						"чисто - чисто" => 6, 
						"чисто - зуби" => 7, 
						"зуби - чисто" => 8, 
						"мінус - мінус" => 9, 
						_ => 0, 
					}, markaStali: product_UtkaUK.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					}, typMaterialInput: product_UtkaUK.TypMaterialInput switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					}, typMaterialOutput: product_UtkaUK.TypMaterialOutput switch
					{
						"Лист Ст 3 3мм" => 1, 
						"Полоса 30х4" => 2, 
						"Кутник 25х25х3" => 3, 
						"Кутник 32х32х3" => 4, 
						"Кутник 35х35х4" => 5, 
						_ => 0, 
					}, D: product_UtkaUK.D, L: product_UtkaUK.L, k: product_UtkaUK.K, k1: product_UtkaUK.K1, c: product_UtkaUK.C, tovchynaMetalu: Convert.ToDouble(product_UtkaUK.ThicknessOfMetal), number: product_UtkaUK.Amount, vidbortovka: additionalLengthFromVidbortovka14, aisiType: product_UtkaUK.AisiType);
					spysannyaMaterialNames = UtkaUK.materialName;
				}
				break;
			case 'P':
				if (text == "Product_UtkaUP" && product is Product_UtkaUP product_UtkaUP)
				{
					int additionalLengthFromVidbortovka13 = MaterialHelper.GetAdditionalLengthFromVidbortovka(product_UtkaUP.Vidbortovka);
					spysannyaMaterialArgumentsTwo = UtkaUP.MaterialUtkaUP(typUP: product_UtkaUP.Type switch
					{
						"фланець - фланець" => 1, 
						"фланець - чисто" => 2, 
						"чисто - чисто" => 3, 
						"чисто - мінус" => 4, 
						_ => 0, 
					}, markaStali: product_UtkaUP.MarkaStali switch
					{
						"Оцинковка" => 1, 
						"Чорна" => 2, 
						"Нержавійка" => 3, 
						_ => 0, 
					}, typProfilBH: product_UtkaUP.TypProfilBH switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					}, typProfilB1H1: product_UtkaUP.TypProfilB1H1 switch
					{
						"S - 20" => 1, 
						"S - 30" => 2, 
						"Лист" => 3, 
						"Кутник" => 4, 
						_ => 0, 
					}, B: product_UtkaUP.B, H: product_UtkaUP.H, L: product_UtkaUP.L, C: product_UtkaUP.C, k: product_UtkaUP.K, k1: product_UtkaUP.K1, tovchynaMetalu: Convert.ToDouble(product_UtkaUP.ThicknessOfMetal), number: product_UtkaUP.Amount, polkaBH: product_UtkaUP.PolkaBH, polkaB1H1: product_UtkaUP.PolkaB1H1, vidbortovka: additionalLengthFromVidbortovka13, aisiType: product_UtkaUP.AisiType);
					spysannyaMaterialNames = UtkaUP.materialName;
				}
				break;
			case 'm':
				if (text == "Product_Custom" && product is Product_Custom product_Custom)
				{
					(string[], double[]) customProductMaterialNamesAndSpendings = CustomProductHelper.GetCustomProductMaterialNamesAndSpendings(product_Custom.Name);
					string[] item = customProductMaterialNamesAndSpendings.Item1;
					double[] item2 = customProductMaterialNamesAndSpendings.Item2;
					spysannyaMaterialArgumentsTwo = UnusualProduct.MaterialUnusualProduct(item, item2, product_Custom.Amount);
					spysannyaMaterialNames = UnusualProduct.materialName;
				}
				break;
			}
			break;
		case 35:
		{
			if (!(text == "Product_KlapanProtypogegnyjKPkEIS60"))
			{
				break;
			}
			Product_KlapanProtypogegnyjKPkEIS60 product_KlapanProtypogegnyjKPkEIS = product as Product_KlapanProtypogegnyjKPkEIS60;
			int kincevyk = 0;
			string kincevyk2 = product_KlapanProtypogegnyjKPkEIS.Kincevyk;
			string text2 = kincevyk2;
			if (!(text2 == "Є"))
			{
				if (text2 == "Немає")
				{
					kincevyk = 2;
				}
			}
			else
			{
				kincevyk = 1;
			}
			if (product_KlapanProtypogegnyjKPkEIS != null)
			{
				spysannyaMaterialArgumentsTwo = KlapanProtypogegnyjKPkEIS60.MaterialKlapanProtypogegnyjKPkEIS60(product_KlapanProtypogegnyjKPkEIS.D, product_KlapanProtypogegnyjKPkEIS.Amount, kincevyk);
				spysannyaMaterialNames = KlapanProtypogegnyjKPkEIS60.materialName;
			}
			break;
		}
		case 28:
		case 29:
		case 30:
		case 32:
		case 33:
		case 34:
			break;
		}
	}

	private Microsoft.Office.Interop.Excel.Range GetHeaderSpysannya(int id, string name, string amount)
	{
		myExcelWorkSheet2.Cells[82, "B"] = id;
		myExcelWorkSheet2.Cells[82, "C"] = name;
		myExcelWorkSheet2.Cells[82, "J"] = amount;
		return ((_Worksheet)myExcelWorkSheet2).get_Range((object)$"B{81}:K{84}", Type.Missing);
	}

	private Microsoft.Office.Interop.Excel.Range GetHeaderSpysannyaSum()
	{
		return ((_Worksheet)myExcelWorkSheet2).get_Range((object)$"B{90}:K{94}", Type.Missing);
	}

	private Microsoft.Office.Interop.Excel.Range GetFooterSpysannyaSum()
	{
		return ((_Worksheet)myExcelWorkSheet2).get_Range((object)$"B{97}:O{100}", Type.Missing);
	}

	private Microsoft.Office.Interop.Excel.Range GetLineSpysannya(string name, double[] arguments, bool isLast = false)
	{
		int num = ((!isLast) ? 85 : 86);
		myExcelWorkSheet2.Cells[num, "C"] = name;
		char c = ((arguments.Length == 6) ? 'D' : 'F');
		for (int i = 0; i < arguments.Length; i++)
		{
			if (Round(arguments[i]) != 0.0)
			{
				if (i != 1)
				{
					myExcelWorkSheet2.Cells[num, c.ToString()] = Round(arguments[i]);
				}
				else
				{
					myExcelWorkSheet2.Cells[num, c.ToString()] = arguments[i];
				}
			}
			else
			{
				myExcelWorkSheet2.Cells[num, c.ToString()] = "";
			}
			c = (char)(c + 1);
		}
		return ((_Worksheet)myExcelWorkSheet2).get_Range((object)$"B{num}:K{num}", Type.Missing);
	}

	private Microsoft.Office.Interop.Excel.Range GetLineSpysannyaSum(int id, string name, double[] arguments)
	{
		int num = 95;
		myExcelWorkSheet2.Cells[num, "B"] = id;
		myExcelWorkSheet2.Cells[num, "C"] = name;
		char c = 'F';
		for (int i = 0; i < 4; i++)
		{
			if (Round(arguments[i]) != 0.0)
			{
				if (i != 1)
				{
					myExcelWorkSheet2.Cells[num, c.ToString()] = Round(arguments[i]);
				}
				else
				{
					myExcelWorkSheet2.Cells[num, c.ToString()] = arguments[i];
				}
			}
			else
			{
				myExcelWorkSheet2.Cells[num, c.ToString()] = "";
			}
			c = (char)(c + 1);
		}
		return ((_Worksheet)myExcelWorkSheet2).get_Range((object)$"B{num}:K{num}", Type.Missing);
	}

	private static double[] GetOneDimentialArr(double[,] array, int index = 0, int innerArrLength = 6)
	{
		double[] array2 = new double[innerArrLength];
		for (int i = 0; i < array2.Length; i++)
		{
			array2[i] = array[index, i];
		}
		return array2;
	}

	private static double Round(double x)
	{
		double num = Math.Round(x, 2);
		if (num == 0.0)
		{
			num = ((Math.Round(x, 3) != 0.0) ? Math.Round(x, 3) : 0.0);
		}
		return num;
	}

	private static double[] SubArray(double[] data, int index, int length)
	{
		double[] array = new double[length];
		Array.Copy(data, index, array, 0, length);
		return array;
	}

	private double GetPovitroprovodyClearMaterialSpending(IEnumerable<IProduct> products)
	{
		double num = 0.0;
		foreach (IProduct product in products)
		{
			if (product is Product_RoundAirPK)
			{
				Product_RoundAirPK product_RoundAirPK = product as Product_RoundAirPK;
				num += Math.PI * (double)product_RoundAirPK.D * (double)product_RoundAirPK.L / 1000000.0 * (double)product_RoundAirPK.Amount;
			}
			if (product is Product_RoundAirPSK)
			{
				Product_RoundAirPSK product_RoundAirPSK = product as Product_RoundAirPSK;
				num += Math.PI * (double)product_RoundAirPSK.D * (double)product_RoundAirPSK.L / 1000000.0 * (double)product_RoundAirPSK.Amount;
			}
			if (product is Product_PovitroprovidPFP)
			{
				Product_PovitroprovidPFP product_PovitroprovidPFP = product as Product_PovitroprovidPFP;
				num += 2.0 * (double)(product_PovitroprovidPFP.B + product_PovitroprovidPFP.H) * (double)product_PovitroprovidPFP.L / 1000000.0 * (double)product_PovitroprovidPFP.Amount;
			}
		}
		return num;
	}

	private List<ProductCategory> GetCategorizedMaterials(IEnumerable<IProduct> products)
	{
		List<ProductCategory> list = new List<ProductCategory>();
		List<IProduct> list2 = Enumerable.ToList<IProduct>(Enumerable.Where<IProduct>(products, (Func<IProduct, bool>)((IProduct p) => p.IsPovitroprovid())));
		List<IProduct> list3 = Enumerable.ToList<IProduct>(Enumerable.Where<IProduct>((IEnumerable<IProduct>)list2, (Func<IProduct, bool>)((IProduct p) => p.GetProductMarkaStali() == 1)));
		List<IProduct> list4 = Enumerable.ToList<IProduct>(Enumerable.Where<IProduct>((IEnumerable<IProduct>)list2, (Func<IProduct, bool>)((IProduct p) => p.GetProductMarkaStali() == 2)));
		List<IProduct> list5 = Enumerable.ToList<IProduct>(Enumerable.Where<IProduct>((IEnumerable<IProduct>)list2, (Func<IProduct, bool>)((IProduct p) => p.GetProductMarkaStali() == 3)));
		List<IProduct> list6 = Enumerable.ToList<IProduct>(Enumerable.Where<IProduct>(products, (Func<IProduct, bool>)((IProduct p) => p.IsFasonka())));
		List<IProduct> list7 = Enumerable.ToList<IProduct>(Enumerable.Where<IProduct>((IEnumerable<IProduct>)list6, (Func<IProduct, bool>)((IProduct p) => p.GetProductMarkaStali() == 1)));
		List<IProduct> list8 = Enumerable.ToList<IProduct>(Enumerable.Where<IProduct>((IEnumerable<IProduct>)list6, (Func<IProduct, bool>)((IProduct p) => p.GetProductMarkaStali() == 2)));
		List<IProduct> list9 = Enumerable.ToList<IProduct>(Enumerable.Where<IProduct>((IEnumerable<IProduct>)list6, (Func<IProduct, bool>)((IProduct p) => p.GetProductMarkaStali() == 3)));
		IEnumerable<IProduct> products2 = Enumerable.Where<IProduct>((IEnumerable<IProduct>)list3, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 0.5));
		double povitroprovodyClearMaterialSpending = GetPovitroprovodyClearMaterialSpending(products2);
		List<Material> materialListForProducts = GetMaterialListForProducts(products2);
		IEnumerable<IProduct> products3 = Enumerable.Where<IProduct>((IEnumerable<IProduct>)list3, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 0.65));
		double povitroprovodyClearMaterialSpending2 = GetPovitroprovodyClearMaterialSpending(products3);
		List<Material> materialListForProducts2 = GetMaterialListForProducts(products3);
		IEnumerable<IProduct> products4 = Enumerable.Where<IProduct>((IEnumerable<IProduct>)list3, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 0.68));
		double povitroprovodyClearMaterialSpending3 = GetPovitroprovodyClearMaterialSpending(products4);
		List<Material> materialListForProducts3 = GetMaterialListForProducts(products4);
		IEnumerable<IProduct> products5 = Enumerable.Where<IProduct>((IEnumerable<IProduct>)list3, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 0.7));
		double povitroprovodyClearMaterialSpending4 = GetPovitroprovodyClearMaterialSpending(products5);
		List<Material> materialListForProducts4 = GetMaterialListForProducts(products5);
		IEnumerable<IProduct> products6 = Enumerable.Where<IProduct>((IEnumerable<IProduct>)list3, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 0.9));
		double povitroprovodyClearMaterialSpending5 = GetPovitroprovodyClearMaterialSpending(products6);
		List<Material> materialListForProducts5 = GetMaterialListForProducts(products6);
		IEnumerable<IProduct> products7 = Enumerable.Where<IProduct>((IEnumerable<IProduct>)list3, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 1.0));
		double povitroprovodyClearMaterialSpending6 = GetPovitroprovodyClearMaterialSpending(products7);
		List<Material> materialListForProducts6 = GetMaterialListForProducts(products7);
		IEnumerable<IProduct> products8 = Enumerable.Where<IProduct>((IEnumerable<IProduct>)list3, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 1.2));
		double povitroprovodyClearMaterialSpending7 = GetPovitroprovodyClearMaterialSpending(products8);
		List<Material> materialListForProducts7 = GetMaterialListForProducts(products8);
		IEnumerable<IProduct> products9 = Enumerable.Where<IProduct>((IEnumerable<IProduct>)list4, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 0.5));
		double povitroprovodyClearMaterialSpending8 = GetPovitroprovodyClearMaterialSpending(products9);
		List<Material> materialListForProducts8 = GetMaterialListForProducts(products9);
		IEnumerable<IProduct> products10 = Enumerable.Where<IProduct>((IEnumerable<IProduct>)list4, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 0.8));
		double povitroprovodyClearMaterialSpending9 = GetPovitroprovodyClearMaterialSpending(products10);
		List<Material> materialListForProducts9 = GetMaterialListForProducts(products10);
		IEnumerable<IProduct> products11 = Enumerable.Where<IProduct>((IEnumerable<IProduct>)list4, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 1.0));
		double povitroprovodyClearMaterialSpending10 = GetPovitroprovodyClearMaterialSpending(products11);
		List<Material> materialListForProducts10 = GetMaterialListForProducts(products11);
		IEnumerable<IProduct> products12 = Enumerable.Where<IProduct>((IEnumerable<IProduct>)list4, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 1.2));
		double povitroprovodyClearMaterialSpending11 = GetPovitroprovodyClearMaterialSpending(products12);
		List<Material> materialListForProducts11 = GetMaterialListForProducts(products12);
		IEnumerable<IProduct> products13 = Enumerable.Where<IProduct>((IEnumerable<IProduct>)list4, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 1.5));
		double povitroprovodyClearMaterialSpending12 = GetPovitroprovodyClearMaterialSpending(products13);
		List<Material> materialListForProducts12 = GetMaterialListForProducts(products13);
		IEnumerable<IProduct> products14 = Enumerable.Where<IProduct>((IEnumerable<IProduct>)list5, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 0.5));
		double povitroprovodyClearMaterialSpending13 = GetPovitroprovodyClearMaterialSpending(products14);
		List<Material> materialListForProducts13 = GetMaterialListForProducts(products14);
		IEnumerable<IProduct> products15 = Enumerable.Where<IProduct>((IEnumerable<IProduct>)list5, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 0.8));
		double povitroprovodyClearMaterialSpending14 = GetPovitroprovodyClearMaterialSpending(products15);
		List<Material> materialListForProducts14 = GetMaterialListForProducts(products15);
		IEnumerable<IProduct> products16 = Enumerable.Where<IProduct>((IEnumerable<IProduct>)list5, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 1.0));
		double povitroprovodyClearMaterialSpending15 = GetPovitroprovodyClearMaterialSpending(products16);
		List<Material> materialListForProducts15 = GetMaterialListForProducts(products16);
		IEnumerable<IProduct> products17 = Enumerable.Where<IProduct>((IEnumerable<IProduct>)list5, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 1.2));
		double povitroprovodyClearMaterialSpending16 = GetPovitroprovodyClearMaterialSpending(products17);
		List<Material> materialListForProducts16 = GetMaterialListForProducts(products17);
		IEnumerable<IProduct> products18 = Enumerable.Where<IProduct>((IEnumerable<IProduct>)list5, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 1.5));
		double povitroprovodyClearMaterialSpending17 = GetPovitroprovodyClearMaterialSpending(products18);
		List<Material> materialListForProducts17 = GetMaterialListForProducts(products18);
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts))
		{
			list.Add(new ProductCategory("Повітропровід з оц сталі 0,5 мм", materialListForProducts, povitroprovodyClearMaterialSpending));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts2))
		{
			list.Add(new ProductCategory("Повітропровід з оц сталі 0,65 мм", materialListForProducts2, povitroprovodyClearMaterialSpending2));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts3))
		{
			list.Add(new ProductCategory("Повітропровід з оц сталі 0,68 мм", materialListForProducts3, povitroprovodyClearMaterialSpending3));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts4))
		{
			list.Add(new ProductCategory("Повітропровід з оц сталі 0,7 мм", materialListForProducts4, povitroprovodyClearMaterialSpending4));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts5))
		{
			list.Add(new ProductCategory("Повітропровід з оц сталі 0,9 мм", materialListForProducts5, povitroprovodyClearMaterialSpending5));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts6))
		{
			list.Add(new ProductCategory("Повітропровід з оц сталі 1,0 мм", materialListForProducts6, povitroprovodyClearMaterialSpending6));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts7))
		{
			list.Add(new ProductCategory("Повітропровід з оц сталі 1,2 мм", materialListForProducts7, povitroprovodyClearMaterialSpending7));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts8))
		{
			list.Add(new ProductCategory("Повітропровід з чорн сталі 0,5 мм", materialListForProducts8, povitroprovodyClearMaterialSpending8));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts9))
		{
			list.Add(new ProductCategory("Повітропровід з чорн сталі 0,8 мм", materialListForProducts9, povitroprovodyClearMaterialSpending9));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts10))
		{
			list.Add(new ProductCategory("Повітропровід з чорн сталі 1,0 мм", materialListForProducts10, povitroprovodyClearMaterialSpending10));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts11))
		{
			list.Add(new ProductCategory("Повітропровід з чорн сталі 1,2 мм", materialListForProducts11, povitroprovodyClearMaterialSpending11));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts12))
		{
			list.Add(new ProductCategory("Повітропровід з чорн сталі 1,5 мм", materialListForProducts12, povitroprovodyClearMaterialSpending12));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts13))
		{
			list.Add(new ProductCategory("Повітропровід з нерж сталі 0,5 мм", materialListForProducts13, povitroprovodyClearMaterialSpending13));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts14))
		{
			list.Add(new ProductCategory("Повітропровід з нерж сталі 0,8 мм", materialListForProducts14, povitroprovodyClearMaterialSpending14));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts15))
		{
			list.Add(new ProductCategory("Повітропровід з нерж сталі 1,0 мм", materialListForProducts15, povitroprovodyClearMaterialSpending15));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts16))
		{
			list.Add(new ProductCategory("Повітропровід з нерж сталі 1,2 мм", materialListForProducts16, povitroprovodyClearMaterialSpending16));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts17))
		{
			list.Add(new ProductCategory("Повітропровід з нерж сталі 1,5 мм", materialListForProducts17, povitroprovodyClearMaterialSpending17));
		}
		List<Material> materialListForProducts18 = GetMaterialListForProducts(Enumerable.Where<IProduct>((IEnumerable<IProduct>)list7, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 0.5)));
		List<Material> materialListForProducts19 = GetMaterialListForProducts(Enumerable.Where<IProduct>((IEnumerable<IProduct>)list7, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 0.65)));
		List<Material> materialListForProducts20 = GetMaterialListForProducts(Enumerable.Where<IProduct>((IEnumerable<IProduct>)list7, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 0.68)));
		List<Material> materialListForProducts21 = GetMaterialListForProducts(Enumerable.Where<IProduct>((IEnumerable<IProduct>)list7, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 0.7)));
		List<Material> materialListForProducts22 = GetMaterialListForProducts(Enumerable.Where<IProduct>((IEnumerable<IProduct>)list7, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 0.9)));
		List<Material> materialListForProducts23 = GetMaterialListForProducts(Enumerable.Where<IProduct>((IEnumerable<IProduct>)list7, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 1.0)));
		List<Material> materialListForProducts24 = GetMaterialListForProducts(Enumerable.Where<IProduct>((IEnumerable<IProduct>)list7, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 1.2)));
		List<Material> materialListForProducts25 = GetMaterialListForProducts(Enumerable.Where<IProduct>((IEnumerable<IProduct>)list8, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 0.5)));
		List<Material> materialListForProducts26 = GetMaterialListForProducts(Enumerable.Where<IProduct>((IEnumerable<IProduct>)list8, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 0.8)));
		List<Material> materialListForProducts27 = GetMaterialListForProducts(Enumerable.Where<IProduct>((IEnumerable<IProduct>)list8, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 1.0)));
		List<Material> materialListForProducts28 = GetMaterialListForProducts(Enumerable.Where<IProduct>((IEnumerable<IProduct>)list8, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 1.2)));
		List<Material> materialListForProducts29 = GetMaterialListForProducts(Enumerable.Where<IProduct>((IEnumerable<IProduct>)list8, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 1.5)));
		List<Material> materialListForProducts30 = GetMaterialListForProducts(Enumerable.Where<IProduct>((IEnumerable<IProduct>)list9, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 0.5)));
		List<Material> materialListForProducts31 = GetMaterialListForProducts(Enumerable.Where<IProduct>((IEnumerable<IProduct>)list9, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 0.8)));
		List<Material> materialListForProducts32 = GetMaterialListForProducts(Enumerable.Where<IProduct>((IEnumerable<IProduct>)list9, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 1.0)));
		List<Material> materialListForProducts33 = GetMaterialListForProducts(Enumerable.Where<IProduct>((IEnumerable<IProduct>)list9, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 1.2)));
		List<Material> materialListForProducts34 = GetMaterialListForProducts(Enumerable.Where<IProduct>((IEnumerable<IProduct>)list9, (Func<IProduct, bool>)((IProduct p) => p.TovchynaMetalu == 1.5)));
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts18))
		{
			list.Add(new ProductCategory("Фасонні елементи з оц сталі 0,5 мм", materialListForProducts18));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts19))
		{
			list.Add(new ProductCategory("Фасонні елементи з оц сталі 0,65 мм", materialListForProducts19));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts20))
		{
			list.Add(new ProductCategory("Фасонні елементи з оц сталі 0,68 мм", materialListForProducts20));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts21))
		{
			list.Add(new ProductCategory("Фасонні елементи з оц сталі 0,7 мм", materialListForProducts21));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts22))
		{
			list.Add(new ProductCategory("Фасонні елементи з оц сталі 0,9 мм", materialListForProducts22));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts23))
		{
			list.Add(new ProductCategory("Фасонні елементи з оц сталі 1,0 мм", materialListForProducts23));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts24))
		{
			list.Add(new ProductCategory("Фасонні елементи з оц сталі 1,2 мм", materialListForProducts24));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts25))
		{
			list.Add(new ProductCategory("Фасонні елементи з чорн сталі 0,5 мм", materialListForProducts25));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts26))
		{
			list.Add(new ProductCategory("Фасонні елементи з чорн сталі 0,8 мм", materialListForProducts26));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts27))
		{
			list.Add(new ProductCategory("Фасонні елементи з чорн сталі 1,0 мм", materialListForProducts27));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts28))
		{
			list.Add(new ProductCategory("Фасонні елементи з чорн сталі 1,2 мм", materialListForProducts28));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts29))
		{
			list.Add(new ProductCategory("Фасонні елементи з чорн сталі 1,5 мм", materialListForProducts29));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts30))
		{
			list.Add(new ProductCategory("Фасонні елементи з нерж сталі 0,5 мм", materialListForProducts30));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts31))
		{
			list.Add(new ProductCategory("Фасонні елементи з нерж сталі 0,8 мм", materialListForProducts31));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts32))
		{
			list.Add(new ProductCategory("Фасонні елементи з нерж сталі 1,0 мм", materialListForProducts32));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts33))
		{
			list.Add(new ProductCategory("Фасонні елементи з нерж сталі 1,2 мм", materialListForProducts33));
		}
		if (Enumerable.Any<Material>((IEnumerable<Material>)materialListForProducts34))
		{
			list.Add(new ProductCategory("Фасонні елементи з нерж сталі 1,5 мм", materialListForProducts34));
		}
		return list;
	}

	private List<Material> GetMaterialListForProducts(IEnumerable<IProduct> products)
	{
		List<Material> list = new List<Material>();
		foreach (IProduct product in products)
		{
			GetMaterialNamesAndArgiments(product);
			if (!(product.Section != "Нестандартний виріб"))
			{
				continue;
			}
			if (spysannyaMaterialNames.Length == 1)
			{
				double[] array = SubArray(spysannyaMaterialArgumentsOne, 2, 4);
				if (list.Exists((Material m) => m.Name == spysannyaMaterialNames[0]))
				{
					Material material = Enumerable.FirstOrDefault<Material>(Enumerable.Where<Material>((IEnumerable<Material>)list, (Func<Material, bool>)((Material m) => m.Name == spysannyaMaterialNames[0])));
					for (int j = 0; j < array.Length; j++)
					{
						material.Values[j] += array[j];
					}
					material.Amount++;
				}
				else
				{
					list.Add(new Material(spysannyaMaterialNames[0], array));
				}
				continue;
			}
			int i;
			for (i = 0; i < spysannyaMaterialNames.Length; i++)
			{
				if (!(spysannyaMaterialNames[i] != ""))
				{
					continue;
				}
				double[] data = ((spysannyaMaterialArgumentsTwo != null) ? GetOneDimentialArr(spysannyaMaterialArgumentsTwo, i) : spysannyaMaterialArgumentsOne);
				double[] array2 = SubArray(data, 2, 4);
				if (list.Exists((Material m) => m.Name == spysannyaMaterialNames[i]))
				{
					Material material2 = Enumerable.FirstOrDefault<Material>(Enumerable.Where<Material>((IEnumerable<Material>)list, (Func<Material, bool>)((Material m) => m.Name == spysannyaMaterialNames[i])));
					for (int k = 0; k < array2.Length; k++)
					{
						material2.Values[k] += array2[k];
					}
					material2.Amount++;
				}
				else
				{
					list.Add(new Material(spysannyaMaterialNames[i], array2));
				}
			}
		}
		return list;
	}

	private string CreateFolderByPath(string folderName, string defaultFolderPath = null)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).Filter = "Directory | directory";
		((FileDialog)val).FileName = folderName;
		bool flag = !string.IsNullOrEmpty(defaultFolderPath);
		if (flag || ((CommonDialog)val).ShowDialog().GetValueOrDefault())
		{
			if (flag)
			{
				((FileDialog)val).FileName = defaultFolderPath + "\\" + folderName;
			}
			if (!Directory.Exists(((FileDialog)val).FileName))
			{
				Directory.CreateDirectory(((FileDialog)val).FileName);
			}
			return ((FileDialog)val).FileName;
		}
		return null;
	}

	private Microsoft.Office.Interop.Excel.Range GetLineFlight(string name, double amount, string code1)
	{
		int num = 1;
		myExcelWorkSheet2.Cells[num, "C"] = name;
		myExcelWorkSheet2.Cells[num, "F"] = amount;
		myExcelWorkSheet2.Cells[num, "I"] = code1;
		return ((_Worksheet)myExcelWorkSheet2).get_Range((object)$"A{num}:K{num}", Type.Missing);
	}

	private string GetPropertyValueOrDefault(IProduct item, string property)
	{
		string result = "";
		PropertyInfo property2 = item.GetType().GetProperty(property);
		if (property2 != null)
		{
			result = property2.GetValue(item)?.ToString();
		}
		return result;
	}

	private string CustomReplaceTypeVidbort(string type, string vidbortovka)
	{
		string[] array = vidbortovka.Split(new char[1] { '-' });
		string[] array2 = type.Split(new char[1] { '-' });
		if (array2[0].Contains("чисто"))
		{
			array2[0] = array[0];
		}
		type = array2[0];
		for (int i = 1; i < array2.Length; i++)
		{
			if (array2[i].Contains("чисто"))
			{
				array2[i] = array[i];
			}
			type = type + "- " + array2[i];
		}
		return type;
	}

	private string GetTypeOfProduct(IProduct item, string vidbortovka, string prymitka)
	{
		string empty = string.Empty;
		empty = item.GetType()?.GetProperty("Type")?.GetValue(item)?.ToString() ?? "";
		if (empty == "")
		{
			PropertyInfo[] array = item.GetType()?.GetProperties();
			PropertyInfo[] array2 = array;
			foreach (PropertyInfo propertyInfo in array2)
			{
				if (propertyInfo.Name.StartsWith("Type") && propertyInfo.Name != "TypeOfProduct")
				{
					empty = empty + propertyInfo.GetValue(item).ToString() + " - ";
				}
			}
			if (empty != "")
			{
				empty = empty.Substring(0, empty.Length - " - ".Length);
			}
		}
		if (!string.IsNullOrEmpty(empty) && empty.Contains("чисто") && !string.IsNullOrEmpty(vidbortovka))
		{
			empty = CustomReplaceTypeVidbort(empty, vidbortovka);
		}
		if (!string.IsNullOrEmpty(empty))
		{
			empty = CustomReplaceTypeShort(empty);
		}
		if (!string.IsNullOrEmpty(empty))
		{
			switch (empty)
			{
			case "фл":
			case "фл - фл":
			case "фл - фл - фл":
			case "фл - фл - фл - фл":
				if (prymitka.Contains("S") && !item.Name.Contains("Перехідник ПОЛП-К") && !item.Name.Contains("Перехідник ПАП-К") && !item.Name.Contains("Перехідник ПОП-К") && !item.Name.Contains("Перехідник ПОПП-К") && !item.Name.Contains("Перехідник ПСП-К"))
				{
					empty = "";
				}
				break;
			}
			switch (empty)
			{
			default:
				if (!(empty == "мінус - мінус - мінус - мінус"))
				{
					break;
				}
				goto case "мінус";
			case "мінус":
			case "мінус - мінус":
			case "мінус - мінус - мінус":
				if (item.Name.Contains("Хрестовина ХК") || item.Name.Contains("Хрестовина ХРК") || item.Name.Contains("Накладка НКП") || item.Name.Contains("Обвід ОК") || item.Name.Contains("Перехідник ПАК") || item.Name.Contains("Перехідник ПОК") || item.Name.Contains("Перехідник ПЦК") || item.Name.Contains("Повітропровід ПК") || item.Name.Contains("Трійник ТРК") || item.Name.Contains("Трійник ТШК") || item.Name.Contains("Утка УАК") || item.Name.Contains("Утка УК") || item.Name.Contains("Відвід ВК") || item.Name.Contains("Накладка НК") || item.Name.Contains("Заглушка ЗК") || item.Name.Contains("Зонт ЗВК") || item.Name.Contains("Трійник ТОШК") || item.Name.Contains("Трійник ТОАШК"))
				{
					empty = "";
				}
				break;
			}
		}
		return empty;
	}

	private void ReplaceFiles(string specifiedPath, string folderName)
	{
		string path = specifiedPath.Substring(0, specifiedPath.Length - folderName.Length - 1);
		string[] files = Directory.GetFiles(path);
		string[] array = files;
		foreach (string path2 in array)
		{
			File.Delete(path2);
		}
		string[] files2 = Directory.GetFiles(specifiedPath);
		string[] array2 = files2;
		foreach (string text in array2)
		{
			List<string> list = new List<string>(text.Split(new char[1] { '\\' }));
			list.RemoveAt(list.Count - 2);
			string destFileName = Enumerable.Aggregate<string>((IEnumerable<string>)list, (Func<string, string, string>)((string i, string j) => i + "\\" + j));
			File.Move(text, destFileName);
		}
		Directory.Delete(specifiedPath);
	}

	private string ReplaceInvalidFileNameCharacters(string fileName)
	{
		string text = "/*?\"<>|";
		string text2 = text;
		foreach (char c in text2)
		{
			if (Enumerable.Contains<char>((IEnumerable<char>)fileName, c))
			{
				fileName = fileName.Replace(c, '_');
			}
		}
		return fileName;
	}

	private string CustomReplaceTypeShort(string type)
	{
		string[] array = type.Split(new char[1] { '-' });
		type = "";
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = array[i].Trim();
			if (array[i].Contains("фланець"))
			{
				array[i] = "фл";
			}
			if (array[i].Contains("заглушка"))
			{
				array[i] = "загл";
			}
			type += array[i];
			if (i != array.Length - 1)
			{
				type += " - ";
			}
		}
		return type;
	}

	private string GetPrymitka(IProduct item)
	{
		Product_VidvidVK product_VidvidVK = item as Product_VidvidVK;
		string text = "";
		string text2 = "";
		if (product_VidvidVK != null && product_VidvidVK.R != 1.0)
		{
			text = (string.IsNullOrEmpty(item.Prymitka) ? ("R = " + product_VidvidVK.R + "D") : (Environment.NewLine + "R = " + product_VidvidVK.R + "D"));
		}
		string text3 = GetPropertyValueOrDefault(item, "ProfilType");
		string propertyValueOrDefault = GetPropertyValueOrDefault(item, "ProfilType1");
		string text4 = null;
		string text5 = null;
		if (string.IsNullOrEmpty(text3) && string.IsNullOrEmpty(propertyValueOrDefault))
		{
			text3 = GetPropertyValueOrDefault(item, "TypProfilBH");
			propertyValueOrDefault = GetPropertyValueOrDefault(item, "TypProfilB1H1");
			text4 = GetPropertyValueOrDefault(item, "TypProfilB2H2");
			text5 = GetPropertyValueOrDefault(item, "TypProfilB3H3");
		}
		if (string.IsNullOrEmpty(text3))
		{
			text3 = GetPropertyValueOrDefault(item, "TypProfil");
		}
		if (string.IsNullOrEmpty(text3) && string.IsNullOrEmpty(propertyValueOrDefault))
		{
			text3 = GetPropertyValueOrDefault(item, "TypProfile");
			propertyValueOrDefault = GetPropertyValueOrDefault(item, "TypProfile1");
		}
		if (string.IsNullOrEmpty(text3))
		{
			text3 = GetPropertyValueOrDefault(item, "ProfilTypeBH");
		}
		if (string.IsNullOrEmpty(propertyValueOrDefault))
		{
			propertyValueOrDefault = GetPropertyValueOrDefault(item, "ProfilTypeB1H1");
		}
		if (string.IsNullOrEmpty(text4))
		{
			text4 = GetPropertyValueOrDefault(item, "ProfilTypeB2H2");
		}
		if (string.IsNullOrEmpty(text3))
		{
			text3 = GetPropertyValueOrDefault(item, "TypeMaterialD");
		}
		if (string.IsNullOrEmpty(text3))
		{
			text3 = GetPropertyValueOrDefault(item, "TypMaterialD");
		}
		if (string.IsNullOrEmpty(propertyValueOrDefault))
		{
			propertyValueOrDefault = GetPropertyValueOrDefault(item, "TypMaterialD1");
		}
		if (string.IsNullOrEmpty(text4))
		{
			text4 = GetPropertyValueOrDefault(item, "TypMaterialD2");
		}
		if (string.IsNullOrEmpty(text5))
		{
			text5 = GetPropertyValueOrDefault(item, "TypMaterialD3");
		}
		if (string.IsNullOrEmpty(propertyValueOrDefault))
		{
			propertyValueOrDefault = GetPropertyValueOrDefault(item, "TypProfilD");
		}
		if (string.IsNullOrEmpty(text3))
		{
			text3 = GetPropertyValueOrDefault(item, "TypMaterialInput");
		}
		if (string.IsNullOrEmpty(propertyValueOrDefault))
		{
			propertyValueOrDefault = GetPropertyValueOrDefault(item, "TypMaterialOutput");
		}
		if (string.IsNullOrEmpty(text3))
		{
			text3 = GetPropertyValueOrDefault(item, "ProfileType");
		}
		if (string.IsNullOrEmpty(text3))
		{
			text3 = GetPropertyValueOrDefault(item, "TypMaterial");
		}
		if (string.IsNullOrEmpty(propertyValueOrDefault))
		{
			propertyValueOrDefault = GetPropertyValueOrDefault(item, "TypMaterialOutLeft");
		}
		if (string.IsNullOrEmpty(text4))
		{
			text4 = GetPropertyValueOrDefault(item, "TypMaterialOutRight");
		}
		if (item is Product_VrizkaVPK)
		{
			if (!text3.Contains("S"))
			{
				text3 = "";
			}
			if (string.IsNullOrEmpty(text4))
			{
				text4 = GetPropertyValueOrDefault(item, "TypMaterialD");
			}
		}
		if (string.IsNullOrEmpty(text3))
		{
			text3 = GetPropertyValueOrDefault(item, "TypMaterialFlanets");
		}
		if (!string.IsNullOrEmpty(text3) || !string.IsNullOrEmpty(propertyValueOrDefault) || !string.IsNullOrEmpty(text4) || !string.IsNullOrEmpty(text5))
		{
			if (!string.IsNullOrEmpty(propertyValueOrDefault))
			{
				text3 = (string.IsNullOrEmpty(text3) ? propertyValueOrDefault : (text3 + "/" + propertyValueOrDefault));
			}
			if (!string.IsNullOrEmpty(text4))
			{
				text3 = (string.IsNullOrEmpty(text3) ? text4 : (text3 + "/" + text4));
			}
			if (!string.IsNullOrEmpty(text5))
			{
				text3 = (string.IsNullOrEmpty(text3) ? text5 : (text3 + "/" + text5));
			}
			text2 = (string.IsNullOrEmpty(item.Prymitka) ? text3 : (Environment.NewLine + text3));
			string propertyValueOrDefault2 = GetPropertyValueOrDefault(item, "Polka");
			if (!string.IsNullOrEmpty(propertyValueOrDefault2) && propertyValueOrDefault2 != "0")
			{
				text2 = text2 + ", полка = " + propertyValueOrDefault2;
			}
		}
		if (item is Product_KlapanDroselnyjKDK)
		{
			Product_KlapanDroselnyjKDK product_KlapanDroselnyjKDK = (Product_KlapanDroselnyjKDK)item;
			if (!string.IsNullOrEmpty(product_KlapanDroselnyjKDK.Servopryvid))
			{
				text = (string.IsNullOrEmpty(item.Prymitka) ? product_KlapanDroselnyjKDK.Servopryvid : (Environment.NewLine + product_KlapanDroselnyjKDK.Servopryvid));
			}
		}
		if (item is Product_KlapanDroselnyjKDP)
		{
			Product_KlapanDroselnyjKDP product_KlapanDroselnyjKDP = (Product_KlapanDroselnyjKDP)item;
			if (!string.IsNullOrEmpty(product_KlapanDroselnyjKDP.Servopryvid))
			{
				text = (string.IsNullOrEmpty(item.Prymitka) ? product_KlapanDroselnyjKDP.Servopryvid : (Environment.NewLine + product_KlapanDroselnyjKDP.Servopryvid));
			}
		}
		if (item is Product_KlapanGaluzijnjyKGP)
		{
			Product_KlapanGaluzijnjyKGP product_KlapanGaluzijnjyKGP = (Product_KlapanGaluzijnjyKGP)item;
			if (!string.IsNullOrEmpty(product_KlapanGaluzijnjyKGP.Servopryvid))
			{
				text = (string.IsNullOrEmpty(item.Prymitka) ? product_KlapanGaluzijnjyKGP.Servopryvid : (Environment.NewLine + product_KlapanGaluzijnjyKGP.Servopryvid));
			}
		}
		if (item is Product_KlapanProtypogegnyjKPkEIS60e product_KlapanProtypogegnyjKPkEIS60e)
		{
			string text6 = product_KlapanProtypogegnyjKPkEIS60e.Servopryvid.Substring(product_KlapanProtypogegnyjKPkEIS60e.Servopryvid.IndexOf(" ") + 1);
			text = (string.IsNullOrEmpty(item.Prymitka) ? text6 : (Environment.NewLine + text6));
		}
		if (item is Product_KlapanProtypogegnyjKPpEIS60e product_KlapanProtypogegnyjKPpEIS60e)
		{
			string text7 = product_KlapanProtypogegnyjKPpEIS60e.Servopryvid.Substring(product_KlapanProtypogegnyjKPpEIS60e.Servopryvid.IndexOf(" ") + 1);
			text = (string.IsNullOrEmpty(item.Prymitka) ? text7 : (Environment.NewLine + text7));
		}
		if (item is Product_KlapanProtypogegnyjKPkC { Servopryvid: var servopryvid })
		{
			text = (string.IsNullOrEmpty(item.Prymitka) ? servopryvid : (Environment.NewLine + servopryvid));
		}
		if (item is Product_KlapanProtypogegnyjKPpS { Servopryvid: var servopryvid2 })
		{
			text = (string.IsNullOrEmpty(item.Prymitka) ? servopryvid2 : (Environment.NewLine + servopryvid2));
		}
		if (item is Product_KlapanProtypogegnyjKPkEIS60 product_KlapanProtypogegnyjKPkEIS)
		{
			string text8 = product_KlapanProtypogegnyjKPkEIS.Kincevyk.Substring(product_KlapanProtypogegnyjKPkEIS.Kincevyk.IndexOf(" ") + 1);
			text = (string.IsNullOrEmpty(item.Prymitka) ? ("Кінцевик = " + text8) : (Environment.NewLine + "Кінцевик = " + text8));
		}
		if (item is Product_KlapanProtypogegnyjKPpEIS60m product_KlapanProtypogegnyjKPpEIS60m)
		{
			string text9 = product_KlapanProtypogegnyjKPpEIS60m.Kincevyk.Substring(product_KlapanProtypogegnyjKPpEIS60m.Kincevyk.IndexOf(" ") + 1);
			text = (string.IsNullOrEmpty(item.Prymitka) ? ("Кінцевик = " + text9) : (Environment.NewLine + "Кінцевик = " + text9));
		}
		if (item is Product_KlapanProtypogegnyjKPkM product_KlapanProtypogegnyjKPkM)
		{
			string text10 = product_KlapanProtypogegnyjKPkM.Kincevyk.Substring(product_KlapanProtypogegnyjKPkM.Kincevyk.IndexOf(" ") + 1);
			text = (string.IsNullOrEmpty(item.Prymitka) ? ("Кінцевик = " + text10) : (Environment.NewLine + "Кінцевик = " + text10));
		}
		if (item is Product_KlapanProtypogegnyjKPpM product_KlapanProtypogegnyjKPpM)
		{
			string text11 = product_KlapanProtypogegnyjKPpM.Kincevyk.Substring(product_KlapanProtypogegnyjKPpM.Kincevyk.IndexOf(" ") + 1);
			text = (string.IsNullOrEmpty(item.Prymitka) ? ("Кінцевик = " + text11) : (Environment.NewLine + "Кінцевик = " + text11));
		}
		return item.Prymitka + text + (string.IsNullOrEmpty(text) ? text2 : (Environment.NewLine + text2));
	}
}
