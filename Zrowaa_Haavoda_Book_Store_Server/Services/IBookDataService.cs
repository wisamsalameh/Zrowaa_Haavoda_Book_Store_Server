using Zrowaa_Haavoda_Book_Store_Server.Models;

namespace Zrowaa_Haavoda_Book_Store_Server.Services
{
    public interface IBookDataService
    {
        Task<List<BookData>> GetAllBookData();
        Task<BookData> GetBookDataById(int id);
        BookData AddBookData(BookData bookData);
        BookData EditBookData(BookData bookData);
        void DeleteBookData(BookData bookData);
    }
}
