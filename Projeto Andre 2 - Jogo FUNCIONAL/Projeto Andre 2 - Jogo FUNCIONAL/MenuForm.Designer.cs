/*
 * Created by SharpDevelop.
 * User: PC
 * Date: 26/11/2019
 * Time: 14:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	partial class MenuForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
			this.retomarButton = new System.Windows.Forms.Button();
			this.atributosButton = new System.Windows.Forms.Button();
			this.magiasButton = new System.Windows.Forms.Button();
			this.lojaButton = new System.Windows.Forms.Button();
			this.forjaButton = new System.Windows.Forms.Button();
			this.magiasLabel = new System.Windows.Forms.Label();
			this.atributosLabel = new System.Windows.Forms.Label();
			this.forjaLabel = new System.Windows.Forms.Label();
			this.lojaLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// retomarButton
			// 
			this.retomarButton.Location = new System.Drawing.Point(83, 272);
			this.retomarButton.Name = "retomarButton";
			this.retomarButton.Size = new System.Drawing.Size(100, 31);
			this.retomarButton.TabIndex = 0;
			this.retomarButton.Text = "Retornar";
			this.retomarButton.UseVisualStyleBackColor = true;
			this.retomarButton.Click += new System.EventHandler(this.RetomarButtonClick);
			// 
			// atributosButton
			// 
			this.atributosButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("atributosButton.BackgroundImage")));
			this.atributosButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.atributosButton.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.atributosButton.ForeColor = System.Drawing.Color.Blue;
			this.atributosButton.Location = new System.Drawing.Point(30, 33);
			this.atributosButton.Name = "atributosButton";
			this.atributosButton.Size = new System.Drawing.Size(100, 100);
			this.atributosButton.TabIndex = 1;
			this.atributosButton.UseVisualStyleBackColor = true;
			this.atributosButton.Click += new System.EventHandler(this.AtributosButtonClick);
			// 
			// magiasButton
			// 
			this.magiasButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("magiasButton.BackgroundImage")));
			this.magiasButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.magiasButton.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.magiasButton.ForeColor = System.Drawing.Color.Blue;
			this.magiasButton.Location = new System.Drawing.Point(136, 164);
			this.magiasButton.Name = "magiasButton";
			this.magiasButton.Size = new System.Drawing.Size(100, 100);
			this.magiasButton.TabIndex = 2;
			this.magiasButton.UseVisualStyleBackColor = true;
			// 
			// lojaButton
			// 
			this.lojaButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lojaButton.BackgroundImage")));
			this.lojaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.lojaButton.Location = new System.Drawing.Point(30, 164);
			this.lojaButton.Name = "lojaButton";
			this.lojaButton.Size = new System.Drawing.Size(100, 100);
			this.lojaButton.TabIndex = 3;
			this.lojaButton.UseVisualStyleBackColor = true;
			// 
			// forjaButton
			// 
			this.forjaButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("forjaButton.BackgroundImage")));
			this.forjaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.forjaButton.Location = new System.Drawing.Point(136, 33);
			this.forjaButton.Name = "forjaButton";
			this.forjaButton.Size = new System.Drawing.Size(100, 100);
			this.forjaButton.TabIndex = 5;
			this.forjaButton.UseVisualStyleBackColor = true;
			this.forjaButton.Click += new System.EventHandler(this.ForjaButtonClick);
			// 
			// magiasLabel
			// 
			this.magiasLabel.Location = new System.Drawing.Point(136, 136);
			this.magiasLabel.Name = "magiasLabel";
			this.magiasLabel.Size = new System.Drawing.Size(100, 25);
			this.magiasLabel.TabIndex = 6;
			this.magiasLabel.Text = "Magias";
			this.magiasLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// atributosLabel
			// 
			this.atributosLabel.Location = new System.Drawing.Point(30, 5);
			this.atributosLabel.Name = "atributosLabel";
			this.atributosLabel.Size = new System.Drawing.Size(100, 25);
			this.atributosLabel.TabIndex = 7;
			this.atributosLabel.Text = "Atributos";
			this.atributosLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// forjaLabel
			// 
			this.forjaLabel.Location = new System.Drawing.Point(136, 5);
			this.forjaLabel.Name = "forjaLabel";
			this.forjaLabel.Size = new System.Drawing.Size(100, 25);
			this.forjaLabel.TabIndex = 8;
			this.forjaLabel.Text = "Forja";
			this.forjaLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// lojaLabel
			// 
			this.lojaLabel.Location = new System.Drawing.Point(30, 136);
			this.lojaLabel.Name = "lojaLabel";
			this.lojaLabel.Size = new System.Drawing.Size(100, 25);
			this.lojaLabel.TabIndex = 9;
			this.lojaLabel.Text = "Loja";
			this.lojaLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// MenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(266, 315);
			this.Controls.Add(this.lojaLabel);
			this.Controls.Add(this.forjaLabel);
			this.Controls.Add(this.atributosLabel);
			this.Controls.Add(this.magiasLabel);
			this.Controls.Add(this.forjaButton);
			this.Controls.Add(this.lojaButton);
			this.Controls.Add(this.magiasButton);
			this.Controls.Add(this.atributosButton);
			this.Controls.Add(this.retomarButton);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MenuForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MenuForm";
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label lojaLabel;
		private System.Windows.Forms.Label forjaLabel;
		private System.Windows.Forms.Label atributosLabel;
		private System.Windows.Forms.Label magiasLabel;
		private System.Windows.Forms.Button forjaButton;
		private System.Windows.Forms.Button lojaButton;
		private System.Windows.Forms.Button atributosButton;
		private System.Windows.Forms.Button retomarButton;
		private System.Windows.Forms.Button magiasButton;
	}
}
