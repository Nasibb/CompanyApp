using System;
using CompanyApp.Domain.Models.Common;

namespace CompanyApp.DataContex.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
	{
		bool Create (T entity);

		bool Update  (T entity);

		bool Delete (T entity);

		T Get(Predicate<T> filter);

		List<T> GetAll(Predicate<T> filter = null);
    }
}

