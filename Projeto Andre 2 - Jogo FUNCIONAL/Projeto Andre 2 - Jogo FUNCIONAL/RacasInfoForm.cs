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
		public RacasInfoForm()
		{
			InitializeComponent();
		}
	}
}
