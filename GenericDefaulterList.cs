using System;
using System.Collections;
using System.Collections.Generic;
namespace ResearchLibrary
{
    public class GenericDefaulterList<T> : IEnumerable where T : IDefaulterList 
    {
        List<T> library = new List<T>();

       
        public void Add(T item)
        {
            library.Add(item);
        }

        public IEnumerator GetEnumerator()
        {
           return library.GetEnumerator();
        }
    }
}