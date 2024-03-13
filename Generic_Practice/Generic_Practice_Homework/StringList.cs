using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Practice_Homework
{
    internal class StringList
    {
        private string[] intArray;
        public StringList()
        {
            intArray = Array.Empty<string>();
        }
        public void Add(string num )
        {
            Array.Resize(ref intArray, intArray.Length + 1);
            intArray[intArray.Length - 1] = num;
        }

        public string[] GetAll()
        {
            return intArray;
        }
    }
}
