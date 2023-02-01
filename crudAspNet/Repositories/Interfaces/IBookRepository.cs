using crudAspNet.Models;

namespace crudAspNet.Repositories.Interfaces;

public interface IBookRepository
{
    Task<List<BookModel>> ListBooks();
    Task<BookModel> AddBook(BookModel book);
    Task<BookModel> EditBook(BookModel book);
    Task<bool> DeleteBook(int id);
}