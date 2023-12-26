using System;
using CompanyApp.Domain.Models.Common;

namespace CompanyApp.Contex
{
	public static class DbContex
	{
		public static List<Employee> Employees { get; set; }
		public static List<Department> Departments { get; set; }

		static DbContex()
		{
			Employees = new();
			Departments = new();
			Console.WriteLine("membere muraciet..");
		}
	}
}

