using JogoDaVelhaIA.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace JogoDaVelhaIA.Interface
{
	public interface IJogoDaVelha
	{
		public void IniciarJogo();
		public void RealizarJogada(int linha, int coluna);

		public bool FimDeJogo();

	}
}
