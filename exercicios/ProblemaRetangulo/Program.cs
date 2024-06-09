using System;

namespace ProblemaRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo(10.0, 5.0);
            Console.WriteLine(retangulo);

            Retangulo r = new Retangulo(10.0, 5.0, "amarelo");
            Console.WriteLine(r);



            Console.ReadKey();
        }
    }
}
