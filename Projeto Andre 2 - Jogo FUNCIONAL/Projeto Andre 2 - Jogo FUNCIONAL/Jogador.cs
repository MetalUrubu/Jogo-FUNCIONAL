
using System;

namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	public class Jogador
	{
		public string Nome{get;set;}
		public string Raca{get;set;}
		public Jogador()
		{
		}
		public Jogador(string n, string r, string c)
		{
			Nome = n;
			Raca = r;
			//Adicionar switch para definição de classe
		}
	}
}
