namespace belge_durum_826
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
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.txtZayif = new System.Windows.Forms.TextBox();
            this.txtDevamsızlıksayısı = new System.Windows.Forms.TextBox();
            this.btnBelgeDurumuGöster = new System.Windows.Forms.Button();
            this.lblNotOrtalaması = new System.Windows.Forms.Label();
            this.lblZayif = new System.Windows.Forms.Label();
            this.lblDevamsizlik = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(167, 67);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(100, 20);
            this.txtOrtalama.TabIndex = 0;
            // 
            // txtZayif
            // 
            this.txtZayif.Location = new System.Drawing.Point(167, 93);
            this.txtZayif.Name = "txtZayif";
            this.txtZayif.Size = new System.Drawing.Size(100, 20);
            this.txtZayif.TabIndex = 1;
            // 
            // txtDevamsızlıksayısı
            // 
            this.txtDevamsızlıksayısı.Location = new System.Drawing.Point(167, 119);
            this.txtDevamsızlıksayısı.Name = "txtDevamsızlıksayısı";
            this.txtDevamsızlıksayısı.Size = new System.Drawing.Size(100, 20);
            this.txtDevamsızlıksayısı.TabIndex = 2;
            // 
            // btnBelgeDurumuGöster
            // 
            this.btnBelgeDurumuGöster.Location = new System.Drawing.Point(76, 145);
            this.btnBelgeDurumuGöster.Name = "btnBelgeDurumuGöster";
            this.btnBelgeDurumuGöster.Size = new System.Drawing.Size(225, 30);
            this.btnBelgeDurumuGöster.TabIndex = 3;
            this.btnBelgeDurumuGöster.Text = "Belge Durumu Göster";
            this.btnBelgeDurumuGöster.UseVisualStyleBackColor = true;
            this.btnBelgeDurumuGöster.Click += new System.EventHandler(this.btnBelgeDurumuGöster_Click);
            // 
            // lblNotOrtalaması
            // 
            this.lblNotOrtalaması.AutoSize = true;
            this.lblNotOrtalaması.Location = new System.Drawing.Point(84, 67);
            this.lblNotOrtalaması.Name = "lblNotOrtalaması";
            this.lblNotOrtalaması.Size = new System.Drawing.Size(77, 13);
            this.lblNotOrtalaması.TabIndex = 4;
            this.lblNotOrtalaması.Text = "Not ortalaması:";
            this.lblNotOrtalaması.Click += new System.EventHandler(this.lblNotOrtalaması_Click);
            // 
            // lblZayif
            // 
            this.lblZayif.AutoSize = true;
            this.lblZayif.Location = new System.Drawing.Point(84, 96);
            this.lblZayif.Name = "lblZayif";
            this.lblZayif.Size = new System.Drawing.Size(85, 13);
            this.lblZayif.TabIndex = 5;
            this.lblZayif.Text = "Zayıf Ortalaması:";
            // 
            // lblDevamsizlik
            // 
            this.lblDevamsizlik.AutoSize = true;
            this.lblDevamsizlik.Location = new System.Drawing.Point(73, 126);
            this.lblDevamsizlik.Name = "lblDevamsizlik";
            this.lblDevamsizlik.Size = new System.Drawing.Size(92, 13);
            this.lblDevamsizlik.TabIndex = 6;
            this.lblDevamsizlik.Text = "Devamsızlık sayıs:";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(73, 200);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(58, 18);
            this.lblDurum.TabIndex = 7;
            this.lblDurum.Text = "Durum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblDevamsizlik);
            this.Controls.Add(this.lblZayif);
            this.Controls.Add(this.lblNotOrtalaması);
            this.Controls.Add(this.btnBelgeDurumuGöster);
            this.Controls.Add(this.txtDevamsızlıksayısı);
            this.Controls.Add(this.txtZayif);
            this.Controls.Add(this.txtOrtalama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.TextBox txtZayif;
        private System.Windows.Forms.TextBox txtDevamsızlıksayısı;
        private System.Windows.Forms.Button btnBelgeDurumuGöster;
        private System.Windows.Forms.Label lblNotOrtalaması;
        private System.Windows.Forms.Label lblZayif;
        private System.Windows.Forms.Label lblDevamsizlik;
        private System.Windows.Forms.Label lblDurum;
    }
}

