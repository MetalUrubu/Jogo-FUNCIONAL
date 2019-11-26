
namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	partial class ClassesInfoForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label magoInfoText;
		private System.Windows.Forms.Label arqueiroInfoText;
		private System.Windows.Forms.Label arqueiroLabel;
		private System.Windows.Forms.Label magoLabel;
		private System.Windows.Forms.Label guerreiroInfoText;
		private System.Windows.Forms.Label guerreiroLabel;
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
			this.magoInfoText = new System.Windows.Forms.Label();
			this.arqueiroInfoText = new System.Windows.Forms.Label();
			this.arqueiroLabel = new System.Windows.Forms.Label();
			this.magoLabel = new System.Windows.Forms.Label();
			this.guerreiroInfoText = new System.Windows.Forms.Label();
			this.guerreiroLabel = new System.Windows.Forms.Label();
			this.sairButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// magoInfoText
			// 
			this.magoInfoText.Location = new System.Drawing.Point(71, 85);
			this.magoInfoText.Name = "magoInfoText";
			this.magoInfoText.Size = new System.Drawing.Size(201, 76);
			this.magoInfoText.TabIndex = 13;
			this.magoInfoText.Text = "texto";
			this.magoInfoText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// arqueiroInfoText
			// 
			this.arqueiroInfoText.Location = new System.Drawing.Point(71, 161);
			this.arqueiroInfoText.Name = "arqueiroInfoText";
			this.arqueiroInfoText.Size = new System.Drawing.Size(201, 76);
			this.arqueiroInfoText.TabIndex = 12;
			this.arqueiroInfoText.Text = "texto";
			this.arqueiroInfoText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// arqueiroLabel
			// 
			this.arqueiroLabel.Location = new System.Drawing.Point(12, 188);
			this.arqueiroLabel.Name = "arqueiroLabel";
			this.arqueiroLabel.Size = new System.Drawing.Size(53, 23);
			this.arqueiroLabel.TabIndex = 11;
			this.arqueiroLabel.Text = "Arqueiro";
			this.arqueiroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// magoLabel
			// 
			this.magoLabel.Location = new System.Drawing.Point(12, 112);
			this.magoLabel.Name = "magoLabel";
			this.magoLabel.Size = new System.Drawing.Size(53, 23);
			this.magoLabel.TabIndex = 10;
			this.magoLabel.Text = "Mago:";
			this.magoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// guerreiroInfoText
			// 
			this.guerreiroInfoText.Location = new System.Drawing.Point(71, 9);
			this.guerreiroInfoText.Name = "guerreiroInfoText";
			this.guerreiroInfoText.Size = new System.Drawing.Size(201, 76);
			this.guerreiroInfoText.TabIndex = 9;
			this.guerreiroInfoText.Text = "texto";
			this.guerreiroInfoText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// guerreiroLabel
			// 
			this.guerreiroLabel.Location = new System.Drawing.Point(12, 36);
			this.guerreiroLabel.Name = "guerreiroLabel";
			this.guerreiroLabel.Size = new System.Drawing.Size(53, 23);
			this.guerreiroLabel.TabIndex = 8;
			this.guerreiroLabel.Text = "Guerreiro:";
			this.guerreiroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// sairButton
			// 
			this.sairButton.Location = new System.Drawing.Point(105, 253);
			this.sairButton.Name = "sairButton";
			this.sairButton.Size = new System.Drawing.Size(75, 23);
			this.sairButton.TabIndex = 14;
			this.sairButton.Text = "Sair";
			this.sairButton.UseVisualStyleBackColor = true;
			this.sairButton.Click += new System.EventHandler(this.SairButtonClick);
			// 
			// ClassesInfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 288);
			this.Controls.Add(this.sairButton);
			this.Controls.Add(this.magoInfoText);
			this.Controls.Add(this.arqueiroInfoText);
			this.Controls.Add(this.arqueiroLabel);
			this.Controls.Add(this.magoLabel);
			this.Controls.Add(this.guerreiroInfoText);
			this.Controls.Add(this.guerreiroLabel);
			this.Name = "ClassesInfoForm";
			this.Text = "ClassesInfoForm";
			this.ResumeLayout(false);

		}
	}
}
