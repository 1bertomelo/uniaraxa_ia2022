using JogoDaVelhaIA.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace JogoDaVelhaIA.Classes
{
	public class Tabuleiro
	{
		public EnumTipoPeca[,] TabuleiroJogo { get; private set; }
		public int Jogadas { get; private set; }

		
		public Tabuleiro()
		{
			TabuleiroJogo = new EnumTipoPeca[3, 3];
			Jogadas = 0;
			
		}

		public void ResetarTabuleiro()
		{
			Jogadas = 0;
			
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					TabuleiroJogo[i,j] = EnumTipoPeca.VAZIO;
				}
			}
		}

		public bool InserirJogada(int linha, int coluna, EnumTipoPeca jogada)
		{
			if(EhCelulaVazia(linha, coluna))
			{
				TabuleiroJogo[linha, coluna] = jogada;
				Jogadas++;
				return true;
			}
			return false;
		}

		public bool EhCelulaVazia(int linha, int coluna) {
			return TabuleiroJogo[linha, coluna] == EnumTipoPeca.VAZIO;
		}

		public EnumTipoPeca ObterValorCelula(int linha, int coluna)
		{
			return TabuleiroJogo[linha, coluna];
		}

		public bool LinhaEstaIgual()
		{
			for (int linha = 0; linha < 3; linha++)
					if (ObterValorCelula(linha, 0) == ObterValorCelula(linha, 1)
					&& ObterValorCelula(linha, 0) == ObterValorCelula(linha, 2)
					&& ObterValorCelula(linha, 0) != EnumTipoPeca.VAZIO
			)
				return true;
			return false;
		}

		public bool ColunaEstaIgual()
		{
			for (int coluna = 0; coluna < 3; coluna++)
				if (ObterValorCelula(0, coluna) == ObterValorCelula(1, coluna)
					&& ObterValorCelula(1, coluna) == ObterValorCelula(2, coluna)
					&& ObterValorCelula(2, coluna) != EnumTipoPeca.VAZIO
			)
					return true;
			return false;
		}

		public bool DiagonalPrincipalEstaIgual()
		{
			if (ObterValorCelula(0, 0) == ObterValorCelula(1, 1)
					&& ObterValorCelula(0, 0) == ObterValorCelula(2, 2)
					&& ObterValorCelula(0, 0) != EnumTipoPeca.VAZIO
			)
				return true;
			return false;
		}

		public bool DiagonalSecundariaEstaIgual()
		{
			if (ObterValorCelula(0, 2) == ObterValorCelula(1, 1)
					&& ObterValorCelula(0, 2) == ObterValorCelula(2, 0)
					&& ObterValorCelula(0, 2) != EnumTipoPeca.VAZIO
			)
				return true;
			return false;
		}

		public bool FimDeJogo()
		{

			//analisa vitoria em linha
			if(LinhaEstaIgual())
				return true;
			//analisa coluna em linha
			if (ColunaEstaIgual())
				return true;
			//analisa diagonal
			if (DiagonalPrincipalEstaIgual())
				return true;
			//analisa diagonal
			if (DiagonalSecundariaEstaIgual())
				return true;

			
			return false;

		}

	}
}
