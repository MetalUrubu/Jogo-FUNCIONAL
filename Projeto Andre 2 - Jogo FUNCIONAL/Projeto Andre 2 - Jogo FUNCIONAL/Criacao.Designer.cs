/*
 * Created by SharpDevelop.
 * User: UCL
 * Date: 25/11/2019
 * Time: 21:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	partial class Criacao
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox racaGroupBox;
		private System.Windows.Forms.RadioButton elfoRadio;
		private System.Windows.Forms.RadioButton trollRadio;
		private System.Windows.Forms.RadioButton humanoRadio;
		private System.Windows.Forms.GroupBox classeGroupBox;
		private System.Windows.Forms.RadioButton arqueiroRadio;
		private System.Windows.Forms.RadioButton magoRadio;
		private System.Windows.Forms.RadioButton guerreiroRadio;
		private System.Windows.Forms.TextBox nomeTextField;
		private System.Windows.Forms.Label nomeLabel;
		private System.Windows.Forms.Button racaInfoButton;
		private System.Windows.Forms.Button confrimarButton;
		private System.Windows.Forms.Button classeInforButton;
		
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
			this.racaGroupBox = new System.Windows.Forms.GroupBox();
			this.elfoRadio = new System.Windows.Forms.RadioButton();
			this.trollRadio = new System.Windows.Forms.RadioButton();
			this.humanoRadio = new System.Windows.Forms.RadioButton();
			this.classeGroupBox = new System.Windows.Forms.GroupBox();
			this.arqueiroRadio = new System.Windows.Forms.RadioButton();
			this.magoRadio = new System.Windows.Forms.RadioButton();
			this.guerreiroRadio = new System.Windows.Forms.RadioButton();
			this.nomeTextField = new System.Windows.Forms.TextBox();
			this.nomeLabel = new System.Windows.Forms.Label();
			this.racaInfoButton = new System.Windows.Forms.Button();
			this.confrimarButton = new System.Windows.Forms.Button();
			this.classeInforButton = new System.Windows.Forms.Button();
			this.racaGroupBox.SuspendLayout();
			this.classeGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// racaGroupBox
			// 
			this.racaGroupBox.Controls.Add(this.elfoRadio);
			this.racaGroupBox.Controls.Add(this.trollRadio);
			this.racaGroupBox.Controls.Add(this.humanoRadio);
			this.racaGroupBox.Location = new System.Drawing.Point(12, 77);
			this.racaGroupBox.Name = "racaGroupBox";
			this.racaGroupBox.Size = new System.Drawing.Size(114, 143);
			this.racaGroupBox.TabIndex = 0;
			this.racaGroupBox.TabStop = false;
			this.racaGroupBox.Text = "Raças";
			// 
			// elfoRadio
			// 
			this.elfoRadio.Location = new System.Drawing.Point(4, 79);
			this.elfoRadio.Name = "elfoRadio";
			this.elfoRadio.Size = new System.Drawing.Size(104, 24);
			this.elfoRadio.TabIndex = 2;
			this.elfoRadio.TabStop = true;
			this.elfoRadio.Text = "Elfo";
			this.elfoRadio.UseVisualStyleBackColor = true;
			this.elfoRadio.CheckedChanged += new System.EventHandler(this.ElfoRadioCheckedChanged);
			// 
			// trollRadio
			// 
			this.trollRadio.Location = new System.Drawing.Point(4, 49);
			this.trollRadio.Name = "trollRadio";
			this.trollRadio.Size = new System.Drawing.Size(104, 24);
			this.trollRadio.TabIndex = 1;
			this.trollRadio.TabStop = true;
			this.trollRadio.Text = "Troll";
			this.trollRadio.UseVisualStyleBackColor = true;
			this.trollRadio.CheckedChanged += new System.EventHandler(this.TrollRadioCheckedChanged);
			// 
			// humanoRadio
			// 
			this.humanoRadio.Location = new System.Drawing.Point(4, 19);
			this.humanoRadio.Name = "humanoRadio";
			this.humanoRadio.Size = new System.Drawing.Size(104, 24);
			this.humanoRadio.TabIndex = 0;
			this.humanoRadio.TabStop = true;
			this.humanoRadio.Text = "Humano";
			this.humanoRadio.UseVisualStyleBackColor = true;
			this.humanoRadio.CheckedChanged += new System.EventHandler(this.HumanoRadioCheckedChanged);
			// 
			// classeGroupBox
			// 
			this.classeGroupBox.Controls.Add(this.arqueiroRadio);
			this.classeGroupBox.Controls.Add(this.magoRadio);
			this.classeGroupBox.Controls.Add(this.guerreiroRadio);
			this.classeGroupBox.Location = new System.Drawing.Point(148, 77);
			this.classeGroupBox.Name = "classeGroupBox";
			this.classeGroupBox.Size = new System.Drawing.Size(124, 143);
			this.classeGroupBox.TabIndex = 1;
			this.classeGroupBox.TabStop = false;
			this.classeGroupBox.Text = "Classes";
			// 
			// arqueiroRadio
			// 
			this.arqueiroRadio.Location = new System.Drawing.Point(6, 79);
			this.arqueiroRadio.Name = "arqueiroRadio";
			this.arqueiroRadio.Size = new System.Drawing.Size(104, 24);
			this.arqueiroRadio.TabIndex = 3;
			this.arqueiroRadio.TabStop = true;
			this.arqueiroRadio.Text = "Arrqueiro";
			this.arqueiroRadio.UseVisualStyleBackColor = true;
			this.arqueiroRadio.CheckedChanged += new System.EventHandler(this.ArqueiroRadioCheckedChanged);
			// 
			// magoRadio
			// 
			this.magoRadio.Location = new System.Drawing.Point(6, 49);
			this.magoRadio.Name = "magoRadio";
			this.magoRadio.Size = new System.Drawing.Size(104, 24);
			this.magoRadio.TabIndex = 3;
			this.magoRadio.TabStop = true;
			this.magoRadio.Text = "Mago";
			this.magoRadio.UseVisualStyleBackColor = true;
			this.magoRadio.CheckedChanged += new System.EventHandler(this.MagoRadioCheckedChanged);
			// 
			// guerreiroRadio
			// 
			this.guerreiroRadio.Location = new System.Drawing.Point(6, 19);
			this.guerreiroRadio.Name = "guerreiroRadio";
			this.guerreiroRadio.Size = new System.Drawing.Size(104, 24);
			this.guerreiroRadio.TabIndex = 4;
			this.guerreiroRadio.TabStop = true;
			this.guerreiroRadio.Text = "Guerreiro";
			this.guerreiroRadio.UseVisualStyleBackColor = true;
			this.guerreiroRadio.CheckedChanged += new System.EventHandler(this.GuerreiroRadioCheckedChanged);
			// 
			// nomeTextField
			// 
			this.nomeTextField.Location = new System.Drawing.Point(87, 35);
			this.nomeTextField.Name = "nomeTextField";
			this.nomeTextField.Size = new System.Drawing.Size(100, 20);
			this.nomeTextField.TabIndex = 2;
			this.nomeTextField.TextChanged += new System.EventHandler(this.NomeTextFieldTextChanged);
			// 
			// nomeLabel
			// 
			this.nomeLabel.Location = new System.Drawing.Point(87, 9);
			this.nomeLabel.Name = "nomeLabel";
			this.nomeLabel.Size = new System.Drawing.Size(100, 23);
			this.nomeLabel.TabIndex = 3;
			this.nomeLabel.Text = "Nome";
			this.nomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// racaInfoButton
			// 
			this.racaInfoButton.Location = new System.Drawing.Point(12, 226);
			this.racaInfoButton.Name = "racaInfoButton";
			this.racaInfoButton.Size = new System.Drawing.Size(75, 23);
			this.racaInfoButton.TabIndex = 4;
			this.racaInfoButton.Text = "Raça Info";
			this.racaInfoButton.UseVisualStyleBackColor = true;
			this.racaInfoButton.Click += new System.EventHandler(this.RacaInfoButtonClick);
			// 
			// confrimarButton
			// 
			this.confrimarButton.Location = new System.Drawing.Point(101, 226);
			this.confrimarButton.Name = "confrimarButton";
			this.confrimarButton.Size = new System.Drawing.Size(90, 23);
			this.confrimarButton.TabIndex = 5;
			this.confrimarButton.Text = "Confirmar";
			this.confrimarButton.UseVisualStyleBackColor = true;
			this.confrimarButton.Click += new System.EventHandler(this.ConfrimarButtonClick);
			// 
			// classeInforButton
			// 
			this.classeInforButton.Location = new System.Drawing.Point(197, 226);
			this.classeInforButton.Name = "classeInforButton";
			this.classeInforButton.Size = new System.Drawing.Size(75, 23);
			this.classeInforButton.TabIndex = 6;
			this.classeInforButton.Text = "Classe Info";
			this.classeInforButton.UseVisualStyleBackColor = true;
			this.classeInforButton.Click += new System.EventHandler(this.ClasseInforButtonClick);
			// 
			// Criacao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.classeInforButton);
			this.Controls.Add(this.confrimarButton);
			this.Controls.Add(this.racaInfoButton);
			this.Controls.Add(this.nomeLabel);
			this.Controls.Add(this.nomeTextField);
			this.Controls.Add(this.classeGroupBox);
			this.Controls.Add(this.racaGroupBox);
			this.Name = "Criacao";
			this.Text = "Novo Personagem";
			this.racaGroupBox.ResumeLayout(false);
			this.classeGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
