namespace netCore
{
    public class Treated
    {
        public int IdTreated { get; set; }
        public string NameTreated { get; set; }
        public string AddressTreated { get; set; }
        public string PhoneTreated { get; set; }

        public Treated()
        {
        }

        public Treated(int idTreated, string nameTreated, string addressTreated, string phoneTreated)
        {
            IdTreated = idTreated;
            NameTreated = nameTreated;
            AddressTreated = addressTreated;
            PhoneTreated = phoneTreated;
        }

    }
}
