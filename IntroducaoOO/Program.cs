using System;

namespace IntroducaoOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Cartao cartao = new Cartao();

            bool autorizado = cartao.AutorizarCompra("jose");

            if (autorizado == true)
            {
                Console.WriteLine("Compra autorizada");
            }
            else
            {
                Console.WriteLine("Compra negada");
            }





            Console.WriteLine(cartao.Numero);

            Console.ReadKey();
        }
    }
}
