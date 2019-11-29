using System;

namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	public class Inimigo
	{
		public string Nome;
		public int Vida;
		public int vidaAtual;
		public int ataque;
		public bool atacar;
		public Inimigo(string n, int v, int a)
		{
			Nome = n;
			Vida = v;
			vidaAtual = v;
			ataque = a;
		}
	}
}
