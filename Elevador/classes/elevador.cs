using System;

namespace Elevador.classes
{
    public abstract class elevador
    {
        protected int terreo {get; set;}

        protected int andares {get; set;}

        protected int capacidade {get; set;}

        protected int pessoasPresentes {get; set;}

        protected int andarAtual {get; set;}

        public void Inicializar()
        {
            Console.WriteLine("\nQual a capacidade máxima de conteúdo do elevador?");
            capacidade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nQuantos andares tem o prédio?");
            andares = int.Parse(Console.ReadLine());

            pessoasPresentes = 0;
            andarAtual = 1;
            terreo = 1;
        }

        public string Subir()
        {
            if (andarAtual == andares)
            {
                Console.WriteLine("\nVocê já está no último andar, não há como subir mais.");
            }

            else if (andarAtual == terreo)
            {
                Console.WriteLine($"\nVocê está no {andarAtual + 1}° andar.");
                andarAtual = andarAtual + 1;
            }

            else
            {
                Console.WriteLine($"\nVocê está no {andarAtual + 1}° andar.");
                andarAtual = andarAtual + 1;
            }

            return "andarAtual";
        }

        public string Descer()
        {
            if (andarAtual == terreo)
            {
                Console.WriteLine("\nVocê já está no térreo, não há como descer mais.");
            }

            else if (andarAtual == andares)
            {
                Console.WriteLine($"\nVocê está no {andarAtual - 1}° andar.");
                andarAtual = andarAtual - 1;
            }

            else if (andarAtual == 2)
            {
                Console.WriteLine($"\nVocê está no térreo.");
                andarAtual = andarAtual - 1;
            }

            else
            {
                Console.WriteLine($"\nVocê está no {andarAtual - 1}° andar.");
                andarAtual = andarAtual - 1;
            }

            return "andarAtual";
        }
    }
}