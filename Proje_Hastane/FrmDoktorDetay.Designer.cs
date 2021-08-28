
namespace Proje_Hastane
{
    partial class FrmDoktorDetay
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.richTextBoxduyuru = new System.Windows.Forms.RichTextBox();
            this.buttonBilgiDuzenle = new System.Windows.Forms.Button();
            this.buttonDuyurular = new System.Windows.Forms.Button();
            this.buttonİnternet = new System.Windows.Forms.Button();
            this.buttonCıkıs = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox1.Controls.Add(this.lbladsoyad);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 105);
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
            this.groupBox2.Controls.Add(this.richTextBoxduyuru);
            this.groupBox2.Location = new System.Drawing.Point(12, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 191);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(268, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(684, 415);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonCıkıs);
            this.groupBox4.Controls.Add(this.buttonİnternet);
            this.groupBox4.Controls.Add(this.buttonDuyurular);
            this.groupBox4.Controls.Add(this.buttonBilgiDuzenle);
            this.groupBox4.Location = new System.Drawing.Point(12, 320);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 107);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hızlı Erişim";
            // 
            // richTextBoxduyuru
            // 
            this.richTextBoxduyuru.Location = new System.Drawing.Point(9, 23);
            this.richTextBoxduyuru.Name = "richTextBoxduyuru";
            this.richTextBoxduyuru.Size = new System.Drawing.Size(235, 162);
            this.richTextBoxduyuru.TabIndex = 0;
            this.richTextBoxduyuru.Text = "";
            // 
            // buttonBilgiDuzenle
            // 
            this.buttonBilgiDuzenle.Location = new System.Drawing.Point(6, 32);
            this.buttonBilgiDuzenle.Name = "buttonBilgiDuzenle";
            this.buttonBilgiDuzenle.Size = new System.Drawing.Size(118, 32);
            this.buttonBilgiDuzenle.TabIndex = 0;
            this.buttonBilgiDuzenle.Text = "Bilgi Düzenle";
            this.buttonBilgiDuzenle.UseVisualStyleBackColor = true;
            // 
            // buttonDuyurular
            // 
            this.buttonDuyurular.Location = new System.Drawing.Point(126, 32);
            this.buttonDuyurular.Name = "buttonDuyurular";
            this.buttonDuyurular.Size = new System.Drawing.Size(118, 32);
            this.buttonDuyurular.TabIndex = 1;
            this.buttonDuyurular.Text = "Duyurular";
            this.buttonDuyurular.UseVisualStyleBackColor = true;
            // 
            // buttonİnternet
            // 
            this.buttonİnternet.Location = new System.Drawing.Point(6, 69);
            this.buttonİnternet.Name = "buttonİnternet";
            this.buttonİnternet.Size = new System.Drawing.Size(118, 32);
            this.buttonİnternet.TabIndex = 2;
            this.buttonİnternet.Text = "İnternet";
            this.buttonİnternet.UseVisualStyleBackColor = true;
            // 
            // buttonCıkıs
            // 
            this.buttonCıkıs.Location = new System.Drawing.Point(126, 69);
            this.buttonCıkıs.Name = "buttonCıkıs";
            this.buttonCıkıs.Size = new System.Drawing.Size(118, 32);
            this.buttonCıkıs.TabIndex = 3;
            this.buttonCıkıs.Text = "Çıkış";
            this.buttonCıkıs.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(678, 392);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(964, 435);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmDoktorDetay";
            this.Text = "FrmDoktorDetay";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBoxduyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonCıkıs;
        private System.Windows.Forms.Button buttonİnternet;
        private System.Windows.Forms.Button buttonDuyurular;
        private System.Windows.Forms.Button buttonBilgiDuzenle;
    }
}