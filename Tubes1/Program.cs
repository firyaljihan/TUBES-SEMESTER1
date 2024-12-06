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
    private static string username_0404 = "adminrobusta";
    private static string password_0404 = "12345";
    public static void Main(string[] args)
    {
        int pilihan_0404;
        do
        {
            Console.WriteLine("===== Robusta Cafe =====");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Logout");
            Console.Write("Masukkan Pilihan Anda : ");
            pilihan_0404 = Convert.ToInt32(Console.ReadLine());

            if (pilihan_0404 == 1)
            {
                // Input username
                Console.Write("Masukkan Username: ");
                string inputUser_0404 = Console.ReadLine();

                // Input password
                Console.Write("Masukkan Password: ");
                string inputPassword_0404 = Console.ReadLine();

                // Validasi login
                if (inputUser_0404 == username_0404 && inputPassword_0404 == password_0404)
                {
                    Console.WriteLine("\nSuccess login! Selamat datang, " + username_0404 + "!");
                    int menu_0404;
                    do
                    {
                        Console.WriteLine("===== Welcome to Robusta Cafe =====");
                        Console.WriteLine("1. Tambah Menu");
                        Console.WriteLine("2. Lihat Menu");
                        Console.WriteLine("3. Edit Menu");
                        Console.WriteLine("4. Hapus Menu");
                        Console.WriteLine("5. Cari Menu");
                        Console.WriteLine("6. Filter Menu");
                        Console.WriteLine("7. Logout");
                        Console.Write("Masukkan Pilihan Menu Anda : ");
                        // menu_0404 = Convert.ToInt32(Console.ReadLine());

                        if (!int.TryParse(Console.ReadLine(), out menu_0404))
                        {
                            Console.WriteLine("Input tidak valid. Silakan masukkan angka.");
                            continue;
                        }

                        switch (menu_0404)
                        {
                            case 1:
                                Console.WriteLine("Fitur Tambah Menu belum tersedia.");
                                break;
                            case 2:
                                Console.WriteLine("Fitur Lihat Menu belum tersedia.");
                                break;
                            case 3:
                                Console.WriteLine("Fitur Edit Menu belum tersedia.");
                                break;
                            case 4:
                                Console.WriteLine("Fitur Hapus Menu belum tersedia.");
                                break;
                            case 5:
                                Console.WriteLine("Fitur Cari Menu belum tersedia.");
                                break;
                            case 6:
                                Console.WriteLine("Fitur Filter Menu belum tersedia.");
                                break;
                            case 7:
                                Console.WriteLine("Anda berhasil logout dari menu.");
                                break;
                            default:
                                Console.WriteLine("Pilihan menu tidak valid. Silakan pilih lagi.");
                                break;

                        }
                    } while (menu_0404 != 7);
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
}