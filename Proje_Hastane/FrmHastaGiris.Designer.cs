
namespace Proje_Hastane
{
    partial class FrmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.buttongiris = new System.Windows.Forms.Button();
            this.üyeol = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.labeluyarı = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre: ";
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(149, 82);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(124, 24);
            this.MskTC.TabIndex = 2;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(149, 121);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(124, 24);
            this.txtsifre.TabIndex = 3;
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // buttongiris
            // 
            this.buttongiris.Location = new System.Drawing.Point(84, 151);
            this.buttongiris.Name = "buttongiris";
            this.buttongiris.Size = new System.Drawing.Size(124, 39);
            this.buttongiris.TabIndex = 4;
            this.buttongiris.Text = "Giriş Yap";
            this.buttongiris.UseVisualStyleBackColor = true;
            this.buttongiris.Click += new System.EventHandler(this.buttongiris_Click);
            // 
            // üyeol
            // 
            this.üyeol.AutoSize = true;
            this.üyeol.Location = new System.Drawing.Point(104, 241);
            this.üyeol.Name = "üyeol";
            this.üyeol.Size = new System.Drawing.Size(59, 18);
            this.üyeol.TabIndex = 5;
            this.üyeol.TabStop = true;
            this.üyeol.Text = "Üye Ol";
            this.üyeol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.üyeol_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(35, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hasta Giriş Paneli";
            // 
            // labeluyarı
            // 
            this.labeluyarı.AutoSize = true;
            this.labeluyarı.Location = new System.Drawing.Point(12, 206);
            this.labeluyarı.Name = "labeluyarı";
            this.labeluyarı.Size = new System.Drawing.Size(47, 18);
            this.labeluyarı.TabIndex = 7;
            this.labeluyarı.Text = "Uyarı";
            this.labeluyarı.Visible = false;
            // 
            // FrmHastaGiris
            // 
            this.AcceptButton = this.buttongiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(298, 278);
            this.Controls.Add(this.labeluyarı);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.üyeol);
            this.Controls.Add(this.buttongiris);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmHastaGiris";
            this.Text = "Hasta Girişi";
            this.Load += new System.EventHandler(this.FrmHastaGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button buttongiris;
        private System.Windows.Forms.LinkLabel üyeol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labeluyarı;
    }
}