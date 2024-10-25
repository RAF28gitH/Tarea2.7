/*
 * Created by SharpDevelop.
 * User: 52445
 * Date: 24/10/2024
 * Time: 07:37 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SDGH2_7
{
	/// <summary>
	/// Description of resu.
	/// </summary>
	public partial class resu : Form
	{
		public resu(string c1,string c2)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			label3.Text=c1;
			label4.Text=c2;
		}
	}
}
