using System;

namespace Elevador.classes
{
    public class elevadorSocial : elevador
    {
        public string EntrarSoc()
        {
            if (pessoasPresentes < capacidade)
            {
                Console.WriteLine($"\nUma pessoa entrou no elevador, então temos {pessoasPresentes + 1} pessoas presentes.");
                pessoasPresentes = pessoasPresentes + 1;
            }

            else
            {
                Console.WriteLine("\nO elevador está cheio.");
            }

            return "pessoasPresentes";
        }

        public string SairSoc()
        {
            if (pessoasPresentes == 0)
            {
                Console.WriteLine("\nJá não tem mais ninguém no elevador.");
            }

            else
            {
                Console.WriteLine($"\nUma pessoa saiu do elevador, então temos {pessoasPresentes - 1} pessoas presentes.");
                pessoasPresentes = pessoasPresentes - 1;
            }

            return "pessoasPresentes";
        }
    }
}