using System;

namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	public abstract class Classes
	{
		public string NomeMg1{get;set;}
		public string NomeMg2{get;set;}
		public string NomeMg3{get;set;}
		public int ManaMg1{get;set;}
		public int ManaMg2{get;set;}
		public int ManaMg3{get;set;}
		public int Dano{get;set;}
		public int Cura{get;set;}
		public int TempoRecargaMagia1 {get;set;}
		public int TempoRecargaMagia2 {get;set;}
		public int TempoRecargaMagia3 {get;set;}
		public string[] icones;
		
		
		public abstract void Magia1(Jogador j, Inimigo i);
		public abstract void Magia2(Jogador j, Inimigo i);
		public abstract void Magia3(Jogador j, Inimigo i);
	}
}
