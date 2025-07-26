using BookTracker.Data;
using BookTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace BookTracker.BookServices
{
    public class BookService : IBookService
    {
        private readonly AppDbContext appDbContext;

        public BookService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<(bool Success, string Message)> DeleteBookAsync(int id)
        {
            if (id == 0)
                return ErrorMessage();

            var bookToDelete = await appDbContext.BooksTable.FirstOrDefaultAsync(_ => _.Id == id);
            if (bookToDelete == null)
                return ErrorMessage();

            appDbContext.BooksTable.Remove(bookToDelete);
            await appDbContext.SaveChangesAsync();
            return SuccessMessage();
        }

        public async Task<List<Book>> GetBooksAsync() => await appDbContext.BooksTable.ToListAsync();

        public async Task<(bool Success, string Message)> ManageBookAsync(Book book)
        {
            if (book.Id == 0)
            {
                if (!await IsBookAlreadyAdded(book.Title!))
                {
                    appDbContext.BooksTable.Add(book);
                    await appDbContext.SaveChangesAsync();
                    return SuccessMessage();
                }
                else
                    return (false, "Book with the same title already exists.");
            }
            else
            {
                if (!await IsBookAlreadyAdded(book.Title!, book.Id))
                {
                    var bookToUpdate = await appDbContext.BooksTable.FirstOrDefaultAsync(_ => _.Id == book.Id);
                    if (bookToUpdate == null)
                        return ErrorMessage();

                    bookToUpdate.Title = book.Title;
                    bookToUpdate.Description = book.Description;
                    bookToUpdate.Author = book.Author;
                    bookToUpdate.Image = book.Image;
                    await appDbContext.SaveChangesAsync();
                    return SuccessMessage();
                }
                else
                    return (false, "Another book with the same title already exists.");
            }
        }

        private async Task<bool> IsBookAlreadyAdded(string bookName, int? excludeId = null)
        {
            return await appDbContext.BooksTable
                .AnyAsync(b => b.Title!.ToLower() == bookName.ToLower() && (!excludeId.HasValue || b.Id != excludeId.Value));
        }

        private async Task<bool> IsBookAlreadyAdded(string bookName)
        {
            var book = await appDbContext.BooksTable.FirstOrDefaultAsync(_ => _.Title!.ToLower() == bookName.ToLower());
            return book != null;
        }

        private static (bool, string) SuccessMessage() => (true, "Process successfully completed.");
        private static (bool, string) ErrorMessage() => (false, "Error occurred while processing.");

        public async Task<Book?> GetBookByIdAsync(int id)
        {
            return await appDbContext.BooksTable.FindAsync(id);
        }

    }
}
