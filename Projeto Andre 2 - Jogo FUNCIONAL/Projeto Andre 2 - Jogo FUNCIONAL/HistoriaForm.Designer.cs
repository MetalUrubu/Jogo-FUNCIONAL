/*
 * Created by SharpDevelop.
 * User: PC
 * Date: 26/11/2019
 * Time: 12:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	partial class HistoriaForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.historiaLabel = new System.Windows.Forms.Label();
			this.anteriorButton = new System.Windows.Forms.Button();
			this.menuButton = new System.Windows.Forms.Button();
			this.proximoButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// historiaLabel
			// 
			this.historiaLabel.Location = new System.Drawing.Point(29, 9);
			this.historiaLabel.Name = "historiaLabel";
			this.historiaLabel.Size = new System.Drawing.Size(222, 174);
			this.historiaLabel.TabIndex = 0;
			this.historiaLabel.Text = "label1";
			// 
			// anteriorButton
			// 
			this.anteriorButton.Location = new System.Drawing.Point(12, 226);
			this.anteriorButton.Name = "anteriorButton";
			this.anteriorButton.Size = new System.Drawing.Size(75, 23);
			this.anteriorButton.TabIndex = 1;
			this.anteriorButton.Text = "Anterior";
			this.anteriorButton.UseVisualStyleBackColor = true;
			// 
			// menuButton
			// 
			this.menuButton.Location = new System.Drawing.Point(102, 226);
			this.menuButton.Name = "menuButton";
			this.menuButton.Size = new System.Drawing.Size(75, 23);
			this.menuButton.TabIndex = 2;
			this.menuButton.Text = "Menu";
			this.menuButton.UseVisualStyleBackColor = true;
			// 
			// proximoButton
			// 
			this.proximoButton.Location = new System.Drawing.Point(200, 226);
			this.proximoButton.Name = "proximoButton";
			this.proximoButton.Size = new System.Drawing.Size(75, 23);
			this.proximoButton.TabIndex = 3;
			this.proximoButton.Text = "Próximo";
			this.proximoButton.UseVisualStyleBackColor = true;
			// 
			// HistoriaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.proximoButton);
			this.Controls.Add(this.menuButton);
			this.Controls.Add(this.anteriorButton);
			this.Controls.Add(this.historiaLabel);
			this.Name = "HistoriaForm";
			this.Text = "HistoriaForm";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button proximoButton;
		private System.Windows.Forms.Button menuButton;
		private System.Windows.Forms.Button anteriorButton;
		private System.Windows.Forms.Label historiaLabel;
	}
}
