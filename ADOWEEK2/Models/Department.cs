namespace ADOWEEK2.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";

        //public virtual ICollection<Student> Students 
        //{ get; set; } = new List<Student>();
        //This is the navigation property.
        //which simply represents the relationship to another entity 
    }
}
