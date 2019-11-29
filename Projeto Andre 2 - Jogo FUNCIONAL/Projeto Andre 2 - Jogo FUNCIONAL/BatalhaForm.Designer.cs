
namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	partial class BatalhaForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label vidaInimigoLabel;
		private System.Windows.Forms.Label nomeJogadorLabel;
		private System.Windows.Forms.Button magia2Button;
		private System.Windows.Forms.Button magia3Button;
		private System.Windows.Forms.Button magia1Button;
		private System.Windows.Forms.Label magia1Label;
		private System.Windows.Forms.Label magia2Label;
		private System.Windows.Forms.Label magia3Label;
		private System.Windows.Forms.ProgressBar vidaJogadorBar;
		private System.Windows.Forms.Label vidaJogadorLabel;
		private System.Windows.Forms.Button passarButton;
		private System.Windows.Forms.Button atacarButton;
		private System.Windows.Forms.Label bar2Label;
		private System.Windows.Forms.ProgressBar vidaInimigoBar;
		private System.Windows.Forms.Label passarLabel;
		private System.Windows.Forms.Label atacarLabel;
		private System.Windows.Forms.Button sairButton;
		private System.Windows.Forms.Button menuButton;
		private System.Windows.Forms.Button magiasMenuButtton;
		private System.Windows.Forms.Button atributosMenuButton;
		private System.Windows.Forms.Button pocoesButton;
		private System.Windows.Forms.Label pocoesLabel;
		private System.Windows.Forms.Label barLabel;
		private System.Windows.Forms.Label manaJogadorLabel;
		private System.Windows.Forms.Label nomeInimigoLabel;
		private System.Windows.Forms.Label magia1RecargaLabel;
		private System.Windows.Forms.Label magia2RecargaLabel;
		private System.Windows.Forms.Label magia3RecargaLabel;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.vidaInimigoLabel = new System.Windows.Forms.Label();
			this.nomeJogadorLabel = new System.Windows.Forms.Label();
			this.magia2Button = new System.Windows.Forms.Button();
			this.magia3Button = new System.Windows.Forms.Button();
			this.magia1Button = new System.Windows.Forms.Button();
			this.magia1Label = new System.Windows.Forms.Label();
			this.magia2Label = new System.Windows.Forms.Label();
			this.magia3Label = new System.Windows.Forms.Label();
			this.vidaJogadorBar = new System.Windows.Forms.ProgressBar();
			this.vidaJogadorLabel = new System.Windows.Forms.Label();
			this.passarButton = new System.Windows.Forms.Button();
			this.atacarButton = new System.Windows.Forms.Button();
			this.bar2Label = new System.Windows.Forms.Label();
			this.vidaInimigoBar = new System.Windows.Forms.ProgressBar();
			this.passarLabel = new System.Windows.Forms.Label();
			this.atacarLabel = new System.Windows.Forms.Label();
			this.sairButton = new System.Windows.Forms.Button();
			this.menuButton = new System.Windows.Forms.Button();
			this.magiasMenuButtton = new System.Windows.Forms.Button();
			this.atributosMenuButton = new System.Windows.Forms.Button();
			this.pocoesButton = new System.Windows.Forms.Button();
			this.pocoesLabel = new System.Windows.Forms.Label();
			this.barLabel = new System.Windows.Forms.Label();
			this.manaJogadorLabel = new System.Windows.Forms.Label();
			this.nomeInimigoLabel = new System.Windows.Forms.Label();
			this.magia1RecargaLabel = new System.Windows.Forms.Label();
			this.magia2RecargaLabel = new System.Windows.Forms.Label();
			this.magia3RecargaLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// vidaInimigoLabel
			// 
			this.vidaInimigoLabel.Location = new System.Drawing.Point(293, 37);
			this.vidaInimigoLabel.Name = "vidaInimigoLabel";
			this.vidaInimigoLabel.Size = new System.Drawing.Size(100, 23);
			this.vidaInimigoLabel.TabIndex = 0;
			this.vidaInimigoLabel.Text = "Vida: 100/100";
			this.vidaInimigoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// nomeJogadorLabel
			// 
			this.nomeJogadorLabel.Location = new System.Drawing.Point(293, 370);
			this.nomeJogadorLabel.Name = "nomeJogadorLabel";
			this.nomeJogadorLabel.Size = new System.Drawing.Size(100, 23);
			this.nomeJogadorLabel.TabIndex = 2;
			this.nomeJogadorLabel.Text = "NomeJogador";
			this.nomeJogadorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// magia2Button
			// 
			this.magia2Button.Location = new System.Drawing.Point(515, 199);
			this.magia2Button.Name = "magia2Button";
			this.magia2Button.Size = new System.Drawing.Size(75, 75);
			this.magia2Button.TabIndex = 4;
			this.magia2Button.Text = "0";
			this.magia2Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.magia2Button.UseVisualStyleBackColor = true;
			this.magia2Button.Click += new System.EventHandler(this.Magia2ButtonClick);
			// 
			// magia3Button
			// 
			this.magia3Button.Location = new System.Drawing.Point(597, 199);
			this.magia3Button.Name = "magia3Button";
			this.magia3Button.Size = new System.Drawing.Size(75, 75);
			this.magia3Button.TabIndex = 5;
			this.magia3Button.Text = "0";
			this.magia3Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.magia3Button.UseVisualStyleBackColor = true;
			this.magia3Button.Click += new System.EventHandler(this.Magia3ButtonClick);
			// 
			// magia1Button
			// 
			this.magia1Button.ForeColor = System.Drawing.SystemColors.MenuText;
			this.magia1Button.Location = new System.Drawing.Point(434, 199);
			this.magia1Button.Name = "magia1Button";
			this.magia1Button.Size = new System.Drawing.Size(75, 75);
			this.magia1Button.TabIndex = 6;
			this.magia1Button.Text = "0";
			this.magia1Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.magia1Button.UseVisualStyleBackColor = true;
			this.magia1Button.Click += new System.EventHandler(this.Magia1ButtonClick);
			// 
			// magia1Label
			// 
			this.magia1Label.Location = new System.Drawing.Point(434, 171);
			this.magia1Label.Name = "magia1Label";
			this.magia1Label.Size = new System.Drawing.Size(75, 25);
			this.magia1Label.TabIndex = 7;
			this.magia1Label.Text = "Magia 1";
			this.magia1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// magia2Label
			// 
			this.magia2Label.Location = new System.Drawing.Point(515, 171);
			this.magia2Label.Name = "magia2Label";
			this.magia2Label.Size = new System.Drawing.Size(75, 25);
			this.magia2Label.TabIndex = 8;
			this.magia2Label.Text = "Magia 2";
			this.magia2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// magia3Label
			// 
			this.magia3Label.Location = new System.Drawing.Point(595, 171);
			this.magia3Label.Name = "magia3Label";
			this.magia3Label.Size = new System.Drawing.Size(75, 25);
			this.magia3Label.TabIndex = 9;
			this.magia3Label.Text = "Magia 3";
			this.magia3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// vidaJogadorBar
			// 
			this.vidaJogadorBar.Location = new System.Drawing.Point(12, 306);
			this.vidaJogadorBar.Name = "vidaJogadorBar";
			this.vidaJogadorBar.Size = new System.Drawing.Size(660, 15);
			this.vidaJogadorBar.TabIndex = 10;
			// 
			// vidaJogadorLabel
			// 
			this.vidaJogadorLabel.Location = new System.Drawing.Point(293, 277);
			this.vidaJogadorLabel.Name = "vidaJogadorLabel";
			this.vidaJogadorLabel.Size = new System.Drawing.Size(100, 23);
			this.vidaJogadorLabel.TabIndex = 11;
			this.vidaJogadorLabel.Text = "Vida: 100/100";
			this.vidaJogadorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// passarButton
			// 
			this.passarButton.Location = new System.Drawing.Point(13, 250);
			this.passarButton.Name = "passarButton";
			this.passarButton.Size = new System.Drawing.Size(50, 50);
			this.passarButton.TabIndex = 14;
			this.passarButton.UseVisualStyleBackColor = true;
			this.passarButton.Click += new System.EventHandler(this.PassarButtonClick);
			// 
			// atacarButton
			// 
			this.atacarButton.Location = new System.Drawing.Point(69, 250);
			this.atacarButton.Name = "atacarButton";
			this.atacarButton.Size = new System.Drawing.Size(50, 50);
			this.atacarButton.TabIndex = 15;
			this.atacarButton.UseVisualStyleBackColor = true;
			this.atacarButton.Click += new System.EventHandler(this.AtacarButtonClick);
			// 
			// bar2Label
			// 
			this.bar2Label.Location = new System.Drawing.Point(13, 81);
			this.bar2Label.Name = "bar2Label";
			this.bar2Label.Size = new System.Drawing.Size(660, 23);
			this.bar2Label.TabIndex = 16;
			this.bar2Label.Text = "_________________________________________________________________________________" +
	"________________________________________________________________";
			// 
			// vidaInimigoBar
			// 
			this.vidaInimigoBar.Location = new System.Drawing.Point(12, 63);
			this.vidaInimigoBar.Name = "vidaInimigoBar";
			this.vidaInimigoBar.Size = new System.Drawing.Size(660, 15);
			this.vidaInimigoBar.TabIndex = 17;
			// 
			// passarLabel
			// 
			this.passarLabel.Location = new System.Drawing.Point(13, 222);
			this.passarLabel.Name = "passarLabel";
			this.passarLabel.Size = new System.Drawing.Size(50, 25);
			this.passarLabel.TabIndex = 18;
			this.passarLabel.Text = "Passar";
			this.passarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// atacarLabel
			// 
			this.atacarLabel.Location = new System.Drawing.Point(69, 222);
			this.atacarLabel.Name = "atacarLabel";
			this.atacarLabel.Size = new System.Drawing.Size(50, 25);
			this.atacarLabel.TabIndex = 19;
			this.atacarLabel.Text = "Atacar";
			this.atacarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// sairButton
			// 
			this.sairButton.Location = new System.Drawing.Point(13, 373);
			this.sairButton.Name = "sairButton";
			this.sairButton.Size = new System.Drawing.Size(75, 23);
			this.sairButton.TabIndex = 20;
			this.sairButton.Text = "Sair";
			this.sairButton.UseVisualStyleBackColor = true;
			// 
			// menuButton
			// 
			this.menuButton.Location = new System.Drawing.Point(94, 373);
			this.menuButton.Name = "menuButton";
			this.menuButton.Size = new System.Drawing.Size(75, 23);
			this.menuButton.TabIndex = 21;
			this.menuButton.Text = "Menu";
			this.menuButton.UseVisualStyleBackColor = true;
			// 
			// magiasMenuButtton
			// 
			this.magiasMenuButtton.Location = new System.Drawing.Point(517, 373);
			this.magiasMenuButtton.Name = "magiasMenuButtton";
			this.magiasMenuButtton.Size = new System.Drawing.Size(75, 23);
			this.magiasMenuButtton.TabIndex = 22;
			this.magiasMenuButtton.Text = "Magias";
			this.magiasMenuButtton.UseVisualStyleBackColor = true;
			// 
			// atributosMenuButton
			// 
			this.atributosMenuButton.Location = new System.Drawing.Point(598, 373);
			this.atributosMenuButton.Name = "atributosMenuButton";
			this.atributosMenuButton.Size = new System.Drawing.Size(75, 23);
			this.atributosMenuButton.TabIndex = 23;
			this.atributosMenuButton.Text = "Atributos";
			this.atributosMenuButton.UseVisualStyleBackColor = true;
			// 
			// pocoesButton
			// 
			this.pocoesButton.Location = new System.Drawing.Point(125, 250);
			this.pocoesButton.Name = "pocoesButton";
			this.pocoesButton.Size = new System.Drawing.Size(50, 50);
			this.pocoesButton.TabIndex = 24;
			this.pocoesButton.UseVisualStyleBackColor = true;
			// 
			// pocoesLabel
			// 
			this.pocoesLabel.Location = new System.Drawing.Point(125, 222);
			this.pocoesLabel.Name = "pocoesLabel";
			this.pocoesLabel.Size = new System.Drawing.Size(50, 25);
			this.pocoesLabel.TabIndex = 25;
			this.pocoesLabel.Text = "Poções";
			this.pocoesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// barLabel
			// 
			this.barLabel.Location = new System.Drawing.Point(12, 347);
			this.barLabel.Name = "barLabel";
			this.barLabel.Size = new System.Drawing.Size(660, 23);
			this.barLabel.TabIndex = 26;
			this.barLabel.Text = "_________________________________________________________________________________" +
	"________________________________________________________________";
			// 
			// manaJogadorLabel
			// 
			this.manaJogadorLabel.Location = new System.Drawing.Point(293, 324);
			this.manaJogadorLabel.Name = "manaJogadorLabel";
			this.manaJogadorLabel.Size = new System.Drawing.Size(100, 23);
			this.manaJogadorLabel.TabIndex = 27;
			this.manaJogadorLabel.Text = "Mana: 100/100";
			this.manaJogadorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// nomeInimigoLabel
			// 
			this.nomeInimigoLabel.Location = new System.Drawing.Point(293, 9);
			this.nomeInimigoLabel.Name = "nomeInimigoLabel";
			this.nomeInimigoLabel.Size = new System.Drawing.Size(100, 23);
			this.nomeInimigoLabel.TabIndex = 28;
			this.nomeInimigoLabel.Text = "Nome Inimigo";
			this.nomeInimigoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// magia1RecargaLabel
			// 
			this.magia1RecargaLabel.Location = new System.Drawing.Point(434, 277);
			this.magia1RecargaLabel.Name = "magia1RecargaLabel";
			this.magia1RecargaLabel.Size = new System.Drawing.Size(75, 20);
			this.magia1RecargaLabel.TabIndex = 29;
			this.magia1RecargaLabel.Text = "Recarga: 0";
			this.magia1RecargaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// magia2RecargaLabel
			// 
			this.magia2RecargaLabel.Location = new System.Drawing.Point(516, 277);
			this.magia2RecargaLabel.Name = "magia2RecargaLabel";
			this.magia2RecargaLabel.Size = new System.Drawing.Size(75, 20);
			this.magia2RecargaLabel.TabIndex = 30;
			this.magia2RecargaLabel.Text = "Recarga: 0";
			this.magia2RecargaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// magia3RecargaLabel
			// 
			this.magia3RecargaLabel.Location = new System.Drawing.Point(595, 277);
			this.magia3RecargaLabel.Name = "magia3RecargaLabel";
			this.magia3RecargaLabel.Size = new System.Drawing.Size(75, 20);
			this.magia3RecargaLabel.TabIndex = 31;
			this.magia3RecargaLabel.Text = "Recarga: 0";
			this.magia3RecargaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// BatalhaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 408);
			this.Controls.Add(this.magia3RecargaLabel);
			this.Controls.Add(this.magia2RecargaLabel);
			this.Controls.Add(this.magia1RecargaLabel);
			this.Controls.Add(this.nomeInimigoLabel);
			this.Controls.Add(this.manaJogadorLabel);
			this.Controls.Add(this.barLabel);
			this.Controls.Add(this.pocoesLabel);
			this.Controls.Add(this.pocoesButton);
			this.Controls.Add(this.atributosMenuButton);
			this.Controls.Add(this.magiasMenuButtton);
			this.Controls.Add(this.menuButton);
			this.Controls.Add(this.sairButton);
			this.Controls.Add(this.atacarLabel);
			this.Controls.Add(this.passarLabel);
			this.Controls.Add(this.vidaInimigoBar);
			this.Controls.Add(this.bar2Label);
			this.Controls.Add(this.atacarButton);
			this.Controls.Add(this.passarButton);
			this.Controls.Add(this.vidaJogadorLabel);
			this.Controls.Add(this.vidaJogadorBar);
			this.Controls.Add(this.magia3Label);
			this.Controls.Add(this.magia2Label);
			this.Controls.Add(this.magia1Label);
			this.Controls.Add(this.magia1Button);
			this.Controls.Add(this.magia3Button);
			this.Controls.Add(this.magia2Button);
			this.Controls.Add(this.nomeJogadorLabel);
			this.Controls.Add(this.vidaInimigoLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "BatalhaForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Faytdowns Desteny";
			this.ResumeLayout(false);

		}
	}
}
