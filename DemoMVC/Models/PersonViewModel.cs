namespace DemoMVC.Models
{
    public class Person
    {
        public string Name { get; set; }   
        public int BirthYear { get; set; } 
        public int Age 
        {
            get
            {
                return DateTime.Now.Year - BirthYear;
            }
        }
    }
}
