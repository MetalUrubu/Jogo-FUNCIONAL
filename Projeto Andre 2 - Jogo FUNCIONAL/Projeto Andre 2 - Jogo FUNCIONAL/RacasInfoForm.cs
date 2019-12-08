using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	public partial class RacasInfoForm : Form
	{
		static FileStream racasInfoArquivo = new FileStream("RacasInfoText.txt",FileMode.Open);
		static StreamReader sr = new StreamReader(racasInfoArquivo);
		static string todoTexto = sr.ReadToEnd();
		string[] historias = todoTexto.Split('\n');
		public RacasInfoForm()
		{
			InitializeComponent();
			humanoInfoText.Text = historias[0];
			trollInfoText.Text = historias[1];
			elfoInfoText.Text = historias[2];
		}
		void SairButtonClick(object sender, EventArgs e)
		{
			Criacao.racasAberto = false;
			Close();
		}
	}
}
