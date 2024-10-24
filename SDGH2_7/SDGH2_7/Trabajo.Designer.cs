/*
 * Created by SharpDevelop.
 * User: CC2_PC16
 * Date: 22/10/2024
 * Time: 08:16 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SDGH2_7
{
	partial class Trabajo
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblTITULO;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNOMBRE;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox txtAP1;
		private System.Windows.Forms.TextBox txtAP2;
		private System.Windows.Forms.TextBox txtTEL;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDIR;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button button1;
		
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
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNOMBRE = new System.Windows.Forms.TextBox();
			this.txtAP1 = new System.Windows.Forms.TextBox();
			this.txtAP2 = new System.Windows.Forms.TextBox();
			this.txtTEL = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDIR = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTITULO
			// 
			this.lblTITULO.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTITULO.Location = new System.Drawing.Point(25, 28);
			this.lblTITULO.Name = "lblTITULO";
			this.lblTITULO.Size = new System.Drawing.Size(431, 47);
			this.lblTITULO.TabIndex = 0;
			this.lblTITULO.Text = "Datos para calcular el RFC";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(35, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nombre";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(226, 96);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Apellido 1";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(417, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Apellido 2";
			// 
			// txtNOMBRE
			// 
			this.txtNOMBRE.Location = new System.Drawing.Point(35, 122);
			this.txtNOMBRE.Name = "txtNOMBRE";
			this.txtNOMBRE.Size = new System.Drawing.Size(171, 22);
			this.txtNOMBRE.TabIndex = 4;
			// 
			// txtAP1
			// 
			this.txtAP1.Location = new System.Drawing.Point(226, 122);
			this.txtAP1.Name = "txtAP1";
			this.txtAP1.Size = new System.Drawing.Size(171, 22);
			this.txtAP1.TabIndex = 5;
			// 
			// txtAP2
			// 
			this.txtAP2.Location = new System.Drawing.Point(417, 122);
			this.txtAP2.Name = "txtAP2";
			this.txtAP2.Size = new System.Drawing.Size(171, 22);
			this.txtAP2.TabIndex = 6;
			// 
			// txtTEL
			// 
			this.txtTEL.Location = new System.Drawing.Point(35, 201);
			this.txtTEL.Name = "txtTEL";
			this.txtTEL.Size = new System.Drawing.Size(171, 22);
			this.txtTEL.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(35, 175);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Teléfono";
			// 
			// txtDIR
			// 
			this.txtDIR.Location = new System.Drawing.Point(226, 201);
			this.txtDIR.Name = "txtDIR";
			this.txtDIR.Size = new System.Drawing.Size(171, 22);
			this.txtDIR.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(226, 175);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "Dirección";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(417, 175);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "Semestre";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"Primero",
			"Segundo",
			"Tercero",
			"Cuarto",
			"Quinto",
			"Sexto"});
			this.comboBox1.Location = new System.Drawing.Point(417, 201);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(171, 24);
			this.comboBox1.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(140, 249);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(171, 23);
			this.label7.TabIndex = 13;
			this.label7.Text = "Fecha de nacimiento";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(140, 275);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
			this.dateTimePicker1.TabIndex = 14;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(417, 272);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(144, 32);
			this.button1.TabIndex = 15;
			this.button1.Text = "Calcular RFC";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// Trabajo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(896, 530);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtDIR);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtTEL);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtAP2);
			this.Controls.Add(this.txtAP1);
			this.Controls.Add(this.txtNOMBRE);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblTITULO);
			this.Name = "Trabajo";
			this.Text = "Trabajo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
