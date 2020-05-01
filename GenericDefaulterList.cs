using System;
using System.Collections;
using System.Collections.Generic;
namespace ResearchLibrary
{
    public class GenericDefaulterList<T> : IEnumerable where T : IDefaulterList 
    {
        List<Library> library = new List<Library>();
        // private T[] defaulter;
        // private int numElements;
        // private const int DEFAULTSIZE = 7;

        public  GenericDefaulterList()
        {
            // defaulter = new T[DEFAULTSIZE];
            // numElements = 0;
        }

        //  public  GenericDefaulterList(int size)
        // {
        //     defaulter = new T[size];
        //     numElements = 0;
        // }
        public void Add(Library item)
        {
            library.Add(item);

            // if(numElements < defaulter.Length)
            // {
            //     defaulter[numElements] = item;
            //     numElements++;
            // }else{
            //     throw new System.Exception("Defaulter list is full!");
            // }
        }

        // public T Remove()
        // {
        //     if(numElements != 0)
        //     {
        //         T item = payments[--numElements];
        //         return item;
        //     }
        //     throw new System.Exception("Payment collection is empty");
        // }

        public IEnumerator GetEnumerator()
        {
           return library.GetEnumerator();
        }

        // public T[] GetAllDefaulters()
        // {

        //     if(numElements > 0)
        //     {
        //         return defaulter;
        //     }
        //     throw new System.Exception("DefaulterList is empty!");
        // }

    }
}