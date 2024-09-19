namespace UserManagements
{
    // Parent class User
    public class User
    {
        private double emoney;

        public string Nama { get; set; }
        public string Role { get; set; }

        public double GetEmoney()
        {
            return emoney;
        }

        public User(string nama, string role, double emoney)
        {
            Nama = nama;
            Role = role;
            this.emoney = emoney;
        }

        protected void SetEmoney(double value)
        {
            emoney = value;
        }
    }
}
