using System;
using tp4_103082400038;

class Program
{
    static void Main(string[] args)
    {
        KodePos kp = new KodePos();

        Console.WriteLine("Kode Pos Batununggal: " + kp.getKodePos("Batununggal"));
        Console.WriteLine("Kode Pos Kujangsari: " + kp.getKodePos("Kujangsari"));
        Console.WriteLine("Kode Pos Mengger: " + kp.getKodePos("Mengger"));

        Console.WriteLine("\nTekan enter untuk lanjut ke simulasi pintu...");
        Console.ReadLine();

        DoorMachine pintu = new DoorMachine();

        pintu.Buka();
        pintu.Kunci();
    }
}