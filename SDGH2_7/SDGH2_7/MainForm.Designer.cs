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
			this.lblTITULO.Location = new System.Drawing.Point(69, 26);
			this.lblTITULO.Name = "lblTITULO";
			this.lblTITULO.Size = new System.Drawing.Size(445, 36);
			this.lblTITULO.TabIndex = 0;
			this.lblTITULO.Text = "Tarea 2.7: Proyecto de csharp en git";
			// 
			// btnINICIAR
			// 
			this.btnINICIAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnINICIAR.Location = new System.Drawing.Point(218, 213);
			this.btnINICIAR.Name = "btnINICIAR";
			this.btnINICIAR.Size = new System.Drawing.Size(103, 32);
			this.btnINICIAR.TabIndex = 1;
			this.btnINICIAR.Text = "INICIAR";
			this.btnINICIAR.UseVisualStyleBackColor = true;
			this.btnINICIAR.Click += new System.EventHandler(this.BtnINICIARClick);
			// 
			// lsbDATOS
			// 
			this.lsbDATOS.FormattingEnabled = true;
			this.lsbDATOS.Items.AddRange(new object[] {
									"Nombre",
									"No. Lista",
									"Materia",
									"Maestro",
									"Fecha",
									"Semestre y Especialidad"});
			this.lsbDATOS.Location = new System.Drawing.Point(12, 110);
			this.lsbDATOS.Name = "lsbDATOS";
			this.lsbDATOS.Size = new System.Drawing.Size(143, 82);
			this.lsbDATOS.TabIndex = 2;
			this.lsbDATOS.SelectedIndexChanged += new System.EventHandler(this.LsbDATOSSelectedIndexChanged);
			// 
			// lblDATOS
			// 
			this.lblDATOS.Location = new System.Drawing.Point(175, 127);
			this.lblDATOS.Name = "lblDATOS";
			this.lblDATOS.Size = new System.Drawing.Size(221, 66);
			this.lblDATOS.TabIndex = 3;
			this.lblDATOS.Text = "Selecciona un dato de la lista a la izquierda";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(553, 306);
			this.Controls.Add(this.lblDATOS);
			this.Controls.Add(this.lsbDATOS);
			this.Controls.Add(this.btnINICIAR);
			this.Controls.Add(this.lblTITULO);
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
