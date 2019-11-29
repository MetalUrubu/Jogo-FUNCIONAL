
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	public partial class BatalhaForm : Form
	{
		int inimigoVidaAtual;
		bool inimigoAtaca;
		public int tempoRecargaMagia1, tempoRecargaMagia2, tempoRecargaMagia3;
		public BatalhaForm()
		{
			InitializeComponent();
			inimigoAtaca = true;
			magia1Button.BackgroundImage = Image.FromFile(Program.usuario.magias.icones[0]);
			magia1Button.BackgroundImageLayout = ImageLayout.Stretch;
			magia2Button.BackgroundImage = Image.FromFile(Program.usuario.magias.icones[1]);
			magia2Button.BackgroundImageLayout = ImageLayout.Stretch;
			magia3Button.BackgroundImage = Image.FromFile(Program.usuario.magias.icones[2]);
			magia3Button.BackgroundImageLayout = ImageLayout.Stretch;
			nomeJogadorLabel.Text = Program.usuario.Nome;
			nomeInimigoLabel.Text = Program.inimigo.Nome;
			magia1Label.Text = Program.usuario.magias.NomeMg1;
			magia2Label.Text = Program.usuario.magias.NomeMg2;
			magia3Label.Text = Program.usuario.magias.NomeMg3;
			vidaJogadorBar.Maximum = Program.usuario.status.Vida;
			Program.usuario.status.VidaAtual = Program.usuario.status.Vida;
			Program.usuario.status.ManaAtual = Program.usuario.status.Mana;
			Program.inimigo.vidaAtual = Program.inimigo.Vida;
			vidaJogadorBar.Increment(vidaJogadorBar.Maximum);
			vidaInimigoBar.Maximum = Program.inimigo.Vida;
			vidaInimigoBar.Increment(Program.inimigo.Vida);
			
			magia1Button.Text = Convert.ToString(Program.usuario.magias.ManaMg1);
			magia2Button.Text = Convert.ToString(Program.usuario.magias.ManaMg2);
			magia3Button.Text = Convert.ToString(Program.usuario.magias.ManaMg3);
			
			magia1RecargaLabel.Text ="Recarga: "+ Convert.ToString(tempoRecargaMagia1);
			magia2RecargaLabel.Text ="Recarga: "+ Convert.ToString(tempoRecargaMagia2);
			magia3RecargaLabel.Text ="Recarga: "+ Convert.ToString(tempoRecargaMagia3);
			
			vidaJogadorLabel.Text = "Vida: " + Convert.ToString(Program.usuario.status.VidaAtual) +"/"+ Convert.ToString(Program.usuario.status.Vida);
			manaJogadorLabel.Text = "Mana: " + Convert.ToString(Program.usuario.status.ManaAtual) +"/"+ Convert.ToString(Program.usuario.status.Mana);
			vidaInimigoLabel.Text = "Vida: " + Convert.ToString(Program.inimigo.vidaAtual) +"/"+ Convert.ToString(Program.inimigo.Vida);
		}
		void PassarButtonClick(object sender, EventArgs e)
		{
			atualizar();
		}
		void atualizar()
		{
			if(Program.inimigo.vidaAtual<=0)
			{
				MessageBox.Show("Você Venceu.");
				HistoriaForm.Pagina=0;
				HistoriaForm.Capitulo+=1;
				Program.historiaMenu = new HistoriaForm();
				Program.historiaMenu.Show();
				Close();
			}
			if(!Program.inimigo.atacar)
			{
				Program.inimigo.atacar = true;
			}
			else
			{
				Program.usuario.status.VidaAtual -= Program.inimigo.ataque-Program.usuario.status.Armadura;
				vidaJogadorBar.Increment(-(Program.inimigo.ataque-Program.usuario.status.Armadura));
				if((Program.usuario.status.VidaAtual-Program.inimigo.ataque) <= 0 )
				{
					Program.usuario.status.VidaAtual = 0;
					MessageBox.Show("Voce Morreu, Tente Novamente.");
					Program.historiaMenu = new HistoriaForm();
					Program.historiaMenu.Show();
					Close();
				}
				
			}
			
			if(tempoRecargaMagia1 <= 0)
			{
				magia1RecargaLabel.Text ="Recarga: 0";
			}
			else
			{
				magia1RecargaLabel.Text ="Recarga: "+ Convert.ToString(tempoRecargaMagia1-1);
			}
			if(tempoRecargaMagia2 <= 0)
			{
				magia2RecargaLabel.Text ="Recarga: 0";
			}
			else
			{
				magia2RecargaLabel.Text ="Recarga: "+ Convert.ToString(tempoRecargaMagia2-1);
			}
			if(tempoRecargaMagia3 <= 0)
			{
				magia3RecargaLabel.Text ="Recarga: 0";
			}
			else
			{
				magia3RecargaLabel.Text ="Recarga: "+ Convert.ToString(tempoRecargaMagia3-1);
			}
			
			vidaJogadorLabel.Text = "Vida: " + Convert.ToString(Program.usuario.status.VidaAtual) +"/"+ Convert.ToString(Program.usuario.status.Vida);
			manaJogadorLabel.Text = "Mana: " + Convert.ToString(Program.usuario.status.ManaAtual) +"/"+ Convert.ToString(Program.usuario.status.Mana);
			vidaInimigoLabel.Text = "Vida: " + Convert.ToString(Program.inimigo.vidaAtual) +"/"+ Convert.ToString(Program.inimigo.Vida);
			
			tempoRecargaMagia1 -=1;
			tempoRecargaMagia2 -=1;
			tempoRecargaMagia3 -=1;
		}
		void AtacarButtonClick(object sender, EventArgs e)
		{
			Program.inimigo.vidaAtual -= Program.usuario.status.Ataque;
			vidaInimigoBar.Increment(-Program.usuario.status.Ataque);
			atualizar();
		}
		void Magia1ButtonClick(object sender, EventArgs e)
		{
			if(Program.usuario.status.ManaAtual >= Program.usuario.magias.ManaMg1 & tempoRecargaMagia1 <= 0)
			{
				Program.usuario.magias.Magia1(Program.usuario, Program.inimigo);
				vidaInimigoBar.Increment(-Program.usuario.magias.Dano);
				tempoRecargaMagia1 = Program.usuario.magias.TempoRecargaMagia1+1;
				atualizar();
			}
			else
			{
				if(Program.usuario.status.ManaAtual <= Program.usuario.magias.ManaMg1)
				{
					MessageBox.Show("Mana Insuficiente.");
				}
				if(tempoRecargaMagia1 >=1)
				{
					MessageBox.Show("Magia em Tempo de Recarga.");
				}
				
			}
		}
		void Magia2ButtonClick(object sender, EventArgs e)
		{
			if(Program.usuario.status.ManaAtual >= Program.usuario.magias.ManaMg2 && tempoRecargaMagia2 <= 0)
			{
				Program.usuario.magias.Magia2(Program.usuario, Program.inimigo);
				vidaInimigoBar.Increment(-Program.usuario.magias.Dano);
				tempoRecargaMagia2 = Program.usuario.magias.TempoRecargaMagia2+1;
				atualizar();
			}
			else
			{
				if(Program.usuario.status.ManaAtual <= Program.usuario.magias.ManaMg1)
				{
					MessageBox.Show("Mana Insuficiente.");
				}
				if(tempoRecargaMagia2 >=1)
				{
					MessageBox.Show("Magia em Tempo de Recarga.");
				}
			}
		}
		void Magia3ButtonClick(object sender, EventArgs e)
		{
			if(Program.usuario.status.ManaAtual >= Program.usuario.magias.ManaMg3 && tempoRecargaMagia3 <= 0)
			{
				Program.usuario.magias.Magia3(Program.usuario, Program.inimigo);
				vidaInimigoBar.Increment(-Program.usuario.magias.Dano);
				tempoRecargaMagia3 = Program.usuario.magias.TempoRecargaMagia3+1;
				atualizar();
			}
			else
			{
				if(Program.usuario.status.ManaAtual <= Program.usuario.magias.ManaMg3)
				{
					MessageBox.Show("Mana Insuficiente.");
				}
				if(tempoRecargaMagia3 >=1)
				{
					MessageBox.Show("Magia em Tempo de Recarga.");
				}
			}
		}
		
	}
}
