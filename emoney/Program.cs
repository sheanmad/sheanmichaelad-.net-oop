using System;

namespace UserManagement
{
    // Parent class User
    public class User
    {
        // Private field simpan duit
        private double emoney;

        // attr
        public string Nama { get; set; }
        public string Role { get; set; }

        // Public method ambil duit
        public double GetEmoney()
        {
            return emoney;
        }

        // Constructor User
        public User(string nama, string role, double emoney)
        {
            Nama = nama;
            Role = role;
            this.emoney = emoney;
        }

        // Protected method untuk update money
        protected void SetEmoney(double value)
        {
            emoney = value;
        }
    }

    // Child Admin from User
    public class Admin : User
    {
        // Constructor Admin
        public Admin() : base("", "Admin", 0) { }

        // Method tambah duit
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

    // Child Customer from User
    public class Customer : User
    {
        // Constructor for Customer class
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

    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Masukkan role anda (admin/customer):");
                string role = Console.ReadLine().ToLower();

                if (role == "customer")
                {
                    Console.WriteLine("Masukkan nama customer Anda:");
                    string namaCustomer = Console.ReadLine();
                    Customer customer = new Customer();
                    if (namaCustomer == customer.Nama)
                    {
                        customer.LihatSaldo();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Siapa itu bro ga kenal T-T coba lagi ... ");
                    }
                }
                else if (role == "admin")
                {
                    Console.WriteLine("Masukkan nama customer Anda:");
                    string namaCustomer = Console.ReadLine();

                    Customer customer = new Customer();

                    Admin admin = new Admin();
                    if (namaCustomer == customer.Nama)
                    {
                        Console.WriteLine("Masukkan jumlah saldo yang akan ditambahkan:");
                        double saldoTambahan = Convert.ToInt32(Console.ReadLine());
                        admin.TambahSaldo(customer, saldoTambahan);
                        customer.LihatSaldo();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Siapa itu bro ga kenal T-T coba lagi ... ");
                    }
                }
                else
                {
                    Console.WriteLine("Role tidak valid.");
                }
            }
        }
    }
}
