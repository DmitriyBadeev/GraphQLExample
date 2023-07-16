namespace GraphQL.API;

public class BookRepository
{
    private readonly List<Book> _books = new()
    {
        new()
        {
            Id = 1,
            Title = "test1",
            Author = new Author
            {
                Name = "author test"
            }
        },
        new()
        {
            Id = 2,
            Title = "test2",
            Author = new Author
            {
                Name = "author test 2"
            }
        },
        new()
        {
            Id = 3,
            Title = "test3",
            Author = new Author
            {
                Name = "author test 3"
            }
        },
    };

    public IEnumerable<Book> GetAll() => _books;
    public Book? GetById(long id) => _books.Find(book => book.Id == id);

    public void CreateBook(Book book) => _books.Add(book);
}

public class Book
{
    public long Id { get; set; }
    public string Title { get; set; }

    public Author Author { get; set; }
}

public class Author
{
    public string Name { get; set; }
}