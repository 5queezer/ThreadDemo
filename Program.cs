using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ThreadDemo
{
	static class Program
	{
		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		//[STAThread]
        [MTAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );
			Application.Run( new Form1() );
		}
	}
}
