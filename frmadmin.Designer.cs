namespace Rent_a_Car_Uygulaması
{
    partial class frmadmin
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
            this.btndon = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.cbyakit = new System.Windows.Forms.ComboBox();
            this.cbsanziman = new System.Windows.Forms.ComboBox();
            this.tbyil = new System.Windows.Forms.TextBox();
            this.tbmodel = new System.Windows.Forms.TextBox();
            this.tbmarka = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnsil = new System.Windows.Forms.Button();
            this.pbresim = new System.Windows.Forms.PictureBox();
            this.btnyenile = new System.Windows.Forms.Button();
            this.btnonay = new System.Windows.Forms.Button();
            this.dgvilanlar = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pbonayli = new System.Windows.Forms.PictureBox();
            this.dgvonaylilar = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbresim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvilanlar)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbonayli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvonaylilar)).BeginInit();
            this.SuspendLayout();
            // 
            // btndon
            // 
            this.btndon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndon.ForeColor = System.Drawing.Color.Silver;
            this.btndon.Location = new System.Drawing.Point(1124, 0);
            this.btndon.Name = "btndon";
            this.btndon.Size = new System.Drawing.Size(119, 56);
            this.btndon.TabIndex = 3;
            this.btndon.Text = "Girişe Dön";
            this.btndon.UseVisualStyleBackColor = true;
            this.btndon.Click += new System.EventHandler(this.btndon_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1122, 630);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Desktop;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnekle);
            this.tabPage1.Controls.Add(this.cbyakit);
            this.tabPage1.Controls.Add(this.cbsanziman);
            this.tabPage1.Controls.Add(this.tbyil);
            this.tabPage1.Controls.Add(this.tbmodel);
            this.tabPage1.Controls.Add(this.tbmarka);
            this.tabPage1.ForeColor = System.Drawing.Color.Silver;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1114, 601);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Araç Ekle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(30, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Yakıt Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(30, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Şanzıman Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(30, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Araç Yılı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(30, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Araç Modeli";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Araç Markası";
            // 
            // btnekle
            // 
            this.btnekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnekle.Location = new System.Drawing.Point(141, 248);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(121, 32);
            this.btnekle.TabIndex = 27;
            this.btnekle.Text = "Araç Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click_1);
            // 
            // cbyakit
            // 
            this.cbyakit.BackColor = System.Drawing.SystemColors.Desktop;
            this.cbyakit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbyakit.ForeColor = System.Drawing.Color.Silver;
            this.cbyakit.FormattingEnabled = true;
            this.cbyakit.Location = new System.Drawing.Point(141, 197);
            this.cbyakit.Name = "cbyakit";
            this.cbyakit.Size = new System.Drawing.Size(121, 24);
            this.cbyakit.TabIndex = 26;
            // 
            // cbsanziman
            // 
            this.cbsanziman.BackColor = System.Drawing.SystemColors.Desktop;
            this.cbsanziman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbsanziman.ForeColor = System.Drawing.Color.Silver;
            this.cbsanziman.FormattingEnabled = true;
            this.cbsanziman.Location = new System.Drawing.Point(141, 156);
            this.cbsanziman.Name = "cbsanziman";
            this.cbsanziman.Size = new System.Drawing.Size(121, 24);
            this.cbsanziman.TabIndex = 25;
            // 
            // tbyil
            // 
            this.tbyil.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbyil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbyil.ForeColor = System.Drawing.Color.Silver;
            this.tbyil.Location = new System.Drawing.Point(141, 106);
            this.tbyil.Name = "tbyil";
            this.tbyil.Size = new System.Drawing.Size(100, 22);
            this.tbyil.TabIndex = 24;
            // 
            // tbmodel
            // 
            this.tbmodel.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbmodel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbmodel.ForeColor = System.Drawing.Color.Silver;
            this.tbmodel.Location = new System.Drawing.Point(141, 61);
            this.tbmodel.Name = "tbmodel";
            this.tbmodel.Size = new System.Drawing.Size(100, 22);
            this.tbmodel.TabIndex = 23;
            // 
            // tbmarka
            // 
            this.tbmarka.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbmarka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbmarka.ForeColor = System.Drawing.Color.Silver;
            this.tbmarka.Location = new System.Drawing.Point(141, 17);
            this.tbmarka.Name = "tbmarka";
            this.tbmarka.Size = new System.Drawing.Size(100, 22);
            this.tbmarka.TabIndex = 22;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Desktop;
            this.tabPage2.Controls.Add(this.btnsil);
            this.tabPage2.Controls.Add(this.pbresim);
            this.tabPage2.Controls.Add(this.btnyenile);
            this.tabPage2.Controls.Add(this.btnonay);
            this.tabPage2.Controls.Add(this.dgvilanlar);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1114, 601);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "İlan Onayla";
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.ForeColor = System.Drawing.Color.Silver;
            this.btnsil.Location = new System.Drawing.Point(254, 517);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(96, 47);
            this.btnsil.TabIndex = 9;
            this.btnsil.Text = "İlani Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // pbresim
            // 
            this.pbresim.BackColor = System.Drawing.SystemColors.Desktop;
            this.pbresim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbresim.Location = new System.Drawing.Point(824, 27);
            this.pbresim.Name = "pbresim";
            this.pbresim.Size = new System.Drawing.Size(235, 229);
            this.pbresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbresim.TabIndex = 8;
            this.pbresim.TabStop = false;
            // 
            // btnyenile
            // 
            this.btnyenile.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnyenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyenile.ForeColor = System.Drawing.Color.Silver;
            this.btnyenile.Location = new System.Drawing.Point(384, 515);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(111, 48);
            this.btnyenile.TabIndex = 7;
            this.btnyenile.Text = "Yenile";
            this.btnyenile.UseVisualStyleBackColor = false;
            // 
            // btnonay
            // 
            this.btnonay.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnonay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnonay.ForeColor = System.Drawing.Color.Silver;
            this.btnonay.Location = new System.Drawing.Point(118, 516);
            this.btnonay.Name = "btnonay";
            this.btnonay.Size = new System.Drawing.Size(96, 47);
            this.btnonay.TabIndex = 6;
            this.btnonay.Text = "İlan Onayla";
            this.btnonay.UseVisualStyleBackColor = false;
            this.btnonay.Click += new System.EventHandler(this.btnonay_Click_1);
            // 
            // dgvilanlar
            // 
            this.dgvilanlar.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.dgvilanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvilanlar.Location = new System.Drawing.Point(0, 0);
            this.dgvilanlar.Name = "dgvilanlar";
            this.dgvilanlar.RowHeadersWidth = 51;
            this.dgvilanlar.RowTemplate.Height = 24;
            this.dgvilanlar.Size = new System.Drawing.Size(796, 471);
            this.dgvilanlar.TabIndex = 5;
            this.dgvilanlar.SelectionChanged += new System.EventHandler(this.dgvilanlar_SelectionChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Desktop;
            this.tabPage3.Controls.Add(this.pbonayli);
            this.tabPage3.Controls.Add(this.dgvonaylilar);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1114, 601);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Onaylı İlanlar";
            // 
            // pbonayli
            // 
            this.pbonayli.BackColor = System.Drawing.SystemColors.Desktop;
            this.pbonayli.Location = new System.Drawing.Point(827, 48);
            this.pbonayli.Name = "pbonayli";
            this.pbonayli.Size = new System.Drawing.Size(259, 262);
            this.pbonayli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbonayli.TabIndex = 2;
            this.pbonayli.TabStop = false;
            // 
            // dgvonaylilar
            // 
            this.dgvonaylilar.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.dgvonaylilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvonaylilar.Location = new System.Drawing.Point(8, 14);
            this.dgvonaylilar.Name = "dgvonaylilar";
            this.dgvonaylilar.RowHeadersWidth = 51;
            this.dgvonaylilar.RowTemplate.Height = 24;
            this.dgvonaylilar.Size = new System.Drawing.Size(797, 406);
            this.dgvonaylilar.TabIndex = 1;
            this.dgvonaylilar.SelectionChanged += new System.EventHandler(this.dgvonaylilar_SelectionChanged);
            // 
            // frmadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1240, 629);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btndon);
            this.Name = "frmadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.frmadmin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbresim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvilanlar)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbonayli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvonaylilar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btndon;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.ComboBox cbyakit;
        private System.Windows.Forms.ComboBox cbsanziman;
        private System.Windows.Forms.TextBox tbyil;
        private System.Windows.Forms.TextBox tbmodel;
        private System.Windows.Forms.TextBox tbmarka;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.PictureBox pbresim;
        private System.Windows.Forms.Button btnyenile;
        private System.Windows.Forms.Button btnonay;
        private System.Windows.Forms.DataGridView dgvilanlar;
        private System.Windows.Forms.DataGridView dgvonaylilar;
        private System.Windows.Forms.PictureBox pbonayli;
    }
}