namespace ProjectsManagement
{
    /// <summary>
    /// Bottom level customer class, represents a natural person (used as either contact person for a company, or a person for a natural person client)
    /// </summary>
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public Person()
        {
        }

        public Person(string name, string surname, string address, int phoneNumber, string email)
        {
            Name = name;
            Surname = surname;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public Person(string name, string surname, string address, string email)
        {
            Name = name;
            Surname = surname;
            Address = address;
            PhoneNumber = -1;
            Email = email;
        }

        public Person(string name, string surname, string address, int phoneNumber)
        {
            Name = name;
            Surname = surname;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = "N/A";
        }
    }
}
