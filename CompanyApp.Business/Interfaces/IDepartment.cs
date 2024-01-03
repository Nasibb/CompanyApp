using System;
using CompanyApp.Domain.Models.Common;

namespace CompanyApp.Business.Interfaces
{
	public interface IDepartment
	{
		Department Create(Department department);

        Department Update(int id, Department department);

		Department Delete(int id);

		Department Get(int id);

		List<Department> GetAll(int id);

		List<Department> GetAll();

	}
}

