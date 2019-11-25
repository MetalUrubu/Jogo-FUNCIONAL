
using System;

namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	public class Atributos
	{
		public int Vida{get;set;}
		public int Mana{get;set;}
		public int Forca{get;set;}
		public int Agilidade{get;set;}
		public int Inteligencia{get;set;}
		public int Armadura{get;set;}
		public int Level{get;set;}
		public int Pontos{get;set;}
		
		public Atributos(string r)
		{
			Pontos += 10;
			Evoluir();
			switch(r)
			{
				case "Humano":
					addAtributo("Força",2);
					addAtributo("Agilidade",5);
					addAtributo("Inteligencia",3);
					break;
				case "Troll":
					addAtributo("Força",5);
					addAtributo("Agilidade",2);
					addAtributo("Inteligencia",3);
					break;
				case "Elfo":
					addAtributo("Força",2);
					addAtributo("Agilidade",2);
					addAtributo("Inteligencia",6);
					break;
			}
		}
		
		public void addAtributo(string atbt, int qntd)
		{
			if(Pontos-=qntd >=0)
			{
				Pontos -= qntd;
				switch(atbt)
				{
					case "Força":
						Forca += qntd;
						break;
					case "Agilidade":
						Agilidade += qntd;
						break;
					case "Inteligencia":
						Inteligencia += qntd;
						break;
				}
			}
		}
		public void subAtributo(string atbt, int qntd)
		{
			switch(atbt)
			{
				case "Força":
					if(Forca -= qntd > 0)
					{
						Forca += qntd;
						Pontos += qntd;
					}
					break;
				case "Agilidade":
					if(Agilidade -= qntd > 0)
					{
						Agilidade += qntd;
						Pontos += qntd;
					}
					break;
				case "Inteligencia":
					if(Inteligencia -= qntd > 0)
					{
						Inteligencia += qntd;
						Pontos += qntd;
					}
					break;
			}
		}
		public void Evoluir()
		{
			Level += 1;
			Pontos += 5;
		}
	}
}

