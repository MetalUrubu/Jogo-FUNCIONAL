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
		public ClassesInfoForm()
		{
			InitializeComponent();
		}
	}
}
