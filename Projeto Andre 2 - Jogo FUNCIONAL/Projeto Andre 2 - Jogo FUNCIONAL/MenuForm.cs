using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	public partial class MenuForm : Form
	{
		public MenuForm()
		{
			InitializeComponent();
		}
		void LojaButtonClick(object sender, EventArgs e)
		{
			
		}
		void MagiasButttonClick(object sender, EventArgs e)
		{
			
		}
		void ForjaButtonClick(object sender, EventArgs e)
		{
			Program.forja = new ForjaForm();
			Program.forja.Show();
			Close();
		}
		void AtributosButtonClick(object sender, EventArgs e)
		{
			Program.atbtMenu = new AtributosForm();
			Program.atbtMenu.Show();
			Close();
		}
		void RetomarButtonClick(object sender, EventArgs e)
		{
			Program.historiaMenu = new HistoriaForm();
			Program.historiaMenu.Show();
			Close();
		}
		
	}
}
