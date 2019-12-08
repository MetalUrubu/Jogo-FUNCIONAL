
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	public partial class BatalhaForm : Form
	{
		int inimigoVidaAtual;
		bool inimigoAtaca, usarPocao;
		public int tempoRecargaMagia1, tempoRecargaMagia2, tempoRecargaMagia3;
		static string[] pocoes = Directory.GetFiles("Poções");
		public BatalhaForm()
		{
			InitializeComponent();
			inimigoAtaca = true;
			
			//Imagens das Magias
			magia1Button.BackgroundImage = Image.FromFile(Program.usuario.magias.icones[0]);
			magia1Button.BackgroundImageLayout = ImageLayout.Stretch;
			magia2Button.BackgroundImage = Image.FromFile(Program.usuario.magias.icones[1]);
			magia2Button.BackgroundImageLayout = ImageLayout.Stretch;
			magia3Button.BackgroundImage = Image.FromFile(Program.usuario.magias.icones[2]);
			magia3Button.BackgroundImageLayout = ImageLayout.Stretch;
			
			//Nomes das Magias
			magia1Label.Text = Program.usuario.magias.NomeMg1;
			magia2Label.Text = Program.usuario.magias.NomeMg2;
			magia3Label.Text = Program.usuario.magias.NomeMg3;
			
			//Mana das Magias
			magia1Button.Text = Convert.ToString(Program.usuario.magias.ManaMg1);
			magia2Button.Text = Convert.ToString(Program.usuario.magias.ManaMg2);
			magia3Button.Text = Convert.ToString(Program.usuario.magias.ManaMg3);
			
			//Recarga das Magias
			magia1RecargaLabel.Text ="Recarga: "+ Convert.ToString(tempoRecargaMagia1);
			magia2RecargaLabel.Text ="Recarga: "+ Convert.ToString(tempoRecargaMagia2);
			magia3RecargaLabel.Text ="Recarga: "+ Convert.ToString(tempoRecargaMagia3);
			
			//Nomes Jogador
			nomeJogadorLabel.Text = Program.usuario.Nome;
			nomeInimigoLabel.Text = Program.inimigo.Nome;
			
			Program.usuario.status.VidaAtual = Program.usuario.status.Vida;
			Program.usuario.status.ManaAtual = Program.usuario.status.Mana;
			
			Program.inimigo.vidaAtual = Program.inimigo.Vida;
			
			vidaJogadorBar.Maximum = Program.usuario.status.Vida;
			vidaJogadorBar.Increment(vidaJogadorBar.Maximum);
			vidaInimigoBar.Maximum = Program.inimigo.Vida;
			vidaInimigoBar.Increment(Program.inimigo.Vida);
			
			vidaJogadorLabel.Text = "Vida: " + Convert.ToString(Program.usuario.status.VidaAtual) +"/"+ Convert.ToString(Program.usuario.status.Vida);
			manaJogadorLabel.Text = "Mana: " + Convert.ToString(Program.usuario.status.ManaAtual) +"/"+ Convert.ToString(Program.usuario.status.Mana);
			
			vidaInimigoLabel.Text = "Vida: " + Convert.ToString(Program.inimigo.vidaAtual) +"/"+ Convert.ToString(Program.inimigo.Vida);
			
			//Imagen das Poções
			pocaoVidaButton.BackgroundImage = Image.FromFile(pocoes[0]);
			pocaoVidaButton.BackgroundImageLayout = ImageLayout.Stretch;
			pocaoManaButton.BackgroundImage = Image.FromFile(pocoes[1]);
			pocaoManaButton.BackgroundImageLayout = ImageLayout.Stretch;
			pocaoDanoButton.BackgroundImage = Image.FromFile(pocoes[2]);
			pocaoDanoButton.BackgroundImageLayout = ImageLayout.Stretch;
			
			//Poções Quantidade
			pocaoVidaLabel.Text = "Possui: "+Convert.ToString(Program.usuario.pocoes.QntdPocaoVida);
			pocaoManaLabel.Text = "Possui: "+Convert.ToString(Program.usuario.pocoes.QntdPocaoMana);
			pocaoDanoLabel.Text = "Possui: "+Convert.ToString(Program.usuario.pocoes.QntdPocaoDano);
			
			atualizar();
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
				Program.inimigo.atacar = false;
				Close();
			}
			if(!Program.inimigo.atacar)
			{
				Program.inimigo.atacar = true;
			}
			else if(usarPocao)
			{
				usarPocao = false;
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
			
			pocaoVidaLabel.Text = "Possui: "+Convert.ToString(Program.usuario.pocoes.QntdPocaoVida);
			pocaoManaLabel.Text = "Possui: "+Convert.ToString(Program.usuario.pocoes.QntdPocaoMana);
			pocaoDanoLabel.Text = "Possui: "+Convert.ToString(Program.usuario.pocoes.QntdPocaoDano);
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
		void PocaoVidaButtonClick(object sender, EventArgs e)
		{
			if(Program.usuario.status.VidaAtual == Program.usuario.status.Vida)
			{
				MessageBox.Show("Sua Vida já está cheia.");
			}
			else
			{
				if(Program.usuario.status.VidaAtual + 25*Program.usuario.status.Level > Program.usuario.status.Vida)
				{
					Program.usuario.pocoes.usarPocaoVida(Program.usuario);
					Program.usuario.status.VidaAtual = Program.usuario.status.Vida;
				}
				else
				{
					Program.usuario.pocoes.usarPocaoVida(Program.usuario);
					
				}
				usarPocao = true;
				atualizar();
			}
		}
		void PocaoManaButtonClick(object sender, EventArgs e)
		{
			if(Program.usuario.status.ManaAtual == Program.usuario.status.Mana)
			{
				MessageBox.Show("Sua Mana já está cheia.");
			}
			else
			{
				if(Program.usuario.status.ManaAtual + 25*Program.usuario.status.Level > Program.usuario.status.Mana)
				{
					Program.usuario.pocoes.usarPocaoMana(Program.usuario);
					Program.usuario.status.ManaAtual = Program.usuario.status.Mana;
				}
				else
				{
					
					Program.usuario.pocoes.usarPocaoMana(Program.usuario);
				}
				usarPocao = true;
				atualizar();
			}
			
		}
		void PocaoDanoButtonClick(object sender, EventArgs e)
		{
			Program.usuario.pocoes.usarPocaoDano(Program.inimigo);
			usarPocao = true;
			atualizar();
		}
		
		
	}
}
