using System;
using Jogador.classes;

namespace Jogador
{
    class Program
    {
        static void Main(string[] args)
        {
            bool acabou = false;
            bool acabouA = false;
            bool acabouD = false;
            bool acabouMC = false;
            string posicao;
            string opcao;

            do
            {
                Console.WriteLine(@"
===========================
|   Selecione a Posição   |
|       do Jogador:       |
|-------------------------|
|      1- Ataque          |
|      2- Defesa          |
|      3- Meio-Campo      |
|      4- Sair            |
===========================");
                posicao = Console.ReadLine();

                switch (posicao)
                {
                    case "1":

                        jogadorataque ja = new jogadorataque();
                        ja.Info();
                        ja.CalculoIdade();

                        do
                        {
                            Console.WriteLine(@"
===============================
|  Selecione uma das Opções:  |
|-----------------------------|
| 1- Listar Informações       |
| 2- Aposentadoria do Jogador |
| 3- Sair                     |
===============================");
                            opcao = Console.ReadLine();

                            switch (opcao)
                            {
                                case "1":
                                    Console.WriteLine($"\nPosição do Jogador: Ataque.");
                                    ja.Imprimir();
                                    acabouA = false;
                                    break;

                                case "2":
                                    ja.calcTempoCarreiraA();
                                    ja.calcTempoAposentadoriaA();
                                    ja.AposentadoriaA();
                                    acabouA = false;
                                    break;

                                case "3":
                                    acabouA = true;
                                    acabou = false;
                                    break;

                                default:
                                    acabouA = false;
                                    break;
                            }
                        } while (acabouA == false);
                        break;

                    case "2":

                        jogadordefesa jd = new jogadordefesa();
                        jd.Info();
                        jd.CalculoIdade();

                        do
                        {
                            Console.WriteLine(@"
===============================
|  Selecione uma das Opções:  |
|-----------------------------|
| 1- Listar Informações       |
| 2- Aposentadoria do Jogador |
| 3- Sair                     |
===============================");
                            opcao = Console.ReadLine();

                            switch (opcao)
                            {
                                case "1":
                                    Console.WriteLine($"\nPosição do Jogador: Defesa.");
                                    jd.Imprimir();
                                    acabouD = false;
                                    break;

                                case "2":
                                    jd.calcTempoCarreiraD();
                                    jd.calcTempoAposentadoriaD();
                                    jd.AposentadoriaD();
                                    acabouD = false;
                                    break;

                                case "3":
                                    acabouD = true;
                                    acabou = false;
                                    break;

                                default:
                                    acabouD = false;
                                    break;
                            }
                        } while (acabouD == false);

                        break;

                    case "3":

                        jogadormeiocampo jmc = new jogadormeiocampo();
                        jmc.Info();
                        jmc.CalculoIdade();

                        do
                        {
                            Console.WriteLine(@"
===============================
|  Selecione uma das Opções:  |
|-----------------------------|
| 1- Listar Informações       |
| 2- Aposentadoria do Jogador |
| 3- Sair                     |
===============================");
                            opcao = Console.ReadLine();

                            switch (opcao)
                            {
                                case "1":
                                    Console.WriteLine($"\nPosição do Jogador: Meio-Campo.");
                                    jmc.Imprimir();
                                    acabouMC = false;
                                    break;

                                case "2":
                                    jmc.calcTempoCarreiraMC();
                                    jmc.calcTempoAposentadoriaMC();
                                    jmc.AposentadoriaMC();
                                    acabouMC = false;
                                    break;

                                case "3":
                                    acabouMC = true;
                                    acabou = false;
                                    break;

                                default:
                                    acabouMC = false;
                                    break;
                            }
                        } while (acabouMC == false);

                        break;

                    case "4":
                        acabou = true;
                        break;

                    default:
                        acabou = false;
                        break;
                }

            } while (acabou == false);
        }
    }
}
