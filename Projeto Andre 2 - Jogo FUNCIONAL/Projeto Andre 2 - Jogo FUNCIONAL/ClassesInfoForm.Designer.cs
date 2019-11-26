
namespace Projeto_Andre_2___Jogo_FUNCIONAL
{
	partial class ClassesInfoForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mago:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(71, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(201, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "texto";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ClassesInfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "ClassesInfoForm";
			this.Text = "ClassesInfoForm";
			this.ResumeLayout(false);

		}
	}
}
