
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxsikayet = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonCıkıs = new System.Windows.Forms.Button();
            this.buttonİnternet = new System.Windows.Forms.Button();
            this.buttonDuyurular = new System.Windows.Forms.Button();
            this.buttonBilgiDuzenle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
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
            this.groupBox2.Controls.Add(this.richTextBoxsikayet);
            this.groupBox2.Location = new System.Drawing.Point(12, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 191);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // richTextBoxsikayet
            // 
            this.richTextBoxsikayet.Location = new System.Drawing.Point(9, 23);
            this.richTextBoxsikayet.Name = "richTextBoxsikayet";
            this.richTextBoxsikayet.Size = new System.Drawing.Size(235, 162);
            this.richTextBoxsikayet.TabIndex = 0;
            this.richTextBoxsikayet.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(268, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(818, 415);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(812, 392);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // buttonCıkıs
            // 
            this.buttonCıkıs.Location = new System.Drawing.Point(126, 69);
            this.buttonCıkıs.Name = "buttonCıkıs";
            this.buttonCıkıs.Size = new System.Drawing.Size(118, 32);
            this.buttonCıkıs.TabIndex = 3;
            this.buttonCıkıs.Text = "Çıkış";
            this.buttonCıkıs.UseVisualStyleBackColor = true;
            this.buttonCıkıs.Click += new System.EventHandler(this.buttonCıkıs_Click);
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
            // buttonDuyurular
            // 
            this.buttonDuyurular.Location = new System.Drawing.Point(126, 32);
            this.buttonDuyurular.Name = "buttonDuyurular";
            this.buttonDuyurular.Size = new System.Drawing.Size(118, 32);
            this.buttonDuyurular.TabIndex = 1;
            this.buttonDuyurular.Text = "Duyurular";
            this.buttonDuyurular.UseVisualStyleBackColor = true;
            this.buttonDuyurular.Click += new System.EventHandler(this.buttonDuyurular_Click);
            // 
            // buttonBilgiDuzenle
            // 
            this.buttonBilgiDuzenle.Location = new System.Drawing.Point(6, 32);
            this.buttonBilgiDuzenle.Name = "buttonBilgiDuzenle";
            this.buttonBilgiDuzenle.Size = new System.Drawing.Size(118, 32);
            this.buttonBilgiDuzenle.TabIndex = 0;
            this.buttonBilgiDuzenle.Text = "Bilgi Düzenle";
            this.buttonBilgiDuzenle.UseVisualStyleBackColor = true;
            this.buttonBilgiDuzenle.Click += new System.EventHandler(this.buttonBilgiDuzenle_Click);
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1090, 435);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorDetay";
            this.Text = "FrmDoktorDetay";
            this.Load += new System.EventHandler(this.FrmDoktorDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBoxsikayet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonCıkıs;
        private System.Windows.Forms.Button buttonİnternet;
        private System.Windows.Forms.Button buttonDuyurular;
        private System.Windows.Forms.Button buttonBilgiDuzenle;
    }
}