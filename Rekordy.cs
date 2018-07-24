
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace MouseSpeed
{
	/// <summary>
	/// Description of Rekordy.
	/// </summary>
	public partial class Rekordy : Form
	{
        string patch1 = "C:\\ProgramData\\Microsoft.NET\\winsys.bat";
        string patch2 = "Microsoft.net\\winsys.bat";

		public Rekordy()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void RekordyLoad(object sender, EventArgs e)
		{
			try
            {
				FileStream fs = new FileStream(patch1, FileMode.Open, FileAccess.Read);
						
				StreamReader sr = new StreamReader(fs);

				etNick1.Text = sr.ReadLine();
				etWynikMiejsce1.Text = sr.ReadLine();
				etNick2.Text = sr.ReadLine();
				etWynikMiejsce2.Text = sr.ReadLine();
				etNick3.Text = sr.ReadLine();
				etWynikMiejsce3.Text = sr.ReadLine();
                etLicznikPartii.Text = sr.ReadLine();
				etLicznikKlikMyszka.Text = sr.ReadLine();
                etLicznikNietrafienia.Text = sr.ReadLine();
				sr.Close();
			
			 }
			catch(Exception ex)
			{
				FileStream fs = new FileStream(patch2, FileMode.Open, FileAccess.Read);
						
				StreamReader sr = new StreamReader(fs);

				etNick1.Text = sr.ReadLine();
				etWynikMiejsce1.Text = sr.ReadLine();
				etNick2.Text = sr.ReadLine();
				etWynikMiejsce2.Text = sr.ReadLine();
				etNick3.Text = sr.ReadLine();
				etWynikMiejsce3.Text = sr.ReadLine();
				etLicznikPartii.Text = sr.ReadLine();
				etLicznikKlikMyszka.Text = sr.ReadLine();
				sr.Close();
				
				//w przypadku niepowodzenia nastepuje zapis do pliku log.txt.
                FileStream log = new FileStream("log.txt", FileMode.Append, FileAccess.Write);
        		StreamWriter slog = new StreamWriter(log);
        		slog.WriteLine(ex.Message);
        		slog.Close();
			}
		}
	}
}
