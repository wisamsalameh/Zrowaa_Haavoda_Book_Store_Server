using Microsoft.EntityFrameworkCore;
using Zrowaa_Haavoda_Book_Store_Server.Models;
 
namespace Zrowaa_Haavoda_Book_Store_Server.Services
{
    public class BookDataService : IBookDataService
    {
        private readonly ZrowaaHaavodaaContext _context;
        public BookDataService(ZrowaaHaavodaaContext context)
        {
            _context = context;
        }

        public BookData AddBookData(BookData bookData)
        {
            _context.bookData.Add(bookData);
            _context.SaveChanges();
            return bookData;
        }

        public void DeleteBookData(BookData bookData)
        {
            _context.bookData.Remove(bookData);
            _context.SaveChanges();
        }
        public BookData EditBookData(BookData bookData)
        {

            _context.bookData.Update(bookData);
            _context.SaveChanges();

            return bookData;
        }

        public async Task<List<BookData>> GetAllBookData()
        {
            return await _context.bookData.ToListAsync();
        }

        public async Task<BookData> GetBookDataById(int id) // Or Task<ActionResult<BookData>>
        {
            // return _context.bookData.SingleOrDefault(x => x.Id == id);
            //Or 
            var bookData = await _context.bookData.FindAsync(id);
            return bookData;
        }
    }
}
