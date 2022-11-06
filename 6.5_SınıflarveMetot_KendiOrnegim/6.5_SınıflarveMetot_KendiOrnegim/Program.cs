namespace _6._5_SınıflarveMetot_KendiOrnegim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bilgi blg = new bilgi();
            string adı,soyadı, yası;
            Console.Write("Adınızı giriniz: ");
            adı=Console.ReadLine();
            Console.Write("Soyadınızı giriniz: ");
            soyadı=Console.ReadLine();
            Console.Write("Yaşınızı giriniz: ");
            yası = Console.ReadLine();
            blg.isim(adı, soyadı, yası);
            Console.Read();




        }
    }
}