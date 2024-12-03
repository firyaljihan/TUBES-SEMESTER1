using System;
    class Program
    {
        private static string username_0404 = "adminrobusta";
        private static string password_0404 = "12345";

        static void Main(string[] args)
        {
            Console.WriteLine("===== Welcome to Robusta Cafe =====");
            Console.WriteLine("---------- Silakan login ----------");

            // Input username
            Console.Write("Masukkan Username: ");
            string inputUser_0404 = Console.ReadLine();

            // Input password (disembunyikan di CMD)
            Console.Write("Masukkan Password: ");
            string inputPassword_0404 = ReadPassword();

            // Validasi login
            if (inputUser_0404 == username_0404 && inputPassword_0404 == password_0404)
            {
                Console.WriteLine("\nLogin berhasil! Selamat datang, " + username_0404 + ".");
            }
            else
            {
                Console.WriteLine("\nLogin gagal! Username atau password salah.");
            }
        }

        // Fungsi untuk membaca password tanpa menampilkan karakter di CMD
        private static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    password += key.KeyChar;
                    Console.Write("*"); // Tampilkan tanda bintang
                }
                else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password = password.Substring(0, password.Length - 1);
                    Console.Write("\b \b"); // Hapus karakter terakhir
                }
            } while (key.Key != ConsoleKey.Enter);

            Console.WriteLine();
            return password;
        }
    }
