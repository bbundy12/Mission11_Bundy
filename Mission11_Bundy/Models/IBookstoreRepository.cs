namespace Mission11_Bundy.Models
{
    public interface IBookstoreRepository
    {
       public IQueryable<Book> Books { get; }
    }
}
