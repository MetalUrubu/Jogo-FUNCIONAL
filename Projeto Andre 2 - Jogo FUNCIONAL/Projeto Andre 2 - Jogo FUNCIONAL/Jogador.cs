
using System;

namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	public class Jogador
	{
		public string Nome{get;set;}
		public string Raca{get;set;}
		public Atributos status;
		public Classes magias;
		public Jogador()
		{
		}
		public Jogador(string n, string r, string c)
		{
			Nome = n;
			Raca = r;
			status = new Atributos(r);
			switch(c)
			{
				case "Guerreiro":
					magias = new Guerreiro();
					break;
				case "Arqueiro":
					magias = new Arqueiro();
					break;
				case "Mago":
					magias = new Mago();
					break;
			}
		}
	}
}
