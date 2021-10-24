
namespace WindowsFormsApp1
{
    partial class frm_menu
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
            this.btn_masa = new System.Windows.Forms.Button();
            this.btnMutfak = new System.Windows.Forms.Button();
            this.btnKasa = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_masa
            // 
            this.btn_masa.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_masa.Location = new System.Drawing.Point(32, 21);
            this.btn_masa.Name = "btn_masa";
            this.btn_masa.Size = new System.Drawing.Size(129, 97);
            this.btn_masa.TabIndex = 0;
            this.btn_masa.Text = "Masa Sipariş";
            this.btn_masa.UseVisualStyleBackColor = false;
            this.btn_masa.Click += new System.EventHandler(this.btn_masa_Click);
            // 
            // btnMutfak
            // 
            this.btnMutfak.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnMutfak.Location = new System.Drawing.Point(32, 135);
            this.btnMutfak.Name = "btnMutfak";
            this.btnMutfak.Size = new System.Drawing.Size(129, 97);
            this.btnMutfak.TabIndex = 1;
            this.btnMutfak.Text = "Mutfak";
            this.btnMutfak.UseVisualStyleBackColor = false;
            this.btnMutfak.Click += new System.EventHandler(this.btnMutfak_Click);
            // 
            // btnKasa
            // 
            this.btnKasa.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnKasa.Location = new System.Drawing.Point(167, 21);
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.Size = new System.Drawing.Size(129, 97);
            this.btnKasa.TabIndex = 2;
            this.btnKasa.Text = "Kasa";
            this.btnKasa.UseVisualStyleBackColor = false;
            this.btnKasa.Click += new System.EventHandler(this.btnKasa_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCikis.Location = new System.Drawing.Point(167, 135);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(129, 97);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnKasa);
            this.Controls.Add(this.btnMutfak);
            this.Controls.Add(this.btn_masa);
            this.Name = "frm_menu";
            this.Text = "frm_menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMutfak;
        private System.Windows.Forms.Button btnKasa;
        private System.Windows.Forms.Button btnCikis;
        public System.Windows.Forms.Button btn_masa;
    }
}