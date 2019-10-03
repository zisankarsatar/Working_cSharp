namespace cSharp_Tarayıcı
{
    partial class cSharp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cSharp));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnJoy = new System.Windows.Forms.Button();
            this.btnNumber = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnKral = new System.Windows.Forms.Button();
            this.btnTwit = new System.Windows.Forms.Button();
            this.btnFace = new System.Windows.Forms.Button();
            this.btnIns = new System.Windows.Forms.Button();
            this.btnLink = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gazetelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onedioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.milliyetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fanatikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeşilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBaslik = new System.Windows.Forms.Button();
            this.btnKaynak = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatuslblDurum = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnGecmis = new System.Windows.Forms.Button();
            this.lstGecmis = new System.Windows.Forms.ListBox();
            this.btnGecmisSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.Location = new System.Drawing.Point(161, 159);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(262, 51);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(12, 47);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(265, 62);
            this.axWindowsMediaPlayer.TabIndex = 16;
            // 
            // btnJoy
            // 
            this.btnJoy.BackgroundImage = global::cSharp_Tarayıcı.Properties.Resources.joyTurk;
            this.btnJoy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJoy.Location = new System.Drawing.Point(384, 68);
            this.btnJoy.Name = "btnJoy";
            this.btnJoy.Size = new System.Drawing.Size(63, 62);
            this.btnJoy.TabIndex = 19;
            this.btnJoy.UseVisualStyleBackColor = true;
            this.btnJoy.Click += new System.EventHandler(this.btnJoy_Click);
            // 
            // btnNumber
            // 
            this.btnNumber.BackgroundImage = global::cSharp_Tarayıcı.Properties.Resources.Number_One_FM;
            this.btnNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNumber.Location = new System.Drawing.Point(462, 68);
            this.btnNumber.Name = "btnNumber";
            this.btnNumber.Size = new System.Drawing.Size(63, 62);
            this.btnNumber.TabIndex = 18;
            this.btnNumber.UseVisualStyleBackColor = true;
            this.btnNumber.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnPower
            // 
            this.btnPower.BackgroundImage = global::cSharp_Tarayıcı.Properties.Resources.powerFm;
            this.btnPower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPower.Location = new System.Drawing.Point(543, 68);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(63, 62);
            this.btnPower.TabIndex = 17;
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // btnKral
            // 
            this.btnKral.BackgroundImage = global::cSharp_Tarayıcı.Properties.Resources.kral;
            this.btnKral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKral.Location = new System.Drawing.Point(625, 68);
            this.btnKral.Name = "btnKral";
            this.btnKral.Size = new System.Drawing.Size(63, 62);
            this.btnKral.TabIndex = 14;
            this.btnKral.UseVisualStyleBackColor = true;
            this.btnKral.Click += new System.EventHandler(this.btnKral_Click);
            // 
            // btnTwit
            // 
            this.btnTwit.BackgroundImage = global::cSharp_Tarayıcı.Properties.Resources.twitter;
            this.btnTwit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTwit.Location = new System.Drawing.Point(896, 159);
            this.btnTwit.Name = "btnTwit";
            this.btnTwit.Size = new System.Drawing.Size(57, 51);
            this.btnTwit.TabIndex = 11;
            this.btnTwit.UseVisualStyleBackColor = true;
            this.btnTwit.Click += new System.EventHandler(this.btnTwit_Click);
            // 
            // btnFace
            // 
            this.btnFace.BackgroundImage = global::cSharp_Tarayıcı.Properties.Resources.facebook;
            this.btnFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFace.Location = new System.Drawing.Point(741, 159);
            this.btnFace.Name = "btnFace";
            this.btnFace.Size = new System.Drawing.Size(57, 51);
            this.btnFace.TabIndex = 10;
            this.btnFace.UseVisualStyleBackColor = true;
            this.btnFace.Click += new System.EventHandler(this.btnFace_Click);
            // 
            // btnIns
            // 
            this.btnIns.BackgroundImage = global::cSharp_Tarayıcı.Properties.Resources.instgram;
            this.btnIns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIns.Location = new System.Drawing.Point(969, 159);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(57, 51);
            this.btnIns.TabIndex = 9;
            this.btnIns.UseVisualStyleBackColor = true;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // btnLink
            // 
            this.btnLink.BackgroundImage = global::cSharp_Tarayıcı.Properties.Resources.linkedn;
            this.btnLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLink.Location = new System.Drawing.Point(821, 159);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(57, 51);
            this.btnLink.TabIndex = 8;
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // btnForward
            // 
            this.btnForward.BackgroundImage = global::cSharp_Tarayıcı.Properties.Resources.forward;
            this.btnForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnForward.Location = new System.Drawing.Point(86, 159);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(57, 51);
            this.btnForward.TabIndex = 6;
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::cSharp_Tarayıcı.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(584, 159);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(57, 51);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnGo
            // 
            this.btnGo.BackgroundImage = global::cSharp_Tarayıcı.Properties.Resources.go;
            this.btnGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGo.Location = new System.Drawing.Point(429, 159);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(57, 51);
            this.btnGo.TabIndex = 4;
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = global::cSharp_Tarayıcı.Properties.Resources.Stop;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.Location = new System.Drawing.Point(657, 159);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(57, 51);
            this.btnStop.TabIndex = 3;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::cSharp_Tarayıcı.Properties.Resources.home;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Location = new System.Drawing.Point(509, 159);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(57, 51);
            this.btnHome.TabIndex = 2;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::cSharp_Tarayıcı.Properties.Resources.forward___Kopya;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(12, 159);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(57, 51);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(12, 302);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(754, 387);
            this.webBrowser.TabIndex = 20;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            this.webBrowser.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser_ProgressChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTarih.Location = new System.Drawing.Point(720, 68);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(46, 18);
            this.lblTarih.TabIndex = 21;
            this.lblTarih.Text = "label1";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSaat.Location = new System.Drawing.Point(720, 91);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(46, 18);
            this.lblSaat.TabIndex = 22;
            this.lblSaat.Text = "label2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1046, 28);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yenileToolStripMenuItem,
            this.gazetelerToolStripMenuItem,
            this.renklerToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.yenileToolStripMenuItem.Text = "Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // gazetelerToolStripMenuItem
            // 
            this.gazetelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onedioToolStripMenuItem,
            this.milliyetToolStripMenuItem,
            this.fanatikToolStripMenuItem});
            this.gazetelerToolStripMenuItem.Name = "gazetelerToolStripMenuItem";
            this.gazetelerToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.gazetelerToolStripMenuItem.Text = "Sayfalar";
            // 
            // onedioToolStripMenuItem
            // 
            this.onedioToolStripMenuItem.Name = "onedioToolStripMenuItem";
            this.onedioToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.onedioToolStripMenuItem.Text = "Onedio";
            this.onedioToolStripMenuItem.Click += new System.EventHandler(this.onedioToolStripMenuItem_Click);
            // 
            // milliyetToolStripMenuItem
            // 
            this.milliyetToolStripMenuItem.Name = "milliyetToolStripMenuItem";
            this.milliyetToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.milliyetToolStripMenuItem.Text = "n11";
            this.milliyetToolStripMenuItem.Click += new System.EventHandler(this.milliyetToolStripMenuItem_Click);
            // 
            // fanatikToolStripMenuItem
            // 
            this.fanatikToolStripMenuItem.Name = "fanatikToolStripMenuItem";
            this.fanatikToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.fanatikToolStripMenuItem.Text = "ModaNisa";
            this.fanatikToolStripMenuItem.Click += new System.EventHandler(this.fanatikToolStripMenuItem_Click);
            // 
            // renklerToolStripMenuItem
            // 
            this.renklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maviToolStripMenuItem,
            this.sarıToolStripMenuItem,
            this.yeşilToolStripMenuItem});
            this.renklerToolStripMenuItem.Name = "renklerToolStripMenuItem";
            this.renklerToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.renklerToolStripMenuItem.Text = "Renkler";
            // 
            // maviToolStripMenuItem
            // 
            this.maviToolStripMenuItem.Name = "maviToolStripMenuItem";
            this.maviToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.maviToolStripMenuItem.Text = "Mavi";
            this.maviToolStripMenuItem.Click += new System.EventHandler(this.maviToolStripMenuItem_Click);
            // 
            // sarıToolStripMenuItem
            // 
            this.sarıToolStripMenuItem.Name = "sarıToolStripMenuItem";
            this.sarıToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.sarıToolStripMenuItem.Text = "Sarı";
            this.sarıToolStripMenuItem.Click += new System.EventHandler(this.sarıToolStripMenuItem_Click);
            // 
            // yeşilToolStripMenuItem
            // 
            this.yeşilToolStripMenuItem.Name = "yeşilToolStripMenuItem";
            this.yeşilToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.yeşilToolStripMenuItem.Text = "Yeşil";
            this.yeşilToolStripMenuItem.Click += new System.EventHandler(this.yeşilToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // btnBaslik
            // 
            this.btnBaslik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBaslik.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaslik.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBaslik.Location = new System.Drawing.Point(12, 228);
            this.btnBaslik.Name = "btnBaslik";
            this.btnBaslik.Size = new System.Drawing.Size(77, 51);
            this.btnBaslik.TabIndex = 24;
            this.btnBaslik.Text = "Başlık";
            this.btnBaslik.UseVisualStyleBackColor = true;
            this.btnBaslik.Click += new System.EventHandler(this.btnBaslik_Click);
            // 
            // btnKaynak
            // 
            this.btnKaynak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaynak.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaynak.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKaynak.Location = new System.Drawing.Point(105, 228);
            this.btnKaynak.Name = "btnKaynak";
            this.btnKaynak.Size = new System.Drawing.Size(90, 51);
            this.btnKaynak.TabIndex = 25;
            this.btnKaynak.Text = "Kaynak";
            this.btnKaynak.UseVisualStyleBackColor = true;
            this.btnKaynak.Click += new System.EventHandler(this.btnKaynak_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTemizle.Location = new System.Drawing.Point(212, 228);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(89, 51);
            this.btnTemizle.TabIndex = 26;
            this.btnTemizle.Text = "Temzile";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatuslblDurum,
            this.toolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 702);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1046, 25);
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(57, 20);
            this.toolStripStatusLabel1.Text = "Durum:";
            // 
            // toolStripStatuslblDurum
            // 
            this.toolStripStatuslblDurum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripStatuslblDurum.Name = "toolStripStatuslblDurum";
            this.toolStripStatuslblDurum.Size = new System.Drawing.Size(17, 20);
            this.toolStripStatuslblDurum.Text = "0";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 19);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnGecmis
            // 
            this.btnGecmis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGecmis.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGecmis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGecmis.Location = new System.Drawing.Point(316, 228);
            this.btnGecmis.Name = "btnGecmis";
            this.btnGecmis.Size = new System.Drawing.Size(89, 51);
            this.btnGecmis.TabIndex = 28;
            this.btnGecmis.Text = "Geçmiş";
            this.btnGecmis.UseVisualStyleBackColor = true;
            this.btnGecmis.Click += new System.EventHandler(this.btnGecmis_Click);
            // 
            // lstGecmis
            // 
            this.lstGecmis.FormattingEnabled = true;
            this.lstGecmis.ItemHeight = 16;
            this.lstGecmis.Location = new System.Drawing.Point(772, 302);
            this.lstGecmis.Name = "lstGecmis";
            this.lstGecmis.Size = new System.Drawing.Size(254, 388);
            this.lstGecmis.TabIndex = 29;
            // 
            // btnGecmisSil
            // 
            this.btnGecmisSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGecmisSil.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGecmisSil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGecmisSil.Location = new System.Drawing.Point(429, 228);
            this.btnGecmisSil.Name = "btnGecmisSil";
            this.btnGecmisSil.Size = new System.Drawing.Size(137, 51);
            this.btnGecmisSil.TabIndex = 30;
            this.btnGecmisSil.Text = "Geçmişi Sil";
            this.btnGecmisSil.UseVisualStyleBackColor = true;
            this.btnGecmisSil.Click += new System.EventHandler(this.btnGecmisSil_Click);
            // 
            // cSharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::cSharp_Tarayıcı.Properties.Resources.background4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1046, 727);
            this.Controls.Add(this.btnGecmisSil);
            this.Controls.Add(this.lstGecmis);
            this.Controls.Add(this.btnGecmis);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaynak);
            this.Controls.Add(this.btnBaslik);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.btnJoy);
            this.Controls.Add(this.btnNumber);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Controls.Add(this.btnKral);
            this.Controls.Add(this.btnTwit);
            this.Controls.Add(this.btnFace);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.btnLink);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cSharp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnTwit;
        private System.Windows.Forms.Button btnFace;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.Button btnKral;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnNumber;
        private System.Windows.Forms.Button btnJoy;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gazetelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onedioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem milliyetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fanatikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeşilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Button btnBaslik;
        private System.Windows.Forms.Button btnKaynak;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatuslblDurum;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnGecmis;
        private System.Windows.Forms.ListBox lstGecmis;
        private System.Windows.Forms.Button btnGecmisSil;
    }
}

