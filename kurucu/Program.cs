using System;


namespace kurucu
{
    class Program
    {
        static void Main(string[] args)
        {
            calisan calisan1=new calisan();
            calisan1.Ad="Volkan";
            calisan1.Soyad="Şallı";
            calisan1.No=00001004;
            calisan1.Departman="IT";
            Console.WriteLine("calisan1 bilgileri*****************************");
            calisan1.CalisanBilgileri();

            calisan calisan2=new calisan();
            calisan2.Ad="Polat";
            calisan2.Soyad="Alemdar";
            calisan2.No=00000001;
            calisan2.Departman="KGT";
            Console.WriteLine("calisan2 bilgileri*****************************");
            calisan2.CalisanBilgileri();

            calisan calisan3=new calisan("Mustafa","Kemal",1,"TSK");
            Console.WriteLine("calisan3 bilgileri*****************************");
            calisan3.CalisanBilgileri();
            
            calisan calisan4=new calisan("Cem","Ersever");
            Console.WriteLine("calisan4 bilgileri*****************************");
            calisan4.CalisanBilgileri();




        }
    }
    

}

class calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;
    
    public void CalisanBilgileri()
        {
            Console.WriteLine("Calisanin Adi {0}",Ad);
            Console.WriteLine("Calisanin Adi {0}",Soyad);
            Console.WriteLine("Calisanin Adi {0}",No);
            Console.WriteLine("Calisanin Adi {0}",Departman);
        }

        public calisan(string isim,string soyisim,int numara,string bolum)
        {
            this.Ad=isim;
            this.Soyad=soyisim;
            this.No=numara;
            this.Departman=bolum;
        }

        public calisan()
        {

        }

        public calisan(string isim,string soyisim)
        {
            this.Ad=isim;
            this.Soyad=soyisim;
            
        }

}