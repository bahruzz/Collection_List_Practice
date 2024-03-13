using List_Practice_homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Practice_homework.Services.Interfaces
{
    internal interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetById(int? id);
        List<Customer> GetByAge(int age);
        int GetCount();
       
    }
}
