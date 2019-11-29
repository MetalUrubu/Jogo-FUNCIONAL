namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	partial class HistoriaForm
	{
		private System.ComponentModel.IContainer components = null;
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoriaForm));
			this.historiaLabel = new System.Windows.Forms.Label();
			this.anteriorButton = new System.Windows.Forms.Button();
			this.menuButton = new System.Windows.Forms.Button();
			this.proximoButton = new System.Windows.Forms.Button();
			this.imagemBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.imagemBox)).BeginInit();
			this.SuspendLayout();
			// 
			// historiaLabel
			// 
			this.historiaLabel.Location = new System.Drawing.Point(28, 9);
			this.historiaLabel.Name = "historiaLabel";
			this.historiaLabel.Size = new System.Drawing.Size(423, 76);
			this.historiaLabel.TabIndex = 0;
			this.historiaLabel.Text = "label1";
			// 
			// anteriorButton
			// 
			this.anteriorButton.Location = new System.Drawing.Point(28, 341);
			this.anteriorButton.Name = "anteriorButton";
			this.anteriorButton.Size = new System.Drawing.Size(75, 23);
			this.anteriorButton.TabIndex = 1;
			this.anteriorButton.Text = "Anterior";
			this.anteriorButton.UseVisualStyleBackColor = true;
			this.anteriorButton.Click += new System.EventHandler(this.AnteriorButtonClick);
			// 
			// menuButton
			// 
			this.menuButton.Location = new System.Drawing.Point(209, 341);
			this.menuButton.Name = "menuButton";
			this.menuButton.Size = new System.Drawing.Size(75, 23);
			this.menuButton.TabIndex = 2;
			this.menuButton.Text = "Menu";
			this.menuButton.UseVisualStyleBackColor = true;
			// 
			// proximoButton
			// 
			this.proximoButton.Location = new System.Drawing.Point(376, 341);
			this.proximoButton.Name = "proximoButton";
			this.proximoButton.Size = new System.Drawing.Size(75, 23);
			this.proximoButton.TabIndex = 3;
			this.proximoButton.Text = "Próximo";
			this.proximoButton.UseVisualStyleBackColor = true;
			this.proximoButton.Click += new System.EventHandler(this.ProximoButtonClick);
			// 
			// imagemBox
			// 
			this.imagemBox.Image = ((System.Drawing.Image)(resources.GetObject("imagemBox.Image")));
			this.imagemBox.Location = new System.Drawing.Point(28, 113);
			this.imagemBox.Name = "imagemBox";
			this.imagemBox.Size = new System.Drawing.Size(423, 222);
			this.imagemBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imagemBox.TabIndex = 4;
			this.imagemBox.TabStop = false;
			// 
			// HistoriaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(479, 376);
			this.Controls.Add(this.imagemBox);
			this.Controls.Add(this.proximoButton);
			this.Controls.Add(this.menuButton);
			this.Controls.Add(this.anteriorButton);
			this.Controls.Add(this.historiaLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "HistoriaForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Faytdows Destiny";
			((System.ComponentModel.ISupportInitialize)(this.imagemBox)).EndInit();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.PictureBox imagemBox;
		private System.Windows.Forms.Button proximoButton;
		private System.Windows.Forms.Button menuButton;
		private System.Windows.Forms.Button anteriorButton;
		private System.Windows.Forms.Label historiaLabel;
	}
}
