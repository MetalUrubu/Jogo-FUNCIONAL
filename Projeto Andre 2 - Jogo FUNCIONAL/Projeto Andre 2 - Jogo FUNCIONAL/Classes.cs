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
		
		public abstract void Magia1();
		public abstract void Magia2();
		public abstract void Magia3();
	}
}
