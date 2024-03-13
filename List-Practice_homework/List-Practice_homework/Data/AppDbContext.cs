using List_Practice_homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Practice_homework.Data
{
    internal class AppDbContext

    {
        public static List<Customer> customers;
       static AppDbContext()
        {
            customers = new List<Customer>
            {
                new Customer
               {
                Id = 1,
                FullName = "Fexriyye Tagizade",
                Adress = "28 may",
                Age = 21
               },
                 new Customer
               {
                Id = 2,
                FullName = "Elmir Qafarzade",
                Adress = "Sahil",
                Age = 21
               },
                  new Customer
               {
                Id = 3,
                FullName = "Sirac Memmedov",
                Adress = "Masazir",
                Age = 23
               },
                   new Customer
               {
                Id = 4,
                FullName = "Bahruz Aliyev",
                Adress = "Kurdexani",
                Age = 33
               },
                        new Customer
               {
                Id = 4,
                FullName = "Rasad Agayev",
                Adress = "Neftciler",
                Age = 21
               },




            };
            
        }

        


    }
}
