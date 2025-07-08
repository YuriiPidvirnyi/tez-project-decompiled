namespace TEZ_Project.Common.Helpers;

public static class SwitchHelper
{
	public static (int, string) GetMarkaStaliIndexAndNamePref(string markaStaliStr)
	{
		int item;
		string item2;
		switch (markaStaliStr)
		{
		case "Оцинковка":
			item = 1;
			item2 = "";
			break;
		case "Чорна":
			item = 2;
			item2 = "ст ";
			break;
		case "Нержавійка":
			item = 3;
			item2 = "нерж ";
			break;
		default:
			item = 0;
			item2 = "";
			break;
		}
		return (item, item2);
	}
}
