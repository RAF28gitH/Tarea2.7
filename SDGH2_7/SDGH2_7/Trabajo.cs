/*
 * Created by SharpDevelop.
 * User: CC2_PC16
 * Date: 22/10/2024
 * Time: 08:16 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SDGH2_7
{
	/// <summary>
	/// Description of Trabajo.
	/// </summary>
	public partial class Trabajo : Form
	{
		public Trabajo()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string cad1=((txtAP1.Text.Length)>=2? txtAP1.Text.Substring(0,2).ToUpper():aggX(2,txtAP1.Text).ToUpper());
			string cad2=((txtAP2.Text.Length)>=2? txtAP2.Text.Substring(0,1).ToUpper():aggX(1,txtAP2.Text).ToUpper());
			string cad3=((txtNOMBRE.Text.Length)>=2? txtNOMBRE.Text.Substring(0,1).ToUpper():aggX(1,txtNOMBRE.Text).ToUpper());
			DateTime fec=dateNAC.Value;
			string cad4=fec.Year.ToString().Substring(2,2)+compFec(fec.Month.ToString())+compFec(fec.Day.ToString());
			lblRFC.Text=cad1+cad2+cad3+cad4;
		}
		
		string aggX(int ter, string s)
		{
			for(int i=0; i<=ter-s.Length; i++){
				s+="X";
			}
			return s;
		}
		
		string compFec(string y)
		{
			if(y.Length==1){
				y="0"+y;
			}
			return y;
		}
	}
}
