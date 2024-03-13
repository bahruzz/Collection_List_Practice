using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Practice_homework.Models
{
    internal class Customer:BaseEntity
    {
        public string FullName { get; set; }
        public string Adress { get; set; }
        public int Age { get; set; }

    }
}
