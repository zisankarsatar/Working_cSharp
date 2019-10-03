namespace AtYarisi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBitis = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnBasla = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnBitir = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.btnTekrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-4, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1169, 27);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(-4, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1169, 27);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(-1, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1169, 27);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(-4, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1169, 27);
            this.label4.TabIndex = 3;
            // 
            // lblBitis
            // 
            this.lblBitis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBitis.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBitis.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBitis.Location = new System.Drawing.Point(1155, -1);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(23, 463);
            this.lblBitis.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBox2.Image = global::AtYarisi.Properties.Resources.at3;
            this.pictureBox2.Location = new System.Drawing.Point(12, 188);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBox3.Image = global::AtYarisi.Properties.Resources.at2;
            this.pictureBox3.Location = new System.Drawing.Point(12, 334);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(136, 88);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBasla.Location = new System.Drawing.Point(23, 508);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(108, 46);
            this.btnBasla.TabIndex = 8;
            this.btnBasla.Text = "BAŞLA";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnBitir
            // 
            this.btnBitir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBitir.Location = new System.Drawing.Point(1012, 508);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(108, 46);
            this.btnBitir.TabIndex = 9;
            this.btnBitir.Text = "BİTİR";
            this.btnBitir.UseVisualStyleBackColor = false;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.BackColor = System.Drawing.Color.Black;
            this.lblDurum.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDurum.Location = new System.Drawing.Point(159, 508);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(515, 46);
            this.lblDurum.TabIndex = 10;
            this.lblDurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSure
            // 
            this.lblSure.BackColor = System.Drawing.Color.Black;
            this.lblSure.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSure.Location = new System.Drawing.Point(690, 508);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(121, 46);
            this.lblSure.TabIndex = 11;
            this.lblSure.Text = "0";
            this.lblSure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTekrar
            // 
            this.btnTekrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTekrar.Location = new System.Drawing.Point(837, 508);
            this.btnTekrar.Name = "btnTekrar";
            this.btnTekrar.Size = new System.Drawing.Size(140, 46);
            this.btnTekrar.TabIndex = 12;
            this.btnTekrar.Text = "TEKRAR OYNA";
            this.btnTekrar.UseVisualStyleBackColor = false;
            this.btnTekrar.Click += new System.EventHandler(this.btnTekrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1185, 596);
            this.Controls.Add(this.btnTekrar);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.btnBitir);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBitis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "At Yarisi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnBitir;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Button btnTekrar;
    }
}

