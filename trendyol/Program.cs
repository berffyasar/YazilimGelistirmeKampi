using System;

namespace eTicaret
{
    class Program
    {
        static void Main(string[] args)
        {
        

            Teacher teacher1= new Teacher();
            teacher1.Ad = "Ayşe\t";
            teacher1.Soyad = "Yıldız\t";
            teacher1.Branşı= "Matematik\t";
            teacher1.GirdiğiSınıfSayısı = "5\t ";
            teacher1.HaftalıkDersSaati = "30 saat\t ";
            teacher1.TatilGünleri = "Cuma\t";

            Teacher teacher2 = new Teacher();
            teacher2.Ad = "İlknur\t";
            teacher2.Soyad = "Karma\t";
            teacher2.Branşı = "Fizik\t\t";
            teacher2.GirdiğiSınıfSayısı = "4\t";
            teacher2.HaftalıkDersSaati = "16 saat\t ";
            teacher2.TatilGünleri = "Pazartesi\t";

            Teacher teacher3 = new Teacher();
            teacher3.Ad = "Sema\t";
            teacher3.Soyad = "Demir\t";
            teacher3.Branşı = "Rehberlik\t";
            teacher3.GirdiğiSınıfSayısı = "9\t ";
            teacher3.HaftalıkDersSaati = "18 saat\t ";
            teacher3.TatilGünleri = "Çarşamba\t";

            Teacher teacher4 = new Teacher();
            teacher4.Ad = "Mehmet\t";
            teacher4.Soyad = "Koç\t";
            teacher4.Branşı = "Sosyal\t\t";
            teacher4.GirdiğiSınıfSayısı = "4\t ";
            teacher4.HaftalıkDersSaati = "16 saat\t ";
            teacher4.TatilGünleri = "Perşembe\t";

            Teacher teacher5 = new Teacher();
            teacher5.Ad = "Kerem\t";
            teacher5.Soyad = "Bulut\t";
            teacher5.Branşı = "Resim\t\t";
            teacher5.GirdiğiSınıfSayısı = "5\t ";
            teacher5.HaftalıkDersSaati = "10 saat\t ";
            teacher5.TatilGünleri = "Salı\t";

            Teacher[] teacher = new Teacher[]
            {
                teacher1,
                teacher2,
                teacher3,
                teacher4,
                teacher5
            };
            
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Ad\t\tSoyad\t\tBranş\t\tSınıf sayısı\t\tHaftalık ders\t\tTatil günleri");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");

            for(int i = 0; i < teacher.Length; i++)
            {
                Console.WriteLine(teacher[i].Ad + " \t " + teacher[i].Soyad + " \t " + teacher[i].Branşı + " \t " + teacher[i].GirdiğiSınıfSayısı + " \t " + teacher[i].HaftalıkDersSaati + " \t " + teacher[i].TatilGünleri);
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("***********************************************For döngüsü bitti****************************************************");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Ad\t\tSoyad\t\tBranş\t\tSınıf sayısı\t\tHaftalık ders\t\tTatil günleri");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");

            foreach (var teachers in teacher  )
            {
                Console.WriteLine(teachers.Ad + "\t" + teachers.Soyad + "\t" +teachers.Branşı + " \t " + teachers.GirdiğiSınıfSayısı + " \t " + teachers.HaftalıkDersSaati + " \t " + teachers.TatilGünleri);
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("**********************************************Forech döngüsü bitti**************************************************");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Ad\t\tSoyad\t\tBranş\t\tSınıf sayısı\t\tHaftalık ders\t\tTatil günleri");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");

            int a = 0;
            while (a < teacher.Length )
            {
                Console.WriteLine(teacher[a].Ad + " \t " + teacher[a].Soyad + " \t " + teacher[a].Branşı + " \t " + teacher[a].GirdiğiSınıfSayısı + " \t " + teacher[a].HaftalıkDersSaati + " \t " + teacher[a].TatilGünleri);
               
                a++;
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("*************************************************While döngüsü bitti************************************************");
        }
    }
    class Teacher
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Branşı { get; set; }
        public string GirdiğiSınıfSayısı { get; set; }
        public string HaftalıkDersSaati { get; set; }
        public string TatilGünleri { get; set; }
    }
 
}
