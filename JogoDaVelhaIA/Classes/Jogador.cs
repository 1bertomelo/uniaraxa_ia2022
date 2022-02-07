using JogoDaVelhaIA.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace JogoDaVelhaIA.Classes
{
	public class Jogador
	{
		public Jogador( EnumTipoPeca tipoPeca)
		{
			TipoPeca = tipoPeca;
		}

	
		public EnumTipoPeca TipoPeca { get; private set; }

		
	}
}
