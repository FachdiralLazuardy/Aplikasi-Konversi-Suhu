using System;

class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;

        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine("===== Aplikasi Konversi Suhu =====");
            Console.WriteLine("Pilih salah satu opsi untuk di Konversikan:");
            Console.WriteLine("1. Celcius ke Fahrenheit");
            Console.WriteLine("2. Celcius ke Kelvin");
            Console.WriteLine("3. Celcius ke Reamur");
            Console.WriteLine("4. Exit");
            Console.WriteLine("==================================");
            Console.Write("Masukkan pilihan Anda: ");

            string pilihan = Console.ReadLine();

            double celcius, hasil;

            switch (pilihan)
            {
                case "1":
                    Console.Write("Masukkan suhu dalam satuan Celcius: ");
                    celcius = Convert.ToDouble(Console.ReadLine());
                    hasil = (celcius * 9 / 5) + 32; // Rumus Celcius ke Fahrenheit
                    Console.WriteLine("Hasil Konversi: {0} Celcius = {1} Fahrenheit", celcius, hasil);
                    break;

                case "2":
                    Console.Write("Masukkan suhu dalam satuan Celcius: ");
                    celcius = Convert.ToDouble(Console.ReadLine());
                    hasil = celcius + 273; // Rumus Celcius ke Kelvin
                    Console.WriteLine("Hasil Konversi: {0} Celcius = {1} Kelvin", celcius, hasil);
                    break;

                case "3":
                    Console.Write("Masukkan suhu dalam satuan Celcius: ");
                    celcius = Convert.ToDouble(Console.ReadLine());
                    hasil = celcius * 4 / 5; // Rumus Celcius ke Reamur
                    Console.WriteLine("Hasil Konversi: {0} Celcius = {1} Reamur", celcius, hasil);
                    break;

                case "4":
                    isRunning = false; // Keluar dari program
                    Console.WriteLine("Terima kasih karena sudah mencoba <3");
                    break;

                default:
                    Console.WriteLine("Pilihan tidak ada. Silakan coba lagi.");
                    break;
            }

            if (isRunning)
            {
                Console.WriteLine("========= HASIL KONVERSI =========");
                Console.WriteLine("Nah sudah tau kan? Ayo kembali ke halaman utama, tekan tombol apa saja.");
                Console.ReadKey();
                    }
        }
    }
}