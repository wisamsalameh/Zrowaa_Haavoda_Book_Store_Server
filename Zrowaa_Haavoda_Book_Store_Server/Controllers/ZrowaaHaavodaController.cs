using Microsoft.AspNetCore.Mvc;
using Zrowaa_Haavoda_Book_Store_Server.Models;
using Zrowaa_Haavoda_Book_Store_Server.Services;

namespace Zrowaa_Haavoda_Book_Store_Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ZrowaaHaavodaController : Controller
    {

        private readonly IBookDataService _bookDataService;

        public ZrowaaHaavodaController(IBookDataService _BookDataService)
        {
            _bookDataService = _BookDataService;

        }

        [HttpGet]
        [Route("api/[controller]")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookDataService))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> GetAllBookData()
        {
            var result = await _bookDataService.GetAllBookData();
            if (result.Count == 0)
            {
                return NoContent();
            }
            return Ok(result);
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public async Task<IActionResult> GetBookDataById(int id) // Or Task<ActionResult>
        {
            var bookData = await _bookDataService.GetBookDataById(id);
            if (bookData != null)
            {
                return Ok(bookData);
            }
            else
            {
                return NotFound($"Book With Id: {id} was not found ");
            }
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddBookData(BookData bookData) // Or 
        {
            _bookDataService.AddBookData(bookData);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + bookData.Id, bookData);
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public async Task<IActionResult> DeleteBookData(int id) // Or 
        {
            var bookData = await _bookDataService.GetBookDataById(id);
            if (bookData != null)
            {
                _bookDataService.DeleteBookData(bookData);
                return Ok(new { Success = true  });
            }
            return NotFound($"Book With Id: {id} was not found ");
        }

        [HttpPatch]
        [Route("api/[controller]")]
        public async Task<IActionResult> UpdateBookData(BookData bookData) // Or 
        {
            var bookDataExist = await _bookDataService.GetBookDataById(bookData.Id);
            if (bookData != null)
            {
                bookDataExist.Name = bookData.Name;
                bookDataExist.Description = bookData.Description;
                bookDataExist.Price = bookData.Price;
                // try check if the below returned vaue is not null
                _bookDataService.EditBookData(bookDataExist);
                return Ok(bookDataExist);
            }
            return NotFound($"Book With Id: {bookData.Id} was not found ");
        }
    }
}