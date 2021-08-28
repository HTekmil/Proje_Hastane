
namespace Proje_Hastane
{
    partial class FrmSekreterDetay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonOlustur = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxRandevuId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBoxRandevuTarih = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRandevuSaat = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRandevuTC = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxRandevuBrans = new System.Windows.Forms.ComboBox();
            this.comboBoxRandevuDoktor = new System.Windows.Forms.ComboBox();
            this.checkBoxRandevuDurum = new System.Windows.Forms.CheckBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonGüncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonDoktorPaneli = new System.Windows.Forms.Button();
            this.buttonBransPaneli = new System.Windows.Forms.Button();
            this.buttonRandevu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.lbladsoyad);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgileri";
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.AutoSize = true;
            this.lbladsoyad.Location = new System.Drawing.Point(101, 67);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(14, 18);
            this.lbladsoyad.TabIndex = 8;
            this.lbladsoyad.Text = "-";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(119, 36);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(98, 18);
            this.lblTC.TabIndex = 7;
            this.lblTC.Text = "0000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ad Soyad: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "TC Kimlik No: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonOlustur);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 195);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // buttonOlustur
            // 
            this.buttonOlustur.Location = new System.Drawing.Point(9, 151);
            this.buttonOlustur.Name = "buttonOlustur";
            this.buttonOlustur.Size = new System.Drawing.Size(233, 38);
            this.buttonOlustur.TabIndex = 1;
            this.buttonOlustur.Text = "Oluştur";
            this.buttonOlustur.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(236, 122);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonGüncelle);
            this.groupBox3.Controls.Add(this.buttonKaydet);
            this.groupBox3.Controls.Add(this.checkBoxRandevuDurum);
            this.groupBox3.Controls.Add(this.comboBoxRandevuDoktor);
            this.groupBox3.Controls.Add(this.comboBoxRandevuBrans);
            this.groupBox3.Controls.Add(this.maskedTextBoxRandevuTC);
            this.groupBox3.Controls.Add(this.maskedTextBoxRandevuSaat);
            this.groupBox3.Controls.Add(this.maskedTextBoxRandevuTarih);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBoxRandevuId);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(266, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 306);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(487, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(374, 198);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tarih: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Branş: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Saat: ";
            // 
            // textBoxRandevuId
            // 
            this.textBoxRandevuId.Location = new System.Drawing.Point(71, 33);
            this.textBoxRandevuId.Name = "textBoxRandevuId";
            this.textBoxRandevuId.Size = new System.Drawing.Size(128, 24);
            this.textBoxRandevuId.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "TC: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Doktor: ";
            // 
            // maskedTextBoxRandevuTarih
            // 
            this.maskedTextBoxRandevuTarih.Location = new System.Drawing.Point(71, 64);
            this.maskedTextBoxRandevuTarih.Mask = "00/00/0000";
            this.maskedTextBoxRandevuTarih.Name = "maskedTextBoxRandevuTarih";
            this.maskedTextBoxRandevuTarih.Size = new System.Drawing.Size(128, 24);
            this.maskedTextBoxRandevuTarih.TabIndex = 7;
            this.maskedTextBoxRandevuTarih.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxRandevuSaat
            // 
            this.maskedTextBoxRandevuSaat.Location = new System.Drawing.Point(71, 95);
            this.maskedTextBoxRandevuSaat.Mask = "00:00";
            this.maskedTextBoxRandevuSaat.Name = "maskedTextBoxRandevuSaat";
            this.maskedTextBoxRandevuSaat.Size = new System.Drawing.Size(128, 24);
            this.maskedTextBoxRandevuSaat.TabIndex = 8;
            this.maskedTextBoxRandevuSaat.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxRandevuTC
            // 
            this.maskedTextBoxRandevuTC.Location = new System.Drawing.Point(71, 189);
            this.maskedTextBoxRandevuTC.Mask = "0000000000";
            this.maskedTextBoxRandevuTC.Name = "maskedTextBoxRandevuTC";
            this.maskedTextBoxRandevuTC.Size = new System.Drawing.Size(128, 24);
            this.maskedTextBoxRandevuTC.TabIndex = 9;
            this.maskedTextBoxRandevuTC.ValidatingType = typeof(int);
            // 
            // comboBoxRandevuBrans
            // 
            this.comboBoxRandevuBrans.FormattingEnabled = true;
            this.comboBoxRandevuBrans.Location = new System.Drawing.Point(71, 126);
            this.comboBoxRandevuBrans.Name = "comboBoxRandevuBrans";
            this.comboBoxRandevuBrans.Size = new System.Drawing.Size(128, 26);
            this.comboBoxRandevuBrans.TabIndex = 10;
            // 
            // comboBoxRandevuDoktor
            // 
            this.comboBoxRandevuDoktor.FormattingEnabled = true;
            this.comboBoxRandevuDoktor.Location = new System.Drawing.Point(71, 158);
            this.comboBoxRandevuDoktor.Name = "comboBoxRandevuDoktor";
            this.comboBoxRandevuDoktor.Size = new System.Drawing.Size(128, 26);
            this.comboBoxRandevuDoktor.TabIndex = 11;
            // 
            // checkBoxRandevuDurum
            // 
            this.checkBoxRandevuDurum.AutoSize = true;
            this.checkBoxRandevuDurum.Location = new System.Drawing.Point(71, 219);
            this.checkBoxRandevuDurum.Name = "checkBoxRandevuDurum";
            this.checkBoxRandevuDurum.Size = new System.Drawing.Size(77, 22);
            this.checkBoxRandevuDurum.TabIndex = 12;
            this.checkBoxRandevuDurum.Text = "Durum";
            this.checkBoxRandevuDurum.UseVisualStyleBackColor = true;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(6, 267);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(97, 33);
            this.buttonKaydet.TabIndex = 13;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            // 
            // buttonGüncelle
            // 
            this.buttonGüncelle.Location = new System.Drawing.Point(112, 267);
            this.buttonGüncelle.Name = "buttonGüncelle";
            this.buttonGüncelle.Size = new System.Drawing.Size(97, 33);
            this.buttonGüncelle.TabIndex = 14;
            this.buttonGüncelle.Text = "Güncelle";
            this.buttonGüncelle.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(368, 175);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(490, 216);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(374, 177);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 20);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(368, 154);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonRandevu);
            this.groupBox6.Controls.Add(this.buttonBransPaneli);
            this.groupBox6.Controls.Add(this.buttonDoktorPaneli);
            this.groupBox6.Location = new System.Drawing.Point(12, 324);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(469, 69);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // buttonDoktorPaneli
            // 
            this.buttonDoktorPaneli.Location = new System.Drawing.Point(6, 23);
            this.buttonDoktorPaneli.Name = "buttonDoktorPaneli";
            this.buttonDoktorPaneli.Size = new System.Drawing.Size(150, 35);
            this.buttonDoktorPaneli.TabIndex = 14;
            this.buttonDoktorPaneli.Text = "Doktor Paneli";
            this.buttonDoktorPaneli.UseVisualStyleBackColor = true;
            // 
            // buttonBransPaneli
            // 
            this.buttonBransPaneli.Location = new System.Drawing.Point(162, 23);
            this.buttonBransPaneli.Name = "buttonBransPaneli";
            this.buttonBransPaneli.Size = new System.Drawing.Size(145, 35);
            this.buttonBransPaneli.TabIndex = 15;
            this.buttonBransPaneli.Text = "Branş Paneli";
            this.buttonBransPaneli.UseVisualStyleBackColor = true;
            // 
            // buttonRandevu
            // 
            this.buttonRandevu.Location = new System.Drawing.Point(313, 23);
            this.buttonRandevu.Name = "buttonRandevu";
            this.buttonRandevu.Size = new System.Drawing.Size(150, 35);
            this.buttonRandevu.TabIndex = 16;
            this.buttonRandevu.Text = "Randevu Listesi";
            this.buttonRandevu.UseVisualStyleBackColor = true;
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(872, 398);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmSekreterDetay";
            this.Text = "FrmSekreterDetay";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonOlustur;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxRandevuDurum;
        private System.Windows.Forms.ComboBox comboBoxRandevuDoktor;
        private System.Windows.Forms.ComboBox comboBoxRandevuBrans;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRandevuTC;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRandevuSaat;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRandevuTarih;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxRandevuId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonGüncelle;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonRandevu;
        private System.Windows.Forms.Button buttonBransPaneli;
        private System.Windows.Forms.Button buttonDoktorPaneli;
    }
}