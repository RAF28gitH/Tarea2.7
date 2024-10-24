/*
 * Created by SharpDevelop.
 * User: CC2_PC16
 * Date: 22/10/2024
 * Time: 07:44 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SDGH2_7
{
	partial class MainForm
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
			this.lblTITULO = new System.Windows.Forms.Label();
			this.btnINICIAR = new System.Windows.Forms.Button();
			this.lsbDATOS = new System.Windows.Forms.ListBox();
			this.lblDATOS = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTITULO
			// 
			this.lblTITULO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTITULO.Location = new System.Drawing.Point(92, 32);
			this.lblTITULO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTITULO.Name = "lblTITULO";
			this.lblTITULO.Size = new System.Drawing.Size(593, 44);
			this.lblTITULO.TabIndex = 0;
			this.lblTITULO.Text = "Tarea 2.7: Proyecto de csharp en git";
			// 
			// btnINICIAR
			// 
			this.btnINICIAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnINICIAR.Location = new System.Drawing.Point(291, 262);
			this.btnINICIAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnINICIAR.Name = "btnINICIAR";
			this.btnINICIAR.Size = new System.Drawing.Size(137, 39);
			this.btnINICIAR.TabIndex = 1;
			this.btnINICIAR.Text = "INICIAR";
			this.btnINICIAR.UseVisualStyleBackColor = true;
			this.btnINICIAR.Click += new System.EventHandler(this.BtnINICIARClick);
			// 
			// lsbDATOS
			// 
			this.lsbDATOS.FormattingEnabled = true;
			this.lsbDATOS.ItemHeight = 16;
			this.lsbDATOS.Items.AddRange(new object[] {
			"Nombre",
			"No. Lista",
			"Materia",
			"Maestro",
			"Fecha",
			"Semestre y Especialidad"});
			this.lsbDATOS.Location = new System.Drawing.Point(16, 135);
			this.lsbDATOS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.lsbDATOS.Name = "lsbDATOS";
			this.lsbDATOS.Size = new System.Drawing.Size(189, 100);
			this.lsbDATOS.TabIndex = 2;
			this.lsbDATOS.SelectedIndexChanged += new System.EventHandler(this.LsbDATOSSelectedIndexChanged);
			// 
			// lblDATOS
			// 
			this.lblDATOS.Location = new System.Drawing.Point(233, 156);
			this.lblDATOS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDATOS.Name = "lblDATOS";
			this.lblDATOS.Size = new System.Drawing.Size(295, 81);
			this.lblDATOS.TabIndex = 3;
			this.lblDATOS.Text = "Selecciona un dato de la lista a la izquierda";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(737, 377);
			this.Controls.Add(this.lblDATOS);
			this.Controls.Add(this.lsbDATOS);
			this.Controls.Add(this.btnINICIAR);
			this.Controls.Add(this.lblTITULO);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "MainForm";
			this.Text = "SDGH2_7";
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label lblDATOS;
		private System.Windows.Forms.ListBox lsbDATOS;
		private System.Windows.Forms.Button btnINICIAR;
		private System.Windows.Forms.Label lblTITULO;
	}
}
