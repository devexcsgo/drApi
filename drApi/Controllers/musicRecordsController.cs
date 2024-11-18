using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace drApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class musicRecordsController : ControllerBase
    {
        private readonly musicRecordRepo _musicRecordRepo;
        public musicRecordsController()
        {
            _musicRecordRepo = new musicRecordRepo();
        }
        // GET: api/<musicRecordsController>
        [HttpGet]
        public ActionResult<IEnumerable<musicRecord>> GetAll()
        {
            return _musicRecordRepo.GetAll().ToList();
        }

        // GET api/<musicRecordsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<musicRecordsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<musicRecordsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<musicRecordsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
