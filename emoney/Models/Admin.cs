namespace UserManagements
{
    public class Admin : User
    {
        public Admin() : base("", "Admin", 0) { }

        public void TambahSaldo(Customer customer, double jumlah)
        {
            if (jumlah > 0)
            {
                customer.AddBalance(jumlah);
                Console.WriteLine($"Saldo berhasil ditambah, saldo sekarang: {customer.GetEmoney()}");
            }
            else
            {
                Console.WriteLine("Anda bangkrut karena uang anda minus :P");
            }
        }
    }
}
