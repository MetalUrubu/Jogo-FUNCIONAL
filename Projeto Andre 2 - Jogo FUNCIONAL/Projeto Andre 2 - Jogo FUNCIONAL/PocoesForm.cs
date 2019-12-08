
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	public partial class PocoesForm : Form
	{
		static string[] pocoes = Directory.GetFiles("Poções");
		public PocoesForm()
		{
			InitializeComponent();
			pocaoVidaButton.BackgroundImage = Image.FromFile(pocoes[0]);
			pocaoVidaButton.BackgroundImageLayout = ImageLayout.Stretch;
			pocaoManaButton.BackgroundImage = Image.FromFile(pocoes[1]);
			pocaoManaButton.BackgroundImageLayout = ImageLayout.Stretch;
			pocaoDanoButton.BackgroundImage = Image.FromFile(pocoes[2]);
			pocaoDanoButton.BackgroundImageLayout = ImageLayout.Stretch;
			pocaoVenenoButton.BackgroundImage = Image.FromFile(pocoes[3]);
			pocaoVenenoButton.BackgroundImageLayout = ImageLayout.Stretch;
			pocaoErrarButton.BackgroundImage = Image.FromFile(pocoes[4]);
			pocaoErrarButton.BackgroundImageLayout = ImageLayout.Stretch;
		}
	}
}
