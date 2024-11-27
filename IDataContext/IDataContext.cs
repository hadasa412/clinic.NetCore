using System.Numerics;

namespace IDataContext
{
    public interface IDataContext
    {
        public List<Doctor> Doctors { get; set; }
        public List<Treated> Treateds { get; set; }
        public List<Apointment> Apointments { get; set; }

       
    }
}
