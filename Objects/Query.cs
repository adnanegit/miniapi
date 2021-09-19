namespace miniapi.core
{
    public class Query
    {
        IList<Book> books = new List<Book>();
        
        public Query()
        {
            books.Add(new Book
            {
                Title = "Production ready GraphQl",
                Author = new Author
                {
                    Name = "Joe Graph"
                }
            });

            books.Add(new Book
            {
                Title = "C#",
                Author = new Author
                {
                    Name = "John Sharp"
                }
            });
        }
        public Book GetBook()
        {          

            return books[0];
        }

        public IEnumerable<Book> GetBooks()
        {            
            return books;
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }
    }
}
