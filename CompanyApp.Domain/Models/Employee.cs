using System;
namespace CompanyApp.Domain.Models.Common
{
	public class Employee:BaseEntity
	{
		public string Name { get; set; }

		public string Surname { get; set; }

		public int Age { get; set; }

		public string Address { get; set; }

		public Department Department { get; set; }
	}
}

