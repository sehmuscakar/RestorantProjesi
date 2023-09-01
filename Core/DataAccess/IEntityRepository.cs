using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
	public interface IEntityRepository<T> where T : class,IEntity,new()//bunu generic say burdaki metotlar baserepositoryde yazılacak bunlar generic olacak 
	{
		T Get(Expression<Func<T, bool>> filter);//bunu getbyıd kullanacaz mesela servicedeki tanımladığımız 
		IList<T> GetActiveList(Expression<Func<T, bool>> filter = null);//bunu mesela GetList e kulanacaz 
		void Add(T entity);//bunu eklemede 
		void Update(T entity);//güncellemede
		void Delete(T entity);
	}
}
