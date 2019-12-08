namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button novoJogo;
		private System.Windows.Forms.Button carregarJogo;
		private System.Windows.Forms.Button sair;
		
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
			this.novoJogo = new System.Windows.Forms.Button();
			this.carregarJogo = new System.Windows.Forms.Button();
			this.sair = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// novoJogo
			// 
			this.novoJogo.Location = new System.Drawing.Point(92, 10);
			this.novoJogo.Name = "novoJogo";
			this.novoJogo.Size = new System.Drawing.Size(100, 25);
			this.novoJogo.TabIndex = 1;
			this.novoJogo.Text = "Novo Jogo";
			this.novoJogo.UseVisualStyleBackColor = true;
			this.novoJogo.Click += new System.EventHandler(this.NovoJogoClick);
			// 
			// carregarJogo
			// 
			this.carregarJogo.Location = new System.Drawing.Point(92, 41);
			this.carregarJogo.Name = "carregarJogo";
			this.carregarJogo.Size = new System.Drawing.Size(100, 25);
			this.carregarJogo.TabIndex = 2;
			this.carregarJogo.Text = "Carregar Jogo";
			this.carregarJogo.UseVisualStyleBackColor = true;
			this.carregarJogo.Click += new System.EventHandler(this.CarregarJogoClick);
			// 
			// sair
			// 
			this.sair.Location = new System.Drawing.Point(92, 72);
			this.sair.Name = "sair";
			this.sair.Size = new System.Drawing.Size(100, 25);
			this.sair.TabIndex = 3;
			this.sair.Text = "Sair";
			this.sair.UseVisualStyleBackColor = true;
			this.sair.Click += new System.EventHandler(this.SairClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 120);
			this.Controls.Add(this.sair);
			this.Controls.Add(this.carregarJogo);
			this.Controls.Add(this.novoJogo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Jogo FUNCIONAL";
			this.ResumeLayout(false);

		}
	}
}
