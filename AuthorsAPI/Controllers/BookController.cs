using Microsoft.AspNetCore.Mvc;
using ProductAPI.DAL;
using ProductAPI.DAL.Abstract;

namespace AuthorsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IGenericRepository<Book> _repository;

        public BookController(IGenericRepository<Book> repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// get books.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /api/book
        ///
        /// </remarks>
        /// <returns>A list of books</returns>
        /// <response code="200">Returns the list of books</response>
        [HttpGet]
        public IActionResult Get()
        {
            var books = _repository.GetAll();
            return Ok(books);
        }
        /// <summary>
        /// Get a book.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /api/book/1
        ///
        /// </remarks>
        /// <returns>An author</returns>
        /// <response code="200">Returns a book</response>
        /// <response code="400">if id is null</response>
        /// 
        [HttpGet("{id}", Name = "GetBookById")]
        public IActionResult Get(int id)
        {
            if (id == 0)
                return BadRequest("provide id");
            var book = _repository.GetById(id);

            return Ok(book);
        }

        /// <summary>
        /// Creates an Book.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /api/book
        ///           {
        ///             "id": 0,
        ///             "name": "book name",
        ///             "authorId": 1,
        ///             "issueDate": "2021-03-10T08:02:57.461Z",
        ///             "description": "book description"
        ///           }
        ///
        /// </remarks>
        /// <returns>A newly created book</returns>
        /// <response code="201">Returns the newly created book</response>
        /// <response code="400">If the book info is not correct</response>
        [HttpPost("{id}")]
        public IActionResult Add([FromBody] Book book)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _repository.Insert(book);
            return CreatedAtRoute("GetBookById", new { id = book.Id }, new { result = "done" });
        }
        /// <summary>
        /// Updates a Book.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /api/book
        ///           {
        ///             "id": 2,
        ///             "name": "book name",
        ///             "authorId": 2,
        ///             "issueDate": "2021-03-10T08:02:57.461Z",
        ///             "description": "book description"
        ///           }
        ///
        /// </remarks>
        /// <returns>The updated book</returns>
        /// <response code="200">Returns the updated book</response>
        /// <response code="400">If the book info is not correct</response>
        [HttpPatch]
        public IActionResult Update([FromBody] Book book)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _repository.Update(book);
            return Ok();
        }
        /// <summary>
        /// Deletes a book.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     DELETE /api/book/1
        ///
        /// </remarks>
        /// <returns>The updates author</returns>
        /// <response code="200">Success</response>
        /// <response code="400">If the auther id is not provided</response>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id == 0)
                return BadRequest("provide id");
            _repository.Delete(id);
            return Ok();
        }
    }
}
