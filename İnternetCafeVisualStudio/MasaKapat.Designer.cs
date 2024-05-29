namespace İnternetCafe2
{
    partial class MasaKapat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasaKapat));
            this.Masa_Kapat = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtID_ = new System.Windows.Forms.TextBox();
            this.TxtMasaID_ = new System.Windows.Forms.TextBox();
            this.TxtMasa_ = new System.Windows.Forms.TextBox();
            this.TxtAcilisTuru_ = new System.Windows.Forms.TextBox();
            this.TxtBaslamaSaati_ = new System.Windows.Forms.TextBox();
            this.TxtBitisSaati_ = new System.Windows.Forms.TextBox();
            this.TxtSaatUcreti_ = new System.Windows.Forms.TextBox();
            this.TxtTutar_ = new System.Windows.Forms.TextBox();
            this.TxtTarih_ = new System.Windows.Forms.TextBox();
            this.TxtMasaID = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.Label();
            this.TxtMasa = new System.Windows.Forms.Label();
            this.TxtAcilisTuru = new System.Windows.Forms.Label();
            this.TxtBaslamaSaati = new System.Windows.Forms.Label();
            this.TxtSaatUcreti = new System.Windows.Forms.Label();
            this.TxtSure = new System.Windows.Forms.Label();
            this.TxtTutar = new System.Windows.Forms.Label();
            this.TxtTarih = new System.Windows.Forms.Label();
            this.TxtBitisSaati = new System.Windows.Forms.Label();
            this.TxtSuree = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Masa_Kapat
            // 
            this.Masa_Kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Masa_Kapat.Location = new System.Drawing.Point(136, 574);
            this.Masa_Kapat.Name = "Masa_Kapat";
            this.Masa_Kapat.Size = new System.Drawing.Size(109, 43);
            this.Masa_Kapat.TabIndex = 0;
            this.Masa_Kapat.Text = "Kapat";
            this.Masa_Kapat.UseVisualStyleBackColor = true;
            this.Masa_Kapat.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(278, 574);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(75, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Masa kapatılacak, onaylıyor musunuz?";
            // 
            // TxtID_
            // 
            this.TxtID_.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtID_.Location = new System.Drawing.Point(205, 54);
            this.TxtID_.Multiline = true;
            this.TxtID_.Name = "TxtID_";
            this.TxtID_.Size = new System.Drawing.Size(242, 36);
            this.TxtID_.TabIndex = 3;
            this.TxtID_.TextChanged += new System.EventHandler(this.MasaNumarası_TextChanged);
            // 
            // TxtMasaID_
            // 
            this.TxtMasaID_.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtMasaID_.Location = new System.Drawing.Point(205, 97);
            this.TxtMasaID_.Multiline = true;
            this.TxtMasaID_.Name = "TxtMasaID_";
            this.TxtMasaID_.Size = new System.Drawing.Size(242, 36);
            this.TxtMasaID_.TabIndex = 3;
            this.TxtMasaID_.TextChanged += new System.EventHandler(this.MasaNumarası_TextChanged);
            // 
            // TxtMasa_
            // 
            this.TxtMasa_.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtMasa_.Location = new System.Drawing.Point(205, 140);
            this.TxtMasa_.Multiline = true;
            this.TxtMasa_.Name = "TxtMasa_";
            this.TxtMasa_.Size = new System.Drawing.Size(242, 36);
            this.TxtMasa_.TabIndex = 3;
            this.TxtMasa_.TextChanged += new System.EventHandler(this.MasaNumarası_TextChanged);
            // 
            // TxtAcilisTuru_
            // 
            this.TxtAcilisTuru_.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtAcilisTuru_.Location = new System.Drawing.Point(205, 183);
            this.TxtAcilisTuru_.Multiline = true;
            this.TxtAcilisTuru_.Name = "TxtAcilisTuru_";
            this.TxtAcilisTuru_.Size = new System.Drawing.Size(242, 36);
            this.TxtAcilisTuru_.TabIndex = 3;
            this.TxtAcilisTuru_.TextChanged += new System.EventHandler(this.MasaNumarası_TextChanged);
            // 
            // TxtBaslamaSaati_
            // 
            this.TxtBaslamaSaati_.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtBaslamaSaati_.Location = new System.Drawing.Point(205, 226);
            this.TxtBaslamaSaati_.Multiline = true;
            this.TxtBaslamaSaati_.Name = "TxtBaslamaSaati_";
            this.TxtBaslamaSaati_.Size = new System.Drawing.Size(242, 36);
            this.TxtBaslamaSaati_.TabIndex = 3;
            this.TxtBaslamaSaati_.TextChanged += new System.EventHandler(this.MasaNumarası_TextChanged);
            // 
            // TxtBitisSaati_
            // 
            this.TxtBitisSaati_.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtBitisSaati_.Location = new System.Drawing.Point(205, 269);
            this.TxtBitisSaati_.Multiline = true;
            this.TxtBitisSaati_.Name = "TxtBitisSaati_";
            this.TxtBitisSaati_.Size = new System.Drawing.Size(242, 36);
            this.TxtBitisSaati_.TabIndex = 3;
            this.TxtBitisSaati_.TextChanged += new System.EventHandler(this.MasaNumarası_TextChanged);
            // 
            // TxtSaatUcreti_
            // 
            this.TxtSaatUcreti_.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtSaatUcreti_.Location = new System.Drawing.Point(205, 312);
            this.TxtSaatUcreti_.Multiline = true;
            this.TxtSaatUcreti_.Name = "TxtSaatUcreti_";
            this.TxtSaatUcreti_.Size = new System.Drawing.Size(242, 36);
            this.TxtSaatUcreti_.TabIndex = 3;
            this.TxtSaatUcreti_.TextChanged += new System.EventHandler(this.MasaNumarası_TextChanged);
            // 
            // TxtTutar_
            // 
            this.TxtTutar_.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtTutar_.Location = new System.Drawing.Point(205, 398);
            this.TxtTutar_.Multiline = true;
            this.TxtTutar_.Name = "TxtTutar_";
            this.TxtTutar_.Size = new System.Drawing.Size(242, 36);
            this.TxtTutar_.TabIndex = 3;
            this.TxtTutar_.TextChanged += new System.EventHandler(this.MasaNumarası_TextChanged);
            // 
            // TxtTarih_
            // 
            this.TxtTarih_.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtTarih_.Location = new System.Drawing.Point(205, 441);
            this.TxtTarih_.Multiline = true;
            this.TxtTarih_.Name = "TxtTarih_";
            this.TxtTarih_.Size = new System.Drawing.Size(242, 36);
            this.TxtTarih_.TabIndex = 3;
            this.TxtTarih_.TextChanged += new System.EventHandler(this.MasaNumarası_TextChanged);
            // 
            // TxtMasaID
            // 
            this.TxtMasaID.AutoSize = true;
            this.TxtMasaID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtMasaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMasaID.Location = new System.Drawing.Point(65, 100);
            this.TxtMasaID.Name = "TxtMasaID";
            this.TxtMasaID.Size = new System.Drawing.Size(73, 20);
            this.TxtMasaID.TabIndex = 4;
            this.TxtMasaID.Text = "MasaID";
            // 
            // TxtID
            // 
            this.TxtID.AutoSize = true;
            this.TxtID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtID.Location = new System.Drawing.Point(99, 57);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(28, 20);
            this.TxtID.TabIndex = 4;
            this.TxtID.Text = "ID";
            // 
            // TxtMasa
            // 
            this.TxtMasa.AutoSize = true;
            this.TxtMasa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtMasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMasa.Location = new System.Drawing.Point(78, 143);
            this.TxtMasa.Name = "TxtMasa";
            this.TxtMasa.Size = new System.Drawing.Size(54, 20);
            this.TxtMasa.TabIndex = 4;
            this.TxtMasa.Text = "Masa";
            // 
            // TxtAcilisTuru
            // 
            this.TxtAcilisTuru.AutoSize = true;
            this.TxtAcilisTuru.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtAcilisTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAcilisTuru.Location = new System.Drawing.Point(50, 186);
            this.TxtAcilisTuru.Name = "TxtAcilisTuru";
            this.TxtAcilisTuru.Size = new System.Drawing.Size(100, 20);
            this.TxtAcilisTuru.TabIndex = 4;
            this.TxtAcilisTuru.Text = "Açılış Türü";
            // 
            // TxtBaslamaSaati
            // 
            this.TxtBaslamaSaati.AutoSize = true;
            this.TxtBaslamaSaati.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtBaslamaSaati.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBaslamaSaati.Location = new System.Drawing.Point(24, 229);
            this.TxtBaslamaSaati.Name = "TxtBaslamaSaati";
            this.TxtBaslamaSaati.Size = new System.Drawing.Size(131, 20);
            this.TxtBaslamaSaati.TabIndex = 4;
            this.TxtBaslamaSaati.Text = "Başlama Saati";
            // 
            // TxtSaatUcreti
            // 
            this.TxtSaatUcreti.AutoSize = true;
            this.TxtSaatUcreti.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtSaatUcreti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSaatUcreti.Location = new System.Drawing.Point(46, 312);
            this.TxtSaatUcreti.Name = "TxtSaatUcreti";
            this.TxtSaatUcreti.Size = new System.Drawing.Size(104, 20);
            this.TxtSaatUcreti.TabIndex = 4;
            this.TxtSaatUcreti.Text = "Saat Ücreti";
            // 
            // TxtSure
            // 
            this.TxtSure.AutoSize = true;
            this.TxtSure.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSure.Location = new System.Drawing.Point(84, 358);
            this.TxtSure.Name = "TxtSure";
            this.TxtSure.Size = new System.Drawing.Size(48, 20);
            this.TxtSure.TabIndex = 4;
            this.TxtSure.Text = "Süre";
            // 
            // TxtTutar
            // 
            this.TxtTutar.AutoSize = true;
            this.TxtTutar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTutar.Location = new System.Drawing.Point(81, 401);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(53, 20);
            this.TxtTutar.TabIndex = 4;
            this.TxtTutar.Text = "Tutar";
            // 
            // TxtTarih
            // 
            this.TxtTarih.AutoSize = true;
            this.TxtTarih.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTarih.Location = new System.Drawing.Point(81, 444);
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Size = new System.Drawing.Size(52, 20);
            this.TxtTarih.TabIndex = 4;
            this.TxtTarih.Text = "Tarih";
            // 
            // TxtBitisSaati
            // 
            this.TxtBitisSaati.AutoSize = true;
            this.TxtBitisSaati.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtBitisSaati.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBitisSaati.Location = new System.Drawing.Point(53, 272);
            this.TxtBitisSaati.Name = "TxtBitisSaati";
            this.TxtBitisSaati.Size = new System.Drawing.Size(97, 20);
            this.TxtBitisSaati.TabIndex = 4;
            this.TxtBitisSaati.Text = "Bitiş Saati";
            // 
            // TxtSuree
            // 
            this.TxtSuree.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtSuree.Location = new System.Drawing.Point(205, 354);
            this.TxtSuree.Multiline = true;
            this.TxtSuree.Name = "TxtSuree";
            this.TxtSuree.Size = new System.Drawing.Size(242, 36);
            this.TxtSuree.TabIndex = 5;
            // 
            // MasaKapat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(505, 652);
            this.Controls.Add(this.TxtSuree);
            this.Controls.Add(this.TxtBitisSaati);
            this.Controls.Add(this.TxtTarih);
            this.Controls.Add(this.TxtTutar);
            this.Controls.Add(this.TxtSure);
            this.Controls.Add(this.TxtAcilisTuru);
            this.Controls.Add(this.TxtSaatUcreti);
            this.Controls.Add(this.TxtMasa);
            this.Controls.Add(this.TxtBaslamaSaati);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.TxtMasaID);
            this.Controls.Add(this.TxtSaatUcreti_);
            this.Controls.Add(this.TxtAcilisTuru_);
            this.Controls.Add(this.TxtBitisSaati_);
            this.Controls.Add(this.TxtMasa_);
            this.Controls.Add(this.TxtBaslamaSaati_);
            this.Controls.Add(this.TxtTarih_);
            this.Controls.Add(this.TxtTutar_);
            this.Controls.Add(this.TxtMasaID_);
            this.Controls.Add(this.TxtID_);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Masa_Kapat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MasaKapat";
            this.Text = "MasaKapat";
            this.Load += new System.EventHandler(this.MasaKapat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Masa_Kapat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtID_;
        public System.Windows.Forms.TextBox TxtMasaID_;
        public System.Windows.Forms.TextBox TxtMasa_;
        public System.Windows.Forms.TextBox TxtAcilisTuru_;
        public System.Windows.Forms.TextBox TxtBaslamaSaati_;
        public System.Windows.Forms.TextBox TxtBitisSaati_;
        public System.Windows.Forms.TextBox TxtSaatUcreti_;
        public System.Windows.Forms.TextBox TxtTutar_;
        public System.Windows.Forms.TextBox TxtTarih_;
        private System.Windows.Forms.Label TxtMasaID;
        private System.Windows.Forms.Label TxtID;
        private System.Windows.Forms.Label TxtMasa;
        private System.Windows.Forms.Label TxtAcilisTuru;
        private System.Windows.Forms.Label TxtBaslamaSaati;
        private System.Windows.Forms.Label TxtSaatUcreti;
        private System.Windows.Forms.Label TxtSure;
        private System.Windows.Forms.Label TxtTutar;
        private System.Windows.Forms.Label TxtTarih;
        private System.Windows.Forms.Label TxtBitisSaati;
        public System.Windows.Forms.TextBox TxtSuree;
    }
}