using System;

namespace Jogador.classes
{
    public class jogadormeiocampo : jogador
    {
        private int tempoDeCarreiraMC;
        private int tempoDeAposentadoriaMC;

        public int calcTempoCarreiraMC()
        {
            tempoDeCarreiraMC = 38 - idade;
            return tempoDeCarreiraMC;
        }

        public int calcTempoAposentadoriaMC()
        {
            tempoDeAposentadoriaMC = idade - 38;
            return tempoDeAposentadoriaMC;
        }

        public string AposentadoriaMC()
        {

            if (idade == 38)
            {
                Console.WriteLine($"\nO jogador tem {idade} anos, essa é a idade exata para um meio-campo se aposentar. O jogador deve se aposentar esse ano.");
            }

            else if (idade < 38)
            {
                Console.WriteLine($"\nO jogador tem {idade} anos, a exata idade para um meio-campo se aposentar é 38 anos. O jogador deve se aposentar daqui, aproximadamente, {tempoDeCarreiraMC} anos.");
            }

            else if (idade > 38)
            {
                Console.WriteLine($"\nO jogador tem {idade} anos, a exata idade para um meio-campo se aposentar é 38 anos. O jogador deveria ter se aposentado há, aproximadamente, {tempoDeAposentadoriaMC} anos.");
            }

            return "";
        }
    }
}