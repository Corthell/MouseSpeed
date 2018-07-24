
namespace MouseSpeed
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btRun = new System.Windows.Forms.Button();
            this.etLicznik = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.etStoper = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btStart = new System.Windows.Forms.Button();
            this.btRekord = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.etNazwa = new System.Windows.Forms.Label();
            this.etZnakR = new System.Windows.Forms.Label();
            this.btZapisz = new System.Windows.Forms.Button();
            this.textNick = new System.Windows.Forms.TextBox();
            this.etNick = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btRun
            // 
            this.btRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btRun.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btRun.Location = new System.Drawing.Point(1193, 868);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(12, 12);
            this.btRun.TabIndex = 0;
            this.btRun.UseVisualStyleBackColor = false;
            this.btRun.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btRun_MouseClick);
            // 
            // etLicznik
            // 
            this.etLicznik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.etLicznik.AutoSize = true;
            this.etLicznik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.etLicznik.ForeColor = System.Drawing.Color.Gold;
            this.etLicznik.Location = new System.Drawing.Point(1206, 7);
            this.etLicznik.Name = "etLicznik";
            this.etLicznik.Size = new System.Drawing.Size(46, 31);
            this.etLicznik.TabIndex = 1;
            this.etLicznik.Text = "30";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // etStoper
            // 
            this.etStoper.AutoSize = true;
            this.etStoper.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.etStoper.ForeColor = System.Drawing.Color.Black;
            this.etStoper.Location = new System.Drawing.Point(13, 10);
            this.etStoper.Name = "etStoper";
            this.etStoper.Size = new System.Drawing.Size(27, 29);
            this.etStoper.TabIndex = 2;
            this.etStoper.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.btRun);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1240, 910);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1228, 891);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btStart.ForeColor = System.Drawing.Color.Red;
            this.btStart.Location = new System.Drawing.Point(97, 7);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(76, 33);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btRekord
            // 
            this.btRekord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btRekord.ForeColor = System.Drawing.Color.ForestGreen;
            this.btRekord.Location = new System.Drawing.Point(561, 8);
            this.btRekord.Name = "btRekord";
            this.btRekord.Size = new System.Drawing.Size(84, 32);
            this.btRekord.TabIndex = 6;
            this.btRekord.Text = "Rekordy";
            this.btRekord.UseVisualStyleBackColor = true;
            this.btRekord.Click += new System.EventHandler(this.btRekord_Click);
            // 
            // btStop
            // 
            this.btStop.Enabled = false;
            this.btStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btStop.ForeColor = System.Drawing.Color.Black;
            this.btStop.Location = new System.Drawing.Point(196, 11);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(70, 25);
            this.btStop.TabIndex = 7;
            this.btStop.Text = "Reset";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // etNazwa
            // 
            this.etNazwa.AutoSize = true;
            this.etNazwa.BackColor = System.Drawing.Color.Transparent;
            this.etNazwa.Font = new System.Drawing.Font("Segoe Print", 45.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.etNazwa.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.etNazwa.Location = new System.Drawing.Point(696, -35);
            this.etNazwa.Name = "etNazwa";
            this.etNazwa.Size = new System.Drawing.Size(446, 106);
            this.etNazwa.TabIndex = 8;
            this.etNazwa.Text = "MouseSPEED";
            // 
            // etZnakR
            // 
            this.etZnakR.AutoSize = true;
            this.etZnakR.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.etZnakR.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.etZnakR.Location = new System.Drawing.Point(1114, 4);
            this.etZnakR.Name = "etZnakR";
            this.etZnakR.Size = new System.Drawing.Size(51, 52);
            this.etZnakR.TabIndex = 9;
            this.etZnakR.Text = "®";
            // 
            // btZapisz
            // 
            this.btZapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btZapisz.ForeColor = System.Drawing.Color.Black;
            this.btZapisz.Location = new System.Drawing.Point(272, 11);
            this.btZapisz.Name = "btZapisz";
            this.btZapisz.Size = new System.Drawing.Size(70, 25);
            this.btZapisz.TabIndex = 10;
            this.btZapisz.Text = "Zapisz";
            this.btZapisz.UseVisualStyleBackColor = true;
            this.btZapisz.Click += new System.EventHandler(this.btZapiszClick);
            // 
            // textNick
            // 
            this.textNick.Location = new System.Drawing.Point(348, 13);
            this.textNick.Name = "textNick";
            this.textNick.Size = new System.Drawing.Size(100, 20);
            this.textNick.TabIndex = 11;
            // 
            // etNick
            // 
            this.etNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.etNick.ForeColor = System.Drawing.Color.Gold;
            this.etNick.Location = new System.Drawing.Point(451, 15);
            this.etNick.Name = "etNick";
            this.etNick.Size = new System.Drawing.Size(74, 19);
            this.etNick.TabIndex = 12;
            this.etNick.Text = "Twój nick";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(651, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 962);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.etNick);
            this.Controls.Add(this.textNick);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btZapisz);
            this.Controls.Add(this.btRekord);
            this.Controls.Add(this.etStoper);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.etLicznik);
            this.Controls.Add(this.etZnakR);
            this.Controls.Add(this.etNazwa);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MouseSPEED 1.0 BETA  ©2014 Michał Dudek";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
		private System.Windows.Forms.Label etNick;
		private System.Windows.Forms.TextBox textNick;
		private System.Windows.Forms.Button btZapisz;

        

        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.Label etLicznik;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label etStoper;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btRekord;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Label etNazwa;
        private System.Windows.Forms.Label etZnakR;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
	}
}
