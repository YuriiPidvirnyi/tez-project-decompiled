using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace TEZ_Project.Common.Data.Entities;

public class User
{
	public int Id { get; set; }

	public string Login { get; set; }

	public string Password { get; set; }

	public DateTime PasswordSetDate { get; set; }

	public Role Role { get; set; }

	public bool IsPasswordReset { get; set; }

	[JsonIgnore]
	public ICollection<Order> Orders { get; set; } = new List<Order>();


	[JsonIgnore]
	[NotMapped]
	public string DisplayDate => PasswordSetDate.ToString("dd/MM/yyyy HH mm", System.Globalization.CultureInfo.InvariantCulture);

	[JsonIgnore]
	[NotMapped]
	public int RoleConverter
	{
		get
		{
			return (int)Role;
		}
		set
		{
			Role = (Role)value;
		}
	}
}
