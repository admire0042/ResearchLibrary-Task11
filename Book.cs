namespace ResearchLibrary
{
    public class Book 
    {
        public string BookName { get; set; }
        public string BookId { get; set; }
        // public Date DateIssued { get; set; }
        // public Date DateReturned { get; set; }
       
        public Book(string bookname, string bookid)
        {
            BookName = bookname;
            BookId = bookid;
            // DateIssued = dateIss;
            // DateReturned = dateRet;
                      
        }

         public override string ToString()
        {
            return $"\nName of the book borrowed: {BookName}\nBook Id: {BookId}";
        }
        
    }
}