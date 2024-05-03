namespace TrackingApi.Data.Entity
{
    public class EmployeeEnt
    {
        public int E_Id { get; set; }
        public string E_Name { get; set; }
        public int E_Age { get; set; }
        public string E_Department { get; set; }
        public DateTime E_JoiningDate { get; set; }

        //public Employee() // Parameterless default constructor
        //{
        //}

        //// Constructor with specific parameter signature
        //public Employee(int e_Id, string e_Name, int e_Age, string e_Department, DateTime e_JoiningDate)
        //{
        //    E_Id = e_Id;
        //    E_Name = e_Name;
        //    E_Age = e_Age;
        //    E_Department = e_Department;
        //    E_JoiningDate = e_JoiningDate;
        //}
    }

}
