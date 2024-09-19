namespace UserManagements
{
    public class Customer : User
    {
        public Customer() : base("William", "Customer", 10000) { }

        public void AddBalance(double jumlah)
        {
            SetEmoney(GetEmoney() + jumlah);
        }

        public void LihatSaldo()
        {
            Console.WriteLine($"Saldo: {GetEmoney()}");
        }
    }
}
