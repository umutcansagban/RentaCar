namespace Rent_a_Car_Uygulaması
{
    partial class frmkullanici
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
            if (disposing)
            {
               
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.lblhosgeldiniz = new System.Windows.Forms.Label();
            this.btndon = new System.Windows.Forms.Button();
            this.dtpBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btngoster = new System.Windows.Forms.Button();
            this.dgvaraclar = new System.Windows.Forms.DataGridView();
            this.btnkirala = new System.Windows.Forms.Button();
            this.cbMarka = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvaraclar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblhosgeldiniz
            // 
            this.lblhosgeldiniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblhosgeldiniz.ForeColor = System.Drawing.Color.Silver;
            this.lblhosgeldiniz.Location = new System.Drawing.Point(12, 9);
            this.lblhosgeldiniz.Name = "lblhosgeldiniz";
            this.lblhosgeldiniz.Size = new System.Drawing.Size(482, 52);
            this.lblhosgeldiniz.TabIndex = 0;
            this.lblhosgeldiniz.Text = "label1";
            // 
            // btndon
            // 
            this.btndon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndon.ForeColor = System.Drawing.Color.Silver;
            this.btndon.Image = global::Rent_a_Car_Uygulaması.Properties.Resources.Return;
            this.btndon.Location = new System.Drawing.Point(751, -1);
            this.btndon.Name = "btndon";
            this.btndon.Size = new System.Drawing.Size(50, 50);
            this.btndon.TabIndex = 1;
            this.btndon.UseVisualStyleBackColor = true;
            this.btndon.Click += new System.EventHandler(this.btndon_Click);
            // 
            // dtpBaslangicTarihi
            // 
            this.dtpBaslangicTarihi.Location = new System.Drawing.Point(80, 95);
            this.dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            this.dtpBaslangicTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpBaslangicTarihi.TabIndex = 2;
            // 
            // dtpBitisTarihi
            // 
            this.dtpBitisTarihi.Location = new System.Drawing.Point(312, 95);
            this.dtpBitisTarihi.Name = "dtpBitisTarihi";
            this.dtpBitisTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpBitisTarihi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(117, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Araç Alış Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(352, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Araç Teslim Tarihi";
            // 
            // btngoster
            // 
            this.btngoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngoster.ForeColor = System.Drawing.Color.Silver;
            this.btngoster.Location = new System.Drawing.Point(671, 97);
            this.btngoster.Name = "btngoster";
            this.btngoster.Size = new System.Drawing.Size(104, 25);
            this.btngoster.TabIndex = 6;
            this.btngoster.Text = "Araçları Göster";
            this.btngoster.UseVisualStyleBackColor = true;
            this.btngoster.Click += new System.EventHandler(this.btngoster_Click);
            // 
            // dgvaraclar
            // 
            this.dgvaraclar.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.dgvaraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvaraclar.Location = new System.Drawing.Point(12, 139);
            this.dgvaraclar.Name = "dgvaraclar";
            this.dgvaraclar.RowHeadersWidth = 51;
            this.dgvaraclar.RowTemplate.Height = 24;
            this.dgvaraclar.Size = new System.Drawing.Size(776, 253);
            this.dgvaraclar.TabIndex = 7;
            this.dgvaraclar.SelectionChanged += new System.EventHandler(this.dgvaraclar_SelectionChanged);
            // 
            // btnkirala
            // 
            this.btnkirala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkirala.ForeColor = System.Drawing.Color.Silver;
            this.btnkirala.Location = new System.Drawing.Point(312, 405);
            this.btnkirala.Name = "btnkirala";
            this.btnkirala.Size = new System.Drawing.Size(106, 33);
            this.btnkirala.TabIndex = 10;
            this.btnkirala.Text = "Kirala";
            this.btnkirala.UseVisualStyleBackColor = true;
            this.btnkirala.Click += new System.EventHandler(this.btnkirala_Click);
            // 
            // cbMarka
            // 
            this.cbMarka.BackColor = System.Drawing.SystemColors.Desktop;
            this.cbMarka.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbMarka.ForeColor = System.Drawing.Color.Silver;
            this.cbMarka.FormattingEnabled = true;
            this.cbMarka.Location = new System.Drawing.Point(544, 98);
            this.cbMarka.Name = "cbMarka";
            this.cbMarka.Size = new System.Drawing.Size(121, 24);
            this.cbMarka.TabIndex = 13;
            this.cbMarka.SelectedIndexChanged += new System.EventHandler(this.cbMarka_SelectedIndexChanged);
            // 
            // frmkullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.cbMarka);
            this.Controls.Add(this.btnkirala);
            this.Controls.Add(this.dgvaraclar);
            this.Controls.Add(this.btngoster);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpBitisTarihi);
            this.Controls.Add(this.dtpBaslangicTarihi);
            this.Controls.Add(this.btndon);
            this.Controls.Add(this.lblhosgeldiniz);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "frmkullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Paneli";
            this.Load += new System.EventHandler(this.frmkullanici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvaraclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhosgeldiniz;
        private System.Windows.Forms.Button btndon;
        private System.Windows.Forms.DateTimePicker dtpBaslangicTarihi;
        private System.Windows.Forms.DateTimePicker dtpBitisTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btngoster;
        private System.Windows.Forms.DataGridView dgvaraclar;
        private System.Windows.Forms.Button btnkirala;
        private System.Windows.Forms.ComboBox cbMarka;
    }
}