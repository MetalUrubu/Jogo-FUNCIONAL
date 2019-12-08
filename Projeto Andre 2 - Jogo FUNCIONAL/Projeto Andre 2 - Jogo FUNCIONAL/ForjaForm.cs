using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	public partial class ForjaForm : Form
	{
		string selecionado;
		public ForjaForm()
		{
			InitializeComponent();
			ferroLabel.Text = "Ferro: " + Convert.ToString((Program.usuario.itens.Ferro));
		}
		void CapaceteButtonClick(object sender, EventArgs e)
		{
			selecionado = "Capacete";
		}
		void ArmaduraButtonClick(object sender, EventArgs e)
		{
			selecionado = "Armadura";
			MessageBox.Show(selecionado + "Selecionado");
		}
		void armaButtonClick(object sender, EventArgs e)
		{
			selecionado = "Arma";
		}
		void LuvasButtonClick(object sender, EventArgs e)
		{
			selecionado = "Luvas";
		}
		void BotaButtonClick(object sender, EventArgs e)
		{
			selecionado = "Bota";
		}
		void AprimorarButtonClick(object sender, EventArgs e)
		{
			if(Program.usuario.itens.Ferro >= Program.usuario.itens.Custo)
			{
				Program.usuario.itens.addLevel(selecionado, Program.usuario);
				atualizar();
			}
			else
			{
				MessageBox.Show("Ferro Insuficiente.");
			}
		}
		void StatusButtonClick(object sender, EventArgs e)
		{
			
		}
		void SairButtonClick(object sender, EventArgs e)
		{
			Program.menuS = new MenuForm();
			Program.menuS.Show();
			Close();
		}
		void atualizar()
		{
			level1Label.Text = "Level: " + Convert.ToString(Program.usuario.itens.Capacete);
			level2Label.Text = "Level: " + Convert.ToString(Program.usuario.itens.Armadura);
			level3Label.Text = "Level: " + Convert.ToString(Program.usuario.itens.Arma);
			level4Label.Text = "Level: " + Convert.ToString(Program.usuario.itens.Botas);
			level5Label.Text = "Level: " + Convert.ToString(Program.usuario.itens.Luvas);
			
			ferroLabel.Text = "Ferro: " + Convert.ToString(Program.usuario.itens.Ferro);
			custoLabel.Text = "Custo: " + Convert.ToString(Program.usuario.itens.Custo);
		}
		
	}
}
