using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	public partial class Criacao : Form
	{
		string nome, raca, classe;
		public Criacao()
		{
			InitializeComponent();
		}
		void HumanoRadioCheckedChanged(object sender, EventArgs e)
		{
			raca = humanoRadio.Text;
		}
		void TrollRadioCheckedChanged(object sender, EventArgs e)
		{	
			raca = trollRadio.Text;
		}
		void ElfoRadioCheckedChanged(object sender, EventArgs e)
		{
			raca = elfoRadio.Text;
		}
		void GuerreiroRadioCheckedChanged(object sender, EventArgs e)
		{
			classe = guerreiroRadio.Text;
		}
		void MagoRadioCheckedChanged(object sender, EventArgs e)
		{
			classe = magoRadio.Text;
		}
		void ArqueiroRadioCheckedChanged(object sender, EventArgs e)
		{
			classe = arqueiroRadio.Text;
		}
		void NomeTextFieldTextChanged(object sender, EventArgs e)
		{
			nome = nomeTextField.Text;
		}
		void RacaInfoButtonClick(object sender, EventArgs e)
		{
			
		}
		void ClasseInforButtonClick(object sender, EventArgs e)
		{
	
		}
		void ConfrimarButtonClick(object sender, EventArgs e)
		{
			Program.usuario = new Jogador(nome, raca, classe);
			Program.atbtMenu = new AtributosForm();
			Close();
			Program.atbtMenu.Show();
		}
	}
}
