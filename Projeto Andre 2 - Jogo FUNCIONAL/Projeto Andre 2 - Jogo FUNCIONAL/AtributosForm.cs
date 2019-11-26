using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	public partial class AtributosForm : Form
	{
		public AtributosForm()
		{
			InitializeComponent();
			pontosNum.Text = Convert.ToString(Program.usuario.status.Pontos);
			forcaNum.Text = Convert.ToString(Program.usuario.status.Forca);
			agilidadeNum.Text = Convert.ToString(Program.usuario.status.Agilidade);
			inteligenciaNum.Text = Convert.ToString(Program.usuario.status.Inteligencia);
			
		}
		void ForcaAddClick(object sender, EventArgs e)
		{
			Program.usuario.status.addAtributo("Força",1);
			attInferface();
		}
		void AgilidadeAddClick(object sender, EventArgs e)
		{
			Program.usuario.status.addAtributo("Força",1);
			attInferface();
		}
		void InteligenciaAddClick(object sender, EventArgs e)
		{
			Program.usuario.status.addAtributo("Agilidade",1);
			attInferface();
		}
		void ForcaSubClick(object sender, EventArgs e)
		{	
			Program.usuario.status.subAtributo("Inteligencia",1);
			attInferface();
		}
		void AgilidadeSubClick(object sender, EventArgs e)
		{
			Program.usuario.status.subAtributo("Agilidade",1);
			attInferface();
		}
		void InteligenciaSubClick(object sender, EventArgs e)
		{
			Program.usuario.status.subAtributo("Inteligencia",1);
			attInferface();
		}
		void ConfirmarClick(object sender, EventArgs e)
		{
	
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
