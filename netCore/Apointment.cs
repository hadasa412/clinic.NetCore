namespace netCore
{
    public class Apointment
    {
        public int ApointemtId { get; set; }
        public int DoctorId { get; set; }
        public int TreatedId { get; set; }
        public DateTime DateTime { get; set; }

        public Apointment()
        {
        }

        public Apointment(int doctorId, int treatedId, DateTime dateTime, int apointemtId)
        {
            this.DoctorId = doctorId;
            this.TreatedId = treatedId;
            this.DateTime = dateTime;
            ApointemtId = apointemtId;
        }

    }
}
