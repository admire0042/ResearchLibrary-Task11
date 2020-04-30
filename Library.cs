using System;
namespace ResearchLibrary
{
    public class Library : IDefaulterList
    {
        public Student StudentDetails { get; set; }
        public Book BookDetails { get; set; }
        public string IssueDate { get; set; }
        public string ReturnDate { get; set; }
        public int IssDate;
        public int ExpectedRetDate;
        public double NumOfDaysRet;

        public Library(Student stdDetails, Book bookDetails, string dateIss, string dateRet)
        {
           
               StudentDetails = stdDetails;
               BookDetails = bookDetails;  
               IssueDate = dateIss;
               ReturnDate = dateRet;
            
        }
        
        public string GetName()
        {
            return $"{StudentDetails.StdName}";
        }

        public string GetYear()
        {
             return $"{StudentDetails.YearOfStudy}";
        }

        public string GetBook()
        {
           return $"{BookDetails.ToString()}"; 
        }

        public string GetDateIssue()
        {
            return $"The book was issued on {IssueDate}";
        }

         public string GetDateReturn()
        {
       
                    System.DateTime IssDate = Convert.ToDateTime(IssueDate);
                    System.DateTime ExpectedRetDate = IssDate.AddDays(+14);
                    TimeSpan DateDifferent = ExpectedRetDate - IssDate;
                    double Days = DateDifferent.TotalDays;
                    System.DateTime RetDate = Convert.ToDateTime(ReturnDate);
                    TimeSpan DateReturnedDifferent = RetDate - IssDate;
                    NumOfDaysRet = DateReturnedDifferent.TotalDays;
                    
                    return  $"The book was returned on: {ReturnDate}";
        
        }

        public string GetDefaulter()
        {
            GetDateReturn();
            if(NumOfDaysRet > 14){
                return $"Name: {GetName()},  {GetBook()} \n ";
            }
            return $"";
            
        }

        public override string ToString()
        {
            return $"{GetDefaulter()}";
        }



    }
}