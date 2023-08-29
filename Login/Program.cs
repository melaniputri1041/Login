using System;
using System.Text.RegularExpressions;

namespace Login
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Masukan Password : ");
			string password = Console.ReadLine();
			if (Validate(password)){
				Console.WriteLine("Password is valid");
			}
			else
			{
				Console.WriteLine("Password tidak valid");
			}
		}

		static bool Validate(string password)
		{
			string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$";
			if(Regex.IsMatch(password, pattern))
			{
				if(!Regex.IsMatch(password, @"[!@#$]"))
				{
					return true;
				}
			}
			return false;
		}
	}
}
