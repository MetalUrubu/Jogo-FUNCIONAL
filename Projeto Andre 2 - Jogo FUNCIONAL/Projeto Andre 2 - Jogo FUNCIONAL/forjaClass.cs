using System;

namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	public class ForjaClass
	{
		public int Ferro{get;set;}
		public int Capacete{get;set;}
		public int Armadura{get;set;}
		public int Arma{get;set;}
		public int Luvas{get;set;}
		public int Botas{get;set;}
		
		public int Custo{get;set;}
		
		public ForjaClass(Jogador j)
		{
			Ferro = 25;
			addLevel("Capacete", j);
			addLevel("Armadura", j);
			addLevel("Arma", j);
			addLevel("Luvas", j);
			addLevel("Botas", j);
			addLevel("Amuleto", j);
			Custo = 1;
		}
		public void addLevel(string item, Jogador j)
		{
			int qntd;
			if(Ferro>=Custo)
			{
				j.status.verificarArmadura = true;
				switch(item)
				{
						
					case "Capacete":
						qntd = (1 + Capacete);
						j.status.addAtributo("Inteligencia", qntd);
						Capacete += 1;
						break;
					case "Armadura":
						qntd = (1 + Armadura);
						j.status.addAtributo("Força", qntd);
						j.status.addAtributo("Agilidade", qntd);
						j.status.addAtributo("Inteligencia", qntd);
						Armadura += 1;
						break;
					case "Arma":
						if(j.Classe == "Mago")
						{
							qntd = (1 + Arma);
							j.status.Ataque += qntd+5;
							j.status.addAtributo("Inteligencia", qntd);
						}
						else if(j.Classe == "Guerreiro")
						{
							qntd = (1 + Arma);
							j.status.Ataque += qntd+5;
							j.status.addAtributo("Força", qntd);
						}
						else if(j.Classe == "Arqueiro")
						{
							qntd = (1 + Arma);
							j.status.Ataque += qntd+5;
							j.status.addAtributo("Agilidade", qntd);
						}
						Arma += 1;
						break;
					case "Luvas":
						qntd = (2 + Luvas);
						j.status.addAtributo("Força", qntd);
						Luvas += 1;
						break;
					case "Botas":
						qntd = (2 + Botas);
						j.status.addAtributo("Agilidade", qntd);
						Botas += 1;
						break;
				}
				Ferro -= Custo;
				Custo += 1;
				j.status.verificarArmadura = false;
			}
		}
	}
}