
using System;

namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	public class Jogador
	{
		public string Nome{get;set;}
		public string Raca{get;set;}
		public string Classe{get;set;}
		public Atributos status;
		public Classes magias;
		public pocoesClasse pocoes;
		public ForjaClass itens;
		
		public Jogador()
		{
		}
		public Jogador(string n, string r, string c)
		{
			Nome = n;
			Raca = r;
			Classe = c;
			status = new Atributos();
			pocoes = new pocoesClasse();
			itens = new ForjaClass(this);
			switch(r)
			{
				case "Humano":
					status.addAtributo("Força",2);
					status.addAtributo("Agilidade",5);
					status.addAtributo("Inteligencia",3);
					break;
				case "Troll":
					status.addAtributo("Força",5);
					status.addAtributo("Agilidade",2);
					status.addAtributo("Inteligencia",3);
					break;
				case "Elfo":
					status.addAtributo("Força",2);
					status.addAtributo("Agilidade",2);
					status.addAtributo("Inteligencia",6);
					break;
			}
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
