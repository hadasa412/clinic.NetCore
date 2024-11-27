using System.Numerics;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace netCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {

        private readonly IDataContext _context;

        public DoctorController(IDataContext context)
        {
            _context = context;
        }

        // GET: api/<DoctorController>
        [HttpGet]
        public IEnumerable<Doctor> Get()
        {
            return _context.Doctors;
        }

        // GET api/<DoctorController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var d = _context.Doctors.FirstOrDefault(f => f.Id == id);
            if (d != null)
            {
                return Ok(d);
            }
            else
            {
                return NotFound();
            }
        }
        // POST api/<DoctorController>
        [HttpPost]
        public void Post([FromBody] Doctor d)
        {
            _context.Doctors.Add(d);
        }

        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public void put(int id, string name = "", string phone = "", string daysWork = "", DateTime timeStart = default)
        {
            if (name != "")
            {
                _context.Doctors.Find(t => t.Id == id).Name = name;
            }
            if (phone != "")
            {
                _context.Doctors.Find(t => t.Id == id).Phone = phone;
            }
            if (daysWork != "")
            {
                _context.Doctors.Find(t => t.Id == id).DaysWork = daysWork;
            }
            if (timeStart != default)
            {
                _context.Doctors.Find(t => t.Id == id).TimeStart = timeStart;
            }
        }



        // DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


    } 
}
