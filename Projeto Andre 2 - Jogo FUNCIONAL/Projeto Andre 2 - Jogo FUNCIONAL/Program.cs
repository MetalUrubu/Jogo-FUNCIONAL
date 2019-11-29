using System;
using System.Windows.Forms;

namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	internal sealed class Program
	{
		public static MainForm menuP;
		public static Jogador usuario;
		public static Criacao novoJogo;
		public static AtributosForm atbtMenu;
		public static HistoriaForm historiaMenu;
		public static BatalhaForm batalha;
		public static Inimigo inimigo = new Inimigo("Cavaleiro Verde",200,30);
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(menuP = new MainForm());
		}
		
	}
}
