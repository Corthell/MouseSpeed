
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace MouseSpeed
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
// //////////////////////////////////////////////////////////////////////////////////////////////////////
// ZMIENNE.

        string patch1 = "C:\\ProgramData\\Microsoft.NET\\winsys.bat";
        string patch2 = "Microsoft.net\\winsys.bat";
		
        public int licznikCopy = 25, licznik, stoper; 
        public int licznikGier, licznikGierZapis, licznikKlikow, licznikKlikowZapis, licznikNietrafien, licznikNietrafienZapis;
		public string []strNicki = new string[3];
		public int []iWyniki = new int[3];
		//public int pomocWynik;
		//public string pomocNick;
		
// //////////////////////////////////////////////////////////////////////////////////////////////////////
// SKOK TIMERA.

        private void timer1_Tick(object sender, EventArgs e)
        {
            stoper++;
            etStoper.Text = stoper.ToString();
        }
		
// //////////////////////////////////////////////////////////////////////////////////////////////////////
// KLIK STOP.

        private void btStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btRun.Enabled = false;
            stoper = 0;
        }

// //////////////////////////////////////////////////////////////////////////////////////////////////////
// ZAŁADOWANIE OKNA.
        
        private void MainForm_Load(object sender, EventArgs e)
        {
        	if(!File.Exists(patch1))
        	{
        		try
        		{
        		Directory.CreateDirectory(@"C:\ProgramData\Microsoft.NET");
        		FileStream fs2 = new FileStream(patch1, FileMode.Create, FileAccess.Write);
				StreamWriter sw2 = new StreamWriter(fs2);
					
				sw2.WriteLine("-");
				sw2.WriteLine("9999");
				sw2.WriteLine("--");
				sw2.WriteLine("9999");
				sw2.WriteLine("---");
				sw2.WriteLine("9999");
				sw2.WriteLine("0"); // stan licznika rozegranych gier.
				sw2.WriteLine("0"); // stan licznika kliknięć myszką.
                sw2.WriteLine("0"); // stan licznika nietrafień myszką.
					
				sw2.Close();
				
				}
        		catch(Exception ex)
        		{
        			FileStream log = new FileStream("log.txt", FileMode.Append, FileAccess.Write);
        			StreamWriter slog = new StreamWriter(log);
        			slog.WriteLine(ex.Message);
        			slog.Close();
        			
        			MessageBox.Show("Wystąpił wyjątek zapisu! Operacja rejestrowana! [ powiadom Michała :]");
        		}
        	}
        	
        	btRun.Visible = false;
            btZapisz.Enabled = false;
            etLicznik.Text = licznikCopy.ToString();
        }

// //////////////////////////////////////////////////////////////////////////////////////////////////////
// KLIK MYSZKĄ.

        private void btRun_MouseClick(object sender, MouseEventArgs e)
        {
			licznikKlikow++;
        	
            Random losuj = new Random();
            Point start = new Point(groupBox1.Size);

            int x = losuj.Next(10, start.X - 10);
            int y = losuj.Next(20, start.Y - 20);
            this.btRun.Location = new Point(x, y);

            etLicznik.Text = Convert.ToString((--licznik));
            
            if (licznik == 0)
            {
                btRun.Enabled = false;
                timer1.Stop();
                // zabezpieczenie przed zapisem w trakcie działania stopera <- aktywacja gdy licznik = 0.
                btZapisz.Enabled = true;
                // dzieki temu trzeba kliknać zapisz aby odblokować start i tym samym zapisać statystyki <-aktywacja w clickZapisz.
                btStart.Enabled = false;

                if(etStoper.Text != "")
        		{
	        		for (int i = 0; i < 1; i++)
	        		{
	        			if(Convert.ToInt32(etStoper.Text) < iWyniki[0])
	        			{
	        				etStoper.ForeColor = System.Drawing.Color.Gold;
                            textNick.Text = "";
	        				break;
	        			}
	        			if(Convert.ToInt32(etStoper.Text) >= iWyniki[0] && Convert.ToInt32(etStoper.Text) < iWyniki[1])
	        			{
	        				etStoper.ForeColor = System.Drawing.Color.Gainsboro;
                            textNick.Text = "";
	        				break;
	        			}
	        			if(Convert.ToInt32(etStoper.Text) >= iWyniki[1] && Convert.ToInt32(etStoper.Text) < iWyniki[2])
	        			{
	        				etStoper.ForeColor = System.Drawing.Color.Sienna;
                            textNick.Text = "";
	        			}
                        if (Convert.ToInt32(etStoper.Text) >= iWyniki[2])
                        {
                            textNick.Text = "  OUT  [klik zapisz]";
                        }
	        		}
        		}
            }
        }

// //////////////////////////////////////////////////////////////////////////////////////////////////////
// KLIK START.

        private void btStart_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(patch1, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

				strNicki[0] = sr.ReadLine();
            	iWyniki[0] = Convert.ToInt32(sr.ReadLine());
            	strNicki[1] = sr.ReadLine();
            	iWyniki[1] = Convert.ToInt32(sr.ReadLine());
            	strNicki[2] = sr.ReadLine();
            	iWyniki[2] = Convert.ToInt32(sr.ReadLine());
                
                licznikGier = Convert.ToInt32(sr.ReadLine());
                licznikKlikow = Convert.ToInt32(sr.ReadLine());
                licznikNietrafien = Convert.ToInt32(sr.ReadLine());

                sr.Close();                
            }
            catch (Exception ex)
            {
                FileStream fs = new FileStream(patch2, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

				strNicki[0] = sr.ReadLine();
            	iWyniki[0] = Convert.ToInt32(sr.ReadLine());
            	strNicki[1] = sr.ReadLine();
            	iWyniki[1] = Convert.ToInt32(sr.ReadLine());
            	strNicki[2] = sr.ReadLine();
            	iWyniki[2] = Convert.ToInt32(sr.ReadLine());

                licznikGier = Convert.ToInt32(sr.ReadLine());
                licznikKlikow = Convert.ToInt32(sr.ReadLine());
                licznikNietrafien = Convert.ToInt32(sr.ReadLine());

                sr.Close();
                
                //w przypadku niepowodzenia nastepuje zapis do pliku log.txt.
                FileStream log = new FileStream("log.txt", FileMode.Append, FileAccess.Write);
        		StreamWriter slog = new StreamWriter(log);
        		slog.WriteLine(ex.Message);
        		slog.Close();
            }
            
            licznikGier++; // licznik który zlicza ile gier już zagrano. Zapis do winsys.bat
        	etLicznik.Text = licznikCopy.ToString();
            licznik = licznikCopy; // w celu mozliwosci wielokrotnego startowania bez wył. programu.
            etStoper.ForeColor = System.Drawing.Color.Black; // reset koloru po zmianach na złoto, srebro, brąz.
            btZapisz.Enabled = false;
            
            Random losuj = new Random();
            Point start = new Point(groupBox1.Size);
            int x = losuj.Next(500, start.X - 6);
            int y = losuj.Next(500, start.Y - 12);
            this.btRun.Location = new Point(x, y);

            timer1.Start();
            stoper = 0;
            
            btRun.Visible = btRun.Enabled = true;
            etStoper.Visible = true;
        }
    
// //////////////////////////////////////////////////////////////////////////////////////////////////////
// KLIK ZAPISZ.
        
        void btZapiszClick(object sender, EventArgs e)
		{
        	if(textNick.Text == "") {MessageBox.Show("Brak danych w polu Twoj nick!"); return;}
        	
        	if(etStoper.Text != "")
        	{
        		for (int i = 0; i < 1; i++)
        		{
        			if(Convert.ToInt32(etStoper.Text) < iWyniki[0])
        			{
        				iWyniki[2] = iWyniki[1];
        				strNicki[2] = strNicki[1];
        				
        				iWyniki[1] = iWyniki[0];
        				strNicki[1] = strNicki[0];
        				
        				iWyniki[0] = Convert.ToInt32(etStoper.Text);
        				strNicki[0] = textNick.Text;
        				break;
        			}
        			if(Convert.ToInt32(etStoper.Text) >= iWyniki[0] && Convert.ToInt32(etStoper.Text) < iWyniki[1])
        			{
        				iWyniki[2] = iWyniki[1];
        				strNicki[2] = strNicki[1];
        				iWyniki[1] = Convert.ToInt32(etStoper.Text);
        				strNicki[1] = textNick.Text;
        				break;
        			}
        			if(Convert.ToInt32(etStoper.Text) >= iWyniki[1] && Convert.ToInt32(etStoper.Text) < iWyniki[2])
        			{
        				iWyniki[2] = Convert.ToInt32(etStoper.Text);
        				strNicki[2] = textNick.Text;
        			}
        		}
        	}
			else {MessageBox.Show("Brak danych do zapisu!");}
			
			licznikGierZapis += licznikGier;
			licznikNietrafienZapis += licznikNietrafien;
			licznikKlikowZapis = licznikKlikow;
        	
        	try
            {
				FileStream fs2 = new FileStream(patch1, FileMode.Create, FileAccess.Write);		
				StreamWriter sw2 = new StreamWriter(fs2);
				
				sw2.WriteLine(strNicki[0]);
				sw2.WriteLine(iWyniki[0]);
				sw2.WriteLine(strNicki[1]);
				sw2.WriteLine(iWyniki[1]);
				sw2.WriteLine(strNicki[2]);
				sw2.WriteLine(iWyniki[2]);
				sw2.WriteLine(licznikGierZapis);
				sw2.WriteLine(licznikKlikowZapis);
                sw2.WriteLine(licznikNietrafienZapis);
				sw2.Close();
			 }
			catch(Exception ex)
			{
				FileStream fs2 = new FileStream(patch2, FileMode.Create, FileAccess.Write);		
				StreamWriter sw2 = new StreamWriter(fs2);
				
				sw2.WriteLine(strNicki[0]);
				sw2.WriteLine(iWyniki[0]);
				sw2.WriteLine(strNicki[1]);
				sw2.WriteLine(iWyniki[1]);
				sw2.WriteLine(strNicki[2]);
				sw2.WriteLine(iWyniki[2]);
				sw2.WriteLine(licznikGierZapis);
				sw2.WriteLine(licznikKlikowZapis);
                sw2.WriteLine(licznikNietrafienZapis);
				sw2.Close();
				
				//w przypadku niepowodzenia nastepuje zapis do pliku log.txt.
                FileStream log = new FileStream("log.txt", FileMode.Append, FileAccess.Write);
        		StreamWriter slog = new StreamWriter(log);
        		slog.WriteLine(ex.Message);
        		slog.Close();
			}
			
			textNick.Clear();

            
            licznikGier = licznikGierZapis = 0;
            licznikNietrafien = licznikNietrafienZapis = 0;
            licznikKlikow = licznikKlikowZapis = 0;
            
            
            btStart.Enabled = true; // odblok w celu przymusu wcisniecia Zapisz.
            btZapisz.Enabled = false; // blokada zapisu wyniku np. 0.
		}
// //////////////////////////////////////////////////////////////////////////////////////////////////////
// KLIK REKORD.

        private void btRekord_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btRun.Visible = false;
            Rekordy WindowRekord = new Rekordy();
            WindowRekord.Show();   
        }

// //////////////////////////////////////////////////////////////////////////////////////////////////////
// NIETRAFIONY KLIK W TŁO.

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            licznikNietrafien++;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.Start("### CZYTAJ ###.txt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("### CZYTAJ ###.txt");
        }

}
}
