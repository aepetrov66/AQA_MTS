namespace Task4
{
    public class Employee
    {
        public string secondName {  get; set; }
        public string speciality { get; set; }

        public Employee(string lastName, string speciality)
        {
            this.secondName = lastName;
            this.speciality = speciality;
        }
    }
}
