using crudAspNet.Data;
using crudAspNet.Models;
using crudAspNet.Repositories.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace crudAspNet.Repositories;

public class BookRepository : IBookRepository
{

    private readonly LibraryDBContext _dbContext;
    
    public BookRepository(LibraryDBContext libraryDbContext)
    {
        _dbContext = libraryDbContext;
    }
    
    public async Task<List<BookModel>> ListBooks()
    {
        return await _dbContext.Books.ToListAsync();
    }
    
    public async Task<BookModel> AddBook(BookModel book)
    {
        await _dbContext.Books.AddAsync(book);
        await _dbContext.SaveChangesAsync();

        return book;
    }
    
    public async Task<BookModel> EditBook(BookModel book)
    {
        BookModel searchedBook = await _dbContext.Books.FirstOrDefaultAsync(x => x.id == book.id);

        if (searchedBook == null)
        {
            throw new Exception("Book not founded");
        }

        searchedBook.name = book.name;
        searchedBook.author = book.author;
        
        _dbContext.Books.Update(searchedBook);
        await _dbContext.SaveChangesAsync();

        return book;
    }
    
    public async Task<bool> DeleteBook(int id)
    {
        BookModel searchedBook = await _dbContext.Books.FirstOrDefaultAsync(x => x.id == id);

        if (searchedBook == null)
        {
            throw new Exception("Book not founded");
        }

        _dbContext.Books.Remove(searchedBook);
        await _dbContext.SaveChangesAsync();

        return true;
    }
}