using TEZ_Project.Common.Data.Entities;

namespace TEZ_Project;

public class CustomConst
{
	public int Id { get; set; }

	public string MaterialName { get; set; }

	public double Price { get; set; }

	public string MaterialNameFlight { get; set; }

	public string Code1 { get; set; }

	public string MaterialName1C { get; set; }

	public string Code2 { get; set; }

	public string OdVym1 { get; set; }

	public string OdVym2 { get; set; }

	public string NameInApp { get; set; }

	public bool IsEdited { get; set; }

	public int DisplayOdVym1
	{
		get
		{
			return DisplayOdVym(OdVym1);
		}
		set
		{
			OdVym1 = DisplayOdVymReverse(value);
		}
	}

	public int DisplayOdVym2
	{
		get
		{
			return DisplayOdVym(OdVym2);
		}
		set
		{
			OdVym2 = DisplayOdVymReverse(value);
		}
	}

	public CustomConst()
	{
	}

	public CustomConst(string materialname, double price, string materialNameFlight, string code1, string materialName1C, string code2, string odVym1, string odVym2)
	{
		MaterialName = materialname;
		Price = price;
		MaterialNameFlight = materialNameFlight;
		Code1 = code1;
		MaterialName1C = materialName1C;
		Code2 = code2;
		OdVym1 = odVym1;
		OdVym2 = odVym2;
	}

	public CustomConst(int id, string materialname, double price, string materialNameFlight, string code1, string materialName1C, string code2, string odVym1, string odVym2, string nameInApp)
	{
		Id = id;
		MaterialName = materialname;
		Price = price;
		MaterialNameFlight = materialNameFlight;
		Code1 = code1;
		MaterialName1C = materialName1C;
		Code2 = code2;
		OdVym1 = odVym1;
		OdVym2 = odVym2;
		NameInApp = nameInApp;
	}

	private int DisplayOdVym(string odVymString)
	{
		if (odVymString == null || odVymString.Length != 0)
		{
			return odVymString switch
			{
				"м" => 1, 
				"м2" => 2, 
				"кг" => 3, 
				"шт" => 4, 
				"пог. м" => 5, 
				_ => 0, 
			};
		}
		return 0;
	}

	private string DisplayOdVymReverse(int odVym)
	{
		return odVym switch
		{
			0 => "", 
			1 => "м", 
			2 => "м2", 
			3 => "кг", 
			4 => "шт", 
			5 => "пог. м", 
			_ => "", 
		};
	}

	public Const ToConst(string name)
	{
		return new Const
		{
			Id = Id,
			NameInApp = name,
			MaterialName = MaterialName,
			Price = Price,
			MaterialNameFlight = MaterialNameFlight,
			Code1 = Code1,
			MaterialName1C = MaterialName1C,
			Code2 = Code2,
			OdVym1 = OdVym1,
			OdVym2 = OdVym2
		};
	}
}
