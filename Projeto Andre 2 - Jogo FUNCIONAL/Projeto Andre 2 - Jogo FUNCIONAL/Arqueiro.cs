using System;
using System.IO;

namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	public class Arqueiro : Classes
	{
		public Arqueiro()
		{
			this.NomeMg1 = "Cegar";
			this.NomeMg2 = "Flecha Perfurante";
			this.NomeMg3 = "Ataque Multiplo";
			this.ManaMg1 = 30;
			this.ManaMg2 = 60;
			this.ManaMg3 = 85;
			this.TempoRecargaMagia1 = 2;
			this.TempoRecargaMagia2 = 2;
			this.TempoRecargaMagia3 = 3;
			this.icones = Directory.GetFiles("arqueiro Icones");
		}
		public override void Magia1(Jogador j, Inimigo i)
		{	
			Dano = j.status.Ataque+j.status.Inteligencia;
			i.vidaAtual -= Dano;
			j.status.ManaAtual-=ManaMg1;
			i.atacar = false;
			
		}
		public override void Magia2(Jogador j, Inimigo i)
		{
			Dano = j.status.Ataque*2;
			i.vidaAtual -= Dano;
			j.status.ManaAtual -= j.magias.ManaMg2;
		}
		public override void Magia3(Jogador j, Inimigo i)
		{
			Dano = (j.status.Ataque/2)*(j.status.Level+2);
			i.vidaAtual -= Dano;
		}
	}
}
