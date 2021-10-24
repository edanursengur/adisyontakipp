
namespace WindowsFormsApp1
{
    partial class frm_siparis
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
            this.lblmasano = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIcecek = new System.Windows.Forms.Button();
            this.btnTatli = new System.Windows.Forms.Button();
            this.btnanayemek = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvMenu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSiparisFrm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblmasano
            // 
            this.lblmasano.AutoSize = true;
            this.lblmasano.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmasano.Location = new System.Drawing.Point(34, 33);
            this.lblmasano.Name = "lblmasano";
            this.lblmasano.Size = new System.Drawing.Size(85, 24);
            this.lblmasano.TabIndex = 0;
            this.lblmasano.Text = "MASA 1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIcecek);
            this.groupBox1.Controls.Add(this.btnTatli);
            this.groupBox1.Controls.Add(this.btnanayemek);
            this.groupBox1.Location = new System.Drawing.Point(38, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 222);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MENÜ";
            // 
            // btnIcecek
            // 
            this.btnIcecek.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIcecek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIcecek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIcecek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIcecek.Location = new System.Drawing.Point(6, 135);
            this.btnIcecek.Name = "btnIcecek";
            this.btnIcecek.Size = new System.Drawing.Size(194, 52);
            this.btnIcecek.TabIndex = 2;
            this.btnIcecek.Text = "İÇECEKLER";
            this.btnIcecek.UseVisualStyleBackColor = false;
            this.btnIcecek.Click += new System.EventHandler(this.btnIcecek_Click);
            // 
            // btnTatli
            // 
            this.btnTatli.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTatli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTatli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTatli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTatli.Location = new System.Drawing.Point(6, 77);
            this.btnTatli.Name = "btnTatli";
            this.btnTatli.Size = new System.Drawing.Size(194, 52);
            this.btnTatli.TabIndex = 1;
            this.btnTatli.Text = "TATLI";
            this.btnTatli.UseVisualStyleBackColor = false;
            this.btnTatli.Click += new System.EventHandler(this.btnTatli_Click);
            // 
            // btnanayemek
            // 
            this.btnanayemek.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnanayemek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnanayemek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnanayemek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnanayemek.Location = new System.Drawing.Point(6, 19);
            this.btnanayemek.Name = "btnanayemek";
            this.btnanayemek.Size = new System.Drawing.Size(194, 52);
            this.btnanayemek.TabIndex = 0;
            this.btnanayemek.Text = "ANA YEMEK";
            this.btnanayemek.UseVisualStyleBackColor = false;
            this.btnanayemek.Click += new System.EventHandler(this.btnanayemek_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvMenu);
            this.groupBox2.Location = new System.Drawing.Point(299, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 320);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MENÜ";
            // 
            // lvMenu
            // 
            this.lvMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvMenu.HideSelection = false;
            this.lvMenu.Location = new System.Drawing.Point(6, 19);
            this.lvMenu.Name = "lvMenu";
            this.lvMenu.Size = new System.Drawing.Size(451, 295);
            this.lvMenu.TabIndex = 0;
            this.lvMenu.UseCompatibleStateImageBehavior = false;
            this.lvMenu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ADI";
            this.columnHeader1.Width = 113;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FİYAT";
            this.columnHeader2.Width = 122;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "TÜRÜ";
            this.columnHeader3.Width = 93;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "STOK";
            // 
            // btnSiparisFrm
            // 
            this.btnSiparisFrm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSiparisFrm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiparisFrm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiparisFrm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiparisFrm.Location = new System.Drawing.Point(674, 375);
            this.btnSiparisFrm.Name = "btnSiparisFrm";
            this.btnSiparisFrm.Size = new System.Drawing.Size(194, 52);
            this.btnSiparisFrm.TabIndex = 1;
            this.btnSiparisFrm.Text = "SİPARİŞ SAYFASINA GİT";
            this.btnSiparisFrm.UseVisualStyleBackColor = false;
            this.btnSiparisFrm.Click += new System.EventHandler(this.btnSiparisFrm_Click);
            // 
            // frm_siparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.btnSiparisFrm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblmasano);
            this.Name = "frm_siparis";
            this.Text = "frm_siparis";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmasano;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIcecek;
        private System.Windows.Forms.Button btnTatli;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnanayemek;
        private System.Windows.Forms.ListView lvMenu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnSiparisFrm;
    }
}