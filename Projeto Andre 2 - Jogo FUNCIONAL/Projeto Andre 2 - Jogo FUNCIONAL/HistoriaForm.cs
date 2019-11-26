using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	public partial class HistoriaForm : Form
	{
		public HistoriaForm()
		{
			InitializeComponent();
			FileStream historia = new FileStream("Historia.txt", FileMode.Open);
			StreamReader sr = new StreamReader(historia);
			
			historiaLabel.Text = sr.ReadLine();
		}
	}
}
