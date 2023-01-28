using bookclass;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nece kitab olacag: ");
            int a = int.Parse(Console.ReadLine());
            Book[] kitablar = new Book[a];
            for ( int i=0;i<a;i++ )
            {
                Book b = new Book();
                Console.Write($"{i+1}.kitabin adi: ");
                b.name = Console.ReadLine();
                Console.Write($"{i + 1}.muellifin adi: ");
                b.Autname = Console.ReadLine();
                Console.Write($"{i + 1}.nesr edilme tarixi: ");
                b.PubDate=int.Parse(Console.ReadLine());
                Console.Write($"{i + 1}.kitabin sehifesi: ");
                b.PageCount=int.Parse(Console.ReadLine());
                kitablar[i] = b;
            }
            foreach(var item in kitablar)
            {
                Console.Write(item);   
            }
        }
    }
}