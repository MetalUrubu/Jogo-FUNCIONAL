using System;
using System.IO;

namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	public class Guerreiro : Classes
	{
		public Guerreiro()
		{
			this.NomeMg1 = "Provocar";
			this.NomeMg2 = "Investida";
			this.NomeMg3 = "Finalização";
			this.ManaMg1 = 40;
			this.ManaMg2 = 50;
			this.ManaMg3 = 60;
			this.TempoRecargaMagia1 = 1;
			this.TempoRecargaMagia2 = 1;
			this.TempoRecargaMagia3 = 3;
			this.icones = Directory.GetFiles("guerreiro Icones");
		}
		public override void Magia1(Jogador j, Inimigo i)
		{
			Dano = 30 + j.status.Agilidade;
			i.vidaAtual -= Dano;
			j.status.ManaAtual -= ManaMg1;
		}
		public override void Magia2(Jogador j, Inimigo i)
		{
			Dano = (j.status.Forca*2)+j.status.Ataque;
			i.vidaAtual -= Dano;
			j.status.ManaAtual -= ManaMg2;
		}
		public override void Magia3(Jogador j, Inimigo i)
		{
			if(i.vidaAtual <= (70*j.status.Level))
			{
				i.vidaAtual = 0;
				j.status.ManaAtual -= ManaMg1;
			}
			else
			{
				Dano =	j.status.Inteligencia*3;
				i.vidaAtual -= j.status.Inteligencia*3;
				j.status.ManaAtual -= ManaMg3;
			}
		}
	}
}
