using System;
using CompanyApp.Domain.Models.Common;

namespace CompanyApp.DataContex
{
	public static class DbContex
	{
		public static List<Employee> Employees { get; set; }
		public static List<Department> Departments { get; set; }

		static DbContex()
		{
			Employees = new();
			Departments = new();
		}
	}
}

