
namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	partial class AtributosForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button forcaAdd;
		private System.Windows.Forms.Label forcaLabel;
		private System.Windows.Forms.Button forcaSub;
		private System.Windows.Forms.Label forcaNum;
		private System.Windows.Forms.Label inteligenciaNum;
		private System.Windows.Forms.Button InteligenciaSub;
		private System.Windows.Forms.Label inteligenciaLabel;
		private System.Windows.Forms.Button inteligenciaAdd;
		private System.Windows.Forms.Label agilidadeNum;
		private System.Windows.Forms.Button agilidadeSub;
		private System.Windows.Forms.Label agilidadeLabel;
		private System.Windows.Forms.Button agilidadeAdd;
		private System.Windows.Forms.Label pontosLabel;
		private System.Windows.Forms.Label pontosNum;
		private System.Windows.Forms.Button confirmar;
		
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
			this.forcaAdd = new System.Windows.Forms.Button();
			this.forcaLabel = new System.Windows.Forms.Label();
			this.forcaSub = new System.Windows.Forms.Button();
			this.forcaNum = new System.Windows.Forms.Label();
			this.inteligenciaNum = new System.Windows.Forms.Label();
			this.InteligenciaSub = new System.Windows.Forms.Button();
			this.inteligenciaLabel = new System.Windows.Forms.Label();
			this.inteligenciaAdd = new System.Windows.Forms.Button();
			this.agilidadeNum = new System.Windows.Forms.Label();
			this.agilidadeSub = new System.Windows.Forms.Button();
			this.agilidadeLabel = new System.Windows.Forms.Label();
			this.agilidadeAdd = new System.Windows.Forms.Button();
			this.pontosLabel = new System.Windows.Forms.Label();
			this.pontosNum = new System.Windows.Forms.Label();
			this.confirmar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// forcaAdd
			// 
			this.forcaAdd.Location = new System.Drawing.Point(100, 80);
			this.forcaAdd.Name = "forcaAdd";
			this.forcaAdd.Size = new System.Drawing.Size(25, 25);
			this.forcaAdd.TabIndex = 0;
			this.forcaAdd.Text = "+";
			this.forcaAdd.UseVisualStyleBackColor = true;
			this.forcaAdd.Click += new System.EventHandler(this.ForcaAddClick);
			// 
			// forcaLabel
			// 
			this.forcaLabel.Location = new System.Drawing.Point(12, 80);
			this.forcaLabel.Name = "forcaLabel";
			this.forcaLabel.Size = new System.Drawing.Size(80, 25);
			this.forcaLabel.TabIndex = 1;
			this.forcaLabel.Text = "Força";
			this.forcaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// forcaSub
			// 
			this.forcaSub.Location = new System.Drawing.Point(162, 80);
			this.forcaSub.Name = "forcaSub";
			this.forcaSub.Size = new System.Drawing.Size(25, 25);
			this.forcaSub.TabIndex = 2;
			this.forcaSub.Text = "-";
			this.forcaSub.UseVisualStyleBackColor = true;
			this.forcaSub.Click += new System.EventHandler(this.ForcaSubClick);
			// 
			// forcaNum
			// 
			this.forcaNum.Location = new System.Drawing.Point(131, 80);
			this.forcaNum.Name = "forcaNum";
			this.forcaNum.Size = new System.Drawing.Size(25, 25);
			this.forcaNum.TabIndex = 3;
			this.forcaNum.Text = "0";
			this.forcaNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// inteligenciaNum
			// 
			this.inteligenciaNum.Location = new System.Drawing.Point(131, 164);
			this.inteligenciaNum.Name = "inteligenciaNum";
			this.inteligenciaNum.Size = new System.Drawing.Size(25, 25);
			this.inteligenciaNum.TabIndex = 7;
			this.inteligenciaNum.Text = "0";
			this.inteligenciaNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// InteligenciaSub
			// 
			this.InteligenciaSub.Location = new System.Drawing.Point(162, 164);
			this.InteligenciaSub.Name = "InteligenciaSub";
			this.InteligenciaSub.Size = new System.Drawing.Size(25, 25);
			this.InteligenciaSub.TabIndex = 6;
			this.InteligenciaSub.Text = "-";
			this.InteligenciaSub.UseVisualStyleBackColor = true;
			this.InteligenciaSub.Click += new System.EventHandler(this.InteligenciaSubClick);
			// 
			// inteligenciaLabel
			// 
			this.inteligenciaLabel.Location = new System.Drawing.Point(12, 164);
			this.inteligenciaLabel.Name = "inteligenciaLabel";
			this.inteligenciaLabel.Size = new System.Drawing.Size(80, 25);
			this.inteligenciaLabel.TabIndex = 5;
			this.inteligenciaLabel.Text = "Inteligencia";
			this.inteligenciaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// inteligenciaAdd
			// 
			this.inteligenciaAdd.Location = new System.Drawing.Point(100, 164);
			this.inteligenciaAdd.Name = "inteligenciaAdd";
			this.inteligenciaAdd.Size = new System.Drawing.Size(25, 25);
			this.inteligenciaAdd.TabIndex = 4;
			this.inteligenciaAdd.Text = "+";
			this.inteligenciaAdd.UseVisualStyleBackColor = true;
			this.inteligenciaAdd.Click += new System.EventHandler(this.InteligenciaAddClick);
			// 
			// agilidadeNum
			// 
			this.agilidadeNum.Location = new System.Drawing.Point(131, 121);
			this.agilidadeNum.Name = "agilidadeNum";
			this.agilidadeNum.Size = new System.Drawing.Size(25, 25);
			this.agilidadeNum.TabIndex = 11;
			this.agilidadeNum.Text = "0";
			this.agilidadeNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// agilidadeSub
			// 
			this.agilidadeSub.Location = new System.Drawing.Point(162, 121);
			this.agilidadeSub.Name = "agilidadeSub";
			this.agilidadeSub.Size = new System.Drawing.Size(25, 25);
			this.agilidadeSub.TabIndex = 10;
			this.agilidadeSub.Text = "-";
			this.agilidadeSub.UseVisualStyleBackColor = true;
			this.agilidadeSub.Click += new System.EventHandler(this.AgilidadeSubClick);
			// 
			// agilidadeLabel
			// 
			this.agilidadeLabel.Location = new System.Drawing.Point(12, 121);
			this.agilidadeLabel.Name = "agilidadeLabel";
			this.agilidadeLabel.Size = new System.Drawing.Size(80, 25);
			this.agilidadeLabel.TabIndex = 9;
			this.agilidadeLabel.Text = "Agilidade";
			this.agilidadeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// agilidadeAdd
			// 
			this.agilidadeAdd.Location = new System.Drawing.Point(100, 121);
			this.agilidadeAdd.Name = "agilidadeAdd";
			this.agilidadeAdd.Size = new System.Drawing.Size(25, 25);
			this.agilidadeAdd.TabIndex = 8;
			this.agilidadeAdd.Text = "+";
			this.agilidadeAdd.UseVisualStyleBackColor = true;
			this.agilidadeAdd.Click += new System.EventHandler(this.AgilidadeAddClick);
			// 
			// pontosLabel
			// 
			this.pontosLabel.Location = new System.Drawing.Point(43, 22);
			this.pontosLabel.Name = "pontosLabel";
			this.pontosLabel.Size = new System.Drawing.Size(82, 25);
			this.pontosLabel.TabIndex = 12;
			this.pontosLabel.Text = "Pontos:";
			this.pontosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// pontosNum
			// 
			this.pontosNum.Location = new System.Drawing.Point(131, 22);
			this.pontosNum.Name = "pontosNum";
			this.pontosNum.Size = new System.Drawing.Size(25, 25);
			this.pontosNum.TabIndex = 13;
			this.pontosNum.Text = "0";
			this.pontosNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// confirmar
			// 
			this.confirmar.Location = new System.Drawing.Point(197, 226);
			this.confirmar.Name = "confirmar";
			this.confirmar.Size = new System.Drawing.Size(75, 25);
			this.confirmar.TabIndex = 15;
			this.confirmar.Text = "Confirmar";
			this.confirmar.UseVisualStyleBackColor = true;
			this.confirmar.Click += new System.EventHandler(this.ConfirmarClick);
			// 
			// AtributosForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.confirmar);
			this.Controls.Add(this.pontosNum);
			this.Controls.Add(this.pontosLabel);
			this.Controls.Add(this.agilidadeNum);
			this.Controls.Add(this.agilidadeSub);
			this.Controls.Add(this.agilidadeLabel);
			this.Controls.Add(this.agilidadeAdd);
			this.Controls.Add(this.inteligenciaNum);
			this.Controls.Add(this.InteligenciaSub);
			this.Controls.Add(this.inteligenciaLabel);
			this.Controls.Add(this.inteligenciaAdd);
			this.Controls.Add(this.forcaNum);
			this.Controls.Add(this.forcaSub);
			this.Controls.Add(this.forcaLabel);
			this.Controls.Add(this.forcaAdd);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AtributosForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Atributos";
			this.ResumeLayout(false);

		}
	}
}
