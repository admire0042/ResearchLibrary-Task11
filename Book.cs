namespace ResearchLibrary
{
    public class Book 
    {
        public string BookName { get; set; }
        public string BookId { get; set; }
        
       
        public Book(string bookname, string bookid)
        {
            BookName = bookname;
            BookId = bookid;
                      
        }

         public override string ToString()
        {
            return $"{BookName}\nBook Id: {BookId}";
        }
        
    }
}