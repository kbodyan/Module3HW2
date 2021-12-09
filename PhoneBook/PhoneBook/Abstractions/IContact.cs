namespace PhoneBook
{
    public interface IContact
    {
        char? FirstLetter { get; }
        string FirstName { get; set; }
        string FullName { get; }
        string LastName { get; set; }
        string[] Phones { get; set; }

        object Clone();
        string ToString();
    }
}