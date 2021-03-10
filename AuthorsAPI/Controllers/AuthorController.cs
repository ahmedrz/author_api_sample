using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.DAL;
using ProductAPI.DAL.Abstract;

namespace AuthorsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private IGenericRepository<Author> _repository;
        public AuthorController(IGenericRepository<Author> repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// get authors.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /api/author
        ///
        /// </remarks>
        /// <returns>A list of authors</returns>
        /// <response code="200">Returns the list of authors</response>
        [HttpGet]
        public IActionResult Get()
        {
            var authors = _repository.GetAll();
            return Ok(authors);
        }
        /// <summary>
        /// Get an author.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /api/author/1
        ///
        /// </remarks>
        /// <returns>An author</returns>
        /// <response code="200">Returns an author</response>
        /// <response code="400">if id is not provided</response>
        [HttpGet("{id}", Name = "GetAuthorById")]
        public IActionResult Get(int id)
        {
            if (id == 0)
                return BadRequest("provide id");
            var author = _repository.GetById(id);
            if (author == null)
                return NotFound();
            return Ok(author);
        }

        /// <summary>
        /// Creates an Author.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /api/author
        ///             {
        ///               "id": 0,
        ///               "name": "author name",
        ///               "bod": "2021-03-10T07:46:49.391Z",
        ///               "country": "country"
        ///             }
        ///
        /// </remarks>
        /// <returns>A newly created Author</returns>
        /// <response code="201">Returns the newly created author</response>
        /// <response code="400">If the auther info is not correct</response>
        [HttpPost]
        public IActionResult Post([FromBody] Author author)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _repository.Insert(author);
            return CreatedAtRoute("GetAuthorById", new { id = author.Id }, new { result = "done" });


        }
        /// <summary>
        /// Updates an Author.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /api/author
        ///             {
        ///               "id": 0,
        ///               "name": "author name",
        ///               "bod": "2021-03-10T07:46:49.391Z",
        ///               "country": "country"
        ///             }
        ///
        /// </remarks>
        /// <returns>The updated author</returns>
        /// <response code="200">Returns the updated author</response>
        /// <response code="400">If the auther info is not correct</response>
        [HttpPut]
        public IActionResult Update([FromBody] Author author)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _repository.Update(author);
            return Ok(author);
        }

        /// <summary>
        /// Deletes an Author.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     DELETE /api/author/1
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
