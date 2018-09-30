using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using odatacoresample.Data;
using odatacoresample.Model;

namespace odatacoresample.Controllers
{
    [Produces("application/json")]
    [Route("api/Book")]
    public class BookController : ODataController
    {
        private DataContext Context { get; set; }

        public BookController(DataContext context)
        {
            this.Context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpPost]
        public IActionResult Post([FromBody] Book model)
        {
            this.Context.Books.Add(model);
            this.Context.SaveChanges();

            return Created("/api/book/" + model.Id, model);
        }

        [EnableQuery]
        public IQueryable<Book> Get() => Context.Books.AsQueryable();
    }
}