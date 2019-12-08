using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	public partial class ClassesInfoForm : Form
	{
		static FileStream classesInfoArquivo = new FileStream("ClassesInfoText.txt",FileMode.Open);
		static StreamReader sr = new StreamReader(classesInfoArquivo);
		static string todoTexto = sr.ReadToEnd();
		string[] historias = todoTexto.Split('\n');
		public ClassesInfoForm()
		{
			InitializeComponent();
			guerreiroInfoText.Text = historias[0];
			magoInfoText.Text = historias[1];
			arqueiroInfoText.Text = historias[2];
		}
		void SairButtonClick(object sender, EventArgs e)
		{
			Criacao.classesAberto = false;
			Close();
		}
	}
}
