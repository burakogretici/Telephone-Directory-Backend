using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Abstract
{
   public interface ICustomerDal 
    {
        void Add(Customer customer);
        void Delete(Customer customer);
        void Update(Customer customer);

        List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null);
        Customer Get(Expression<Func<Customer, bool>> filter);
    }
}
