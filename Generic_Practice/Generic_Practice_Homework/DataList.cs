using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Practice_Homework
{
    internal class DataList<T>
    {
        private T[] _datas;
        public DataList()
        {
            _datas = Array.Empty<T>();
        }
        public void Add(T data)
        {
            Array.Resize(ref _datas, _datas.Length + 1);
            _datas[_datas.Length - 1] = data;
        }

        public T[] GetAll()
        {
            return _datas;
        }

        public /*bool*/ void Delete(T data)
        {
            //var temp = _datas[ Array.FindIndex(_datas,m=>m.Equals(data))];
            //_datas[ Array.FindIndex(_datas, m => m.Equals(data))] = _datas[_datas.Length-1];
            //_datas[_datas.Length-1] = temp;

            //Array.Resize(ref _datas, _datas.Length-1);
            //int index= Array.IndexOf(_datas, data);
            //if (index >= 0)
            //{
            //    for (int i = index; i < _datas.Length-1; i++)

            //    {
            //        _datas[i] = _datas[i+1];

            //    }
            //    Array.Resize(ref _datas, _datas.Length - 1);
            //    return true;

            //}
            //return false;
            var datas = GetAll();
            _datas = datas.Where(m=>!m.Equals(data)).ToArray();
        }
        
       

    }
}
