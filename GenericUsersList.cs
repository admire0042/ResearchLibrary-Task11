using System;
using System.Collections;
using System.Collections.Generic;
namespace ResearchLibrary
{
    public class GenericUsersList<T> : IEnumerable where T : IDefaulterList 
    {
        List<LibGenList> library = new List<LibGenList>();
        
        public void Add(LibGenList item)
        {
            library.Add(item);
        }

        public IEnumerator GetEnumerator()
        {
           return library.GetEnumerator();
        }
    }
}