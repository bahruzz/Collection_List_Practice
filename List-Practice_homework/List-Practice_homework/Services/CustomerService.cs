using List_Practice_homework.Data;
using List_Practice_homework.Models;
using List_Practice_homework.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Practice_homework.Services
{
    internal class CustomerService : ICustomerService
    {
        public List<Customer> GetAll()
        {
            return AppDbContext.customers;
        }

        public IEnumerable<Customer?> GetByAge()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int? id)
        {
            return id==null ? throw new ArgumentNullException() : AppDbContext.customers.First(m => m.Id==id);
        }

      

        public int GetCount()
        {
            return AppDbContext.customers.Count();
        }

       

        List<Customer> ICustomerService.GetByAge(int age)
        {
            return AppDbContext.customers.Where(m => m.Age == age).ToList();
        }
    }
}

