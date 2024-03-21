namespace Mission11_Bundy.Models
{
    public class EFBookstoreRepository : IBookstoreRepository
    {
        private BookstoreContext context;
        public EFBookstoreRepository(BookstoreContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Book> Books => context.Books;
    }
}
