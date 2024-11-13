using System;
using System.Threading;

class Program {
    static void Main() {
        _opening();
    }

    static void _opening() {
        Console.Clear();
        Console.WriteLine("=============================");
        Console.WriteLine("🎃 HITUNG LUAS MATEMATIKA 🎃");    
        Console.WriteLine("=============================");
        Console.WriteLine("Pilih mode : ");
        Console.WriteLine("0. Exit");
        Console.WriteLine("1. Luas segitiga");
        Console.WriteLine("2. Luas jajar genjang");
        Console.WriteLine("3. Mencari Alas segitiga");
        Console.WriteLine("4. Mencari Tinggi segitiga");
        Console.WriteLine("5. Mencari Alas jajar genjang");
        Console.WriteLine("6. Mencari Tinggi jajar genjang");
        // Minta pengguna memasukkan mode hitung
        Console.Write("Masukan mode: ");
        int mode = Convert.ToInt32(Console.ReadLine());
        // Gunakan logika jika user memilih
        if (mode == 1) {
            op_luas_segitiga();
        } else if (mode == 2) {
            op_luas_jajar_genjang();
        } else if (mode == 3) {
            op_alas_segitiga();
        } else if (mode == 4) {
            op_tinggi_segitiga();
        } else if (mode == 5) {
            op_alas_jajar_genjang();
        } else if (mode == 6) {
            op_tinggi_jajar_genjang();
        } else {
            System.Environment.Exit(1);
        }
    }

    static void op_luas_segitiga() {
        WelcomeTextLuasSegitiga();
        // Minta pengguna memasukkan nilai alas
        Console.Write("Masukkan nilai alas segitiga: ");
        double alas = Convert.ToDouble(Console.ReadLine());
        // Minta pengguna memasukkan nilai tinggi
        Console.Write("Masukkan nilai tinggi segitiga: ");
        double tinggi = Convert.ToDouble(Console.ReadLine());
        // Hitung luas segitiga
        double luas = 0.5 * alas * tinggi;
        // Tampilkan hasil luas segitiga
        Console.WriteLine("Luas segitiga adalah: " + luas.ToString());
        _continue_dialogue();
    }

    static void op_luas_jajar_genjang() {
        WelcomeTextLuasJajarGenjang();
        // Minta pengguna memasukkan nilai alas
        Console.Write("Masukkan nilai alas: ");
        double alas = Convert.ToDouble(Console.ReadLine());
        // Minta pengguna memasukkan nilai tinggi
        Console.Write("Masukkan nilai tinggi: ");
        double tinggi = Convert.ToDouble(Console.ReadLine());
        // Hitung luas jajar genjang
        double luas = alas * tinggi;
        // Tampilkan hasil luas segitiga
        Console.WriteLine("Luas jajar genjang adalah: " + luas.ToString());
        _continue_dialogue();
    }

    static void op_alas_segitiga() {
        WelcomeTextAlasSegitiga();
        // Minta pengguna memasukkan nilai luas
        Console.Write("Masukkan nilai luas: ");
        double luas = Convert.ToDouble(Console.ReadLine());
        // Minta pengguna memasukkan nilai tinggi
        Console.Write("Masukkan nilai tinggi: ");
        double tinggi = Convert.ToDouble(Console.ReadLine());
        // Hitung alas segitiga
        double alas = 2 * luas / tinggi;
        // Tampilkan hasil alas segitiga
        Console.WriteLine("Alas segitiga adalah: " + alas.ToString());
        _continue_dialogue();
    }

    static void op_tinggi_segitiga() {
        WelcomeTextTinggiSegitiga();
        // Minta pengguna memasukkan nilai luas
        Console.Write("Masukkan nilai luas: ");
        double luas = Convert.ToDouble(Console.ReadLine());
        // Minta pengguna memasukkan nilai tinggi
        Console.Write("Masukkan nilai alas: ");
        double alas = Convert.ToDouble(Console.ReadLine());
        // Hitung alas segitiga
        double tinggi = 2 * luas / alas;
        // Tampilkan hasil alas segitiga
        Console.WriteLine("Tinggi segitiga adalah: " + tinggi.ToString());
        _continue_dialogue();
    }

    static void op_alas_jajar_genjang() {
        WelcomeTextAlasJG();
        // Minta pengguna memasukkan nilai luas
        Console.Write("Masukkan nilai luas: ");
        double luas = Convert.ToDouble(Console.ReadLine());
        // Minta pengguna memasukkan nilai tinggi
        Console.Write("Masukkan nilai tinggi: ");
        double tinggi = Convert.ToDouble(Console.ReadLine());
        // Hitung alas segitiga
        double alas = luas / tinggi;
        // Tampilkan hasil alas segitiga
        Console.WriteLine("Alas jajar genjang adalah: " + alas.ToString());
        _continue_dialogue();
    }

    static void op_tinggi_jajar_genjang() {
        WelcomeTextTinggiJG();
        // Minta pengguna memasukkan nilai luas
        Console.Write("Masukkan nilai luas: ");
        double luas = Convert.ToDouble(Console.ReadLine());
        // Minta pengguna memasukkan nilai tinggi
        Console.Write("Masukkan nilai alas: ");
        double alas = Convert.ToDouble(Console.ReadLine());
        // Hitung alas segitiga
        double tinggi = luas / alas;
        // Tampilkan hasil alas segitiga
        Console.WriteLine("Tinggi jajar genjang adalah: " + tinggi.ToString());
        _continue_dialogue();
    }

    static void WelcomeTextLuasSegitiga() {
        Console.WriteLine("==========================");
        Console.WriteLine("🎃 HITUNG LUAS SEGITIGA 🎃");    
        Console.WriteLine("==========================");
        Thread.Sleep(2000);
    }

    static void WelcomeTextLuasJajarGenjang() {
        Console.WriteLine("================================");
        Console.WriteLine("🎃 HITUNG LUAS JAJAR GENJANG 🎃");    
        Console.WriteLine("================================");
        Thread.Sleep(2000);
    }

    static void WelcomeTextAlasSegitiga() {
        Console.WriteLine("================================");
        Console.WriteLine("   🎃 HITUNG ALAS SEGITIGS 🎃");    
        Console.WriteLine("================================");
        Thread.Sleep(2000);
    }

    static void WelcomeTextTinggiSegitiga() {
        Console.WriteLine("================================");
        Console.WriteLine("  🎃 HITUNG TINGGI SEGITIGA 🎃");    
        Console.WriteLine("================================");
        Thread.Sleep(2000);
    }

    static void WelcomeTextAlasJG() {
        Console.WriteLine("================================");
        Console.WriteLine(" 🎃 HITUNG ALAS JAJAR GENJANG 🎃");    
        Console.WriteLine("================================");
        Thread.Sleep(2000);
    }

    static void WelcomeTextTinggiJG() {
        Console.WriteLine("================================");
        Console.WriteLine("🎃 HITUNG TINGGI JAJAR GENJANG 🎃");    
        Console.WriteLine("================================");
        Thread.Sleep(2000);
    }

    static void _continue_dialogue() {
        Console.Write("Mau mencoba rumus luas lagi? (Y/n) : ");
        string continue_sys = Console.ReadLine();
        if (continue_sys == "Y" || continue_sys == "y") {
            _opening();
        } else {
            System.Environment.Exit(1);
        }
    }
}   
