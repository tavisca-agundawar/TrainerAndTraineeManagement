namespace CRUD_API.Model
{
    public class Trainee : Employee
    {
        public int BatchNumber { get; set; }

        public Trainee(int id, string name, string email, string phoneNumber, string designation, int batchNumber)
        {
            ID = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Designation = designation;
            BatchNumber = batchNumber;
        }
    }
}
