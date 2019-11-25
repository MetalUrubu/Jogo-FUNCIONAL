using System;
using System.Windows.Forms;

namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	internal sealed class Program
	{
		public static MainForm menuP;
		public static Jogador usuario;
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(menuP = new MainForm());
		}
		
	}
}
