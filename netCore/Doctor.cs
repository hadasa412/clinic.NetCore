namespace netCore
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string DaysWork { get; set; }
        public DateTime TimeStart { get; set; }

        public Doctor()
        {
        }

        public Doctor(int id, string name, string phone, string daysWork, DateTime timeStart)
        {
            this.Id = id;
            this.Name = name;
            this.Phone = phone;
            this.DaysWork = daysWork;
            this.TimeStart = timeStart;

        }
    }
}
