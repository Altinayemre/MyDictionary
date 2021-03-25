using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> Citys = new MyDictionary<int, string>();
            Citys.Add(07, "Antalya");
            Citys.Add(15,"Burdur");
            Citys.Add(34,"İstanbul");
            Citys.Add(06,"Ankara");
            Citys.Add(35, "İzmir");


            Citys.List();
            Console.WriteLine();
            Console.WriteLine("Toplam Şehir Sayısı: "+Citys.Count); 
            
            Console.ReadLine();
        }
    }
}
