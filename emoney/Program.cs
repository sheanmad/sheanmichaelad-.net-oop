using System;
using UserManagements;

namespace UserManagements
{
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
