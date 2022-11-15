namespace Volintiru_Maria_Lab2.Models
{
    public class Author
    {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public ICollection<Book>? Book { get; set; }
        }
    
}
