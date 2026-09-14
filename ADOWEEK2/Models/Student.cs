namespace ADOWEEK2.Models

{
    public class Student
    {
        public int Id { get; set; }
        public string name { get; set; } = "";

        public int Age { get; set; }

        //public int DepartmentId { get; set; }
        //This is the foreign key
        
        //public virtual Department Department { get; set; } = null!;
        //This is the navigation property.
        //which simply represents the relationship to another entity 
    }
}
