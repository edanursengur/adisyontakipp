
namespace WindowsFormsApp1
{
    partial class SiparisAl
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
            this.btn1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvSiparis = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvMenu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.btnToplamHesapla = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.lblmasano = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSuluYemek = new System.Windows.Forms.Button();
            this.btnEtYemekleri = new System.Windows.Forms.Button();
            this.btnArasicak = new System.Windows.Forms.Button();
            this.btnSiparisAl = new System.Windows.Forms.Button();
            this.txtturu = new System.Windows.Forms.TextBox();
            this.txtadt = new System.Windows.Forms.TextBox();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.txtadi = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnmeyvelitatli = new System.Windows.Forms.Button();
            this.btnsutlutatli = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnsicakicecek = new System.Windows.Forms.Button();
            this.btnsogukicecek = new System.Windows.Forms.Button();
            this.txttoplamfiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn1.Location = new System.Drawing.Point(685, 94);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(64, 31);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvSiparis);
            this.groupBox3.Location = new System.Drawing.Point(491, 354);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(458, 248);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SİPARİŞLER";
            // 
            // lvSiparis
            // 
            this.lvSiparis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvSiparis.HideSelection = false;
            this.lvSiparis.Location = new System.Drawing.Point(6, 19);
            this.lvSiparis.Name = "lvSiparis";
            this.lvSiparis.Size = new System.Drawing.Size(443, 221);
            this.lvSiparis.TabIndex = 1;
            this.lvSiparis.UseCompatibleStateImageBehavior = false;
            this.lvSiparis.View = System.Windows.Forms.View.Details;
            this.lvSiparis.DoubleClick += new System.EventHandler(this.lvSiparis_DoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ADI";
            this.columnHeader5.Width = 109;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "TÜRÜ";
            this.columnHeader6.Width = 111;
            // 
            // columnHeader7
            // 
            this.columnHeader7.DisplayIndex = 3;
            this.columnHeader7.Text = "FİYATI";
            this.columnHeader7.Width = 109;
            // 
            // columnHeader8
            // 
            this.columnHeader8.DisplayIndex = 2;
            this.columnHeader8.Text = "ADET";
            this.columnHeader8.Width = 92;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvMenu);
            this.groupBox2.Location = new System.Drawing.Point(30, 354);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 248);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MENÜ";
            // 
            // lvMenu
            // 
            this.lvMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader9});
            this.lvMenu.HideSelection = false;
            this.lvMenu.Location = new System.Drawing.Point(6, 19);
            this.lvMenu.Name = "lvMenu";
            this.lvMenu.Size = new System.Drawing.Size(402, 221);
            this.lvMenu.TabIndex = 0;
            this.lvMenu.UseCompatibleStateImageBehavior = false;
            this.lvMenu.View = System.Windows.Forms.View.Details;
            this.lvMenu.DoubleClick += new System.EventHandler(this.lvMenu_DoubleClick);
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
            this.columnHeader4.Width = 66;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "adisyonid";
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn2.Location = new System.Drawing.Point(754, 94);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(61, 31);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn3.Location = new System.Drawing.Point(823, 95);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(61, 31);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn6.Location = new System.Drawing.Point(823, 132);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(61, 31);
            this.btn6.TabIndex = 17;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn5.Location = new System.Drawing.Point(754, 131);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(61, 31);
            this.btn5.TabIndex = 16;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn4.Location = new System.Drawing.Point(685, 131);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(64, 31);
            this.btn4.TabIndex = 15;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn9.Location = new System.Drawing.Point(823, 168);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(61, 31);
            this.btn9.TabIndex = 20;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn8.Location = new System.Drawing.Point(751, 168);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(64, 31);
            this.btn8.TabIndex = 19;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn7.Location = new System.Drawing.Point(685, 168);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(64, 31);
            this.btn7.TabIndex = 18;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(685, 205);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(130, 31);
            this.btnTemizle.TabIndex = 21;
            this.btnTemizle.Text = "C";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn0.Location = new System.Drawing.Point(824, 205);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(60, 31);
            this.btn0.TabIndex = 22;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(682, 59);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(199, 20);
            this.txtAdet.TabIndex = 23;
            // 
            // btnToplamHesapla
            // 
            this.btnToplamHesapla.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnToplamHesapla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnToplamHesapla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToplamHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToplamHesapla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnToplamHesapla.Location = new System.Drawing.Point(682, 246);
            this.btnToplamHesapla.Name = "btnToplamHesapla";
            this.btnToplamHesapla.Size = new System.Drawing.Size(92, 41);
            this.btnToplamHesapla.TabIndex = 24;
            this.btnToplamHesapla.Text = "TOPLAM FİYAT HESAPLA";
            this.btnToplamHesapla.UseVisualStyleBackColor = false;
            this.btnToplamHesapla.Click += new System.EventHandler(this.btnToplamHesapla_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnIptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIptal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIptal.Location = new System.Drawing.Point(682, 293);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(202, 41);
            this.btnIptal.TabIndex = 26;
            this.btnIptal.Text = "İPTAL ET";
            this.btnIptal.UseVisualStyleBackColor = false;
            // 
            // lblmasano
            // 
            this.lblmasano.AutoSize = true;
            this.lblmasano.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmasano.Location = new System.Drawing.Point(26, 19);
            this.lblmasano.Name = "lblmasano";
            this.lblmasano.Size = new System.Drawing.Size(85, 24);
            this.lblmasano.TabIndex = 28;
            this.lblmasano.Text = "MASA 1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSuluYemek);
            this.groupBox1.Controls.Add(this.btnEtYemekleri);
            this.groupBox1.Controls.Add(this.btnArasicak);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 177);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yemekler";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSuluYemek
            // 
            this.btnSuluYemek.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSuluYemek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuluYemek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuluYemek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuluYemek.Location = new System.Drawing.Point(6, 114);
            this.btnSuluYemek.Name = "btnSuluYemek";
            this.btnSuluYemek.Size = new System.Drawing.Size(173, 42);
            this.btnSuluYemek.TabIndex = 2;
            this.btnSuluYemek.Text = "SULU YEMEK";
            this.btnSuluYemek.UseVisualStyleBackColor = false;
            this.btnSuluYemek.Click += new System.EventHandler(this.btnSuluYemek_Click);
            // 
            // btnEtYemekleri
            // 
            this.btnEtYemekleri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEtYemekleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEtYemekleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEtYemekleri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEtYemekleri.Location = new System.Drawing.Point(6, 66);
            this.btnEtYemekleri.Name = "btnEtYemekleri";
            this.btnEtYemekleri.Size = new System.Drawing.Size(173, 42);
            this.btnEtYemekleri.TabIndex = 1;
            this.btnEtYemekleri.Text = "ET YEMEKLERİ";
            this.btnEtYemekleri.UseVisualStyleBackColor = false;
            this.btnEtYemekleri.Click += new System.EventHandler(this.btnEtYemekleri_Click);
            // 
            // btnArasicak
            // 
            this.btnArasicak.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnArasicak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArasicak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArasicak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArasicak.Location = new System.Drawing.Point(6, 18);
            this.btnArasicak.Name = "btnArasicak";
            this.btnArasicak.Size = new System.Drawing.Size(173, 42);
            this.btnArasicak.TabIndex = 3;
            this.btnArasicak.Text = "ARA SICAK";
            this.btnArasicak.UseVisualStyleBackColor = false;
            this.btnArasicak.Click += new System.EventHandler(this.btnArasicak_Click);
            // 
            // btnSiparisAl
            // 
            this.btnSiparisAl.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSiparisAl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiparisAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiparisAl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiparisAl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSiparisAl.Location = new System.Drawing.Point(792, 246);
            this.btnSiparisAl.Name = "btnSiparisAl";
            this.btnSiparisAl.Size = new System.Drawing.Size(92, 41);
            this.btnSiparisAl.TabIndex = 31;
            this.btnSiparisAl.Text = "SİPARİŞ ONAYLA";
            this.btnSiparisAl.UseVisualStyleBackColor = false;
            this.btnSiparisAl.Click += new System.EventHandler(this.btnSiparisAl_Click);
            // 
            // txtturu
            // 
            this.txtturu.Location = new System.Drawing.Point(667, -80);
            this.txtturu.Name = "txtturu";
            this.txtturu.Size = new System.Drawing.Size(113, 20);
            this.txtturu.TabIndex = 32;
            // 
            // txtadt
            // 
            this.txtadt.Location = new System.Drawing.Point(667, -28);
            this.txtadt.Name = "txtadt";
            this.txtadt.Size = new System.Drawing.Size(113, 20);
            this.txtadt.TabIndex = 32;
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(667, -54);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(113, 20);
            this.txtfiyat.TabIndex = 32;
            // 
            // txtadi
            // 
            this.txtadi.Location = new System.Drawing.Point(715, -47);
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(113, 20);
            this.txtadi.TabIndex = 32;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnmeyvelitatli);
            this.groupBox4.Controls.Add(this.btnsutlutatli);
            this.groupBox4.Location = new System.Drawing.Point(233, 58);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(187, 140);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tatlılar";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnmeyvelitatli
            // 
            this.btnmeyvelitatli.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnmeyvelitatli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmeyvelitatli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmeyvelitatli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmeyvelitatli.Location = new System.Drawing.Point(6, 66);
            this.btnmeyvelitatli.Name = "btnmeyvelitatli";
            this.btnmeyvelitatli.Size = new System.Drawing.Size(173, 42);
            this.btnmeyvelitatli.TabIndex = 1;
            this.btnmeyvelitatli.Text = "MEYVELİ TATLILAR";
            this.btnmeyvelitatli.UseVisualStyleBackColor = false;
            this.btnmeyvelitatli.Click += new System.EventHandler(this.btnmeyvelitatli_Click);
            // 
            // btnsutlutatli
            // 
            this.btnsutlutatli.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsutlutatli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsutlutatli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsutlutatli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsutlutatli.Location = new System.Drawing.Point(6, 18);
            this.btnsutlutatli.Name = "btnsutlutatli";
            this.btnsutlutatli.Size = new System.Drawing.Size(173, 42);
            this.btnsutlutatli.TabIndex = 3;
            this.btnsutlutatli.Text = "SÜTLÜ TATLILAR";
            this.btnsutlutatli.UseVisualStyleBackColor = false;
            this.btnsutlutatli.Click += new System.EventHandler(this.btnsutlutatli_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnsicakicecek);
            this.groupBox5.Controls.Add(this.btnsogukicecek);
            this.groupBox5.Location = new System.Drawing.Point(453, 59);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(187, 140);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "İçecekler";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnsicakicecek
            // 
            this.btnsicakicecek.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsicakicecek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsicakicecek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsicakicecek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsicakicecek.Location = new System.Drawing.Point(6, 66);
            this.btnsicakicecek.Name = "btnsicakicecek";
            this.btnsicakicecek.Size = new System.Drawing.Size(173, 42);
            this.btnsicakicecek.TabIndex = 1;
            this.btnsicakicecek.Text = "SICAK İÇECEKLER";
            this.btnsicakicecek.UseVisualStyleBackColor = false;
            this.btnsicakicecek.Click += new System.EventHandler(this.btnsicakicecek_Click);
            // 
            // btnsogukicecek
            // 
            this.btnsogukicecek.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsogukicecek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsogukicecek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsogukicecek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsogukicecek.Location = new System.Drawing.Point(6, 18);
            this.btnsogukicecek.Name = "btnsogukicecek";
            this.btnsogukicecek.Size = new System.Drawing.Size(173, 42);
            this.btnsogukicecek.TabIndex = 3;
            this.btnsogukicecek.Text = "SOĞUK İÇECEKLER";
            this.btnsogukicecek.UseVisualStyleBackColor = false;
            this.btnsogukicecek.Click += new System.EventHandler(this.btnsogukicecek_Click);
            // 
            // txttoplamfiyat
            // 
            this.txttoplamfiyat.Location = new System.Drawing.Point(603, 609);
            this.txttoplamfiyat.Name = "txttoplamfiyat";
            this.txttoplamfiyat.Size = new System.Drawing.Size(113, 20);
            this.txttoplamfiyat.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "TOPLAM HESAP:";
            // 
            // SiparisAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 735);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttoplamfiyat);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.txtadt);
            this.Controls.Add(this.txtturu);
            this.Controls.Add(this.txtadi);
            this.Controls.Add(this.btnSiparisAl);
            this.Controls.Add(this.lblmasano);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnToplamHesapla);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "SiparisAl";
            this.Text = "SiparisAl";
            this.Load += new System.EventHandler(this.SiparisAl_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvMenu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Button btnToplamHesapla;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label lblmasano;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnArasicak;
        private System.Windows.Forms.Button btnSuluYemek;
        private System.Windows.Forms.Button btnEtYemekleri;
        private System.Windows.Forms.ListView lvSiparis;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnSiparisAl;
        private System.Windows.Forms.TextBox txtturu;
        private System.Windows.Forms.TextBox txtadt;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TextBox txtadi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnmeyvelitatli;
        private System.Windows.Forms.Button btnsutlutatli;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnsicakicecek;
        private System.Windows.Forms.Button btnsogukicecek;
        private System.Windows.Forms.TextBox txttoplamfiyat;
        private System.Windows.Forms.Label label1;
    }
}
