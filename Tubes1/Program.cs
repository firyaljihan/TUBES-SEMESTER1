//Kelas : IS-07-04
//Kelompok : 04
//Anggota Kelompok :
// 1. Firyal Jihan Haura (102062400119)
// 2. Rizqy Dharmawan (102062400123)
// 3. Savira Desti Erinanda (102062430015)
// 4. Farhan Jessen Irfananda (102062430002)
// 5. Berlian Sepasya Rekardian (102062400088)

using System;
public class MyProgram
{
    private static string username_0404 = "adminrobusta"; //membuat function set username
    private static string password_0404 = "12345"; //membuat function set username
    public static string[] menu_0404 = new string[100]; // kapasitas awal untuk 100 menu
    public static string[] kategori_0404 = new string[100];
    public static int[] harga_0404 = new int[100];
    public static int jumlahMenu_0404 = 0; // penghitung jumlah menu


    public static void Main(string[] args)
    {
        int pilihan_0404; //deklarasi variabel pilihan
        do //tampilkan dlu pilihannya
        {
            Console.WriteLine("===== Robusta Cafe =====");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Logout");
            Console.Write("Masukkan Pilihan Anda : ");
            pilihan_0404 = Convert.ToInt32(Console.ReadLine()); //menerima input pilihan user

            if (pilihan_0404 == 1)//jika kondisi pilihan = 1
            {
                // input username
                Console.Write("Masukkan Username: ");
                string inputUser_0404 = Console.ReadLine();

                // input password
                Console.Write("Masukkan Password: ");
                string inputPassword_0404 = ReadPassword();

                // validasi login
                if (inputUser_0404 == username_0404 && inputPassword_0404 == password_0404)
                {
                    Console.WriteLine("\nSuccess login! Selamat datang, " + username_0404 + "!");
                    int fitur_0404;
                    do
                    {
                        Console.WriteLine("===== Welcome to Robusta Cafe =====");
                        Console.WriteLine("1. Tambah Menu");
                        Console.WriteLine("2. Lihat Menu");
                        Console.WriteLine("3. Edit Menu");
                        Console.WriteLine("4. Hapus Menu");
                        Console.WriteLine("5. Cari Menu");
                        Console.WriteLine("6. Filter Menu");
                        Console.WriteLine("7. Pesan Menu");
                        Console.WriteLine("8. Logout");
                        Console.Write("Masukkan Pilihan Menu Anda : ");

                        if (!int.TryParse(Console.ReadLine(), out fitur_0404))
                        {
                            Console.WriteLine("Input tidak valid. Silakan masukkan angka.");
                            continue;
                        }

                        switch (fitur_0404)
                        {
                            case 1:
                                TambahMenu_0404(); //memanggil function tambahMenu
                                break;
                            case 2:
                                LihatMenu_0404(); //memanggil function lihatMenu
                                break;
                            case 3:
                                EditMenu_0404();
                                break;
                            case 4:
                                HapusMenu_0404();
                                break;
                            case 5:
                                CariMenu_0404();
                                break;
                            case 6:
                                FilterMenu_0404();
                                break;
                            case 7:
                                Pemesanan_0404();
                                break;
                            case 8:
                                Console.WriteLine("Anda berhasil logout dari menu.");
                                break;
                            default:
                                Console.WriteLine("Pilihan menu tidak valid. Silakan pilih lagi.");
                                break;
                        }
                    } while (fitur_0404 != 8);

                }
                else
                {
                    Console.WriteLine("\nUsername atau password salah.");
                }
            }
            else if (pilihan_0404 == 2)
            {
                Console.WriteLine("Terima kasih sudah bekerja hari ini :)");
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid, Silahkan pilih lagi!");
            }
            Console.WriteLine();
        } while (pilihan_0404 != 2);
    }

    public static string ReadPassword() //function untuk menampilkan password menjadi *
    {
        string password = string.Empty;
        ConsoleKey key;

        do
        {
            var keyInfo = Console.ReadKey(intercept: true);
            key = keyInfo.Key;

            if (key == ConsoleKey.Backspace && password.Length > 0)
            {
                Console.Write("\b \b");
                password = password[0..^1];
            }
            else if (!char.IsControl(keyInfo.KeyChar))
            {
                Console.Write("*");
                password += keyInfo.KeyChar;
            }
        } while (key != ConsoleKey.Enter);

        return password;
    }

    private static void TambahMenu_0404()
    {
        Console.Write("Tambah nama menu : ");
        string namaMenu_0404 = Console.ReadLine();

        string kategoriMenu_0404;
        do
        {
            Console.Write("Masukkan kategori menu (Coffee Series/Non-Coffe Series/Dessert Series): ");
            kategoriMenu_0404 = Console.ReadLine()?.ToLower(); // convert ke lowercase untuk mempermudah validasi

            if (kategoriMenu_0404 != "coffee series" && kategoriMenu_0404 != "non-coffe series" && kategoriMenu_0404 != "dessert series")
            {
                Console.WriteLine("Jenis menu tidak valid. Silakan masukkan 'coffee series' atau 'non-coffe series' atau 'dessert series'.");
            }
        } while (kategoriMenu_0404 != "coffee series" && kategoriMenu_0404 != "non-coffe series" && kategoriMenu_0404 != "dessert series");


        Console.Write("Masukkan harga menu : ");
        int hargaMenu_0404 = Convert.ToInt32(Console.ReadLine());

        if (jumlahMenu_0404 < menu_0404.Length) //jika masih ada ruang kosong
        {
            menu_0404[jumlahMenu_0404] = namaMenu_0404; //masukkan nama menu ke array menu_0404
            kategori_0404[jumlahMenu_0404] = kategoriMenu_0404;
            harga_0404[jumlahMenu_0404] = hargaMenu_0404;
            jumlahMenu_0404++; //data baru selalu ditambahkan pada posisi yang benar di array selagi kosong

            Console.WriteLine("Menu berhasil ditambahkan!");
        }
        else
        {
            Console.WriteLine("Kapasitas menu penuh! Tidak dapat menambahkan menu baru.");
        }

    }

    private static void LihatMenu_0404()
    {
        Console.Write("Coming soon");
    }

    private static void EditMenu_0404()
    {
        Console.Write("Coming soon");
    }
    private static void HapusMenu_0404()
    {
        Console.Write("Coming soon");
    }
    private static void CariMenu_0404()
    {
        Console.Write("Coming soon");
    }
    private static void FilterMenu_0404()
    {
        Console.Write("Coming soon");
    }
    private static void Pemesanan_0404()
    {
        Console.Write("Coming soon");
    }

}