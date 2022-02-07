using JogoDaVelhaIA.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace JogoDaVelhaIA.Classes
{
	public class JogoDaVelha : IJogoDaVelha
	{
		public Jogador Jogador1 { get; private set; }
		public Jogador Jogador2 { get; private set; }
		public Jogador Vencedor { get; private set; }
		public Tabuleiro Tabuleiro { get; private set; }

		public Jogador JogadorAtual { get; private set; }
		public bool deuVelha { get; private set; }

		public JogoDaVelha()
		{
			Tabuleiro = new Tabuleiro();
			Jogador1 = new Jogador(Enum.EnumTipoPeca.X);
			Jogador2 = new Jogador(Enum.EnumTipoPeca.O);
			IniciarJogo();
		}

		public void IniciarJogo()
		{

			Vencedor = null;
			deuVelha = false;
			JogadorAtual = Jogador1;
			Tabuleiro.ResetarTabuleiro();
		}

		public void RealizarJogada( int linha, int coluna)
		{
			bool jogadaOK = Tabuleiro.InserirJogada(linha, coluna, JogadorAtual.TipoPeca);
			if(jogadaOK) 
				AlternaJogador();
		}
		private void AlternaJogador()
		{
			if (JogadorAtual.TipoPeca == Jogador1.TipoPeca)
				JogadorAtual = Jogador2;
			else
				JogadorAtual = Jogador1;
		}
		public bool FimDeJogo()
		{
			bool AcabouJogo = Tabuleiro.FimDeJogo();
			if (AcabouJogo)
			{
				AlternaJogador();
				Vencedor = JogadorAtual;
			}
			if (Tabuleiro.Jogadas == 9 && !AcabouJogo)
			{
				Vencedor = null;
				deuVelha = true;
				return true;
			}
				
			return AcabouJogo;
		}
		public Jogador ObterVencedor() 
		{
			return Vencedor;
		}

		public void ImprimirTabuleiroConsole()
		{
			Console.Clear();
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					if(Tabuleiro.TabuleiroJogo[i, j] == Enum.EnumTipoPeca.VAZIO )
						Console.Write("   ");
					else
						Console.Write(" " + Tabuleiro.TabuleiroJogo[i,j] + " ");
					if(j<2)
						Console.Write("|");
				}
				Console.WriteLine("");
				if(i<2)
				Console.WriteLine("-------------");
			}
		}
	}
}
