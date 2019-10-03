namespace BilgiYarismasiOyunu
{
    partial class BilgiYarismasi
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
            this.txtSoru = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnBasla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSoruSayisi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDogruSayi = new System.Windows.Forms.Label();
            this.lblDogru = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblzaman = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtSoru
            // 
            this.txtSoru.BackColor = System.Drawing.Color.White;
            this.txtSoru.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoru.Location = new System.Drawing.Point(25, 12);
            this.txtSoru.Multiline = true;
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(357, 93);
            this.txtSoru.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnA.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnA.Location = new System.Drawing.Point(25, 115);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(357, 34);
            this.btnA.TabIndex = 2;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnB.Location = new System.Drawing.Point(25, 155);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(357, 34);
            this.btnB.TabIndex = 3;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnC.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnC.Location = new System.Drawing.Point(25, 195);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(357, 34);
            this.btnC.TabIndex = 4;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnBasla
            // 
            this.btnBasla.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasla.Location = new System.Drawing.Point(624, 12);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(151, 40);
            this.btnBasla.TabIndex = 6;
            this.btnBasla.Text = "BAŞLA";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(443, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Puan:";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.Location = new System.Drawing.Point(512, 202);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(22, 25);
            this.lblPuan.TabIndex = 8;
            this.lblPuan.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(443, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dogru Soru Sayısı:";
            // 
            // lblSoruSayisi
            // 
            this.lblSoruSayisi.AutoSize = true;
            this.lblSoruSayisi.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoruSayisi.Location = new System.Drawing.Point(556, 26);
            this.lblSoruSayisi.Name = "lblSoruSayisi";
            this.lblSoruSayisi.Size = new System.Drawing.Size(22, 25);
            this.lblSoruSayisi.TabIndex = 11;
            this.lblSoruSayisi.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(443, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Soru Sayısı:";
            // 
            // lblDogruSayi
            // 
            this.lblDogruSayi.AutoSize = true;
            this.lblDogruSayi.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogruSayi.Location = new System.Drawing.Point(614, 156);
            this.lblDogruSayi.Name = "lblDogruSayi";
            this.lblDogruSayi.Size = new System.Drawing.Size(22, 25);
            this.lblDogruSayi.TabIndex = 14;
            this.lblDogruSayi.Text = "0";
            // 
            // lblDogru
            // 
            this.lblDogru.AutoSize = true;
            this.lblDogru.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogru.Location = new System.Drawing.Point(595, 115);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(28, 25);
            this.lblDogru.TabIndex = 16;
            this.lblDogru.Text = "--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(443, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Dogru Cevap:";
            // 
            // lblzaman
            // 
            this.lblzaman.AutoSize = true;
            this.lblzaman.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblzaman.Location = new System.Drawing.Point(595, 71);
            this.lblzaman.Name = "lblzaman";
            this.lblzaman.Size = new System.Drawing.Size(28, 25);
            this.lblzaman.TabIndex = 18;
            this.lblzaman.Text = "--";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(443, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Kalan Süre:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BilgiYarismasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 278);
            this.Controls.Add(this.lblzaman);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDogru);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDogruSayi);
            this.Controls.Add(this.lblSoruSayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.txtSoru);
            this.Name = "BilgiYarismasi";
            this.Text = "BilgiYarismasi";
            this.Load += new System.EventHandler(this.BilgiYarismasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoru;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSoruSayisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDogruSayi;
        private System.Windows.Forms.Label lblDogru;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblzaman;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
    }
}