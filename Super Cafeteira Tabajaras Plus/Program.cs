using System;
using Super_Cafeteira_Tabajaras_Plus.classes;

namespace Super_Cafeteira_Tabajaras_Plus
{
    class Program
    {
        static void Main(string[] args)
        {
            int acucarPedido;
            MaquinaCafe mc = new MaquinaCafe();
            mc.inicio();

            Console.WriteLine("\nDeseja informar uma quantidade de açúcar para seu café?\ns - Sim\nn - Não");
            string opcao = Console.ReadLine();

            if (opcao == "s")
            {
                Console.WriteLine("\nQuantidade de açúcar em gramas:");
                acucarPedido = int.Parse(Console.ReadLine());
                mc.fazerCafe(acucarPedido);
            }

            else if (opcao == "n")
            {
                mc.fazerCafe();
            }
        }
    }
}
