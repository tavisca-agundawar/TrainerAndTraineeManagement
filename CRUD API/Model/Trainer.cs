namespace CRUD_API.Model
{
    public class Trainer : Employee
    {
        public string Technology { get; set; }
        public string Tribe { get; set; }

        public Trainer(int id, string name,string email, string phoneNumber, string designation, string technology, string tribe)
        {
            ID = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Designation = designation;
            Technology = technology;
            Tribe = tribe;
        }
    }
}
