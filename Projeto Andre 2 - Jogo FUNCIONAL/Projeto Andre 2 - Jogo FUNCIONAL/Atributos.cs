
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
		
		public Atributos()
		{
			Pontos += 20;
			Level +=1;
			
		}
		
		public void addAtributo(string atbt, int qntd)
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
		
		public void subAtributo(string atbt, int qntd)
		{
			Pontos += qntd;
			switch(atbt)
			{
				case "Força":
					Forca -= qntd;
					break;
				case "Agilidade":
					Agilidade -= qntd;
					break;
				case "Inteligencia":
					Inteligencia -= qntd;
					break;
			}
		}
		public void Evoluir()
		{
			Level += 1;
			Pontos += 10;
		}
	}
}

