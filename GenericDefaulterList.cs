using System;
using System.Collections;
using System.Collections.Generic;
namespace ResearchLibrary
{
    public class GenericDefaulterList<T> : IEnumerable where T : IDefaulterList 
    {
        List<Library> library = new List<Library>();

       
        public void Add(Library item)
        {
            library.Add(item);
        }

        public IEnumerator GetEnumerator()
        {
           return library.GetEnumerator();
        }
    }
}