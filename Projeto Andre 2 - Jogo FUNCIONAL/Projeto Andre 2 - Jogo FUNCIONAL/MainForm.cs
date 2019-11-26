using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_Andre_2___Jogo_FUNCIONAL
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void NovoJogoClick(object sender, EventArgs e)
		{
			Program.novoJogo = new Criacao();
			Hide();
			Program.novoJogo.Show();
		}
		void CarregarJogoClick(object sender, EventArgs e)
		{
			
		}
		void SairClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
	}
}
