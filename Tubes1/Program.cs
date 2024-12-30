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
    public static string[,] daftarMenu_0404 = new string[100, 3]; // kapasitas awal untuk 100 menu
    private static List<string[]> pesanan_0404 = new List<string[]>();
    public static int jumlahMenu_0404 = 0; // penghitung jumlah menu


    public static void Main(string[] args)
    {
        int pilihan_0404; //deklarasi variabel pilihan
        do //tampilkan dlu pilihannya
        {
            // Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("===== Robusta Cafe =====");
            Console.ResetColor();
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Logout");
            Console.Write("Masukkan Pilihan Anda: ");
            pilihan_0404 = Convert.ToInt32(Console.ReadLine()); //menerima input pilihan user

            if (pilihan_0404 == 1)//jika kondisi pilihan = 1
            {
                // input username
                Console.Write("Masukkan Username: ");
                string inputUser_0404 = Console.ReadLine();

                // input password
                Console.Write("Masukkan Password: ");
                string inputPassword_0404 = ReadPassword_0404();

                // validasi login
                if (inputUser_0404 == username_0404 && inputPassword_0404 == password_0404)
                {
                    Console.WriteLine("\n🎉 Success login! Selamat datang, " + username_0404 + "! 🎉");

                    int fitur_0404;
                    do
                    {
                        // Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("===== Welcome to Robusta Cafe ☕ =====");
                        Console.ResetColor();
                        Console.WriteLine("1. Tambah Menu");
                        Console.WriteLine("2. Lihat Menu");
                        Console.WriteLine("3. Edit Menu");
                        Console.WriteLine("4. Hapus Menu");
                        Console.WriteLine("5. Cari Menu");
                        Console.WriteLine("6. Filter Menu");
                        Console.WriteLine("7. Pesan Menu");
                        Console.WriteLine("8. Logout");
                        Console.Write("Masukkan Pilihan Fitur Anda: ");

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
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Terima kasih sudah menggunakan Robusta Cafe! Anda berhasil logout.");
                                Console.ResetColor();
                                break;
                            default:
                                Console.WriteLine("Pilihan menu tidak valid. Silakan pilih lagi.");
                                break;
                        }
                    } while (fitur_0404 != 8);

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nUsername atau password salah. Silakan coba lagi.");
                    Console.ResetColor();
                }
            }
            else if (pilihan_0404 == 2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Terima kasih sudah bekerja hari ini, sampai jumpa lagi!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid, Silahkan pilih lagi!");
            }
            Console.WriteLine();
        } while (pilihan_0404 != 2);
    }

    public static string ReadPassword_0404() //function untuk menampilkan password menjadi *
    {
        string password_0404 = string.Empty;
        ConsoleKey key;

        do
        {
            var keyInfo_0404 = Console.ReadKey(intercept: true);
            key = keyInfo_0404.Key;

            if (key == ConsoleKey.Backspace && password_0404.Length > 0)
            {
                Console.Write("\b \b");
                password_0404 = password_0404[0..^1];
            }
            else if (!char.IsControl(keyInfo_0404.KeyChar))
            {
                Console.Write("*");
                password_0404 += keyInfo_0404.KeyChar;
            }
        } while (key != ConsoleKey.Enter);

        return password_0404;
    }

    private static void TambahMenu_0404()
    {
        Console.Write("Tambah nama menu : ");
        string namaMenu_0404 = Console.ReadLine();


        string kategoriMenu_0404;
        do
        {
            Console.Write("Masukkan kategori menu (Coffee Series/Non-Coffee Series/Dessert Series): ");
            kategoriMenu_0404 = Console.ReadLine()?.ToLower(); // convert ke lowercase untuk mempermudah validasi

            if (kategoriMenu_0404 != "coffee series" && kategoriMenu_0404 != "non-coffee series" && kategoriMenu_0404 != "dessert series")
            {
                Console.WriteLine("Jenis menu tidak valid. Silakan masukkan 'coffee series' atau 'non-coffee series' atau 'dessert series'.");
            }
        } while (kategoriMenu_0404 != "coffee series" && kategoriMenu_0404 != "non-coffee series" && kategoriMenu_0404 != "dessert series");


        int hargaMenu_0404;
        while (true) // Loop sampai input benar
        {
            try
            {
                Console.Write("Masukkan harga menu: ");
                hargaMenu_0404 = Convert.ToInt32(Console.ReadLine()); // Ini bisa menyebabkan error jika input bukan angka
                break; // Keluar dari loop jika input benar
            }
            catch (FormatException)
            {
                Console.WriteLine("Input tidak valid! Harap masukkan angka.");
            }
        }
        Console.WriteLine($"Harga menu yang dimasukkan: {hargaMenu_0404}");

        if (jumlahMenu_0404 < daftarMenu_0404.GetLength(0))
        /*jika jumlahMenu_0404 lebih kecil dari 
        kapasitas array, maka data baru masih bisa ditambahkan.*/
        {
            daftarMenu_0404[jumlahMenu_0404, 0] = namaMenu_0404; //masukkan nama menu ke array daftarMenu_0404
            daftarMenu_0404[jumlahMenu_0404, 1] = kategoriMenu_0404;
            daftarMenu_0404[jumlahMenu_0404, 2] = hargaMenu_0404.ToString();

            jumlahMenu_0404++; //data baru selalu ditambahkan pada posisi yang benar di array selagi kosong

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("🍽 Menu berhasil ditambahkan!");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("❌ Kapasitas menu penuh! Tidak dapat menambahkan menu baru.");
            Console.ResetColor();
        }

    }

    private static void LihatMenu_0404()
    {
        if (jumlahMenu_0404 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("😢 Belum ada menu yang ditambahkan.");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("\n===================== 📋 DAFTAR MENU 📋 =====================");
            // header tabel
            Console.WriteLine($"| {"No.",-5} | {"Nama Menu",-20} | {"Kategori Menu",-20} | {"Harga",-10} |"); //(-20 = lebar karakter)
            Console.WriteLine(new string('-', 55)); // garis pemisah
            for (int i = 0; i < jumlahMenu_0404; i++)
            {
                // akses data menu menggunakan indeks dua dimensi
                string namaMenu = daftarMenu_0404[i, 0]; // nama menu
                string kategoriMenu = daftarMenu_0404[i, 1]; // kategori menu
                string hargaMenu = daftarMenu_0404[i, 2]; // harga menu
                Console.WriteLine($"| {i + 1,-5} | {namaMenu,-20} | {kategoriMenu,-20} | Rp{hargaMenu,-8} |");
            }
            Console.WriteLine(new string('-', 55)); // garis pemisah
        }
    }

    private static void EditMenu_0404()
    {
        if (jumlahMenu_0404 == 0)
        {
            Console.WriteLine("Anda belum menambahkan menu.");
            return;
        }

        LihatMenu_0404();

        Console.Write("Masukkan nomor menu yang ingin Anda edit : ");
        if (!int.TryParse(Console.ReadLine(), out int nomorMenu_0404) || nomorMenu_0404 < 1 || nomorMenu_0404 > jumlahMenu_0404)
        {
            Console.WriteLine("Maaf, nomor menu yang Anda inputkan tidak valid.");
            return;
        }

        Console.Write("Masukkan nama baru untuk menu : ");       // Input nama menu baru dari username_04
        string namaBaru_0404 = Console.ReadLine();

        // Console.Write("Masukkan kategori baru untuk menu : ");   // Input kategori menu baru dari username_04
        string kategoriBaru_0404;
        do
        {
            Console.Write("Masukkan kategori menu (Coffee Series/Non-Coffee Series/Dessert Series): ");
            kategoriBaru_0404 = Console.ReadLine()?.ToLower(); // convert ke lowercase untuk mempermudah validasi

            if (kategoriBaru_0404 != "coffee series" && kategoriBaru_0404 != "non-coffee series" && kategoriBaru_0404 != "dessert series")
            {
                Console.WriteLine("Jenis menu tidak valid. Silakan masukkan 'coffee series' atau 'non-coffee series' atau 'dessert series'.");
            }
        } while (kategoriBaru_0404 != "coffee series" && kategoriBaru_0404 != "non-coffee series" && kategoriBaru_0404 != "dessert series");

        Console.Write("Masukkan harga baru untuk menu : ");      // Input harga menu baru dari username_04
        string hargaBaru_0404 = Console.ReadLine();

        // Update menu di posisi yang dipilih
        daftarMenu_0404[nomorMenu_0404 - 1, 0] = namaBaru_0404;      // Nama menu
        daftarMenu_0404[nomorMenu_0404 - 1, 1] = kategoriBaru_0404;  // Kategori menu
        daftarMenu_0404[nomorMenu_0404 - 1, 2] = hargaBaru_0404;     // Harga menu

        Console.WriteLine("Menu berhasil diupdate!");
    }
    private static void HapusMenu_0404()
    {
        if (jumlahMenu_0404 == 0)
        {
            Console.WriteLine("Tidak ada menu untuk dihapus.");
            return;
        }

        LihatMenu_0404();

        Console.Write("Masukkan nomor menu yang ingin dihapus (1 - {0}): ", jumlahMenu_0404);
        string input_0404 = Console.ReadLine();

        // Validasi input
        if (int.TryParse(input_0404, out int nomorMenu_0404) && nomorMenu_0404 >= 1 && nomorMenu_0404 <= jumlahMenu_0404)
        {
            // Konversi nomor menu ke indeks array (indeks mulai dari 0)
            int indexMenu_0404 = nomorMenu_0404 - 1;

            // Geser elemen-elemen setelah menu yang dihapus
            for (int i = indexMenu_0404; i < jumlahMenu_0404 - 1; i++)
            {
                daftarMenu_0404[i, 0] = daftarMenu_0404[i + 1, 0]; // Menggeser nama menu
                daftarMenu_0404[i, 1] = daftarMenu_0404[i + 1, 1]; // Menggeser kategori menu
                daftarMenu_0404[i, 2] = daftarMenu_0404[i + 1, 2]; // Menggeser harga menu
            }

            jumlahMenu_0404--; // Mengurangi jumlah menu setelah penghapusan
            Console.WriteLine("Menu berhasil dihapus!");
        }
        else
        {
            Console.WriteLine("Nomor menu tidak valid. Mohon inputkan kembali.");
        }
    }
    private static void CariMenu_0404()
    {
        if (jumlahMenu_0404 == 0)
        {
            Console.WriteLine("Belum ada menu yang tersedia untuk dicari.");
            return;
        }

        Console.Write("Masukkan nama menu yang dicari: ");
        string keyword = Console.ReadLine().ToLower(); // konversi ke huruf kecil untuk mempermudah pencarian

        bool keyDitemukan_0404 = false;
        Console.WriteLine("\nHasil Pencarian:");
        Console.WriteLine($"{"No.",-5}{"Nama Menu",-20}{"Kategori Menu",-20}{"Harga",-10}");
        Console.WriteLine(new string('-', 55)); // garis pemisah

        for (int i = 0; i < jumlahMenu_0404; i++)
        {
            if (daftarMenu_0404[i, 0].ToLower().Contains(keyword))
            {
                Console.WriteLine($"{i + 1,-5}{daftarMenu_0404[i, 0],-20}{daftarMenu_0404[i, 1],-20}Rp{daftarMenu_0404[i, 2],-10}");
                keyDitemukan_0404 = true;
            }
        }

        if (!keyDitemukan_0404)
        {
            Console.WriteLine("Menu tidak tersedia");
        }

        Console.WriteLine(new string('-', 55)); // garis pemisah
    }
    private static void FilterMenu_0404()
    {
        if (jumlahMenu_0404 == 0)
        {
            Console.WriteLine("Belum ada menu yang tersedia untuk difilter.");
            return;
        }

        Console.WriteLine("-- Filter Menu Berdasarkan Kategori --");
        Console.WriteLine("Pilih kategori yang ingin ditampilkan:");
        Console.WriteLine("1. Coffee Series");
        Console.WriteLine("2. Non-Coffee Series");
        Console.WriteLine("3. Dessert Series");

        Console.Write("Masukkan pilihan kategori (1-3): ");
        string pilihanKategori = Console.ReadLine();

        string kategoriFilter_0404 = "";
        switch (pilihanKategori)
        {
            case "1":
                kategoriFilter_0404 = "coffee series";
                break;
            case "2":
                kategoriFilter_0404 = "non-coffee series";
                break;
            case "3":
                kategoriFilter_0404 = "dessert series";
                break;
            default:
                Console.WriteLine("Pilihan tidak valid. Silakan masukkan angka 1-3.");
                return;
        }

        // Filter menu berdasarkan kategori yang dipilih
        Console.WriteLine($"\nMenampilkan menu untuk kategori: {kategoriFilter_0404.ToUpper()}");
        Console.WriteLine($"{"No.",-5}{"Nama Menu",-20}{"Kategori Menu",-20}{"Harga",-10}");
        Console.WriteLine(new string('-', 55));

        bool ditemukan_0404 = false;
        for (int i = 0; i < jumlahMenu_0404; i++)
        {
            if (daftarMenu_0404[i, 1].ToLower() == kategoriFilter_0404)
            {
                Console.WriteLine($"{i + 1,-5}{daftarMenu_0404[i, 0],-20}{daftarMenu_0404[i, 1],-20}Rp{daftarMenu_0404[i, 2],-10}");
                ditemukan_0404 = true;
            }
        }

        if (!ditemukan_0404)
        {
            Console.WriteLine($"Tidak ada menu dalam kategori '{kategoriFilter_0404}'.");
        }

        Console.WriteLine(new string('-', 55));
    }
    private static void Pemesanan_0404()
    {
        pesanan_0404.Clear(); // hapus pesanan sebelumnya
        if (jumlahMenu_0404 == 0)
        {
            Console.WriteLine("❌ Belum ada menu yang tersedia untuk dipesan.");
            return;
        }
        LihatMenu_0404(); //tampilkan menu yang ada
        bool pesanLagi_0404 = true;
        while (pesanLagi_0404)
        {
            // meminta user memilih menu
            Console.Write("\nMasukkan nomor menu yang ingin dipesan: ");
            int nomorMenu_0404 = Convert.ToInt32(Console.ReadLine()) - 1; // kurangi 1 karena indeks dimulai dari 0

            if (nomorMenu_0404 < 0 || nomorMenu_0404 >= jumlahMenu_0404)
            {
                Console.WriteLine("Nomor menu tidak valid.");
                continue;
            }

            // meminta user jumlah pesanan
            Console.Write("Masukkan jumlah yang ingin dipesan: ");
            int jumlahItem_0404 = Convert.ToInt32(Console.ReadLine());

            if (jumlahItem_0404 <= 0)
            {
                Console.WriteLine("Jumlah pesanan tidak valid.");
                continue;
            }

            // mengambil harga menu yang dipilih pada array daftarmenu berdasarkan nomorMenu
            int hargaMenu_0404 = Convert.ToInt32(daftarMenu_0404[nomorMenu_0404, 2]);

            // hitung total harga
            int totalHarga_0404 = hargaMenu_0404 * jumlahItem_0404;

            // simpan pesanan dalam list
            string[] newOrder_0404 = new string[]
            {
            daftarMenu_0404[nomorMenu_0404, 0], // nama menu
            daftarMenu_0404[nomorMenu_0404, 1], // kategori menu
            hargaMenu_0404.ToString(), // harga per item
            jumlahItem_0404.ToString(), // jumlah item
            totalHarga_0404.ToString() // total harga
            };
            pesanan_0404.Add(newOrder_0404); // menambahkan pesanan ke list

            // apakah pengguna ingin menambah pesanan?
            Console.Write("\nApakah Anda ingin memesan menu lain? (y/n): ");
            string pilihan_0404 = Console.ReadLine().ToLower();
            if (pilihan_0404 != "y")
            {
                pesanLagi_0404 = false; // jika tidak, keluar dari loop
            }
        }

        SimpanInvoice_0404(pesanan_0404); //jalankan func simpan invoice

    }

    private static void SimpanInvoice_0404(List<string[]> pesanan_0404) //menerima parameter berupa List<string[]> dari pesanan_0404
    {
        // simpan invoice ke dalam file
        string timeStamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
        string filePath = $"invoice_robusta_cafe_{timeStamp}.txt";  // penentuan nama file untuk menyimpan invoice

        using (StreamWriter writer = new StreamWriter(filePath)) //streamWriter: Digunakan untuk menulis teks ke file
        {
            // header invoice
            writer.WriteLine("========= INVOICE ROBUSTA CAFE =========");
            writer.WriteLine($"Tanggal: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
            writer.WriteLine(new string('-', 88)); // garis pemisah
            writer.WriteLine($"{"No.",-5}{"Nama Menu",-20} {"Kategori Menu",-10} {"Harga",-10} {"Jumlah",-10} {"Total Harga",-10}");
            writer.WriteLine(new string('-', 88)); // garis pemisah

            // tulis setiap pesanan ke dalam file
            int totalPembayaran_0404 = 0;
            for (int i = 0; i < pesanan_0404.Count; i++)
            {
                var order_0404 = pesanan_0404[i];
                writer.WriteLine($"{i + 1,-5} {order_0404[0],-20} {order_0404[1],-10} Rp{order_0404[2],-10} {order_0404[3],-10} Rp{order_0404[4],-10}");
                totalPembayaran_0404 += Convert.ToInt32(order_0404[4]);
            }

            // tulis total pembayaran
            writer.WriteLine(new string('-', 88)); // garis pemisah
            writer.WriteLine($"Total Pembayaran{"",-40} Rp{totalPembayaran_0404,-10}");
            writer.WriteLine("\nThanks for your order!");
            writer.WriteLine(new string('=', 88)); // garis pemisah  
        }

        // informasikan bahwa invoice telah disimpan ke file
        Console.WriteLine($"\nInvoice telah disimpan di file '{filePath}'.");
    }

}