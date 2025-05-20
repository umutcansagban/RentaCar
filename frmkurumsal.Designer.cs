namespace Rent_a_Car_Uygulaması
{
    partial class frmkurumsal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmkurumsal));
            this.btncikis = new System.Windows.Forms.Button();
            this.lblhosgeldiniz = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbyakit = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbsanziman = new System.Windows.Forms.ComboBox();
            this.cbyil = new System.Windows.Forms.ComboBox();
            this.cbmodel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnresimsec = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pbresim = new System.Windows.Forms.PictureBox();
            this.tbaciklama = new System.Windows.Forms.TextBox();
            this.tbfiyat = new System.Windows.Forms.TextBox();
            this.cbmarka = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvKiralamaGecmisi = new System.Windows.Forms.DataGridView();
            this.dgvKiralama = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbresim)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiralamaGecmisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiralama)).BeginInit();
            this.SuspendLayout();
            // 
            // btncikis
            // 
            this.btncikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncikis.ForeColor = System.Drawing.Color.Silver;
            this.btncikis.Image = global::Rent_a_Car_Uygulaması.Properties.Resources.Return;
            this.btncikis.Location = new System.Drawing.Point(745, 0);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(50, 50);
            this.btncikis.TabIndex = 0;
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // lblhosgeldiniz
            // 
            this.lblhosgeldiniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblhosgeldiniz.ForeColor = System.Drawing.Color.Silver;
            this.lblhosgeldiniz.Location = new System.Drawing.Point(6, 3);
            this.lblhosgeldiniz.Name = "lblhosgeldiniz";
            this.lblhosgeldiniz.Size = new System.Drawing.Size(194, 56);
            this.lblhosgeldiniz.TabIndex = 2;
            this.lblhosgeldiniz.Text = "label1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 462);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Desktop;
            this.tabPage1.Controls.Add(this.cbyakit);
            this.tabPage1.Controls.Add(this.btncikis);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cbsanziman);
            this.tabPage1.Controls.Add(this.cbyil);
            this.tabPage1.Controls.Add(this.cbmodel);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnresimsec);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.pbresim);
            this.tabPage1.Controls.Add(this.tbaciklama);
            this.tabPage1.Controls.Add(this.tbfiyat);
            this.tabPage1.Controls.Add(this.cbmarka);
            this.tabPage1.Controls.Add(this.lblhosgeldiniz);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(802, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "İlan Ekle";
            // 
            // cbyakit
            // 
            this.cbyakit.BackColor = System.Drawing.SystemColors.Desktop;
            this.cbyakit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbyakit.ForeColor = System.Drawing.Color.Silver;
            this.cbyakit.FormattingEnabled = true;
            this.cbyakit.Location = new System.Drawing.Point(198, 269);
            this.cbyakit.Name = "cbyakit";
            this.cbyakit.Size = new System.Drawing.Size(121, 24);
            this.cbyakit.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(109, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Yakıt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(106, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "Şanzıman";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(103, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Araç Yılı";
            // 
            // cbsanziman
            // 
            this.cbsanziman.BackColor = System.Drawing.SystemColors.Desktop;
            this.cbsanziman.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbsanziman.ForeColor = System.Drawing.Color.Silver;
            this.cbsanziman.FormattingEnabled = true;
            this.cbsanziman.Location = new System.Drawing.Point(198, 215);
            this.cbsanziman.Name = "cbsanziman";
            this.cbsanziman.Size = new System.Drawing.Size(121, 24);
            this.cbsanziman.TabIndex = 31;
            this.cbsanziman.SelectedIndexChanged += new System.EventHandler(this.cbsanziman_SelectedIndexChanged);
            // 
            // cbyil
            // 
            this.cbyil.BackColor = System.Drawing.SystemColors.Desktop;
            this.cbyil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbyil.ForeColor = System.Drawing.Color.Silver;
            this.cbyil.FormattingEnabled = true;
            this.cbyil.Location = new System.Drawing.Point(198, 169);
            this.cbyil.Name = "cbyil";
            this.cbyil.Size = new System.Drawing.Size(121, 24);
            this.cbyil.TabIndex = 30;
            this.cbyil.SelectedIndexChanged += new System.EventHandler(this.cbyil_SelectedIndexChanged);
            // 
            // cbmodel
            // 
            this.cbmodel.BackColor = System.Drawing.SystemColors.Desktop;
            this.cbmodel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbmodel.ForeColor = System.Drawing.Color.Silver;
            this.cbmodel.FormattingEnabled = true;
            this.cbmodel.Location = new System.Drawing.Point(198, 118);
            this.cbmodel.Name = "cbmodel";
            this.cbmodel.Size = new System.Drawing.Size(121, 24);
            this.cbmodel.TabIndex = 29;
            this.cbmodel.SelectedIndexChanged += new System.EventHandler(this.cbmodel_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(103, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Araç Modeli";
            // 
            // btnresimsec
            // 
            this.btnresimsec.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnresimsec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnresimsec.ForeColor = System.Drawing.Color.Silver;
            this.btnresimsec.Location = new System.Drawing.Point(617, 262);
            this.btnresimsec.Name = "btnresimsec";
            this.btnresimsec.Size = new System.Drawing.Size(75, 23);
            this.btnresimsec.TabIndex = 27;
            this.btnresimsec.Text = "Resim Seç";
            this.btnresimsec.UseVisualStyleBackColor = false;
            this.btnresimsec.Click += new System.EventHandler(this.btnresimsec_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(423, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "İlan Resmi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(396, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "İlan Açıklaması";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(430, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "İlan Fiyatı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(100, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Araç Markası";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(499, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 37);
            this.button1.TabIndex = 22;
            this.button1.Text = "İlan Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbresim
            // 
            this.pbresim.BackColor = System.Drawing.SystemColors.Desktop;
            this.pbresim.Location = new System.Drawing.Point(499, 231);
            this.pbresim.Name = "pbresim";
            this.pbresim.Size = new System.Drawing.Size(112, 78);
            this.pbresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbresim.TabIndex = 21;
            this.pbresim.TabStop = false;
            // 
            // tbaciklama
            // 
            this.tbaciklama.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbaciklama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbaciklama.ForeColor = System.Drawing.Color.Silver;
            this.tbaciklama.Location = new System.Drawing.Point(499, 184);
            this.tbaciklama.Multiline = true;
            this.tbaciklama.Name = "tbaciklama";
            this.tbaciklama.Size = new System.Drawing.Size(100, 22);
            this.tbaciklama.TabIndex = 20;
            // 
            // tbfiyat
            // 
            this.tbfiyat.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbfiyat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbfiyat.ForeColor = System.Drawing.Color.Silver;
            this.tbfiyat.Location = new System.Drawing.Point(499, 144);
            this.tbfiyat.Name = "tbfiyat";
            this.tbfiyat.Size = new System.Drawing.Size(100, 22);
            this.tbfiyat.TabIndex = 19;
            // 
            // cbmarka
            // 
            this.cbmarka.BackColor = System.Drawing.SystemColors.Desktop;
            this.cbmarka.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbmarka.ForeColor = System.Drawing.Color.Silver;
            this.cbmarka.FormattingEnabled = true;
            this.cbmarka.Location = new System.Drawing.Point(198, 70);
            this.cbmarka.Name = "cbmarka";
            this.cbmarka.Size = new System.Drawing.Size(121, 24);
            this.cbmarka.TabIndex = 18;
            this.cbmarka.SelectedIndexChanged += new System.EventHandler(this.cbmarka_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Desktop;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.dgvKiralamaGecmisi);
            this.tabPage2.Controls.Add(this.dgvKiralama);
            this.tabPage2.ForeColor = System.Drawing.Color.Silver;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(802, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kiralık Araçlar";
            // 
            // dgvKiralamaGecmisi
            // 
            this.dgvKiralamaGecmisi.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.dgvKiralamaGecmisi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKiralamaGecmisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKiralamaGecmisi.GridColor = System.Drawing.SystemColors.Desktop;
            this.dgvKiralamaGecmisi.Location = new System.Drawing.Point(30, 21);
            this.dgvKiralamaGecmisi.Name = "dgvKiralamaGecmisi";
            this.dgvKiralamaGecmisi.RowHeadersWidth = 51;
            this.dgvKiralamaGecmisi.RowTemplate.Height = 24;
            this.dgvKiralamaGecmisi.Size = new System.Drawing.Size(680, 339);
            this.dgvKiralamaGecmisi.TabIndex = 1;
            // 
            // dgvKiralama
            // 
            this.dgvKiralama.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.dgvKiralama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKiralama.Location = new System.Drawing.Point(11, 21);
            this.dgvKiralama.Name = "dgvKiralama";
            this.dgvKiralama.RowHeadersWidth = 51;
            this.dgvKiralama.RowTemplate.Height = 24;
            this.dgvKiralama.Size = new System.Drawing.Size(775, 392);
            this.dgvKiralama.TabIndex = 0;
            // 
            // frmkurumsal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "frmkurumsal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kurumsal Panel";
            this.Load += new System.EventHandler(this.frmkurumsal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbresim)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiralamaGecmisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiralama)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Label lblhosgeldiniz;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbyakit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbsanziman;
        private System.Windows.Forms.ComboBox cbyil;
        private System.Windows.Forms.ComboBox cbmodel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnresimsec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbresim;
        private System.Windows.Forms.TextBox tbaciklama;
        private System.Windows.Forms.TextBox tbfiyat;
        private System.Windows.Forms.ComboBox cbmarka;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvKiralama;
        private System.Windows.Forms.DataGridView dgvKiralamaGecmisi;
    }
}