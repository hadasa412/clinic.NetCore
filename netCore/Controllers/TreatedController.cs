using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace netCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatedController : ControllerBase
    {
        private readonly IDataContext _context;
        public TreatedController(IDataContext context)
        {
            _context = context;
        }


        // GET: api/<Nurse>
        [HttpGet]
        public IEnumerable<Treated> Get()
        {
            return _context.Treateds;

        }

        // GET api/<Nurse>/5
        [HttpGet("{id}")]
        public Treated Get(int id)
        {
            return _context.Treateds.FirstOrDefault(f => f.IdTreated == id);
        }

        // POST api/<Nurse>
        [HttpPost]
        public void Post([FromBody] Treated t)
        {
            _context.Treateds.Add(t);
        }

        // PUT api/<Nurse>/5
        [HttpPut("{id}")]
        public void Put(int idTreated, string nameTreated = "", string addressTreated = "", string phoneTreated = "")
        {
            if (nameTreated != "")
            {
                _context.Treateds.Find(t => t.IdTreated == idTreated).NameTreated = nameTreated;
            }

            if (addressTreated != "")
            {
                _context.Treateds.Find(t => t.IdTreated == idTreated).AddressTreated = addressTreated;
            }

            if (phoneTreated != "")
            {
                _context.Treateds.Find(t => t.IdTreated == idTreated).PhoneTreated = phoneTreated;
            }
        }
        //// DELETE api/<TreatedController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
