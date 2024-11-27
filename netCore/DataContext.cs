using IDataContext;

namespace netCore
{
    public class DataContext:IDataContext
    {
        public List<Doctor> Doctors { get; set; }
        public List<Treated> Treateds { get; set; }
        public List<Apointment> Apointments { get; set; }

        public DataContext()
        {

            Doctors = new List<Doctor>
            {
                  new Doctor{Id=1,Name= "Daniel Lubin", Phone="0533124356", DaysWork="1 3 5",TimeStart= new DateTime(2023, 11, 23, 10, 30, 00) },
                  new Doctor{Id=2,Name= "Shmuel Rabin",Phone= "0548415768",DaysWork="2 4",TimeStart=new DateTime(2024,12,11,14,40,00)},
                  new Doctor{Id= 3, Name= "Josef Zark", Phone= "0533457678",DaysWork= "1,5", TimeStart= new DateTime(2022, 5, 2, 20, 20, 20)}
            };

            Treateds = new List<Treated>
            {
            new Treated{IdTreated=1,NameTreated= "Rachel rubin",AddressTreated="rabi akiva", PhoneTreated="0533124356"},
            new Treated{IdTreated=2,NameTreated= "Shoshana klain",AddressTreated="Yerushalim",PhoneTreated= "0548415768"},
            new Treated{IdTreated= 3, NameTreated= "Yakov Choen", AddressTreated="ashomer",PhoneTreated= "0533457678"}
            };

             Apointments = new List<Apointment>
             {
            new Apointment{DoctorId=1,TreatedId= 8,DateTime=new DateTime(),ApointemtId=1},
            new Apointment{DoctorId=2,TreatedId= 5,DateTime=new DateTime(),ApointemtId=2},
            new Apointment{DoctorId=1,TreatedId= 9,DateTime=new DateTime(),ApointemtId=3},
            };

    }
    }
}
