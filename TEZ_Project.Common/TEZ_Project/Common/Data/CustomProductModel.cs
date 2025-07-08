using System;

namespace TEZ_Project.Common.Data;

public class CustomProductModel
{
	public int CustomProductId { get; set; }

	public DateTime LastUpdatedDate { get; set; }

	public string Name { get; set; }

	public string CreatedBy { get; set; }

	public string LastUpdatedBy { get; set; }

	public string DisplayDate => LastUpdatedDate.ToString("dd/MM/yyyy HH mm", System.Globalization.CultureInfo.InvariantCulture);
}
