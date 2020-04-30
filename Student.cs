namespace ResearchLibrary
{
    public class Student
    {
        public string StdName { get; set; }
        public int YearOfStudy { get; set; }

        public Student(string stdname, int yearofstudy)
        {
            StdName = stdname;
            YearOfStudy = yearofstudy;
        }

        public override string ToString()
        {
            return $"Name of Student: {StdName}\nYear of Study: {YearOfStudy}";
        }
       
    }
}