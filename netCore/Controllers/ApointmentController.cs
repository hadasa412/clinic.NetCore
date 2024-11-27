using Microsoft.AspNetCore.Mvc;
using IDataContext;
 

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace netCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApointmentController : ControllerBase
    {
        private readonly IDataContext _context;
        public ApointmentController(IDataContext context)
        {
            _context = context;
        }
        public enum Filtertype { Doctor, Treated };

        // GET: api/<ApointmentController>
        //שליפת כל התורים לרופא מסוים
        //שליפת כל התורים למטופל מסוים
        [HttpGet]
        public IEnumerable<Apointment> GetAllApointmentsToPazient(int filterId, Filtertype filtertype)
        {
            return _context.Apointments.Where(f => filtertype == Filtertype.Doctor ? f.DoctorId == filterId : f.TreatedId == filterId).ToList();
        }

        // GET api/<ApointmentController>/5
        //שלפית תור לפי מזהה ספציפי
        [HttpGet("{id}")]
        public Apointment Get(int apointmentId)
        {
            return _context.Apointments.FirstOrDefault(f => f.ApointemtId == apointmentId);

        }

        // POST api/<ApointmentController>
        [HttpPost]
        public void Post(Apointment a)
        {
            _context.Apointments.Add(a);
        }

        // PUT api/<ApointmentController>/5
        [HttpPut]
        public void Put(int doctorId = 0, int treatedId = 0, DateTime dateTime = new DateTime(), int apointmentId = 0)
        {
            if (doctorId != 0)
            {
                _context.Apointments.Find(t => t.ApointemtId == apointmentId).DoctorId = doctorId;
            }
            if (treatedId != 0)
            {
                _context.Apointments.Find(t => t.ApointemtId == apointmentId).TreatedId = treatedId;
            }
            if (dateTime != new DateTime())
            {
                _context.Apointments.Find(t => t.ApointemtId == apointmentId).DateTime = dateTime;
            }
        }

        // DELETE api/<ApointmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int apointmentId)
        {
            var apointmentToRemove = _context.Apointments.FirstOrDefault(f => f.ApointemtId == apointmentId);

            if (apointmentToRemove != null)
            {
                _context.Apointments.Remove(apointmentToRemove);
            }
        }
    }
}
