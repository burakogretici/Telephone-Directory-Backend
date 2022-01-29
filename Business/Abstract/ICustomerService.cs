using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);

        List<Customer> GetAll();
        Customer GetByPhoneNumber(string phoneNumber);
        Customer GetByName(string name);
        Customer GetById(int id);


    }
}
