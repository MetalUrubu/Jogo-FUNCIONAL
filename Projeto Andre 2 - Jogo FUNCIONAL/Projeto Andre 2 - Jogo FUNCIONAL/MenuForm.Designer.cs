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
			this.magiaButtons = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.forjaButton = new System.Windows.Forms.Button();
			this.magiasLabel = new System.Windows.Forms.Label();
			this.atributosLabel = new System.Windows.Forms.Label();
			this.forjaLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// retomarButton
			// 
			this.retomarButton.Location = new System.Drawing.Point(244, 323);
			this.retomarButton.Name = "retomarButton";
			this.retomarButton.Size = new System.Drawing.Size(206, 31);
			this.retomarButton.TabIndex = 0;
			this.retomarButton.Text = "Retornar";
			this.retomarButton.UseVisualStyleBackColor = true;
			// 
			// atributosButton
			// 
			this.atributosButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("atributosButton.BackgroundImage")));
			this.atributosButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.atributosButton.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.atributosButton.ForeColor = System.Drawing.Color.Blue;
			this.atributosButton.Location = new System.Drawing.Point(30, 33);
			this.atributosButton.Name = "atributosButton";
			this.atributosButton.Size = new System.Drawing.Size(187, 117);
			this.atributosButton.TabIndex = 1;
			this.atributosButton.UseVisualStyleBackColor = true;
			this.atributosButton.Click += new System.EventHandler(this.AtributosButtonClick);
			// 
			// magiaButtons
			// 
			this.magiaButtons.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("magiaButtons.BackgroundImage")));
			this.magiaButtons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.magiaButtons.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.magiaButtons.ForeColor = System.Drawing.Color.Blue;
			this.magiaButtons.Location = new System.Drawing.Point(258, 178);
			this.magiaButtons.Name = "magiaButtons";
			this.magiaButtons.Size = new System.Drawing.Size(192, 117);
			this.magiaButtons.TabIndex = 2;
			this.magiaButtons.UseVisualStyleBackColor = true;
			this.magiaButtons.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
			this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button4.Location = new System.Drawing.Point(30, 178);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(187, 117);
			this.button4.TabIndex = 3;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(30, 323);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(187, 31);
			this.button5.TabIndex = 4;
			this.button5.Text = "Sair";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// forjaButton
			// 
			this.forjaButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("forjaButton.BackgroundImage")));
			this.forjaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.forjaButton.Location = new System.Drawing.Point(258, 33);
			this.forjaButton.Name = "forjaButton";
			this.forjaButton.Size = new System.Drawing.Size(192, 117);
			this.forjaButton.TabIndex = 5;
			this.forjaButton.UseVisualStyleBackColor = true;
			// 
			// magiasLabel
			// 
			this.magiasLabel.Location = new System.Drawing.Point(305, 153);
			this.magiasLabel.Name = "magiasLabel";
			this.magiasLabel.Size = new System.Drawing.Size(102, 22);
			this.magiasLabel.TabIndex = 6;
			this.magiasLabel.Text = "Magias";
			this.magiasLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// atributosLabel
			// 
			this.atributosLabel.Location = new System.Drawing.Point(58, -1);
			this.atributosLabel.Name = "atributosLabel";
			this.atributosLabel.Size = new System.Drawing.Size(130, 31);
			this.atributosLabel.TabIndex = 7;
			this.atributosLabel.Text = "Atributos";
			this.atributosLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// forjaLabel
			// 
			this.forjaLabel.Location = new System.Drawing.Point(292, -1);
			this.forjaLabel.Name = "forjaLabel";
			this.forjaLabel.Size = new System.Drawing.Size(130, 31);
			this.forjaLabel.TabIndex = 8;
			this.forjaLabel.Text = "Forja";
			this.forjaLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.forjaLabel.Click += new System.EventHandler(this.ForjaLabelClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(58, 153);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 22);
			this.label1.TabIndex = 9;
			this.label1.Text = "Loja";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// MenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(469, 366);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.forjaLabel);
			this.Controls.Add(this.atributosLabel);
			this.Controls.Add(this.magiasLabel);
			this.Controls.Add(this.forjaButton);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.magiaButtons);
			this.Controls.Add(this.atributosButton);
			this.Controls.Add(this.retomarButton);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Name = "MenuForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MenuForm";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label forjaLabel;
		private System.Windows.Forms.Label atributosLabel;
		private System.Windows.Forms.Label magiasLabel;
		private System.Windows.Forms.Button forjaButton;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button magiaButtons;
		private System.Windows.Forms.Button atributosButton;
		private System.Windows.Forms.Button retomarButton;
	}
}
