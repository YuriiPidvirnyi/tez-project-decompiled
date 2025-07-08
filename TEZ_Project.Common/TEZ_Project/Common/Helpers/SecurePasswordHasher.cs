using System;
using System.Security.Cryptography;

namespace TEZ_Project.Common.Helpers;

public static class SecurePasswordHasher
{
	private const int SaltSize = 16;

	private const int HashSize = 20;

	public static string Hash(string password, int iterations)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		byte[] array = new byte[16];
		RandomNumberGenerator.Create().GetBytes(array);
		Rfc2898DeriveBytes val = new Rfc2898DeriveBytes(password, array, iterations);
		byte[] bytes = ((DeriveBytes)val).GetBytes(20);
		byte[] array2 = new byte[36];
		Array.Copy(array, 0, array2, 0, 16);
		Array.Copy(bytes, 0, array2, 16, 20);
		string arg = Convert.ToBase64String(array2);
		return $"$V1${iterations}${arg}";
	}

	public static string Hash(string password)
	{
		return Hash(password, 10000);
	}

	public static bool Verify(string password, string hashedPassword)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		string[] array = hashedPassword.Replace("$V1$", "").Split(new char[1] { '$' });
		int num = int.Parse(array[0]);
		string s = array[1];
		byte[] array2 = Convert.FromBase64String(s);
		byte[] array3 = new byte[16];
		Array.Copy(array2, 0, array3, 0, 16);
		Rfc2898DeriveBytes val = new Rfc2898DeriveBytes(password, array3, num);
		byte[] bytes = ((DeriveBytes)val).GetBytes(20);
		for (int i = 0; i < 20; i++)
		{
			if (array2[i + 16] != bytes[i])
			{
				return false;
			}
		}
		return true;
	}
}
