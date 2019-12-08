using System;

namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	public class pocoesClasse
	{
		public int QntdPocaoVida{get;set;}
		public int QntdPocaoMana{get;set;}
		public int QntdPocaoDano{get;set;}
		public int Bonus{get;set;}
		public pocoesClasse()
		{
			QntdPocaoVida += 1;
			QntdPocaoMana += 1;
			QntdPocaoDano += 1;
		}
		
		
		public void usarPocaoVida(Jogador j)
		{
			if(QntdPocaoVida >0)
			{
				Bonus = 25*j.status.Level;
				j.status.VidaAtual += Bonus;
				QntdPocaoVida -= 1;
				Program.batalha.vidaJogadorBar.Increment(Program.usuario.pocoes.Bonus);
			}
		}
		public void usarPocaoMana(Jogador j)
		{
			if(QntdPocaoMana >0)
			{
				Bonus = 25*j.status.Level;
				j.status.ManaAtual += Bonus;
				QntdPocaoMana -= 1;
			}
		}
		public void usarPocaoDano(Inimigo i)
		{
			if(QntdPocaoDano > 0)
			{
				Bonus = Convert.ToInt32(0.07*i.Vida);
				i.vidaAtual -= Bonus;
				QntdPocaoDano -= 1;
				Program.batalha.vidaInimigoBar.Increment(-Program.usuario.pocoes.Bonus);
			}
		}
		public void addPocaoVida()
		{
			QntdPocaoVida += 1;
		}
		public void addPocaoMana()
		{
			QntdPocaoMana += 1;
		}
		public void addPocaoDano()
		{
			QntdPocaoDano += 1;
		}
		public void removerPocaoVida()
		{
			QntdPocaoVida -= 1;
		}
		public void removerPocaoMana()
		{
			QntdPocaoMana -= 1;
		}
		public void removerPocaoDano()
		{
			QntdPocaoDano -= 1;
		}
	}
}
