using System;

namespace Super_Cafeteira_Tabajaras_Plus.classes
{
    public class MaquinaCafe
    {
        public int acucarDisponivel;
        public int acucarNaoPedido;
        public void inicio()
        {
            acucarDisponivel = 50;
            acucarNaoPedido = 10;
        }

        public int fazerCafe(int acucarPedido)
        {
            if (acucarPedido > acucarDisponivel)
            {
                Console.WriteLine("\nInfelizmente, a máquina de café não possui a quantidade de açúcar requisitada. Seu café foi preparado sem açúcar.\n");
            }

            else if (acucarPedido == acucarDisponivel)
            {
                Console.WriteLine($"\nSeu café foi preparado com {acucarPedido} gramas de açúcar e acabou com o estoque da máquina. Aproveite!\n");
            }

            else
            {
                Console.WriteLine($"\nSeu café foi preparado com {acucarPedido} gramas de açúcar. Aproveite!\n");
            }

            return acucarPedido;
        }

        public int fazerCafe()
        {
            Console.WriteLine($"\nSeu café foi preparado com {acucarNaoPedido} gramas de açúcar. Aproveite!\n");
            return acucarNaoPedido;
        }
    }
}