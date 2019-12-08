using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	public partial class HistoriaForm : Form
	{
		static string[] historias = Directory.GetFiles("historia Capitulos");
		static FileStream historia; //= new FileStream(historias[Capitulo], FileMode.Open);
		static StreamReader sr; //= new StreamReader(historia);
		static string[] imagens = Directory.GetFiles("imagens");
		static string todaHistoria;//  = sr.ReadToEnd();
		static string[] historiaArray;// = todaHistoria.Split('\n');
		public static int Pagina{get;set;}
		public static int Capitulo{get;set;}
		
		public HistoriaForm()
		{
			InitializeComponent();
			historia = new FileStream(historias[Capitulo], FileMode.Open);
			sr = new StreamReader(historia);
			todaHistoria  = sr.ReadToEnd();
			historiaArray = todaHistoria.Split('\n');
			historiaLabel.Text = historiaArray[Pagina];
			imagemBox.Image = Image.FromFile(imagens[Pagina]);
			
		}
		
		void ProximoButtonClick(object sender, EventArgs e)
		{
			if((Pagina+2) > historiaArray.Length)
			{
				Program.batalha = new BatalhaForm();
				Program.batalha.Show();
				historia.Close();
				sr.Close();
				Close();
			}
			else
			{
				historiaLabel.Text = historiaArray[++Pagina];
				imagemBox.Image = Image.FromFile(imagens[Pagina]);
			}
		}
		
		void AnteriorButtonClick(object sender, EventArgs e)
		{
			if((Pagina-1) < 0)
			{
				
			}
			else
			{
				historiaLabel.Text = historiaArray[--Pagina];
				imagemBox.Image = Image.FromFile(imagens[Pagina]);
			}
		}
		void MenuButtonClick(object sender, EventArgs e)
		{
			Program.menuS = new MenuForm();
			Program.menuS.Show();
			historia.Close();
			sr.Close();
			Close();
		}
	}
}
