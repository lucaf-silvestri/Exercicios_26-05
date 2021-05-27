using System;

namespace Elevador.classes
{
    public class elevadorServico : elevador
    {
        private int caixas {get; set;}
        private int conteudo {get; set;}

        public void InicializarSer()
        {
            Console.WriteLine("\nQual a capacidade máxima de conteúdo do elevador?");
            capacidade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nQuantos andares tem o prédio?");
            andares = int.Parse(Console.ReadLine());

            caixas = 0;
            conteudo = 0;
            pessoasPresentes = 0;
            andarAtual = 1;
            terreo = 1;
        }

        public string EntrarSer()
        {
            if (conteudo < capacidade)
            {
                Console.WriteLine($"\nUma pessoa entrou no elevador, então temos {pessoasPresentes + 1} pessoas presentes e {caixas} caixas.");
                pessoasPresentes = pessoasPresentes + 1;
                conteudo = conteudo + 1;
            }

            else
            {
                Console.WriteLine("\nO elevador está cheio.");
            }

            return "conteudo";
        }

        public string SairSer()
        {
            if (pessoasPresentes == 0)
            {
                Console.WriteLine("\nJá não tem mais ninguém no elevador.");
            }

            else
            {
                Console.WriteLine($"\nUma pessoa saiu do elevador, então temos {pessoasPresentes - 1} pessoas presentes e {caixas} caixas.");
                pessoasPresentes = pessoasPresentes - 1;
                conteudo = conteudo - 1;
            }

            return "conteudo";
        }

        public string MaisCaixa()
        {
            if (conteudo < capacidade)
            {
                Console.WriteLine($"\nUma caixa foi adicionada no elevador, então temos {pessoasPresentes} pessoas presentes e {caixas + 1} caixas.");
                caixas = caixas + 1;
                conteudo = conteudo + 1;
            }

            else
            {
                Console.WriteLine("\nO elevador está cheio.");
            }

            return "conteudo";
        }

        public string MenosCaixa()
        {
            if (caixas == 0)
            {
                Console.WriteLine("\nJá não tem mais caixas no elevador.");
            }

            else
            {
                Console.WriteLine($"\nUma caixa foi retirada do elevador, então temos {pessoasPresentes} pessoas presentes e {caixas - 1} caixas.");
                caixas = caixas - 1;
                conteudo = conteudo - 1;
            }

            return "conteudo";
        }
    }
}