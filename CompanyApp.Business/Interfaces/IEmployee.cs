using System;
using CompanyApp.Domain.Models.Common;

namespace CompanyApp.Business.Interfaces
{
	public interface IEmployee
	{
		Employee Create(Employee employee,string departmentName);

		Employee Update(int id,Employee employee);

		Employee Delete(int id);

		Employee Get(int id);

		List<Employee> GetAll(int age);

		List<Employee> GetAll(Department department);

		List<Employee> GetAll();

	}
}

