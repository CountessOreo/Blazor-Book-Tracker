using BookTracker.Models;
using System.Net.Http;

namespace BookTracker.BookServices
{
    public interface IBookService
    {
        Task<(bool Success, string Message)> ManageBookAsync(Book book);
        Task<(bool Success, string Message)> DeleteBookAsync(int id);
        Task<List<Book>> GetBooksAsync();
        Task<Book?> GetBookByIdAsync(int id);

    }
}
