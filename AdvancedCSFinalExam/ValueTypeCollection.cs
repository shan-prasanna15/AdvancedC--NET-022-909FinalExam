using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AdvancedCSFinalExam
{
    class ValueTypeCollection<T> where T: struct
    {        
        private List<T> _privateCollection = new List<T>();

        public void Add(T value)
        {
            _privateCollection.Add(value);
        }

        public T GetValueByIndex(int index)
        {            
            return _privateCollection[index];
        }


        //public List<T> SortDescending()
        //{
        //    List<T> sortedList = _privateCollection.Sort<T>();
            
        //}

    }
}
