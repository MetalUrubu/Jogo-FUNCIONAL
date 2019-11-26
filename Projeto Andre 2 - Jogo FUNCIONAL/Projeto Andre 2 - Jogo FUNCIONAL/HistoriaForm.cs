using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	public partial class HistoriaForm : Form
	{
		static FileStream historia = new FileStream("Historia.txt", FileMode.Open);
		static StreamReader sr = new StreamReader(historia);
		static string todaHistoria  = sr.ReadToEnd();
		public string[] historiaArray = todaHistoria.Split('\n');
		int pagina;		
		
		public HistoriaForm()
		{
			InitializeComponent();
			historiaLabel.Text = historiaArray[pagina];
		}
		
		void ProximoButtonClick(object sender, EventArgs e)
		{
			if((pagina +2) > historiaArray.Length){
				
			}else{
				historiaLabel.Text = historiaArray[++pagina];
				imagemBox.Image = Image.FromFile("cavaleirodomal.jpg");
			}
		}
		
		void AnteriorButtonClick(object sender, EventArgs e)
		{
			historiaLabel.Text = historiaArray[--pagina];
			
		}
	}
}
