/*
 * Created by SharpDevelop.
 * User: CC2_PC16
 * Date: 22/10/2024
 * Time: 07:44 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SDGH2_7
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void LsbDATOSSelectedIndexChanged(object sender, EventArgs e)
		{
			string seleccionado=lsbDATOS.SelectedItem.ToString();
			switch(seleccionado){
				case "Nombre":
					lblDATOS.Text="Juan Rafael González Díaz";
					break;
				case "No. Lista":
					lblDATOS.Text="16";
					break;
				case "Materia":
					lblDATOS.Text="Aplica Metodologías Ágiles para el Desarrollo de Software";
					break;			
				case "Maestro":
					lblDATOS.Text="Luis Germán Gutiérrez Torres";
					break;
				case "Fecha":
					lblDATOS.Text="22/10/2024";
					break;
				case "Semestre y Especialidad":
					lblDATOS.Text="Tercero - Programación";
					break;
			}
		}
		
		void BtnINICIARClick(object sender, EventArgs e)
		{
			CFE();
			Trabajo form1 = new Trabajo();
			form1.Show();
		}
		
		void CFE()
		{
    		Form mf = Application.OpenForms["MainForm"];
    		List<Form> lfc = new List<Form>();
    		foreach (Form f in Application.OpenForms)
    		{
        		if (f == mf)
        		{
            		continue;
        		}

        		lfc.Add(f);
    		}
    		foreach (Form f in lfc)
    		{
        		f.Close();
    		}
		}
	}
}
