
namespace WindowsFormsApp1
{
    partial class frmMasalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasalar));
            this.geridon = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.masa3 = new System.Windows.Forms.Button();
            this.masa6 = new System.Windows.Forms.Button();
            this.masa5 = new System.Windows.Forms.Button();
            this.masa4 = new System.Windows.Forms.Button();
            this.masa2 = new System.Windows.Forms.Button();
            this.masa1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // geridon
            // 
            this.geridon.Location = new System.Drawing.Point(28, 319);
            this.geridon.Name = "geridon";
            this.geridon.Size = new System.Drawing.Size(112, 66);
            this.geridon.TabIndex = 6;
            this.geridon.Text = "Geri Dön";
            this.geridon.UseVisualStyleBackColor = true;
            this.geridon.Click += new System.EventHandler(this.geridon_Click);
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(158, 319);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(112, 66);
            this.cikis.TabIndex = 7;
            this.cikis.Text = "Çıkış Yap";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Image = global::WindowsFormsApp1.Properties.Resources.indir;
            this.label1.Location = new System.Drawing.Point(516, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "DOLU";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Image = global::WindowsFormsApp1.Properties.Resources.indir__1_;
            this.label2.Location = new System.Drawing.Point(516, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "BOŞ";
            // 
            // masa3
            // 
            this.masa3.Image = global::WindowsFormsApp1.Properties.Resources.indir;
            this.masa3.Location = new System.Drawing.Point(408, 12);
            this.masa3.Name = "masa3";
            this.masa3.Size = new System.Drawing.Size(192, 118);
            this.masa3.TabIndex = 8;
            this.masa3.Text = "Masa 3";
            this.masa3.UseVisualStyleBackColor = true;
            this.masa3.Click += new System.EventHandler(this.masa3_Click);
            // 
            // masa6
            // 
            this.masa6.Image = global::WindowsFormsApp1.Properties.Resources.indir;
            this.masa6.Location = new System.Drawing.Point(408, 136);
            this.masa6.Name = "masa6";
            this.masa6.Size = new System.Drawing.Size(192, 118);
            this.masa6.TabIndex = 5;
            this.masa6.Text = "Masa 6";
            this.masa6.UseVisualStyleBackColor = true;
            this.masa6.Click += new System.EventHandler(this.masa6_Click);
            // 
            // masa5
            // 
            this.masa5.Image = global::WindowsFormsApp1.Properties.Resources.indir;
            this.masa5.Location = new System.Drawing.Point(210, 136);
            this.masa5.Name = "masa5";
            this.masa5.Size = new System.Drawing.Size(192, 118);
            this.masa5.TabIndex = 4;
            this.masa5.Text = "Masa 5";
            this.masa5.UseVisualStyleBackColor = true;
            this.masa5.Click += new System.EventHandler(this.masa5_Click);
            // 
            // masa4
            // 
            this.masa4.Image = global::WindowsFormsApp1.Properties.Resources.indir;
            this.masa4.Location = new System.Drawing.Point(12, 136);
            this.masa4.Name = "masa4";
            this.masa4.Size = new System.Drawing.Size(192, 118);
            this.masa4.TabIndex = 3;
            this.masa4.Text = "Masa 4";
            this.masa4.UseVisualStyleBackColor = true;
            this.masa4.Click += new System.EventHandler(this.masa4_Click);
            // 
            // masa2
            // 
            this.masa2.Image = ((System.Drawing.Image)(resources.GetObject("masa2.Image")));
            this.masa2.Location = new System.Drawing.Point(210, 12);
            this.masa2.Name = "masa2";
            this.masa2.Size = new System.Drawing.Size(192, 118);
            this.masa2.TabIndex = 1;
            this.masa2.Text = "Masa 2";
            this.masa2.UseVisualStyleBackColor = true;
            this.masa2.Click += new System.EventHandler(this.masa2_Click);
            // 
            // masa1
            // 
            this.masa1.Image = ((System.Drawing.Image)(resources.GetObject("masa1.Image")));
            this.masa1.Location = new System.Drawing.Point(12, 12);
            this.masa1.Name = "masa1";
            this.masa1.Size = new System.Drawing.Size(192, 118);
            this.masa1.TabIndex = 0;
            this.masa1.Text = "Masa1";
            this.masa1.UseVisualStyleBackColor = true;
            this.masa1.Click += new System.EventHandler(this.masa1_Click);
            // 
            // frmMasalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.masa3);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.geridon);
            this.Controls.Add(this.masa6);
            this.Controls.Add(this.masa5);
            this.Controls.Add(this.masa4);
            this.Controls.Add(this.masa2);
            this.Controls.Add(this.masa1);
            this.Name = "frmMasalar";
            this.Text = "frmMasalar";
            this.Load += new System.EventHandler(this.frmMasalar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button masa1;
        private System.Windows.Forms.Button masa2;
        private System.Windows.Forms.Button masa4;
        private System.Windows.Forms.Button masa5;
        private System.Windows.Forms.Button masa6;
        private System.Windows.Forms.Button geridon;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Button masa3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}