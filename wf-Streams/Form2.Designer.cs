namespace wf_Streams
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSatir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMetin = new System.Windows.Forms.RichTextBox();
            this.btnYaz = new System.Windows.Forms.Button();
            this.btnOku = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnHepsiniOku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yeni Satır";
            // 
            // txtSatir
            // 
            this.txtSatir.Location = new System.Drawing.Point(176, 63);
            this.txtSatir.Name = "txtSatir";
            this.txtSatir.Size = new System.Drawing.Size(322, 26);
            this.txtSatir.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Metin";
            // 
            // txtMetin
            // 
            this.txtMetin.Location = new System.Drawing.Point(176, 173);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(322, 240);
            this.txtMetin.TabIndex = 3;
            this.txtMetin.Text = "";
            // 
            // btnYaz
            // 
            this.btnYaz.Location = new System.Drawing.Point(185, 113);
            this.btnYaz.Name = "btnYaz";
            this.btnYaz.Size = new System.Drawing.Size(58, 36);
            this.btnYaz.TabIndex = 4;
            this.btnYaz.Text = "Yaz";
            this.btnYaz.UseVisualStyleBackColor = true;
            this.btnYaz.Click += new System.EventHandler(this.btnYaz_Click);
            // 
            // btnOku
            // 
            this.btnOku.Location = new System.Drawing.Point(249, 113);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(58, 36);
            this.btnOku.TabIndex = 5;
            this.btnOku.Text = "Oku";
            this.btnOku.UseVisualStyleBackColor = true;
            this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(313, 113);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(58, 36);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnHepsiniOku
            // 
            this.btnHepsiniOku.Location = new System.Drawing.Point(377, 113);
            this.btnHepsiniOku.Name = "btnHepsiniOku";
            this.btnHepsiniOku.Size = new System.Drawing.Size(103, 36);
            this.btnHepsiniOku.TabIndex = 7;
            this.btnHepsiniOku.Text = "Hepsini Oku";
            this.btnHepsiniOku.UseVisualStyleBackColor = true;
            this.btnHepsiniOku.Click += new System.EventHandler(this.btnHepsiniOku_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(619, 490);
            this.Controls.Add(this.btnHepsiniOku);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnOku);
            this.Controls.Add(this.btnYaz);
            this.Controls.Add(this.txtMetin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSatir);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSatir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtMetin;
        private System.Windows.Forms.Button btnYaz;
        private System.Windows.Forms.Button btnOku;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnHepsiniOku;
    }
}