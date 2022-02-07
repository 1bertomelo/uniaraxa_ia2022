using JogoDaVelhaIA.Classes;
using System;

namespace JogoDaVelhaIA
{
	class Program
	{
		static void Main(string[] args)
		{
			JogoDaVelha jogo = new JogoDaVelha();
			
			jogo.IniciarJogo();
			int linha;
			int coluna;
			while (!jogo.FimDeJogo())
			{
				Console.WriteLine("\nVEZ DO JOGADOR " + jogo.JogadorAtual.TipoPeca);
				Console.Write("DIGITE LINHA (1 a 3): ");
				linha = Convert.ToInt32(Console.ReadLine());
				Console.Write("DIGITE COLUNA (1 a 3):");
				coluna = Convert.ToInt32(Console.ReadLine());
				jogo.RealizarJogada(linha-1, coluna-1);
				Console.WriteLine("\n");
				jogo.ImprimirTabuleiroConsole();
			}
			if(jogo.deuVelha)
				Console.WriteLine("\nDEU VELHA!");
			else
				Console.WriteLine("\nGANHADOR FOI " + jogo.ObterVencedor().TipoPeca);
			Console.ReadLine();
		}
	}
}
