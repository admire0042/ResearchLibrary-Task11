using System;

namespace ResearchLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Student student1 = new Student("Adeoti", 2017);
            Student student2 = new Student("Ituah", 2016);
            Student student3= new Student("Kemi", 2018);
            Student student4 = new Student("Samson", 2015);
            Student student5 = new Student("Jacob", 2017);
            Student student6 = new Student("Laide", 2018);
            Student student7 = new Student("Tola", 2017);
            Book book1 = new Book("Engineering Mathematics", "165");
            Book book2 = new Book("Introduction to Algebra", "186");
            Book book3 = new Book("Partial Differential Equation", "112");
            Book book4 = new Book("Mathematical Modelling", "183");
            Book book5 = new Book("Functional Analysis", "154");
            Book book6 = new Book("Mathematical Methods", "192");
            Book book7 = new Book("Complex Analysis", "174");

            Library library1 = new Library(student1,book1,"1/30/2017", "2/10/2017");
            Library library2 = new Library(student2,book2,"5/4/2016", "8/20/2016");
            Library library3 = new Library(student3,book3,"8/5/2018", "9/15/2018");
            Library library4 = new Library(student4,book4,"3/7/2015", "3/11/2016");
            Library library5 = new Library(student5,book5,"11/20/2017", "12/19/2017");
            Library library6 = new Library(student6,book6,"08/20/2017", "09/01/2017");
            Library library7 = new Library(student7,book7,"04/15/2017", "06/19/2017");

            LibGenList library11 = new LibGenList(student1,book1,"1/30/2017", "2/10/2017");
            LibGenList library22 = new LibGenList(student2,book2,"5/4/2016", "8/20/2016");
            LibGenList library33 = new LibGenList(student3,book3,"8/5/2018", "9/15/2018");
            LibGenList library44 = new LibGenList(student4,book4,"3/7/2015", "3/11/2016");
            LibGenList library55 = new LibGenList(student5,book5,"11/20/2017", "12/19/2017");
            LibGenList library66 = new LibGenList(student6,book6,"08/20/2017", "09/01/2017");
            LibGenList library77 = new LibGenList(student7,book7,"04/15/2017", "06/19/2017");

             
            Console.WriteLine("\nLIST OF ALL STUDENTS WITH BOOKS COLLECTECTED(PROCESSED POLYMORPHICALLY))\n");

             GenericUsersList<LibGenList> libra = new GenericUsersList<LibGenList>(); 

             libra.Add(library11);                     
             libra.Add(library22);                     
             libra.Add(library33);                     
             libra.Add(library44); 
             libra.Add(library55); 
             libra.Add(library66); 
             libra.Add(library77);  
             

             foreach(var lib in libra){
                    // Console.WriteLine(lib.GetAllStudents());
                     Console.WriteLine(lib.ToString());
             
              }

            Console.WriteLine("\nLIST OF DEFAULTERS(PROCESSED POLYMORPHICALLY)");

             GenericDefaulterList<Library> library = new GenericDefaulterList<Library>(); 


                                
             library.Add(library1);                     
             library.Add(library2);                     
             library.Add(library3);                     
             library.Add(library4); 
             library.Add(library5); 
             library.Add(library6); 
             library.Add(library7);  
             

             foreach(var lib in library){
                    // Console.WriteLine(lib.GetAllStudents());
                     Console.WriteLine(lib.ToString());
             
              }
        }
    }
}
