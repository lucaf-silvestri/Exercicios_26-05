using System;

namespace Jogador.classes
{
    public abstract class jogador
    {
        protected string nome;
        protected int anoDeNascimento;
        protected int idade;
        private int dataAtual = DateTime.Now.Year;
        protected string nacionalidade;
        protected double altura;
        protected double peso;

        public string Info()
        {
            Console.WriteLine("\nPor favor, digite as informações do jogador:");
            Console.WriteLine("Qual o nome do jogador?");
            nome = Console.ReadLine();

            Console.WriteLine("\nQual o ano de nascimento do jogador?");
            anoDeNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("\nQual a nacionalidade do jogador?");
            nacionalidade = Console.ReadLine();

            Console.WriteLine("\nQual a altura do jogador, em metros?");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("\nQual o peso do jogador, em quilos?");
            peso = double.Parse(Console.ReadLine());

            return "";
        }

        public int CalculoIdade()
        {
            idade = dataAtual - anoDeNascimento;
            return idade;
        }

        public string Imprimir()
        {
            Console.WriteLine($"\nNome do Jogador: {nome}.");
            Console.WriteLine($"\nIdade do Jogador: {idade} anos de idade.");
            Console.WriteLine($"\nNacionalidade do Jogador: {nacionalidade}.");
            Console.WriteLine($"\nAltura do Jogador: {altura} metros.");
            Console.WriteLine($"\nPeso do Jogador: {peso} kg.");

            return "";
        }
    }
}