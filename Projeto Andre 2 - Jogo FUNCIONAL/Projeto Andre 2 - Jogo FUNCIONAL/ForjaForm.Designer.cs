/*
 * Created by SharpDevelop.
 * User: UCL
 * Date: 05/12/2019
 * Time: 15:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	partial class ForjaForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button capaceteButton;
		private System.Windows.Forms.Button armaduraButton;
		private System.Windows.Forms.Button botaButton;
		private System.Windows.Forms.Button armaButton;
		private System.Windows.Forms.Label ferroLabel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button aprimorarButton;
		private System.Windows.Forms.Button luvasButton;
		private System.Windows.Forms.Label custoLabel;
		private System.Windows.Forms.Button statusButton;
		private System.Windows.Forms.Label level1Label;
		private System.Windows.Forms.Label level2Label;
		private System.Windows.Forms.Label level3Label;
		private System.Windows.Forms.Label level4Label;
		private System.Windows.Forms.Label level5Label;
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
			this.capaceteButton = new System.Windows.Forms.Button();
			this.armaduraButton = new System.Windows.Forms.Button();
			this.botaButton = new System.Windows.Forms.Button();
			this.armaButton = new System.Windows.Forms.Button();
			this.ferroLabel = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.aprimorarButton = new System.Windows.Forms.Button();
			this.luvasButton = new System.Windows.Forms.Button();
			this.statusButton = new System.Windows.Forms.Button();
			this.level1Label = new System.Windows.Forms.Label();
			this.level2Label = new System.Windows.Forms.Label();
			this.level3Label = new System.Windows.Forms.Label();
			this.level4Label = new System.Windows.Forms.Label();
			this.level5Label = new System.Windows.Forms.Label();
			this.sairButton = new System.Windows.Forms.Button();
			this.custoLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// capaceteButton
			// 
			this.capaceteButton.Location = new System.Drawing.Point(12, 12);
			this.capaceteButton.Name = "capaceteButton";
			this.capaceteButton.Size = new System.Drawing.Size(75, 75);
			this.capaceteButton.TabIndex = 0;
			this.capaceteButton.Text = "Helm";
			this.capaceteButton.UseVisualStyleBackColor = true;
			this.capaceteButton.Click += new System.EventHandler(this.CapaceteButtonClick);
			// 
			// armaduraButton
			// 
			this.armaduraButton.Location = new System.Drawing.Point(93, 12);
			this.armaduraButton.Name = "armaduraButton";
			this.armaduraButton.Size = new System.Drawing.Size(75, 75);
			this.armaduraButton.TabIndex = 1;
			this.armaduraButton.Text = "Armor";
			this.armaduraButton.UseVisualStyleBackColor = true;
			this.armaduraButton.Click += new System.EventHandler(this.ArmaduraButtonClick);
			// 
			// botaButton
			// 
			this.botaButton.Location = new System.Drawing.Point(336, 12);
			this.botaButton.Name = "botaButton";
			this.botaButton.Size = new System.Drawing.Size(75, 75);
			this.botaButton.TabIndex = 2;
			this.botaButton.Text = "Bots";
			this.botaButton.UseVisualStyleBackColor = true;
			this.botaButton.Click += new System.EventHandler(this.BotaButtonClick);
			// 
			// armaButton
			// 
			this.armaButton.Location = new System.Drawing.Point(174, 12);
			this.armaButton.Name = "armaButton";
			this.armaButton.Size = new System.Drawing.Size(75, 75);
			this.armaButton.TabIndex = 3;
			this.armaButton.Text = "Arma";
			this.armaButton.UseVisualStyleBackColor = true;
			// 
			// ferroLabel
			// 
			this.ferroLabel.Location = new System.Drawing.Point(12, 270);
			this.ferroLabel.Name = "ferroLabel";
			this.ferroLabel.Size = new System.Drawing.Size(50, 23);
			this.ferroLabel.TabIndex = 4;
			this.ferroLabel.Text = "Ferros: 0";
			this.ferroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(21, 296);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(29, 27);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// aprimorarButton
			// 
			this.aprimorarButton.Location = new System.Drawing.Point(336, 300);
			this.aprimorarButton.Name = "aprimorarButton";
			this.aprimorarButton.Size = new System.Drawing.Size(75, 23);
			this.aprimorarButton.TabIndex = 6;
			this.aprimorarButton.Text = "Aprimorar";
			this.aprimorarButton.UseVisualStyleBackColor = true;
			this.aprimorarButton.Click += new System.EventHandler(this.AprimorarButtonClick);
			// 
			// luvasButton
			// 
			this.luvasButton.Location = new System.Drawing.Point(255, 12);
			this.luvasButton.Name = "luvasButton";
			this.luvasButton.Size = new System.Drawing.Size(75, 75);
			this.luvasButton.TabIndex = 7;
			this.luvasButton.Text = "Luvas";
			this.luvasButton.UseVisualStyleBackColor = true;
			this.luvasButton.Click += new System.EventHandler(this.LuvasButtonClick);
			// 
			// statusButton
			// 
			this.statusButton.Location = new System.Drawing.Point(255, 300);
			this.statusButton.Name = "statusButton";
			this.statusButton.Size = new System.Drawing.Size(75, 23);
			this.statusButton.TabIndex = 13;
			this.statusButton.Text = "Status";
			this.statusButton.UseVisualStyleBackColor = true;
			this.statusButton.Click += new System.EventHandler(this.StatusButtonClick);
			// 
			// level1Label
			// 
			this.level1Label.Location = new System.Drawing.Point(12, 90);
			this.level1Label.Name = "level1Label";
			this.level1Label.Size = new System.Drawing.Size(75, 23);
			this.level1Label.TabIndex = 14;
			this.level1Label.Text = "Level: 1";
			this.level1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// level2Label
			// 
			this.level2Label.Location = new System.Drawing.Point(93, 90);
			this.level2Label.Name = "level2Label";
			this.level2Label.Size = new System.Drawing.Size(75, 23);
			this.level2Label.TabIndex = 15;
			this.level2Label.Text = "Level: 1";
			this.level2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// level3Label
			// 
			this.level3Label.Location = new System.Drawing.Point(174, 90);
			this.level3Label.Name = "level3Label";
			this.level3Label.Size = new System.Drawing.Size(75, 23);
			this.level3Label.TabIndex = 16;
			this.level3Label.Text = "Level: 1";
			this.level3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// level4Label
			// 
			this.level4Label.Location = new System.Drawing.Point(255, 90);
			this.level4Label.Name = "level4Label";
			this.level4Label.Size = new System.Drawing.Size(75, 23);
			this.level4Label.TabIndex = 17;
			this.level4Label.Text = "Level: 1";
			this.level4Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// level5Label
			// 
			this.level5Label.Location = new System.Drawing.Point(336, 90);
			this.level5Label.Name = "level5Label";
			this.level5Label.Size = new System.Drawing.Size(75, 23);
			this.level5Label.TabIndex = 18;
			this.level5Label.Text = "Level: 1";
			this.level5Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// sairButton
			// 
			this.sairButton.Location = new System.Drawing.Point(174, 300);
			this.sairButton.Name = "sairButton";
			this.sairButton.Size = new System.Drawing.Size(75, 23);
			this.sairButton.TabIndex = 19;
			this.sairButton.Text = "Sair";
			this.sairButton.UseVisualStyleBackColor = true;
			this.sairButton.Click += new System.EventHandler(this.SairButtonClick);
			// 
			// custoLabel
			// 
			this.custoLabel.Location = new System.Drawing.Point(174, 188);
			this.custoLabel.Name = "custoLabel";
			this.custoLabel.Size = new System.Drawing.Size(75, 23);
			this.custoLabel.TabIndex = 12;
			this.custoLabel.Text = "Custo: 1";
			this.custoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ForjaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(429, 335);
			this.Controls.Add(this.sairButton);
			this.Controls.Add(this.level5Label);
			this.Controls.Add(this.level4Label);
			this.Controls.Add(this.level3Label);
			this.Controls.Add(this.level2Label);
			this.Controls.Add(this.level1Label);
			this.Controls.Add(this.statusButton);
			this.Controls.Add(this.custoLabel);
			this.Controls.Add(this.luvasButton);
			this.Controls.Add(this.aprimorarButton);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.ferroLabel);
			this.Controls.Add(this.armaButton);
			this.Controls.Add(this.botaButton);
			this.Controls.Add(this.armaduraButton);
			this.Controls.Add(this.capaceteButton);
			this.Name = "ForjaForm";
			this.Text = "ForjaForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
