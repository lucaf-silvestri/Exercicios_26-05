using System;

namespace Jogador.classes
{
    public class jogadordefesa : jogador
    {
        private int tempoDeCarreiraD;
        private int tempoDeAposentadoriaD;

        public int calcTempoCarreiraD()
        {
            tempoDeCarreiraD = 40 - idade;
            return tempoDeCarreiraD;
        }

        public int calcTempoAposentadoriaD()
        {
            tempoDeAposentadoriaD = idade - 40;
            return tempoDeAposentadoriaD;
        }

        public string AposentadoriaD()
        {

            if (idade == 40)
            {
                Console.WriteLine($"\nO jogador tem {idade} anos, essa é a idade exata para um zagueiro se aposentar. O jogador deve se aposentar esse ano.");
            }

            else if (idade < 40)
            {
                Console.WriteLine($"\nO jogador tem {idade} anos, a exata idade para um zagueiro se aposentar é 40 anos. O jogador deve se aposentar daqui, aproximadamente, {tempoDeCarreiraD} anos.");
            }

            else if (idade > 40)
            {
                Console.WriteLine($"\nO jogador tem {idade} anos, a exata idade para um zagueiro se aposentar é 40 anos. O jogador deveria ter se aposentado há, aproximadamente, {tempoDeAposentadoriaD} anos.");
            }

            return "";
        }
    }
}