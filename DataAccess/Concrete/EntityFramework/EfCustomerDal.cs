using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : ICustomerDal 
    {
        //Crud işlemleri yapılıyor 
        public void Add(Customer customer)
        {
            using (PhoneBookContext phoneBook = new PhoneBookContext())
            {
                var addedCustomer = phoneBook.Entry(customer);
                addedCustomer.State = EntityState.Added;
                phoneBook.SaveChanges();
            }

        }

        public void Delete(Customer customer)
        {
            using (PhoneBookContext phoneBook = new PhoneBookContext())
            {
                var deletedCustomer = phoneBook.Remove(customer);
                deletedCustomer.State = EntityState.Deleted;
                phoneBook.SaveChanges();
            }

        }

        public void Update(Customer customer)
        {
            using (PhoneBookContext phoneBook = new PhoneBookContext())
            {
                var updatedCustomer = phoneBook.Remove(customer);
                updatedCustomer.State = EntityState.Modified;
                phoneBook.SaveChanges();
            }

        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            using (PhoneBookContext phoneBook = new PhoneBookContext())
            {
                return filter == null
                    ? phoneBook.Set<Customer>().ToList()
                    : phoneBook.Set<Customer>().Where(filter).ToList();

            }
        }

        public Customer Get(Expression<Func<Customer, bool>> filter)
        {
            using (PhoneBookContext phoneBook = new PhoneBookContext())
            {
                return phoneBook.Set<Customer>().SingleOrDefault(filter);
            }

        }
    }
}

