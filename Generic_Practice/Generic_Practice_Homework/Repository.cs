using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Practice_Homework
{
    internal class Repository<T,U>/*where T : class*//*where T : BaseEntity*//*where T :struct*/ /*where T :new()*/
        where T : U
    {
    }
}
