namespace DemoMVC.Models
{
    public class PersonViewModel
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
