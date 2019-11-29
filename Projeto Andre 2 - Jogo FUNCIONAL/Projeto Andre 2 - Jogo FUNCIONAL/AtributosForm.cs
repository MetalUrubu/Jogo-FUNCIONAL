using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	public partial class AtributosForm : Form
	{
		int forcaInicial, agilidadeInicial, inteligenciaInicial;
		public AtributosForm()
		{
			InitializeComponent();
			pontosNum.Text = Convert.ToString(Program.usuario.status.Pontos);
			forcaNum.Text = Convert.ToString(Program.usuario.status.Forca);
			agilidadeNum.Text = Convert.ToString(Program.usuario.status.Agilidade);
			inteligenciaNum.Text = Convert.ToString(Program.usuario.status.Inteligencia);
			forcaInicial = Program.usuario.status.Forca;
			agilidadeInicial = Program.usuario.status.Agilidade;
			inteligenciaInicial = Program.usuario.status.Inteligencia;
			
			
		}
		void ForcaAddClick(object sender, EventArgs e)
		{
			if(int.Parse(pontosNum.Text) == 0)
			{
				
			}
			else
			{
				Program.usuario.status.addAtributo("Força",1);
				attInferface();
			}
			
		}
		void AgilidadeAddClick(object sender, EventArgs e)
		{
			if(int.Parse(pontosNum.Text) == 0)
			{
				
			}
			else
			{
				Program.usuario.status.addAtributo("Agilidade",1);
				attInferface();
			}
		}
		void InteligenciaAddClick(object sender, EventArgs e)
		{
			if(int.Parse(pontosNum.Text) == 0)
			{
				
			}
			else
			{
				Program.usuario.status.addAtributo("Inteligencia",1);
				attInferface();
			}
		}
		void ForcaSubClick(object sender, EventArgs e)
		{
			if(Convert.ToInt32(forcaNum.Text) == forcaInicial)
			{
				
			}
			else
			{
				Program.usuario.status.subAtributo("Força",1);
				attInferface();
			}
		}
		void AgilidadeSubClick(object sender, EventArgs e)
		{
			if(Convert.ToInt32(agilidadeNum.Text) == agilidadeInicial)
			{
				
			}
			else
			{
				Program.usuario.status.subAtributo("Agilidade",1);
				attInferface();
			}
		}
		void InteligenciaSubClick(object sender, EventArgs e)
		{
			if(Convert.ToInt32(inteligenciaNum.Text) == inteligenciaInicial)
			{
				
			}
			else
			{
				Program.usuario.status.subAtributo("Inteligencia",1);
				attInferface();
			}
		}
		void ConfirmarClick(object sender, EventArgs e)
		{
			if(Program.usuario.status.Pontos > 0)
			{
				MessageBox.Show("Distribua todos os Pontos");
			}
			else
			{
				Program.historiaMenu = new HistoriaForm();
				Program.historiaMenu.Show();
				Close();
			}
			
		}
		void attInferface()
		{
			pontosNum.Text = Convert.ToString(Program.usuario.status.Pontos);
			forcaNum.Text = Convert.ToString(Program.usuario.status.Forca);
			agilidadeNum.Text = Convert.ToString(Program.usuario.status.Agilidade);
			inteligenciaNum.Text = Convert.ToString(Program.usuario.status.Inteligencia);
		}
	}
}
