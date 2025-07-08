using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TEZ_Project.Common.Data;
using TEZ_Project.Common.Data.Entities;

namespace TEZ_Project.Common.Helpers;

public static class CustomProductHelper
{
	public static async Task<ICollection<CustomProductModel>> GetAllCustomProductsAsync()
	{
		using UnitOfWork unit = new UnitOfWork();
		var products = await unit.CustomProductRepository.GetAllAsync();
		return products.Select(p => new CustomProductModel
		{
			CustomProductId = p.Id,
			Name = p.Name,
			CreatedBy = p.CreatedBy,
			LastUpdatedBy = p.LastUpdatedBy,
			LastUpdatedDate = p.LastUpdatedDate
		}).ToList();
	}

	public static void AddNewCustomProduct(string name, string userName, int[] constIds, double[] meterialSpendings)
	{
		if (constIds.Length != meterialSpendings.Length)
		{
			return;
		}
		using UnitOfWork unitOfWork = new UnitOfWork();
		CustomProduct customProduct = new CustomProduct
		{
			Name = name,
			LastUpdatedDate = DateTime.Now,
			CreatedBy = userName,
			LastUpdatedBy = userName,
			CustomProductConsts = new List<CustomProductConsts>()
		};
		for (int i = 0; i < constIds.Length; i++)
		{
			customProduct.CustomProductConsts.Add(new CustomProductConsts
			{
				ConstId = constIds[i],
				MaterialSpending = meterialSpendings[i]
			});
		}
		unitOfWork.CustomProductRepository.Insert(customProduct);
		unitOfWork.Save();
	}

	public static void UpdateCustomProduct(string key, string name, string userName, int[] constIds, double[] meterialSpendings)
	{
		if (constIds.Length != meterialSpendings.Length)
		{
			return;
		}
		using UnitOfWork unitOfWork = new UnitOfWork();
		CustomProduct byName = unitOfWork.CustomProductRepository.GetByName(key);
		if (byName == null)
		{
			return;
		}
		byName.Name = name;
		byName.LastUpdatedBy = userName;
		byName.LastUpdatedDate = DateTime.Now;
		List<CustomProductConsts> customProductConsts = Enumerable.ToList<CustomProductConsts>(Enumerable.Where<CustomProductConsts>((IEnumerable<CustomProductConsts>)byName.CustomProductConsts, (Func<CustomProductConsts, bool>)((CustomProductConsts c) => !Enumerable.Contains<int>((IEnumerable<int>)constIds, c.ConstId))));
		unitOfWork.CustomProductRepository.DeleteCustomProductConsts(customProductConsts);
		foreach (CustomProductConsts customProductConst in byName.CustomProductConsts)
		{
			int num = Array.IndexOf(constIds, customProductConst.ConstId);
			if (num != -1)
			{
				customProductConst.MaterialSpending = meterialSpendings[num];
			}
		}
		List<int> list = Enumerable.ToList<int>(Enumerable.Select<CustomProductConsts, int>((IEnumerable<CustomProductConsts>)byName.CustomProductConsts, (Func<CustomProductConsts, int>)((CustomProductConsts x) => x.ConstId)));
		for (int i = 0; i < constIds.Length; i++)
		{
			if (!list.Contains(constIds[i]))
			{
				byName.CustomProductConsts.Add(new CustomProductConsts
				{
					ConstId = constIds[i],
					MaterialSpending = meterialSpendings[i]
				});
			}
		}
		unitOfWork.Save();
	}

	public static void DeleteCustomProduct(int id)
	{
		using UnitOfWork unitOfWork = new UnitOfWork();
		unitOfWork.CustomProductRepository.DeleteById(id);
		unitOfWork.Save();
	}

	public static List<string> GetCustomProductNames()
	{
		using UnitOfWork unitOfWork = new UnitOfWork();
		return unitOfWork.CustomProductRepository.GetAllNames().ToList();
	}

	public static (string[], double[]) GetCustomProductMaterialNamesAndSpendings(string customProductName)
	{
		List<string> list = new List<string>();
		List<double> list2 = new List<double>();
		using (UnitOfWork unitOfWork = new UnitOfWork())
		{
			CustomProduct byName = unitOfWork.CustomProductRepository.GetByName(customProductName);
			if (byName?.CustomProductConsts != null)
			{
				foreach (CustomProductConsts customProductConst in byName.CustomProductConsts)
				{
					list.Add(customProductConst.Const.MaterialName);
					list2.Add(customProductConst.MaterialSpending);
				}
			}
		}
		return (list.ToArray(), list2.ToArray());
	}

	public static List<BaseNameDto> GetConstsBaseInfo()
	{
		using UnitOfWork unitOfWork = new UnitOfWork();
		IEnumerable<Const> all = unitOfWork.ConstRepository.GetAll();
		return Enumerable.ToList<BaseNameDto>(Enumerable.Select<Const, BaseNameDto>(all, (Func<Const, BaseNameDto>)((Const x) => new BaseNameDto
		{
			Id = x.Id,
			Name = x.MaterialName
		})));
	}
}
