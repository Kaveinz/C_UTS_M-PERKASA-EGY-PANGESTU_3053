using System.Collections.Generic;
using System.Windows.Markup;

internal class Program

{
    private static void Main(string[] args)
    {
        buku_fiksi kancil = new buku_fiksi("si kancil", "atok", "12 April 2004");
        buku_fiksi gajah = new buku_fiksi("si gajah", "atok", "18 April 2004");
        buku_non_fiksi ipa1 = new buku_non_fiksi("IPA kelas 1", "Dinas", "13 November 2006");
        buku_non_fiksi ipa2 = new buku_non_fiksi("IPA kelas 2", "Dinas", "17 November 2006");
        majalah model = new majalah("trend baju 2024", "fashoin.com", "15 Maret 2024");
        majalah model2 = new majalah("trend baju 2025", "fashoin.com", "15 Maret 2025");


        List<string> judul_buku = new List<string>();
        judul_buku.Add(kancil.judul);
        judul_buku.Add(gajah.judul);
        judul_buku.Add(ipa1.judul);
        judul_buku.Add(ipa2.judul);
        judul_buku.Add(model.judul);
        judul_buku.Add(model2.judul);
        List<string> penulis_buku = new List<string>();
        judul_buku.Add(kancil.penulis);
        judul_buku.Add(gajah.penulis);
        judul_buku.Add(ipa1.penulis);
        judul_buku.Add(ipa2.penulis);
        judul_buku.Add(model.penulis);
        judul_buku.Add(model2.penulis);
        List<string> rilis_buku = new List<string>();
        judul_buku.Add(kancil.tahun_terbit);
        judul_buku.Add(gajah.tahun_terbit);
        judul_buku.Add(ipa1.tahun_terbit);
        judul_buku.Add(ipa2.tahun_terbit);
        judul_buku.Add(model.tahun_terbit);
        judul_buku.Add(model2.tahun_terbit);
        List <object> daftar_perpustakaan = new List<object>();

        daftar_perpustakaan.Add(kancil);
        daftar_perpustakaan.Add(gajah);
        daftar_perpustakaan.Add(ipa1);
        daftar_perpustakaan.Add(ipa2);
        daftar_perpustakaan.Add(model2);
        daftar_perpustakaan.Add(model2);

        Console.Write("ingin melakukan apa? (menambah buku/merubah buku/melihat informasi/menyimpan data buku/meminjam(maksimal 3)/ mengembalikan/melihat daftar yang dipinjam: ");
        string apa_yang_dilakukan = Console.ReadLine().ToLower();

        if (apa_yang_dilakukan == "menambah buku")
        {

            Console.Write("mau menambah buku apa (fiksi/non fiksi/majalah) : ");
            string menambah = Console.ReadLine().ToLower();
            Console.Write("judulnya : ");
            string judul = Console.ReadLine();
            Console.Write("siapa penulisnya : ");
            string penulis = Console.ReadLine();
            Console.Write("tahun terbitnya : ");
            string tahun_terbit = Console.ReadLine();

            if (menambah == "fiksi")
            {

            }


        }
        if (apa_yang_dilakukan == "melihat informasi")
        {
            foreach (string item in judul_buku)
            {
                Console.WriteLine(item);
            }


            foreach (string item in penulis_buku)
            {
                Console.WriteLine(item);
            }
           


            foreach (string item in rilis_buku)
            {
                Console.WriteLine(item);
            }
        }

    }



}


abstract class buku()
{
    public string judul;
    public string penulis;
    public string tahun_terbit;
    public virtual void Deskripsi ()
    {

        Console.WriteLine($"judul dari buku ini adalah {judul} dan ditulis oleh {penulis} diterbitkan pada tahun {tahun_terbit}");
    }
}



class buku_fiksi: buku
{

    public buku_fiksi(string judul, string penulis, string tahun_terbit)
    
    {
       
        base.judul = judul;
        base.penulis = penulis;
        base.tahun_terbit = tahun_terbit;

    }

    public override void Deskripsi()
    {
        base.Deskripsi();
    }

}

class buku_non_fiksi : buku
{

    public buku_non_fiksi(string judul, string penulis, string tahun_terbit)
    {

        this.judul = judul;
        this.penulis = penulis;
        this.tahun_terbit = tahun_terbit;

    }

    public override void Deskripsi()
    {
         base.Deskripsi();
    }

}

class majalah : buku
{

    public majalah(string judul, string penulis, string tahun_terbit)
    {

        this.judul = judul;
        this.penulis = penulis;
        this.tahun_terbit = tahun_terbit;

    }

    public override void Deskripsi()
    {
        base.Deskripsi();
    }

}
