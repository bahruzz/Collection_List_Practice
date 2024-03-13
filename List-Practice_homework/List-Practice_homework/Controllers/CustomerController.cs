using List_Practice_homework.Services;
using List_Practice_homework.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Practice_homework.Controllers
{
    internal class CustomerController
    {
        private readonly ICustomerService _customerService;
        public CustomerController()
        {
            _customerService = new CustomerService();
        }
        public void GetAll()
        {
            foreach (var item in _customerService.GetAll())
            {
                Console.WriteLine(item.FullName + " - " + item.Adress + "-" +item.Age);
            }
        }

        public void GetbyId ()
        {
            try
            {
                int id = 4;
                var result= _customerService.GetById(id);
                Console.WriteLine(result.FullName + " - " + result.Adress + "-" + result.Age);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }
        //public void GetByAge()
        //{
        //    foreach(var item in _customerService.GetByAge())
        //    {
        //        Console.WriteLine(item.FullName + " - " + item.Adress + "-" + item.Age);
        //    }

            

            
        //}

        public void GetCount()
        {
            Console.WriteLine(_customerService.GetCount());
        }

        
    }
}
