
namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	partial class RacasInfoForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label humanoInfoText;
		private System.Windows.Forms.Label humanoLabel;
		private System.Windows.Forms.Label elfoLabel;
		private System.Windows.Forms.Label elfoInfoText;
		private System.Windows.Forms.Label trollInfoText;
		private System.Windows.Forms.Label trollLabel;
		private System.Windows.Forms.Button sairButton;
		
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
			this.humanoInfoText = new System.Windows.Forms.Label();
			this.humanoLabel = new System.Windows.Forms.Label();
			this.trollLabel = new System.Windows.Forms.Label();
			this.elfoLabel = new System.Windows.Forms.Label();
			this.elfoInfoText = new System.Windows.Forms.Label();
			this.trollInfoText = new System.Windows.Forms.Label();
			this.sairButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// humanoInfoText
			// 
			this.humanoInfoText.Location = new System.Drawing.Point(71, 9);
			this.humanoInfoText.Name = "humanoInfoText";
			this.humanoInfoText.Size = new System.Drawing.Size(201, 76);
			this.humanoInfoText.TabIndex = 3;
			this.humanoInfoText.Text = "texto";
			this.humanoInfoText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// humanoLabel
			// 
			this.humanoLabel.Location = new System.Drawing.Point(12, 36);
			this.humanoLabel.Name = "humanoLabel";
			this.humanoLabel.Size = new System.Drawing.Size(53, 23);
			this.humanoLabel.TabIndex = 2;
			this.humanoLabel.Text = "Humano:";
			this.humanoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// trollLabel
			// 
			this.trollLabel.Location = new System.Drawing.Point(12, 112);
			this.trollLabel.Name = "trollLabel";
			this.trollLabel.Size = new System.Drawing.Size(53, 23);
			this.trollLabel.TabIndex = 4;
			this.trollLabel.Text = "Troll:";
			this.trollLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// elfoLabel
			// 
			this.elfoLabel.Location = new System.Drawing.Point(12, 188);
			this.elfoLabel.Name = "elfoLabel";
			this.elfoLabel.Size = new System.Drawing.Size(53, 23);
			this.elfoLabel.TabIndex = 5;
			this.elfoLabel.Text = "Elfo:";
			this.elfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// elfoInfoText
			// 
			this.elfoInfoText.Location = new System.Drawing.Point(71, 161);
			this.elfoInfoText.Name = "elfoInfoText";
			this.elfoInfoText.Size = new System.Drawing.Size(201, 76);
			this.elfoInfoText.TabIndex = 6;
			this.elfoInfoText.Text = "texto";
			this.elfoInfoText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// trollInfoText
			// 
			this.trollInfoText.Location = new System.Drawing.Point(71, 85);
			this.trollInfoText.Name = "trollInfoText";
			this.trollInfoText.Size = new System.Drawing.Size(201, 76);
			this.trollInfoText.TabIndex = 7;
			this.trollInfoText.Text = "texto";
			this.trollInfoText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// sairButton
			// 
			this.sairButton.Location = new System.Drawing.Point(105, 264);
			this.sairButton.Name = "sairButton";
			this.sairButton.Size = new System.Drawing.Size(75, 23);
			this.sairButton.TabIndex = 9;
			this.sairButton.Text = "Sair";
			this.sairButton.UseVisualStyleBackColor = true;
			this.sairButton.Click += new System.EventHandler(this.SairButtonClick);
			// 
			// RacasInfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 288);
			this.Controls.Add(this.sairButton);
			this.Controls.Add(this.trollInfoText);
			this.Controls.Add(this.elfoInfoText);
			this.Controls.Add(this.elfoLabel);
			this.Controls.Add(this.trollLabel);
			this.Controls.Add(this.humanoInfoText);
			this.Controls.Add(this.humanoLabel);
			this.Name = "RacasInfoForm";
			this.Text = "RacasInfoForm";
			this.ResumeLayout(false);

		}
	}
}
