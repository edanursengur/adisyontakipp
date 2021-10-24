
namespace WindowsFormsApp1
{
    partial class StokBilgisi
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
            this.lblStokadedi = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStokadedi
            // 
            this.lblStokadedi.AutoSize = true;
            this.lblStokadedi.Location = new System.Drawing.Point(101, 40);
            this.lblStokadedi.Name = "lblStokadedi";
            this.lblStokadedi.Size = new System.Drawing.Size(12, 13);
            this.lblStokadedi.TabIndex = 0;
            this.lblStokadedi.Text = "s";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StokBilgisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblStokadedi);
            this.Name = "StokBilgisi";
            this.Text = "StokBilgisi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStokadedi;
        private System.Windows.Forms.Button button1;
    }
}