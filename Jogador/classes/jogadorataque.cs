using System;

namespace Jogador.classes
{
    public class jogadorataque : jogador
    {
        private int tempoDeCarreiraA;
        private int tempoDeAposentadoriaA;

        public int calcTempoCarreiraA()
        {
            tempoDeCarreiraA = 35 - idade;
            return tempoDeCarreiraA;
        }

        public int calcTempoAposentadoriaA()
        {
            tempoDeAposentadoriaA = idade - 35;
            return tempoDeAposentadoriaA;
        }

        public string AposentadoriaA()
        {

            if (idade == 35)
            {
                Console.WriteLine($"\nO jogador tem {idade} anos, essa é a idade exata para um atacante se aposentar. O jogador deve se aposentar esse ano.");
            }

            else if (idade < 35)
            {
                Console.WriteLine($"\nO jogador tem {idade} anos, a exata idade para um atacante se aposentar é 35 anos. O jogador deve se aposentar daqui, aproximadamente, {tempoDeCarreiraA} anos.");
            }

            else if (idade > 35)
            {
                Console.WriteLine($"\nO jogador tem {idade} anos, a exata idade para um atacante se aposentar é 35 anos. O jogador deveria ter se aposentado há, aproximadamente, {tempoDeAposentadoriaA} anos.");
            }

            return "";
        }
    }
}